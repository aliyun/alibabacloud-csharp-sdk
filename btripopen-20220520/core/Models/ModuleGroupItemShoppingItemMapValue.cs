// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleGroupItemShoppingItemMapValue : TeaModel {
        /// <summary>
        /// <para>The cabin remaining inventory per segment.</para>
        /// </summary>
        [NameInMap("cabin_quantity_list")]
        [Validation(Required=false)]
        public List<ModuleGroupItemShoppingItemMapValueCabinQuantityList> CabinQuantityList { get; set; }
        public class ModuleGroupItemShoppingItemMapValueCabinQuantityList : TeaModel {
            /// <summary>
            /// <para>The journey information that identifies which journey and which segment.</para>
            /// </summary>
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleGroupItemShoppingItemMapValueCabinQuantityListSegmentPosition SegmentPosition { get; set; }
            public class ModuleGroupItemShoppingItemMapValueCabinQuantityListSegmentPosition : TeaModel {
                /// <summary>
                /// <para>The journey ordinal number, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The segment ordinal number, starting from 0 within the same journey.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

            }

            /// <summary>
            /// <para>The cabin information.</para>
            /// </summary>
            [NameInMap("cabin")]
            [Validation(Required=false)]
            public ModuleGroupItemShoppingItemMapValueCabinQuantityListCabin Cabin { get; set; }
            public class ModuleGroupItemShoppingItemMapValueCabinQuantityListCabin : TeaModel {
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
                /// <para>The cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class name. If a custom name exists, the custom name is displayed. Otherwise, the generic name is displayed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_class_name")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                /// <summary>
                /// <para>The number of remaining seats in the cabin.</para>
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
        /// <para>The price provided by the search.</para>
        /// </summary>
        [NameInMap("search_price")]
        [Validation(Required=false)]
        public ModuleGroupItemShoppingItemMapValueSearchPrice SearchPrice { get; set; }
        public class ModuleGroupItemShoppingItemMapValueSearchPrice : TeaModel {
            /// <summary>
            /// <para>The face value price in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("ticket_price")]
            [Validation(Required=false)]
            public int? TicketPrice { get; set; }

            /// <summary>
            /// <para>The selling price in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("sell_price")]
            [Validation(Required=false)]
            public int? SellPrice { get; set; }

            /// <summary>
            /// <para>The reference tax in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6000</para>
            /// </summary>
            [NameInMap("tax")]
            [Validation(Required=false)]
            public int? Tax { get; set; }

        }

        /// <summary>
        /// <para>The price for each segment. This field may not have a value because airline bundled products may not have prices split by segment.</para>
        /// </summary>
        [NameInMap("segment_price_list")]
        [Validation(Required=false)]
        public List<ModuleGroupItemShoppingItemMapValueSegmentPriceList> SegmentPriceList { get; set; }
        public class ModuleGroupItemShoppingItemMapValueSegmentPriceList : TeaModel {
            /// <summary>
            /// <para>The journey information that identifies which journey and which segment.</para>
            /// </summary>
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleGroupItemShoppingItemMapValueSegmentPriceListSegmentPosition SegmentPosition { get; set; }
            public class ModuleGroupItemShoppingItemMapValueSegmentPriceListSegmentPosition : TeaModel {
                /// <summary>
                /// <para>The journey ordinal number, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The segment ordinal number, starting from 0 within the same journey.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

            }

            /// <summary>
            /// <para>The price information.</para>
            /// </summary>
            [NameInMap("search_price")]
            [Validation(Required=false)]
            public ModuleGroupItemShoppingItemMapValueSegmentPriceListSearchPrice SearchPrice { get; set; }
            public class ModuleGroupItemShoppingItemMapValueSegmentPriceListSearchPrice : TeaModel {
                /// <summary>
                /// <para>The face value price in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120000</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public int? TicketPrice { get; set; }

                /// <summary>
                /// <para>The selling price in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120000</para>
                /// </summary>
                [NameInMap("sell_price")]
                [Validation(Required=false)]
                public int? SellPrice { get; set; }

                /// <summary>
                /// <para>The reference tax in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6000</para>
                /// </summary>
                [NameInMap("tax")]
                [Validation(Required=false)]
                public int? Tax { get; set; }

            }

        }

    }

}
