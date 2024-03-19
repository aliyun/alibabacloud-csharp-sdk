// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleOrderItemListBaggageRuleBaggageInfoMapValue : TeaModel {
        [NameInMap("carry_freepc")]
        [Validation(Required=false)]
        public int? CarryFreepc { get; set; }

        [NameInMap("carry_bag_weight")]
        [Validation(Required=false)]
        public int? CarryBagWeight { get; set; }

        [NameInMap("carry_bag_size")]
        [Validation(Required=false)]
        public string CarryBagSize { get; set; }

        [NameInMap("is_all_carry_bag_weight")]
        [Validation(Required=false)]
        public bool? IsAllCarryBagWeight { get; set; }

        [NameInMap("airline")]
        [Validation(Required=false)]
        public string Airline { get; set; }

        [NameInMap("start_airport")]
        [Validation(Required=false)]
        public string StartAirport { get; set; }

        [NameInMap("end_airport")]
        [Validation(Required=false)]
        public string EndAirport { get; set; }

        [NameInMap("start_city_code")]
        [Validation(Required=false)]
        public string StartCityCode { get; set; }

        [NameInMap("end_city_code")]
        [Validation(Required=false)]
        public string EndCityCode { get; set; }

        [NameInMap("free_pcs")]
        [Validation(Required=false)]
        public long? FreePcs { get; set; }

        [NameInMap("baggage_weight")]
        [Validation(Required=false)]
        public long? BaggageWeight { get; set; }

        [NameInMap("baggage_unit")]
        [Validation(Required=false)]
        public string BaggageUnit { get; set; }

        [NameInMap("baggage_size")]
        [Validation(Required=false)]
        public string BaggageSize { get; set; }

        [NameInMap("all_weight")]
        [Validation(Required=false)]
        public bool? AllWeight { get; set; }

        [NameInMap("total_pcs")]
        [Validation(Required=false)]
        public long? TotalPcs { get; set; }

        [NameInMap("total_weight")]
        [Validation(Required=false)]
        public long? TotalWeight { get; set; }

    }

}
