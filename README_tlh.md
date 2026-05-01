# WpfPrinter

[English](README.md) | [日本語](README_ja.md) | [简体中文](README_zh-CN.md) | [繁體中文](README_zh-TW.md) | [Esperanto](README_eo.md) | [Klingon](README_tlh.md) | [Español](README_es.md) | [Français](README_fr.md) | [Deutsch](README_de.md) | [한국어](README_ko.md)

Qeyb lo' luj WpuDaw' maSop chenmoH.

## Qaw'

'e' DaqelmoHpu' 'ej wIqmoHpu'. 'e' leghlaHlaw' 'ach 'oH pab Dochvetlh 'ej pagh nIv Datogh.

## Qaw'maj

- WpuDaw' FixedDocument Daqel
- batlh Dev'mejDat
- Qu'vaD Dev chenmoH
- 'IwchoH jarghoq

## qaw'DIch

```bash
dotnet add package loach.WpfPrinter
```

## lo'mej

Qaw' mu'tlhegh:

```csharp
using WpfPrinter;
using System.Windows.Documents;

// FixedDocument jIchel
var doc = new FixedDocument();

// Qaw' jIghoS
ReportPrinter.Print(doc, true, "My Document");
```

### Qaw' QI'mej

#### ReportPrinter.Print

FixedDocument Dun'e' qaw'.

```csharp
public static void Print(FixedDocument doc, bool isPortrait, string name)
```

**ghanI':**
- `doc`: FixedDocument 'ej qaw'
- `isPortrait`: pIgh batlh Datlhov
- `name`: qaw' Dev'I'mej}

**Duj'a':**
- `ArgumentNullException`: FixedDocument lu' Sopbe'chugh
- `InvalidOperationException`: FixedDocument lu' Sopbe'chugh

## Holvam

- [English](README.md)
- [日本語](README_ja.md)
- [简体中文](README_zh-CN.md)
- [繁體中文](README_zh-TW.md)
- [Esperanto](README_eo.md)
- [Klingon](README_tlh.md)
- [Español](README_es.md)
- [Français](README_fr.md)
- [Deutsch](README_de.md)
- [한국어](README_ko.md)

## Qu'maj

'ev lu' je'e'lu' je'e'lu' jIlo'lu'. Qu'Daj pe'me'vam Hoch 'Iw Daqel.