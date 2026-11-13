// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListMcpProductToolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMcpProductToolsResponseBodyData Data { get; set; }
        public class ListMcpProductToolsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of MCP tools. Each element in the list is named tool and represents a single MCP tool.</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<ListMcpProductToolsResponseBodyDataTools> Tools { get; set; }
            public class ListMcpProductToolsResponseBodyDataTools : TeaModel {
                /// <summary>
                /// <para>The annotation information of the tool, formatted as a map. The API definition declares this field only as map<any> without specifying its members or purposes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;readOnly&quot;:true}</para>
                /// </summary>
                [NameInMap("annotations")]
                [Validation(Required=false)]
                public Dictionary<string, object> Annotations { get; set; }

                /// <summary>
                /// <para>The description of the tool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Functional description of the sample tool</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The input parameter schema of the tool, formatted as a map. The API definition declares this field only as map<any> without specifying its members or constraints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;query&quot;:{&quot;type&quot;:&quot;string&quot;}}}</para>
                /// </summary>
                [NameInMap("inputSchema")]
                [Validation(Required=false)]
                public Dictionary<string, object> InputSchema { get; set; }

                /// <summary>
                /// <para>The metadata of the tool, formatted as a map. The API definition declares this field only as map<any> without specifying its members or purposes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;version&quot;:&quot;1.0.0&quot;}</para>
                /// </summary>
                [NameInMap("meta")]
                [Validation(Required=false)]
                public Dictionary<string, object> Meta { get; set; }

                /// <summary>
                /// <para>The name of the tool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-tool</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The output result schema of the tool, formatted as a map. The API definition declares this field only as map<any> without specifying its members or constraints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;result&quot;:{&quot;type&quot;:&quot;string&quot;}}}</para>
                /// </summary>
                [NameInMap("outputSchema")]
                [Validation(Required=false)]
                public Dictionary<string, object> OutputSchema { get; set; }

                /// <summary>
                /// <para>The title of the tool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample tool</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
