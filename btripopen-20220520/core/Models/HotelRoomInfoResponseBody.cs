// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelRoomInfoResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<HotelRoomInfoResponseBodyModule> Module { get; set; }
        public class HotelRoomInfoResponseBodyModule : TeaModel {
            [NameInMap("bed_infos")]
            [Validation(Required=false)]
            public List<HotelRoomInfoResponseBodyModuleBedInfos> BedInfos { get; set; }
            public class HotelRoomInfoResponseBodyModuleBedInfos : TeaModel {
                [NameInMap("bed_desc")]
                [Validation(Required=false)]
                public string BedDesc { get; set; }

                [NameInMap("bed_num")]
                [Validation(Required=false)]
                public int? BedNum { get; set; }

                [NameInMap("bed_size")]
                [Validation(Required=false)]
                public string BedSize { get; set; }

                [NameInMap("bed_type")]
                [Validation(Required=false)]
                public string BedType { get; set; }

            }

            [NameInMap("extra_bed")]
            [Validation(Required=false)]
            public int? ExtraBed { get; set; }

            [NameInMap("extra_bed_desc")]
            [Validation(Required=false)]
            public string ExtraBedDesc { get; set; }

            [NameInMap("floor")]
            [Validation(Required=false)]
            public string Floor { get; set; }

            [NameInMap("internet_way")]
            [Validation(Required=false)]
            public string InternetWay { get; set; }

            [NameInMap("max_occupancy")]
            [Validation(Required=false)]
            public int? MaxOccupancy { get; set; }

            [NameInMap("room_desc")]
            [Validation(Required=false)]
            public string RoomDesc { get; set; }

            [NameInMap("room_facilities")]
            [Validation(Required=false)]
            public string RoomFacilities { get; set; }

            [NameInMap("room_facility_list")]
            [Validation(Required=false)]
            public List<string> RoomFacilityList { get; set; }

            [NameInMap("room_id")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("room_image")]
            [Validation(Required=false)]
            public string RoomImage { get; set; }

            [NameInMap("room_images")]
            [Validation(Required=false)]
            public List<HotelRoomInfoResponseBodyModuleRoomImages> RoomImages { get; set; }
            public class HotelRoomInfoResponseBodyModuleRoomImages : TeaModel {
                [NameInMap("bed_infos2")]
                [Validation(Required=false)]
                public string BedInfos2 { get; set; }

                [NameInMap("tag")]
                [Validation(Required=false)]
                public int? Tag { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("room_name")]
            [Validation(Required=false)]
            public string RoomName { get; set; }

            [NameInMap("room_type")]
            [Validation(Required=false)]
            public int? RoomType { get; set; }

            [NameInMap("roomarea")]
            [Validation(Required=false)]
            public string Roomarea { get; set; }

            [NameInMap("rooms")]
            [Validation(Required=false)]
            public int? Rooms { get; set; }

            [NameInMap("window")]
            [Validation(Required=false)]
            public string Window { get; set; }

            [NameInMap("window_bad")]
            [Validation(Required=false)]
            public string WindowBad { get; set; }

            [NameInMap("window_view")]
            [Validation(Required=false)]
            public string WindowView { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
