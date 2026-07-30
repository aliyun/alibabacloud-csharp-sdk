// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleFlightItemListBestPriceItemSubItemsShoppingItemMapValueSegmentPriceValue : TeaModel {
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
        /// <para>The ticket face price (unit: cents).</para>
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
        /// <para>The original selling price, the price before promotion (unit: cents).</para>
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
        /// <para>The supplier\&quot;s selling price for procurement products.</para>
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
        /// <para>The direct discount for round-trip, amount deducted per segment.</para>
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
        /// <para>The pre-discount price (multi-price per cabin) [dynamic discount exclusive].</para>
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
        /// <para>The price after dynamic discount [dynamic discount exclusive].</para>
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
        /// <para>The number of installments.</para>
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
        /// <para>The target price after competitive dynamic subsidy.</para>
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
        /// <para>The competitive dynamic subsidy, deductible discount.</para>
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
        /// <para>The lowest price before price control for normal quotes of the current flight combination.</para>
        /// <remarks>
        /// <para>Warning: Deprecated</warning></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>当前航班组合普通报价限价前最低价格</para>
        /// </summary>
        [NameInMap("min_before_control_price_of_normal")]
        [Validation(Required=false)]
        public int? MinBeforeControlPriceOfNormal { get; set; }

        /// <summary>
        /// <para>The price display information.</para>
        /// </summary>
        [NameInMap("price_show_info")]
        [Validation(Required=false)]
        public ModuleFlightItemListBestPriceItemSubItemsShoppingItemMapValueSegmentPriceValuePriceShowInfo PriceShowInfo { get; set; }
        public class ModuleFlightItemListBestPriceItemSubItemsShoppingItemMapValueSegmentPriceValuePriceShowInfo : TeaModel {
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
            /// <para>Indicates whether to display the ticket face price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("show_ticket_price")]
            [Validation(Required=false)]
            public bool? ShowTicketPrice { get; set; }

        }

    }

}
