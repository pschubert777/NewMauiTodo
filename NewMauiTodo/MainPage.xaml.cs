using NewMauiTodo.Models;
using System.Collections.ObjectModel;

namespace NewMauiTodo;

public partial class MainPage : ContentPage
{
    string _todoListData = string.Empty;


    public ObservableCollection<TodoItem> Todos { get; set; } = new();

    public MainPage()
    {
        InitializeComponent();

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await Initialize();
    }

    private async Task Initialize()
    {
        Todos.Add(new TodoItem
        {
            Id = Guid.NewGuid(),
            Done = true,
            Due = DateTime.Parse("12/30/22"),
            Title = "test"
        });


        Todos.Add(new TodoItem
        {
            Id = Guid.NewGuid(),
            Done = true,
            Due = DateTime.Parse("6/15/22"),
            Title = "test"
        });

        Todos.Add(new TodoItem
        {
            Id = Guid.NewGuid(),
            Done = true,
            Due = DateTime.Parse("9/4/22"),
            Title = "test"
        });


    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var todo = new TodoItem
        {
            Id = Guid.NewGuid(),
            Due = DueDatePicker.Date,
            Title = TodoTitleEntry.Text
        };

        Todos.Add(todo);

        TodoTitleEntry.Text = string.Empty;
        DueDatePicker.Date = DateTime.Now;
    }
}


