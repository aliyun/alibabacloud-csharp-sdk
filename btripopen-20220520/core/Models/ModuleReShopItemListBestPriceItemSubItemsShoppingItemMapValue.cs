// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValue : TeaModel {
        /// <summary>
        /// <para>The cabin remaining inventory per segment.</para>
        /// </summary>
        [NameInMap("cabin_quantity_list")]
        [Validation(Required=false)]
        public List<ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueCabinQuantityList> CabinQuantityList { get; set; }
        public class ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueCabinQuantityList : TeaModel {
            /// <summary>
            /// <para>The segment position information, indicating the journey index and segment index within the overall itinerary.</para>
            /// </summary>
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueCabinQuantityListSegmentPosition SegmentPosition { get; set; }
            public class ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueCabinQuantityListSegmentPosition : TeaModel {
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
            public ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueCabinQuantityListCabinInfo CabinInfo { get; set; }
            public class ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueCabinQuantityListCabinInfo : TeaModel {
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
                /// <para>The cabin class. Valid values: F: first class. C: business class. Y: economy class. P: premium economy class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_class_name")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                /// <summary>
                /// <para>The number of remaining seats in the cabin. 0-9: 0 to 9 seats remaining. A: more than 9 seats remaining.</para>
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
        public ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueSearchPrice SearchPrice { get; set; }
        public class ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueSearchPrice : TeaModel {
            /// <summary>
            /// <para>The total amount, in cents.</para>
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
            /// <para>The cabin upgrade fee amount, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("upgrade_amount")]
            [Validation(Required=false)]
            public long? UpgradeAmount { get; set; }

            /// <summary>
            /// <para>The tax difference amount, in cents.</para>
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
            /// <para>true</para>
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
        /// <para>The price per segment. This field may not have a value because airline bundled products may not have prices split by segment.</para>
        /// </summary>
        [NameInMap("segment_price_list")]
        [Validation(Required=false)]
        public List<ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueSegmentPriceList> SegmentPriceList { get; set; }
        public class ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueSegmentPriceList : TeaModel {
            /// <summary>
            /// <para>The segment position information, indicating the journey index and segment index within the overall itinerary.</para>
            /// </summary>
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueSegmentPriceListSegmentPosition SegmentPosition { get; set; }
            public class ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueSegmentPriceListSegmentPosition : TeaModel {
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
            public ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueSegmentPriceListSearchPrice SearchPrice { get; set; }
            public class ModuleReShopItemListBestPriceItemSubItemsShoppingItemMapValueSegmentPriceListSearchPrice : TeaModel {
                /// <summary>
                /// <para>The total amount, in cents.</para>
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
                /// <para>The cabin upgrade fee amount, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("upgrade_amount")]
                [Validation(Required=false)]
                public long? UpgradeAmount { get; set; }

                /// <summary>
                /// <para>The tax difference amount, in cents.</para>
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
                /// <para>true</para>
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
