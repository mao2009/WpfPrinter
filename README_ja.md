# WpfPrinter

[English](README.md) | [日本語](README_ja.md) | [简体中文](README_zh-CN.md) | [繁體中文](README_zh-TW.md) | [Esperanto](README_eo.md) | [Klingon](README_tlh.md) | [Español](README_es.md) | [Français](README_fr.md) | [Deutsch](README_de.md) | [한국어](README_ko.md)

WPF用の印刷機能を提供するライブラリです。

## 概要

このライブラリはWPFアプリケーションで印刷機能を簡単に実装できるように設計されています。固定ドキュメントの印刷をサポートし、向きの指定などの基本的な印刷オプションを提供します。

## 特徴

- WPF FixedDocumentの印刷サポート
- 縦横方向の指定
- 印ダイアログの統合
- 簡単なAPI

## インストール

```bash
dotnet add package loach.WpfPrinter
```

## 使い方

基本的な印刷の例：

```csharp
using WpfPrinter;
using System.Windows.Documents;

// 固定ドキュメントを作成
var doc = new FixedDocument();

// 印刷を実行
ReportPrinter.Print(doc, true, "My Document");
```

### APIリファレンス

#### ReportPrinter.Print

指定されたドキュメントを印刷します。

```csharp
public static void Print(FixedDocument doc, bool isPortrait, string name)
```

**パラメータ:**
- `doc`: 印刷するFixedDocument
- `isPortrait`: 縦向きの場合はtrue、横向きの場合はfalse
- `name`: 印刷ジョブの名前

**例外:**
- `ArgumentNullException`: ドキュメントがnullの場合
- `InvalidOperationException`: ドキュメントがFixedDocumentでない場合

## ライセンス

このプロジェクトはMITライセンスの下で提供されています。詳細はLICENSEファイルを参照してください。