    <?php
        require_once "cabecalho.php";
    ?>
    <div class="content my-4">
        <div class="container">
            <h1 style="margin-top: 60px; margin-bottom: 20px;">Usuário</h1>
            <form action="#" method="post" class="row g-3 p-2">
                <div class="col-md-6">
                    <label for="nome" class="form-label">Nome</label>
                    <input type="text" class="form-control" id="nome" name="nome">
                </div>
                <div class="col-md-6">
                    <label for="email" class="form-label">Email</label>
                    <input type="email" class="form-control" id="email" name="email">
                </div>
                <div class="col-md-6"><?php echo $msg[0]; ?></div>
                <div class="col-md-6"><?php echo $msg[1]; ?></div>
                <div class="col-md-6">
                    <label for="senha" class="form-label">Senha</label>
                    <input type="password" class="form-control" id="senha" name="senha">
                </div>
                <div class="col-md-6">
                    <label for="celular" class="form-label">Celular</label>
                    <input type="text" class="form-control" id="celular" name="celular" placeholder="14 99999-9999">
                </div>
                <div class="col-md-6"><?php echo $msg[2]; ?></div>
                <div class="col-md-6"><?php echo $msg[3]; ?></div>
                <div class="col-12">
                    <button type="submit" class="btn w-100 btn-primary">Sign in</button>
                </div>
            </form>
        </div>
    </div>
</body>
</html>