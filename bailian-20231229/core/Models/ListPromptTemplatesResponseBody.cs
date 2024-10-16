// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListPromptTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dc270401186b433f975d7e1faaa34e0e</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("promptTemplates")]
        [Validation(Required=false)]
        public List<ListPromptTemplatesResponseBodyPromptTemplates> PromptTemplates { get; set; }
        public class ListPromptTemplatesResponseBodyPromptTemplates : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d6935b7efbe34d11b13df9307151cf8c</para>
            /// </summary>
            [NameInMap("promptTemplateId")]
            [Validation(Required=false)]
            public string PromptTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;System&quot;</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("variables")]
            [Validation(Required=false)]
            public List<string> Variables { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE9B6CBF-47E6-5D76-9C5D-B814DD5AB071</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-us9hjmt32nysdxxx</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
