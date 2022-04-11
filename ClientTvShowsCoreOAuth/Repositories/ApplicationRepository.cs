using ClientTvShowsCoreOAuth.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClientTvShowsCoreOAuth.Repositories
{
    public class ApplicationRepository
    {
        private string url;
        private MediaTypeWithQualityHeaderValue header;

        public ApplicationRepository()
        {
            //this.url = "https://localhost:44304/";
            this.url = "https://apitvshowsborja.azurewebsites.net/";
            this.header = new MediaTypeWithQualityHeaderValue("application/json");
        }

        // Método para validar usuarios; devuelve un Token
        public async Task<string> GetToken(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);

                // Creamos el modelo Login para el API
                LoginModel login = new LoginModel
                {
                    UserName = username,
                    Password = password
                };

                // Convertimos a JSON para el servicio API
                string json = JsonConvert.SerializeObject(login);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                string request = "Auth/Login";
                HttpResponseMessage response = await client.PostAsync(request, content);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    JObject jobject = JObject.Parse(data);
                    string token = jobject.GetValue("response").ToString();

                    return token;
                }
                else
                {
                    return null;
                }
            }
        }

        // Método para resolver las peticiones API sin Token
        public async Task<T> CallApi<T>(string request)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);

                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    T data = await response.Content.ReadAsAsync<T>();
                    return (T)Convert.ChangeType(data, typeof(T));
                }
                else
                {
                    return default(T);
                }
            }
        }

        // Método para resolver las peticiones API con Token
        public async Task<T> CallApi<T>(string request, string token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + token);

                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    T data = await response.Content.ReadAsAsync<T>();
                    return (T)Convert.ChangeType(data, typeof(T));
                }
                else
                {
                    return default(T);
                }
            }
        }

        // Métodos para peticiones API y nuestra App Client MVC
        public async Task<Usuario> PerfilUsuario(string token)
        {
            // Con seguridad
            Usuario usuario =
                await this.CallApi<Usuario>("api/Usuarios/PerfilUsuario", token);

            return usuario;
        }

        // TV SHOWS
        public async Task<List<Serie>> GetSeries()
        {
            List<Serie> series =
                await this.CallApi<List<Serie>>("api/Series");

            return series;
        }

        public async Task<Serie> GetSerie(int idserie)
        {
            Serie serie =
                await this.CallApi<Serie>("api/Series/" + idserie);

            return serie;
        }

        // PERSONAJES
        public async Task<List<Personaje>> GetPersonajes()
        {
            List<Personaje> personajes =
                await this.CallApi<List<Personaje>>("api/Personajes");

            return personajes;
        }

        public async Task<Personaje> GetPersonaje(int idpersonaje)
        {
            Personaje personaje =
                await this.CallApi<Personaje>("api/Personajes/" + idpersonaje);

            return personaje;
        }

        public async Task<List<Personaje>> GetPersonajeBySerie(int idserie)
        {
            List<Personaje> personajes =
                await this.CallApi<List<Personaje>>("api/Personajes/BySerie/" + idserie);

            return personajes;
        }

        public async Task<Personaje> AddPersonaje(Personaje personaje, string token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + token);

                HttpResponseMessage response =
                    await client.PostAsJsonAsync("api/Personajes", personaje);
            }
            // Return URI of the created resource
            return null;
        }

        public async Task<Personaje> UpdatePersonaje(Personaje personaje, string token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + token);

                HttpResponseMessage response =
                    await client.PutAsJsonAsync("api/Personajes", personaje);
            }
            // Return URI of the created resource
            return null;
        }
    }
}
