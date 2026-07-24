// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class DataRefundChangeRuleMapValue : TeaModel {
        /// <summary>
        /// <para>全程未使用退票规则</para>
        /// </summary>
        [NameInMap("refund_rule_all_unused_list")]
        [Validation(Required=false)]
        public List<DataRefundChangeRuleMapValueRefundRuleAllUnusedList> RefundRuleAllUnusedList { get; set; }
        public class DataRefundChangeRuleMapValueRefundRuleAllUnusedList : TeaModel {
            /// <summary>
            /// <para>该退票规则适用航程使用类型 0:全程未使用; 1:部分未使用</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>时间单位：day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>该退票规则适用于的退票时间区间开始时间，单位（天/小时）</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>该退票规则适用于的退票时间区间结束时间，单位（天/小时）</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 可否退票</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_refund")]
            [Validation(Required=false)]
            public bool? CanRefund { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 退票手续费</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public double? RefundFee { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 是否全额退税</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_return_all_tax")]
            [Validation(Required=false)]
            public bool? CanReturnAllTax { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 可部分退税金额</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("return_part_tax_fee")]
            [Validation(Required=false)]
            public double? ReturnPartTaxFee { get; set; }

        }

        /// <summary>
        /// <para>部分未使用退票规则</para>
        /// </summary>
        [NameInMap("refund_rule_part_unused_list")]
        [Validation(Required=false)]
        public List<DataRefundChangeRuleMapValueRefundRulePartUnusedList> RefundRulePartUnusedList { get; set; }
        public class DataRefundChangeRuleMapValueRefundRulePartUnusedList : TeaModel {
            /// <summary>
            /// <para>该退票规则适用航程使用类型 0:全程未使用; 1:部分未使用</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>时间单位：day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>该退票规则适用于的退票时间区间开始时间，单位（天/小时）</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>该退票规则适用于的退票时间区间结束时间，单位（天/小时）</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 可否退票</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_refund")]
            [Validation(Required=false)]
            public bool? CanRefund { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 退票手续费</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public double? RefundFee { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 是否全额退税</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_return_all_tax")]
            [Validation(Required=false)]
            public bool? CanReturnAllTax { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 可部分退税金额</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("return_part_tax_fee")]
            [Validation(Required=false)]
            public double? ReturnPartTaxFee { get; set; }

        }

        /// <summary>
        /// <para>回程未使用改签规则</para>
        /// </summary>
        [NameInMap("change_rule_in_unused_list")]
        [Validation(Required=false)]
        public List<DataRefundChangeRuleMapValueChangeRuleInUnusedList> ChangeRuleInUnusedList { get; set; }
        public class DataRefundChangeRuleMapValueChangeRuleInUnusedList : TeaModel {
            /// <summary>
            /// <para>该改签规则适用航程使用类型 2:去程未使用; 3:回程未使用</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>时间单位：day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>该退票规则适用于的退票时间区间开始时间，单位（天/小时）</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>该退票规则适用于的退票时间区间结束时间，单位（天/小时）</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 可否可以改签</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_change")]
            [Validation(Required=false)]
            public bool? CanChange { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 改签费</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("change_fee")]
            [Validation(Required=false)]
            public double? ChangeFee { get; set; }

        }

        /// <summary>
        /// <para>去程未使用改签规则</para>
        /// </summary>
        [NameInMap("change_rule_out_unused_list")]
        [Validation(Required=false)]
        public List<DataRefundChangeRuleMapValueChangeRuleOutUnusedList> ChangeRuleOutUnusedList { get; set; }
        public class DataRefundChangeRuleMapValueChangeRuleOutUnusedList : TeaModel {
            /// <summary>
            /// <para>该改签规则适用航程使用类型 2:去程未使用; 3:回程未使用</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>时间单位：day/hour</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("time_unit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>该退票规则适用于的退票时间区间开始时间，单位（天/小时）</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("rule_start_time")]
            [Validation(Required=false)]
            public int? RuleStartTime { get; set; }

            /// <summary>
            /// <para>该退票规则适用于的退票时间区间结束时间，单位（天/小时）</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("rule_end_time")]
            [Validation(Required=false)]
            public int? RuleEndTime { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 可否可以改签</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_change")]
            [Validation(Required=false)]
            public bool? CanChange { get; set; }

            /// <summary>
            /// <para>起飞前X-Y小时(天) 改签费</para>
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
