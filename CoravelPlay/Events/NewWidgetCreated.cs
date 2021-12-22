using Coravel.Events.Interfaces;
using CoravelPlay.Data;

namespace CoravelPlay.Events {
  public class NewWidgetCreated : IEvent {
    public Widget Widget { get; set; }

    public NewWidgetCreated(Widget widget) =>
      Widget = widget;
  }
}