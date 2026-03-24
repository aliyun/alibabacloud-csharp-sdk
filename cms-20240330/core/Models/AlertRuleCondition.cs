// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleCondition : TeaModel {
        /// <summary>
        /// <para>适用条件类型：SLS_CONDITION</para>
        /// <para>满足条件几次后告警，默认为1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("alertCount")]
        [Validation(Required=false)]
        public int? AlertCount { get; set; }

        /// <summary>
        /// <para>适用条件类型： SLS_CONDITION。</para>
        /// <para>SLS告警条件列表</para>
        /// </summary>
        [NameInMap("caseList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionCaseList> CaseList { get; set; }
        public class AlertRuleConditionCaseList : TeaModel {
            /// <summary>
            /// <para>匹配表达式，示例：  logLevel: error</para>
            /// 
            /// <b>Example:</b>
            /// <para>logLevel: error</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>数量匹配表达式，示例：
            /// 区间组合： <b>count</b> &gt;= 3 &amp;&amp; <b>count</b> &lt;= 10
            /// 单区间： __count__ &gt;= 3</para>
            /// 
            /// <b>Example:</b>
            /// <para>count &gt;= 3</para>
            /// </summary>
            [NameInMap("countCondition")]
            [Validation(Required=false)]
            public string CountCondition { get; set; }

            /// <summary>
            /// <para>满足条件后的告警级别</para>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>匹配类型： 有数据/有特定条数据/有数据匹配/有特定条数匹配。</para>
            /// <para>取值范围：</para>
            /// <list type="bullet">
            /// <item><description>HasData: 有数据</description></item>
            /// <item><description>HasDataCount:  有特定条数据</description></item>
            /// <item><description>HasDataMatch：有数据匹配</description></item>
            /// <item><description>HasDataMatchCount：有特定条数匹配</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HasData</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>适用条件类型：APM_CONDITION。</para>
        /// <para>APM告警比较条件列表</para>
        /// </summary>
        [NameInMap("compareList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionCompareList> CompareList { get; set; }
        public class AlertRuleConditionCompareList : TeaModel {
            /// <summary>
            /// <para>时间序列后聚合函数</para>
            /// <list type="bullet">
            /// <item><description>count</description></item>
            /// <item><description>sum</description></item>
            /// <item><description>avg</description></item>
            /// <item><description>min</description></item>
            /// <item><description>max</description></item>
            /// <item><description>p90</description></item>
            /// <item><description>p95</description></item>
            /// <item><description>p99</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>count</para>
            /// </summary>
            [NameInMap("aggregate")]
            [Validation(Required=false)]
            public string Aggregate { get; set; }

            /// <summary>
            /// <para>数据单位</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("baseUnit")]
            [Validation(Required=false)]
            public string BaseUnit { get; set; }

            /// <summary>
            /// <para>展示单位</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("displayUnit")]
            [Validation(Required=false)]
            public string DisplayUnit { get; set; }

            /// <summary>
            /// <para>比较操作，判断是否是同比、环比</para>
            /// <list type="bullet">
            /// <item><description>大于 GT</description></item>
            /// <item><description>大于等于 GTE</description></item>
            /// <item><description>小于 LT</description></item>
            /// <item><description>小于等于 LTE</description></item>
            /// <item><description>等于 EQ</description></item>
            /// <item><description>不等于 NE</description></item>
            /// <item><description>同比增加 YOY_UP</description></item>
            /// <item><description>同比减少 YOY_DOWN</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GT</para>
            /// </summary>
            [NameInMap("oper")]
            [Validation(Required=false)]
            public string Oper { get; set; }

            /// <summary>
            /// <para>对比的阈值</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

            /// <summary>
            /// <para>不同值的报警级别的列表。</para>
            /// </summary>
            [NameInMap("valueLevelList")]
            [Validation(Required=false)]
            public List<AlertRuleConditionCompareListValueLevelList> ValueLevelList { get; set; }
            public class AlertRuleConditionCompareListValueLevelList : TeaModel {
                /// <summary>
                /// <para>阈值对应的级别</para>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>对比的阈值</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// <para>同比时间单位（仅对oper=YOY_UP/YOY_DOWN生效）
            ///  minute、hour、day、week、month</para>
            /// 
            /// <b>Example:</b>
            /// <para>month</para>
            /// </summary>
            [NameInMap("yoyTimeUnit")]
            [Validation(Required=false)]
            public string YoyTimeUnit { get; set; }

            /// <summary>
            /// <para>同比时间的值，与yoyTimeUnit配合使用</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("yoyTimeValue")]
            [Validation(Required=false)]
            public int? YoyTimeValue { get; set; }

        }

        /// <summary>
        /// <para>适用条件类型：CMS_BASIC_CONDITION</para>
        /// <para>escalationType=composite时有效，组合指标告警条件</para>
        /// </summary>
        [NameInMap("compositeEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionCompositeEscalation CompositeEscalation { get; set; }
        public class AlertRuleConditionCompositeEscalation : TeaModel {
            /// <summary>
            /// <para>多指标的组合条件列表</para>
            /// </summary>
            [NameInMap("escalations")]
            [Validation(Required=false)]
            public List<AlertRuleConditionCompositeEscalationEscalations> Escalations { get; set; }
            public class AlertRuleConditionCompositeEscalationEscalations : TeaModel {
                /// <summary>
                /// <para>阈值比较符，取值范围：</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold：大于等于。</description></item>
                /// <item><description>GreaterThanThreshold：大于。</description></item>
                /// <item><description>LessThanOrEqualToThreshold：小于等于。</description></item>
                /// <item><description>LessThanThreshold：小于。</description></item>
                /// <item><description>NotEqualToThreshold：不等于。</description></item>
                /// <item><description>EqualToThreshold：等于。</description></item>
                /// <item><description>GreaterThanYesterday：同比昨天时间上涨。</description></item>
                /// <item><description>LessThanYesterday：同比昨天时间下降。</description></item>
                /// <item><description>GreaterThanLastWeek：同比上周同一时间上涨。</description></item>
                /// <item><description>LessThanLastWeek：同比上周同一时间下降。</description></item>
                /// <item><description>GreaterThanLastPeriod：环比上周期上涨。</description></item>
                /// <item><description>LessThanLastPeriod：环比上周期下降。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("comparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>指标名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_total</para>
                /// </summary>
                [NameInMap("metricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>指标的时间窗口</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// <para>统计方法，该参数的取值由指定云产品的MetricName对应的Statistics列决定。  监控项的统计方法。取值示例：</para>
                /// <list type="bullet">
                /// <item><description>$Maximum：最大值。</description></item>
                /// <item><description>$Minimum：最小值。</description></item>
                /// <item><description>$Average：平均值。</description></item>
                /// <item><description>$Availability：可用率（通常用于站点监控）</description></item>
                /// </list>
                /// <para>说明 $为监控项的统一前缀符号。</para>
                /// 
                /// <b>Example:</b>
                /// <para>$Maximum</para>
                /// </summary>
                [NameInMap("statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>告警阈值</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public double? Threshold { get; set; }

            }

            /// <summary>
            /// <para>满足条件时触发的告警级别(多指标组合告警仅支持一个级别)</para>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>多个指标条件之间的关系，取值为and或or</para>
            /// 
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            /// <summary>
            /// <para>触发告警需满足条件的次数</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>适用条件类型：CMS_BASIC_CONDITION</para>
        /// <para>取值范围: </para>
        /// <list type="bullet">
        /// <item><description>simple: 简单指标条件</description></item>
        /// <item><description>composite: 组合指标条件</description></item>
        /// <item><description>express: 表达式条件</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>simple</para>
        /// </summary>
        [NameInMap("escalationType")]
        [Validation(Required=false)]
        public string EscalationType { get; set; }

        /// <summary>
        /// <para>适用条件类型：CMS_BASIC_CONDITION。</para>
        /// <para>escalationType=composite时有效，多指标组合告警条件。</para>
        /// </summary>
        [NameInMap("expressEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionExpressEscalation ExpressEscalation { get; set; }
        public class AlertRuleConditionExpressEscalation : TeaModel {
            /// <summary>
            /// <para>满足条件时触发的告警级别(表达式告警仅支持一个级别)</para>
            /// <list type="bullet">
            /// <item><description>CRITICAL</description></item>
            /// <item><description>WARNING</description></item>
            /// <item><description>INFO</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>告警条件表达式</para>
            /// 
            /// <b>Example:</b>
            /// <para>@cpu_total[60].$Average &gt; 60</para>
            /// </summary>
            [NameInMap("rawExpression")]
            [Validation(Required=false)]
            public string RawExpression { get; set; }

            /// <summary>
            /// <para>触发告警需满足条件的次数</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>适用条件类型：APM_CONDITION。</para>
        /// <para>无数据时的告警级别，不指定则不对无数据报警</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("noDataAlertLevel")]
        [Validation(Required=false)]
        public string NoDataAlertLevel { get; set; }

        /// <summary>
        /// <para>适用条件类型：APM_CONDITION。</para>
        /// <para>无数据时补偿的值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("noDataAppendValue")]
        [Validation(Required=false)]
        public string NoDataAppendValue { get; set; }

        /// <summary>
        /// <para>适用条件类型：CMS_BASIC_CONDITION。</para>
        /// <para>无监控数据时报警的处理方式。取值：</para>
        /// <list type="bullet">
        /// <item><description>KEEP_LAST_STATE（默认值）：不做任何处理。</description></item>
        /// <item><description>INSUFFICIENT_DATA：报警内容为无数据。</description></item>
        /// <item><description>OK：正常。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KEEP_LAST_STATE</para>
        /// </summary>
        [NameInMap("noDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// <para>比较操作，判断是否是同比、环比</para>
        /// <list type="bullet">
        /// <item><description>大于 GT</description></item>
        /// <item><description>大于等于 GTE</description></item>
        /// <item><description>小于 LT</description></item>
        /// <item><description>小于等于 LTE</description></item>
        /// <item><description>等于 EQ</description></item>
        /// <item><description>不等于 NE</description></item>
        /// <item><description>同比增加 YOY_UP</description></item>
        /// <item><description>同比减少 YOY_DOWN</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LT</para>
        /// </summary>
        [NameInMap("oper")]
        [Validation(Required=false)]
        public string Oper { get; set; }

        /// <summary>
        /// <para>适用条件类型：APM_CONDITION。</para>
        /// <para>多个条件之间的逻辑关系。 取值：</para>
        /// <list type="bullet">
        /// <item><description>and</description></item>
        /// <item><description>or</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>适用条件类型：CMS_BASIC_CONDITION。</para>
        /// <para>仅当escalationType=simple时有效，针对单一指标设置的告警条件</para>
        /// </summary>
        [NameInMap("simpleEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionSimpleEscalation SimpleEscalation { get; set; }
        public class AlertRuleConditionSimpleEscalation : TeaModel {
            /// <summary>
            /// <para>条件列表，同一个告警规则对应多个级别的，每一个级别会有一个条件对象。</para>
            /// </summary>
            [NameInMap("escalations")]
            [Validation(Required=false)]
            public List<AlertRuleConditionSimpleEscalationEscalations> Escalations { get; set; }
            public class AlertRuleConditionSimpleEscalationEscalations : TeaModel {
                /// <summary>
                /// <para>阈值比较符，取值范围：</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold：大于等于。</description></item>
                /// <item><description>GreaterThanThreshold：大于。</description></item>
                /// <item><description>LessThanOrEqualToThreshold：小于等于。</description></item>
                /// <item><description>LessThanThreshold：小于。</description></item>
                /// <item><description>NotEqualToThreshold：不等于。</description></item>
                /// <item><description>EqualToThreshold：等于。</description></item>
                /// <item><description>GreaterThanYesterday：同比昨天时间上涨。</description></item>
                /// <item><description>LessThanYesterday：同比昨天时间下降。</description></item>
                /// <item><description>GreaterThanLastWeek：同比上周同一时间上涨。</description></item>
                /// <item><description>LessThanLastWeek：同比上周同一时间下降。</description></item>
                /// <item><description>GreaterThanLastPeriod：环比上周期上涨。</description></item>
                /// <item><description>LessThanLastPeriod：环比上周期下降。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("comparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>满足条件时触发的告警级别(表达式告警仅支持一个级别)</para>
                /// <list type="bullet">
                /// <item><description>CRITICAL</description></item>
                /// <item><description>WARNING</description></item>
                /// <item><description>INFO</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>统计方法，该参数的取值由指定云产品的MetricName对应的Statistics列决定，例如：Maximum、Minimum 和 Average</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>告警阈值</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public double? Threshold { get; set; }

                /// <summary>
                /// <para>触发告警需满足条件的次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            /// <summary>
            /// <para>适用条件类型：CMS_BASIC_CONDITION。</para>
            /// <para>告警条件关联的指标</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>指标的时间窗口，单位秒</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

        }

        /// <summary>
        /// <para>规则条件类型，取值范围：</para>
        /// <list type="bullet">
        /// <item><description>SLS_CONDITION(SLS告警条件)</description></item>
        /// <item><description>APM_CONDITION(APM告警条件)</description></item>
        /// <item><description>CMS_BASIC_CONDITION(基础云监控告警条件)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS_CONDITION</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>告警触发的阈值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
