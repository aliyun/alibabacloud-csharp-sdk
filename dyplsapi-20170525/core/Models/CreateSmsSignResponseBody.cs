// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreateSmsSignResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>返回状态码 0000表示成功 其他表示失败</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSmsSignResponseBodyData Data { get; set; }
        public class CreateSmsSignResponseBodyData : TeaModel {
            /// <summary>
            /// <para>短信接收者号码签名串(加到短信内容中供解析真实被叫号码)</para>
            /// 
            /// <b>Example:</b>
            /// <para>sign23343466</para>
            /// </summary>
            [NameInMap("CalledNoSign")]
            [Validation(Required=false)]
            public string CalledNoSign { get; set; }

        }

        /// <summary>
        /// <para>返回信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>返回是否成功 true  表示成功 false表示失败</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
