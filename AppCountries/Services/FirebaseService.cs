using Microsoft.JSInterop;
using System.Threading.Tasks;

public class FirebaseService
{
    private readonly IJSRuntime _jsRuntime;

    public FirebaseService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    // Método para iniciar sesión con email y contraseña
    public async Task<string> LoginWithEmailPasswordAsync(string email, string password)
    {
        return await _jsRuntime.InvokeAsync<string>("loginWithEmailPassword", email, password);
    }

    // Método para registrar un nuevo usuario
    public async Task<string> RegisterUserAsync(string email, string password, string nombre, string apellido, string continente)
    {
        return await _jsRuntime.InvokeAsync<string>("registerUser", email, password, nombre, apellido, continente);
    }

    // Método para obtener un documento por ID
    public async Task<string> GetDocumentByIdAsync(string documentId)
    {
        return await _jsRuntime.InvokeAsync<string>("getDocumentById", documentId);
    }
}
