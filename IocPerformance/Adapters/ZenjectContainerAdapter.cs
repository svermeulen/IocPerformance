using System;
using IocPerformance.Classes.Child;
using IocPerformance.Classes.Complex;
using IocPerformance.Classes.Conditions;
using IocPerformance.Classes.Dummy;
using IocPerformance.Classes.Generics;
using IocPerformance.Classes.Multiple;
using IocPerformance.Classes.Properties;
using IocPerformance.Classes.Standard;
using IocPerformance.Interception;
using Zenject;

namespace IocPerformance.Adapters
{
    public sealed class ZenjectContainerAdapter : ContainerAdapterBase
    {
        private DiContainer container;

        public override string PackageName => "Zenject";

        public override string Url => "https://github.com/svermeulen/Zenject";

        public override bool SupportsInterception => false;

        public override bool SupportsPropertyInjection => true;

        public override bool SupportGeneric => true;

        public override bool SupportsConditional => true;

        public override bool SupportsMultiple => true;

        public override bool SupportsChildContainer => true;

        public override IChildContainerAdapter CreateChildContainerAdapter() => new ZenjectChildContainerAdapter(new DiContainer(this.container));

        public override object Resolve(Type type) => this.container.Resolve(type);

        public override string Version
        {
            get { return "6.4.0"; }
        }

        public override void Dispose()
        {
            // Allow the container and everything it references to be garbage collected.
            if (this.container == null)
            {
                return;
            }

            this.container = null;
        }

        public override void Prepare()
        {
            this.PrepareBasic();
            this.RegisterPropertyInjection();
            this.RegisterOpenGeneric();
            this.RegisterConditional();
            this.RegisterMultiple();
        }

        public override void PrepareBasic()
        {
            this.container = new DiContainer();

            this.RegisterDummies();
            this.RegisterStandard();
            this.RegisterComplexObject();
        }

        private void RegisterDummies()
        {
            this.container.Bind<IDummyOne>().To<DummyOne>().AsTransient();
            this.container.Bind<IDummyTwo>().To<DummyTwo>().AsTransient();
            this.container.Bind<IDummyThree>().To<DummyThree>().AsTransient();
            this.container.Bind<IDummyFour>().To<DummyFour>().AsTransient();
            this.container.Bind<IDummyFive>().To<DummyFive>().AsTransient();
            this.container.Bind<IDummySix>().To<DummySix>().AsTransient();
            this.container.Bind<IDummySeven>().To<DummySeven>().AsTransient();
            this.container.Bind<IDummyEight>().To<DummyEight>().AsTransient();
            this.container.Bind<IDummyNine>().To<DummyNine>().AsTransient();
            this.container.Bind<IDummyTen>().To<DummyTen>().AsTransient();
        }

        private void RegisterStandard()
        {
            this.container.Bind<ISingleton1>().To<Singleton1>().AsSingle();
            this.container.Bind<ISingleton2>().To<Singleton2>().AsSingle();
            this.container.Bind<ISingleton3>().To<Singleton3>().AsSingle();
            this.container.Bind<ITransient1>().To<Transient1>().AsTransient();
            this.container.Bind<ITransient2>().To<Transient2>().AsTransient();
            this.container.Bind<ITransient3>().To<Transient3>().AsTransient();
            this.container.Bind<ICombined1>().To<Combined1>().AsTransient();
            this.container.Bind<ICombined2>().To<Combined2>().AsTransient();
            this.container.Bind<ICombined3>().To<Combined3>().AsTransient();
        }

        private void RegisterComplexObject()
        {
            this.container.Bind<IFirstService>().To<FirstService>().AsSingle();
            this.container.Bind<ISecondService>().To<SecondService>().AsSingle();
            this.container.Bind<IThirdService>().To<ThirdService>().AsSingle();
            this.container.Bind<ISubObjectA>().To<SubObjectA>().AsTransient();
            this.container.Bind<ISubObjectB>().To<SubObjectB>().AsTransient();
            this.container.Bind<ISubObjectC>().To<SubObjectC>().AsTransient();
            this.container.Bind<IComplex1>().To<Complex1>().AsTransient();
            this.container.Bind<IComplex2>().To<Complex2>().AsTransient();
            this.container.Bind<IComplex3>().To<Complex3>().AsTransient();
        }

