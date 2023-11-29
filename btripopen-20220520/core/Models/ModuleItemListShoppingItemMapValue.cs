// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleItemListShoppingItemMapValue : TeaModel {
        [NameInMap("cabin_quantity_list")]
        [Validation(Required=false)]
        public List<ModuleItemListShoppingItemMapValueCabinQuantityList> CabinQuantityList { get; set; }
        public class ModuleItemListShoppingItemMapValueCabinQuantityList : TeaModel {
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleItemListShoppingItemMapValueCabinQuantityListSegmentPosition SegmentPosition { get; set; }
            public class ModuleItemListShoppingItemMapValueCabinQuantityListSegmentPosition : TeaModel {
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

            }

            [NameInMap("cabin")]
            [Validation(Required=false)]
            public ModuleItemListShoppingItemMapValueCabinQuantityListCabin Cabin { get; set; }
            public class ModuleItemListShoppingItemMapValueCabinQuantityListCabin : TeaModel {
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                [NameInMap("cabin_class_name")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                [NameInMap("quantity")]
                [Validation(Required=false)]
                public string Quantity { get; set; }

            }

        }

        [NameInMap("search_price")]
        [Validation(Required=false)]
        public ModuleItemListShoppingItemMapValueSearchPrice SearchPrice { get; set; }
        public class ModuleItemListShoppingItemMapValueSearchPrice : TeaModel {
            [NameInMap("floor_price")]
            [Validation(Required=false)]
            public int? FloorPrice { get; set; }

            [NameInMap("ticket_price")]
            [Validation(Required=false)]
            public int? TicketPrice { get; set; }

            [NameInMap("sell_price")]
            [Validation(Required=false)]
            public int? SellPrice { get; set; }

            [NameInMap("original_sell_price")]
            [Validation(Required=false)]
            public int? OriginalSellPrice { get; set; }

            [NameInMap("base_total_price")]
            [Validation(Required=false)]
            public int? BaseTotalPrice { get; set; }

            [NameInMap("before_control_price")]
            [Validation(Required=false)]
            public int? BeforeControlPrice { get; set; }

            [NameInMap("tax")]
            [Validation(Required=false)]
            public int? Tax { get; set; }

            [NameInMap("supply_price")]
            [Validation(Required=false)]
            public int? SupplyPrice { get; set; }

            [NameInMap("basic_cabin_price")]
            [Validation(Required=false)]
            public int? BasicCabinPrice { get; set; }

            [NameInMap("build_price")]
            [Validation(Required=false)]
            public int? BuildPrice { get; set; }

            [NameInMap("oil_price")]
            [Validation(Required=false)]
            public int? OilPrice { get; set; }

            [NameInMap("first_standard_price")]
            [Validation(Required=false)]
            public int? FirstStandardPrice { get; set; }

            [NameInMap("business_standard_price")]
            [Validation(Required=false)]
            public int? BusinessStandardPrice { get; set; }

            [NameInMap("common_standard_price")]
            [Validation(Required=false)]
            public int? CommonStandardPrice { get; set; }

            /// <summary>
            /// fdPrice
            /// </summary>
            [NameInMap("inter_ticket_price")]
            [Validation(Required=false)]
            public int? InterTicketPrice { get; set; }

            [NameInMap("subtracted_price")]
            [Validation(Required=false)]
            public int? SubtractedPrice { get; set; }

            [NameInMap("origin_common_price")]
            [Validation(Required=false)]
            public int? OriginCommonPrice { get; set; }

            [NameInMap("dynamic_promotion_price")]
            [Validation(Required=false)]
            public int? DynamicPromotionPrice { get; set; }

            [NameInMap("installment_num")]
            [Validation(Required=false)]
            public int? InstallmentNum { get; set; }

            [NameInMap("installment_price")]
            [Validation(Required=false)]
            public double? InstallmentPrice { get; set; }

            [NameInMap("competition_dynamic_price")]
            [Validation(Required=false)]
            public int? CompetitionDynamicPrice { get; set; }

            [NameInMap("competition_promotion_price")]
            [Validation(Required=false)]
            public int? CompetitionPromotionPrice { get; set; }

            [NameInMap("min_before_control_price_of_normal")]
            [Validation(Required=false)]
            public int? MinBeforeControlPriceOfNormal { get; set; }

            [NameInMap("price_show_info")]
            [Validation(Required=false)]
            public ModuleItemListShoppingItemMapValueSearchPricePriceShowInfo PriceShowInfo { get; set; }
            public class ModuleItemListShoppingItemMapValueSearchPricePriceShowInfo : TeaModel {
                [NameInMap("discount_info")]
                [Validation(Required=false)]
                public string DiscountInfo { get; set; }

                [NameInMap("discount_num")]
                [Validation(Required=false)]
                public double? DiscountNum { get; set; }

                [NameInMap("show_ticket_price")]
                [Validation(Required=false)]
                public bool? ShowTicketPrice { get; set; }

            }

        }

        [NameInMap("segment_price_list")]
        [Validation(Required=false)]
        public List<ModuleItemListShoppingItemMapValueSegmentPriceList> SegmentPriceList { get; set; }
        public class ModuleItemListShoppingItemMapValueSegmentPriceList : TeaModel {
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleItemListShoppingItemMapValueSegmentPriceListSegmentPosition SegmentPosition { get; set; }
            public class ModuleItemListShoppingItemMapValueSegmentPriceListSegmentPosition : TeaModel {
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

            }

            [NameInMap("search_price")]
            [Validation(Required=false)]
            public ModuleItemListShoppingItemMapValueSegmentPriceListSearchPrice SearchPrice { get; set; }
            public class ModuleItemListShoppingItemMapValueSegmentPriceListSearchPrice : TeaModel {
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public int? TicketPrice { get; set; }

                [NameInMap("sell_price")]
                [Validation(Required=false)]
                public int? SellPrice { get; set; }

                [NameInMap("tax")]
                [Validation(Required=false)]
                public int? Tax { get; set; }

            }

        }

        /// <summary>
        /// id
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("cabin_quantity")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleItemListShoppingItemMapValueCabinQuantityValue> CabinQuantity { get; set; }

        [NameInMap("segment_price")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleItemListShoppingItemMapValueSegmentPriceValue> SegmentPrice { get; set; }

    }

}
