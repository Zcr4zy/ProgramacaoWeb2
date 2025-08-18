using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    { 
        List<Categoria> categorias = new List<Categoria>{
            new Categoria{
                Id = 1,
                Nome = "Monitores"
            },
            new Categoria {
                Id = 2,
                Nome = "Consoles"
            },
            new Categoria {
                Id = 3,
                Nome = "Notebooks"
            }
        };
        
        List<Produto> produtos = new List<Produto>{
            new Produto{
                Id = 1,
                Nome = "Monitor Gamer Pichau Nexus S29, 29 Pol",
                Descricao = "O monitor Pichau Nexus S29 foi desenvolvido com o intuito de transformar completamente sua experiência como gamer. Prepare-se para guardar memórias incríveis se aventurando pelos mais épicos lugares de seus games favoritos, com total performance e imersão.",
                Categoria = categorias[0],
                QtdeEstoque = 20,
                ValorCusto = 800,
                ValorVenda = 999,
                Foto = "/img/produtos/1-Nexus29.jpg"
            },
            new Produto{
                Id = 2,
                Nome = "Monitor Gamer Pichau Cepheus S49 PRO, 49 Pol. ",
                Descricao = "O Monitor Gamer Pichau Cepheus S49 PRO foi criado e desenvolvido para trazer uma experiência única e imersiva, unindo alta performance, boa fidelidade de cores e tecnologia de ponta, tudo isso com um design moderno e impressionante.",
                Categoria = categorias[0],
                QtdeEstoque = 5,
                ValorCusto = 3000,
                ValorVenda = 4705.87m,
                Foto = "2-Cepheus49.jpg"
            },
            new Produto{
                Id = 3,
                Nome = "Monitor Gamer AOC 27G4/P, 27 Pol. ",
                Descricao = "Prepare-se para dominar suas partidas com o monitor AOC Gaming G4, equipado com as principais tecnologias do mundo gamer que irão te proporcionar jogadas fantásticas e levar no caminho certo para a vitória. Além disso, o G-menu, software exclusivo da AOC, permite personalizar todas as configurações do seu monitor em uma única plataforma intuitiva.",
                Categoria = categorias[0],
                QtdeEstoque = 15,
                ValorCusto = 700,
                ValorVenda = 1117.63m,
                Foto = "3-AOC27.jpg"
            },


            new Produto{
                Id = 4,
                Nome = "Console Sony PlayStation 5 Slim, Edição Digital, SSD 1TB, Controle Sem Fio DualSense + 2 Jogos Digitais. ",
                Descricao = "Prepare-se para uma experiência de jogo revolucionária com o PlayStation®5 Slim Digital. Este console combina um design elegante e compacto com a poderosa tecnologia de jogos da Sony, oferecendo um desempenho que redefine os limites do que é possível. Com o SSD de 1TB de altíssima velocidade, você desfrutará de carregamentos quase instantâneos, permitindo que você passe mais tempo jogando e menos tempo esperando. Mergulhe em mundos vibrantes e realistas com gráficos 4K impressionantes e uma jogabilidade incrivelmente fluida.",
                Categoria = categorias[1],
                QtdeEstoque = 6,
                ValorCusto = 3000,
                ValorVenda = 4000,
                Foto = "/img/produtos/4-PlayStation5.jpg"
            },
            new Produto{
                Id = 5,
                Nome = "Xbox Console Series X 1TB SSD console de videogame com um controlador sem fio, 16 GB GDDR6 RAM, 8x núcleos Zen 2 CPU, RDNA 2 G",
                Descricao = "Apresentamos o Xbox Series X: proporcionando uma verdadeira experiência de jogo 4K, graças aos 12 teraflops de poder de processamento. Equipado com as arquiteturas Zen 2 e RDNA 2 da AMD, o raytracing DirectX acelerado por hardware proporciona iluminação realista, sombras e reflexos para criar mundos dinâmicos e vivos. Aproveite ao máximo cada minuto de jogo com Quick Resume, tempos de carregamento extremamente rápidos e jogos de até 120 FPS que são todos alimentados pela Xbox Velocity Architecture. Minimize o tempo de carga e aumente as taxas de quadros com um SSD de 1 TB personalizado, que permite que jogos maiores e mais robustos funcionem em sua capacidade total. Traga sua experiência de jogo com os ambientes de som ricos e dinâmicos de alta qualidade.",
                Categoria = categorias[1],
                QtdeEstoque = 6,
                ValorCusto = 3000,
                ValorVenda = 4000,
                Foto = "/img/produtos/5-XboxSeriesX.jpg"
            },
            new Produto{
                Id = 6,
                Nome = "Console PS4 PRO - 1TB +2 controles + 1 jogo com 2 Anos de Garantia - Sony",
                Descricao = "Jogos em 4K dinâmico e entretenimento em 4K. É isso o que o PS4 Pro 1TB faz: deixa o seu jogo mais perto de você. Intensifique suas experiências. Eleve o nível das suas aventuras. Deixe o superpotente PS4 Pro mostrar o caminho. Gráficos incríveis: explore mundos cheios de vida em jogos com gráficos ainda mais detalhados no PS4 Pro. • Gameplay aprimorado: a compatibilidade com taxas de quadros mais rápidas proporciona uma ação extremamente nítida em determinados jogos para PS4. • Uma comunidade unificada de jogadores: compatível com todos os jogos para PS4. Jogue online com outros usuários do PS4 com o PlayStation® Plus. • Entretenimento excepcional: com streaming em até 4K e aprimoramento automático de 4K para conteúdos de vídeo. ",
                Categoria = categorias[1],
                QtdeEstoque = 6,
                ValorCusto = 3000,
                ValorVenda = 4000,
                Foto = "/img/produtos/6-PlayStation4.png"
            },

            new Produto{
                Id = 7,
                Nome = "Notebook Gamer Acer Nitro V, 15.6 Pol, 144Hz, Intel Core i5-13420H, 8GB DDR5, SSD 512GB M.2, RTX 3050 6GB, Preto, ANV15-51-57WS",
                Descricao = "O Notebook Gamer Acer Nitro V oferece uma experiência fluida com seu processador Intel Core i5-13420H e 8GB de memória DDR5, ideal para games e tarefas exigentes. Equipado com SSD de 512GB, proporciona carregamentos rápidos e espaço suficiente para jogos e arquivos pesados. Sua tela de 15.6” é perfeita para imersão nos jogos. Com visual moderno na cor preta, o Nitro V alia performance e portabilidade. É uma ótima opção para jogadores e criadores que precisam de potência em qualquer lugar.",
                Categoria = categorias[2],
                QtdeEstoque = 6,
                ValorCusto = 5000,
                ValorVenda = 6705.87m,
                Foto = "/img/produtos/7-NotebookAcerNitroV.jpg"
            },
            new Produto{
                Id = 8,
                Nome = "Notebook Gamer ROG Strix G16, NVidia RTX4060, CORE I9, 16 GB, 512 GB, Windows 11 Home, Eclipse Gray - G614JV-N3094W",
                Descricao = "O novo ROG Strix G16 traz a 13 a geração de processadores Intel® Core™ i9-13980HX, que garante o desempenho supremo que você precisa para elevar sua gameplay e carregar seu time em quaisquer desafios, graças aos seus 8 núcleos de performance e 16 núcleos de eficiência. Este poderoso notebook gamer conta com a novíssima placa NVIDIA® GeForce RTX™ 4060, que fornece mais poder de processamento gráfico combinado com uma surpreendente e inovadora tecnologia de inteligência artificial. E com modernos recursos como o novo DLSS 3, que aumenta o FPS dos jogos, o ROG Strix G16 é capaz de trazer uma experiência ainda mais imersiva e realista.",
                Categoria = categorias[2],
                QtdeEstoque = 3,
                ValorCusto = 8000,
                ValorVenda = 10000,
                Foto = "/img/produtos/8-NotebookROGStrix.jpg"
            },
            new Produto{
                Id = 9,
                Nome = "Notebook Acer Predator Helios Neo, Intel Core i7-14700hx de 14ªGen, 16GB, RTX 4070, SSD 512GB, W11 Home - Phn16-72-74vx",
                Descricao = "Notebook Acer Predator Helios Neo Phn16-72-74vx Intel Core I7-14700hx De 14ªgen 16gb 512gb SSD RTX 4070 W11 Home. Processador: Intel Core i7-14700HX de 14ª geração para alto desempenho em tarefas exigentes. Memória e Armazenamento: 16GB de RAM para execução fluida de múltiplos aplicativos, aliado a um SSD de 512GB para armazenamento rápido e eficiente. Gráficos e Vídeo: Equipado com RTX 4070, ideal para jogos e aplicações gráficas intensivas.",
                Categoria = categorias[2],
                QtdeEstoque = 6,
                ValorCusto = 9000,
                ValorVenda = 12560.99m,
                Foto = "/img/produtos/9-NotebookAcerPredatorHelios.jpg"
            },
        };

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
