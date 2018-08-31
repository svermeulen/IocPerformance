Ioc Performance
===============

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
|**No**|54<br/>64|74<br/>82|72<br/>98|92<br/>81|
|**[abioc 0.7.0](https://github.com/JSkimming/abioc)**|31<br/>49|41<br/>65|76<br/>86|83<br/>124|
|**[Autofac 4.8.1](https://github.com/autofac/Autofac)**|687<br/>757|1065<br/>791|2475<br/>2297|7272<br/>7709|
|**[Caliburn.Micro 1.5.2](https://github.com/Caliburn-Micro/Caliburn.Micro)**|525<br/>338|579<br/>787|1917<br/>1056|7864<br/>4566|
|**[Catel 5.6.0](http://www.catelproject.com)**|360<br/>549|6677<br/>6649|13330<br/>14885|30903<br/>34712|
|**[Cauldron.Activator 3.0.32](https://github.com/Capgemini/Cauldron)**|40<br/>47|60<br/>72|153<br/>92|231<br/>275|
|**[DryIoc 3.0.2](https://bitbucket.org/dadhi/dryioc)**|35<br/>49|126<br/>77|68<br/>87|106<br/>108|
|**[DryIocZero 4.0.0](https://bitbucket.org/dadhi/dryioc)**|292<br/>90|94<br/>99|102<br/>201|360<br/>203|
|**[Dynamo 3.0.2](http://martinf.github.io/Dynamo.IoC)**|229<br/>85|247<br/>123|479<br/>269|1481<br/>464|
|**[fFastInjector 1.0.1](https://ffastinjector.codeplex.com)**|173<br/>72|173<br/>109|289<br/>269|886<br/>439|
|**[Funq 1.0.0.0](https://funq.codeplex.com)**|280<br/>95|159<br/>179|422<br/>312|1886<br/>1049|
|**[Grace 6.4.1](https://github.com/ipjohnson/Grace)**|72<br/>52|37<br/>73|**51**<br/>112|169<br/>75|
|**[Griffin 1.1.9](https://github.com/jgauffin/griffin.container)**|655<br/>372|487<br/>281|908<br/>859|2436<br/>1553|
|**[HaveBox 2.0.0](https://bitbucket.org/Have/havebox)**|43<br/>52|53<br/>71|137<br/>159|244<br/>108|
|**[IfInjector 0.8.1](https://github.com/iamahern/IfInjector)**|217<br/>80|145<br/>113|561<br/>244|615<br/>164|
|**[Lamar 1.1.1](https://jasperfx.github.io/lamar/)**|63<br/>146|102<br/>101|139<br/>118|162<br/>98|
|**[LightCore 1.5.1](http://www.lightcore.ch)**|181<br/>172|2382<br/>1400|26155<br/>35040|150543*<br/>202841*|
|**[LightInject 5.1.8](https://github.com/seesharper/LightInject)**|**25**<br/>**39**|**33**<br/>**58**|**51**<br/>**76**|**64**<br/>**66**|
|**[LinFu 2.3.0.41559](https://github.com/philiplaureano/LinFu)**|3142<br/>1688|17718<br/>11083|45787<br/>27069|119206*<br/>66834*|
|**[Maestro 1.5.4](https://github.com/JonasSamuelsson/Maestro)**|327<br/>227|386<br/>273|982<br/>594|2957<br/>1603|
|**[Mef 4.0.0.0](https://github.com/MicrosoftArchive/mef)**|21405<br/>11238|33085<br/>20246|57224<br/>56399|115637*<br/>133664*|
|**[Mef2 1.0.33.0](https://blogs.msdn.com/b/bclteam/p/composition.aspx)**|214<br/>140|235<br/>178|336<br/>212|651<br/>368|
|**[MicroResolver 2.3.5](https://github.com/neuecc/MicroResolver)**|27<br/>42|37<br/>60|81<br/>83|128<br/>105|
|**[MicroSliver 2.1.6](  )**|196<br/>217|747<br/>566|2448<br/>1706|7365<br/>6155|
|**[Microsoft Extensions DependencyInjection 2.1.1](https://github.com/aspnet/DependencyInjection)**|83<br/>66|123<br/>92|138<br/>119|187<br/>136|
|**[Mugen 3.5.1](http://mugeninjection.codeplex.com)**|454<br/>432|692<br/>898|2090<br/>2724|7885<br/>10422|
|**[Munq 3.1.6](http://munq.codeplex.com)**|91<br/>69|134<br/>101|478<br/>298|1618<br/>918|
|**[MvvmCross 6.1.2](https://github.com/MvvmCross/MvvmCross)**|240<br/>259|957<br/>1023|2986<br/>2810|7635<br/>7916|
|**[Ninject 3.3.4](http://ninject.org)**|2700<br/>1843|8360<br/>6601|23408<br/>16491|59604<br/>44290|
|**[Rezolver 1.3.4](http://rezolver.co.uk)**|169<br/>121|193<br/>138|263<br/>182|410<br/>254|
|**[SimpleInjector 4.3.0](https://simpleinjector.org)**|113<br/>68|81<br/>90|163<br/>182|247<br/>203|
|**[Spring.NET 2.0.1](http://www.springframework.net/)**|1106<br/>1230|12492<br/>27388|40566<br/>42456|98866*<br/>106773*|
|**[Stashbox 2.6.1](https://github.com/z4kn4fein/stashbox)**|36<br/>45|40<br/>74|90<br/>87|210<br/>138|
|**[StructureMap 4.7.0](http://structuremap.net/structuremap)**|1606<br/>1082|2113<br/>1378|4700<br/>2626|12681<br/>6237|
|**[Unity 5.8.6](https://github.com/unitycontainer/unity)**|316<br/>201|493<br/>256|1452<br/>1189|4946<br/>2618|
|**[Windsor 4.1.0](http://castleproject.org)**|445<br/>298|1877<br/>1029|6501<br/>3338|18121<br/>9864|
|**[Zenject 6.4.0](https://github.com/svermeulen/Zenject)**|680<br/>425|2439<br/>1506|6938<br/>4035|20085<br/>11605|
### Advanced Features
|**Container**|**Property**|**Generics**|**IEnumerable**|**Conditional**|**Child Container**|**Asp Net Core**|**Interception With Proxy**|
|:------------|-----------:|-----------:|--------------:|--------------:|------------------:|---------------:|--------------------------:|
|**No**|154<br/>134|87<br/>**78**|198<br/>198|86<br/>90|753<br/>493|<br/>|586<br/>333|
|**[abioc 0.7.0](https://github.com/JSkimming/abioc)**|<br/>|<br/>|1110<br/>588|<br/>|<br/>|<br/>|<br/>|
|**[Autofac 4.8.1](https://github.com/autofac/Autofac)**|7565<br/>7343|2875<br/>2267|8906<br/>11080|1443<br/>1568|86169*<br/>50176|17743<br/>14485|28929<br/>13919|
|**[Caliburn.Micro 1.5.2](https://github.com/Caliburn-Micro/Caliburn.Micro)**|10653<br/>5885|<br/>|9253<br/>6530|<br/>|<br/>|<br/>|<br/>|
|**[Catel 5.6.0](http://www.catelproject.com)**|<br/>|12083<br/>14448|<br/>|<br/>|<br/>|<br/>|6054<br/>6386|
|**[Cauldron.Activator 3.0.32](https://github.com/Capgemini/Cauldron)**|68<br/>69|112<br/>83|414<br/>291|<br/>|<br/>|<br/>|1067<br/>918|
|**[DryIoc 3.0.2](https://bitbucket.org/dadhi/dryioc)**|558<br/>126|114<br/>115|380<br/>212|84<br/>92|<br/>|1185<br/>715|**968**<br/>985|
|**[DryIocZero 4.0.0](https://bitbucket.org/dadhi/dryioc)**|845<br/>467|88<br/>103|718<br/>404|420<br/>294|<br/>|<br/>|<br/>|
|**[Dynamo 3.0.2](http://martinf.github.io/Dynamo.IoC)**|1332<br/>1011|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[fFastInjector 1.0.1](https://ffastinjector.codeplex.com)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Funq 1.0.0.0](https://funq.codeplex.com)**|1660<br/>995|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Grace 6.4.1](https://github.com/ipjohnson/Grace)**|116<br/>135|51<br/>102|665<br/>452|107<br/>**71**|64601*<br/>32965|**536**<br/>744|1121<br/>**594**|
|**[Griffin 1.1.9](https://github.com/jgauffin/griffin.container)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[HaveBox 2.0.0](https://bitbucket.org/Have/havebox)**|1179<br/>1193|<br/>|2729<br/>1356|<br/>|<br/>|<br/>|1126<br/>700|
|**[IfInjector 0.8.1](https://github.com/iamahern/IfInjector)**|882<br/>465|248<br/>150|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Lamar 1.1.1](https://jasperfx.github.io/lamar/)**|90<br/>144|108<br/>93|575<br/>319|<br/>|<br/>|862<br/>**539**|<br/>|
|**[LightCore 1.5.1](http://www.lightcore.ch)**|2305<br/>1741|16024<br/>16970|35649<br/>26720|<br/>|<br/>|<br/>|<br/>|
|**[LightInject 5.1.8](https://github.com/seesharper/LightInject)**|100<br/>94|**44**<br/>**78**|**246**<br/>**167**|330<br/>211|<br/>|2425<br/>1897|1360<br/>769|
|**[LinFu 2.3.0.41559](https://github.com/philiplaureano/LinFu)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Maestro 1.5.4](https://github.com/JonasSamuelsson/Maestro)**|3123<br/>1698|919<br/>518|3347<br/>1847|987<br/>592|<br/>|<br/>|6560<br/>3471|
|**[Mef 4.0.0.0](https://github.com/MicrosoftArchive/mef)**|120266*<br/>139271*|132436*<br/>120840*|91940*<br/>111056*|<br/>|<br/>|<br/>|<br/>|
|**[Mef2 1.0.33.0](https://blogs.msdn.com/b/bclteam/p/composition.aspx)**|1292<br/>719|272<br/>186|1329<br/>761|<br/>|<br/>|<br/>|<br/>|
|**[MicroResolver 2.3.5](https://github.com/neuecc/MicroResolver)**|**58**<br/>**61**|<br/>|360<br/>172|<br/>|<br/>|<br/>|<br/>|
|**[MicroSliver 2.1.6](  )**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Microsoft Extensions DependencyInjection 2.1.1](https://github.com/aspnet/DependencyInjection)**|<br/>|140<br/>114|562<br/>254|<br/>|<br/>|983<br/>613|<br/>|
|**[Mugen 3.5.1](http://mugeninjection.codeplex.com)**|10756<br/>10016|58560<br/>60583*|5817<br/>7783|1783<br/>2155|605320*<br/>389001*|<br/>|15548<br/>18926|
|**[Munq 3.1.6](http://munq.codeplex.com)**|1607<br/>845|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[MvvmCross 6.1.2](https://github.com/MvvmCross/MvvmCross)**|962<br/>1150|6525<br/>6884|<br/>|<br/>|**4302**<br/>**2597**|<br/>|<br/>|
|**[Ninject 3.3.4](http://ninject.org)**|60902*<br/>41696|26977<br/>15988|67084*<br/>43845|21293<br/>12337|524582000*<br/>481055555*|<br/>|18319<br/>13953|
|**[Rezolver 1.3.4](http://rezolver.co.uk)**|728<br/>450|224<br/>165|9383<br/>4928|<br/>|8397000*<br/>4517311*|9365<br/>6889|<br/>|
|**[SimpleInjector 4.3.0](https://simpleinjector.org)**|396<br/>202|159<br/>141|1189<br/>568|89<br/>96|<br/>|<br/>|9647<br/>5370|
|**[Spring.NET 2.0.1](http://www.springframework.net/)**|74867*<br/>134366*|<br/>|<br/>|<br/>|<br/>|<br/>|64283*<br/>78492*|
|**[Stashbox 2.6.1](https://github.com/z4kn4fein/stashbox)**|123<br/>126|111<br/>96|353<br/>243|**77**<br/>116|479523*<br/>411457*|1022<br/>1746|1240<br/>688|
|**[StructureMap 4.7.0](http://structuremap.net/structuremap)**|11555<br/>5946|3270<br/>2309|12097<br/>8658|<br/>|4356857*<br/>2393911*|71017*<br/>50346|11001<br/>8290|
|**[Unity 5.8.6](https://github.com/unitycontainer/unity)**|4282<br/>3337|1764<br/>1295|5347<br/>3124|1243<br/>1022|8776<br/>13613|17110<br/>15200|<br/>|
|**[Windsor 4.1.0](http://castleproject.org)**|35848<br/>19210|15885<br/>8484|15873<br/>8576|<br/>|217064*<br/>115952*|<br/>|14208<br/>7466|
|**[Zenject 6.4.0](https://github.com/svermeulen/Zenject)**|23048<br/>12968|10322<br/>5755|20899<br/>12437|5642<br/>3629|25720<br/>14130|<br/>|<br/>|
### Prepare
|**Container**|**Prepare And Register**|**Prepare And Register And Simple Resolve**|
|:------------|-----------------------:|------------------------------------------:|
|**No**|4<br/>|2<br/>|
|**[abioc 0.7.0](https://github.com/JSkimming/abioc)**|7220<br/>|7385<br/>|
|**[Autofac 4.8.1](https://github.com/autofac/Autofac)**|510<br/>|342<br/>|
|**[Caliburn.Micro 1.5.2](https://github.com/Caliburn-Micro/Caliburn.Micro)**|107<br/>|122<br/>|
|**[Catel 5.6.0](http://www.catelproject.com)**|32266<br/>|29391<br/>|
|**[Cauldron.Activator 3.0.32](https://github.com/Capgemini/Cauldron)**|**0**<br/>|**1**<br/>|
|**[DryIoc 3.0.2](https://bitbucket.org/dadhi/dryioc)**|148<br/>|688<br/>|
|**[DryIocZero 4.0.0](https://bitbucket.org/dadhi/dryioc)**|**0**<br/>|**1**<br/>|
|**[Dynamo 3.0.2](http://martinf.github.io/Dynamo.IoC)**|24415<br/>|27342<br/>|
|**[fFastInjector 1.0.1](https://ffastinjector.codeplex.com)**|11831<br/>|12242<br/>|
|**[Funq 1.0.0.0](https://funq.codeplex.com)**|11<br/>|12<br/>|
|**[Grace 6.4.1](https://github.com/ipjohnson/Grace)**|169<br/>|2081<br/>|
|**[Griffin 1.1.9](https://github.com/jgauffin/griffin.container)**|12829<br/>|13950<br/>|
|**[HaveBox 2.0.0](https://bitbucket.org/Have/havebox)**|93313*<br/>|93751*<br/>|
|**[IfInjector 0.8.1](https://github.com/iamahern/IfInjector)**|2724<br/>|2934<br/>|
|**[Lamar 1.1.1](https://jasperfx.github.io/lamar/)**|2034<br/>|340341*<br/>|
|**[LightCore 1.5.1](http://www.lightcore.ch)**|181<br/>|189<br/>|
|**[LightInject 5.1.8](https://github.com/seesharper/LightInject)**|186<br/>|825<br/>|
|**[LinFu 2.3.0.41559](https://github.com/philiplaureano/LinFu)**|97<br/>|345<br/>|
|**[Maestro 1.5.4](https://github.com/JonasSamuelsson/Maestro)**|172<br/>|800<br/>|
|**[Mef 4.0.0.0](https://github.com/MicrosoftArchive/mef)**|13<br/>|2143<br/>|
|**[Mef2 1.0.33.0](https://blogs.msdn.com/b/bclteam/p/composition.aspx)**|5328<br/>|6578<br/>|
|**[MicroResolver 2.3.5](https://github.com/neuecc/MicroResolver)**|27610<br/>|67152<br/>|
|**[MicroSliver 2.1.6](  )**|11<br/>|17<br/>|
|**[Microsoft Extensions DependencyInjection 2.1.1](https://github.com/aspnet/DependencyInjection)**|19<br/>|26<br/>|
|**[Mugen 3.5.1](http://mugeninjection.codeplex.com)**|446<br/>|1812<br/>|
|**[Munq 3.1.6](http://munq.codeplex.com)**|10931<br/>|10639<br/>|
|**[MvvmCross 6.1.2](https://github.com/MvvmCross/MvvmCross)**|10<br/>|13<br/>|
|**[Ninject 3.3.4](http://ninject.org)**|1075338*<br/>|1028694*<br/>|
|**[Rezolver 1.3.4](http://rezolver.co.uk)**|12758<br/>|23679<br/>|
|**[SimpleInjector 4.3.0](https://simpleinjector.org)**|1010<br/>|4440<br/>|
|**[Spring.NET 2.0.1](http://www.springframework.net/)**|32339<br/>|33450<br/>|
|**[Stashbox 2.6.1](https://github.com/z4kn4fein/stashbox)**|75<br/>|959<br/>|
|**[StructureMap 4.7.0](http://structuremap.net/structuremap)**|2138<br/>|9156<br/>|
|**[Unity 5.8.6](https://github.com/unitycontainer/unity)**|64<br/>|70<br/>|
|**[Windsor 4.1.0](http://castleproject.org)**|3080<br/>|3026<br/>|
|**[Zenject 6.4.0](https://github.com/svermeulen/Zenject)**|140<br/>|156<br/>|
### Charts
![Basic features](http://www.palmmedia.de/content/blogimages/5225c515-2f25-498f-84fe-6c6e931d2042.png)
![Advanced features](http://www.palmmedia.de/content/blogimages/e0401485-20c6-462e-b5d4-c9cf854e6bee.png)
![Prepare](http://www.palmmedia.de/content/blogimages/67b056a5-9da8-40b4-9ae6-0c838cdac180.png)
### Machine
The benchmark was executed on the following machine:  
**CPU**: Intel(R) Core(TM) i7-6700HQ CPU @ 2.60GHz  
**Memory**: 31.94GB
