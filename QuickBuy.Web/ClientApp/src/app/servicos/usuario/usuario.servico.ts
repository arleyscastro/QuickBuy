import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from "../../modelo/usuario.model";

@Injectable({
  providedIn: "root"
})
export class UsuarioServico {

  private baseUrl: String;

  constructor(private http: HttpClient, @Inject('BASE URL') baseUrl: String) {
    this.baseUrl = baseUrl;
  }

  public verificarUsuario(usuario: Usuario): Observable<Usuario> {
    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      email: usuario.email,
      senha: usuario.senha
    }
    this.http.post<Usuario>(this.baseUrl + "api/usuario", body, { headers });
  }
}
