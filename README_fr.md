# WpfPrinter

[English](README.md) | [日本語](README_ja.md) | [简体中文](README_zh-CN.md) | [繁體中文](README_zh-TW.md) | [Esperanto](README_eo.md) | [Klingon](README_tlh.md) | [Español](README_es.md) | [Français](README_fr.md) | [Deutsch](README_de.md) | [한국어](README_ko.md)

Bibliothèque pour fournir des fonctionnalités d'impression pour WPF.

## Résumé

Cette bibliothèque est conçue pour implémenter facilement des fonctionnalités d'impression dans les applications WPF. Elle prend en charge l'impression de documents fixes et fournit des options d'impression de base telles que l'orientation.

## Caractéristiques

- Prise en charge de l'impression de FixedDocument WPF
- Orientation (portrait/paysage)
- Dialogue d'impression intégré
- API simple

## Installation

```bash
dotnet add package WpfPrinter
```

## Utilisation

Exemple d'impression de base :

```csharp
using WpfPrinter;
using System.Windows.Documents;

// Créer un document fixe
var doc = new FixedDocument();

// Exécuter l'impression
ReportPrinter.Print(doc, true, "My Document");
```

### Référence de l'API

#### ReportPrinter.Print

Imprime le document spécifié.

```csharp
public static void Print(FixedDocument doc, bool isPortrait, string name)
```

**Paramètres :**
- `doc`: Le FixedDocument à imprimer
- `isPortrait`: Vrai si c'est en portrait, faux si c'est en paysage
- `name`: Nom du travail d'impression

**Exceptions :**
- `ArgumentNullException`: Lorsque le document est nul
- `InvalidOperationException`: Lorsque le document n'est pas un FixedDocument

## Licence

Ce projet est fourni sous licence MIT. Voir le fichier LICENSE pour plus de détails.