// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class GetFlinkAiServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The Flink AI service data transfer object.</para>
        /// </summary>
        [NameInMap("FlinkAiServiceDTO")]
        [Validation(Required=false)]
        public GetFlinkAiServiceResponseBodyFlinkAiServiceDTO FlinkAiServiceDTO { get; set; }
        public class GetFlinkAiServiceResponseBodyFlinkAiServiceDTO : TeaModel {
            /// <summary>
            /// <para>Indicates whether deletion protection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The status of the Flink AI instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CLOSED: closed or not activated.</description></item>
            /// <item><description>WAITING: waiting to be activated after payment.</description></item>
            /// <item><description>OPENING: being activated.</description></item>
            /// <item><description>RUNNING: activated.</description></item>
            /// <item><description>CLOSING: being closed.</description></item>
            /// <item><description>DISABLE: overdue payment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLOSED</para>
            /// </summary>
            [NameInMap("FlinkAiInstanceStatus")]
            [Validation(Required=false)]
            public string FlinkAiInstanceStatus { get; set; }

            /// <summary>
            /// <para>The AI service order instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sc_flinkaifuncpost_public_cn-o3s4xabcdef</para>
            /// </summary>
            [NameInMap("MainInstanceId")]
            [Validation(Required=false)]
            public string MainInstanceId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The time when the AI service was activated, in timestamp format (milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786934292</para>
            /// </summary>
            [NameInMap("ResourceCreateTime")]
            [Validation(Required=false)]
            public long? ResourceCreateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B21DC47E-8928-199A-9F32-36D45E4693B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
