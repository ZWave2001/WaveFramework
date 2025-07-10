using System;
using System.Collections.Generic;

namespace WaveFramework
{
    internal class EventDelegateData : IReference
    {
        public int eventId;
        private readonly List<Delegate> _delegateList = new List<Delegate>();

        /// <summary>
        /// 构造函数
        /// </summary>
        public EventDelegateData()
        {
        }

        /// <summary>
        /// 添加注册委托
        /// </summary>
        /// <param name="handler">委托</param>
        /// <returns>是否添加成功</returns>
        internal bool AddHandler(Delegate handler)
        {
            if (_delegateList.Contains(handler))
            {
                Log.Fatal($"Repeated add handler");
                return false;
            }

            _delegateList.Add(handler);
            return true;
        }

        /// <summary>
        /// 移除注册委托
        /// </summary>
        /// <param name="handler">委托</param>
        /// <returns>是否移除成功</returns>
        internal bool RemoveHandler(Delegate handler)
        {
            if (!_delegateList.Remove(handler))
            {
                Log.Fatal($"RemoveHandler failed, Can't find handler in Event: {StringId.HashToString(eventId)}");
                return false;
            }

            _delegateList.Remove(handler);

            if (_delegateList.Count == 0)
                ReferencePool.Release(this);

            return true;
        }


        /// <summary>
        /// 执行回调
        /// </summary>
        public void Callback()
        {
            foreach (var d in _delegateList)
            {
                if (d is Action action)
                    action();
            }
        }


        /// <summary>
        /// 执行回调
        /// </summary>
        /// <param name="arg1">参数1</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        public void Callback<T1>(T1 arg1)
        {
            foreach (var d in _delegateList)
            {
                if (d is Action<T1> action)
                    action(arg1);
            }
        }


        /// <summary>
        /// 执行回调
        /// </summary>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        public void Callback<T1, T2>(T1 arg1, T2 arg2)
        {
            foreach (var d in _delegateList)
            {
                if (d is Action<T1, T2> action)
                    action(arg1, arg2);
            }
        }


        /// <summary>
        /// 执行回调
        /// </summary>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <param name="arg3">参数3</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        public void Callback<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
        {
            foreach (var d in _delegateList)
            {
                if (d is Action<T1, T2, T3> action)
                    action(arg1, arg2, arg3);
            }
        }


        /// <summary>
        /// 执行回调
        /// </summary>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <param name="arg3">参数3</param>
        /// <param name="arg4">参数4</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <typeparam name="T4">参数4类型</typeparam>
        public void Callback<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            foreach (var d in _delegateList)
            {
                if (d is Action<T1, T2, T3, T4> action)
                    action(arg1, arg2, arg3, arg4);
            }
        }


        /// <summary>
        /// 执行回调
        /// </summary>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <param name="arg3">参数3</param>
        /// <param name="arg4">参数4</param>
        /// <param name="arg5">参数5</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <typeparam name="T4">参数4类型</typeparam>
        /// <typeparam name="T5">参数5类型</typeparam>
        public void Callback<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            foreach (var d in _delegateList)
            {
                if (d is Action<T1, T2, T3, T4, T5> action)
                    action(arg1, arg2, arg3, arg4, arg5);
            }
        }


        /// <summary>
        /// 执行回调
        /// </summary>
        /// <param name="arg1">参数1</param>
        /// <param name="arg2">参数2</param>
        /// <param name="arg3">参数3</param>
        /// <param name="arg4">参数4</param>
        /// <param name="arg5">参数5</param>
        /// <param name="arg6">参数6</param>
        /// <typeparam name="T1">参数1类型</typeparam>
        /// <typeparam name="T2">参数2类型</typeparam>
        /// <typeparam name="T3">参数3类型</typeparam>
        /// <typeparam name="T4">参数4类型</typeparam>
        /// <typeparam name="T5">参数5类型</typeparam>
        /// <typeparam name="T6">参数6类型</typeparam>
        public void Callback<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            foreach (var d in _delegateList)
            {
                if (d is Action<T1, T2, T3, T4, T5, T6> action)
                    action(arg1, arg2, arg3, arg4, arg5, arg6);
            }
        }

        public void Clear()
        {
            eventId = 0;
            _delegateList.Clear();
        }
    }
}