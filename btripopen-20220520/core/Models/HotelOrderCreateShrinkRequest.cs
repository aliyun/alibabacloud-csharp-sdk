// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderCreateShrinkRequest : TeaModel {
        [NameInMap("arrival_time")]
        [Validation(Required=false)]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// <para>The external user ID. If organization personnel synchronization is enabled, use the btripUserId. Otherwise, pass the userId corresponding to the distributor\&quot;s own system user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123122</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The check-in date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-20 00:00:00</para>
        /// </summary>
        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        /// <summary>
        /// <para>The check-out date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-20 00:00:00</para>
        /// </summary>
        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        /// <summary>
        /// <para>The contact person\&quot;s email address. This parameter is required if the need_email parameter returned by the pre-order validation operation is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("contract_email")]
        [Validation(Required=false)]
        public string ContractEmail { get; set; }

        /// <summary>
        /// <para>The contact person\&quot;s name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("contract_name")]
        [Validation(Required=false)]
        public string ContractName { get; set; }

        /// <summary>
        /// <para>The contact person\&quot;s mobile phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>131****8888</para>
        /// </summary>
        [NameInMap("contract_phone")]
        [Validation(Required=false)]
        public string ContractPhone { get; set; }

        /// <summary>
        /// <para>The corporate payment amount. Unit: cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("corp_pay_price")]
        [Validation(Required=false)]
        public long? CorpPayPrice { get; set; }

        /// <summary>
        /// <para>The distributor order ID. Regardless of whether the order is created successfully, the distributor order ID is recorded. Do not use the same order ID to place orders multiple times.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>The extended information in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>（特定企业需要传递）
        /// 1.企业支付金额：DisCorpPayPrice
        /// 2.个人支付金额：
        /// DisPersonPayPrice</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>The invoice information.</para>
        /// </summary>
        [NameInMap("invoice_info")]
        [Validation(Required=false)]
        public string InvoiceInfoShrink { get; set; }

        /// <summary>
        /// <para>The item ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>671570615157</para>
        /// </summary>
        [NameInMap("item_id")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        /// <summary>
        /// <para>The btrip itinerary ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb5e1abf33924b6c912bd6d80deec0eb-1</para>
        /// </summary>
        [NameInMap("itinerary_no")]
        [Validation(Required=false)]
        public string ItineraryNo { get; set; }

        [NameInMap("leave_time")]
        [Validation(Required=false)]
        public string LeaveTime { get; set; }

        /// <summary>
        /// <para>The GDS membership card information.</para>
        /// </summary>
        [NameInMap("member_info")]
        [Validation(Required=false)]
        public string MemberInfoShrink { get; set; }

        /// <summary>
        /// <para>The occupant information. The number of occupants cannot exceed the number specified during price validation. A maximum of two occupants are allowed per room.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("occupant_info_list")]
        [Validation(Required=false)]
        public string OccupantInfoListShrink { get; set; }

        /// <summary>
        /// <para>The personal payment amount. Unit: cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("person_pay_price")]
        [Validation(Required=false)]
        public long? PersonPayPrice { get; set; }

        /// <summary>
        /// <para>The promotion information.</para>
        /// </summary>
        [NameInMap("promotion_info")]
        [Validation(Required=false)]
        public string PromotionInfoShrink { get; set; }

        /// <summary>
        /// <para>The rate plan ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1399417428510</para>
        /// </summary>
        [NameInMap("rate_plan_id")]
        [Validation(Required=false)]
        public long? RatePlanId { get; set; }

        /// <summary>
        /// <para>The room ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187211</para>
        /// </summary>
        [NameInMap("room_id")]
        [Validation(Required=false)]
        public long? RoomId { get; set; }

        /// <summary>
        /// <para>The number of rooms.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("room_num")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        [NameInMap("rp_type")]
        [Validation(Required=false)]
        public int? RpType { get; set; }

        /// <summary>
        /// <para>The seller ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2088441675613762</para>
        /// </summary>
        [NameInMap("seller_id")]
        [Validation(Required=false)]
        public long? SellerId { get; set; }

        /// <summary>
        /// <para>The standard hotel ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2198781</para>
        /// </summary>
        [NameInMap("shid")]
        [Validation(Required=false)]
        public long? Shid { get; set; }

        /// <summary>
        /// <para>The total order price. Unit: cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total_order_price")]
        [Validation(Required=false)]
        public long? TotalOrderPrice { get; set; }

        /// <summary>
        /// <para>The validation result.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nonUltron_1673575241156_d91ea8ad16735752359161037bf6cf_c54d3768312a4b249b719f126377bf82</para>
        /// </summary>
        [NameInMap("validate_res_key")]
        [Validation(Required=false)]
        public string ValidateResKey { get; set; }

    }

}
