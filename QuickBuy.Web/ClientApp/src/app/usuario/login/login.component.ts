import { Component, OnInit } from '@angular/core';
import { Usuario } from "../../modelo/usuario.model";
import { Router, ActivatedRoute } from "@angular/router";
import Usuarioservico = require("../../servicos/usuario/usuario.servico");
import UsuarioServico = Usuarioservico.UsuarioServico;

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: [
    "./login.component.css"
    ]
})
export class LoginComponent implements OnInit{
  public usuario;
  public returnUrl: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }

  entrar() {

  }
  
}
