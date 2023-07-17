// 前提条件：WPF アプリケーションのプロジェクトを作成する

using System.ComponentModel;

namespace TodoList
{
    public partial class MainWindow : Window
    {
        private BindingList<TodoElement> todoList = new BindingList<TodoElement>();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void SetBindingList(object sender, RoutedEventArgs e)
        {
            TodoList.ItemsSource = todoList;
        }
        public void AddTodoList(object sender, RoutedEventArgs e)
        {
            todoList.Add(new TodoElement(TodoText.Text, false));
        }
        public void DeleteTodoList(object sender, RoutedEventArgs e)
        {
            BindingList<TodoElement> ListTmp = new BindingList<TodoElement>();
            foreach (TodoElement element in todoList)
            {
                ListTmp.Add(element);
            }
            foreach (TodoElement element in ListTmp)
            {
                if (element.DoneFlg) todoList.Remove(element);
            }
        }
    }
}