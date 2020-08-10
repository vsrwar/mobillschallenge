# Mobills Challenge

Acompanhamento: /api/usuarios (GET)

# DESPESAS
- Recuperar todas despesas: /api/despesas (GET)
- Recuperar despesas: /api/despesas/{id} (GET)
- Inserir despesas: /api/despesas (POST) com uma json string. Ex.:
  "{\"descricao\":\"Conta de água\", \"valor\":\"74.99\", \"data\": \"2020-08-08T21:28:12.707\", \"pago\":\"true\"}"
- Alterar despesas: /api/despesas/{id} (PUT) com uma json string. Ex.:
  "{\"descricao\":\"Conta de água\", \"valor\":\"74.99\", \"data\": \"2020-08-08T21:28:12.707\", \"pago\":\"false\"}"
- Deletar despesas: /api/despesas/{id} (DELETE)

# RECEITAS
- Recuperar todas receitas: /api/receitas (GET)
- Recuperar receita: /api/receitas/{id} (GET)
- Inserir receita: /api/receitas (POST) com uma json string. Ex.:
  "{\"descricao\":\"Salario\", \"valor\":\"1045\", \"data\": \"2020-08-08T21:28:12.707\", \"recebido\":\"true\"}"
- Alterar receita: /api/receitas/{id} (PUT) com uma json string. Ex.:
  "{\"descricao\":\"Salario\", \"valor\":\"2045\", \"data\": \"2020-08-08T21:28:12.707\", \"recebido\":\"false\"}"
- Deletar receita: /api/receitas/{id} (DELETE)
