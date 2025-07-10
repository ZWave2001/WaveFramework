using System;

namespace WaveFramework
{
    public enum ShutdownType : byte
    {
        /// <summary>
        /// 仅关闭游戏框架
        /// </summary>
        None = 0,

        /// <summary>
        /// 关闭游戏框架并重启游戏
        /// </summary>
        Restart,

        /// <summary>
        /// 关闭游戏框架并退出游戏
        /// </summary>
        Quit,
    }


    public static class ModuleSystem
    {
        private static readonly GameFrameworkLinkedList<Module> _modules = new GameFrameworkLinkedList<Module>();


        /// <summary>
        /// 游戏框架所在的场景编号
        /// </summary>
        internal const int GameFrameworkSceneID = 0;


        public static T GetModule<T>() where T : Module
        {
            return (T)GetModule(typeof(T));
        }

        public static Module GetModule(Type type)
        {
            var current = _modules.First;
            while (current != null)
            {
                if (current.Value.GetType() == type)
                    return current.Value;

                current = current.Next;
            }

            return null;
        }


        public static Module GetModule(string typeName)
        {
            var current = _modules.First;
            while (current != null)
            {
                var type = current.Value.GetType();
                if (type.Name == typeName || type.FullName == typeName)
                    return current.Value;
                current = current.Next;
            }

            return null;
        }


        public static void Shutdown(ShutdownType shutdownType)
        {
            Log.Info($"Shutdown GameFramework {shutdownType}");
        }


        /// <summary>
        /// 注册模块
        /// </summary>
        /// <param name="module">模块类型</param>
        internal static void RegisterModule(Module module)
        {
            if (module == null)
            {
                Log.Error("Module is invalid");
                return;
            }


            Type type = module.GetType();

            var current = _modules.First;
            while (current != null)
            {
                if (current.Value.GetType() == type)
                {
                    Log.Error($"Module {type.Name} is already registered");
                    return;
                }

                current = current.Next;
            }

            _modules.AddLast(module);
        }
    }
}