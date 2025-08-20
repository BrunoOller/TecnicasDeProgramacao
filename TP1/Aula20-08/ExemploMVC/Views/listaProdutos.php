<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lista de Produtos</title>
</head>
<body>
    <h1>Produtos</h1>
    <a href="index.php?controle=ProdutoController&metodo=inserir">Novo Produto</a>
    <table style="border: 1px solid black;">
        <tr>
            <th>Produto</th>
            <th>Preço</th>
            <th>Estoque</th>
            <th>Ações</th>
        </tr>
        <?php
            foreach($resultado as $dados) {
                $preco = number_format($dados->preco,2,",",".");
                echo "<tr>
                        <td>($dados->nome)</td>
                        <td>($dados->preco)</td>
                        <td>($dados->estoque)</td>
                        <td><a href='index.php?controle=produtoController&metodo=alterar&id={$dados->id_produto}'>Alterar</a>&nsp;&nsp;</td>
                        <td><a href='index.php?controle=produtoController&metodo=excluir&id={$dados->id_produto}'>Excluir</a>&nsp;&nsp;</td>
                      </tr>";
            }
        ?>
    </table>

    
</body>
</html>