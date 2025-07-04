using Content;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Game
{
    public class GameScope : LifetimeScope
    {
        [SerializeField] private ContentProvider _contentProvider;
        
        protected override void Configure(IContainerBuilder builder)
        {
            RegisterContent(builder);
            builder.RegisterEntryPoint<LevelCreator>();
        }

        private void RegisterContent(IContainerBuilder builder)
        {
            builder.RegisterInstance(_contentProvider.Levels);
            builder.RegisterInstance(_contentProvider.PlayerContent);
            builder.RegisterInstance(_contentProvider.ProjectileContent);
            builder.RegisterInstance(_contentProvider.EnemyContent);
        }
    }
}