// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class PreviewPipelineRequest : TeaModel {
        /// <summary>
        /// <para>The start time of the preview data window. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660800</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The pipeline configuration, including node orchestration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;nodes&quot;:[{&quot;id&quot;:&quot;select-fields&quot;,&quot;type&quot;:&quot;project&quot;,&quot;parameters&quot;:{&quot;question&quot;:&quot;user_query&quot;}}]}</para>
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public PreviewPipelineRequestPipeline Pipeline { get; set; }
        public class PreviewPipelineRequestPipeline : TeaModel {
            /// <summary>
            /// <para>The list of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;id&quot;:&quot;select-fields&quot;,&quot;type&quot;:&quot;project&quot;,&quot;parameters&quot;:{}}]</para>
            /// </summary>
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<PreviewPipelineRequestPipelineNodes> Nodes { get; set; }
            public class PreviewPipelineRequestPipelineNodes : TeaModel {
                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The parameters of the node. The parameters are in key-value format and vary based on the node type.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>transform</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The data source of the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;logstore&quot;,&quot;logstore&quot;:{&quot;project&quot;:&quot;my-sls-project&quot;,&quot;logstore&quot;:&quot;agent-logs&quot;},&quot;inputFields&quot;:[{&quot;name&quot;:&quot;question&quot;,&quot;type&quot;:&quot;text&quot;}]}</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public PreviewPipelineRequestSource Source { get; set; }
        public class PreviewPipelineRequestSource : TeaModel {
            /// <summary>
            /// <para>The dataset datasource config in the current AgentSpace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;dataset&quot;:&quot;my-dataset&quot;,&quot;filter&quot;:&quot;status = \&quot;pending\&quot;&quot;}</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public PreviewPipelineRequestSourceDataset Dataset { get; set; }
            public class PreviewPipelineRequestSourceDataset : TeaModel {
                /// <summary>
                /// <para>The name of the source dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-dataset</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public string Dataset { get; set; }

                /// <summary>
                /// <para>The filter condition for the dataset data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status = \&quot;pending\&quot;</para>
                /// </summary>
                [NameInMap("filter")]
                [Validation(Required=false)]
                public string Filter { get; set; }

            }

            /// <summary>
            /// <para>The input fields and their data types. This applies to all data source types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;question&quot;,&quot;type&quot;:&quot;text&quot;}]</para>
            /// </summary>
            [NameInMap("inputFields")]
            [Validation(Required=false)]
            public List<PreviewPipelineRequestSourceInputFields> InputFields { get; set; }
            public class PreviewPipelineRequestSourceInputFields : TeaModel {
                /// <summary>
                /// <para>The name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>question</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the field. Valid values: text, long, double, and json.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The Simple Log Service Logstore datasource config.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;project&quot;:&quot;my-sls-project&quot;,&quot;logstore&quot;:&quot;agent-logs&quot;}</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public PreviewPipelineRequestSourceLogstore Logstore { get; set; }
            public class PreviewPipelineRequestSourceLogstore : TeaModel {
                /// <summary>
                /// <para>The name of the Simple Log Service Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-sls-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the Simple Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-sls-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The filtered query statement (Simple Log Service query and analysis syntax).</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>| SELECT *</description></item>
                /// </list>
                /// </summary>
                [NameInMap("query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            /// <summary>
            /// <para>The configuration of trajectory data. This parameter is optional and takes effect only when the type is set to trace. It retrieves ATIF standard trajectory data from the trajectory cleaning service and extends the data based on features.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;enrich&quot;:{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}}</para>
            /// </summary>
            [NameInMap("trajectory")]
            [Validation(Required=false)]
            public PreviewPipelineRequestSourceTrajectory Trajectory { get; set; }
            public class PreviewPipelineRequestSourceTrajectory : TeaModel {
                /// <summary>
                /// <para>Trajectory enrichment: mounts trajectory data into the cleaning results based on the trace_id. When writing data to a dataset, the data is stored in the fixed agent_trajectory column, and the column value is the JSON content of the trajectory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}</para>
                /// </summary>
                [NameInMap("enrich")]
                [Validation(Required=false)]
                public PreviewPipelineRequestSourceTrajectoryEnrich Enrich { get; set; }
                public class PreviewPipelineRequestSourceTrajectoryEnrich : TeaModel {
                    /// <summary>
                    /// <para>The list of enrichment columns. This parameter is retained for compatibility. The current implementation outputs only the fixed agent_trajectory column, and this parameter no longer affects the output.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;input&quot;,&quot;output&quot;,&quot;session_id&quot;]</para>
                    /// </summary>
                    [NameInMap("columns")]
                    [Validation(Required=false)]
                    public List<string> Columns { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable trajectory enrichment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            /// <summary>
            /// <para>The type of the data source. Simple Log Service is currently supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The end time of the preview data window. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735747200</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
