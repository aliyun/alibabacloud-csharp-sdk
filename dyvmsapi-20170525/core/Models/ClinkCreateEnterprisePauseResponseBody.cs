// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkCreateEnterprisePauseResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClinkCreateEnterprisePauseResponseBodyData Data { get; set; }
        public class ClinkCreateEnterprisePauseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>请求标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <para>企业置忙状态</para>
            /// </summary>
            [NameInMap("EnterprisePause")]
            [Validation(Required=false)]
            public ClinkCreateEnterprisePauseResponseBodyDataEnterprisePause EnterprisePause { get; set; }
            public class ClinkCreateEnterprisePauseResponseBodyDataEnterprisePause : TeaModel {
                /// <summary>
                /// <para>默认状态，0：不是；1：是</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public long? IsDefault { get; set; }

                /// <summary>
                /// <para>休息状态，0：不是；1：是</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsRest")]
                [Validation(Required=false)]
                public string IsRest { get; set; }

                /// <summary>
                /// <para>置忙状态描述（不超4个字符）</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("PauseStatus")]
                [Validation(Required=false)]
                public string PauseStatus { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6086693B-2250-17CE-A41F-06259AB6DB1B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
