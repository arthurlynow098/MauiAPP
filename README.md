<p align="center">
  <img src="assets/banner.png" alt="MauiApp — .NET MAUI" width="100%">
</p>

<p align="center">
  Aplicação multiplataforma desenvolvida em C# e .NET MAUI (.NET 9) com núcleo de interface compartilhado e empacotamento nativo para Android e Windows.
</p>

<p align="center">
  <img alt=".NET MAUI" src="https://img.shields.io/badge/.NET_9-MAUI-C52E36?style=for-the-badge&logo=dotnet&logoColor=white">
  <img alt="Android" src="https://img.shields.io/badge/Target-Android-11120F?style=for-the-badge&logo=android&logoColor=C52E36">
  <img alt="Windows" src="https://img.shields.io/badge/Target-WinUI_3-18181B?style=for-the-badge&logo=windows&logoColor=C52E36">
</p>

## Sobre o projeto

O desenvolvimento multiplataforma moderno busca compartilhar a maior parte possível das regras de negócio e das telas em XAML/C# sem abrir mão do desempenho e das APIs nativas de cada sistema operacional. Este projeto acadêmico explora o **.NET MAUI (.NET Multi-platform App UI)** sobre o **.NET 9**.

A solução (MauiApp2.sln) está organizada com separação explícita entre o núcleo compartilhado e os cabeçalhos de plataforma (MauiApp2.Droid para Android com MainActivity e recursos mipmap/drawable, além do suporte desktop Windows), permitindo compilar e depurar a partir de uma base única.

## Principais recursos

| Recurso | Como funciona |
|---|---|
| Base de código unificada | Lógica em C# e telas compartilhadas entre dispositivos móveis e desktop. |
| Host nativo Android | Projeto MauiApp2.Droid com AndroidManifest.xml, MainApplication.cs e ícones adaptativos em múltiplas densidades (hdpi a xxxhdpi). |
| Pipeline MauiProgram | Inicialização centralizada com padrão *HostBuilder* para registro de fontes, serviços e ciclo de vida. |
| Destino .NET 9 | Configurado para aproveitar as otimizações de compilação e runtime do SDK .NET 9. |

## Tecnologias

<p>
  <img alt="C#" src="https://img.shields.io/badge/C%23-C52E36?style=flat-square&logo=dotnet&logoColor=white">
  <img alt=".NET 9" src="https://img.shields.io/badge/.NET_9-11120F?style=flat-square&logo=dotnet&logoColor=C52E36">
  <img alt=".NET MAUI" src="https://img.shields.io/badge/.NET_MAUI-C52E36?style=flat-square&logo=dotnet&logoColor=white">
  <img alt="Android" src="https://img.shields.io/badge/Android_SDK-11120F?style=flat-square&logo=android&logoColor=C52E36">
  <img alt="XAML" src="https://img.shields.io/badge/XAML-C52E36?style=flat-square&logo=windows&logoColor=white">
</p>

- **C# & .NET 9** como linguagem e plataforma de execução;
- **.NET MAUI** para abstração de componentes visuais multiplataforma;
- **Android SDK** para empacotamento e execução em emuladores ou dispositivos físicos Android.

## Arquitetura

`mermaid
flowchart LR
    A[Código Compartilhado C# / XAML] --> B[MauiProgram · HostBuilder]
    B --> C[Target Android · MauiApp2.Droid]
    B --> D[Target Windows · WinUI]
    C --> E[APK / Dispositivo Android]
    D --> F[Aplicação Desktop Windows]
`

## Estrutura do repositório

`	ext
MauiAPP/
├── assets/
│   ├── banner.png                          Banner principal MauiApp
│   └── project-animal.png                  Símbolo da raia manta
├── MauiApp2/
│   ├── MauiApp2.Droid/                     Projeto nativo Android (Manifest, MainActivity, Resources)
│   └── ...                                 Arquivos compartilhados da solução MAUI
├── MauiApp2.sln                            Solução Visual Studio
├── MauiApp-master.zip                      Snapshot compactado do projeto original
└── README.md
`

## Executando o código

1. Certifique-se de ter o **SDK .NET 9** e a workload do MAUI instalada (dotnet workload install maui).
2. Clone o repositório:
   `powershell
   git clone https://github.com/arthurlynow098/MauiAPP.git
   cd MauiAPP
   `
3. Abra MauiApp2.sln no **Visual Studio 2022** e selecione o emulador Android ou a máquina Windows para iniciar a depuração.

---

<p align="center"><sub>Estudo · construção · evolução</sub><br><a href="https://github.com/arthurlynow098">Perfil</a> · <a href="https://arthurentsev.vercel.app/">Portfólio</a> · <a href="https://www.linkedin.com/in/entsevarthur/">LinkedIn</a></p>
