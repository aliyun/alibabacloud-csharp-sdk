// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleFlightItemListItemListShoppingItemMapValue : TeaModel {
        /// <summary>
        /// <para>id</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADT07df0bd9-f803-4a50-8449-f4bd675d9939</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("cabin_quantity")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleFlightItemListItemListShoppingItemMapValueCabinQuantityValue> CabinQuantity { get; set; }

        [NameInMap("search_price")]
        [Validation(Required=false)]
        public ModuleFlightItemListItemListShoppingItemMapValueSearchPrice SearchPrice { get; set; }
        public class ModuleFlightItemListItemListShoppingItemMapValueSearchPrice : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>17400</para>
            /// </summary>
            [NameInMap("floor_price")]
            [Validation(Required=false)]
            public int? FloorPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>121000</para>
            /// </summary>
            [NameInMap("ticket_price")]
            [Validation(Required=false)]
            public int? TicketPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17400</para>
            /// </summary>
            [NameInMap("sell_price")]
            [Validation(Required=false)]
            public int? SellPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17400</para>
            /// </summary>
            [NameInMap("original_sell_price")]
            [Validation(Required=false)]
            public int? OriginalSellPrice { get; set; }

            [NameInMap("base_total_price")]
            [Validation(Required=false)]
            public int? BaseTotalPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17400</para>
            /// </summary>
            [NameInMap("before_control_price")]
            [Validation(Required=false)]
            public int? BeforeControlPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11000</para>
            /// </summary>
            [NameInMap("tax")]
            [Validation(Required=false)]
            public int? Tax { get; set; }

            [NameInMap("supply_price")]
            [Validation(Required=false)]
            public int? SupplyPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>242000</para>
            /// </summary>
            [NameInMap("basic_cabin_price")]
            [Validation(Required=false)]
            public int? BasicCabinPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("build_price")]
            [Validation(Required=false)]
            public int? BuildPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6000</para>
            /// </summary>
            [NameInMap("oil_price")]
            [Validation(Required=false)]
            public int? OilPrice { get; set; }

            [NameInMap("first_standard_price")]
            [Validation(Required=false)]
            public int? FirstStandardPrice { get; set; }

            [NameInMap("business_standard_price")]
            [Validation(Required=false)]
            public int? BusinessStandardPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>242000</para>
            /// </summary>
            [NameInMap("common_standard_price")]
            [Validation(Required=false)]
            public int? CommonStandardPrice { get; set; }

            /// <summary>
            /// <para>fdPrice</para>
            /// 
            /// <b>Example:</b>
            /// <para>fdPrice</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>17400</para>
            /// </summary>
            [NameInMap("min_before_control_price_of_normal")]
            [Validation(Required=false)]
            public int? MinBeforeControlPriceOfNormal { get; set; }

            [NameInMap("price_show_info")]
            [Validation(Required=false)]
            public ModuleFlightItemListItemListShoppingItemMapValueSearchPricePriceShowInfo PriceShowInfo { get; set; }
            public class ModuleFlightItemListItemListShoppingItemMapValueSearchPricePriceShowInfo : TeaModel {
                [NameInMap("discount_info")]
                [Validation(Required=false)]
                public string DiscountInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("discount_num")]
                [Validation(Required=false)]
                public double? DiscountNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("show_ticket_price")]
                [Validation(Required=false)]
                public bool? ShowTicketPrice { get; set; }

            }

        }

        [NameInMap("segment_price")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleFlightItemListItemListShoppingItemMapValueSegmentPriceValue> SegmentPrice { get; set; }

    }

}
