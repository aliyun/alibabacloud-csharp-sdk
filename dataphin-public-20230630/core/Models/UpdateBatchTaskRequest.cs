// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateBatchTaskRequest : TeaModel {
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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The update request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateBatchTaskRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateBatchTaskRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The base schedule template ID. This parameter takes effect when the configuration method is set to schedule template. If this parameter and all other schedule fields are not specified, the original binding is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7305621095333696</para>
            /// </summary>
            [NameInMap("BaseScheduleTemplateId")]
            [Validation(Required=false)]
            public long? BaseScheduleTemplateId { get; set; }

            /// <summary>
            /// <para>The task code.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>show tables;</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable conditional scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConditionScheduleEnable")]
            [Validation(Required=false)]
            public bool? ConditionScheduleEnable { get; set; }

            /// <summary>
            /// <para>The conditional scheduling configuration details. This parameter overwrites the existing configurations. If this parameter is not specified, the original configurations are retained. This parameter is supported only for periodic tasks.</para>
            /// </summary>
            [NameInMap("ConditionScheduleParamList")]
            [Validation(Required=false)]
            public List<UpdateBatchTaskRequestUpdateCommandConditionScheduleParamList> ConditionScheduleParamList { get; set; }
            public class UpdateBatchTaskRequestUpdateCommandConditionScheduleParamList : TeaModel {
                /// <summary>
                /// <para>The condition name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>condition1</para>
                /// </summary>
                [NameInMap("ConditionName")]
                [Validation(Required=false)]
                public string ConditionName { get; set; }

                /// <summary>
                /// <para>The cron expression used after the condition is met.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 1 * * ?</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>Specifies whether to follow the primary schedule parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FollowScheduleParam")]
                [Validation(Required=false)]
                public bool? FollowScheduleParam { get; set; }

                /// <summary>
                /// <para>The node schedule status after the condition is met. Valid values:</para>
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
                /// <para>The JSON string of the conditional expression tree. The keys are in lower camel case characters and must be parsed by the invoker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;EXPRESSION&quot;,&quot;operator&quot;:&quot;or&quot;}</para>
                /// </summary>
                [NameInMap("ScheduleConditionJson")]
                [Validation(Required=false)]
                public string ScheduleConditionJson { get; set; }

                /// <summary>
                /// <para>The schedule time used after the condition is met.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01:00</para>
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

            }

            /// <summary>
            /// <para>The conditional schedule template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7305621095333697</para>
            /// </summary>
            [NameInMap("ConditionScheduleTemplateId")]
            [Validation(Required=false)]
            public long? ConditionScheduleTemplateId { get; set; }

            /// <summary>
            /// <para>The cross-node parameters. These are output parameters declared by the current node for downstream nodes to reference. This parameter overwrites the existing parameters. If this parameter is not specified, the original parameters are retained.</para>
            /// </summary>
            [NameInMap("ContextParamList")]
            [Validation(Required=false)]
            public List<UpdateBatchTaskRequestUpdateCommandContextParamList> ContextParamList { get; set; }
            public class UpdateBatchTaskRequestUpdateCommandContextParamList : TeaModel {
                /// <summary>
                /// <para>The default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test parameter</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>param1</para>
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
            public UpdateBatchTaskRequestUpdateCommandCustomScheduleConfig CustomScheduleConfig { get; set; }
            public class UpdateBatchTaskRequestUpdateCommandCustomScheduleConfig : TeaModel {
                /// <summary>
                /// <para>The end time in the HH:mm format.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20:59</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The custom interval.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The interval unit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MINUTE: Minutes.</description></item>
                /// <item><description>HOUR: Hours.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HOUR</para>
                /// </summary>
                [NameInMap("IntervalUnit")]
                [Validation(Required=false)]
                public string IntervalUnit { get; set; }

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
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAILY</para>
                /// </summary>
                [NameInMap("SchedulePeriod")]
                [Validation(Required=false)]
                public string SchedulePeriod { get; set; }

                /// <summary>
                /// <para>The start time in the HH:mm format.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>08:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The data source catalog for database SQL tasks. This parameter takes effect only for data source types that require a catalog, such as Presto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql_catalog</para>
            /// </summary>
            [NameInMap("DataSourceCatalog")]
            [Validation(Required=false)]
            public string DataSourceCatalog { get; set; }

            /// <summary>
            /// <para>The data source ID for database SQL tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12131111</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The data source schema for database SQL tasks. This parameter takes effect only for data source types that require a schema, such as Oracle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>erp</para>
            /// </summary>
            [NameInMap("DataSourceSchema")]
            [Validation(Required=false)]
            public string DataSourceSchema { get; set; }

            /// <summary>
            /// <para>The HTTP path in the development environment for Databricks tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/sql/protocolv1/o/xxx</para>
            /// </summary>
            [NameInMap("DevHttpPath")]
            [Validation(Required=false)]
            public string DevHttpPath { get; set; }

            /// <summary>
            /// <para>The ID of the schedule resource group for development tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-def456</para>
            /// </summary>
            [NameInMap("DevResourceGroupId")]
            [Validation(Required=false)]
            public string DevResourceGroupId { get; set; }

            /// <summary>
            /// <para>The list of development owner IDs.</para>
            /// </summary>
            [NameInMap("DevelopOwnerIdList")]
            [Validation(Required=false)]
            public List<string> DevelopOwnerIdList { get; set; }

            /// <summary>
            /// <para>The task execution engine, such as Python tasks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PYTHON2_7: Python 2.7.</description></item>
            /// <item><description>PYTHON3_7: Python 3.7.</description></item>
            /// <item><description>PYTHON3_11: Python 3.11.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PYTHON3_7</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The ID of the task directory tree node.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12113111</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The name of the offline task.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test111</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
            /// <para>The list of O&amp;M owner IDs. If you do not specify this parameter, the O&amp;M owners are not modified.</para>
            /// </summary>
            [NameInMap("OpsOwnerIdList")]
            [Validation(Required=false)]
            public List<string> OpsOwnerIdList { get; set; }

            /// <summary>
            /// <para>The list of custom parameters.</para>
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<UpdateBatchTaskRequestUpdateCommandParamList> ParamList { get; set; }
            public class UpdateBatchTaskRequestUpdateCommandParamList : TeaModel {
                /// <summary>
                /// <para>The parameter name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
            /// <para>The HTTP path in the production environment. This parameter is used for Databricks nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/sql/protocolv1/o/yyy</para>
            /// </summary>
            [NameInMap("ProdHttpPath")]
            [Validation(Required=false)]
            public string ProdHttpPath { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the node belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10121101</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The list of third-party Python packages on which the node depends.</para>
            /// </summary>
            [NameInMap("PythonModuleList")]
            [Validation(Required=false)]
            public List<string> PythonModuleList { get; set; }

            /// <summary>
            /// <para>The ID of the scheduling resource group for the production node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-abc123</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The scheduling cycle. Valid values:</para>
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
            /// <para>The Spark client.</para>
            /// </summary>
            [NameInMap("SparkClientInfo")]
            [Validation(Required=false)]
            public UpdateBatchTaskRequestUpdateCommandSparkClientInfo SparkClientInfo { get; set; }
            public class UpdateBatchTaskRequestUpdateCommandSparkClientInfo : TeaModel {
                /// <summary>
                /// <para>The version name of the Spark client.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("SparkClientVersion")]
                [Validation(Required=false)]
                public string SparkClientVersion { get; set; }

            }

            /// <summary>
            /// <para>The list of node tags. This parameter overwrites all existing tags. If you do not specify this parameter, the original tags remain unchanged.</para>
            /// </summary>
            [NameInMap("TaskTagList")]
            [Validation(Required=false)]
            public List<string> TaskTagList { get; set; }

            /// <summary>
            /// <para>The type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Hive SQL.</description></item>
            /// <item><description>5: MaxCompute SQL.</description></item>
            /// <item><description>10: Shell.</description></item>
            /// <item><description>21: Python.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

            /// <summary>
            /// <para>The list of upstream dependencies.</para>
            /// </summary>
            [NameInMap("UpStreamList")]
            [Validation(Required=false)]
            public List<UpdateBatchTaskRequestUpdateCommandUpStreamList> UpStreamList { get; set; }
            public class UpdateBatchTaskRequestUpdateCommandUpStreamList : TeaModel {
                /// <summary>
                /// <para>The dependency cycle.</para>
                /// </summary>
                [NameInMap("DependPeriod")]
                [Validation(Required=false)]
                public UpdateBatchTaskRequestUpdateCommandUpStreamListDependPeriod DependPeriod { get; set; }
                public class UpdateBatchTaskRequestUpdateCommandUpStreamListDependPeriod : TeaModel {
                    /// <summary>
                    /// <para>The cycle offset. This parameter is required when the PeriodType parameter is set to LAST_N_PERIOD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PeriodOffset")]
                    [Validation(Required=false)]
                    public int? PeriodOffset { get; set; }

                    /// <summary>
                    /// <para>The type of the dependency cycle. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CURRENT_PERIOD: Current cycle.</description></item>
                    /// <item><description>LAST_PERIOD: Last cycle.</description></item>
                    /// <item><description>LAST_N_PERIOD: Last N days.</description></item>
                    /// <item><description>LAST_24_HOUR: Last 24 hours.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
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
                /// <item><description>ALL: All.</description></item>
                /// <item><description>FIRST: First.</description></item>
                /// <item><description>LAST: Last.</description></item>
                /// <item><description>NEAR: Nearest.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LAST</para>
                /// </summary>
                [NameInMap("DependStrategy")]
                [Validation(Required=false)]
                public string DependStrategy { get; set; }

                /// <summary>
                /// <para>The list of dependent logical table fields.</para>
                /// </summary>
                [NameInMap("FieldList")]
                [Validation(Required=false)]
                public List<string> FieldList { get; set; }

                /// <summary>
                /// <para>The type of the upstream dependency node. Valid values:</para>
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
                /// <para>The cycle difference. A value of 0 indicates a dependency on the same cycle. A positive integer indicates a dependency on the previous N cycles.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodDiff")]
                [Validation(Required=false)]
                public int? PeriodDiff { get; set; }

                /// <summary>
                /// <para>Specifies whether the upstream node is enabled.</para>
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
                /// <para>The output name of the upstream node.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_input1</para>
                /// </summary>
                [NameInMap("SourceNodeOutputName")]
                [Validation(Required=false)]
                public string SourceNodeOutputName { get; set; }

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
            /// <para>The end date of the validity period. Format: yyyy-MM-dd. This parameter must be specified together with the ValidStartDate parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999-12-31</para>
            /// </summary>
            [NameInMap("ValidEndDate")]
            [Validation(Required=false)]
            public string ValidEndDate { get; set; }

            /// <summary>
            /// <para>The start date of the validity period. Format: yyyy-MM-dd. This parameter must be specified together with the ValidEndDate parameter.</para>
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
