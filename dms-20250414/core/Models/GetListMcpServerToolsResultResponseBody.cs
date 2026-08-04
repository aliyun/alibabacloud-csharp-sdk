// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetListMcpServerToolsResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The MCP Server connectivity detection result. The business status is distinguished by the State field.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetListMcpServerToolsResultResponseBodyData Data { get; set; }
        public class GetListMcpServerToolsResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the MCP Server is accessible. The value is true only when State is success.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Accessible")]
            [Validation(Required=false)]
            public bool? Accessible { get; set; }

            /// <summary>
            /// <para>The detection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending: The detection is in progress.</description></item>
            /// <item><description>success: The detection succeeded.</description></item>
            /// <item><description>failed: The detection failed or timed out.</description></item>
            /// </list>
            /// <para>The top-level Success field can be true in all three business states.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The list of detected MCP tools. A non-empty list is returned only when State is success.</para>
            /// </summary>
            [NameInMap("Tools")]
            [Validation(Required=false)]
            public List<GetListMcpServerToolsResultResponseBodyDataTools> Tools { get; set; }
            public class GetListMcpServerToolsResultResponseBodyDataTools : TeaModel {
                /// <summary>
                /// <para>The description of the MCP tool functionality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>query user information by user ID</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The JSON Schema string of the tool input parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;userId&quot;:{&quot;type&quot;:&quot;string&quot;}}}</para>
                /// </summary>
                [NameInMap("InputSchema")]
                [Validation(Required=false)]
                public string InputSchema { get; set; }

                /// <summary>
                /// <para>The MCP tool name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>query_user</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The return code. The value success is returned if the request succeeds. An error code is returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when a system-level request failure occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no mcp connect test record for session</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550***544</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
