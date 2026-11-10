// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable tools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTools")]
        [Validation(Required=false)]
        public string EnableTools { get; set; }

        /// <summary>
        /// <para>The agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82cf3d62-0add-47bd-869f-877131f7****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the custom agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Query instance list agent</para>
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

        /// <summary>
        /// <para>The list of associated skill details.</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<UpdateCustomAgentResponseBodySkills> Skills { get; set; }
        public class UpdateCustomAgentResponseBodySkills : TeaModel {
            /// <summary>
            /// <para>The skill description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL query optimization skill</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique identifier of the skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>82cf3d62-0add-47bd-869f-877131f7****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>query-optimization</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The skill type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("SkillType")]
            [Validation(Required=false)]
            public string SkillType { get; set; }

        }

        /// <summary>
        /// <para>The system prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I am your custom agent for querying the instance list</para>
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

    }

}
