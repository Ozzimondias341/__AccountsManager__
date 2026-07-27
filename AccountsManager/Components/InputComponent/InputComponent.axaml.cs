using System;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace AccountsManager.Components;

public partial class InputComponent : UserControl
{
    public static readonly StyledProperty<string> LabelTextProperty =
        AvaloniaProperty.Register<InputComponent, string>(nameof(LabelText));

    public string LabelText
    {
        get => GetValue(LabelTextProperty);
        set => SetValue(LabelTextProperty, value);
    }

    public static readonly StyledProperty<Geometry?> LabelIconProperty =
        AvaloniaProperty.Register<InputComponent, Geometry?>(nameof(LabelIcon));

    public Geometry? LabelIcon
    {
        get => GetValue(LabelIconProperty);
        set => SetValue(LabelIconProperty, value);
    }

    public static readonly StyledProperty<string?> ValueProperty =
        AvaloniaProperty.Register<InputComponent, string?>(nameof(Value));

    public string? Value
    {
        get => GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public static readonly StyledProperty<string?> PlaceholderProperty =
        AvaloniaProperty.Register<InputComponent, string?>(nameof(Placeholder));

    public string? Placeholder
    {
        get => GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public static readonly StyledProperty<bool> IsReadOnlyProperty =
        AvaloniaProperty.Register<InputComponent, bool>(nameof(IsReadOnly));

    public bool IsReadOnly
    {
        get => GetValue(IsReadOnlyProperty);
        set => SetValue(IsReadOnlyProperty, value);
    }

    public static new readonly RoutedEvent<RoutedEventArgs> TextInputEvent =
        RoutedEvent.Register<InputComponent, RoutedEventArgs>(nameof(TextInput), RoutingStrategies.Direct);

    public new event EventHandler<RoutedEventArgs> TextInput
    {
        add => AddHandler(TextInputEvent, value);
        remove => RemoveHandler(TextInputEvent, value);
    }

    private void OnTextInput(object? sender, TextInputEventArgs e)
    {
        var args = new RoutedEventArgs(TextInputEvent);
        RaiseEvent(args);
    }

    public InputComponent()
    {
        InitializeComponent();
    }
}