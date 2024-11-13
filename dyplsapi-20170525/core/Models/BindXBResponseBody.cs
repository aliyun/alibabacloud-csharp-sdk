// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindXBResponseBody : TeaModel {
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
        public BindXBResponseBodyData Data { get; set; }
        public class BindXBResponseBodyData : TeaModel {
            /// <summary>
            /// <para>工作号关系绑定的唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>4353453456</para>
            /// </summary>
            [NameInMap("AuthId")]
            [Validation(Required=false)]
            public string AuthId { get; set; }

            /// <summary>
            /// <para>X号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>18640577897</para>
            /// </summary>
            [NameInMap("TelX")]
            [Validation(Required=false)]
            public string TelX { get; set; }

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
