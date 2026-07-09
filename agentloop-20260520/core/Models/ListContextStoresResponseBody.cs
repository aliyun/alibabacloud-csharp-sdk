// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListContextStoresResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page that was specified in the request. This value is echoed back.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. An empty string indicates that the current page is the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate and troubleshoot issues.</para>
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
            /// <para>我的上下文库</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The region ID of the context store.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of service names. This parameter has a value only for context stores of the experience type. The service names are used together with the data source AgentSpace to locate trace data sources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;order-service&quot;,&quot;payment-service&quot;]</para>
            /// </summary>
            [NameInMap("serviceNames")]
            [Validation(Required=false)]
            public List<string> ServiceNames { get; set; }

            /// <summary>
            /// <para>The status of the context store. Valid values: ACTIVE, INITIALIZING, and FAILED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>The total number of context stores that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
