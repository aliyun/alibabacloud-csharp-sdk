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
        /// <para>The submit request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubmitCommand")]
        [Validation(Required=false)]
        public SubmitBatchTaskRequestSubmitCommand SubmitCommand { get; set; }
        public class SubmitBatchTaskRequestSubmitCommand : TeaModel {
            /// <summary>
            /// <para>The code of the node.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>show tables;</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
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
            /// <para>The cron expression for automatic scheduling. Refer to the Linux cron expression syntax.</para>
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
            public SubmitBatchTaskRequestSubmitCommandCustomScheduleConfig CustomScheduleConfig { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandCustomScheduleConfig : TeaModel {
                /// <summary>
                /// <para>The end time in the format of HH:mm.</para>
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
                /// <item><description>MINUTE: minute</description></item>
                /// <item><description>HOUR: hour</description></item>
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
                /// <item><description>YEARLY</description></item>
                /// <item><description>MONTHLY</description></item>
                /// <item><description>WEEKLY</description></item>
                /// <item><description>DAILY</description></item>
                /// <item><description>HOURLY</description></item>
                /// <item><description>MINUTELY</description></item>
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
                /// <para>The start time in the format of HH:mm.</para>
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
            /// <para>The execution engine for the node, such as for Python tasks. Valid values:</para>
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
            /// <para>The node ID in the directory tree.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12113111</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The name of the batch task.</para>
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
            /// <para>xx测试</para>
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
            /// <b>Example:</b>
            /// <para>template_123456</para>
            /// </summary>
            [NameInMap("OfflineCodeTemplateId")]
            [Validation(Required=false)]
            public string OfflineCodeTemplateId { get; set; }

            [NameInMap("OfflineCodeTemplateParams")]
            [Validation(Required=false)]
            public List<SubmitBatchTaskRequestSubmitCommandOfflineCodeTemplateParams> OfflineCodeTemplateParams { get; set; }
            public class SubmitBatchTaskRequestSubmitCommandOfflineCodeTemplateParams : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>参数说明</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EncryptEnabled")]
                [Validation(Required=false)]
                public bool? EncryptEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>paramKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
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
            /// <para>The scheduling priority of the node. Valid values: 1 to 9. A larger value indicates a lower priority.</para>
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
            /// <para>The Python third-party packages that the node depends on.</para>
            /// </summary>
            [NameInMap("PythonModuleList")]
            [Validation(Required=false)]
            public List<string> PythonModuleList { get; set; }

            /// <summary>
            /// <para>The schedule period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>YEARLY</description></item>
            /// <item><description>MONTHLY</description></item>
            /// <item><description>WEEKLY</description></item>
            /// <item><description>DAILY</description></item>
            /// <item><description>HOURLY</description></item>
            /// <item><description>MINUTELY</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("SchedulePeriod")]
            [Validation(Required=false)]
            public string SchedulePeriod { get; set; }

            /// <summary>
            /// <para>The Spark client information.</para>
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
                    /// <item><description>LAST_PERIOD: previous period</description></item>
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
                /// <para>The type of the upstream dependency node. Valid values:</para>
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
                /// <para>The period difference. A value of 0 indicates a same-period dependency. A positive number indicates a dependency on the previous N periods.</para>
                /// <para>This parameter is required.</para>
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

        }

    }

}
