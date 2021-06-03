﻿using System;

namespace Colder.CommonUtil
{
    /// <summary>
    /// 业务异常
    /// 注:并不会当作真正的异常处理,仅为方便返回前端错误提示信息
    /// </summary>
    public class MsgException : Exception
    {
        /// <summary>
        /// 代码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public MsgException()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message">错误信息</param>
        public MsgException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message">错误信息</param>
        /// <param name="code">错误代码</param>
        public MsgException(string message, int code)
            : base(message)
        {
            Code = code;
        }
    }
}
