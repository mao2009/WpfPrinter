# WpfPrinter

[English](README.md) | [日本語](README_ja.md) | [简体中文](README_zh-CN.md) | [繁體中文](README_zh-TW.md) | [Esperanto](README_eo.md) | [Klingon](README_tlh.md) | [Español](README_es.md) | [Français](README_fr.md) | [Deutsch](README_de.md) | [한국어](README_ko.md)

用於提供WPF列印功能的函式庫。

## 概述

此函式庫旨在為WPF應用程式輕鬆實現列印功能。它支援固定文件的列印，並提供基本的列印選項，如方向設定。

## 特性

- 支援WPF FixedDocument列印
- 方向設定（縱向/橫向）
- 整合列印對話方塊
- 簡單的API

## 安裝

```bash
dotnet add package WpfPrinter
```

## 使用方法

基本列印範例：

```csharp
using WpfPrinter;
using System.Windows.Documents;

// 建立固定文件
var doc = new FixedDocument();

// 執行列印
ReportPrinter.Print(doc, true, "My Document");
```

### API參考

#### ReportPrinter.Print

列印指定的文件。

```csharp
public static void Print(FixedDocument doc, bool isPortrait, string name)
```

**參數：**
- `doc`: 要列印的FixedDocument
- `isPortrait`: 縱向為true，橫向為false
- `name`: 列印作業名稱

**例外：**
- `ArgumentNullException`: 當文件為null時
- `InvalidOperationException`: 當文件不是FixedDocument時

## 授權

此專案在MIT授權下提供。詳情請參閱LICENSE檔案。