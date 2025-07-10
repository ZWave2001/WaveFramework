using System;

namespace WaveFramework
{
    /// <summary>
    /// 游戏事件类
    /// </summary>
    public static class Event
    {
        private static readonly EventMgr _eventMgr = new EventMgr();

        public static EventMgr EventMgr => _eventMgr;


        /// <summary>
        /// 添加事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <returns>是否添加成功</returns>
        public static bool AddEventListener(string eventId, Action handler)
        {
            return _eventMgr.AddEventListener(StringId.StringToHash(eventId), handler);
        }

        /// <summary>
        /// 添加事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <returns>是否添加成功</returns>
        public static bool AddEventListener<T1>(string eventId, Action<T1> handler)
        {
            return _eventMgr.AddEventListener(StringId.StringToHash(eventId), handler);
        }


        /// <summary>
        /// 添加事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <returns>是否添加成功</returns>
        public static bool AddEventListener<T1, T2>(string eventId, Action<T1, T2> handler)
        {
            return _eventMgr.AddEventListener(StringId.StringToHash(eventId), handler);
        }

        /// <summary>
        /// 添加事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <returns>是否添加成功</returns>
        public static bool AddEventListener<T1, T2, T3>(string eventId, Action<T1, T2, T3> handler)
        {
            return _eventMgr.AddEventListener(StringId.StringToHash(eventId), handler);
        }

        /// <summary>
        /// 添加事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <typeparam name="T4">参数4类型</typeparam>
        /// <returns>是否添加成功</returns>
        public static bool AddEventListener<T1, T2, T3, T4>(string eventId, Action<T1, T2, T3, T4> handler)
        {
            return _eventMgr.AddEventListener(StringId.StringToHash(eventId), handler);
        }

        /// <summary>
        /// 添加事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <typeparam name="T4">参数4类型</typeparam>
        /// <typeparam name="T5">参数5类型</typeparam>
        /// <returns>是否添加成功</returns>
        public static bool AddEventListener<T1, T2, T3, T4, T5>(string eventId, Action<T1, T2, T3, T4, T5> handler)
        {
            return _eventMgr.AddEventListener(StringId.StringToHash(eventId), handler);
        }

        /// <summary>
        /// 添加事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <typeparam name="T4">参数4类型</typeparam>
        /// <typeparam name="T5">参数5类型</typeparam>
        /// <typeparam name="T6">参数6类型</typeparam>
        /// <returns>是否添加成功</returns>
        public static bool AddEventListener<T1, T2, T3, T4, T5, T6>(string eventId,
            Action<T1, T2, T3, T4, T5, T6> handler)
        {
            return _eventMgr.AddEventListener(StringId.StringToHash(eventId), handler);
        }


        /// <summary>
        /// 移除事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <returns>是否移除成功</returns>
        public static bool RemoveEventListener(string eventId, Action handler)
        {
            return _eventMgr.RemoveListener(StringId.StringToHash(eventId), handler);
        }


        /// <summary>
        /// 移除事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <returns>是否移除成功</returns>
        public static bool RemoveEventListener<T1>(string eventId, Action<T1> handler)
        {
            return _eventMgr.RemoveListener(StringId.StringToHash(eventId), handler);
        }

        /// <summary>
        /// 移除事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <returns>是否移除成功</returns>
        public static bool RemoveEventListener<T1, T2>(string eventId, Action<T1, T2> handler)
        {
            return _eventMgr.RemoveListener(StringId.StringToHash(eventId), handler);
        }

        /// <summary>
        /// 移除事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <returns>是否移除成功</returns>
        public static bool RemoveEventListener<T1, T2, T3>(string eventId, Action<T1, T2, T3> handler)
        {
            return _eventMgr.RemoveListener(StringId.StringToHash(eventId), handler);
        }


        /// <summary>
        /// 移除事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <typeparam name="T4">参数4类型</typeparam>
        /// <returns>是否移除成功</returns>
        public static bool RemoveEventListener<T1, T2, T3, T4>(string eventId, Action<T1, T2, T3, T4> handler)
        {
            return _eventMgr.RemoveListener(StringId.StringToHash(eventId), handler);
        }

