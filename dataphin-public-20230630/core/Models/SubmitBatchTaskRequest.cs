// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SubmitBatchTaskRequest : TeaModel {
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
        /// <para>The edit request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubmitCommand")]
        [Validation(Required=false)]
        public SubmitBatchTaskRequestSubmitCommand SubmitCommand { get; set; }
        public class SubmitBatchTaskRequestSubmitCommand : TeaModel {
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
            /// <para>The code template version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CodeTemplateVersion")]
            [Validation(Required=false)]
            public int? CodeTemplateVersion { get; set; }

            /// <summary>
            /// <para>The comment for the submit operation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The conditional scheduling configuration. If this parameter is not specified, the current configuration is retained. If Enable is set to false, conditional scheduling is disabled and the original conditions are cleared. This parameter is supported only for periodic tasks.</para>
            /// </summary>
            [NameInMap("ConditionScheduleConfig")]
            [Validation(Required=false)]
            public SubmitBatchTaskRequestSubmitCommandConditionScheduleConfig ConditionScheduleConfig { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandConditionScheduleConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable conditional scheduling. This parameter is required when the ConditionScheduleConfig object is passed and is verified by the backend. If this parameter is set to false, conditional scheduling is disabled and the previous configuration is cleared.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The list of custom conditions. This parameter is mutually exclusive with TemplateId. An empty list clears the previous conditions.</para>
                /// </summary>
                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<SubmitBatchTaskRequestSubmitCommandConditionScheduleConfigParamList> ParamList { get; set; }
                public class SubmitBatchTaskRequestSubmitCommandConditionScheduleConfigParamList : TeaModel {
                    /// <summary>
                    /// <para>The condition name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>workday</para>
                    /// </summary>
                    [NameInMap("ConditionName")]
                    [Validation(Required=false)]
                    public string ConditionName { get; set; }

                    /// <summary>
                    /// <para>The cron expression used after a condition is matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 0 5 * * ?</para>
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
                    /// <para>Specifies whether to follow the primary scheduling parameters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("FollowScheduleParam")]
                    [Validation(Required=false)]
                    public bool? FollowScheduleParam { get; set; }

                    /// <summary>
                    /// <para>The scheduling status used after a condition is matched. Valid values:</para>
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
                    /// <para>The JSON character string of the conditional expression tree. Internal key names use lower camel case.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("ScheduleConditionJson")]
                    [Validation(Required=false)]
                    public string ScheduleConditionJson { get; set; }

                    /// <summary>
                    /// <para>The scheduling time used after a condition is matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>05:00</para>
                    /// </summary>
                    [NameInMap("ScheduleTime")]
                    [Validation(Required=false)]
                    public string ScheduleTime { get; set; }

                }

                /// <summary>
                /// <para>The ID of the conditional scheduling template. This parameter is mutually exclusive with ParamList.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1002</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

            /// <summary>
            /// <para>The amount of CPU resources. If this parameter is not specified, the current configuration of the task is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("CpuResource")]
            [Validation(Required=false)]
            public string CpuResource { get; set; }

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
            /// <para>The custom scheduling interval configuration.</para>
            /// </summary>
            [NameInMap("CustomScheduleConfig")]
            [Validation(Required=false)]
            public SubmitBatchTaskRequestSubmitCommandCustomScheduleConfig CustomScheduleConfig { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandCustomScheduleConfig : TeaModel {
                /// <summary>
                /// <para>The end time in the HH:mm format.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10:00</para>
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
                /// <para>The scheduling period. Valid values:</para>
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
                /// <para>10:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The task execution engine. For Python tasks, valid values:</para>
            /// <list type="bullet">
            /// <item><description>PYTHON2_7</description></item>
            /// <item><description>PYTHON3_7</description></item>
            /// <item><description>PYTHON3_11</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PYTHON3_7</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The failure retry configuration. If this parameter is not specified, the current configuration of the task is retained. If this parameter is specified, the entire configuration object is replaced.</para>
            /// </summary>
            [NameInMap("ExecuteRerunConfig")]
            [Validation(Required=false)]
            public SubmitBatchTaskRequestSubmitCommandExecuteRerunConfig ExecuteRerunConfig { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandExecuteRerunConfig : TeaModel {
                /// <summary>
                /// <para>The custom retry interval for failures.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("CustomRerunInterval")]
                [Validation(Required=false)]
                public string CustomRerunInterval { get; set; }

                /// <summary>
                /// <para>The custom number of retries for failures.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CustomRerunTimes")]
                [Validation(Required=false)]
                public string CustomRerunTimes { get; set; }

                /// <summary>
                /// <para>Specifies whether to follow the system configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("FollowSystem")]
                [Validation(Required=false)]
                public bool? FollowSystem { get; set; }

            }

            /// <summary>
            /// <para>The execution timeout configuration. If this parameter is not specified, the current configuration of the task is retained. If this parameter is specified, the entire configuration object is replaced.</para>
            /// </summary>
            [NameInMap("ExecuteTimeOutConfig")]
            [Validation(Required=false)]
            public SubmitBatchTaskRequestSubmitCommandExecuteTimeOutConfig ExecuteTimeOutConfig { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandExecuteTimeOutConfig : TeaModel {
                /// <summary>
                /// <para>The custom timeout period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1800</para>
                /// </summary>
                [NameInMap("CustomValues")]
                [Validation(Required=false)]
                public string CustomValues { get; set; }

                /// <summary>
                /// <para>Specifies whether to follow the system configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("FollowSystem")]
                [Validation(Required=false)]
                public bool? FollowSystem { get; set; }

            }

            /// <summary>
            /// <para>The ID of the node in the task directory tree.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12113111</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The amount of CPU resources. If this parameter is not specified, the current configuration of the task is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("MemoryResource")]
            [Validation(Required=false)]
            public string MemoryResource { get; set; }

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
            /// <para>The task description.</para>
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
            /// <para>The node status. Valid values:</para>
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
            /// <para>The ID of the offline code template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template_123456</para>
            /// </summary>
            [NameInMap("OfflineCodeTemplateId")]
            [Validation(Required=false)]
            public string OfflineCodeTemplateId { get; set; }

            /// <summary>
            /// <para>The list of offline code template parameters.</para>
            /// </summary>
            [NameInMap("OfflineCodeTemplateParams")]
            [Validation(Required=false)]
            public List<SubmitBatchTaskRequestSubmitCommandOfflineCodeTemplateParams> OfflineCodeTemplateParams { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandOfflineCodeTemplateParams : TeaModel {
                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Parameter description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Specifies whether encryption is enabled.</para>
                /// </summary>
                [NameInMap("EncryptEnabled")]
                [Validation(Required=false)]
                public bool? EncryptEnabled { get; set; }

                /// <summary>
                /// <para>The parameter key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>paramKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>paramValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of custom parameters.</para>
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<SubmitBatchTaskRequestSubmitCommandParamList> ParamList { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandParamList : TeaModel {
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
                /// <para>The parameter value.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The task scheduling priority. Valid values: 1 to 9. A larger value indicates a lower priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

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
            /// <para>The list of Python third-party packages on which the node depends.</para>
            /// </summary>
            [NameInMap("PythonModuleList")]
            [Validation(Required=false)]
            public List<string> PythonModuleList { get; set; }

            /// <summary>
            /// <para>The list of referenced resources. Each element is a resource name. If this parameter is not specified, the resource references of the original node are used. If a list is specified, the existing references are completely replaced. An empty list clears all references.</para>
            /// </summary>
            [NameInMap("ResourceReferenceList")]
            [Validation(Required=false)]
            public List<string> ResourceReferenceList { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable retry on timeout. If this parameter is not specified, the current configuration of the node is retained. If this parameter is explicitly set to false, the feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RetryOnTimeoutEnable")]
            [Validation(Required=false)]
            public bool? RetryOnTimeoutEnable { get; set; }

            /// <summary>
            /// <para>The scheduling period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>YEARLY: yearly</description></item>
            /// <item><description>MONTHLY: monthly</description></item>
            /// <item><description>WEEKLY: weekly</description></item>
            /// <item><description>DAILY: daily</description></item>
            /// <item><description>HOURLY: hourly</description></item>
            /// <item><description>MINUTELY: minutely</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("SchedulePeriod")]
            [Validation(Required=false)]
            public string SchedulePeriod { get; set; }

            /// <summary>
            /// <para>The basic scheduling template. If this parameter is not specified, the current template is retained. An empty object unbinds the template. This parameter is supported only for periodic nodes.</para>
            /// </summary>
            [NameInMap("ScheduleTemplate")]
            [Validation(Required=false)]
            public SubmitBatchTaskRequestSubmitCommandScheduleTemplate ScheduleTemplate { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandScheduleTemplate : TeaModel {
                /// <summary>
                /// <para>The ID of the basic scheduling template. The value must be a positive number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

            /// <summary>
            /// <para>The Spark client.</para>
            /// </summary>
            [NameInMap("SparkClientInfo")]
            [Validation(Required=false)]
            public SubmitBatchTaskRequestSubmitCommandSparkClientInfo SparkClientInfo { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandSparkClientInfo : TeaModel {
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
            /// <para>Specifies whether to enable dynamic resources for Spark. If this parameter is not specified, the current configuration of the node is retained. If this parameter is explicitly set to false, the feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SparkDynamicResourceSwitch")]
            [Validation(Required=false)]
            public bool? SparkDynamicResourceSwitch { get; set; }

            /// <summary>
            /// <para>The effective scope of the Spark resource configuration. ONLY_PROD indicates the production environment only. PROD_AND_DEV indicates both the production and development environments. If this parameter is not specified, the current configuration of the node is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONLY_PROD</para>
            /// </summary>
            [NameInMap("SparkResourceEffectScope")]
            [Validation(Required=false)]
            public string SparkResourceEffectScope { get; set; }

            /// <summary>
            /// <para>The Spark SQL resource configurations. The key is the configuration item name, and the value is a string. If this parameter is not specified, the current configurations of the node are retained. An empty map clears all configurations.</para>
            /// </summary>
            [NameInMap("SparkSqlResourceConfigMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> SparkSqlResourceConfigMap { get; set; }

            /// <summary>
            /// <para>The upstream dependencies.</para>
            /// </summary>
            [NameInMap("UpStreamList")]
            [Validation(Required=false)]
            public List<SubmitBatchTaskRequestSubmitCommandUpStreamList> UpStreamList { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandUpStreamList : TeaModel {
                /// <summary>
                /// <para>The dependency period.</para>
                /// </summary>
                [NameInMap("DependPeriod")]
                [Validation(Required=false)]
                public SubmitBatchTaskRequestSubmitCommandUpStreamListDependPeriod DependPeriod { get; set; }
                public class SubmitBatchTaskRequestSubmitCommandUpStreamListDependPeriod : TeaModel {
                    /// <summary>
                    /// <para>The period offset. This parameter is required when dependencyPeriodType is set to LAST_N_PERIOD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PeriodOffset")]
                    [Validation(Required=false)]
                    public int? PeriodOffset { get; set; }

                    /// <summary>
                    /// <para>The dependency period type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CURRENT_PERIOD: current period</description></item>
                    /// <item><description>LAST_PERIOD: last period</description></item>
                    /// <item><description>LAST_N_PERIOD: last N days</description></item>
                    /// <item><description>LAST_24_HOUR: last 24 hours</description></item>
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
                /// <item><description>ALL: all</description></item>
                /// <item><description>FIRST: first</description></item>
                /// <item><description>LAST: last</description></item>
                /// <item><description>NEAR: nearest</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALL</para>
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
                /// <item><description>PHYSICAL: physical node</description></item>
                /// <item><description>LOGICAL: logical table dependency</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PHYSICAL</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The period difference. A value of 0 indicates a dependency on the same period. A positive value indicates a dependency on the previous N periods.</para>
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

        }

    }

}
