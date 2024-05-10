// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderPreValidateShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("daily_list")]
        [Validation(Required=false)]
        public string DailyListShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("item_id")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        [NameInMap("number_of_adults_per_room")]
        [Validation(Required=false)]
        public int? NumberOfAdultsPerRoom { get; set; }

        [NameInMap("occupant_info_list")]
        [Validation(Required=false)]
        public string OccupantInfoListShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("rate_plan_id")]
        [Validation(Required=false)]
        public long? RatePlanId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("room_id")]
        [Validation(Required=false)]
        public long? RoomId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("room_num")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("search_room_price")]
        [Validation(Required=false)]
        public long? SearchRoomPrice { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("seller_id")]
        [Validation(Required=false)]
        public long? SellerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("shid")]
        [Validation(Required=false)]
        public long? Shid { get; set; }

    }

}
