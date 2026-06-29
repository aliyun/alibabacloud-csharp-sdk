// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetPipelineByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The pipeline task details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPipelineByIdResponseBodyData Data { get; set; }
        public class GetPipelineByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration mode of the integration pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PIPELINE</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The basic information of the pipeline task.</para>
            /// </summary>
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public GetPipelineByIdResponseBodyDataNodeInfo NodeInfo { get; set; }
            public class GetPipelineByIdResponseBodyDataNodeInfo : TeaModel {
                /// <summary>
                /// <para>The task description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>comment</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The folder of the integration pipeline task node. The default value is the root folder. The folder must exist. If it does not exist, call the relevant API operation to create a folder of the offlinePipeline type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The pipeline file ID. This parameter is empty when the task is first created. When updating a pipeline task, specify at least one of pipelineId, fileId, or nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The scheduling node ID of the pipeline task. This parameter is empty when the task is first created. When updating a pipeline task, specify at least one of pipelineId, fileId, or nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The name of the integration pipeline task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The pipeline task ID. This parameter is empty when the task is first created. When updating a pipeline task, specify at least one of pipelineId, fileId, or nodeId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public long? PipelineId { get; set; }

            }

            /// <summary>
            /// <para>The component configuration of the integration pipeline.</para>
            /// </summary>
            [NameInMap("PipelineConfig")]
            [Validation(Required=false)]
            public GetPipelineByIdResponseBodyDataPipelineConfig PipelineConfig { get; set; }
            public class GetPipelineByIdResponseBodyDataPipelineConfig : TeaModel {
                /// <summary>
                /// <para>The DAG (directed acyclic graph) link configuration that describes the connections between all components.</para>
                /// </summary>
                [NameInMap("Hops")]
                [Validation(Required=false)]
                public List<GetPipelineByIdResponseBodyDataPipelineConfigHops> Hops { get; set; }
                public class GetPipelineByIdResponseBodyDataPipelineConfigHops : TeaModel {
                    /// <summary>
                    /// <para>For conditional distribution components, set this parameter to true when the downstream condition is true. Otherwise, set it to false.</para>
                    /// </summary>
                    [NameInMap("SendTo")]
                    [Validation(Required=false)]
                    public bool? SendTo { get; set; }

                    /// <summary>
                    /// <para>The input step name, which corresponds to Steps[*].StepName.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql_reader</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>The output step name, which corresponds to Steps[*].StepName.</para>
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
                /// </summary>
                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<GetPipelineByIdResponseBodyDataPipelineConfigSteps> Steps { get; set; }
                public class GetPipelineByIdResponseBodyDataPipelineConfigSteps : TeaModel {
                    /// <summary>
                    /// <para>Specifies the data distribution method when the current component has multiple downstream components. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: The data of the current component is sent to all downstream components in a round-robin manner. For example, if the current component has 100 records and two downstream components, each downstream component receives 50 records. Default value: true.</description></item>
                    /// <item><description>false: The full data of the current component is sent to all downstream components. For example, if the current component has 100 records and two downstream components, each downstream component receives 100 records.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("IsDistribute")]
                    [Validation(Required=false)]
                    public bool? IsDistribute { get; set; }

                    /// <summary>
                    /// <para>The plugin ID. Each plugin has a unique identifier. Refer to the utility class com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig#stepKey. Developers should inherit this component configuration class and implement the corresponding component configuration. Each component configuration has the same structure as the pipeline configuration created on the Dataphin console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysqlinput</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The specific component configuration in JSON string format. Refer to the toJsonString method of the subclasses of the utility class com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig. Developers should inherit this component configuration class and implement the corresponding component configuration. Each component configuration has the same structure as the pipeline configuration created on the Dataphin console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("PluginConfig")]
                    [Validation(Required=false)]
                    public string PluginConfig { get; set; }

                    /// <summary>
                    /// <para>The step name. Step names must be unique within the same pipeline task.</para>
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
                    /// <item><description>transfrom: a transformation component.</description></item>
                    /// <item><description>process: a flow control component.
                    /// Refer to the utility class com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig#stepType. Developers should inherit this component configuration class and implement the corresponding component configuration. Each component configuration has the same structure as the pipeline configuration created on the Dataphin console.</description></item>
                    /// </list>
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
            /// <para>The script mode configuration of the integration pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("PipelineJson")]
            [Validation(Required=false)]
            public string PipelineJson { get; set; }

            /// <summary>
            /// <para>The pipeline task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PipelineType")]
            [Validation(Required=false)]
            public int? PipelineType { get; set; }

            /// <summary>
            /// <para>The schedule configuration of the integration pipeline. The value is a JSON string. Deserialize it by using the utility class com.alibaba.dataphin.pipeline.common.facade.openapi.vo.OAScheduleConfigVO.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public string ScheduleConfig { get; set; }

            /// <summary>
            /// <para>The channel configuration of the integration pipeline. The value is a JSON string. Deserialize it by using the utility class com.alibaba.dataphin.pipeline.common.facade.openapi.model.OAPipelineSetting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Settings")]
            [Validation(Required=false)]
            public string Settings { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error details returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
