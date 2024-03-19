// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleOrderItemListRefundChangeRuleOfferPenaltyInfoMapValue : TeaModel {
        [NameInMap("struct")]
        [Validation(Required=false)]
        public bool? Struct { get; set; }

        [NameInMap("cancel_fee_ind")]
        [Validation(Required=false)]
        public bool? CancelFeeInd { get; set; }

        [NameInMap("change_fee_ind")]
        [Validation(Required=false)]
        public bool? ChangeFeeInd { get; set; }

        [NameInMap("upgrade_fee_ind")]
        [Validation(Required=false)]
        public bool? UpgradeFeeInd { get; set; }

        [NameInMap("reissue_ind")]
        [Validation(Required=false)]
        public bool? ReissueInd { get; set; }

        [NameInMap("penalty_type_code")]
        [Validation(Required=false)]
        public int? PenaltyTypeCode { get; set; }

        [NameInMap("penalty_apply_range_code")]
        [Validation(Required=false)]
        public int? PenaltyApplyRangeCode { get; set; }

        [NameInMap("penalty_charge_type_code")]
        [Validation(Required=false)]
        public int? PenaltyChargeTypeCode { get; set; }

        [NameInMap("fee")]
        [Validation(Required=false)]
        public double? Fee { get; set; }

        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("penalty_percent")]
        [Validation(Required=false)]
        public double? PenaltyPercent { get; set; }

        [NameInMap("start_time")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        [NameInMap("end_time")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        [NameInMap("time_unit_code")]
        [Validation(Required=false)]
        public int? TimeUnitCode { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
