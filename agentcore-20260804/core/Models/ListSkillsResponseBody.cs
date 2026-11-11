// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSkillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListSkillsResponseBodyData Data { get; set; }
        public class ListSkillsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data on the current page.</para>
            /// </summary>
            [NameInMap("pageItems")]
            [Validation(Required=false)]
            public List<ListSkillsResponseBodyDataPageItems> PageItems { get; set; }
            public class ListSkillsResponseBodyDataPageItems : TeaModel {
                /// <summary>
                /// <para>The JSON array string of business tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample property value</para>
                /// </summary>
                [NameInMap("bizTags")]
                [Validation(Required=false)]
                public string BizTags { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample description used to illustrate the purpose of the resource</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The total number of downloads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("downloadCount")]
                [Validation(Required=false)]
                public long? DownloadCount { get; set; }

                /// <summary>
                /// <para>The draft mode. Valid values: HEAD (the skill has a persistent draft) and VERSIONED (a versioned draft is created for each edit). This value is determined by the server and used by the caller to render the status column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEAD</para>
                /// </summary>
                [NameInMap("draftMode")]
                [Validation(Required=false)]
                public string DraftMode { get; set; }

                /// <summary>
                /// <para>Specifies whether the page item is editable.</para>
                /// </summary>
                [NameInMap("editable")]
                [Validation(Required=false)]
                public bool? Editable { get; set; }

                /// <summary>
                /// <para>The version being edited. The value is HEAD in HEAD draft mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("editingVersion")]
                [Validation(Required=false)]
                public string EditingVersion { get; set; }

                /// <summary>
                /// <para>Specifies whether the skill is enabled.</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The source tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UPLOAD</para>
                /// </summary>
                [NameInMap("from")]
                [Validation(Required=false)]
                public string From { get; set; }

                /// <summary>
                /// <para>The label mapping.</para>
                /// </summary>
                [NameInMap("labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skill-example</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of online versions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("onlineCnt")]
                [Validation(Required=false)]
                public int? OnlineCnt { get; set; }

                /// <summary>
                /// <para>The resource owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alice</para>
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The version under review. The value is HEAD in HEAD draft mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("reviewingVersion")]
                [Validation(Required=false)]
                public string ReviewingVersion { get; set; }

                /// <summary>
                /// <para>The visibility scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRIVATE</para>
                /// </summary>
                [NameInMap("scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1787671022000</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ws-1234567890abcdef</para>
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>Specifies whether the current user has write permissions.</para>
                /// </summary>
                [NameInMap("writeable")]
                [Validation(Required=false)]
                public bool? Writeable { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("pagesAvailable")]
            [Validation(Required=false)]
            public int? PagesAvailable { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of items to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-page-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-47A8-90AB-CDEF12345678</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
