# Encurtador de Links usando API cutt.ly

Este é um pequeno programa em C# que utiliza a API do serviço cutt.ly para encurtar links. A API cutt.ly permite que você converta URLs longas em URLs curtas, facilitando o compartilhamento em redes sociais, e-mails ou qualquer outro lugar onde o espaço é limitado.

## Requisitos para Executar

Para executar este programa, você precisará ter instalado o seguinte:

1.  **Ambiente de Desenvolvimento C#:** Certifique-se de que você possui o ambiente de desenvolvimento C# instalado em seu sistema.
    
2.  **Arquivo de Configuração (appSettings.json):** É necessário ter um arquivo de configuração chamado "appSettings.json" no mesmo diretório onde o programa será executado. Este arquivo deve conter a chave de API do serviço cutt.ly. Veja um exemplo de como o arquivo appSettings.json deve ser estruturado:
    

jsonCopy code

`{
   "ApiKey": "sua_chave_de_api_aqui"
}` 

3.  **Pacote HttpClient:** O programa utiliza o pacote HttpClient para fazer requisições HTTP. Normalmente, esse pacote já é incluído nos projetos C#, mas se você estiver executando o código em um contexto diferente, certifique-se de que o pacote esteja instalado.

## Executando o Programa

Após garantir que você possui os requisitos listados acima, siga as etapas abaixo para executar o programa:

1.  Certifique-se de ter preenchido corretamente a chave de API no arquivo "appSettings.json".
    
2.  Execute o programa em um ambiente C# compatível, como o Visual Studio ou através da linha de comando usando o compilador C#.
    
3.  Quando o programa for executado, você será solicitado a inserir um link longo que deseja encurtar. Digite o link e pressione Enter.
    
4.  O programa fará uma solicitação à API do cutt.ly para encurtar o link fornecido. Em seguida, mostrará os resultados na saída.
    

## Explicação do Programa

1.  O programa começa carregando as configurações a partir do arquivo "appSettings.json", que deve conter a chave de API do cutt.ly.
    
2.  Em seguida, solicita ao usuário que insira o link longo que deseja encurtar.
    
3.  Se a chave de API não for encontrada no arquivo de configuração, o programa exibirá uma mensagem de erro e sairá.
    
4.  Caso a chave de API esteja disponível, o programa fará uma solicitação HTTP para a API cutt.ly, fornecendo a chave de API e o link longo a ser encurtado.
    
5.  A resposta da API é lida e desserializada para um objeto do tipo ApiResponse, que contém os dados da resposta da API.
    
6.  Se a resposta da API for bem-sucedida, o programa imprimirá as informações do link encurtado na saída. Caso contrário, exibirá uma mensagem de erro com o código e a razão do erro retornado pela API.
    

## Considerações Finais

Este programa básico demonstra como realizar uma requisição à API cutt.ly para encurtar links usando a linguagem de programação C#. Lembre-se de que é necessário ter uma chave de API válida para usar o serviço e que o programa pode ser estendido e adaptado de várias maneiras para se adequar aos seus projetos.
