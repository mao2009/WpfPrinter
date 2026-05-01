# WpfPrinter

[English](README.md) | [日本語](README_ja.md) | [简体中文](README_zh-CN.md) | [繁體中文](README_zh-TW.md) | [Esperanto](README_eo.md) | [Klingon](README_tlh.md) | [Español](README_es.md) | [Français](README_fr.md) | [Deutsch](README_de.md) | [한국어](README_ko.md)

A library for providing printing functionality for WPF.

## Overview

This library is designed to easily implement printing functionality in WPF applications. It supports printing fixed documents and provides basic printing options such as orientation.

## Features

- Support for WPF FixedDocument printing
- Orientation setting (portrait/landscape)
- Integrated print dialog
- Simple API

## Installation

```bash
dotnet add package loach.WpfPrinter
```

## Usage

Basic printing example:

```csharp
using WpfPrinter;
using System.Windows.Documents;

// Create a fixed document
var doc = new FixedDocument();

// Execute printing
ReportPrinter.Print(doc, true, "My Document");
```

### API Reference

#### ReportPrinter.Print

Prints the specified document.

```csharp
public static void Print(FixedDocument doc, bool isPortrait, string name)
```

**Parameters:**
- `doc`: The FixedDocument to print
- `isPortrait`: True for portrait, false for landscape
- `name`: Name of the print job

**Exceptions:**
- `ArgumentNullException`: When the document is null
- `InvalidOperationException`: When the document is not a FixedDocument

## License

This project is provided under the MIT license. See the LICENSE file for details.