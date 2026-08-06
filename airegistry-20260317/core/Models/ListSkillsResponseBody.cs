// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class ListSkillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of rule information returned when the call succeeds. For more information, see <b>RuleInfo</b>.</para>
        /// <remarks>
        /// <para>The returned rule information is sorted by rule creation time in descending order.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSkillsResponseBodyData Data { get; set; }
        public class ListSkillsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The MCP server information.</para>
            /// </summary>
            [NameInMap("PageItems")]
            [Validation(Required=false)]
            public List<ListSkillsResponseBodyDataPageItems> PageItems { get; set; }
            public class ListSkillsResponseBodyDataPageItems : TeaModel {
                /// <summary>
                /// <para>The business tags as a JSON array string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BizTags")]
                [Validation(Required=false)]
                public string BizTags { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>secret for bbtadmin</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The total number of downloads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DownloadCount")]
                [Validation(Required=false)]
                public long? DownloadCount { get; set; }

                /// <summary>
                /// <para>The version being edited.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.3</para>
                /// </summary>
                [NameInMap("EditingVersion")]
                [Validation(Required=false)]
                public string EditingVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the skill is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The source tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aqs</para>
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                /// <summary>
                /// <para>The label mapping.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OCR品牌</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the group or workspace to which the repository belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou:creatulize-test</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The number of online versions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OnlineCnt")]
                [Validation(Required=false)]
                public int? OnlineCnt { get; set; }

                /// <summary>
                /// <para>The account ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>manual</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The version under review.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.2</para>
                /// </summary>
                [NameInMap("ReviewingVersion")]
                [Validation(Required=false)]
                public string ReviewingVersion { get; set; }

                /// <summary>
                /// <para>The visibility scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rd-yORclL</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-05T19:24:43.798</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the skill can be edited.</para>
                /// </summary>
                [NameInMap("Writeable")]
                [Validation(Required=false)]
                public bool? Writeable { get; set; }

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
            /// <para>pagesAvailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PagesAvailable")]
            [Validation(Required=false)]
            public int? PagesAvailable { get; set; }

            /// <summary>
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>195BF118-9AEF-5F3F-9A58-D88A77EB07DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
