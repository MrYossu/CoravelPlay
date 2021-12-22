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
      int hash = GetHashCode();
      Widget w = broadcasted.Widget;
      Widgets.Add(w);
      _n++;
      await Task.CompletedTask;
    }

    public void AddNewWidget(Widget w) {
      int hash = GetHashCode();
      Widgets.Add(w);
      StateHasChanged();
    }
  }
}