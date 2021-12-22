using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Coravel.Events.Interfaces;
using CoravelPlay.Data;
using CoravelPlay.Events;

namespace CoravelPlay.Pages {
  public partial class WidgetList : IListener<NewWidgetCreated> {
    private ObservableCollection<Widget> Widgets { get; set; } = new() { new Widget { Name = "Initial" } };
    private int _n;
    public async Task HandleAsync(NewWidgetCreated broadcasted) {
      Widget w = broadcasted.Widget;
      Widgets.Add(w);
      _n++;
      await Task.CompletedTask;
    }
  }
}