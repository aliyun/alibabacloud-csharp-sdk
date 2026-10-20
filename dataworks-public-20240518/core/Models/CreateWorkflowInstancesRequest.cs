// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateWorkflowInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to run the workflow instance immediately after it is created. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoStartEnabled")]
        [Validation(Required=false)]
        public bool? AutoStartEnabled { get; set; }

        /// <summary>
        /// <para>The reason for creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create for test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The runtime configurations.</para>
        /// </summary>
        [NameInMap("DefaultRunProperties")]
        [Validation(Required=false)]
        public CreateWorkflowInstancesRequestDefaultRunProperties DefaultRunProperties { get; set; }
        public class CreateWorkflowInstancesRequestDefaultRunProperties : TeaModel {
            /// <summary>
            /// <para>The alert configurations.</para>
            /// </summary>
            [NameInMap("Alert")]
            [Validation(Required=false)]
            public CreateWorkflowInstancesRequestDefaultRunPropertiesAlert Alert { get; set; }
            public class CreateWorkflowInstancesRequestDefaultRunPropertiesAlert : TeaModel {
                /// <summary>
                /// <para>The notification method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Sms: text message only</description></item>
                /// <item><description>Mail: email only</description></item>
                /// <item><description>SmsMail: text message and email</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Sms</para>
                /// </summary>
                [NameInMap("NoticeType")]
                [Validation(Required=false)]
                public string NoticeType { get; set; }

                /// <summary>
                /// <para>The alert policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Success: alerts on success</description></item>
                /// <item><description>Failure: alerts on failure</description></item>
                /// <item><description>SuccessFailure: alerts on both success and failure</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Succes</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The analysis configurations. This parameter is required when Type is set to SupplementData.</para>
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public CreateWorkflowInstancesRequestDefaultRunPropertiesAnalysis Analysis { get; set; }
            public class CreateWorkflowInstancesRequestDefaultRunPropertiesAnalysis : TeaModel {
                /// <summary>
                /// <para>Specifies whether to block the run if the analysis fails. This parameter is required when Type is set to SupplementData.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Blocked")]
                [Validation(Required=false)]
                public bool? Blocked { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable analysis. This parameter is required when Type is set to SupplementData.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The data source name mappings for data backfill runs. The key of the map is DataSource.Name in the node definition, and the value is DataSource.Name used during data backfill runs. This parameter takes effect only when Type is set to SupplementData. If this parameter is not configured, an empty map is passed, or the key is not matched, the node continues to use the original data source. Currently, only EMR Spark SQL, EMR Shell, and EMR Spark nodes are supported.</para>
            /// </summary>
            [NameInMap("DataSourceNameMappings")]
            [Validation(Required=false)]
            public Dictionary<string, string> DataSourceNameMappings { get; set; }

            /// <summary>
            /// <para>The list of project IDs to exclude from the run.</para>
            /// </summary>
            [NameInMap("ExcludeProjectIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeProjectIds { get; set; }

            /// <summary>
            /// <para>The list of node IDs to exclude from the run.</para>
            /// </summary>
            [NameInMap("ExcludeTaskIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeTaskIds { get; set; }

            /// <summary>
            /// <para>The list of project IDs to include in the run.</para>
            /// </summary>
            [NameInMap("IncludeProjectIds")]
            [Validation(Required=false)]
            public List<long?> IncludeProjectIds { get; set; }

            /// <summary>
            /// <para>The list of node IDs to include in the run.</para>
            /// </summary>
            [NameInMap("IncludeTaskIds")]
            [Validation(Required=false)]
            public List<long?> IncludeTaskIds { get; set; }

            /// <summary>
            /// <para>The data backfill mode. Default value: ManualSelection. This parameter is required when Type is set to SupplementData. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>General: general mode. You can specify only one value for RootTaskIds. IncludeTaskIds is optional. If you do not specify IncludeTaskIds, the value of RootTaskIds is included by default.</description></item>
            /// <item><description>ManualSelection: manual selection mode. You can specify multiple values for RootTaskIds. IncludeTaskIds is optional. If you do not specify IncludeTaskIds, the values of RootTaskIds are included by default.</description></item>
            /// <item><description>Chain: chain mode. RootTaskIds must be left empty. You must specify two IDs for IncludeTaskIds, which are the start and end nodes.</description></item>
            /// <item><description>AllDownstream: all downstream mode. You can specify only one value for RootTaskIds.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManualSelection</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The run order. Default value: Asc. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Asc: ascending order by business date</description></item>
            /// <item><description>Desc: descending order by business date</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Asc</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            /// <summary>
            /// <para>The number of parallel nodes. A value of 2 to 10 indicates the parallelism, and a value of 1 indicates serial execution. This parameter is required when Type is set to SupplementData.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

            /// <summary>
            /// <para>The run priority. Valid values: 1 to 11. A larger value indicates a higher priority. These parameter settings are supported only for manually triggered workflows and event-triggered workflows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The priority weight policy. These parameter settings are supported only for manually triggered workflows and event-triggered workflows. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Disable: disabled. This is the default value.</description></item>
            /// <item><description>Upstream: calculates the sum of weights of upstream nodes for the current node. A deeper hierarchy indicates a higher weight.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Upstream</para>
            /// </summary>
            [NameInMap("PriorityWeightStrategy")]
            [Validation(Required=false)]
            public string PriorityWeightStrategy { get; set; }

            /// <summary>
            /// <para>The list of root node IDs.</para>
            /// <list type="bullet">
            /// <item><description>When Type is set to SupplementData, RootTaskIds is required except when Mode is set to Chain.</description></item>
            /// <item><description>When Type is set to ManualWorkflow, RootTaskIds is optional. If you do not specify RootTaskIds, the default root node list of the manually triggered workflow is used.</description></item>
            /// <item><description>When Type is set to Manual, RootTaskIds is required and specifies the list of manually triggered nodes to be run.</description></item>
            /// <item><description>When Type is set to SmokeTest, RootTaskIds is required and specifies the list of test nodes to be run.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RootTaskIds")]
            [Validation(Required=false)]
            public List<long?> RootTaskIds { get; set; }

            /// <summary>
            /// <para>The run policy. If this field is left empty, the node configuration is used.</para>
            /// </summary>
            [NameInMap("RunPolicy")]
            [Validation(Required=false)]
            public CreateWorkflowInstancesRequestDefaultRunPropertiesRunPolicy RunPolicy { get; set; }
            public class CreateWorkflowInstancesRequestDefaultRunPropertiesRunPolicy : TeaModel {
                /// <summary>
                /// <para>The end time of the run. Specify the time in the hh:mm:ss format based on the 24-hour clock. This field is required if you configure a run policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23:59:59</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>Specifies whether the run can be started immediately if the run time is in the future. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Immediately")]
                [Validation(Required=false)]
                public bool? Immediately { get; set; }

                /// <summary>
                /// <para>The start time of the run. Specify the time in the hh:mm:ss format based on the 24-hour clock. This field is required if you configure a run policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The period type. This field is required if you configure a run policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Daily: every day</description></item>
                /// <item><description>Weekend: weekends only</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Daily</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The identifier of the custom scheduling resource group. If this field is left empty, the node configuration is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public string RuntimeResource { get; set; }

        }

        /// <summary>
        /// <para>The project environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: production</description></item>
        /// <item><description>Dev: development</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkflowInstance1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The data backfill period settings.</para>
        /// </summary>
        [NameInMap("Periods")]
        [Validation(Required=false)]
        public CreateWorkflowInstancesRequestPeriods Periods { get; set; }
        public class CreateWorkflowInstancesRequestPeriods : TeaModel {
            /// <summary>
            /// <para>The list of business dates. You can specify multiple business date ranges, up to a maximum of 7 ranges.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("BizDates")]
            [Validation(Required=false)]
            public List<CreateWorkflowInstancesRequestPeriodsBizDates> BizDates { get; set; }
            public class CreateWorkflowInstancesRequestPeriodsBizDates : TeaModel {
                /// <summary>
                /// <para>The end business date. Format: yyyy-mm-dd.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-24</para>
                /// </summary>
                [NameInMap("EndBizDate")]
                [Validation(Required=false)]
                public string EndBizDate { get; set; }

                /// <summary>
                /// <para>The start business date. Format: yyyy-mm-dd.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-20</para>
                /// </summary>
                [NameInMap("StartBizDate")]
                [Validation(Required=false)]
                public string StartBizDate { get; set; }

            }

            /// <summary>
            /// <para>The end time of the period. Specify the time in the hh:mm:ss format based on the 24-hour clock. Default value: 23:59:59.</para>
            /// <para>If you specify this field, you must also specify StartTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23:59:59</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The start time of the period. Specify the time in the hh:mm:ss format based on the 24-hour clock. Default value: 00:00:00.</para>
            /// <para>If you specify this field, you must also specify EndTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The tag creation policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Append: Append mode. Inherits existing tags from the manual workflow and appends new tags.</description></item>
        /// <item><description>Overwrite: Overwrite mode. Does not inherit existing tags from the manual workflow and directly creates tags.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Append</para>
        /// </summary>
        [NameInMap("TagCreationPolicy")]
        [Validation(Required=false)]
        public string TagCreationPolicy { get; set; }

        /// <summary>
        /// <para>The list of task tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateWorkflowInstancesRequestTags> Tags { get; set; }
        public class CreateWorkflowInstancesRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The node parameters, which are used to set parameters for specific nodes. The value is in JSON format. The key is the node ID, and the value format refers to the node script parameters (Task.Script.Parameter in the response of the GetTask operation).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;1001&quot;: &quot;key1=val2 key2=val2&quot;, 
        ///   &quot;1002&quot;: &quot;key1=val2 key2=val2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TaskParameters")]
        [Validation(Required=false)]
        public string TaskParameters { get; set; }

        /// <summary>
        /// <para>The type of the workflow instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SupplementData: data backfill. The methods for specifying RootTaskIds and IncludeTaskIds vary based on the data backfill mode. For more information, see the parameter description of DefaultRunProperties.Mode.</description></item>
        /// <item><description>ManualWorkflow: manually triggered workflow. You must set WorkflowId to the ID of the manually triggered workflow. RootTaskIds is optional. If you do not specify RootTaskIds, the default root node list of the manually triggered workflow is used.</description></item>
        /// <item><description>Manual: manually triggered node. You only need to specify RootTaskIds, which is the list of manually triggered nodes to be run.</description></item>
        /// <item><description>SmokeTest: smoke test. You only need to specify RootTaskIds, which is the list of test nodes to be run.</description></item>
        /// <item><description>TriggerWorkflow: event-triggered workflow. You must set WorkflowId to the ID of the event-triggered workflow. IncludeTaskIds is optional. If you do not specify IncludeTaskIds, the entire workflow is run.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SupplementData</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the workflow to which the node belongs. The WorkflowId of a periodic node is always 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

        /// <summary>
        /// <para>The workflow parameters. This parameter takes effect only when a specific workflow is specified (WorkflowId != 1). For a periodic workflow or an event-triggered workflow, the format is key=value, and the priority is lower than that of node parameters. For a manually triggered workflow, the format is JSON, and the priority is higher than that of node parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;key=value&quot; format:
        /// key1=value1 key2=value2
        /// JSON format:
        /// {&quot;key1&quot;:&quot;value1&quot;, &quot;key2&quot;: &quot;value2&quot;}</para>
        /// </summary>
        [NameInMap("WorkflowParameters")]
        [Validation(Required=false)]
        public string WorkflowParameters { get; set; }

    }

}
