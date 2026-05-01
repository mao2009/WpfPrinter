# WpfPrinter

[English](README.md) | [日本語](README_ja.md) | [简体中文](README_zh-CN.md) | [繁體中文](README_zh-TW.md) | [Esperanto](README_eo.md) | [Klingon](README_tlh.md) | [Español](README_es.md) | [Français](README_fr.md) | [Deutsch](README_de.md) | [한국어](README_ko.md)

Bibliothek zum Bereitstellen von Druckfunktionen für WPF.

## Zusammenfassung

Diese Bibliothek ist entwickelt, um Druckfunktionen einfach in WPF-Anwendungen zu implementieren. Sie unterstützt das Drucken von FixedDocuments und bietet grundlegende Druckoptionen wie Ausrichtung.

## Merkmale

- Unterstützung für WPF FixedDocument-Druck
- Ausrichtung (Hoch-/Querformat)
- Integrierter Druckdialog
- Einfache API

## Installation

```bash
dotnet add package WpfPrinter
```

## Verwendung

Beispiel für grundlegenden Druck:

```csharp
using WpfPrinter;
using System.Windows.Documents;

// FixedDocument erstellen
var doc = new FixedDocument();

// Drucken ausführen
ReportPrinter.Print(doc, true, "My Document");
```

### API-Referenz

#### ReportPrinter.Print

Druckt das angegebene Dokument.

```csharp
public static void Print(FixedDocument doc, bool isPortrait, string name)
```

**Parameter:**
- `doc`: Das zu druckende FixedDocument
- `isPortrait`: True für Hochformat, false für Querformat
- `name`: Name des Druckauftrags

**Ausnahmen:**
- `ArgumentNullException`: Wenn das Dokument null ist
- `InvalidOperationException`: Wenn das Dokument kein FixedDocument ist

## Lizenz

Dieses Projekt wird unter der MIT-Lizenz bereitgestellt. Details finden Sie in der LICENSE-Datei.