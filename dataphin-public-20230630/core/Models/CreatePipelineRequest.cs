// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>Request context information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public CreatePipelineRequestContext Context { get; set; }
        public class CreatePipelineRequestContext : TeaModel {
            /// <summary>
            /// <para>Current operating environment: DEV indicates the development environment, PROD indicates the production environment (for workflows, only PROD is currently supported)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>Project ID to which the integration pipeline/workflow task belongs</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>Pipeline/workflow task creation configuration</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreatePipelineRequestCreateCommand CreateCommand { get; set; }
        public class CreatePipelineRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>Comment</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Integration pipeline configuration mode: PIPELINE indicates pipeline mode (default), JSON indicates script mode.
            /// For workflows, this can be ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PIPELINE</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>Integration pipeline/workflow task basic information</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public CreatePipelineRequestCreateCommandNodeInfo NodeInfo { get; set; }
            public class CreatePipelineRequestCreateCommandNodeInfo : TeaModel {
                /// <summary>
                /// <para>Directory of the integration pipeline/workflow task node (defaults to root directory). The directory must exist. If it does not exist, call the relevant API to create a directory of type offlinePipeline (or unstructuredPipeline for workflows)</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>Pipeline/workflow file ID. Leave empty for initial creation. When updating a pipeline/workflow task, at least one of pipelineId, fileId, or nodeId must be specified</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>Scheduling node ID of the pipeline/workflow task. Leave empty for initial creation. When updating a pipeline/workflow task, at least one of pipelineId, fileId, or nodeId must be specified</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>Integration pipeline/workflow task name</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>Pipeline/workflow task ID. Leave empty for initial creation. When updating a pipeline/workflow task, at least one of pipelineId, fileId, or nodeId must be specified</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public long? PipelineId { get; set; }

            }

            /// <summary>
            /// <para>Integration pipeline component/workflow operator configuration</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("PipelineConfig")]
            [Validation(Required=false)]
            public CreatePipelineRequestCreateCommandPipelineConfig PipelineConfig { get; set; }
            public class CreatePipelineRequestCreateCommandPipelineConfig : TeaModel {
                /// <summary>
                /// <para>DAG (directed acyclic graph) link configuration: describes the connections between all components/operators</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Hops")]
                [Validation(Required=false)]
                public List<CreatePipelineRequestCreateCommandPipelineConfigHops> Hops { get; set; }
                public class CreatePipelineRequestCreateCommandPipelineConfigHops : TeaModel {
                    /// <summary>
                    /// <para>For conditional distribution components, set to true when the downstream condition is true, otherwise set to false.
                    /// For workflow tasks, this can be ignored.</para>
                    /// </summary>
                    [NameInMap("SendTo")]
                    [Validation(Required=false)]
                    public bool? SendTo { get; set; }

                    /// <summary>
                    /// <para>Input step name, i.e., Steps[*].StepName</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>Output step name, i.e., Steps[*].StepName</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps_writer</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                }

                /// <summary>
                /// <para>Component/operator configuration: contains detailed configuration of all components/operators used</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<CreatePipelineRequestCreateCommandPipelineConfigSteps> Steps { get; set; }
                public class CreatePipelineRequestCreateCommandPipelineConfigSteps : TeaModel {
                    /// <summary>
                    /// <para>Indicates the data distribution method when the current component has multiple downstream components:
                    /// true indicates that data from the current component is sent to all downstream components in a round-robin manner. For example, if the current component has 100 records and two downstream components, each downstream component receives 50 records. The default value is true.
                    /// false indicates that data from the current component is sent in full to all downstream components. For example, if the current component has 100 records and two downstream components, both downstream components receive all 100 records.
                    /// For workflow tasks, this value can be ignored.</para>
                    /// </summary>
                    [NameInMap("IsDistribute")]
                    [Validation(Required=false)]
                    public bool? IsDistribute { get; set; }

                    /// <summary>
                    /// <para>Plugin/operator ID. Each plugin/operator has a unique identifier. Refer to the utility class: com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig#stepKey. Developers should inherit this component/operator configuration class and implement the corresponding component/operator configuration. Each component/operator configuration has the same structure as the configuration created on the Dataphin page</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysqlinput</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>Specific component configuration in JSON string format. Refer to the utility class: subclasses of com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig (for workflow operators, use com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.unstructured.BaseOAUnstructuredNeuronConfig) and their toJsonString method. Developers should inherit this component/operator configuration class and implement the corresponding component/operator configuration. Each component/operator configuration has the same structure as the task configuration created on the Dataphin page</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("PluginConfig")]
                    [Validation(Required=false)]
                    public string PluginConfig { get; set; }

                    /// <summary>
                    /// <para>Step name. Step names must be unique within the same pipeline task</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("StepName")]
                    [Validation(Required=false)]
                    public string StepName { get; set; }

                    /// <summary>
                    /// <para>Component type: input indicates an input component, output indicates an output component, transfrom indicates a transform component, process indicates a flow control component. For workflow tasks, this indicates the operator type, such as image for image, text for text. Refer to the utility class: com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig#stepType. Developers should inherit this component/operator configuration class and implement the corresponding component/operator configuration. Each component/operator configuration has the same structure as the configuration created on the Dataphin page</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>input</para>
                    /// </summary>
                    [NameInMap("StepType")]
                    [Validation(Required=false)]
                    public string StepType { get; set; }

                }

            }

            /// <summary>
            /// <para>In script mode: integration pipeline configuration (in JSON string format).
            /// Workflow tasks do not support script mode</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("PipelineJson")]
            [Validation(Required=false)]
            public string PipelineJson { get; set; }

            /// <summary>
            /// <para>Task type: 0 indicates offline integration (default), 1 indicates real-time integration, 14 indicates a workflow task</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PipelineType")]
            [Validation(Required=false)]
            public int? PipelineType { get; set; }

            /// <summary>
            /// <para>Scheduling configuration in JSON string format. Refer to the utility class: com.alibaba.dataphin.pipeline.common.facade.openapi.model.OAScheduleConfig#toJsonString method</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cronExpression&quot;:&quot;0 0 0 * * ?&quot;}</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public string ScheduleConfig { get; set; }

            /// <summary>
            /// <para>Channel configuration in JSON string format. Refer to the utility class: com.alibaba.dataphin.pipeline.common.facade.openapi.model.OAPipelineSetting#toJsonString method</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Settings")]
            [Validation(Required=false)]
            public string Settings { get; set; }

            /// <summary>
            /// <para>Whether to submit. Submitted by default</para>
            /// </summary>
            [NameInMap("Submit")]
            [Validation(Required=false)]
            public bool? Submit { get; set; }

        }

        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
