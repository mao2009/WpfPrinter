# WpfPrinter

[English](README.md) | [日本語](README_ja.md) | [简体中文](README_zh-CN.md) | [繁體中文](README_zh-TW.md) | [Esperanto](README_eo.md) | [Klingon](README_tlh.md) | [Español](README_es.md) | [Français](README_fr.md) | [Deutsch](README_de.md) | [한국어](README_ko.md)

Biblioteko por provi presajn funkciojn por WPF.

## Resumo

Ĉi tiu biblioteko estas dezajnita por facile efektivigi presajn funkciojn en WPF-aplikojioj. Ĝi subtenas preson de fiksitaj dokumentoj kaj provizas bazajn presajn opciojn kiel orientagordo.

## Trajtoj

- Subteno por presi WPF FixedDocument
- Orientagordo (vertikala/horizontala)
- Integrita presa dialogo
- Simpla API

## Instalo

```bash
dotnet add package WpfPrinter
```

## Uzado

Ekzemplo de baza presado:

```csharp
using WpfPrinter;
using System.Windows.Documents;

// Krei fiksitan dokumenton
var doc = new FixedDocument();

// Ekzekuti presadon
ReportPrinter.Print(doc, true, "My Document");
```

### API Referenco

#### ReportPrinter.Print

Presas la specifitan dokumenton.

```csharp
public static void Print(FixedDocument doc, bool isPortrait, string name)
```

**Parametroj:**
- `doc`: La FixedDocument por presi
- `isPortrait`: Se estas portreta (verdade) a pejzaĝa (falso)
- `name`: Nomo de presa tasko

**Esceptoj:**
- `ArgumentNullException`: Kiam la dokumento estas null
- `InvalidOperationException`: Kiam la dokumento ne estas FixedDocument

## Permesilo

Ĉi tiu projekto estas provizita sub MIT-permesilo. Vidu la dosieron por pli da detaloj.