// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValue : TeaModel {
        [NameInMap("refund_rule_all_unused_list")]
        [Validation(Required=false)]
        public List<DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueRefundRuleAllUnusedList> RefundRuleAllUnusedList { get; set; }
        public class DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueRefundRuleAllUnusedList : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            [NameInMap("can_refund")]
            [Validation(Required=false)]
            public bool? CanRefund { get; set; }

            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public double? RefundFee { get; set; }

            [NameInMap("can_return_all_tax")]
            [Validation(Required=false)]
            public bool? CanReturnAllTax { get; set; }

            [NameInMap("return_part_tax_fee")]
            [Validation(Required=false)]
            public double? ReturnPartTaxFee { get; set; }

        }

        [NameInMap("refund_rule_part_unused_list")]
        [Validation(Required=false)]
        public List<DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueRefundRulePartUnusedList> RefundRulePartUnusedList { get; set; }
        public class DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueRefundRulePartUnusedList : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            [NameInMap("can_refund")]
            [Validation(Required=false)]
            public bool? CanRefund { get; set; }

            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public double? RefundFee { get; set; }

            [NameInMap("can_return_all_tax")]
            [Validation(Required=false)]
            public bool? CanReturnAllTax { get; set; }

            [NameInMap("return_part_tax_fee")]
            [Validation(Required=false)]
            public double? ReturnPartTaxFee { get; set; }

        }

        [NameInMap("change_rule_in_unused_list")]
        [Validation(Required=false)]
        public List<DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueChangeRuleInUnusedList> ChangeRuleInUnusedList { get; set; }
        public class DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueChangeRuleInUnusedList : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            [NameInMap("can_change")]
            [Validation(Required=false)]
            public bool? CanChange { get; set; }

            [NameInMap("change_fee")]
            [Validation(Required=false)]
            public double? ChangeFee { get; set; }

        }

        [NameInMap("change_rule_out_unused_list")]
        [Validation(Required=false)]
        public List<DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueChangeRuleOutUnusedList> ChangeRuleOutUnusedList { get; set; }
        public class DataSolutionSegmentRefundChangeRuleMappingListRefundChangeRuleMapValueChangeRuleOutUnusedList : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            [NameInMap("can_change")]
            [Validation(Required=false)]
            public bool? CanChange { get; set; }

            [NameInMap("change_fee")]
            [Validation(Required=false)]
            public double? ChangeFee { get; set; }

        }

    }

}