        /// <summary>
        /// 移除事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <typeparam name="T4">参数4类型</typeparam>
        /// <typeparam name="T5">参数5类型</typeparam>
        /// <returns>是否移除成功</returns>
        public static bool RemoveEventListener<T1, T2, T3, T4, T5>(string eventId, Action<T1, T2, T3, T4, T5> handler)
        {
            return _eventMgr.RemoveListener(StringId.StringToHash(eventId), handler);
        }


        /// <summary>
        /// 移除事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <typeparam name="T4">参数4类型</typeparam>
        /// <typeparam name="T5">参数5类型</typeparam>
        /// <typeparam name="T6">参数6类型</typeparam>
        /// <returns>是否移除成功</returns>
        public static bool RemoveEventListener<T1, T2, T3, T4, T5, T6>(string eventId,
            Action<T1, T2, T3, T4, T5, T6> handler)
        {
            return _eventMgr.RemoveListener(StringId.StringToHash(eventId), handler);
        }


        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventId">事件id</param>
        public static void Send(string eventId)
        {
            _eventMgr.Send(StringId.StringToHash(eventId));
        }


        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="arg1">参数1</param>
        /// <typeparam name="T1">参数类型1</typeparam>
        public static void Send<T1>(string eventId, T1 arg1)
        {
            _eventMgr.Send(StringId.StringToHash(eventId), arg1);
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <typeparam name="T1">参数类型1</typeparam>
        /// <typeparam name="T2">参数类型2</typeparam>
        public static void Send<T1, T2>(string eventId, T1 arg1, T2 arg2)
        {
            _eventMgr.Send(StringId.StringToHash(eventId), arg1, arg2);
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <param name="arg3">参数3</param>
        /// <typeparam name="T1">参数类型1</typeparam>
        /// <typeparam name="T2">参数类型2</typeparam>
        /// <typeparam name="T3">参数类型3</typeparam>
        public static void Send<T1, T2, T3>(string eventId, T1 arg1, T2 arg2, T3 arg3)
        {
            _eventMgr.Send(StringId.StringToHash(eventId), arg1, arg2, arg3);
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <param name="arg3">参数3</param>
        /// <param name="arg4">参数4</param>
        /// <typeparam name="T1">参数类型1</typeparam>
        /// <typeparam name="T2">参数类型2</typeparam>
        /// <typeparam name="T3">参数类型3</typeparam>
        /// <typeparam name="T4">参数类型4</typeparam>
        public static void Send<T1, T2, T3, T4>(string eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            _eventMgr.Send(StringId.StringToHash(eventId), arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <param name="arg3">参数3</param>
        /// <param name="arg4">参数4</param>
        /// <param name="arg5">参数4</param>
        /// <typeparam name="T1">参数类型1</typeparam>
        /// <typeparam name="T2">参数类型2</typeparam>
        /// <typeparam name="T3">参数类型3</typeparam>
        /// <typeparam name="T4">参数类型4</typeparam>
        /// <typeparam name="T5">参数类型4</typeparam>
        public static void Send<T1, T2, T3, T4, T5>(string eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            _eventMgr.Send(StringId.StringToHash(eventId), arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <param name="arg3">参数3</param>
        /// <param name="arg4">参数4</param>
        /// <param name="arg5">参数4</param>
        /// <param name="arg6">参数4</param>
        /// <typeparam name="T1">参数类型1</typeparam>
        /// <typeparam name="T2">参数类型2</typeparam>
        /// <typeparam name="T3">参数类型3</typeparam>
        /// <typeparam name="T4">参数类型4</typeparam>
        /// <typeparam name="T5">参数类型4</typeparam>
        /// <typeparam name="T6">参数类型4</typeparam>
        public static void Send<T1, T2, T3, T4, T5, T6>(string eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            T6 arg6)
        {
            _eventMgr.Send(StringId.StringToHash(eventId), arg1, arg2, arg3, arg4, arg5, arg6);
        }


        /// <summary>
        /// 清除事件。
        /// </summary>
        public static void Shutdown()
        {
            _eventMgr.Init();
        }
    }
}