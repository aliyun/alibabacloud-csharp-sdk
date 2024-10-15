// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleGroupItemSubItemsRefundChangeRuleOfferPenaltyInfoMapValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("struct")]
        [Validation(Required=false)]
        public bool? Struct { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cancel_fee_ind")]
        [Validation(Required=false)]
        public bool? CancelFeeInd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("change_fee_ind")]
        [Validation(Required=false)]
        public bool? ChangeFeeInd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("upgrade_fee_ind")]
        [Validation(Required=false)]
        public bool? UpgradeFeeInd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("reissue_ind")]
        [Validation(Required=false)]
        public bool? ReissueInd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("penalty_type_code")]
        [Validation(Required=false)]
        public int? PenaltyTypeCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("penalty_apply_range_code")]
        [Validation(Required=false)]
        public int? PenaltyApplyRangeCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("penalty_charge_type_code")]
        [Validation(Required=false)]
        public int? PenaltyChargeTypeCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("fee")]
        [Validation(Required=false)]
        public double? Fee { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("penalty_percent")]
        [Validation(Required=false)]
        public double? PenaltyPercent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48</para>
        /// </summary>
        [NameInMap("start_time")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("end_time")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("time_unit_code")]
        [Validation(Required=false)]
        public int? TimeUnitCode { get; set; }

    }

}
