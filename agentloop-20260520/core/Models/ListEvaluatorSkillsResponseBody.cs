// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListEvaluatorSkillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page used in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJuZXh0IjoiNDAifQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FE4CD1E-FF41-56BE-B590-7A021D9C1524</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of skill summaries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;skillName&quot;:&quot;trace_context_loader&quot;,&quot;displayName&quot;:&quot;Trace 上下文读取&quot;,&quot;enable&quot;:true}]</para>
        /// </summary>
        [NameInMap("skills")]
        [Validation(Required=false)]
        public List<ListEvaluatorSkillsResponseBodySkills> Skills { get; set; }
        public class ListEvaluatorSkillsResponseBodySkills : TeaModel {
            /// <summary>
            /// <para>The creation time. This field is declared as int64 in CloudSpec, but the backend currently returns the StarOps <c>createTime</c> string field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816000</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>The skill description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>读取链路上下文辅助评估</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Trace 上下文读取</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The latest version. This field is declared in CloudSpec but is not currently populated in the backend response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816000000</para>
            /// </summary>
            [NameInMap("latestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trace_context_loader</para>
            /// </summary>
            [NameInMap("skillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The update time. This field is declared as int64 in CloudSpec, but the backend currently returns the StarOps <c>updateTime</c> string field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816600</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The total number of skills.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
