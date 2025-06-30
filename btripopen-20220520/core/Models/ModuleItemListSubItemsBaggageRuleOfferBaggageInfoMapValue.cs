// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleItemListSubItemsBaggageRuleOfferBaggageInfoMapValue : TeaModel {
        [NameInMap("start_city_code")]
        [Validation(Required=false)]
        public string StartCityCode { get; set; }

        [NameInMap("end_city_code")]
        [Validation(Required=false)]
        public string EndCityCode { get; set; }

        [NameInMap("carry_free_pc")]
        [Validation(Required=false)]
        public int? CarryFreePc { get; set; }

        [NameInMap("carry_bag_weight")]
        [Validation(Required=false)]
        public int? CarryBagWeight { get; set; }

        [NameInMap("carry_bag_size")]
        [Validation(Required=false)]
        public string CarryBagSize { get; set; }

        [NameInMap("is_all_carry_bag_weight")]
        [Validation(Required=false)]
        public bool? IsAllCarryBagWeight { get; set; }

        [NameInMap("total_pcs")]
        [Validation(Required=false)]
        public long? TotalPcs { get; set; }

        [NameInMap("total_weight")]
        [Validation(Required=false)]
        public long? TotalWeight { get; set; }

        [NameInMap("carry_unknown")]
        [Validation(Required=false)]
        public bool? CarryUnknown { get; set; }

        [NameInMap("carry_length")]
        [Validation(Required=false)]
        public int? CarryLength { get; set; }

        [NameInMap("carry_width")]
        [Validation(Required=false)]
        public int? CarryWidth { get; set; }

        [NameInMap("carry_height")]
        [Validation(Required=false)]
        public int? CarryHeight { get; set; }

        [NameInMap("carry_sum_of_length_width_height")]
        [Validation(Required=false)]
        public int? CarrySumOfLengthWidthHeight { get; set; }

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

        [NameInMap("length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        [NameInMap("height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("sum_of_length_width_height")]
        [Validation(Required=false)]
        public int? SumOfLengthWidthHeight { get; set; }

        [NameInMap("unknown")]
        [Validation(Required=false)]
        public bool? Unknown { get; set; }

        [NameInMap("cn_desc")]
        [Validation(Required=false)]
        public string CnDesc { get; set; }

        [NameInMap("en_desc")]
        [Validation(Required=false)]
        public string EnDesc { get; set; }

        [NameInMap("attribute")]
        [Validation(Required=false)]
        public string Attribute { get; set; }

        [NameInMap("baggage_price")]
        [Validation(Required=false)]
        public int? BaggagePrice { get; set; }

        [NameInMap("carry_on_baggage_tips")]
        [Validation(Required=false)]
        public string CarryOnBaggageTips { get; set; }

    }

}
