// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderPreValidateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The external user ID. If organization personnel synchronization is enabled, use btripUserId. Otherwise, pass the userId corresponding to the distributor\&quot;s own system user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23141</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The check-in date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-15 00:00:00</para>
        /// </summary>
        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        /// <summary>
        /// <para>The check-out date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-15 00:00:00</para>
        /// </summary>
        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        /// <summary>
        /// <para>The daily prices.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("daily_list")]
        [Validation(Required=false)]
        public string DailyListShrink { get; set; }

        /// <summary>
        /// <para>The item ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>612673015638</para>
        /// </summary>
        [NameInMap("item_id")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        /// <summary>
        /// <para>The number of adults per room. The number must be consistent with the number specified when placing the order, or must not be less than the number specified when creating the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("number_of_adults_per_room")]
        [Validation(Required=false)]
        public int? NumberOfAdultsPerRoom { get; set; }

        /// <summary>
        /// <para>The occupant information.</para>
        /// </summary>
        [NameInMap("occupant_info_list")]
        [Validation(Required=false)]
        public string OccupantInfoListShrink { get; set; }

        /// <summary>
        /// <para>The rate key identifier for non-persisted items.</para>
        /// </summary>
        [NameInMap("rate_key")]
        [Validation(Required=false)]
        public string RateKey { get; set; }

        /// <summary>
        /// <para>The rp_Id passed through from the rate query API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239872781</para>
        /// </summary>
        [NameInMap("rate_plan_id")]
        [Validation(Required=false)]
        public long? RatePlanId { get; set; }

        /// <summary>
        /// <para>The room ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71652158</para>
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

        /// <summary>
        /// <para>The room type, which distinguishes between full-day rooms and hourly rooms. If not specified, the default is full-day room. Valid values: 0: full-day room. 1: hourly room.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("rp_type")]
        [Validation(Required=false)]
        public int? RpType { get; set; }

        /// <summary>
        /// <para>The total room price passed through from the rate query API, in cents. For multiple room nights, pass in the sum of last_discounts_price for each room night multiplied by the number of rooms.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("search_room_price")]
        [Validation(Required=false)]
        public long? SearchRoomPrice { get; set; }

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
        /// <para>52302073</para>
        /// </summary>
        [NameInMap("shid")]
        [Validation(Required=false)]
        public long? Shid { get; set; }

    }

}
