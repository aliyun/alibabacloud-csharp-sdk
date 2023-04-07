// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderPreValidateShrinkRequest : TeaModel {
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        [NameInMap("daily_list")]
        [Validation(Required=false)]
        public string DailyListShrink { get; set; }

        [NameInMap("item_id")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        [NameInMap("number_of_adults_per_room")]
        [Validation(Required=false)]
        public int? NumberOfAdultsPerRoom { get; set; }

        [NameInMap("occupant_info_list")]
        [Validation(Required=false)]
        public string OccupantInfoListShrink { get; set; }

        [NameInMap("rate_plan_id")]
        [Validation(Required=false)]
        public long? RatePlanId { get; set; }

        [NameInMap("room_id")]
        [Validation(Required=false)]
        public long? RoomId { get; set; }

        [NameInMap("room_num")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        [NameInMap("search_room_price")]
        [Validation(Required=false)]
        public long? SearchRoomPrice { get; set; }

        [NameInMap("seller_id")]
        [Validation(Required=false)]
        public long? SellerId { get; set; }

        [NameInMap("shid")]
        [Validation(Required=false)]
        public long? Shid { get; set; }

    }

}
