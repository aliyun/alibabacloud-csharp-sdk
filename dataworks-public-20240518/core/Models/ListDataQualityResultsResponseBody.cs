// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>数据质量校验结果分页查询结果。</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityResultsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityResultsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>质量校验结果列表。</para>
            /// </summary>
            [NameInMap("DataQualityResults")]
            [Validation(Required=false)]
            public List<ListDataQualityResultsResponseBodyPagingInfoDataQualityResults> DataQualityResults { get; set; }
            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResults : TeaModel {
                /// <summary>
                /// <para>校验结果生成时间。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1708284916414</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>本次校验的详情。</para>
                /// </summary>
                [NameInMap("Details")]
                [Validation(Required=false)]
                public List<ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsDetails> Details { get; set; }
                public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsDetails : TeaModel {
                    /// <summary>
                    /// <para>最终用来与阈值比较的值。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.0</para>
                    /// </summary>
                    [NameInMap("CheckedValue")]
                    [Validation(Required=false)]
                    public string CheckedValue { get; set; }

                    /// <summary>
                    /// <para>使用引用的样本，用来参与CheckedValue计算的基准值。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("ReferencedValue")]
                    [Validation(Required=false)]
                    public string ReferencedValue { get; set; }

                    /// <summary>
                    /// <para>最终的比较结果状态：</para>
                    /// <list type="bullet">
                    /// <item><description>Error</description></item>
                    /// <item><description>Passed</description></item>
                    /// <item><description>Warned</description></item>
                    /// <item><description>Critical</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Passed</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>校验结果ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>16033</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>校验开始时，规则配置快照。</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRule Rule { get; set; }
                public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRule : TeaModel {
                    /// <summary>
                    /// <para>样本校验设置。</para>
                    /// </summary>
                    [NameInMap("CheckingConfig")]
                    [Validation(Required=false)]
                    public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfig CheckingConfig { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfig : TeaModel {
                        /// <summary>
                        /// <para>有些类型的阈值需要查询出一些参考样本，然后对参考样本的值进行汇总得出进行比较的阈值，这里使用一个表达式来表示参考样本的查询方式。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
                        /// </summary>
                        [NameInMap("ReferencedSamplesFilter")]
                        [Validation(Required=false)]
                        public string ReferencedSamplesFilter { get; set; }

                        /// <summary>
                        /// <para>阈值设置。</para>
                        /// </summary>
                        [NameInMap("Thresholds")]
                        [Validation(Required=false)]
                        public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholds Thresholds { get; set; }
                        public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholds : TeaModel {
                            /// <summary>
                            /// <para>严重警告的阈值设置。</para>
                            /// </summary>
                            [NameInMap("Critical")]
                            [Validation(Required=false)]
                            public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsCritical Critical { get; set; }
                            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsCritical : TeaModel {
                                /// <summary>
                                /// <para>阈值表达式。</para>
                                /// <para>波动率类型规则必须使用表达式方式表示波动阈值。如：</para>
                                /// <list type="bullet">
                                /// <item><description>波动上升大于0.01： $checkValue &gt; 0.01 </description></item>
                                /// <item><description>波动下降大于0.01：$checkValue &lt; -0.01 </description></item>
                                /// <item><description>波动率绝对值：abs($checkValue) &gt; 0.01</description></item>
                                /// </list>
                                /// <para>固定值类型规则也可以使用表达式方式配置阈值，如果同时配置，表达式优先级高于Operator和Value。</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>$checkValue &gt; 0.01</para>
                                /// </summary>
                                [NameInMap("Expression")]
                                [Validation(Required=false)]
                                public string Expression { get; set; }

                                /// <summary>
                                /// <para>比较符：</para>
                                /// <list type="bullet">
                                /// <item><description>\&gt;</description></item>
                                /// <item><description>\&gt;=</description></item>
                                /// <item><description>\&lt;</description></item>
                                /// <item><description>\&lt;=</description></item>
                                /// <item><description>!=</description></item>
                                /// <item><description>=</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <remarks>
                                /// </remarks>
                                /// </summary>
                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                /// <summary>
                                /// <para>阈值数值。</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100.0</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>期望的阈值设置。</para>
                            /// </summary>
                            [NameInMap("Expected")]
                            [Validation(Required=false)]
                            public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsExpected Expected { get; set; }
                            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsExpected : TeaModel {
                                /// <summary>
                                /// <para>阈值表达式。</para>
                                /// <para>波动率类型规则必须使用表达式方式表示波动阈值。如：</para>
                                /// <list type="bullet">
                                /// <item><description>波动上升大于0.01： $checkValue &gt; 0.01 </description></item>
                                /// <item><description>波动下降大于0.01：$checkValue &lt; -0.01 </description></item>
                                /// <item><description>波动率绝对值：abs($checkValue) &gt; 0.01</description></item>
                                /// </list>
                                /// <para>固定值类型规则也可以使用表达式方式配置阈值，如果同时配置，表达式优先级高于Operator和Value。</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>$checkValue &gt; 0.01</para>
                                /// </summary>
                                [NameInMap("Expression")]
                                [Validation(Required=false)]
                                public string Expression { get; set; }

                                /// <summary>
                                /// <para>比较符：</para>
                                /// <list type="bullet">
                                /// <item><description>\&gt;</description></item>
                                /// <item><description>\&gt;=</description></item>
                                /// <item><description>\&lt;</description></item>
                                /// <item><description>\&lt;=</description></item>
                                /// <item><description>!=</description></item>
                                /// <item><description>=</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <remarks>
                                /// </remarks>
                                /// </summary>
                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                /// <summary>
                                /// <para>阈值数值。</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100.0</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>普通警告的阈值设置。</para>
                            /// </summary>
                            [NameInMap("Warned")]
                            [Validation(Required=false)]
                            public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsWarned Warned { get; set; }
                            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsWarned : TeaModel {
                                /// <summary>
                                /// <para>阈值表达式。</para>
                                /// <para>波动率类型规则必须使用表达式方式表示波动阈值。如：</para>
                                /// <list type="bullet">
                                /// <item><description>波动上升大于0.01： $checkValue &gt; 0.01 </description></item>
                                /// <item><description>波动下降大于0.01：$checkValue &lt; -0.01 </description></item>
                                /// <item><description>波动率绝对值：abs($checkValue) &gt; 0.01</description></item>
                                /// </list>
                                /// <para>固定值类型规则也可以使用表达式方式配置阈值，如果同时配置，表达式优先级高于Operator和Value。</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>$checkValue &gt; 0.01</para>
                                /// </summary>
                                [NameInMap("Expression")]
                                [Validation(Required=false)]
                                public string Expression { get; set; }

                                /// <summary>
                                /// <para>比较符：</para>
                                /// <list type="bullet">
                                /// <item><description>\&gt;</description></item>
                                /// <item><description>\&gt;=</description></item>
                                /// <item><description>\&lt;</description></item>
                                /// <item><description>\&lt;=</description></item>
                                /// <item><description>!=</description></item>
                                /// <item><description>=</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <remarks>
                                /// </remarks>
                                /// </summary>
                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                /// <summary>
                                /// <para>阈值数值。</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100.0</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>阈值计算方式：</para>
                        /// <list type="bullet">
                        /// <item><description>Fixed</description></item>
                        /// <item><description>Fluctation</description></item>
                        /// <item><description>FluctationDiscreate</description></item>
                        /// <item><description>Auto</description></item>
                        /// <item><description>Average</description></item>
                        /// <item><description>Variance</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Fixed</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>规则描述信息，最长500个字符。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>this is a odps _sql task</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>规则是否启用。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>质量规则校验问题处理器。</para>
                    /// </summary>
                    [NameInMap("ErrorHandlers")]
                    [Validation(Required=false)]
                    public List<ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleErrorHandlers> ErrorHandlers { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleErrorHandlers : TeaModel {
                        /// <summary>
                        /// <para>如果是自定义SQL规则，需要用户指定SQL来过滤问题数据。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SELECT * FROM tb_api_log WHERE id IS NULL</para>
                        /// </summary>
                        [NameInMap("ErrorDataFilter")]
                        [Validation(Required=false)]
                        public string ErrorDataFilter { get; set; }

                        /// <summary>
                        /// <para>处理器类型。</para>
                        /// <list type="bullet">
                        /// <item><description>SaveErrorData</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SaveErrorData</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>规则ID。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>规则名称，数字、英文字母、汉字、半角全角标点符号组合，最长255个字符。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The table cannot be empty.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>DataWorks项目空间ID。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    /// <summary>
                    /// <para>样本采集所需的设置。</para>
                    /// </summary>
                    [NameInMap("SamplingConfig")]
                    [Validation(Required=false)]
                    public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleSamplingConfig SamplingConfig { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleSamplingConfig : TeaModel {
                        /// <summary>
                        /// <para>采样的指标名称：</para>
                        /// <list type="bullet">
                        /// <item><description>Count：表行数</description></item>
                        /// <item><description>Min：字段最小值</description></item>
                        /// <item><description>Max：字段最大值</description></item>
                        /// <item><description>Avg：字段均值</description></item>
                        /// <item><description>DistinctCount：字段唯一值个数</description></item>
                        /// <item><description>DistinctPercent：字段唯一值个数与数据行数占比</description></item>
                        /// <item><description>DuplicatedCount：字段重复值个数</description></item>
                        /// <item><description>DuplicatedPercent：字段重复值个数与数据行数占比</description></item>
                        /// <item><description>TableSize：表大小</description></item>
                        /// <item><description>NullValueCount：字段为空的行数</description></item>
                        /// <item><description>NullValuePercent：字段为空的比例</description></item>
                        /// <item><description>GroupCount：按字段值聚合后每个值与对应的数据行数</description></item>
                        /// <item><description>CountNotIn：枚举值不匹配行数</description></item>
                        /// <item><description>CountDistinctNotIn：枚举值不匹配唯一值个数</description></item>
                        /// <item><description>UserDefinedSql：通过自定义SQL做样本采集</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Count</para>
                        /// </summary>
                        [NameInMap("Metric")]
                        [Validation(Required=false)]
                        public string Metric { get; set; }

                        /// <summary>
                        /// <para>样本采集时，所需的参数。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{ &quot;columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] }</para>
                        /// </summary>
                        [NameInMap("MetricParameters")]
                        [Validation(Required=false)]
                        public string MetricParameters { get; set; }

                        /// <summary>
                        /// <para>采样时，对不关注的数据进行二次过滤的条件，最多16777215个字符。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>id IS NULL</para>
                        /// </summary>
                        [NameInMap("SamplingFilter")]
                        [Validation(Required=false)]
                        public string SamplingFilter { get; set; }

                        /// <summary>
                        /// <para>具体执行采样语句前，插入执行的一些运行时参数设置语句，最长1000个字符。目前只支持MaxCompute。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SET odps.sql.udf.timeout=600s;</para>
                        /// </summary>
                        [NameInMap("SettingConfig")]
                        [Validation(Required=false)]
                        public string SettingConfig { get; set; }

                    }

                    /// <summary>
                    /// <para>规则对于业务的等级（对应页面上的强弱规则）：</para>
                    /// <list type="bullet">
                    /// <item><description>High</description></item>
                    /// <item><description>Normal</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// <para>规则所监控的对象。</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleTarget Target { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleTarget : TeaModel {
                        /// <summary>
                        /// <para>表类型的数据集，表所属的数据库类型：</para>
                        /// <list type="bullet">
                        /// <item><description>maxcompute</description></item>
                        /// <item><description>emr</description></item>
                        /// <item><description>cdh</description></item>
                        /// <item><description>hologres</description></item>
                        /// <item><description>analyticdb_for_postgresql</description></item>
                        /// <item><description>analyticdb_for_mysql</description></item>
                        /// <item><description>starrocks</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>maxcompute</para>
                        /// </summary>
                        [NameInMap("DatabaseType")]
                        [Validation(Required=false)]
                        public string DatabaseType { get; set; }

                        /// <summary>
                        /// <para>表在数据地图中的唯一ID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>odps.unit_test.tb_unit_test</para>
                        /// </summary>
                        [NameInMap("TableGuid")]
                        [Validation(Required=false)]
                        public string TableGuid { get; set; }

                        /// <summary>
                        /// <para>监控对象类型：</para>
                        /// <list type="bullet">
                        /// <item><description>Table</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Table</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>创建规则时所引用的规则模板Code。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SYSTEM:user_defined_sql</para>
                    /// </summary>
                    [NameInMap("TemplateCode")]
                    [Validation(Required=false)]
                    public string TemplateCode { get; set; }

                }

                /// <summary>
                /// <para>本次校验所使用的样本值。</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///   {
                ///     &quot;gender&quot;: &quot;male&quot;,
                ///     &quot;_count&quot;: 100
                ///   }, {
                ///     &quot;gender&quot;: &quot;female&quot;,
                ///     &quot;_count&quot;: 100
                ///   }
                /// ]</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <para>校验结果状态：</para>
                /// <list type="bullet">
                /// <item><description>Running</description></item>
                /// <item><description>Error</description></item>
                /// <item><description>Passed</description></item>
                /// <item><description>Warned</description></item>
                /// <item><description>Critical</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Passed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>校验任务实例ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>200001</para>
                /// </summary>
                [NameInMap("TaskInstanceId")]
                [Validation(Required=false)]
                public long? TaskInstanceId { get; set; }

            }

            /// <summary>
            /// <para>页码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>页大小。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>总条数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>219</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>API请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
