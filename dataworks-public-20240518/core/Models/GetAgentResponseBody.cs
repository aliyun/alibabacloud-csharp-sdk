// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentResponseBody : TeaModel {
        [NameInMap("Agent")]
        [Validation(Required=false)]
        public GetAgentResponseBodyAgent Agent { get; set; }
        public class GetAgentResponseBodyAgent : TeaModel {
            [NameInMap("CallableAgents")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentCallableAgents> CallableAgents { get; set; }
            public class GetAgentResponseBodyAgentCallableAgents : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sub-agent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public GetAgentResponseBodyAgentModel Model { get; set; }
            public class GetAgentResponseBodyAgentModel : TeaModel {
                [NameInMap("Config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                [NameInMap("MaxTokens")]
                [Validation(Required=false)]
                public int? MaxTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen3-max</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("Stream")]
                [Validation(Required=false)]
                public bool? Stream { get; set; }

                [NameInMap("Temperature")]
                [Validation(Required=false)]
                public double? Temperature { get; set; }

                [NameInMap("TopP")]
                [Validation(Required=false)]
                public double? TopP { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-agent</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RequiredRuntime")]
            [Validation(Required=false)]
            public List<string> RequiredRuntime { get; set; }

            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentSkills> Skills { get; set; }
            public class GetAgentResponseBodyAgentSkills : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-skill</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            [NameInMap("SystemPrompt")]
            [Validation(Required=false)]
            public string SystemPrompt { get; set; }

            [NameInMap("Tools")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentTools> Tools { get; set; }
            public class GetAgentResponseBodyAgentTools : TeaModel {
                [NameInMap("BuiltinName")]
                [Validation(Required=false)]
                public string BuiltinName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>builtin</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                [NameInMap("McpItems")]
                [Validation(Required=false)]
                public List<string> McpItems { get; set; }

                [NameInMap("McpServerName")]
                [Validation(Required=false)]
                public string McpServerName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TENANT</para>
            /// </summary>
            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

            [NameInMap("VisibilityScope")]
            [Validation(Required=false)]
            public GetAgentResponseBodyAgentVisibilityScope VisibilityScope { get; set; }
            public class GetAgentResponseBodyAgentVisibilityScope : TeaModel {
                [NameInMap("ProjectIds")]
                [Validation(Required=false)]
                public List<string> ProjectIds { get; set; }

                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>824F80BA-1778-5D8A-BAFF-668A4D9C4CC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
