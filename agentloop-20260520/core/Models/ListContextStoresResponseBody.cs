// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListContextStoresResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results per page specified in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. An empty string indicates that the last page is reached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used to locate the request during troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of context stores.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<ListContextStoresResponseBodyResults> Results { get; set; }
        public class ListContextStoresResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The name of the AgentSpace to which the context store belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-space</para>
            /// </summary>
            [NameInMap("agentSpace")]
            [Validation(Required=false)]
            public string AgentSpace { get; set; }

            /// <summary>
            /// <para>The name of the context store.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-context-store</para>
            /// </summary>
            [NameInMap("contextStoreName")]
            [Validation(Required=false)]
            public string ContextStoreName { get; set; }

            /// <summary>
            /// <para>The type of the context store, such as experience or memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>experience</para>
            /// </summary>
            [NameInMap("contextType")]
            [Validation(Required=false)]
            public string ContextType { get; set; }

            /// <summary>
            /// <para>The time when the context store was created, in ISO 8601 UTC format.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the context store.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My context store</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the region where the context store resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of service names. This parameter has a value only for the experience type. It is used together with the data source AgentSpace to locate the trace data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;order-service&quot;,&quot;payment-service&quot;]</para>
            /// </summary>
            [NameInMap("serviceNames")]
            [Validation(Required=false)]
            public List<string> ServiceNames { get; set; }

            /// <summary>
            /// <para>The memory data source type, such as manual, trajectory, or dataset. This parameter has a value only for the memory type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trajectory</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The status of the context store. Valid values include ACTIVE, INITIALIZING, and FAILED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The memory storage mode, such as event or upsert. This parameter has a value only for the memory type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upsert</para>
            /// </summary>
            [NameInMap("storageMode")]
            [Validation(Required=false)]
            public string StorageMode { get; set; }

            /// <summary>
            /// <para>The time when the context store was last updated, in ISO 8601 UTC format.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-02T00:00:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of context stores that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
