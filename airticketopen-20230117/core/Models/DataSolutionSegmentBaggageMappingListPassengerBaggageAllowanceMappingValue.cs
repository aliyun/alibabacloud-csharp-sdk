// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class DataSolutionSegmentBaggageMappingListPassengerBaggageAllowanceMappingValue : TeaModel {
        [NameInMap("baggage_amount")]
        [Validation(Required=false)]
        public int? BaggageAmount { get; set; }

        [NameInMap("baggage_weight")]
        [Validation(Required=false)]
        public int? BaggageWeight { get; set; }

        [NameInMap("baggage_weight_unit")]
        [Validation(Required=false)]
        public string BaggageWeightUnit { get; set; }

        [NameInMap("is_all_weight")]
        [Validation(Required=false)]
        public bool? IsAllWeight { get; set; }

        [NameInMap("carry_on_amount")]
        [Validation(Required=false)]
        public int? CarryOnAmount { get; set; }

        [NameInMap("carry_on_weight")]
        [Validation(Required=false)]
        public int? CarryOnWeight { get; set; }

        [NameInMap("carry_on_weight_unit")]
        [Validation(Required=false)]
        public string CarryOnWeightUnit { get; set; }

        [NameInMap("is_all_carry_on_weight")]
        [Validation(Required=false)]
        public bool? IsAllCarryOnWeight { get; set; }

    }

}
