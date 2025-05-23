// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateBatchTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateBatchTaskRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateBatchTaskRequestUpdateCommand : TeaModel {
            /// <summary>
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
            /// <para>0 0 1 * * ?</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            [NameInMap("CustomScheduleConfig")]
            [Validation(Required=false)]
            public UpdateBatchTaskRequestUpdateCommandCustomScheduleConfig CustomScheduleConfig { get; set; }
            public class UpdateBatchTaskRequestUpdateCommandCustomScheduleConfig : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20:59</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HOUR</para>
                /// </summary>
                [NameInMap("IntervalUnit")]
                [Validation(Required=false)]
                public string IntervalUnit { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAILY</para>
                /// </summary>
                [NameInMap("SchedulePeriod")]
                [Validation(Required=false)]
                public string SchedulePeriod { get; set; }

                /// <summary>
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
            /// <b>Example:</b>
            /// <para>mysql_catalog</para>
            /// </summary>
            [NameInMap("DataSourceCatalog")]
            [Validation(Required=false)]
            public string DataSourceCatalog { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12131111</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>erp</para>
            /// </summary>
            [NameInMap("DataSourceSchema")]
            [Validation(Required=false)]
            public string DataSourceSchema { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PYTHON3_7</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12113111</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test111</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("NodeDescription")]
            [Validation(Required=false)]
            public string NodeDescription { get; set; }

            [NameInMap("NodeOutputNameList")]
            [Validation(Required=false)]
            public List<string> NodeOutputNameList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public int? NodeStatus { get; set; }

            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<UpdateBatchTaskRequestUpdateCommandParamList> ParamList { get; set; }
            public class UpdateBatchTaskRequestUpdateCommandParamList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
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
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10121101</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("PythonModuleList")]
            [Validation(Required=false)]
            public List<string> PythonModuleList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("SchedulePeriod")]
            [Validation(Required=false)]
            public string SchedulePeriod { get; set; }

            [NameInMap("SparkClientInfo")]
            [Validation(Required=false)]
            public UpdateBatchTaskRequestUpdateCommandSparkClientInfo SparkClientInfo { get; set; }
            public class UpdateBatchTaskRequestUpdateCommandSparkClientInfo : TeaModel {
                /// <summary>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

            [NameInMap("UpStreamList")]
            [Validation(Required=false)]
            public List<UpdateBatchTaskRequestUpdateCommandUpStreamList> UpStreamList { get; set; }
            public class UpdateBatchTaskRequestUpdateCommandUpStreamList : TeaModel {
                [NameInMap("DependPeriod")]
                [Validation(Required=false)]
                public UpdateBatchTaskRequestUpdateCommandUpStreamListDependPeriod DependPeriod { get; set; }
                public class UpdateBatchTaskRequestUpdateCommandUpStreamListDependPeriod : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PeriodOffset")]
                    [Validation(Required=false)]
                    public int? PeriodOffset { get; set; }

                    /// <summary>
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
                /// <b>Example:</b>
                /// <para>LAST</para>
                /// </summary>
                [NameInMap("DependStrategy")]
                [Validation(Required=false)]
                public string DependStrategy { get; set; }

                [NameInMap("FieldList")]
                [Validation(Required=false)]
                public List<string> FieldList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PHYSICAL</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodDiff")]
                [Validation(Required=false)]
                public int? PeriodDiff { get; set; }

                [NameInMap("SourceNodeEnabled")]
                [Validation(Required=false)]
                public bool? SourceNodeEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>n_2001</para>
                /// </summary>
                [NameInMap("SourceNodeId")]
                [Validation(Required=false)]
                public string SourceNodeId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_input1</para>
                /// </summary>
                [NameInMap("SourceNodeOutputName")]
                [Validation(Required=false)]
                public string SourceNodeOutputName { get; set; }

                /// <summary>
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
