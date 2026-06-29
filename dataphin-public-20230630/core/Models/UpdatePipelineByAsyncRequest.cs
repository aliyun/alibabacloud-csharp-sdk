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
            /// <item><description>DEV: the development environment.</description></item>
            /// <item><description>PROD: the production environment.</description></item>
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
            /// <para>The ID of the project to which the integration pipeline node belongs.</para>
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
        /// <para>The pipeline node update configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdatePipelineByAsyncRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdatePipelineByAsyncRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The integration pipeline configuration mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PIPELINE: pipeline mode (default).</description></item>
            /// <item><description>JSON: script mode.</description></item>
            /// </list>
            /// <para>This parameter is not applicable to workflow nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PIPELINE</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The basic information of the integration pipeline node.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public UpdatePipelineByAsyncRequestUpdateCommandNodeInfo NodeInfo { get; set; }
            public class UpdatePipelineByAsyncRequestUpdateCommandNodeInfo : TeaModel {
                /// <summary>
                /// <para>The folder of the integration pipeline node. Default value: root folder. The folder must exist. If it does not exist, call the relevant API operation to create a folder of the offlinePipeline type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The pipeline file ID. Leave this parameter empty for initial creation. When updating a pipeline node, specify at least one of pipelineId, fileId, or nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The scheduling node ID of the pipeline node. Leave this parameter empty for initial creation. When updating a pipeline node, specify at least one of pipelineId, fileId, or nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The name of the integration pipeline node.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The pipeline node ID. Leave this parameter empty for initial creation. When updating a pipeline node, specify at least one of pipelineId, fileId, or nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public long? PipelineId { get; set; }

            }

            /// <summary>
            /// <para>The integration pipeline component configuration.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("PipelineConfig")]
            [Validation(Required=false)]
            public UpdatePipelineByAsyncRequestUpdateCommandPipelineConfig PipelineConfig { get; set; }
            public class UpdatePipelineByAsyncRequestUpdateCommandPipelineConfig : TeaModel {
                /// <summary>
                /// <para>The DAG (directed acyclic graph) link configurations that describe the connections between all components.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Hops")]
                [Validation(Required=false)]
                public List<UpdatePipelineByAsyncRequestUpdateCommandPipelineConfigHops> Hops { get; set; }
                public class UpdatePipelineByAsyncRequestUpdateCommandPipelineConfigHops : TeaModel {
                    /// <summary>
                    /// <para>For conditional distribution components, set this parameter to true when the downstream condition is true, and to false otherwise. This parameter is not applicable to workflow nodes.</para>
                    /// </summary>
                    [NameInMap("SendTo")]
                    [Validation(Required=false)]
                    public bool? SendTo { get; set; }

                    /// <summary>
                    /// <para>The input step name, which corresponds to Steps[*].StepName.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>The output step name, which corresponds to Steps[*].StepName.</para>
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
                /// <para>The component configurations, including detailed configurations of all components used.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<UpdatePipelineByAsyncRequestUpdateCommandPipelineConfigSteps> Steps { get; set; }
                public class UpdatePipelineByAsyncRequestUpdateCommandPipelineConfigSteps : TeaModel {
                    /// <summary>
                    /// <para>Specifies the data distribution method when the current component has multiple downstream components. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: the data of the current component is distributed to all downstream components in a round-robin manner. For example, if the current component has 100 records and two downstream components, each downstream component receives 50 records. Default value: true.</description></item>
                    /// <item><description>false: the full data of the current component is sent to all downstream components. For example, if the current component has 100 records and two downstream components, both downstream components receive 100 records.</description></item>
                    /// </list>
                    /// <para>This parameter is not applicable to workflow nodes.</para>
                    /// </summary>
                    [NameInMap("IsDistribute")]
                    [Validation(Required=false)]
                    public bool? IsDistribute { get; set; }

                    /// <summary>
                    /// <para>The plugin ID. Each plugin or operator has a unique identifier. Refer to the stepKey field of the utility class com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig. Developers should inherit the component or operator configuration class and implement the corresponding configuration. Each component or operator configuration has the same structure as the configuration created on the Dataphin console.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysqlinput</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The specific component configuration in JSON string format. Refer to the toJsonString method of the utility class com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig (or com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.unstructured.BaseOAUnstructuredNeuronConfig for workflow operators) and its subclasses. Developers should inherit the component or operator configuration class and implement the corresponding configuration. Each component or operator configuration has the same structure as the node configuration created on the Dataphin console.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("PluginConfig")]
                    [Validation(Required=false)]
                    public string PluginConfig { get; set; }

                    /// <summary>
                    /// <para>The step name. Step names must be unique within the same pipeline node.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("StepName")]
                    [Validation(Required=false)]
                    public string StepName { get; set; }

                    /// <summary>
                    /// <para>The component type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>input: an input component.</description></item>
                    /// <item><description>output: an output component.</description></item>
                    /// <item><description>transfrom: a transform component.</description></item>
                    /// <item><description>process: a flow control component.</description></item>
                    /// </list>
                    /// <para>For workflow nodes, this parameter specifies the operator type, such as image for images and text for text. Refer to the stepType field of the utility class com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig. Developers should inherit the component or operator configuration class and implement the corresponding configuration. Each component or operator configuration has the same structure as the configuration created on the Dataphin console.</para>
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
            /// <para>The integration pipeline configuration in JSON string format for script mode. Workflow nodes do not support script mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("PipelineJson")]
            [Validation(Required=false)]
            public string PipelineJson { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: batch integration (default).</description></item>
            /// <item><description>1: real-time integration.</description></item>
            /// <item><description>14: workflow node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PipelineType")]
            [Validation(Required=false)]
            public int? PipelineType { get; set; }

            /// <summary>
            /// <para>The scheduling configuration in JSON string format. Refer to the toJsonString method of the utility class com.alibaba.dataphin.pipeline.common.facade.openapi.model.OAScheduleConfig.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cronExpression&quot;:&quot;0 0 0 * * ?&quot;}</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public string ScheduleConfig { get; set; }

            /// <summary>
            /// <para>The channel configuration in JSON string format. Refer to the toJsonString method of the utility class com.alibaba.dataphin.pipeline.common.facade.openapi.model.OAPipelineSetting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Settings")]
            [Validation(Required=false)]
            public string Settings { get; set; }

            /// <summary>
            /// <para>Specifies whether to submit the node. Default value: true.</para>
            /// </summary>
            [NameInMap("Submit")]
            [Validation(Required=false)]
            public bool? Submit { get; set; }

        }

    }

}
