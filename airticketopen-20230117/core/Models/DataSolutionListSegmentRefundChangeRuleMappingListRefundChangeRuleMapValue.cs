// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValue : TeaModel {
        /// <summary>
        /// <para>Fully unused refund rules</para>
        /// </summary>
        [NameInMap("refund_rule_all_unused_list")]
        [Validation(Required=false)]
        public List<DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueRefundRuleAllUnusedList> RefundRuleAllUnusedList { get; set; }
        public class DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueRefundRuleAllUnusedList : TeaModel {
            /// <summary>
            /// <para>Refund rule applicable journey usage type 0: fully unused; 1: partially unused</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>Time unit: day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>Start time of the refund time interval applicable to this refund rule, unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>End time of the refund time interval applicable to this refund rule, unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>Whether refund is allowed X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_refund")]
            [Validation(Required=false)]
            public bool? CanRefund { get; set; }

            /// <summary>
            /// <para>Refund fee X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public double? RefundFee { get; set; }

            /// <summary>
            /// <para>Whether full tax refund is available X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_return_all_tax")]
            [Validation(Required=false)]
            public bool? CanReturnAllTax { get; set; }

            /// <summary>
            /// <para>Partial tax refund amount X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("return_part_tax_fee")]
            [Validation(Required=false)]
            public double? ReturnPartTaxFee { get; set; }

        }

        /// <summary>
        /// <para>Partially unused refund rules</para>
        /// </summary>
        [NameInMap("refund_rule_part_unused_list")]
        [Validation(Required=false)]
        public List<DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueRefundRulePartUnusedList> RefundRulePartUnusedList { get; set; }
        public class DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueRefundRulePartUnusedList : TeaModel {
            /// <summary>
            /// <para>Refund rule applicable journey usage type 0: fully unused; 1: partially unused</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>Time unit: day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>Start time of the refund time interval applicable to this refund rule, unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>End time of the refund time interval applicable to this refund rule, unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>Whether refund is allowed X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_refund")]
            [Validation(Required=false)]
            public bool? CanRefund { get; set; }

            /// <summary>
            /// <para>Refund fee X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public double? RefundFee { get; set; }

            /// <summary>
            /// <para>Whether full tax refund is available X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("can_return_all_tax")]
            [Validation(Required=false)]
            public bool? CanReturnAllTax { get; set; }

            /// <summary>
            /// <para>Partial tax refund amount X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("return_part_tax_fee")]
            [Validation(Required=false)]
            public double? ReturnPartTaxFee { get; set; }

        }

        /// <summary>
        /// <para>Return/inbound unused change rules</para>
        /// </summary>
        [NameInMap("change_rule_in_unused_list")]
        [Validation(Required=false)]
        public List<DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueChangeRuleInUnusedList> ChangeRuleInUnusedList { get; set; }
        public class DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueChangeRuleInUnusedList : TeaModel {
            /// <summary>
            /// <para>Change rule applicable journey usage type 2: outbound unused; 3: return/inbound unused</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>Time unit: day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>Start time of the refund time interval applicable to this refund rule, unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>End time of the refund time interval applicable to this refund rule, unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>Whether rebooking is allowed X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_change")]
            [Validation(Required=false)]
            public bool? CanChange { get; set; }

            /// <summary>
            /// <para>Rebooking fee X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("change_fee")]
            [Validation(Required=false)]
            public double? ChangeFee { get; set; }

        }

        /// <summary>
        /// <para>Outbound unused change rules</para>
        /// </summary>
        [NameInMap("change_rule_out_unused_list")]
        [Validation(Required=false)]
        public List<DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueChangeRuleOutUnusedList> ChangeRuleOutUnusedList { get; set; }
        public class DataSolutionListSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueChangeRuleOutUnusedList : TeaModel {
            /// <summary>
            /// <para>Change rule applicable journey usage type 2: outbound unused; 3: return/inbound unused</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>Time unit: day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>Start time of the refund time interval applicable to this refund rule, unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>End time of the refund time interval applicable to this refund rule, unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>Whether rebooking is allowed X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_change")]
            [Validation(Required=false)]
            public bool? CanChange { get; set; }

            /// <summary>
            /// <para>Rebooking fee X-Y hours (days) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("change_fee")]
            [Validation(Required=false)]
            public double? ChangeFee { get; set; }

        }

    }

}
