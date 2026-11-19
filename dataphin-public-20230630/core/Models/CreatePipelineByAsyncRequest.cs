// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreatePipelineByAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The request context information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public CreatePipelineByAsyncRequestContext Context { get; set; }
        public class CreatePipelineByAsyncRequestContext : TeaModel {
            /// <summary>
            /// <para>The current operation environment. Valid values: DEV: development environment. PROD: production environment. For workflows, only PROD is currently supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the integration pipeline or workflow task belongs.</para>
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
        /// <para>The configuration for creating a pipeline or workflow task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreatePipelineByAsyncRequestCreateCommand CreateCommand { get; set; }
        public class CreatePipelineByAsyncRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The integration pipeline configuration mode. Valid values: PIPELINE: pipeline mode (default). JSON: script mode. Ignore this parameter for workflows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PIPELINE</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The basic information of the integration pipeline task.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public CreatePipelineByAsyncRequestCreateCommandNodeInfo NodeInfo { get; set; }
            public class CreatePipelineByAsyncRequestCreateCommandNodeInfo : TeaModel {
                /// <summary>
                /// <para>The node directory of the integration pipeline task. Default value: root directory. The directory must exist. If it does not exist, call the relevant API operation to create a directory of the offlinePipeline type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The ID of the pipeline file. Leave this parameter empty when creating a task for the first time. When updating a pipeline task, you must configure at least one of the following parameters: pipelineId, fileId, and nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The ID of the schedule node for the pipeline task. Leave this parameter empty when creating a task for the first time. When updating a pipeline task, you must configure at least one of the following parameters: pipelineId, fileId, and nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The name of the integration pipeline task.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The ID of the pipeline task. Leave this parameter empty when creating a task for the first time. When updating a pipeline task, you must configure at least one of the following parameters: pipelineId, fileId, and nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public long? PipelineId { get; set; }

            }

            /// <summary>
            /// <para>The integration pipeline component or workflow operator configuration.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("PipelineConfig")]
            [Validation(Required=false)]
            public CreatePipelineByAsyncRequestCreateCommandPipelineConfig PipelineConfig { get; set; }
            public class CreatePipelineByAsyncRequestCreateCommandPipelineConfig : TeaModel {
                /// <summary>
                /// <para>The directed acyclic graph (DAG) link configuration that describes the connection relationships among all components.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Hops")]
                [Validation(Required=false)]
                public List<CreatePipelineByAsyncRequestCreateCommandPipelineConfigHops> Hops { get; set; }
                public class CreatePipelineByAsyncRequestCreateCommandPipelineConfigHops : TeaModel {
                    /// <summary>
                    /// <para>For conditional distribution components, set this parameter to true if the downstream connection condition is true. Otherwise, set it to false. Ignore this parameter for workflow tasks.</para>
                    /// </summary>
                    [NameInMap("SendTo")]
                    [Validation(Required=false)]
                    public bool? SendTo { get; set; }

                    /// <summary>
                    /// <para>The name of the input step, which corresponds to Steps[*].StepName.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>The name of the output step, which corresponds to Steps[*].StepName.</para>
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
                /// <para>The component or operator configurations, including the detailed configurations of all used components or operators.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<CreatePipelineByAsyncRequestCreateCommandPipelineConfigSteps> Steps { get; set; }
                public class CreatePipelineByAsyncRequestCreateCommandPipelineConfigSteps : TeaModel {
                    /// <summary>
                    /// <para>The data distribution method when the current component has multiple downstream components. Valid values: true: distributes data from the current component to all downstream components in turn. For example, if the current component has 100 data records and two downstream components, each downstream component receives 50 data records. Default value: true. false: sends all data from the current component to all downstream components. For example, if the current component has 100 data records and two downstream components, both downstream components receive all 100 data records. Ignore this parameter for workflow tasks.</para>
                    /// </summary>
                    [NameInMap("IsDistribute")]
                    [Validation(Required=false)]
                    public bool? IsDistribute { get; set; }

                    /// <summary>
                    /// <para>The plugin ID. Each plugin or operator has a unique identifier. Refer to the stepKey field in the com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig utility class. Developers must inherit this component or operator configuration class to implement the corresponding configuration. The structure of each component or operator configuration must be identical to the configuration structure created on the Dataphin page.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysqlinput</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The specific component configuration in JSON string format. Refer to the toJsonString method of the relevant subclasses of com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig (for workflow operators, use com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.unstructured.BaseOAUnstructuredNeuronConfig). Developers must inherit this component or operator configuration class to implement the corresponding configuration. The structure of each component or operator configuration must be identical to the task configuration structure created on the Dataphin page.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("PluginConfig")]
                    [Validation(Required=false)]
                    public string PluginConfig { get; set; }

                    /// <summary>
                    /// <para>The step name. Step names must be unique within the same pipeline task.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("StepName")]
                    [Validation(Required=false)]
                    public string StepName { get; set; }

                    /// <summary>
                    /// <para>The component type. Valid values: input: input component. output: output component. transfrom: transform component. process: flow control component. For workflow tasks, this indicates the operator type, such as image for images and text for text. Refer to the stepType field in the com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig utility class. Developers must inherit this component or operator configuration class to implement the corresponding configuration. The structure of each component or operator configuration must be identical to the configuration structure created on the Dataphin page.</para>
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
            /// <para>The integration pipeline configuration in JSON string format for script mode. Workflow tasks do not support script mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("PipelineJson")]
            [Validation(Required=false)]
            public string PipelineJson { get; set; }

            /// <summary>
            /// <para>The task type. Valid values: 0: offline integration (default). 1: real-time integration. 14: offline workflow task. 15: real-time workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PipelineType")]
            [Validation(Required=false)]
            public int? PipelineType { get; set; }

            /// <summary>
            /// <para>The schedule configuration in JSON string format. Refer to the toJsonString method in the com.alibaba.dataphin.pipeline.common.facade.openapi.model.OAScheduleConfig utility class.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cronExpression&quot;:&quot;0 0 0 * * ?&quot;}</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public string ScheduleConfig { get; set; }

            /// <summary>
            /// <para>The channel configuration in JSON string format. Refer to the toJsonString method in the com.alibaba.dataphin.pipeline.common.facade.openapi.model.OAPipelineSetting utility class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Settings")]
            [Validation(Required=false)]
            public string Settings { get; set; }

            /// <summary>
            /// <para>Specifies whether to submit the task. By default, the task is submitted.</para>
            /// </summary>
            [NameInMap("Submit")]
            [Validation(Required=false)]
            public bool? Submit { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the user who performs the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
