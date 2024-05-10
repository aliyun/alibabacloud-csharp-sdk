// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderPreValidateRequest : TeaModel {
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
        public List<HotelOrderPreValidateRequestDailyList> DailyList { get; set; }
        public class HotelOrderPreValidateRequestDailyList : TeaModel {
            [NameInMap("board")]
            [Validation(Required=false)]
            public string Board { get; set; }

            [NameInMap("price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("rate_start_time")]
            [Validation(Required=false)]
            public string RateStartTime { get; set; }

            [NameInMap("room_count")]
            [Validation(Required=false)]
            public int? RoomCount { get; set; }

        }

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
        public List<HotelOrderPreValidateRequestOccupantInfoList> OccupantInfoList { get; set; }
        public class HotelOrderPreValidateRequestOccupantInfoList : TeaModel {
            [NameInMap("card_no")]
            [Validation(Required=false)]
            public string CardNo { get; set; }

            [NameInMap("card_type")]
            [Validation(Required=false)]
            public int? CardType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("staff_no")]
            [Validation(Required=false)]
            public string StaffNo { get; set; }

            [NameInMap("user_type")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

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
