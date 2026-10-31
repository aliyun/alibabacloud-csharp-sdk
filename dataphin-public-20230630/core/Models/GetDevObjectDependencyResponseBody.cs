// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDevObjectDependencyResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The dependency list.</para>
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
            /// <para>The business type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SCRIPT: Script.</description></item>
            /// <item><description>LOGICAL_TABLE: Logical table.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SCRIPT</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>The business module ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13111</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public string BizUnitId { get; set; }

            /// <summary>
            /// <para>The business unit name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("BizUnitName")]
            [Validation(Required=false)]
            public string BizUnitName { get; set; }

            /// <summary>
            /// <para>The cron expression of the scheduling node.</para>
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
            /// <para>The dependent fields.</para>
            /// </summary>
            [NameInMap("DependFieldList")]
            [Validation(Required=false)]
            public List<string> DependFieldList { get; set; }

            /// <summary>
            /// <para>The dependency period configuration.</para>
            /// </summary>
            [NameInMap("DependencyPeriod")]
            [Validation(Required=false)]
            public GetDevObjectDependencyResponseBodyDevObjectDependencyListDependencyPeriod DependencyPeriod { get; set; }
            public class GetDevObjectDependencyResponseBodyDevObjectDependencyListDependencyPeriod : TeaModel {
                /// <summary>
                /// <para>The period offset. This parameter is required when the dependency period type is LAST_N_PERIOD.</para>
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
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DependencyStrategy")]
            [Validation(Required=false)]
            public string DependencyStrategy { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is an intermediate node of a dimension table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DimMidNode")]
            [Validation(Required=false)]
            public bool? DimMidNode { get; set; }

            /// <summary>
            /// <para>The dependent fields.</para>
            /// </summary>
            [NameInMap("EffectFieldList")]
            [Validation(Required=false)]
            public List<string> EffectFieldList { get; set; }

            /// <summary>
            /// <para>The additional business information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>All field information, hasProd, hasDev, and other information</para>
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
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_13211</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The node output name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_xx</para>
            /// </summary>
            [NameInMap("NodeOutputName")]
            [Validation(Required=false)]
            public string NodeOutputName { get; set; }

            /// <summary>
            /// <para>The output table information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_xx</para>
            /// </summary>
            [NameInMap("NodeOutputTableName")]
            [Validation(Required=false)]
            public string NodeOutputTableName { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DATA_PROCESS: Code task.</description></item>
            /// <item><description>BBOX_LOGIC_TABLE_NODE: Black-box logical table node.</description></item>
            /// <item><description>ONE_ID_LABEL: Extracted tag node.</description></item>
            /// <item><description>ONE_ID_RULE: Extracted tag node.</description></item>
            /// <item><description>PIPELINE_NODE: Pipeline node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_PROCESS</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The cross-node output parameters.</para>
            /// </summary>
            [NameInMap("OutputContextParamList")]
            [Validation(Required=false)]
            public List<GetDevObjectDependencyResponseBodyDevObjectDependencyListOutputContextParamList> OutputContextParamList { get; set; }
            public class GetDevObjectDependencyResponseBodyDevObjectDependencyListOutputContextParamList : TeaModel {
                /// <summary>
                /// <para>The default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxtest</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>The node owner.</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<GetDevObjectDependencyResponseBodyDevObjectDependencyListOwnerList> OwnerList { get; set; }
            public class GetDevObjectDependencyResponseBodyDevObjectDependencyListOwnerList : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The dependency period difference.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PeriodDiff")]
            [Validation(Required=false)]
            public int? PeriodDiff { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123131</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The scheduling type. Valid values: MINUTELY (minute), HOURLY (hour), DAILY (day), WEEKLY (week), MONTHLY (month), and YEARLY (year).</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <para>Indicates whether self-dependency is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SelfDepend")]
            [Validation(Required=false)]
            public bool? SelfDepend { get; set; }

            /// <summary>
            /// <para>The sub-business type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MAX_COMPUTE_SQL</description></item>
            /// <item><description>HIVE_SQL</description></item>
            /// <item><description>SHELL</description></item>
            /// <item><description>PYTHON</description></item>
            /// <item><description>ONE_SERVICE_SQL</description></item>
            /// <item><description>DATABASE_SQL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SHELL</para>
            /// </summary>
            [NameInMap("SubBizType")]
            [Validation(Required=false)]
            public string SubBizType { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration is effective.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

        }

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
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
