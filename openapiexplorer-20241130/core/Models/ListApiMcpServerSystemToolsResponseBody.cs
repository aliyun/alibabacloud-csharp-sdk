// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class ListApiMcpServerSystemToolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return on each page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The NextToken value. Use this value to retrieve more results.</para>
        /// <remarks>
        /// <para>If this parameter is not returned, no more results are available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAZjtYxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BFC4AC1-6BE4-5405-BDEC-CA288D404812</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of system tools.</para>
        /// </summary>
        [NameInMap("systemTools")]
        [Validation(Required=false)]
        public List<ListApiMcpServerSystemToolsResponseBodySystemTools> SystemTools { get; set; }
        public class ListApiMcpServerSystemToolsResponseBodySystemTools : TeaModel {
            /// <summary>
            /// <para>The description of the system tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system tool description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-system</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
