// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleCondition : TeaModel {
        /// <summary>
        /// <para>type=SLS_CONDITION时指定，满足条件几次后告警，默认为1</para>
        /// </summary>
        [NameInMap("alertCount")]
        [Validation(Required=false)]
        public int? AlertCount { get; set; }

        /// <summary>
        /// <para>type=SLS_CONDITION时指定</para>
        /// </summary>
        [NameInMap("caseList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionCaseList> CaseList { get; set; }
        public class AlertRuleConditionCaseList : TeaModel {
            [NameInMap("condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            [NameInMap("countCondition")]
            [Validation(Required=false)]
            public string CountCondition { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("compareList")]
        [Validation(Required=false)]
        public List<AlertRuleConditionCompareList> CompareList { get; set; }
        public class AlertRuleConditionCompareList : TeaModel {
            [NameInMap("aggregate")]
            [Validation(Required=false)]
            public string Aggregate { get; set; }

            [NameInMap("oper")]
            [Validation(Required=false)]
            public string Oper { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

            [NameInMap("valueLevelList")]
            [Validation(Required=false)]
            public List<AlertRuleConditionCompareListValueLevelList> ValueLevelList { get; set; }
            public class AlertRuleConditionCompareListValueLevelList : TeaModel {
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            [NameInMap("yoyTimeUnit")]
            [Validation(Required=false)]
            public string YoyTimeUnit { get; set; }

            [NameInMap("yoyTimeValue")]
            [Validation(Required=false)]
            public int? YoyTimeValue { get; set; }

        }

        [NameInMap("compositeEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionCompositeEscalation CompositeEscalation { get; set; }
        public class AlertRuleConditionCompositeEscalation : TeaModel {
            [NameInMap("escalations")]
            [Validation(Required=false)]
            public List<AlertRuleConditionCompositeEscalationEscalations> Escalations { get; set; }
            public class AlertRuleConditionCompositeEscalationEscalations : TeaModel {
                [NameInMap("comparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                [NameInMap("metricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                [NameInMap("statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                [NameInMap("threshold")]
                [Validation(Required=false)]
                public double? Threshold { get; set; }

            }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        [NameInMap("escalationType")]
        [Validation(Required=false)]
        public string EscalationType { get; set; }

        [NameInMap("expressEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionExpressEscalation ExpressEscalation { get; set; }
        public class AlertRuleConditionExpressEscalation : TeaModel {
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("rawExpression")]
            [Validation(Required=false)]
            public string RawExpression { get; set; }

            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>无数据时按什么级别告警，不指定则不对无数据报警</para>
        /// </summary>
        [NameInMap("noDataAlertLevel")]
        [Validation(Required=false)]
        public string NoDataAlertLevel { get; set; }

        [NameInMap("noDataAppendValue")]
        [Validation(Required=false)]
        public string NoDataAppendValue { get; set; }

        [NameInMap("noDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        [NameInMap("oper")]
        [Validation(Required=false)]
        public string Oper { get; set; }

        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        [NameInMap("simpleEscalation")]
        [Validation(Required=false)]
        public AlertRuleConditionSimpleEscalation SimpleEscalation { get; set; }
        public class AlertRuleConditionSimpleEscalation : TeaModel {
            [NameInMap("escalations")]
            [Validation(Required=false)]
            public List<AlertRuleConditionSimpleEscalationEscalations> Escalations { get; set; }
            public class AlertRuleConditionSimpleEscalationEscalations : TeaModel {
                [NameInMap("comparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                [NameInMap("threshold")]
                [Validation(Required=false)]
                public double? Threshold { get; set; }

                [NameInMap("times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

        }

        /// <summary>
        /// <para>规则条件类型，可选值：SLS_CONDITION</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
