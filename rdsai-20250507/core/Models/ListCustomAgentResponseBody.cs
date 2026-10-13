// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCustomAgentResponseBodyData> Data { get; set; }
        public class ListCustomAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-27 16:01:28</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Indicates whether tools are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableTools")]
            [Validation(Required=false)]
            public bool? EnableTools { get; set; }

            /// <summary>
            /// <para>AgentId。</para>
            /// 
            /// <b>Example:</b>
            /// <para>d1b7d639-f34e-44c7-8231-987da14d****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the dedicated agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Log Analysis Agent</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The system prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I am your dedicated agent for querying instance lists</para>
            /// </summary>
            [NameInMap("SystemPrompt")]
            [Validation(Required=false)]
            public string SystemPrompt { get; set; }

            /// <summary>
            /// <para>The tool information.</para>
            /// </summary>
            [NameInMap("Tools")]
            [Validation(Required=false)]
            public List<string> Tools { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-27 16:02:28</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<ListCustomAgentResponseBodySkills> Skills { get; set; }
        public class ListCustomAgentResponseBodySkills : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SkillType")]
            [Validation(Required=false)]
            public string SkillType { get; set; }

        }

        /// <summary>
        /// <para>The total number of data records that meet the request conditions. This parameter is optional and is not returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
