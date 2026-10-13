// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the dedicated agent was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-04T02:25:43Z</para>
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
        /// <para>The backup set ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17053</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the dedicated agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Query Instance List Agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        public List<GetCustomAgentResponseBodySkills> Skills { get; set; }
        public class GetCustomAgentResponseBodySkills : TeaModel {
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
        /// <para>The system prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I am your dedicated agent for querying instance lists</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The tool details.</para>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public List<string> Tools { get; set; }

        /// <summary>
        /// <para>The time when the dedicated agent was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-27 16:02:28</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