        private void RegisterPropertyInjection()
        {
            this.container.Bind<IComplexPropertyObject1>().To<ComplexPropertyObject1>().AsTransient();
            this.container.Bind<IComplexPropertyObject2>().To<ComplexPropertyObject2>().AsTransient();
            this.container.Bind<IComplexPropertyObject3>().To<ComplexPropertyObject3>().AsTransient();
            this.container.Bind<IServiceA>().To<ServiceA>().AsSingle();
            this.container.Bind<IServiceB>().To<ServiceB>().AsSingle();
            this.container.Bind<IServiceC>().To<ServiceC>().AsSingle();
            this.container.Bind<ISubObjectOne>().To<SubObjectOne>().AsTransient();
            this.container.Bind<ISubObjectTwo>().To<SubObjectTwo>().AsTransient();
            this.container.Bind<ISubObjectThree>().To<SubObjectThree>().AsTransient();
        }

        private void RegisterOpenGeneric()
        {
            this.container.Bind(typeof(IGenericInterface<>)).To(typeof(GenericExport<>)).AsTransient();
            this.container.Bind(typeof(ImportGeneric<>)).AsTransient();
        }

        private void RegisterConditional()
        {
            this.container.Bind<ImportConditionObject1>().To<ImportConditionObject1>().AsTransient();
            this.container.Bind<ImportConditionObject2>().To<ImportConditionObject2>().AsTransient();
            this.container.Bind<ImportConditionObject3>().To<ImportConditionObject3>().AsTransient();
            this.container.Bind<IExportConditionInterface>()
                .To<ExportConditionalObject1>()
                .AsTransient()
                .WhenInjectedInto<ImportConditionObject1>();
            this.container.Bind<IExportConditionInterface>()
                .To<ExportConditionalObject2>()
                .AsTransient()
                .WhenInjectedInto<ImportConditionObject2>();
            this.container.Bind<IExportConditionInterface>()
                .To<ExportConditionalObject3>()
                .AsTransient()
                .WhenInjectedInto<ImportConditionObject3>();
        }

        private void RegisterMultiple()
        {
            this.container.Bind<ISimpleAdapter>().To<SimpleAdapterOne>().AsTransient();
            this.container.Bind<ISimpleAdapter>().To<SimpleAdapterTwo>().AsTransient();
            this.container.Bind<ISimpleAdapter>().To<SimpleAdapterThree>().AsTransient();
            this.container.Bind<ISimpleAdapter>().To<SimpleAdapterFour>().AsTransient();
            this.container.Bind<ISimpleAdapter>().To<SimpleAdapterFive>().AsTransient();
            this.container.Bind<ImportMultiple1>().To<ImportMultiple1>().AsTransient();
            this.container.Bind<ImportMultiple2>().To<ImportMultiple2>().AsTransient();
            this.container.Bind<ImportMultiple3>().To<ImportMultiple3>().AsTransient();
        }
    }

    public class ZenjectChildContainerAdapter : IChildContainerAdapter
    {
        private DiContainer childKernel;

        public ZenjectChildContainerAdapter(DiContainer childKernel)
        {
            this.childKernel = childKernel;
        }

        public void Dispose()
        {
        }

        public void Prepare()
        {
            this.childKernel.Bind<ITransient1>().To<ScopedTransient>().AsTransient();
            this.childKernel.Bind<ICombined1>().To<ScopedCombined1>().AsTransient();
            this.childKernel.Bind<ICombined2>().To<ScopedCombined2>().AsTransient();
            this.childKernel.Bind<ICombined3>().To<ScopedCombined3>().AsTransient();
        }

        public object Resolve(Type resolveType) => this.childKernel.Resolve(resolveType);
    }
}
