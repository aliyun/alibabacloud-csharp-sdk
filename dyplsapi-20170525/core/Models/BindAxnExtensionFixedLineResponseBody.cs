// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxnExtensionFixedLineResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>响应码 0：成功，其它失败，具体见文档</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>响应信息</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindAxnExtensionFixedLineResponseBodyData Data { get; set; }
        public class BindAxnExtensionFixedLineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>绑定id</para>
            /// 
            /// <b>Example:</b>
            /// <para>GHX0534X202504221531579290029</para>
            /// </summary>
            [NameInMap("Subid")]
            [Validation(Required=false)]
            public string Subid { get; set; }

            /// <summary>
            /// <para>隐私号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>0571409312</para>
            /// </summary>
            [NameInMap("TelX")]
            [Validation(Required=false)]
            public string TelX { get; set; }

            /// <summary>
            /// <para>分机号，只有4位</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("TelXext")]
            [Validation(Required=false)]
            public string TelXext { get; set; }

        }

        /// <summary>
        /// <para>描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AE2D6997-643A-59CB-9B3C-918572E5CEAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
