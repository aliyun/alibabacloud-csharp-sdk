// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateWorkflowNodeConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the current user can edit this node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canEdit")]
        [Validation(Required=false)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// <para>The common business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The configuration version. Use this value as the expectedVersion when updating or restoring.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("configVersion")]
        [Validation(Required=false)]
        public long? ConfigVersion { get; set; }

        /// <summary>
        /// <para>The default executor defined in the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;AGENT&quot;,&quot;id&quot;:&quot;agent_1001&quot;}</para>
        /// </summary>
        [NameInMap("defaultExecutor")]
        [Validation(Required=false)]
        public UpdateWorkflowNodeConfigurationResponseBodyDefaultExecutor DefaultExecutor { get; set; }
        public class UpdateWorkflowNodeConfigurationResponseBodyDefaultExecutor : TeaModel {
            /// <summary>
            /// <para>The executor ID. If the type is USER, the value is a string representing a positive integer platform user ID. If the type is AGENT, the value is the technical name of the digital worker in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_1001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The executor type. Valid values: USER (a human user), AGENT (a digital worker), and SYSTEM (a legacy system executor). The SYSTEM value is used only in responses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The default model profile defined in the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("defaultModel")]
        [Validation(Required=false)]
        public string DefaultModel { get; set; }

        /// <summary>
        /// <para>The list of user IDs for the default owners defined in the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10001]</para>
        /// </summary>
        [NameInMap("defaultResponsibleUserIds")]
        [Validation(Required=false)]
        public List<string> DefaultResponsibleUserIds { get; set; }

        /// <summary>
        /// <para>The currently effective executor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;AGENT&quot;,&quot;id&quot;:&quot;agent_1001&quot;}</para>
        /// </summary>
        [NameInMap("effectiveExecutor")]
        [Validation(Required=false)]
        public UpdateWorkflowNodeConfigurationResponseBodyEffectiveExecutor EffectiveExecutor { get; set; }
        public class UpdateWorkflowNodeConfigurationResponseBodyEffectiveExecutor : TeaModel {
            /// <summary>
            /// <para>The executor ID. If the type is USER, the value is a string representing a positive integer platform user ID. If the type is AGENT, the value is the technical name of the digital worker in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_1001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The executor type. Valid values: USER (a human user), AGENT (a digital worker), and SYSTEM (a legacy system executor). The SYSTEM value is used only in responses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The currently effective model profile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max-plus</para>
        /// </summary>
        [NameInMap("effectiveModel")]
        [Validation(Required=false)]
        public string EffectiveModel { get; set; }

        /// <summary>
        /// <para>The list of user IDs for the currently effective owners.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10001]</para>
        /// </summary>
        [NameInMap("effectiveResponsibleUserIds")]
        [Validation(Required=false)]
        public List<string> EffectiveResponsibleUserIds { get; set; }

        /// <summary>
        /// <para>The ID of the current physical plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inst_2081</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The common error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The key of the business node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_7f3a2c</para>
        /// </summary>
        [NameInMap("nodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The instance override values. If a field is null, the default value defined in the template is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model&quot;:&quot;qwen-max-plus&quot;}</para>
        /// </summary>
        [NameInMap("overrides")]
        [Validation(Required=false)]
        public UpdateWorkflowNodeConfigurationResponseBodyOverrides Overrides { get; set; }
        public class UpdateWorkflowNodeConfigurationResponseBodyOverrides : TeaModel {
            /// <summary>
            /// <para>The overridden executor. A value of null indicates that the default value is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;AGENT&quot;,&quot;id&quot;:&quot;agent_1001&quot;}</para>
            /// </summary>
            [NameInMap("executor")]
            [Validation(Required=false)]
            public UpdateWorkflowNodeConfigurationResponseBodyOverridesExecutor Executor { get; set; }
            public class UpdateWorkflowNodeConfigurationResponseBodyOverridesExecutor : TeaModel {
                /// <summary>
                /// <para>The executor ID. If the type is USER, the value is a string representing a positive integer platform user ID. If the type is AGENT, the value is the technical name of the digital worker in the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent_1001</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The executor type. Valid values: USER (a human user), AGENT (a digital worker), and SYSTEM (a legacy system executor). The SYSTEM value is used only in responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The overridden model profile. A value of null indicates that the default value is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The list of overridden owner IDs. A value of null indicates that the default value is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[10001]</para>
            /// </summary>
            [NameInMap("responsibleUserIds")]
            [Validation(Required=false)]
            public List<long?> ResponsibleUserIds { get; set; }

        }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The state refresh cursor. This value cannot be used as the configuration version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("stateVersion")]
        [Validation(Required=false)]
        public long? StateVersion { get; set; }

        /// <summary>
        /// <para>The time when the configuration was last updated, in ISO 8601 format. This field is empty if the configuration has never been updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T08:00:00Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The platform user ID of the user who last updated the configuration. This field is empty if the configuration has never been updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public long? UpdatedBy { get; set; }

    }

}
