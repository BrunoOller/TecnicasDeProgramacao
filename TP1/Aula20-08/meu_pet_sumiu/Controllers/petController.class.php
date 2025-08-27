<?php
    class ProdutoController {
        public function listar() {
            // Buscar os dados de produtos no banco de dados     
            $parametros = "mysql:host=localhost;dbname=exemplomvc;charset=utf8mb4";
            $conn = new PDO($parametros, "root", "");
            // Buscar os dados
            $sql = "SELECT * FROM produtos";
            $stm = $conn->prepare($sql);
            $stm->execute();
            $conn = null;
            $resultado = $stm->fetchAll(PDO::FETCH_OBJ);

            // var_dump($resultado);
            require_once "Views/lista_produtos.php";
            // Mostrar uma visão
        }
    }
?>