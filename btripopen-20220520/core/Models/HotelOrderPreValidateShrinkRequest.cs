// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderPreValidateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23141</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-15</para>
        /// </summary>
        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-15</para>
        /// </summary>
        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("daily_list")]
        [Validation(Required=false)]
        public string DailyListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>612673015638</para>
        /// </summary>
        [NameInMap("item_id")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("number_of_adults_per_room")]
        [Validation(Required=false)]
        public int? NumberOfAdultsPerRoom { get; set; }

        [NameInMap("occupant_info_list")]
        [Validation(Required=false)]
        public string OccupantInfoListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239872781</para>
        /// </summary>
        [NameInMap("rate_plan_id")]
        [Validation(Required=false)]
        public long? RatePlanId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71652158</para>
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
        /// <para>1000</para>
        /// </summary>
        [NameInMap("search_room_price")]
        [Validation(Required=false)]
        public long? SearchRoomPrice { get; set; }

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
        /// <para>52302073</para>
        /// </summary>
        [NameInMap("shid")]
        [Validation(Required=false)]
        public long? Shid { get; set; }

    }

}
