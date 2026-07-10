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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        [NameInMap("contract_email")]
        [Validation(Required=false)]
        public string ContractEmail { get; set; }

        [NameInMap("contract_name")]
        [Validation(Required=false)]
        public string ContractName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contract_phone")]
        [Validation(Required=false)]
        public string ContractPhone { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corp_pay_price")]
        [Validation(Required=false)]
        public long? CorpPayPrice { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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
        /// </summary>
        [NameInMap("item_id")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("itinerary_no")]
        [Validation(Required=false)]
        public string ItineraryNo { get; set; }

        [NameInMap("leave_time")]
        [Validation(Required=false)]
        public string LeaveTime { get; set; }

        [NameInMap("member_info")]
        [Validation(Required=false)]
        public string MemberInfoShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("occupant_info_list")]
        [Validation(Required=false)]
        public string OccupantInfoListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("person_pay_price")]
        [Validation(Required=false)]
        public long? PersonPayPrice { get; set; }

        [NameInMap("promotion_info")]
        [Validation(Required=false)]
        public string PromotionInfoShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("rate_plan_id")]
        [Validation(Required=false)]
        public long? RatePlanId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("room_id")]
        [Validation(Required=false)]
        public long? RoomId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("room_num")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        [NameInMap("rp_type")]
        [Validation(Required=false)]
        public int? RpType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("seller_id")]
        [Validation(Required=false)]
        public long? SellerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("shid")]
        [Validation(Required=false)]
        public long? Shid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("total_order_price")]
        [Validation(Required=false)]
        public long? TotalOrderPrice { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("validate_res_key")]
        [Validation(Required=false)]
        public string ValidateResKey { get; set; }

    }

}
