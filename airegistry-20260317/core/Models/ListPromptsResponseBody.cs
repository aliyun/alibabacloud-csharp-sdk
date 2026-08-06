// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class ListPromptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPromptsResponseBodyData Data { get; set; }
        public class ListPromptsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of prompts.</para>
            /// </summary>
            [NameInMap("PageItems")]
            [Validation(Required=false)]
            public List<ListPromptsResponseBodyDataPageItems> PageItems { get; set; }
            public class ListPromptsResponseBodyDataPageItems : TeaModel {
                /// <summary>
                /// <para>The list of business tags.</para>
                /// </summary>
                [NameInMap("BizTags")]
                [Validation(Required=false)]
                public List<string> BizTags { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test prompt</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The version number of the draft version of the prompt. This value is empty if no draft version exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.1</para>
                /// </summary>
                [NameInMap("EditingVersion")]
                [Validation(Required=false)]
                public string EditingVersion { get; set; }

                /// <summary>
                /// <para>The time when the prompt was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-22 11:51:03</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The mapping between prompt versions and labels.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <para>The latest version number of the prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.1</para>
                /// </summary>
                [NameInMap("LatestVersion")]
                [Validation(Required=false)]
                public string LatestVersion { get; set; }

                /// <summary>
                /// <para>The number of online versions of the prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OnlineCnt")]
                [Validation(Required=false)]
                public int? OnlineCnt { get; set; }

                /// <summary>
                /// <para>The unique identifier of the prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("PromptKey")]
                [Validation(Required=false)]
                public string PromptKey { get; set; }

                /// <summary>
                /// <para>The version number of the prompt version that is under review. This value is empty if no version is under review.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.1</para>
                /// </summary>
                [NameInMap("ReviewingVersion")]
                [Validation(Required=false)]
                public string ReviewingVersion { get; set; }

                /// <summary>
                /// <para>The schema version of the prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public int? SchemaVersion { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of available pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PagesAvailable")]
            [Validation(Required=false)]
            public int? PagesAvailable { get; set; }

            /// <summary>
            /// <para>The total number of prompts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9E87E66-9EF0-5C10-A5E6-924020A0C9B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
