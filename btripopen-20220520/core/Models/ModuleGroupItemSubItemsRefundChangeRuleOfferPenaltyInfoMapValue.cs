// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleGroupItemSubItemsRefundChangeRuleOfferPenaltyInfoMapValue : TeaModel {
        /// <summary>
        /// <para>Indicates whether the rule is applicable. Only structured refund and change rules are processed. Unknown situations do not need to be represented. A flag is used to indicate this. Unstructured data can only provide text.</para>
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
        /// <para>true</para>
        /// </summary>
        [NameInMap("change_fee_ind")]
        [Validation(Required=false)]
        public bool? ChangeFeeInd { get; set; }

        /// <summary>
        /// <para>Indicates whether cabin upgrade is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("upgrade_fee_ind")]
        [Validation(Required=false)]
        public bool? UpgradeFeeInd { get; set; }

        /// <summary>
        /// <para>Indicates whether reissue is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("reissue_ind")]
        [Validation(Required=false)]
        public bool? ReissueInd { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Cancellation fee.</description></item>
        /// <item><description>1: Date change fee.</description></item>
        /// <item><description>2: No-show penalty.</description></item>
        /// <item><description>3: Other.</description></item>
        /// <item><description>4: Upgrade fee.</description></item>
        /// <item><description>100: Tax refund.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("penalty_type_code")]
        [Validation(Required=false)]
        public int? PenaltyTypeCode { get; set; }

        /// <summary>
        /// <para>The applicable range of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: All unused.</description></item>
        /// <item><description>2: Partially unused.</description></item>
        /// <item><description>3: Outbound.</description></item>
        /// <item><description>4: Inbound.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("penalty_apply_range_code")]
        [Validation(Required=false)]
        public int? PenaltyApplyRangeCode { get; set; }

        /// <summary>
        /// <para>The charge method of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Charged per whole trip.</description></item>
        /// <item><description>1: Charged per direction.</description></item>
        /// <item><description>2: Charged per segment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("penalty_charge_type_code")]
        [Validation(Required=false)]
        public int? PenaltyChargeTypeCode { get; set; }

        /// <summary>
        /// <para>The fee amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("fee")]
        [Validation(Required=false)]
        public double? Fee { get; set; }

        /// <summary>
        /// <para>The currency of the fee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The fee percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("penalty_percent")]
        [Validation(Required=false)]
        public double? PenaltyPercent { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48</para>
        /// </summary>
        [NameInMap("start_time")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>The end time. The current time is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("end_time")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The time unit. Valid values: HOUR(0, &quot;hour&quot;), DAY(1, &quot;day&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("time_unit_code")]
        [Validation(Required=false)]
        public int? TimeUnitCode { get; set; }

    }

}
