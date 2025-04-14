// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateWorkflowInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The default value is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoStartEnabled")]
        [Validation(Required=false)]
        public bool? AutoStartEnabled { get; set; }

        /// <summary>
        /// <para>The reason for the creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create for test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The runtime configuration.</para>
        /// </summary>
        [NameInMap("DefaultRunProperties")]
        [Validation(Required=false)]
        public CreateWorkflowInstancesRequestDefaultRunProperties DefaultRunProperties { get; set; }
        public class CreateWorkflowInstancesRequestDefaultRunProperties : TeaModel {
            /// <summary>
            /// <para>The alert settings.</para>
            /// </summary>
            [NameInMap("Alert")]
            [Validation(Required=false)]
            public CreateWorkflowInstancesRequestDefaultRunPropertiesAlert Alert { get; set; }
            public class CreateWorkflowInstancesRequestDefaultRunPropertiesAlert : TeaModel {
                /// <summary>
                /// <para>The alert notification method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Sms</description></item>
                /// <item><description>Mail</description></item>
                /// <item><description>SmsMail</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Sms</para>
                /// </summary>
                [NameInMap("NoticeType")]
                [Validation(Required=false)]
                public string NoticeType { get; set; }

                /// <summary>
                /// <para>The alerting policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SUCCESS: An alert is reported when data backfill succeeds.</description></item>
                /// <item><description>FAILURE: An alert is reported when data backfill fails.</description></item>
                /// <item><description>SuccessFailure: An alert is reported regardless of whether data backfill succeeds or fails.</description></item>
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
            /// <para>The analysis of the configurations.</para>
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public CreateWorkflowInstancesRequestDefaultRunPropertiesAnalysis Analysis { get; set; }
            public class CreateWorkflowInstancesRequestDefaultRunPropertiesAnalysis : TeaModel {
                /// <summary>
                /// <para>Specifies whether to block the running of the instance if the analysis fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Blocked")]
                [Validation(Required=false)]
                public bool? Blocked { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the analysis feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The IDs of the projects that do not need to be run.</para>
            /// </summary>
            [NameInMap("ExcludeProjectIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeProjectIds { get; set; }

            /// <summary>
            /// <para>The IDs of the tasks that do not need to be run.</para>
            /// </summary>
            [NameInMap("ExcludeTaskIds")]
            [Validation(Required=false)]
            public List<long?> ExcludeTaskIds { get; set; }

            /// <summary>
            /// <para>The IDs of the projects that need to be run.</para>
            /// </summary>
            [NameInMap("IncludeProjectIds")]
            [Validation(Required=false)]
            public List<long?> IncludeProjectIds { get; set; }

            /// <summary>
            /// <para>The IDs of the tasks that need to be run.</para>
            /// </summary>
            [NameInMap("IncludeTaskIds")]
            [Validation(Required=false)]
            public List<long?> IncludeTaskIds { get; set; }

            /// <summary>
            /// <para>The data backfill mode. Default value: ManualSelection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>General: You can specify only one root task ID. The <c>IncludeTaskIds</c> parameter is optional. If you do not specify the IncludeTaskIds parameter, the tasks that are specified by the <c>RootTaskIds</c> parameter are included by default.``</description></item>
            /// <item><description>ManualSelection: You can specify multiple root tasks IDs. The <c>IncludeTaskIds</c> parameter is optional. If you do not specify the IncludeTaskIds parameter, the tasks that are specified by the <c>RootTaskIds</c> parameter are included by default.``</description></item>
            /// <item><description>Chain: The value of the <c>RootTaskIds</c> parameter is left empty. You must set the <c>IncludeTaskIds</c> parameter to the start task ID and the end task ID.</description></item>
            /// <item><description>AllDownstream: You can specify only one root task ID.``</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManualSelection</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The running order. Default value: Asc. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Asc: The tasks are sorted by data timestamp in ascending order.</description></item>
            /// <item><description>Desc: The tasks are sorted by data timestamp in descending order.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Asc</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            /// <summary>
            /// <para>The number of tasks that can be run in parallel. If you specify the value to 2 to 10, the value indicates the number of tasks that can be run in parallel. If you specify the value to 1, the tasks are run one by one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

            /// <summary>
            /// <para>The root task IDs.</para>
            /// </summary>
            [NameInMap("RootTaskIds")]
            [Validation(Required=false)]
            public List<long?> RootTaskIds { get; set; }

            /// <summary>
            /// <para>The data backfill policy. If you leave this parameter empty, the runtime configuration is used.</para>
            /// </summary>
            [NameInMap("RunPolicy")]
            [Validation(Required=false)]
            public CreateWorkflowInstancesRequestDefaultRunPropertiesRunPolicy RunPolicy { get; set; }
            public class CreateWorkflowInstancesRequestDefaultRunPropertiesRunPolicy : TeaModel {
                /// <summary>
                /// <para>The time when the instance finishes running. This parameter is required if you specify the RunPolicy parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23:59:59</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>Specifies whether the instance can be run immediately during the time period in the future. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Immediately")]
                [Validation(Required=false)]
                public bool? Immediately { get; set; }

                /// <summary>
                /// <para>The time when the instance starts to run. This parameter is required if you specify the RunPolicy parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The type of the time period during which the data is backfilled. This parameter is required if you specify the RunPolicy parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Daily</description></item>
                /// <item><description>Weekend</description></item>
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
            /// <para>The identifier of the custom resource group for scheduling. If you leave this parameter empty, the runtime configuration is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public string RuntimeResource { get; set; }

        }

        /// <summary>
        /// <para>The environment of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: production environment</description></item>
        /// <item><description>Dev: development environment</description></item>
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
        /// <para>Make up the data cycle settings.</para>
        /// </summary>
        [NameInMap("Periods")]
        [Validation(Required=false)]
        public CreateWorkflowInstancesRequestPeriods Periods { get; set; }
        public class CreateWorkflowInstancesRequestPeriods : TeaModel {
            /// <summary>
            /// <para>The list of business dates. You can specify a multi-segment business date (up to 7 segments).</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("BizDates")]
            [Validation(Required=false)]
            public List<CreateWorkflowInstancesRequestPeriodsBizDates> BizDates { get; set; }
            public class CreateWorkflowInstancesRequestPeriodsBizDates : TeaModel {
                /// <summary>
                /// <para>The end date of the business.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-24</para>
                /// </summary>
                [NameInMap("EndBizDate")]
                [Validation(Required=false)]
                public string EndBizDate { get; set; }

                /// <summary>
                /// <para>The start business date.</para>
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
            /// <para>Specifies the end cycle time. Default value: 23:59:59.</para>
            /// <para>If you enter this field, StartTime and EndTime must be filled in at the same time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23:59:59</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Specifies the start cycle time. Default value: 00:00:00.</para>
            /// <para>If you enter this field, StartTime and EndTime must be filled in at the same time.</para>
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
        /// <para>The task-specific parameters. The value is in the JSON format. The key specifies the task ID. You can call the GetTask operation to obtain the format of the value by querying the script parameters.</para>
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
        /// <item><description>SupplementData The values of the RootTaskIds and IncludeTaskIds parameters vary based on the value of the Mode parameter. For more information, see the Mode parameter in this API operation.</description></item>
        /// <item><description>ManualWorkflow You must set the WorkflowId parameter to the ID of the manually triggered workflow. The RootTaskIds parameter is optional. If you do not specify the RootTaskIds parameter, the IDs of the default root nodes of the manually triggered workflow are used.</description></item>
        /// <item><description>Manual You need to specify only the RootTaskIds parameter. The RootTaskIds parameter specifies the IDs of the manually triggered tasks that need to be run.</description></item>
        /// <item><description>SmokeTest You need to specify only the RootTaskIds parameter. The RootTaskIds parameter specifies the IDs of the test tasks that need to be run.</description></item>
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
        /// <para>The ID of the workflow to which the instance belongs. This parameter is set to 1 for auto triggered tasks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

        /// <summary>
        /// <para>The workflow parameters. The priority of workflow parameters is higher than that of task parameters. You can call the GetTask operation to obtain the format of the workflow parameters by querying the Parameters parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ 
        ///   &quot;key1&quot;: &quot;value1&quot;, 
        ///   &quot;key2&quot;: &quot;value2&quot; 
        /// }</para>
        /// </summary>
        [NameInMap("WorkflowParameters")]
        [Validation(Required=false)]
        public string WorkflowParameters { get; set; }

    }

}
