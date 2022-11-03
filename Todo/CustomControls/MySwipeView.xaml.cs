namespace Todo.CustomControls;

public partial class MySwipeView : SwipeView
{
    public MySwipeView()
    {
        InitializeComponent();
        //label.BindingContext = slider;
        //label.SetBinding(Label.RotationProperty, nameof(slider.Value));
        //label.SetBinding(Label.RotationProperty, new Binding { Path = nameof(slider.Value), Source = slider });
    }
}