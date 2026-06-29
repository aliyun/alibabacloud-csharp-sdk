// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDevObjectDependencyResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Dependency list.</para>
        /// </summary>
        [NameInMap("DevObjectDependencyList")]
        [Validation(Required=false)]
        public List<GetDevObjectDependencyResponseBodyDevObjectDependencyList> DevObjectDependencyList { get; set; }
        public class GetDevObjectDependencyResponseBodyDevObjectDependencyList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the task is automatically parsed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoParse")]
            [Validation(Required=false)]
            public bool? AutoParse { get; set; }

            /// <summary>
            /// <para>Business type.</para>
            /// <list type="bullet">
            /// <item><description>SCRIPT: Script</description></item>
            /// <item><description>LOGICAL_TABLE: Logical table</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SCRIPT</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>Business unit ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13111</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public string BizUnitId { get; set; }

            /// <summary>
            /// <para>Business unit name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("BizUnitName")]
            [Validation(Required=false)]
            public string BizUnitName { get; set; }

            /// <summary>
            /// <para>Cron expression for the scheduling node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 0 * * ?</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>Indicates whether a custom cron expression is used for the scheduling node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CustomCronExpression")]
            [Validation(Required=false)]
            public bool? CustomCronExpression { get; set; }

            /// <summary>
            /// <para>Dependency fields.</para>
            /// </summary>
            [NameInMap("DependFieldList")]
            [Validation(Required=false)]
            public List<string> DependFieldList { get; set; }

            /// <summary>
            /// <para>Dependency period configuration.</para>
            /// </summary>
            [NameInMap("DependencyPeriod")]
            [Validation(Required=false)]
            public GetDevObjectDependencyResponseBodyDevObjectDependencyListDependencyPeriod DependencyPeriod { get; set; }
            public class GetDevObjectDependencyResponseBodyDevObjectDependencyListDependencyPeriod : TeaModel {
                /// <summary>
                /// <para>Period offset. This parameter is required when the dependency period type is LAST_N_PERIOD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodOffset")]
                [Validation(Required=false)]
                public int? PeriodOffset { get; set; }

                /// <summary>
                /// <para>Dependency period type.</para>
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
            /// <para>Dependency strategy.</para>
            /// <list type="bullet">
            /// <item><description>ALL</description></item>
            /// <item><description>FIRST</description></item>
            /// <item><description>LAST</description></item>
            /// <item><description>NEAR</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DependencyStrategy")]
            [Validation(Required=false)]
            public string DependencyStrategy { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is a dimension table intermediate node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DimMidNode")]
            [Validation(Required=false)]
            public bool? DimMidNode { get; set; }

            /// <summary>
            /// <para>Effect fields.</para>
            /// </summary>
            [NameInMap("EffectFieldList")]
            [Validation(Required=false)]
            public List<string> EffectFieldList { get; set; }

            /// <summary>
            /// <para>Additional business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>所有字段信息/hasProd/hasDev等信息</para>
            /// </summary>
            [NameInMap("ExternalBizInfo")]
            [Validation(Required=false)]
            public string ExternalBizInfo { get; set; }

            /// <summary>
            /// <para>Indicates whether the dependency is manually added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ManuallyAdd")]
            [Validation(Required=false)]
            public bool? ManuallyAdd { get; set; }

            /// <summary>
            /// <para>Node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_13211</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>Node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>Node output name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_xx</para>
            /// </summary>
            [NameInMap("NodeOutputName")]
            [Validation(Required=false)]
            public string NodeOutputName { get; set; }

            /// <summary>
            /// <para>Output table information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_xx</para>
            /// </summary>
            [NameInMap("NodeOutputTableName")]
            [Validation(Required=false)]
            public string NodeOutputTableName { get; set; }

            /// <summary>
            /// <para>Node type.</para>
            /// <list type="bullet">
            /// <item><description>DATA_PROCESS: Code task</description></item>
            /// <item><description>BBOX_LOGIC_TABLE_NODE: Black box logical table node</description></item>
            /// <item><description>ONE_ID_LABEL: ID label node</description></item>
            /// <item><description>ONE_ID_RULE: ID rule node</description></item>
            /// <item><description>PIPELINE_NODE: Pipeline node</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_PROCESS</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>Cross-node output parameters.</para>
            /// </summary>
            [NameInMap("OutputContextParamList")]
            [Validation(Required=false)]
            public List<GetDevObjectDependencyResponseBodyDevObjectDependencyListOutputContextParamList> OutputContextParamList { get; set; }
            public class GetDevObjectDependencyResponseBodyDevObjectDependencyListOutputContextParamList : TeaModel {
                /// <summary>
                /// <para>Default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>Description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxtest</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Parameter key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>Node owners.</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<GetDevObjectDependencyResponseBodyDevObjectDependencyListOwnerList> OwnerList { get; set; }
            public class GetDevObjectDependencyResponseBodyDevObjectDependencyListOwnerList : TeaModel {
                /// <summary>
                /// <para>Node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Dependency period difference.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PeriodDiff")]
            [Validation(Required=false)]
            public int? PeriodDiff { get; set; }

            /// <summary>
            /// <para>Project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123131</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>Schedule type.</para>
            /// <list type="bullet">
            /// <item><description>MINUTELY: Minute</description></item>
            /// <item><description>HOURLY: Hour</description></item>
            /// <item><description>DAILY: Day</description></item>
            /// <item><description>WEEKLY: Week</description></item>
            /// <item><description>MONTHLY: Month</description></item>
            /// <item><description>YEARLY: Year</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <para>Indicates whether the node has a self-dependency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SelfDepend")]
            [Validation(Required=false)]
            public bool? SelfDepend { get; set; }

            /// <summary>
            /// <para>Sub-business type.</para>
            /// <list type="bullet">
            /// <item><description>MAX_COMPUTE_SQL</description></item>
            /// <item><description>HIVE_SQL</description></item>
            /// <item><description>SHELL</description></item>
            /// <item><description>PYTHON</description></item>
            /// <item><description>ONE_SERVICE_SQL</description></item>
            /// <item><description>DATABASE_SQL, etc.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SHELL</para>
            /// </summary>
            [NameInMap("SubBizType")]
            [Validation(Required=false)]
            public string SubBizType { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration is valid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
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
