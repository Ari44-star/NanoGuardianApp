using CommunityToolkit.Mvvm.ComponentModel;
using NanoGuardian.App.Models;

namespace NanoGuardian.App.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    // Añadimos el "?" para que deje de marcar error de "non-nullable"
    [ObservableProperty]
    private Alerta? alertaActual; 

    public DashboardViewModel()
    {
        // La propiedad con A mayúscula la genera el Toolkit automáticamente
        AlertaActual = new Alerta
        {
            Paciente = "Juan Hernandez",
            FuerzaImpactoG = 4,
            Estado = "Monitoreando..." 
        };
    }
}