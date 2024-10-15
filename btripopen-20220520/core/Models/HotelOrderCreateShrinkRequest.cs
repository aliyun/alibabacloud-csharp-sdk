// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderCreateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123122</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-20</para>
        /// </summary>
        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-20</para>
        /// </summary>
        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("contract_email")]
        [Validation(Required=false)]
        public string ContractEmail { get; set; }

        [NameInMap("contract_name")]
        [Validation(Required=false)]
        public string ContractName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19281772123</para>
        /// </summary>
        [NameInMap("contract_phone")]
        [Validation(Required=false)]
        public string ContractPhone { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("corp_pay_price")]
        [Validation(Required=false)]
        public long? CorpPayPrice { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("invoice_info")]
        [Validation(Required=false)]
        public string InvoiceInfoShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>671570615157</para>
        /// </summary>
        [NameInMap("item_id")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb5e1abf33924b6c912bd6d80deec0eb-1</para>
        /// </summary>
        [NameInMap("itinerary_no")]
        [Validation(Required=false)]
        public string ItineraryNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("occupant_info_list")]
        [Validation(Required=false)]
        public string OccupantInfoListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("person_pay_price")]
        [Validation(Required=false)]
        public long? PersonPayPrice { get; set; }

        [NameInMap("promotion_info")]
        [Validation(Required=false)]
        public string PromotionInfoShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1399417428510</para>
        /// </summary>
        [NameInMap("rate_plan_id")]
        [Validation(Required=false)]
        public long? RatePlanId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187211</para>
        /// </summary>
        [NameInMap("room_id")]
        [Validation(Required=false)]
        public long? RoomId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("room_num")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2088441675613762</para>
        /// </summary>
        [NameInMap("seller_id")]
        [Validation(Required=false)]
        public long? SellerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2198781</para>
        /// </summary>
        [NameInMap("shid")]
        [Validation(Required=false)]
        public long? Shid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total_order_price")]
        [Validation(Required=false)]
        public long? TotalOrderPrice { get; set; }

        /// <summary>
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
