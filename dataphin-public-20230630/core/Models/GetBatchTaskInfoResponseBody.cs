// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBatchTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The node details.</para>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public GetBatchTaskInfoResponseBodyTaskInfo TaskInfo { get; set; }
        public class GetBatchTaskInfoResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the basic schedule template. This parameter is returned when the configuration method is set to schedule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7305621095333696</para>
            /// </summary>
            [NameInMap("BaseScheduleTemplateId")]
            [Validation(Required=false)]
            public long? BaseScheduleTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the basic schedule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily schedule template</para>
            /// </summary>
            [NameInMap("BaseScheduleTemplateName")]
            [Validation(Required=false)]
            public string BaseScheduleTemplateName { get; set; }

            /// <summary>
            /// <para>The code of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>show tables;</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Indicates whether conditional scheduling is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConditionScheduleEnable")]
            [Validation(Required=false)]
            public bool? ConditionScheduleEnable { get; set; }

            /// <summary>
            /// <para>The details of the conditional scheduling configuration. This parameter has a value only when conditional scheduling is enabled.</para>
            /// </summary>
            [NameInMap("ConditionScheduleParamList")]
            [Validation(Required=false)]
            public List<GetBatchTaskInfoResponseBodyTaskInfoConditionScheduleParamList> ConditionScheduleParamList { get; set; }
            public class GetBatchTaskInfoResponseBodyTaskInfoConditionScheduleParamList : TeaModel {
                /// <summary>
                /// <para>The name of the condition.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Rerun on failure</para>
                /// </summary>
                [NameInMap("ConditionName")]
                [Validation(Required=false)]
                public string ConditionName { get; set; }

                /// <summary>
                /// <para>The cron expression used after the condition is met.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 30 * * * ?</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the condition.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>Specifies whether to follow the primary schedule parameter.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("FollowScheduleParam")]
                [Validation(Required=false)]
                public bool? FollowScheduleParam { get; set; }

                /// <summary>
                /// <para>The scheduling status of the node after the condition is met. Valid values: 1: Normal. 2: Paused. 3: Dry run.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeStatus")]
                [Validation(Required=false)]
                public int? NodeStatus { get; set; }

                /// <summary>
                /// <para>The conditional expression tree in JSON string format. The keys are named in lower camel case characters and must be parsed by the invoker.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;EXPRESSION_GROUP&quot;,&quot;operator&quot;:&quot;or&quot;}</para>
                /// </summary>
                [NameInMap("ScheduleConditionJson")]
                [Validation(Required=false)]
                public string ScheduleConditionJson { get; set; }

                /// <summary>
                /// <para>The schedule time used after the condition is met.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:30</para>
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

            }

            /// <summary>
            /// <para>The ID of the conditional schedule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7305621095333697</para>
            /// </summary>
            [NameInMap("ConditionScheduleTemplateId")]
            [Validation(Required=false)]
            public long? ConditionScheduleTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the conditional schedule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Conditional schedule template</para>
            /// </summary>
            [NameInMap("ConditionScheduleTemplateName")]
            [Validation(Required=false)]
            public string ConditionScheduleTemplateName { get; set; }

            /// <summary>
            /// <para>The cross-node parameters, which are the output parameters declared by the current node for downstream nodes to reference in the ${#n_NodeID:ParameterName} format.</para>
            /// </summary>
            [NameInMap("ContextParamList")]
            [Validation(Required=false)]
            public List<GetBatchTaskInfoResponseBodyTaskInfoContextParamList> ContextParamList { get; set; }
            public class GetBatchTaskInfoResponseBodyTaskInfoContextParamList : TeaModel {
                /// <summary>
                /// <para>The default value.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Number of output records</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cnt</para>
                /// </summary>
                [NameInMap("ParamKey")]
                [Validation(Required=false)]
                public string ParamKey { get; set; }

            }

            /// <summary>
            /// <para>The cron expression for automatic scheduling. You can refer to Linux cron expressions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 1 * * ?</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The custom schedule interval configuration.</para>
            /// </summary>
            [NameInMap("CustomScheduleConfig")]
            [Validation(Required=false)]
            public GetBatchTaskInfoResponseBodyTaskInfoCustomScheduleConfig CustomScheduleConfig { get; set; }
            public class GetBatchTaskInfoResponseBodyTaskInfoCustomScheduleConfig : TeaModel {
                /// <summary>
                /// <para>The end time in the HH:mm format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20:59</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The custom interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The unit of the interval. Valid values: MINUTE and HOUR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HOUR</para>
                /// </summary>
                [NameInMap("IntervalUnit")]
                [Validation(Required=false)]
                public string IntervalUnit { get; set; }

                /// <summary>
                /// <para>The schedule cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAILY</para>
                /// </summary>
                [NameInMap("SchedulePeriod")]
                [Validation(Required=false)]
                public string SchedulePeriod { get; set; }

                /// <summary>
                /// <para>The start time in the HH:mm format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>08:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The ID of the DAG to which the node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dag_102121211</para>
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public string DagId { get; set; }

            /// <summary>
            /// <para>The catalog of the data source. This parameter applies only to database SQL nodes and data source types that require a catalog, such as Presto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql_catalog</para>
            /// </summary>
            [NameInMap("DataSourceCatalog")]
            [Validation(Required=false)]
            public string DataSourceCatalog { get; set; }

            /// <summary>
            /// <para>The ID of the data source for the database SQL node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12131111</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The schema of the data source. This parameter applies only to database SQL nodes and data source types that require a schema, such as Oracle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>erp</para>
            /// </summary>
            [NameInMap("DataSourceSchema")]
            [Validation(Required=false)]
            public string DataSourceSchema { get; set; }

            /// <summary>
            /// <para>The HTTP path in the development environment, used for Databricks tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/sql/protocolv1/o/xxx</para>
            /// </summary>
            [NameInMap("DevHttpPath")]
            [Validation(Required=false)]
            public string DevHttpPath { get; set; }

            /// <summary>
            /// <para>The ID of the schedule resource group for the development task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-def456</para>
            /// </summary>
            [NameInMap("DevResourceGroupId")]
            [Validation(Required=false)]
            public string DevResourceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the schedule resource group for the development task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default resource group</para>
            /// </summary>
            [NameInMap("DevResourceGroupName")]
            [Validation(Required=false)]
            public string DevResourceGroupName { get; set; }

            /// <summary>
            /// <para>The user ID of the development owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30231123</para>
            /// </summary>
            [NameInMap("DevelopOwnerId")]
            [Validation(Required=false)]
            public string DevelopOwnerId { get; set; }

            /// <summary>
            /// <para>The list of development owner IDs.</para>
            /// </summary>
            [NameInMap("DevelopOwnerIdList")]
            [Validation(Required=false)]
            public List<string> DevelopOwnerIdList { get; set; }

            /// <summary>
            /// <para>The name of the development owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("DevelopOwnerName")]
            [Validation(Required=false)]
            public string DevelopOwnerName { get; set; }

            /// <summary>
            /// <para>The list of development owner names.</para>
            /// </summary>
            [NameInMap("DevelopOwnerNameList")]
            [Validation(Required=false)]
            public List<string> DevelopOwnerNameList { get; set; }

            /// <summary>
            /// <para>The node ID in the task directory tree.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12113111</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>Indicates whether a development environment node exists.</para>
            /// </summary>
            [NameInMap("HasDevNode")]
            [Validation(Required=false)]
            public bool? HasDevNode { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test node 1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the node needs to be published.</para>
            /// </summary>
            [NameInMap("NeedPublish")]
            [Validation(Required=false)]
            public bool? NeedPublish { get; set; }

            /// <summary>
            /// <para>The description of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("NodeDescription")]
            [Validation(Required=false)]
            public string NodeDescription { get; set; }

            /// <summary>
            /// <para>The source of the node, which indicates the organization or application that created the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openapi</para>
            /// </summary>
            [NameInMap("NodeFrom")]
            [Validation(Required=false)]
            public string NodeFrom { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_1011_21232132322</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test node 1</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The list of node output names.</para>
            /// </summary>
            [NameInMap("NodeOutputNameList")]
            [Validation(Required=false)]
            public List<string> NodeOutputNameList { get; set; }

            /// <summary>
            /// <para>The status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Normal.</description></item>
            /// <item><description>2: Paused.</description></item>
            /// <item><description>3: Dry run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public int? NodeStatus { get; set; }

            /// <summary>
            /// <para>The user ID of the current operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30231123</para>
            /// </summary>
            [NameInMap("OperatorUserId")]
            [Validation(Required=false)]
            public string OperatorUserId { get; set; }

            /// <summary>
            /// <para>The user ID of the O&amp;M owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30231123</para>
            /// </summary>
            [NameInMap("OpsOwnerId")]
            [Validation(Required=false)]
            public string OpsOwnerId { get; set; }

            /// <summary>
            /// <para>The list of O&amp;M owner IDs.</para>
            /// </summary>
            [NameInMap("OpsOwnerIdList")]
            [Validation(Required=false)]
            public List<string> OpsOwnerIdList { get; set; }

            /// <summary>
            /// <para>The name of the O&amp;M owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("OpsOwnerName")]
            [Validation(Required=false)]
            public string OpsOwnerName { get; set; }

            /// <summary>
            /// <para>The list of O&amp;M owner names.</para>
            /// </summary>
            [NameInMap("OpsOwnerNameList")]
            [Validation(Required=false)]
            public List<string> OpsOwnerNameList { get; set; }

            /// <summary>
            /// <para>The name of the node owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>The user ID of the node owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30231123</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The list of custom parameters for the node.</para>
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<GetBatchTaskInfoResponseBodyTaskInfoParamList> ParamList { get; set; }
            public class GetBatchTaskInfoResponseBodyTaskInfoParamList : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the scheduling of the node is paused.</para>
            /// </summary>
            [NameInMap("Paused")]
            [Validation(Required=false)]
            public bool? Paused { get; set; }

            /// <summary>
            /// <para>The scheduling priority of the node. Valid values: 1 to 9. A larger value indicates a lower priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The HTTP path in the production environment, used for Databricks tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/sql/protocolv1/o/yyy</para>
            /// </summary>
            [NameInMap("ProdHttpPath")]
            [Validation(Required=false)]
            public string ProdHttpPath { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131211211</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is published.</para>
            /// </summary>
            [NameInMap("Published")]
            [Validation(Required=false)]
            public bool? Published { get; set; }

            /// <summary>
            /// <para>The list of third-party packages that the Python task depends on.</para>
            /// </summary>
            [NameInMap("PythonModuleList")]
            [Validation(Required=false)]
            public List<GetBatchTaskInfoResponseBodyTaskInfoPythonModuleList> PythonModuleList { get; set; }
            public class GetBatchTaskInfoResponseBodyTaskInfoPythonModuleList : TeaModel {
                /// <summary>
                /// <para>The ID of the third-party package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("ModuleId")]
                [Validation(Required=false)]
                public long? ModuleId { get; set; }

                /// <summary>
                /// <para>The name of the third-party package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pandas</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The Python version that the third-party package depends on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Python 3.7</para>
                /// </summary>
                [NameInMap("PythonVersion")]
                [Validation(Required=false)]
                public string PythonVersion { get; set; }

                /// <summary>
                /// <para>The version number of the third-party package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.3.5</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The Python version of the Python task, such as Python 3.7.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Python 3.7</para>
            /// </summary>
            [NameInMap("PythonVersion")]
            [Validation(Required=false)]
            public string PythonVersion { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test xx</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Indicates whether the task can be rerun.</para>
            /// </summary>
            [NameInMap("Rerunable")]
            [Validation(Required=false)]
            public bool? Rerunable { get; set; }

            /// <summary>
            /// <para>The ID of the schedule resource group for the production task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-abc123</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the schedule resource group for the production task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default resource group</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The schedule period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>YEARLY: Yearly.</description></item>
            /// <item><description>MONTHLY: Monthly.</description></item>
            /// <item><description>WEEKLY: Weekly.</description></item>
            /// <item><description>DAILY: Daily.</description></item>
            /// <item><description>HOURLY: Hourly.</description></item>
            /// <item><description>MINUTELY: Minutely.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("SchedulePeriod")]
            [Validation(Required=false)]
            public string SchedulePeriod { get; set; }

            /// <summary>
            /// <para>The node type. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>1: Periodic node.</description></item>
            /// <item><description>3: Manual node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public int? ScheduleType { get; set; }

            /// <summary>
            /// <para>The Spark client information.</para>
            /// </summary>
            [NameInMap("SparkClientInfo")]
            [Validation(Required=false)]
            public GetBatchTaskInfoResponseBodyTaskInfoSparkClientInfo SparkClientInfo { get; set; }
            public class GetBatchTaskInfoResponseBodyTaskInfoSparkClientInfo : TeaModel {
                /// <summary>
                /// <para>The version name of the Spark client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("SparkClientVersion")]
                [Validation(Required=false)]
                public string SparkClientVersion { get; set; }

            }

            /// <summary>
            /// <para>The publish status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Draft.</description></item>
            /// <item><description>1: Submitted.</description></item>
            /// <item><description>100: In development.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Test node 1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of task tag names.</para>
            /// </summary>
            [NameInMap("TaskTagList")]
            [Validation(Required=false)]
            public List<string> TaskTagList { get; set; }

            /// <summary>
            /// <para>The node type. For more information, see the API operation for creating an offline computing node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

            /// <summary>
            /// <para>The upstream dependencies.</para>
            /// </summary>
            [NameInMap("UpStreamList")]
            [Validation(Required=false)]
            public List<GetBatchTaskInfoResponseBodyTaskInfoUpStreamList> UpStreamList { get; set; }
            public class GetBatchTaskInfoResponseBodyTaskInfoUpStreamList : TeaModel {
                /// <summary>
                /// <para>The dependency period.</para>
                /// </summary>
                [NameInMap("DependPeriod")]
                [Validation(Required=false)]
                public GetBatchTaskInfoResponseBodyTaskInfoUpStreamListDependPeriod DependPeriod { get; set; }
                public class GetBatchTaskInfoResponseBodyTaskInfoUpStreamListDependPeriod : TeaModel {
                    /// <summary>
                    /// <para>The period offset. This parameter is required when PeriodType is set to LAST_N_PERIOD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PeriodOffset")]
                    [Validation(Required=false)]
                    public int? PeriodOffset { get; set; }

                    /// <summary>
                    /// <para>The dependency period type. Valid values: </para>
                    /// <list type="bullet">
                    /// <item><description>CURRENT_PERIOD</description></item>
                    /// <item><description>LAST_PERIOD</description></item>
                    /// <item><description>LAST_N_PERIOD</description></item>
                    /// <item><description>LAST_24_HOUR</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CURRENT_PERIOD</para>
                    /// </summary>
                    [NameInMap("PeriodType")]
                    [Validation(Required=false)]
                    public string PeriodType { get; set; }

                }

                /// <summary>
                /// <para>The dependency strategy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ALL</description></item>
                /// <item><description>FIRST</description></item>
                /// <item><description>LAST</description></item>
                /// <item><description>NEAR</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LAST</para>
                /// </summary>
                [NameInMap("DependStrategy")]
                [Validation(Required=false)]
                public string DependStrategy { get; set; }

                /// <summary>
                /// <para>The dependent logical table fields.</para>
                /// </summary>
                [NameInMap("FieldList")]
                [Validation(Required=false)]
                public List<string> FieldList { get; set; }

                /// <summary>
                /// <para>The upstream dependency node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PHYSICAL: Physical node.</description></item>
                /// <item><description>LOGICAL: Logical table dependency.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PHYSICAL</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The period difference. A value of 0 indicates a same-period dependency. A positive integer indicates a dependency on the previous N periods.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodDiff")]
                [Validation(Required=false)]
                public int? PeriodDiff { get; set; }

                /// <summary>
                /// <para>Indicates whether the upstream node is enabled.</para>
                /// </summary>
                [NameInMap("SourceNodeEnabled")]
                [Validation(Required=false)]
                public bool? SourceNodeEnabled { get; set; }

                /// <summary>
                /// <para>The ID of the upstream node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_2001</para>
                /// </summary>
                [NameInMap("SourceNodeId")]
                [Validation(Required=false)]
                public string SourceNodeId { get; set; }

                /// <summary>
                /// <para>The name of the upstream node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_input1</para>
                /// </summary>
                [NameInMap("SourceNodeName")]
                [Validation(Required=false)]
                public string SourceNodeName { get; set; }

                /// <summary>
                /// <para>The output name of the upstream node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_input1</para>
                /// </summary>
                [NameInMap("SourceNodeOutputName")]
                [Validation(Required=false)]
                public string SourceNodeOutputName { get; set; }

                /// <summary>
                /// <para>The upstream username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("SourceNodeUserName")]
                [Validation(Required=false)]
                public string SourceNodeUserName { get; set; }

                /// <summary>
                /// <para>The name of the input table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_input1</para>
                /// </summary>
                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

            }

            /// <summary>
            /// <para>The end date of the validity period. Format: yyyy-MM-dd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999-12-31</para>
            /// </summary>
            [NameInMap("ValidEndDate")]
            [Validation(Required=false)]
            public string ValidEndDate { get; set; }

            /// <summary>
            /// <para>The effective start date in the yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01</para>
            /// </summary>
            [NameInMap("ValidStartDate")]
            [Validation(Required=false)]
            public string ValidStartDate { get; set; }

        }

    }

}
