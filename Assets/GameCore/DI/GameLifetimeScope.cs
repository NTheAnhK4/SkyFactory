

using VContainer;
using VContainer.Unity;

namespace GameCore.DI
{
    public class GameLifetimeScope : LifetimeScope
    {
       
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
           
            
           
            //
            // builder.Register<LoadingState>(Lifetime.Scoped);
            // builder.Register<AdvantureState>(Lifetime.Scoped);
            // builder.Register<WinState>(Lifetime.Scoped);
            // builder.Register<LobbyState>(Lifetime.Scoped);
            // builder.Register<LoseState>(Lifetime.Scoped);
            // builder.RegisterVitalRouter(routing =>
            // {
            //     routing.MapEntryPoint<GameFSM>();
            // });
        }
    }

}

