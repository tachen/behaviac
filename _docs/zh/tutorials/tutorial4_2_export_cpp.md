---
layout: docs_relatives
title: 导出和使用C++行为树
date: 2015-12-04 17:37:26 +0800
author: cainhuang
permalink: /docs/zh/tutorials/tutorial4_2_export_cpp/
categories: [tutorial]
lang: zh
---

## 导出和使用C++行为树
- 在“导出行为树”对话框中，选择“C++ Behavior Exporter”，如下图所示：

![]({{site.baseurl}}/img/tutorials/tutorial4/exportCpp.png)

图1 导出C++行为树

![]({{site.baseurl}}/img/tutorials/tutorial4/cppExportSettings.png)

图2 导出C++的设置

- 点击上图中右侧的“…”设置按钮，在弹出的“C++导出设置”对话框中设置生成文件所在的位置，并可以添加项目中游戏类（从Agent类派生而来）所在的.h头文件，添加的头文件将会被包含在生成的.cpp文件中，如图2所示：
	- 回到“导出行为树”对话框，点击“导出”按钮，开始导出.cpp文件。在指定的导出位置（默认为当前工作区的exported文件夹）会自动生成一个名为behaviac_generated的文件夹，里面生成了behaviors和types两个子文件夹：behaviors文件夹含有generated_behaviors.h及其他单个的行为树.h文件；types文件夹中含有agentproperties.h（为Agent类添加的自定义属性和方法，会扩展在该文件中）、customizedtypes.h和customizedtypes.cpp（添加的枚举和结构体类型，会生成在这两个文件中）以及其他的Agent文件（这些文件是为添加的Agent子类自动生成的.h和.cpp文件，需要程序员补充代码进一步实现这些Agent子类的逻辑），这些自动生成的文件都需要包含到自己的游戏项目中。
	- 在项目中包含了这些自动生成的代码文件后，就可以与前面提及的XML行为树文件一样的接口和方式加载使用这些文件，只是需要将文件格式改为EFF_cpp：

``` c++

behaviac::Workspace::GetInstance()->SetFileFormat(behaviac::Workspace::EFF_cpp);

```