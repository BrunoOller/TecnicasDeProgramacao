<?php
    require_once "Models/Usuario.class.php";

    class UsuarioController {
        public function login() {
            
            // Require Views Formulário
            if ($_POST) {
                // Verificar os dados
                // Verificar no banco de dados se existe esse usuário
            }
        }

        public function inserir() {
            $msg = array("","","","");
            $erro = false;

            if($_POST) {
                if(empty($_POST["nome"])) {
                    $msg[0] = "Preencha o nome";
                    $erro = true;
                }

                if(empty($_POST["email"])) {
                    $msg[1] = "Preencha o email";
                    $erro = true;
                } else {
                    // Verificar se já não tem um usuário com esse email cadastrado
                    $usuario = new Usuario(email: 
                    $_POST["email"]);
                }

                if(empty($_POST["senha"])) {
                    $msg[2] = "Preencha a senha";
                    $erro = true;
                }

                if(empty($_POST["celular"])) {
                    $msg[3] = "Preencha o celular";
                    $erro = true;
                }
                if(!$erro) {
                    $usuario = new Usuario(0, 
                    $_POST["nome"], 
                    $_POST["email"], 
                    $_POST["senha"], 
                    $_POST["celular"]);
                    // Cadastrar no banco de dados
                }
            }

            require_once "Views/form_usuario.php";
        }

    } // Fim da classe
?>