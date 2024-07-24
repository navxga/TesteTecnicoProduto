# Teste Técnico para treinar uma API de produtos

**Stack**:
- C#
- API REST
- Auth: Basic Protocol
- SQL Server
- DDD
- SOLID

## Quais princípios SOLID foram usados?
### Single Responsibility Principle (SRP):
- ProdutoController: Cada método é responsável por uma ação específica (criar, obter, atualizar, deletar).
- ProdutoAppService: Responsável pelas operações de aplicação relacionadas a produtos.
- ProdutoDomainService: Responsável pelas regras de negócios relacionadas a produtos.
- BaseRepository<TEntity>: Responsável pelas operações básicas de CRUD no banco de dados.

### Open/Closed Principle (OCP):
- BaseRepository<TEntity>: Esta classe está aberta para extensão, mas fechada para modificação. Pode ser estendida para adicionar funcionalidades específicas sem alterar o comportamento básico.
- ProdutoAppService e ProdutoDomainService: Seguem o princípio ao permitir que novos comportamentos sejam adicionados sem alterar as classes existentes.
  
### Liskov Substitution Principle (LSP):
- As classes que implementam as interfaces como IProdutoAppService, IProdutoDomainService e IBaseRepository<TEntity> podem ser substituídas por suas implementações concretas sem quebrar a funcionalidade.

### Interface Segregation Principle (ISP):
- IProdutoAppService e IProdutoDomainService: Interfaces específicas e pequenas que definem contratos claros para os serviços de aplicação e domínio.
- IBaseRepository<TEntity>: Define um contrato claro para as operações básicas de repositório.
  
### Dependency Inversion Principle (DIP):
- ProdutoAppService depende da abstração IProdutoDomainService.
- ProdutoDomainService depende da abstração IProdutoRepository.
- A injeção de dependência é usada para passar as implementações concretas para essas classes.

##  Qual foi o motivo da escolha deles?
Essa estrutura que utiliza todos os princípios corretamente, é além de muito bonita, muito organizada e escalável

## Dado um cenário que necessite de alta performance, cite 2 locais possíveis de melhorar a performance da API criada e explique como seria a implementação desta melhoria.
Eu pensaria para o lado dos Design Patterns, visto que eles podem melhorar muito a performance. 

1. Inicialmente eu implementaria um Singleton no DataContext para manter a instância de connectionString (desde que tenha certeza que será a mesma).
2. Talvez, dependendo do tamanho do projeto, cabe também um Factory Method para fabricar alguma entidade com mais performance.
