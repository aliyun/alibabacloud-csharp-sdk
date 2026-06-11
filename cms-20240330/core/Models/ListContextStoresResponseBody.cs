// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListContextStoresResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If this field is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2-ba4d-4b9f-aa24-dcb067a30f1c</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of context stores.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<ListContextStoresResponseBodyResults> Results { get; set; }
        public class ListContextStoresResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The name of the context store.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-context-store</para>
            /// </summary>
            [NameInMap("contextStoreName")]
            [Validation(Required=false)]
            public string ContextStoreName { get; set; }

            /// <summary>
            /// <para>The context type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>memory</para>
            /// </summary>
            [NameInMap("contextType")]
            [Validation(Required=false)]
            public string ContextType { get; set; }

            /// <summary>
            /// <para>The creation time of the context store. The value is a Unix timestamp in milliseconds.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>173847364841938</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the context store.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the context store.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The last update time of the context store. The value is a Unix timestamp in milliseconds.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>173847364841938</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspace-test</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The total number of context stores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
