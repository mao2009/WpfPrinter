# WpfPrinter

[English](README.md) | [日本語](README_ja.md) | [简体中文](README_zh-CN.md) | [繁體中文](README_zh-TW.md) | [Esperanto](README_eo.md) | [Klingon](README_tlh.md) | [Español](README_es.md) | [Français](README_fr.md) | [Deutsch](README_de.md) | [한국어](README_ko.md)

Biblioteca para proporcionar funcionalidades de impresión para WPF.

## Resumen

Esta biblioteca está diseñada para implementar fácilmente funcionalidades de impresión en aplicaciones WPF. Soporta la impresión de documentos fijos y proporciona opciones básicas de impresión como la orientación.

## Características

- Soporte para impresión de WPF FixedDocument
- Orientación (vertical/horizontal)
- Diálogo de impresión integrado
- API simple

## Instalación

```bash
dotnet add package WpfPrinter
```

## Uso

Ejemplo básico de impresión:

```csharp
using WpfPrinter;
using System.Windows.Documents;

// Crear documento fijo
var doc = new FixedDocument();

// Ejecutar impresión
ReportPrinter.Print(doc, true, "My Document");
```

### Referencia de API

#### ReportPrinter.Print

Imprime el documento especificado.

```csharp
public static void Print(FixedDocument doc, bool isPortrait, string name)
```

**Parámetros:**
- `doc`: El FixedDocument para imprimir
- `isPortrait`: Verdadero si es vertical, falso si es horizontal
- `name`: Nombre del trabajo de impresión

**Excepciones:**
- `ArgumentNullException`: Cuando el documento es nulo
- `InvalidOperationException`: Cuando el documento no es FixedDocument

## Licencia

Este proyecto se proporciona bajo la licencia MIT. Consulte el archivo LICENSE para más detalles.