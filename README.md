## TapAPICSharpWrapper

易盛启明星 API 的 C#封装,包括行情接口及交易接口

### 接口版本

TapQuoteAPI V9.3.1.4 2019.09.25
iTapTradeAPI V9.3.8.7 2023.01.17

### 原理:

使用 SWIG 创建易盛启明星 API 的 c# wrapper 文件。

### 调用关系：

CSharp_Demo <--> TapQuoteAPIWrapper.dll <--> TapQuoteAPI.dll
CSharp_Demo <--> TapTradeAPIWrapper.dll <--> TapTradeAPI.dll
其中 TapQuoteAPI.dll 和 TapTradeAPI.dll 由易盛公司提供。
TapQuoteAPIWrapper.dll 和 TapTradeAPIWrapper.dll 由 SWIG 生成。
