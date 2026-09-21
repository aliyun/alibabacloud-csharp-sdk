// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSkillReferencesResponseBody : TeaModel {
        /// <summary>
        /// <para>The skill reference relationship data returned by the paged query. The data is returned with paging.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListSkillReferencesResponseBodyData Data { get; set; }
        public class ListSkillReferencesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of skill reference relationships on the current page.</para>
            /// </summary>
            [NameInMap("pageItems")]
            [Validation(Required=false)]
            public List<ListSkillReferencesResponseBodyDataPageItems> PageItems { get; set; }
            public class ListSkillReferencesResponseBodyDataPageItems : TeaModel {
                /// <summary>
                /// <para>The ID of the referencing entity (the identifier of the Agent or AgentSpec).</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-1234567890abcdef</para>
                /// </summary>
                [NameInMap("ownerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The type of the referencing entity. Valid values: AGENT and AGENTSPEC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT</para>
                /// </summary>
                [NameInMap("ownerType")]
                [Validation(Required=false)]
                public string OwnerType { get; set; }

                /// <summary>
                /// <para>The version of the referencing entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("ownerVersion")]
                [Validation(Required=false)]
                public string OwnerVersion { get; set; }

                /// <summary>
                /// <para>The reference selector type. Valid values: LABEL and VERSION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LABEL</para>
                /// </summary>
                [NameInMap("selectorType")]
                [Validation(Required=false)]
                public string SelectorType { get; set; }

                /// <summary>
                /// <para>The reference selector value, such as latest, a named label, HEAD, or a specific version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEAD</para>
                /// </summary>
                [NameInMap("selectorValue")]
                [Validation(Required=false)]
                public string SelectorValue { get; set; }

                /// <summary>
                /// <para>The name of the referenced skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>web-search</para>
                /// </summary>
                [NameInMap("skillName")]
                [Validation(Required=false)]
                public string SkillName { get; set; }

                /// <summary>
                /// <para>The workspace ID to which the reference belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ws-1234567890abcdef</para>
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            /// <summary>
            /// <para>The current page number, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The total number of available pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("pagesAvailable")]
            [Validation(Required=false)]
            public int? PagesAvailable { get; set; }

            /// <summary>
            /// <para>The total number of reference relationships that match the filter conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C6D9E10-1234-5678-9ABC-DEF012345678</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
