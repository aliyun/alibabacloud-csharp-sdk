// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class DataRefundChangeRuleMapValue : TeaModel {
        /// <summary>
        /// <para>refund rule for fully-unused tickets</para>
        /// </summary>
        [NameInMap("refund_rule_all_unused_list")]
        [Validation(Required=false)]
        public List<DataRefundChangeRuleMapValueRefundRuleAllUnusedList> RefundRuleAllUnusedList { get; set; }
        public class DataRefundChangeRuleMapValueRefundRuleAllUnusedList : TeaModel {
            /// <summary>
            /// <para>type: 0 - fully-unused ticket; 1 - partially used ticket</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>time unit: day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>applicable refund rule start time, time unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>applicable refund rule end time, time unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>whether refundable X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_refund")]
            [Validation(Required=false)]
            public bool? CanRefund { get; set; }

            /// <summary>
            /// <para>refund fee X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public double? RefundFee { get; set; }

            /// <summary>
            /// <para>whether tax is fully refundable X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_return_all_tax")]
            [Validation(Required=false)]
            public bool? CanReturnAllTax { get; set; }

            /// <summary>
            /// <para>tax amount refundable X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("return_part_tax_fee")]
            [Validation(Required=false)]
            public double? ReturnPartTaxFee { get; set; }

        }

        /// <summary>
        /// <para>refund rule for partially-used tickets</para>
        /// </summary>
        [NameInMap("refund_rule_part_unused_list")]
        [Validation(Required=false)]
        public List<DataRefundChangeRuleMapValueRefundRulePartUnusedList> RefundRulePartUnusedList { get; set; }
        public class DataRefundChangeRuleMapValueRefundRulePartUnusedList : TeaModel {
            /// <summary>
            /// <para>type: 0 - fully-unused ticket; 1 - partially used ticket</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>time unit: day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>applicable refund rule start time, time unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>applicable refund rule end time, time unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>whether refundable X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_refund")]
            [Validation(Required=false)]
            public bool? CanRefund { get; set; }

            /// <summary>
            /// <para>refund fee X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public double? RefundFee { get; set; }

            /// <summary>
            /// <para>whether tax is fully refundable X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_return_all_tax")]
            [Validation(Required=false)]
            public bool? CanReturnAllTax { get; set; }

            /// <summary>
            /// <para>tax amount refundable X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("return_part_tax_fee")]
            [Validation(Required=false)]
            public double? ReturnPartTaxFee { get; set; }

        }

        /// <summary>
        /// <para>change rule for inbound segment unused tickets</para>
        /// </summary>
        [NameInMap("change_rule_in_unused_list")]
        [Validation(Required=false)]
        public List<DataRefundChangeRuleMapValueChangeRuleInUnusedList> ChangeRuleInUnusedList { get; set; }
        public class DataRefundChangeRuleMapValueChangeRuleInUnusedList : TeaModel {
            /// <summary>
            /// <para>type: 2 - outbound segment unused; 3 - inbound segment unused</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>time unit: day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>applicable change rule start time, time unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>applicable change rule end time, time unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>whether changeable X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_change")]
            [Validation(Required=false)]
            public bool? CanChange { get; set; }

            /// <summary>
            /// <para>change fee X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("change_fee")]
            [Validation(Required=false)]
            public double? ChangeFee { get; set; }

        }

        /// <summary>
        /// <para>change rule for outbound-flight-unused tickets</para>
        /// </summary>
        [NameInMap("change_rule_out_unused_list")]
        [Validation(Required=false)]
        public List<DataRefundChangeRuleMapValueChangeRuleOutUnusedList> ChangeRuleOutUnusedList { get; set; }
        public class DataRefundChangeRuleMapValueChangeRuleOutUnusedList : TeaModel {
            /// <summary>
            /// <para>type: 2 - outbound segment unused; 3 - inbound segment unused</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>time unit: day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>applicable change rule start time, time unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>applicable change rule end time, time unit (day/hour)</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>whether changeable X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_change")]
            [Validation(Required=false)]
            public bool? CanChange { get; set; }

            /// <summary>
            /// <para>change fee X-Y hour(day) before departure</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("change_fee")]
            [Validation(Required=false)]
            public double? ChangeFee { get; set; }

        }

    }

}
