# ShopOnlineDemoSolution
<br/><br/><br/>
## 介绍
<br/>
1、ShopOnlineDemo是一个电商网站的Demo，使用了Blazor WebAssembly模式设计的，该项目有由ShopOnline.Api项目、ShopOnline.Models类和ShopOnline.Web项目组成，启动时需要配置启动项为多个启动项目并把ShopOnline.Api顺序排第一位，ShopOnline.Web和ShopOnline.Api同时启动。
<br/>
2、该项目使用了EFCore（CodeFirst）、Blazor WebAssembly、WebApi前后端分离、Blazored.LocalStorage本地存储、RESTful接口服务的Swagger、Linq等技术。
<br/>
3、还使用了Dto（数据传输对象）的设计思想
<br/>

## 使用方法
<br/>
1.下载代码，下载VS2022，下载SqlServer2022
<br/>
2、在ShopOnline.Api的appsettings.json中更改数据库连接字符串ConnectionStrings为对应数据库连接字符串
<br/>
3、依次点击VS2022中的工具→Nuget包管理器→程序包管理控制台，右击ShopOnline.Api项目选择设为启动项目，程序包管理控制台的默认项目选择ShopOnline.Api,输入 add-migration IninialCreate 和 update-database
<br/>
4、配置启动项为多个启动项目并把ShopOnline.Api顺序排第一位，ShopOnline.Web和ShopOnline.Api同时启动,点击VS2022运行按钮实现本地运行。
