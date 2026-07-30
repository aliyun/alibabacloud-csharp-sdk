// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleOrderItemListRefundChangeRuleOfferPenaltyInfoMapValue : TeaModel {
        /// <summary>
        /// <para>Specifies whether the rule is applicable. Only structured refund and change rules are processed. There is no need to represent unknown situations. A flag is used to indicate this. For unstructured data, only text can be retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("struct")]
        [Validation(Required=false)]
        public bool? Struct { get; set; }

        /// <summary>
        /// <para>Indicates whether refund is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cancel_fee_ind")]
        [Validation(Required=false)]
        public bool? CancelFeeInd { get; set; }

        /// <summary>
        /// <para>Indicates whether date change is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("change_fee_ind")]
        [Validation(Required=false)]
        public bool? ChangeFeeInd { get; set; }

        /// <summary>
        /// <para>Indicates whether cabin upgrade is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("upgrade_fee_ind")]
        [Validation(Required=false)]
        public bool? UpgradeFeeInd { get; set; }

        /// <summary>
        /// <para>Indicates whether reissue is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reissue_ind")]
        [Validation(Required=false)]
        public bool? ReissueInd { get; set; }

        /// <summary>
        /// <para>The rule type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("penalty_type_code")]
        [Validation(Required=false)]
        public int? PenaltyTypeCode { get; set; }

        /// <summary>
        /// <para>The applicable scope of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("penalty_apply_range_code")]
        [Validation(Required=false)]
        public int? PenaltyApplyRangeCode { get; set; }

        /// <summary>
        /// <para>The charge method of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("penalty_charge_type_code")]
        [Validation(Required=false)]
        public int? PenaltyChargeTypeCode { get; set; }

        /// <summary>
        /// <para>The fee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("fee")]
        [Validation(Required=false)]
        public double? Fee { get; set; }

        /// <summary>
        /// <para>The fee currency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The fee percentage.
        /// [responses.200.schema.properties.module.properties.order_item_list.items.properties.refund_change_</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("penalty_percent")]
        [Validation(Required=false)]
        public double? PenaltyPercent { get; set; }

        /// <summary>
        /// <para>规则时间范围-开始时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("start_time")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>规则时间范围-结束时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("end_time")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>时间单位 HOUR(0, &quot;小时&quot;), DAY(1, &quot;天&quot;);</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("time_unit_code")]
        [Validation(Required=false)]
        public int? TimeUnitCode { get; set; }

        /// <summary>
        /// <para>The rule title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>退票费用</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The departure time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("dep_time")]
        [Validation(Required=false)]
        public string DepTime { get; set; }

        /// <summary>
        /// <para>The segment number.
        /// For example:
        ///      OUTBOUND_FIRST (&quot;Outbound first segment&quot;),
        ///      OUTBOUND_SECOND (&quot;Outbound second segment&quot;),
        ///      INBOUND_FIRST (&quot;Inbound first segment&quot;),
        ///      INBOUND_SECOND (&quot;Inbound second segment&quot;)</para>
        /// 
        /// <b>Example:</b>
        /// <para>OUTBOUND_FIRST</para>
        /// </summary>
        [NameInMap("segment_number")]
        [Validation(Required=false)]
        public string SegmentNumber { get; set; }

        /// <summary>
        /// <para>The unstructured supplementary descriptions.</para>
        /// </summary>
        [NameInMap("desc_infos")]
        [Validation(Required=false)]
        public Dictionary<string, string> DescInfos { get; set; }

    }

}
