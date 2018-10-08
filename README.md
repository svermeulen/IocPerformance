Ioc Performance
===============

This 

Source code of my performance comparison of the most popular .NET IoC containers:  
[www.palmmedia.de/Blog/2011/8/30/ioc-container-benchmark-performance-comparison](http://www.palmmedia.de/Blog/2011/8/30/ioc-container-benchmark-performance-comparison)

Author: Daniel Palme  
Blog: [www.palmmedia.de](http://www.palmmedia.de)  
Twitter: [@danielpalme](http://twitter.com/danielpalme)  

Results
-------
### Explantions
**First value**: Time of single-threaded execution in [ms]  
**Second value**: Time of multi-threaded execution in [ms]  
**_*_**: Benchmark was stopped after 1 minute and result is extrapolated.  
### Basic Features
|**Container**|**Singleton**|**Transient**|**Combined**|**Complex**|
|:------------|------------:|------------:|-----------:|----------:|
|**No**|43<br/>48|46<br/>57|81<br/>77|76<br/>82|
|**[abioc 0.7.0](https://github.com/JSkimming/abioc)**|43<br/>43|39<br/>**49**|64<br/>**63**|60<br/>77|
|**[Autofac 4.8.1](https://github.com/autofac/Autofac)**|594<br/>639|630<br/>537|1980<br/>1766|6417<br/>6534|
|**[Caliburn.Micro 1.5.2](https://github.com/Caliburn-Micro/Caliburn.Micro)**|395<br/>229|472<br/>272|1390<br/>771|5888<br/>3145|
|**[Catel 5.6.0](http://www.catelproject.com)**|258<br/>301|3981<br/>4475|8873<br/>9712|20584<br/>22965|
|**[Cauldron.Activator 3.0.32](https://github.com/Capgemini/Cauldron)**|34<br/>41|44<br/>60|75<br/>84|175<br/>130|
|**[DryIoc 3.0.2](https://bitbucket.org/dadhi/dryioc)**|31<br/>41|44<br/>61|56<br/>79|66<br/>70|
|**[DryIocZero 4.0.0](https://bitbucket.org/dadhi/dryioc)**|98<br/>76|75<br/>76|86<br/>94|206<br/>144|
|**[Dynamo 3.0.2](http://martinf.github.io/Dynamo.IoC)**|85<br/>68|93<br/>83|207<br/>139|621<br/>348|
|**[fFastInjector 1.0.1](https://ffastinjector.codeplex.com)**|69<br/>53|116<br/>92|242<br/>166|558<br/>319|
|**[Funq 1.0.0.0](https://funq.codeplex.com)**|109<br/>81|133<br/>106|366<br/>245|1075<br/>592|
|**[Grace 6.4.1](https://github.com/ipjohnson/Grace)**|**23**<br/>38|34<br/>60|**45**<br/>72|**56**<br/>63|
|**[Griffin 1.1.9](https://github.com/jgauffin/griffin.container)**|274<br/>175|291<br/>195|628<br/>386|1758<br/>988|
|**[HaveBox 2.0.0](https://bitbucket.org/Have/havebox)**|38<br/>45|47<br/>61|64<br/>80|97<br/>87|
|**[IfInjector 0.8.1](https://github.com/iamahern/IfInjector)**|78<br/>59|116<br/>86|138<br/>116|188<br/>130|
|**[Lamar 1.1.1](https://jasperfx.github.io/lamar/)**|63<br/>56|79<br/>76|104<br/>101|119<br/>101|
|**[LightCore 1.5.1](http://www.lightcore.ch)**|173<br/>168|2281<br/>1254|25409<br/>35011|144838*<br/>198335*|
|**[LightInject 5.1.8](https://github.com/seesharper/LightInject)**|26<br/>**37**|**31**<br/>58|47<br/>76|63<br/>**62**|
|**[LinFu 2.3.0.41559](https://github.com/philiplaureano/LinFu)**|3037<br/>1644|16419<br/>10338|41746<br/>25356|108167*<br/>62903*|
|**[Maestro 1.5.4](https://github.com/JonasSamuelsson/Maestro)**|329<br/>237|389<br/>265|912<br/>563|2831<br/>1536|
|**[Mef 4.0.0.0](https://github.com/MicrosoftArchive/mef)**|20118<br/>10987|32123<br/>19262|54379<br/>50162|107807*<br/>131680*|
|**[Mef2 1.0.33.0](https://blogs.msdn.com/b/bclteam/p/composition.aspx)**|207<br/>136|220<br/>153|321<br/>214|609<br/>352|
|**[MicroResolver 2.3.5](https://github.com/neuecc/MicroResolver)**|26<br/>40|33<br/>59|50<br/>69|89<br/>79|
|**[MicroSliver 2.1.6](  )**|202<br/>227|753<br/>520|2395<br/>1643|6677<br/>5764|
|**[Microsoft Extensions DependencyInjection 2.1.1](https://github.com/aspnet/DependencyInjection)**|77<br/>64|108<br/>90|135<br/>119|187<br/>131|
|**[Mugen 3.5.1](http://mugeninjection.codeplex.com)**|476<br/>460|708<br/>798|2063<br/>2775|7717<br/>10160|
|**[Munq 3.1.6](http://munq.codeplex.com)**|85<br/>68|119<br/>98|472<br/>303|1561<br/>857|
|**[MvvmCross 6.1.2](https://github.com/MvvmCross/MvvmCross)**|229<br/>252|922<br/>992|2572<br/>2732|7434<br/>7995|
|**[Ninject 3.3.4](http://ninject.org)**|2613<br/>1890|7584<br/>6263|22328<br/>15373|61634*<br/>45643|
|**[Rezolver 1.3.4](http://rezolver.co.uk)**|165<br/>116|181<br/>136|246<br/>184|378<br/>235|
|**[SimpleInjector 4.3.0](https://simpleinjector.org)**|65<br/>56|84<br/>70|92<br/>89|119<br/>96|
|**[Spring.NET 2.0.1](http://www.springframework.net/)**|890<br/>891|9550<br/>13180|26494<br/>30451|69669*<br/>77039*|
|**[Stashbox 2.6.1](https://github.com/z4kn4fein/stashbox)**|30<br/>38|36<br/>61|51<br/>77|64<br/>70|
|**[StructureMap 4.7.0](http://structuremap.net/structuremap)**|994<br/>557|1159<br/>709|3203<br/>1795|7992<br/>4478|
|**[Unity 5.8.6](https://github.com/unitycontainer/unity)**|270<br/>162|376<br/>249|1108<br/>634|3327<br/>1835|
|**[Windsor 4.1.0](http://castleproject.org)**|426<br/>286|1776<br/>973|5787<br/>3108|16675<br/>8985|
|**[Zenject 7.3.0](https://github.com/svermeulen/Zenject)**|437<br/>549|1286<br/>932|3610<br/>2987|9963<br/>6737|
### Advanced Features
|**Container**|**Property**|**Generics**|**IEnumerable**|**Conditional**|**Child Container**|**Asp Net Core**|**Interception With Proxy**|
|:------------|-----------:|-----------:|--------------:|--------------:|------------------:|---------------:|--------------------------:|
|**No**|141<br/>98|53<br/>67|195<br/>124|58<br/>57|543<br/>324|<br/>|439<br/>310|
|**[abioc 0.7.0](https://github.com/JSkimming/abioc)**|<br/>|<br/>|914<br/>431|<br/>|<br/>|<br/>|<br/>|
|**[Autofac 4.8.1](https://github.com/autofac/Autofac)**|6660<br/>6301|1774<br/>1414|7448<br/>6011|1175<br/>1137|67161*<br/>35810|10851<br/>9262|20654<br/>10711|
|**[Caliburn.Micro 1.5.2](https://github.com/Caliburn-Micro/Caliburn.Micro)**|7819<br/>4036|<br/>|5951<br/>3160|<br/>|<br/>|<br/>|<br/>|
|**[Catel 5.6.0](http://www.catelproject.com)**|<br/>|8820<br/>9452|<br/>|<br/>|<br/>|<br/>|3939<br/>4247|
|**[Cauldron.Activator 3.0.32](https://github.com/Capgemini/Cauldron)**|44<br/>64|65<br/>**72**|285<br/>193|<br/>|<br/>|<br/>|**612**<br/>**399**|
|**[DryIoc 3.0.2](https://bitbucket.org/dadhi/dryioc)**|115<br/>98|49<br/>79|253<br/>170|58<br/>65|<br/>|870<br/>538|787<br/>469|
|**[DryIocZero 4.0.0](https://bitbucket.org/dadhi/dryioc)**|270<br/>182|78<br/>78|268<br/>183|333<br/>224|<br/>|<br/>|<br/>|
|**[Dynamo 3.0.2](http://martinf.github.io/Dynamo.IoC)**|733<br/>417|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[fFastInjector 1.0.1](https://ffastinjector.codeplex.com)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Funq 1.0.0.0](https://funq.codeplex.com)**|1043<br/>606|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Grace 6.4.1](https://github.com/ipjohnson/Grace)**|92<br/>89|44<br/>77|244<br/>162|**48**<br/>**58**|43497<br/>23765|**439**<br/>**326**|794<br/>469|
|**[Griffin 1.1.9](https://github.com/jgauffin/griffin.container)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[HaveBox 2.0.0](https://bitbucket.org/Have/havebox)**|732<br/>452|<br/>|1647<br/>954|<br/>|<br/>|<br/>|677<br/>429|
|**[IfInjector 0.8.1](https://github.com/iamahern/IfInjector)**|350<br/>220|134<br/>113|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Lamar 1.1.1](https://jasperfx.github.io/lamar/)**|83<br/>81|121<br/>101|517<br/>317|<br/>|<br/>|809<br/>478|<br/>|
|**[LightCore 1.5.1](http://www.lightcore.ch)**|2046<br/>1670|15474<br/>17370|35033<br/>26530|<br/>|<br/>|<br/>|<br/>|
|**[LightInject 5.1.8](https://github.com/seesharper/LightInject)**|100<br/>98|**41**<br/>**72**|**238**<br/>**161**|328<br/>202|<br/>|2380<br/>1682|1301<br/>731|
|**[LinFu 2.3.0.41559](https://github.com/philiplaureano/LinFu)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Maestro 1.5.4](https://github.com/JonasSamuelsson/Maestro)**|3002<br/>1619|660<br/>415|2943<br/>1631|902<br/>533|<br/>|<br/>|5998<br/>3270|
|**[Mef 4.0.0.0](https://github.com/MicrosoftArchive/mef)**|113888*<br/>137699*|129008*<br/>109517*|89816*<br/>110240*|<br/>|<br/>|<br/>|<br/>|
|**[Mef2 1.0.33.0](https://blogs.msdn.com/b/bclteam/p/composition.aspx)**|1229<br/>721|266<br/>179|1303<br/>737|<br/>|<br/>|<br/>|<br/>|
|**[MicroResolver 2.3.5](https://github.com/neuecc/MicroResolver)**|**34**<br/>**54**|<br/>|251<br/>175|<br/>|<br/>|<br/>|<br/>|
|**[MicroSliver 2.1.6](  )**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Microsoft Extensions DependencyInjection 2.1.1](https://github.com/aspnet/DependencyInjection)**|<br/>|129<br/>110|389<br/>238|<br/>|<br/>|942<br/>600|<br/>|
|**[Mugen 3.5.1](http://mugeninjection.codeplex.com)**|10338<br/>10368|55300<br/>57507|5407<br/>7695|1638<br/>2153|573933*<br/>376419*|<br/>|14189<br/>29322|
|**[Munq 3.1.6](http://munq.codeplex.com)**|1469<br/>818|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[MvvmCross 6.1.2](https://github.com/MvvmCross/MvvmCross)**|948<br/>1027|6198<br/>6536|<br/>|<br/>|**4088**<br/>**2418**|<br/>|<br/>|
|**[Ninject 3.3.4](http://ninject.org)**|58388<br/>41062|24518<br/>15220|61256*<br/>42380|19949<br/>11790|435571000*<br/>365734939*|<br/>|17204<br/>14491|
|**[Rezolver 1.3.4](http://rezolver.co.uk)**|534<br/>325|239<br/>172|8946<br/>4642|<br/>|8179875*<br/>4415881*|9143<br/>6857|<br/>|
|**[SimpleInjector 4.3.0](https://simpleinjector.org)**|218<br/>148|70<br/>77|742<br/>407|78<br/>72|<br/>|<br/>|7165<br/>4037|
|**[Spring.NET 2.0.1](http://www.springframework.net/)**|51391<br/>62415*|<br/>|<br/>|<br/>|<br/>|<br/>|42185<br/>54271|
|**[Stashbox 2.6.1](https://github.com/z4kn4fein/stashbox)**|106<br/>99|48<br/>**72**|257<br/>170|52<br/>**58**|317873*<br/>219028*|676<br/>1042|848<br/>497|
|**[StructureMap 4.7.0](http://structuremap.net/structuremap)**|8417<br/>4696|2223<br/>1315|8352<br/>4592|<br/>|3196473*<br/>1749431*|44306<br/>25318|7541<br/>4091|
|**[Unity 5.8.6](https://github.com/unitycontainer/unity)**|3332<br/>1881|1144<br/>661|4049<br/>2263|834<br/>467|5863<br/>9406|14369<br/>13913|<br/>|
|**[Windsor 4.1.0](http://castleproject.org)**|32879<br/>17795|14091<br/>7517|14856<br/>8174|<br/>|205541*<br/>108275*|<br/>|13683<br/>7150|
|**[Zenject 7.3.0](https://github.com/svermeulen/Zenject)**|13240<br/>8144|6796<br/>4149|13243<br/>8863|2923<br/>2307|21211<br/>11956|<br/>|<br/>|
### Prepare
|**Container**|**Prepare And Register**|**Prepare And Register And Simple Resolve**|
|:------------|-----------------------:|------------------------------------------:|
|**No**|1<br/>|1<br/>|
|**[abioc 0.7.0](https://github.com/JSkimming/abioc)**|6048<br/>|5631<br/>|
|**[Autofac 4.8.1](https://github.com/autofac/Autofac)**|276<br/>|288<br/>|
|**[Caliburn.Micro 1.5.2](https://github.com/Caliburn-Micro/Caliburn.Micro)**|48<br/>|49<br/>|
|**[Catel 5.6.0](http://www.catelproject.com)**|17604<br/>|18036<br/>|
|**[Cauldron.Activator 3.0.32](https://github.com/Capgemini/Cauldron)**|**0**<br/>|**0**<br/>|
|**[DryIoc 3.0.2](https://bitbucket.org/dadhi/dryioc)**|53<br/>|246<br/>|
|**[DryIocZero 4.0.0](https://bitbucket.org/dadhi/dryioc)**|**0**<br/>|1<br/>|
|**[Dynamo 3.0.2](http://martinf.github.io/Dynamo.IoC)**|16854<br/>|16871<br/>|
|**[fFastInjector 1.0.1](https://ffastinjector.codeplex.com)**|7283<br/>|7401<br/>|
|**[Funq 1.0.0.0](https://funq.codeplex.com)**|7<br/>|7<br/>|
|**[Grace 6.4.1](https://github.com/ipjohnson/Grace)**|137<br/>|858<br/>|
|**[Griffin 1.1.9](https://github.com/jgauffin/griffin.container)**|9131<br/>|9201<br/>|
|**[HaveBox 2.0.0](https://bitbucket.org/Have/havebox)**|51547<br/>|51582<br/>|
|**[IfInjector 0.8.1](https://github.com/iamahern/IfInjector)**|1326<br/>|1968<br/>|
|**[Lamar 1.1.1](https://jasperfx.github.io/lamar/)**|1804<br/>|325983*<br/>|
|**[LightCore 1.5.1](http://www.lightcore.ch)**|172<br/>|188<br/>|
|**[LightInject 5.1.8](https://github.com/seesharper/LightInject)**|178<br/>|800<br/>|
|**[LinFu 2.3.0.41559](https://github.com/philiplaureano/LinFu)**|94<br/>|330<br/>|
|**[Maestro 1.5.4](https://github.com/JonasSamuelsson/Maestro)**|174<br/>|785<br/>|
|**[Mef 4.0.0.0](https://github.com/MicrosoftArchive/mef)**|14<br/>|2119<br/>|
|**[Mef2 1.0.33.0](https://blogs.msdn.com/b/bclteam/p/composition.aspx)**|5079<br/>|6485<br/>|
|**[MicroResolver 2.3.5](https://github.com/neuecc/MicroResolver)**|26713<br/>|65064<br/>|
|**[MicroSliver 2.1.6](  )**|11<br/>|15<br/>|
|**[Microsoft Extensions DependencyInjection 2.1.1](https://github.com/aspnet/DependencyInjection)**|20<br/>|27<br/>|
|**[Mugen 3.5.1](http://mugeninjection.codeplex.com)**|428<br/>|1757<br/>|
|**[Munq 3.1.6](http://munq.codeplex.com)**|10195<br/>|10276<br/>|
|**[MvvmCross 6.1.2](https://github.com/MvvmCross/MvvmCross)**|9<br/>|12<br/>|
|**[Ninject 3.3.4](http://ninject.org)**|864750*<br/>|828996*<br/>|
|**[Rezolver 1.3.4](http://rezolver.co.uk)**|10680<br/>|16192<br/>|
|**[SimpleInjector 4.3.0](https://simpleinjector.org)**|623<br/>|3106<br/>|
|**[Spring.NET 2.0.1](http://www.springframework.net/)**|22250<br/>|22311<br/>|
|**[Stashbox 2.6.1](https://github.com/z4kn4fein/stashbox)**|60<br/>|510<br/>|
|**[StructureMap 4.7.0](http://structuremap.net/structuremap)**|1374<br/>|7347<br/>|
|**[Unity 5.8.6](https://github.com/unitycontainer/unity)**|64<br/>|66<br/>|
|**[Windsor 4.1.0](http://castleproject.org)**|2847<br/>|2882<br/>|
|**[Zenject 7.3.0](https://github.com/svermeulen/Zenject)**|137<br/>|146<br/>|
### Charts
<img src="docs/img/Overview_Basic_Slow.png" width="800" height="600" />
<img src="docs/img/Overview_Advanced_Fast.png" width="800" height="600" />
<img src="docs/img/13-Prepare And Register And Simple Resolve.png" width="800" height="600" />
<img src="docs/img/12-Prepare And Register.png" width="800" height="600" />
