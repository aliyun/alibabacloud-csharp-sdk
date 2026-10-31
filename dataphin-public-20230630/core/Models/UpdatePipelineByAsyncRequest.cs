// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdatePipelineByAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The request context information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public UpdatePipelineByAsyncRequestContext Context { get; set; }
        public class UpdatePipelineByAsyncRequestContext : TeaModel {
            /// <summary>
            /// <para>The current operating environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEV: development environment.</description></item>
            /// <item><description>PROD: production environment.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the integration pipeline task belongs.</para>
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

        /// <summary>
        /// <para>The update configuration for the pipeline task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdatePipelineByAsyncRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdatePipelineByAsyncRequestUpdateCommand : TeaModel {
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
            /// <para>The configuration mode of the integration pipeline. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PIPELINE: pipeline mode (default).</description></item>
            /// <item><description>JSON: script mode.
            /// Ignore this parameter for workflow tasks.</description></item>
            /// </list>
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
            public UpdatePipelineByAsyncRequestUpdateCommandNodeInfo NodeInfo { get; set; }
            public class UpdatePipelineByAsyncRequestUpdateCommandNodeInfo : TeaModel {
                /// <summary>
                /// <para>The directory of the integration pipeline task node. The default value is the root directory. The directory must exist. If it does not exist, call the relevant API to create a directory of the offlinePipeline type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The ID of the pipeline file. Leave this parameter empty when creating a task for the first time. When updating a pipeline task, you must specify at least one of pipelineId, fileId, or nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The ID of the scheduling node for the pipeline task. Leave this parameter empty when creating a task for the first time. When updating a pipeline task, you must specify at least one of pipelineId, fileId, or nodeId.</para>
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
                /// <para>The ID of the pipeline task. Leave this parameter empty when creating a task for the first time. When updating a pipeline task, you must specify at least one of pipelineId, fileId, or nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public long? PipelineId { get; set; }

            }

            /// <summary>
            /// <para>The component configuration for the integration pipeline.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("PipelineConfig")]
            [Validation(Required=false)]
            public UpdatePipelineByAsyncRequestUpdateCommandPipelineConfig PipelineConfig { get; set; }
            public class UpdatePipelineByAsyncRequestUpdateCommandPipelineConfig : TeaModel {
                /// <summary>
                /// <para>The directed acyclic graph (DAG) hop configurations that describe the connection relationships among all components.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Hops")]
                [Validation(Required=false)]
                public List<UpdatePipelineByAsyncRequestUpdateCommandPipelineConfigHops> Hops { get; set; }
                public class UpdatePipelineByAsyncRequestUpdateCommandPipelineConfigHops : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to connect to the downstream component when the condition is met for a conditional distribution component. Set to true if the downstream condition is true, and false otherwise. Ignore this parameter for workflow tasks.</para>
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
                /// <para>The step configurations, including the detailed configurations of all used components.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<UpdatePipelineByAsyncRequestUpdateCommandPipelineConfigSteps> Steps { get; set; }
                public class UpdatePipelineByAsyncRequestUpdateCommandPipelineConfigSteps : TeaModel {
                    /// <summary>
                    /// <para>Specifies the data distribution method when the current component has multiple downstream components. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: distributes data to all downstream components in turn. For example, if the current component has 100 data records and two downstream components, each downstream component receives 50 records. This is the default value.</description></item>
                    /// <item><description>false: sends all data to all downstream components. For example, if the current component has 100 data records and two downstream components, both downstream components receive all 100 records.
                    /// Ignore this parameter for workflow tasks.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("IsDistribute")]
                    [Validation(Required=false)]
                    public bool? IsDistribute { get; set; }

                    /// <summary>
                    /// <para>The plugin ID. Each plugin or operator has a unique identifier. Refer to com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig#stepKey. Developers must inherit the component or operator configuration class to implement the corresponding configuration. The structure of each configuration must be identical to the configuration structure created on the Dataphin page.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysqlinput</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The specific component or operator configuration in JSON string format. Refer to the toJsonString method of the relevant subclasses of com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig (or com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.unstructured.BaseOAUnstructuredNeuronConfig for workflow operators). Developers must inherit this component or operator configuration class to implement the corresponding configuration. The structure of each component or operator configuration must be identical to the task configuration structure created on the Dataphin page.</para>
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
                    /// <para>The step type. For pipeline tasks, valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>input: input component.</description></item>
                    /// <item><description>output: output component.</description></item>
                    /// <item><description>transfrom: transform component.</description></item>
                    /// <item><description>process: flow control component.
                    /// For workflow tasks, this indicates the operator type, such as image: image or text: text. Refer to com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig#stepType. Developers must inherit the component or operator configuration class to implement the corresponding configuration. The structure of each configuration must be identical to the configuration structure created on the Dataphin page.</description></item>
                    /// </list>
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
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: offline integration (default).</description></item>
            /// <item><description>1: real-time integration.</description></item>
            /// <item><description>14: workflow task.</description></item>
            /// <item><description>15: real-time workflow.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PipelineType")]
            [Validation(Required=false)]
            public int? PipelineType { get; set; }

            /// <summary>
            /// <para>The schedule configuration in JSON string format. Refer to the com.alibaba.dataphin.pipeline.common.facade.openapi.model.OAScheduleConfig#toJsonString method in the utility class.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cronExpression&quot;:&quot;0 0 0 * * ?&quot;}</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public string ScheduleConfig { get; set; }

            /// <summary>
            /// <para>The channel settings in JSON string format. Refer to the com.alibaba.dataphin.pipeline.common.facade.openapi.model.OAPipelineSetting#toJsonString method in the utility class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Settings")]
            [Validation(Required=false)]
            public string Settings { get; set; }

            /// <summary>
            /// <para>Specifies whether to submit the task. Default value: true.</para>
            /// </summary>
            [NameInMap("Submit")]
            [Validation(Required=false)]
            public bool? Submit { get; set; }

        }

    }

}
