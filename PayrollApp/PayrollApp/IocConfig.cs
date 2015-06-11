using IContainer = StructureMap.IContainer;

namespace PayrollApp
{
    public static class IocConfig
    {
        public static IContainer Setup()
        {

            var container = new StructureMap.Container(

                x =>
                {
                    x.AddRegistry<DataRegistry>();
                    x.Scan(y =>
                    {
                        y.WithDefaultConventions();
                        y.LookForRegistries();

                    });
                });

            return container;
        }
    }

}
