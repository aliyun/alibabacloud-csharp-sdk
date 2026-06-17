// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRulesRequest : TeaModel {
        /// <summary>
        /// <para>The list of threshold alert rules.</para>
        /// <para>Valid values of N: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<PutResourceMetricRulesRequestRules> Rules { get; set; }
        public class PutResourceMetricRulesRequestRules : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=false)]
            public PutResourceMetricRulesRequestRulesEscalations Escalations { get; set; }
            public class PutResourceMetricRulesRequestRulesEscalations : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public PutResourceMetricRulesRequestRulesEscalationsCritical Critical { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsCritical : TeaModel {
                    /// <summary>
                    /// <para>Critical级别阈值比较符。取值：</para>
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
                    /// <para>N的取值范围：1~50。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GreaterThanOrEqualToThreshold</para>
                    /// </summary>
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    /// <summary>
                    /// <para>Critical级别报警统计方法。</para>
                    /// <para>N的取值范围：1~50。</para>
                    /// <para>该参数的取值由指定云产品的<c>MetricName</c>对应的<c>Statistics</c>列决定，例如：Maximum、Minimum和Average。关于如何获取该参数的取值，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>Critical级别报警阈值。</para>
                    /// <para>N的取值范围：1~50。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>Critical级别报警重试次数。</para>
                    /// <para>N的取值范围：1~50。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Info")]
                [Validation(Required=false)]
                public PutResourceMetricRulesRequestRulesEscalationsInfo Info { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsInfo : TeaModel {
                    /// <summary>
                    /// <para>Info级别阈值比较符。取值：</para>
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
                    /// <para>N的取值范围：1~50。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GreaterThanOrEqualToThreshold</para>
                    /// </summary>
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    /// <summary>
                    /// <para>Info级别报警统计方法。</para>
                    /// <para>N的取值范围：1~50。</para>
                    /// <para>该参数的取值由指定云产品的<c>MetricName</c>对应的<c>Statistics</c>列决定，例如：Maximum、Minimum和Average。关于如何获取该参数的取值，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>Info级别报警阈值。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>Info级别报警重试次数。</para>
                    /// <para>N的取值范围：1~50。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Warn")]
                [Validation(Required=false)]
                public PutResourceMetricRulesRequestRulesEscalationsWarn Warn { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsWarn : TeaModel {
                    /// <summary>
                    /// <para>Warn级别阈值比较符。取值：</para>
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
                    /// <para>N的取值范围：1~50。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GreaterThanOrEqualToThreshold</para>
                    /// </summary>
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    /// <summary>
                    /// <para>Warn级别报警统计方法。</para>
                    /// <para>N的取值范围：1~50。</para>
                    /// <para>该参数的取值由指定云产品的<c>MetricName</c>对应的<c>Statistics</c>列决定，例如：Maximum、Minimum和Average。关于如何获取该参数的取值，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>Warn级别报警阈值。</para>
                    /// <para>N的取值范围：1~50。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>Warn级别报警重试次数。</para>
                    /// <para>N的取值范围：1~50。</para>
                    /// <remarks>
                    /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

            }

            /// <summary>
            /// <para>报警联系组。报警通知会发送给该报警联系组中的报警联系人。</para>
            /// <para>N的取值范围：1~50。</para>
            /// <remarks>
            /// <para>报警联系组是一组报警联系人，可以包含一个或多个报警联系人。关于如何创建报警联系人和报警联系组，请参见<a href="https://help.aliyun.com/document_detail/114923.html">PutContact</a>和<a href="https://help.aliyun.com/document_detail/114929.html">PutContactGroup</a>。</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_Group</para>
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public string ContactGroups { get; set; }

            /// <summary>
            /// <para>报警规则的生效时间范围。</para>
            /// <para>N的取值范围：1~50。</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-23:59</para>
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// <para>报警邮件主题。</para>
            /// <para>N的取值范围：1~50。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS instance alert</para>
            /// </summary>
            [NameInMap("EmailSubject")]
            [Validation(Required=false)]
            public string EmailSubject { get; set; }

            /// <summary>
            /// <para>报警规则的触发周期。</para>
            /// <para>单位：秒。</para>
            /// <para>N的取值范围：1~50。</para>
            /// <remarks>
            /// <para>关于如何查询监控项的统计周期，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            /// <summary>
            /// <para>当监控项达到报警条件并进行报警时，标签同时写入监控项，在报警通知中进行展示。</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<PutResourceMetricRulesRequestRulesLabels> Labels { get; set; }
            public class PutResourceMetricRulesRequestRulesLabels : TeaModel {
                /// <summary>
                /// <para>标签键。</para>
                /// 
                /// <b>Example:</b>
                /// <para>tagKey1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>标签值。</para>
                /// <remarks>
                /// <para>标签值支持模板参数，将模板参数替换为实际标签值。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>监控项名称。</para>
            /// <para>N的取值范围：1~50。</para>
            /// <para>关于如何查询监控项名称，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>云产品的数据命名空间。</para>
            /// <para>N的取值范围：1~50。</para>
            /// <para>关于如何查询云产品的数据命名空间，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>无监控数据时报警的处理方式。取值：</para>
            /// <list type="bullet">
            /// <item><description>KEEP_LAST_STATE（默认值）：不做任何处理。</description></item>
            /// <item><description>INSUFFICIENT_DATA：报警内容为无数据。</description></item>
            /// <item><description>OK：正常。</description></item>
            /// </list>
            /// <para>N的取值范围：1~50。</para>
            /// 
            /// <b>Example:</b>
            /// <para>KEEP_LAST_STATE</para>
            /// </summary>
            [NameInMap("NoDataPolicy")]
            [Validation(Required=false)]
            public string NoDataPolicy { get; set; }

            /// <summary>
            /// <para>报警规则的失效时间范围。</para>
            /// <para>N的取值范围：1~50。</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-06:00</para>
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// <para>监控项的统计周期。</para>
            /// <para>单位：秒。默认为监控项的原始上报周期。</para>
            /// <para>N的取值范围：1~50。</para>
            /// <remarks>
            /// <para>关于如何查询监控项的统计周期，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>资源信息，例如：<c>[{&quot;instanceId&quot;:&quot;i-uf6j91r34rnwawoo****&quot;}]</c>、<c>[{&quot;userId&quot;:&quot;100931896542****&quot;}]</c>。</para>
            /// <para>N的取值范围：1~50。</para>
            /// <para>关于资源信息支持的维度Dimensions，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;instanceId&quot;:&quot;i-uf6j91r34rnwawoo****&quot;}]</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            /// <summary>
            /// <para>报警规则ID。</para>
            /// <para>N的取值范围：1~50。</para>
            /// <para>您可以输入新的报警规则ID，也可以使用云监控已存在的报警规则ID。关于如何查询报警规则ID，请参见<a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>。</para>
            /// <remarks>
            /// <para>输入新的报警规则ID，表示创建一条阈值报警规则。</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a151cd6023eacee2f0978e03863cc1697c89508****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>报警规则名称。</para>
            /// <para>N的取值范围：1~50。</para>
            /// <para>您可以输入新的报警规则名称，也可以使用云监控已存在的报警规则名称。关于如何查询报警规则名称，请参见<a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>。</para>
            /// <remarks>
            /// <para>输入新的报警规则名称，表示创建一条阈值报警规则。</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test123</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>是否发送恢复通知</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SendOK")]
            [Validation(Required=false)]
            public bool? SendOK { get; set; }

            /// <summary>
            /// <para>通道沉默周期。</para>
            /// <para>单位：秒，默认值：86400。</para>
            /// <para>N的取值范围：1~50。</para>
            /// <remarks>
            /// <para>通道沉默周期是指报警发生后未恢复正常，间隔多久重新发送一次报警通知。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// <para>报警发生回调时指定的URL地址，向URL发送POST请求。</para>
            /// <para>N的取值范围：1~50。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alert.aliyun.com.com:8080/callback">https://alert.aliyun.com.com:8080/callback</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

    }

}
