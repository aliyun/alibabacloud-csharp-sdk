// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkCreateExtenResponseBody : TeaModel {
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
        public ClinkCreateExtenResponseBodyData Data { get; set; }
        public class ClinkCreateExtenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <para>分机</para>
            /// </summary>
            [NameInMap("Exten")]
            [Validation(Required=false)]
            public ClinkCreateExtenResponseBodyDataExten Exten { get; set; }
            public class ClinkCreateExtenResponseBodyDataExten : TeaModel {
                /// <summary>
                /// <para>语音编码。 1：g729(已弃用) 2：g729,alaw,ulaw 3：alaw,ulaw,g729 4：myopus,alaw,ulaw,g729 5：alaw,ulaw 6：myopus,alaw,ulaw</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Allow")]
                [Validation(Required=false)]
                public long? Allow { get; set; }

                /// <summary>
                /// <para>话机区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>010</para>
                /// </summary>
                [NameInMap("AreaCode")]
                [Validation(Required=false)]
                public string AreaCode { get; set; }

                /// <summary>
                /// <para>话机号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>11354</para>
                /// </summary>
                [NameInMap("ExtenNumber")]
                [Validation(Required=false)]
                public string ExtenNumber { get; set; }

                /// <summary>
                /// <para>是否允许主叫外呼，1：允许；0：不允许。话机类型为IP话机时，可以开启主叫外呼功能，直接通过IP话机进行外呼。若要使用主叫外呼功能，需要开启企业级开关。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsDirect")]
                [Validation(Required=false)]
                public long? IsDirect { get; set; }

                /// <summary>
                /// <para>网络防抖开关，0：关闭；1：开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("JittBuffer")]
                [Validation(Required=false)]
                public long? JittBuffer { get; set; }

                /// <summary>
                /// <para>话机密码，密码规则参见企业配置</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>话机类型。1: IP话机， 2: 软电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public long? Type { get; set; }

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
        /// <para>7BF47617-7851-48F7-A3A1-2021342A78E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
