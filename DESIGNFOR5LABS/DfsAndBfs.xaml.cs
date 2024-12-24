using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;
using System.Linq;

namespace DESIGNFOR5LABS
{
    public partial class DfsAndBfs : Page
    {
        private enum Mode
        {
            None,
            AddNode,
            AddEdge,
            Delete
        }

        private Mode _currentMode = Mode.None;
        private List<Ellipse> nodes = new List<Ellipse>();
        private List<Line> edges = new List<Line>();
        private Ellipse selectedNode;
        private bool isOrientedGraph = false;

        public DfsAndBfs()
        {
            InitializeComponent();
        }

        // Обработчик для кнопки "Добавить вершину"
        private void SetAddNodesModeButton_Click(object sender, RoutedEventArgs e)
        {
            _currentMode = Mode.AddNode;
        }

        // Обработчик для кнопки "Добавить связи"
        private void SetAddEdgesModeButton_Click(object sender, RoutedEventArgs e)
        {
            _currentMode = Mode.AddEdge;
        }

        // Обработчик для кнопки "Удалить"
        private void SetDeletingModeButton_Click(object sender, RoutedEventArgs e)
        {
            _currentMode = Mode.Delete;
        }

        // Обработчик клика на канву
        private void GraphCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_currentMode == Mode.AddNode)
            {
                var position = e.GetPosition(GraphCanvas);
                AddNode(position);
            }
            else if (_currentMode == Mode.AddEdge && selectedNode != null)
            {
                var position = e.GetPosition(GraphCanvas);
                AddEdge(selectedNode, position);
            }
            else if (_currentMode == Mode.Delete)
            {
                var position = e.GetPosition(GraphCanvas);
                DeleteElementAt(position);
            }
        }

        // Добавить вершину
        private void AddNode(Point position)
        {
            var node = new Ellipse
            {
                Width = 30,
                Height = 30,
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            Canvas.SetLeft(node, position.X - node.Width / 2);
            Canvas.SetTop(node, position.Y - node.Height / 2);
            GraphCanvas.Children.Add(node);
            nodes.Add(node);

            node.MouseLeftButtonDown += (s, e) =>
            {
                selectedNode = (Ellipse)s;
            };
        }

        // Добавить связь (ребро)
        private void AddEdge(Ellipse startNode, Point endPosition)
        {
            var edge = new Line
            {
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            var startPosition = new Point(Canvas.GetLeft(startNode) + startNode.Width / 2, Canvas.GetTop(startNode) + startNode.Height / 2);
            edge.X1 = startPosition.X;
            edge.Y1 = startPosition.Y;
            edge.X2 = endPosition.X;
            edge.Y2 = endPosition.Y;

            GraphCanvas.Children.Add(edge);
            edges.Add(edge);

            if (isOrientedGraph)
            {
                AddArrowhead(edge);
            }
        }

        // Добавить стрелку на ребре для ориентированного графа
        private void AddArrowhead(Line edge)
        {
            var arrowSize = 10;
            var arrow = new Polygon
            {
                Points = new PointCollection
                {
                    new Point(edge.X2, edge.Y2),
                    new Point(edge.X2 - arrowSize, edge.Y2 - arrowSize),
                    new Point(edge.X2 - arrowSize, edge.Y2 + arrowSize)
                },
                Fill = Brushes.Black
            };
            GraphCanvas.Children.Add(arrow);
        }

        // Удалить элемент по клику
        private void DeleteElementAt(Point position)
        {
            foreach (var node in nodes)
            {
                var nodePosition = new Point(Canvas.GetLeft(node) + node.Width / 2, Canvas.GetTop(node) + node.Height / 2);
                if (Math.Abs(nodePosition.X - position.X) < node.Width / 2 && Math.Abs(nodePosition.Y - position.Y) < node.Height / 2)
                {
                    GraphCanvas.Children.Remove(node);
                    nodes.Remove(node);
                    return;
                }
            }

            foreach (var edge in edges)
            {
                var edgeStart = new Point(edge.X1, edge.Y1);
                var edgeEnd = new Point(edge.X2, edge.Y2);
                if (IsNearPoint(edgeStart, position) || IsNearPoint(edgeEnd, position))
                {
                    GraphCanvas.Children.Remove(edge);
                    edges.Remove(edge);
                    return;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFRame2.Navigate(new Uri("Menu1.xaml", UriKind.Relative));

        }

        // Проверить, находится ли точка близко к линии
        private bool IsNearPoint(Point edgePoint, Point clickPoint)
        {
            return Math.Abs(edgePoint.X - clickPoint.X) < 10 && Math.Abs(edgePoint.Y - clickPoint.Y) < 10;
        }

        // Обход в ширину
        private void BFSButton_Click(object sender, RoutedEventArgs e)
        {
            var visited = new HashSet<Ellipse>();
            var queue = new Queue<Ellipse>();

            if (nodes.Count > 0)
            {
                var startNode = nodes[0];
                queue.Enqueue(startNode);
                visited.Add(startNode);

                while (queue.Count > 0)
                {
                    var currentNode = queue.Dequeue();
                    // Здесь можно добавить логику для выделения текущего узла
                    LogStep($"Посетили вершину {nodes.IndexOf(currentNode)}");

                    // Добавить соседей в очередь
                    foreach (var edge in edges)
                    {
                        var adjacentNode = GetAdjacentNode(edge, currentNode);
                        if (adjacentNode != null && !visited.Contains(adjacentNode))
                        {
                            visited.Add(adjacentNode);
                            queue.Enqueue(adjacentNode);
                        }
                    }
                }
            }
        }

        // Обход в глубину
        private void DFSButton_Click(object sender, RoutedEventArgs e)
        {
            var visited = new HashSet<Ellipse>();
            var stack = new Stack<Ellipse>();

            if (nodes.Count > 0)
            {
                var startNode = nodes[0];
                stack.Push(startNode);
                visited.Add(startNode);

                while (stack.Count > 0)
                {
                    var currentNode = stack.Pop();
                    // Здесь можно добавить логику для выделения текущего узла
                    LogStep($"Посетили вершину {nodes.IndexOf(currentNode)}");

                    // Добавить соседей в стек
                    foreach (var edge in edges)
                    {
                        var adjacentNode = GetAdjacentNode(edge, currentNode);
                        if (adjacentNode != null && !visited.Contains(adjacentNode))
                        {
                            visited.Add(adjacentNode);
                            stack.Push(adjacentNode);
                        }
                    }
                }
            }
        }

        // Получить соседнюю вершину из ребра
        private Ellipse GetAdjacentNode(Line edge, Ellipse node)
        {
            var startPosition = new Point(edge.X1, edge.Y1);
            var endPosition = new Point(edge.X2, edge.Y2);

            if (Math.Abs(Canvas.GetLeft(node) + node.Width / 2 - startPosition.X) < 10 && Math.Abs(Canvas.GetTop(node) + node.Height / 2 - startPosition.Y) < 10)
            {
                return nodes.FirstOrDefault(n => Canvas.GetLeft(n) + n.Width / 2 == endPosition.X && Canvas.GetTop(n) + n.Height / 2 == endPosition.Y);
            }

            if (Math.Abs(Canvas.GetLeft(node) + node.Width / 2 - endPosition.X) < 10 && Math.Abs(Canvas.GetTop(node) + node.Height / 2 - endPosition.Y) < 10)
            {
                return nodes.FirstOrDefault(n => Canvas.GetLeft(n) + n.Width / 2 == startPosition.X && Canvas.GetTop(n) + n.Height / 2 == startPosition.Y);
            }

            return null;
        }

        // Логирование шага обхода
        private void LogStep(string message)
        {
            TextBlockWithExplanation.Text += message + Environment.NewLine;
        }

        // Кнопка для сбора графа (обход всех вершин и рёбер)
        private void CollectGraphButton_Click(object sender, RoutedEventArgs e)
        {
            LogStep("Начинаем обход графа...");
            BFSButton_Click(sender, e); // Используйте BFS или DFS для обхода
        }
    }
}
