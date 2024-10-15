// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleGroupItemShoppingItemMapValue : TeaModel {
        [NameInMap("cabin_quantity_list")]
        [Validation(Required=false)]
        public List<ModuleGroupItemShoppingItemMapValueCabinQuantityList> CabinQuantityList { get; set; }
        public class ModuleGroupItemShoppingItemMapValueCabinQuantityList : TeaModel {
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleGroupItemShoppingItemMapValueCabinQuantityListSegmentPosition SegmentPosition { get; set; }
            public class ModuleGroupItemShoppingItemMapValueCabinQuantityListSegmentPosition : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

            }

            [NameInMap("cabin")]
            [Validation(Required=false)]
            public ModuleGroupItemShoppingItemMapValueCabinQuantityListCabin Cabin { get; set; }
            public class ModuleGroupItemShoppingItemMapValueCabinQuantityListCabin : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                [NameInMap("cabin_class_name")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public string Quantity { get; set; }

            }

        }

        [NameInMap("search_price")]
        [Validation(Required=false)]
        public ModuleGroupItemShoppingItemMapValueSearchPrice SearchPrice { get; set; }
        public class ModuleGroupItemShoppingItemMapValueSearchPrice : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("ticket_price")]
            [Validation(Required=false)]
            public int? TicketPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("sell_price")]
            [Validation(Required=false)]
            public int? SellPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6000</para>
            /// </summary>
            [NameInMap("tax")]
            [Validation(Required=false)]
            public int? Tax { get; set; }

        }

        [NameInMap("segment_price_list")]
        [Validation(Required=false)]
        public List<ModuleGroupItemShoppingItemMapValueSegmentPriceList> SegmentPriceList { get; set; }
        public class ModuleGroupItemShoppingItemMapValueSegmentPriceList : TeaModel {
            [NameInMap("segment_position")]
            [Validation(Required=false)]
            public ModuleGroupItemShoppingItemMapValueSegmentPriceListSegmentPosition SegmentPosition { get; set; }
            public class ModuleGroupItemShoppingItemMapValueSegmentPriceListSegmentPosition : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

            }

            [NameInMap("search_price")]
            [Validation(Required=false)]
            public ModuleGroupItemShoppingItemMapValueSegmentPriceListSearchPrice SearchPrice { get; set; }
            public class ModuleGroupItemShoppingItemMapValueSegmentPriceListSearchPrice : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>120000</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public int? TicketPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>120000</para>
                /// </summary>
                [NameInMap("sell_price")]
                [Validation(Required=false)]
                public int? SellPrice { get; set; }

                /// <summary>
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
