using System;
using System.Collections.Generic;

namespace WaveFramework
{
    /// <summary>
    /// 事件管理器
    /// </summary>
    public class EventMgr
    {
        /// <summary>
        /// 事件字典
        /// </summary>
        private static readonly Dictionary<int, EventDelegateData>
            _eventDict = new Dictionary<int, EventDelegateData>();


        /// <summary>
        /// 添加事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <returns>是否添加成功</returns>
        public bool AddEventListener(int eventId, Delegate handler)
        {
            if (!_eventDict.TryGetValue(eventId, out var data))
            {
                data = ReferencePool.Acquire<EventDelegateData>();
                data.eventId = eventId;
                
                _eventDict.Add(eventId, data);
            }

            return data.AddHandler(handler);
        }


        /// <summary>
        /// 移除事件监听
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="handler">回调</param>
        /// <returns>是否移除成功</returns>
        public bool RemoveListener(int eventId, Delegate handler)
        {
            if (_eventDict.TryGetValue(eventId, out var data))
            {
                return data.RemoveHandler(handler);
            }

            Log.Fatal($"RemoveEvent failed, Event {StringId.HashToString(eventId)} not found");
            return false;
        }


        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventId">事件id</param>
        public void Send(int eventId)
        {
            if (_eventDict.TryGetValue(eventId, out var data))
            {
                data.Callback();
            }
        }


        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="arg1">参数1</param>
        /// <typeparam name="T1">参数类型1</typeparam>
        public void Send<T1>(int eventId, T1 arg1)
        {
            if (_eventDict.TryGetValue(eventId, out var data))
            {
                data.Callback(arg1);
            }
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventId">事件id</param>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <typeparam name="T1">参数类型1</typeparam>
        /// <typeparam name="T2">参数类型2</typeparam>
        public void Send<T1, T2>(int eventId, T1 arg1, T2 arg2)
        {
            if (_eventDict.TryGetValue(eventId, out var data))
            {
                data.Callback(arg1, arg2);
            }
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
        public void Send<T1, T2, T3>(int eventId, T1 arg1, T2 arg2, T3 arg3)
        {
            if (_eventDict.TryGetValue(eventId, out var data))
            {
                data.Callback(arg1, arg2, arg3);
            }
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
        public void Send<T1, T2, T3, T4>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (_eventDict.TryGetValue(eventId, out var data))
            {
                data.Callback(arg1, arg2, arg3, arg4);
            }
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
        public void Send<T1, T2, T3, T4, T5>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (_eventDict.TryGetValue(eventId, out var data))
            {
                data.Callback(arg1, arg2, arg3, arg4, arg5);
            }
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
        public void Send<T1, T2, T3, T4, T5, T6>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (_eventDict.TryGetValue(eventId, out var data))
            {
                data.Callback(arg1, arg2, arg3, arg4, arg5, arg6);
            }
        }

        public void Init()
        {
            _eventDict.Clear();
        }
    }
}