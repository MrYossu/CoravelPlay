using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Coravel.Events.Interfaces;
using CoravelPlay.Data;
using CoravelPlay.Events;

namespace CoravelPlay.Pages {
  public partial class WidgetList : IListener<NewWidgetCreated> {
    private readonly List<Widget> _widgets = new() { new Widget { Date = DateTime.Now, Name = "Initial" } };

    public Task HandleAsync(NewWidgetCreated broadcasted) {
      _widgets.Add(broadcasted.Widget);
      return Task.CompletedTask;
    }
  }
}