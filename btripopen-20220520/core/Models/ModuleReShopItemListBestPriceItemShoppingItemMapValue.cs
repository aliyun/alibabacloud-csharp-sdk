// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleReShopItemListBestPriceItemShoppingItemMapValue : TeaModel {
        /// <summary>
        /// <para>The remaining cabin inventory for each segment.</para>
        /// </summary>
        [NameInMap("cabin_quantity_list")]
        [Validation(Required=false)]
        public List<ModuleReShopItemListBestPriceItemShoppingItemMapValueCabinQuantityList> CabinQuantityList { get; set; }
        public class ModuleReShopItemListBestPriceItemShoppingItemMapValueCabinQuantityList : TeaModel {
            /// <summary>
            /// <para>The segment position information, indicating the journey index and segment index within the overall itinerary.</para>
            /// </summary>
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleReShopItemListBestPriceItemShoppingItemMapValueCabinQuantityListSegmentPosition SegmentPosition { get; set; }
            public class ModuleReShopItemListBestPriceItemShoppingItemMapValueCabinQuantityListSegmentPosition : TeaModel {
                /// <summary>
                /// <para>The journey ordinal number (starting from 0).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The segment ordinal number (starting from 0 within the same journey).</para>
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
            public ModuleReShopItemListBestPriceItemShoppingItemMapValueCabinQuantityListCabinInfo CabinInfo { get; set; }
            public class ModuleReShopItemListBestPriceItemShoppingItemMapValueCabinQuantityListCabinInfo : TeaModel {
                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>F: first class.</description></item>
                /// <item><description>C: business class.</description></item>
                /// <item><description>Y: economy class.</description></item>
                /// <item><description>P: premium economy class.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class name. Displays the custom name if available. Otherwise, displays the standard name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_class_name")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                /// <summary>
                /// <para>The number of remaining seats in the cabin. Valid values: 0-9 indicates 0 to 9 remaining seats. A indicates more than 9 seats.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public string Quantity { get; set; }

                /// <summary>
                /// <para>The cabin class description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_class_memo")]
                [Validation(Required=false)]
                public string CabinClassMemo { get; set; }

                /// <summary>
                /// <para>The domestic special notes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

            }

        }

        /// <summary>
        /// <para>The rebooking search price.</para>
        /// </summary>
        [NameInMap("search_price")]
        [Validation(Required=false)]
        public ModuleReShopItemListBestPriceItemShoppingItemMapValueSearchPrice SearchPrice { get; set; }
        public class ModuleReShopItemListBestPriceItemShoppingItemMapValueSearchPrice : TeaModel {
            /// <summary>
            /// <para>The total amount in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("total_amount")]
            [Validation(Required=false)]
            public long? TotalAmount { get; set; }

            /// <summary>
            /// <para>The service fee amount, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("handling_amount")]
            [Validation(Required=false)]
            public long? HandlingAmount { get; set; }

            /// <summary>
            /// <para>The cabin upgrade fee amount in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("upgrade_amount")]
            [Validation(Required=false)]
            public long? UpgradeAmount { get; set; }

            /// <summary>
            /// <para>The tax difference amount in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("tax_diff_amount")]
            [Validation(Required=false)]
            public long? TaxDiffAmount { get; set; }

            /// <summary>
            /// <para>Indicates whether a direct price is available. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("has_price")]
            [Validation(Required=false)]
            public bool? HasPrice { get; set; }

            /// <summary>
            /// <para>The text prompt displayed when no direct price is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>待服务商确认</para>
            /// </summary>
            [NameInMap("non_price_text")]
            [Validation(Required=false)]
            public string NonPriceText { get; set; }

        }

        /// <summary>
        /// <para>The price for each segment. This value may not be available because airline bundled products may not have prices broken down by segment.</para>
        /// </summary>
        [NameInMap("segment_price_list")]
        [Validation(Required=false)]
        public List<ModuleReShopItemListBestPriceItemShoppingItemMapValueSegmentPriceList> SegmentPriceList { get; set; }
        public class ModuleReShopItemListBestPriceItemShoppingItemMapValueSegmentPriceList : TeaModel {
            /// <summary>
            /// <para>The segment position information, indicating the journey index and segment index within the overall itinerary.</para>
            /// </summary>
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleReShopItemListBestPriceItemShoppingItemMapValueSegmentPriceListSegmentPosition SegmentPosition { get; set; }
            public class ModuleReShopItemListBestPriceItemShoppingItemMapValueSegmentPriceListSegmentPosition : TeaModel {
                /// <summary>
                /// <para>The journey ordinal number (starting from 0).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The segment ordinal number (starting from 0 within the same journey).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

            }

            /// <summary>
            /// <para>The rebooking price.</para>
            /// </summary>
            [NameInMap("search_price")]
            [Validation(Required=false)]
            public ModuleReShopItemListBestPriceItemShoppingItemMapValueSegmentPriceListSearchPrice SearchPrice { get; set; }
            public class ModuleReShopItemListBestPriceItemShoppingItemMapValueSegmentPriceListSearchPrice : TeaModel {
                /// <summary>
                /// <para>The total amount in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("total_amount")]
                [Validation(Required=false)]
                public long? TotalAmount { get; set; }

                /// <summary>
                /// <para>The service fee amount, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("handling_amount")]
                [Validation(Required=false)]
                public long? HandlingAmount { get; set; }

                /// <summary>
                /// <para>The cabin upgrade fee amount in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("upgrade_amount")]
                [Validation(Required=false)]
                public long? UpgradeAmount { get; set; }

                /// <summary>
                /// <para>The tax difference amount in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("tax_diff_amount")]
                [Validation(Required=false)]
                public long? TaxDiffAmount { get; set; }

                /// <summary>
                /// <para>Indicates whether a direct price is available. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("has_price")]
                [Validation(Required=false)]
                public bool? HasPrice { get; set; }

                /// <summary>
                /// <para>The text prompt displayed when no direct price is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>待服务商确认</para>
                /// </summary>
                [NameInMap("non_price_text")]
                [Validation(Required=false)]
                public string NonPriceText { get; set; }

            }

        }

    }

}
