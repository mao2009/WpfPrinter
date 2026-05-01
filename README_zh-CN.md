# WpfPrinter

[English](README.md) | [日本語](README_ja.md) | [简体中文](README_zh-CN.md) | [繁體中文](README_zh-TW.md) | [Esperanto](README_eo.md) | [Klingon](README_tlh.md) | [Español](README_es.md) | [Français](README_fr.md) | [Deutsch](README_de.md) | [한국어](README_ko.md)

用于提供WPF打印功能的库。

## 概述

此库旨在为WPF应用程序轻松实现打印功能。它支持固定文档的打印，并提供基本的打印选项，如方向设置。

## 特性

- 支持WPF FixedDocument打印
- 方向设置（纵向/横向）
- 集成打印对话框
- 简单的API

## 安装

```bash
dotnet add package loach.WpfPrinter
```

## 使用方法

基本打印示例：

```csharp
using WpfPrinter;
using System.Windows.Documents;

// 创建固定文档
var doc = new FixedDocument();

// 执行打印
ReportPrinter.Print(doc, true, "My Document");
```

### API参考

#### ReportPrinter.Print

打印指定的文档。

```csharp
public static void Print(FixedDocument doc, bool isPortrait, string name)
```

**参数：**
- `doc`: 要打印的FixedDocument
- `isPortrait`: 纵向为true，横向为false
- `name`: 打印作业名称

**异常：**
- `ArgumentNullException`: 当文档为null时
- `InvalidOperationException`: 当文档不是FixedDocument时

## 许可证

此项目在MIT许可证下提供。详情请参阅LICENSE文件。