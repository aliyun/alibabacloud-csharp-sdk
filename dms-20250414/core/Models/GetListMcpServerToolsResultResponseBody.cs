// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetListMcpServerToolsResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The connectivity detection results of the MCP server. The business status is indicated by State.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetListMcpServerToolsResultResponseBodyData Data { get; set; }
        public class GetListMcpServerToolsResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the MCP server is accessible. The value is true only when State is success.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Accessible")]
            [Validation(Required=false)]
            public bool? Accessible { get; set; }

            /// <summary>
            /// <para>The detection status. Valid values: pending: The detection is in progress. success: The detection succeeded. failed: The detection failed or timed out. The top-level Success field can be true in all three business statuses.</para>
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
                /// <para>The description of the MCP tool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>query user information by user ID</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The JSON schema string for the input parameters of the tool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;userId&quot;:{&quot;type&quot;:&quot;string&quot;}}}</para>
                /// </summary>
                [NameInMap("InputSchema")]
                [Validation(Required=false)]
                public string InputSchema { get; set; }

                /// <summary>
                /// <para>The name of the MCP tool.</para>
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
        /// <para>The error code. The value is success if the request succeeds, or the corresponding error code if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request fails at the system level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no mcp connect test record for session</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550***544</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of true indicates success. A value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
