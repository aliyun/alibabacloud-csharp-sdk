// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleFlightItemListBestPriceItemShoppingItemMapValue : TeaModel {
        /// <summary>
        /// <para>The remaining cabin inventory for each segment.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Empty when no value exists.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("cabin_quantity_list")]
        [Validation(Required=false)]
        public List<ModuleFlightItemListBestPriceItemShoppingItemMapValueCabinQuantityList> CabinQuantityList { get; set; }
        public class ModuleFlightItemListBestPriceItemShoppingItemMapValueCabinQuantityList : TeaModel {
            /// <summary>
            /// <para>The segment position index.</para>
            /// </summary>
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleFlightItemListBestPriceItemShoppingItemMapValueCabinQuantityListSegmentPosition SegmentPosition { get; set; }
            public class ModuleFlightItemListBestPriceItemShoppingItemMapValueCabinQuantityListSegmentPosition : TeaModel {
                /// <summary>
                /// <para>The journey index (starting from 0).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The segment index (starting from 0 within the same journey).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

            }

            /// <summary>
            /// <para>The cabin details.</para>
            /// </summary>
            [NameInMap("cabin_info")]
            [Validation(Required=false)]
            public ModuleFlightItemListBestPriceItemShoppingItemMapValueCabinQuantityListCabinInfo CabinInfo { get; set; }
            public class ModuleFlightItemListBestPriceItemShoppingItemMapValueCabinQuantityListCabinInfo : TeaModel {
                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class. Valid values: F: first class. C: business class. Y: economy class. P: premium economy class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class name. Displays the custom name if one exists, otherwise displays the standard name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_class_name")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                /// <summary>
                /// <para>The number of remaining seats in the cabin. 0-9: 0 to 9 seats remaining. A: more than 9 seats. Example: 8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public string Quantity { get; set; }

            }

        }

        /// <summary>
        /// <para>The price quote provided by the search.</para>
        /// </summary>
        [NameInMap("search_price")]
        [Validation(Required=false)]
        public ModuleFlightItemListBestPriceItemShoppingItemMapValueSearchPrice SearchPrice { get; set; }
        public class ModuleFlightItemListBestPriceItemShoppingItemMapValueSearchPrice : TeaModel {
            /// <summary>
            /// <para>The floor price (unit: cents).</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>17400</para>
            /// </summary>
            [NameInMap("floor_price")]
            [Validation(Required=false)]
            public int? FloorPrice { get; set; }

            /// <summary>
            /// <para>The face value price (unit: cents).</para>
            /// 
            /// <b>Example:</b>
            /// <para>121000</para>
            /// </summary>
            [NameInMap("ticket_price")]
            [Validation(Required=false)]
            public int? TicketPrice { get; set; }

            /// <summary>
            /// <para>The selling price (unit: cents).</para>
            /// 
            /// <b>Example:</b>
            /// <para>17400</para>
            /// </summary>
            [NameInMap("sell_price")]
            [Validation(Required=false)]
            public int? SellPrice { get; set; }

            /// <summary>
            /// <para>The original selling price before promotions (unit: cents).</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>17400</para>
            /// </summary>
            [NameInMap("original_sell_price")]
            [Validation(Required=false)]
            public int? OriginalSellPrice { get; set; }

            /// <summary>
            /// <para>The controlled total price (unit: cents).</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>管控总价格（单位：分）</para>
            /// </summary>
            [NameInMap("base_total_price")]
            [Validation(Required=false)]
            public int? BaseTotalPrice { get; set; }

            /// <summary>
            /// <para>The pre-control price (unit: cents).</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>17400</para>
            /// </summary>
            [NameInMap("before_control_price")]
            [Validation(Required=false)]
            public int? BeforeControlPrice { get; set; }

            /// <summary>
            /// <para>The reference tax (unit: cents).</para>
            /// 
            /// <b>Example:</b>
            /// <para>11000</para>
            /// </summary>
            [NameInMap("tax")]
            [Validation(Required=false)]
            public int? Tax { get; set; }

            /// <summary>
            /// <para>The supplier selling price.</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>采购产品，服务商的销售价</para>
            /// </summary>
            [NameInMap("supply_price")]
            [Validation(Required=false)]
            public int? SupplyPrice { get; set; }

            /// <summary>
            /// <para>The cabin base price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>242000</para>
            /// </summary>
            [NameInMap("basic_cabin_price")]
            [Validation(Required=false)]
            public int? BasicCabinPrice { get; set; }

            /// <summary>
            /// <para>The domestic airport construction fee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("build_price")]
            [Validation(Required=false)]
            public int? BuildPrice { get; set; }

            /// <summary>
            /// <para>The domestic fuel surcharge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6000</para>
            /// </summary>
            [NameInMap("oil_price")]
            [Validation(Required=false)]
            public int? OilPrice { get; set; }

            /// <summary>
            /// <para>The first class base price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>头等舱基准价格</para>
            /// </summary>
            [NameInMap("first_standard_price")]
            [Validation(Required=false)]
            public int? FirstStandardPrice { get; set; }

            /// <summary>
            /// <para>The business class base price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>商务舱基准价格</para>
            /// </summary>
            [NameInMap("business_standard_price")]
            [Validation(Required=false)]
            public int? BusinessStandardPrice { get; set; }

            /// <summary>
            /// <para>The economy class base price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>242000</para>
            /// </summary>
            [NameInMap("common_standard_price")]
            [Validation(Required=false)]
            public int? CommonStandardPrice { get; set; }

            /// <summary>
            /// <para>The fdPrice.</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fdPrice</para>
            /// </summary>
            [NameInMap("inter_ticket_price")]
            [Validation(Required=false)]
            public int? InterTicketPrice { get; set; }

            /// <summary>
            /// <para>The amount deducted from the segment for round-trip direct deduction.</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>直减往返，航段上减去的钱</para>
            /// </summary>
            [NameInMap("subtracted_price")]
            [Validation(Required=false)]
            public int? SubtractedPrice { get; set; }

            /// <summary>
            /// <para>The pre-discount price (multi-price per cabin) [dynamic discount].</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>优惠前价格（一舱多价）[动态优惠专用]</para>
            /// </summary>
            [NameInMap("origin_common_price")]
            [Validation(Required=false)]
            public int? OriginCommonPrice { get; set; }

            /// <summary>
            /// <para>The post-dynamic-discount price [dynamic discount].</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>动态优惠后的价格 [动态优惠专用]</para>
            /// </summary>
            [NameInMap("dynamic_promotion_price")]
            [Validation(Required=false)]
            public int? DynamicPromotionPrice { get; set; }

            /// <summary>
            /// <para>The installment count.</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>分期数</para>
            /// </summary>
            [NameInMap("installment_num")]
            [Validation(Required=false)]
            public int? InstallmentNum { get; set; }

            /// <summary>
            /// <para>The installment price per period.</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>分期每期价格</para>
            /// </summary>
            [NameInMap("installment_price")]
            [Validation(Required=false)]
            public double? InstallmentPrice { get; set; }

            /// <summary>
            /// <para>The target price after competitor dynamic subsidy.</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>竞品动态补贴后的目标价格</para>
            /// </summary>
            [NameInMap("competition_dynamic_price")]
            [Validation(Required=false)]
            public int? CompetitionDynamicPrice { get; set; }

            /// <summary>
            /// <para>The discount from competitor dynamic subsidy.</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>竞品动态补贴，可减的优惠</para>
            /// </summary>
            [NameInMap("competition_promotion_price")]
            [Validation(Required=false)]
            public int? CompetitionPromotionPrice { get; set; }

            /// <summary>
            /// <para>The lowest pre-control price for normal quotes of the current flight combination.</para>
            /// <remarks>
            /// <para>Warning: Deprecated</warning></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>17400</para>
            /// </summary>
            [NameInMap("min_before_control_price_of_normal")]
            [Validation(Required=false)]
            public int? MinBeforeControlPriceOfNormal { get; set; }

            /// <summary>
            /// <para>The price display information.</para>
            /// </summary>
            [NameInMap("price_show_info")]
            [Validation(Required=false)]
            public ModuleFlightItemListBestPriceItemShoppingItemMapValueSearchPricePriceShowInfo PriceShowInfo { get; set; }
            public class ModuleFlightItemListBestPriceItemShoppingItemMapValueSearchPricePriceShowInfo : TeaModel {
                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8折</para>
                /// </summary>
                [NameInMap("discount_info")]
                [Validation(Required=false)]
                public string DiscountInfo { get; set; }

                /// <summary>
                /// <para>The discount value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("discount_num")]
                [Validation(Required=false)]
                public double? DiscountNum { get; set; }

                /// <summary>
                /// <para>Indicates whether to display the face value price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("show_ticket_price")]
                [Validation(Required=false)]
                public bool? ShowTicketPrice { get; set; }

            }

        }

        /// <summary>
        /// <para>The price for each segment. This may not have a value if the airline bundles the product without splitting prices by segment.</para>
        /// </summary>
        [NameInMap("segment_price_list")]
        [Validation(Required=false)]
        public List<ModuleFlightItemListBestPriceItemShoppingItemMapValueSegmentPriceList> SegmentPriceList { get; set; }
        public class ModuleFlightItemListBestPriceItemShoppingItemMapValueSegmentPriceList : TeaModel {
            /// <summary>
            /// <para>The segment position index.</para>
            /// </summary>
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleFlightItemListBestPriceItemShoppingItemMapValueSegmentPriceListSegmentPosition SegmentPosition { get; set; }
            public class ModuleFlightItemListBestPriceItemShoppingItemMapValueSegmentPriceListSegmentPosition : TeaModel {
                /// <summary>
                /// <para>The journey index (starting from 0).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The segment index (starting from 0 within the same journey).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

            }

            /// <summary>
            /// <para>The search price object.</para>
            /// </summary>
            [NameInMap("search_price")]
            [Validation(Required=false)]
            public ModuleFlightItemListBestPriceItemShoppingItemMapValueSegmentPriceListSearchPrice SearchPrice { get; set; }
            public class ModuleFlightItemListBestPriceItemShoppingItemMapValueSegmentPriceListSearchPrice : TeaModel {
                /// <summary>
                /// <para>The selling price, which equals the ticket price plus tax. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>126000</para>
                /// </summary>
                [NameInMap("sell_price")]
                [Validation(Required=false)]
                public int? SellPrice { get; set; }

                /// <summary>
                /// <para>The ticket selling price (excluding tax). Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120000</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public int? TicketPrice { get; set; }

                /// <summary>
                /// <para>The reference tax. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6000</para>
                /// </summary>
                [NameInMap("tax")]
                [Validation(Required=false)]
                public int? Tax { get; set; }

            }

        }

        /// <summary>
        /// <para>id</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADT07df0bd9-f803-4a50-8449-f4bd675d9939</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The cabin remaining inventory per segment, keyed by ((journeyIndex, segmentIndex), Cabin).</para>
        /// </summary>
        [NameInMap("cabin_quantity")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleFlightItemListBestPriceItemShoppingItemMapValueCabinQuantityValue> CabinQuantity { get; set; }

        /// <summary>
        /// <para>The price per segment.</para>
        /// <remarks>
        /// <para>Warning: Deprecated</warning></para>
        /// </remarks>
        /// </summary>
        [NameInMap("segment_price")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleFlightItemListBestPriceItemShoppingItemMapValueSegmentPriceValue> SegmentPrice { get; set; }

    }

}
