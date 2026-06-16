// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetContextStoreResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent-space</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        [NameInMap("config")]
        [Validation(Required=false)]
        public GetContextStoreResponseBodyConfig Config { get; set; }
        public class GetContextStoreResponseBodyConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;userId&quot;:&quot;user_id&quot;,&quot;sessionId&quot;:&quot;session_id&quot;}</para>
            /// </summary>
            [NameInMap("metadataField")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetadataField { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1d</para>
            /// </summary>
            [NameInMap("miningInterval")]
            [Validation(Required=false)]
            public string MiningInterval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;order-service&quot;,&quot;payment-service&quot;]</para>
            /// </summary>
            [NameInMap("serviceNames")]
            [Validation(Required=false)]
            public List<string> ServiceNames { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigSource Source { get; set; }
            public class GetContextStoreResponseBodyConfigSource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-context-store</para>
        /// </summary>
        [NameInMap("contextStoreName")]
        [Validation(Required=false)]
        public string ContextStoreName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>experience</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>我的上下文库</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-02T00:00:00Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
