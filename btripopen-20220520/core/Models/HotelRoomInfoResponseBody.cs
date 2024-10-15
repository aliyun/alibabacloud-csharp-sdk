// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelRoomInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<HotelRoomInfoResponseBodyModule> Module { get; set; }
        public class HotelRoomInfoResponseBodyModule : TeaModel {
            [NameInMap("bed_info_group_list")]
            [Validation(Required=false)]
            public List<HotelRoomInfoResponseBodyModuleBedInfoGroupList> BedInfoGroupList { get; set; }
            public class HotelRoomInfoResponseBodyModuleBedInfoGroupList : TeaModel {
                [NameInMap("bed_infos")]
                [Validation(Required=false)]
                public List<HotelRoomInfoResponseBodyModuleBedInfoGroupListBedInfos> BedInfos { get; set; }
                public class HotelRoomInfoResponseBodyModuleBedInfoGroupListBedInfos : TeaModel {
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

                    [NameInMap("length")]
                    [Validation(Required=false)]
                    public string Length { get; set; }

                    [NameInMap("width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            [NameInMap("bed_infos")]
            [Validation(Required=false)]
            public List<HotelRoomInfoResponseBodyModuleBedInfos> BedInfos { get; set; }
            public class HotelRoomInfoResponseBodyModuleBedInfos : TeaModel {
                [NameInMap("bed_desc")]
                [Validation(Required=false)]
                public string BedDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("bed_num")]
                [Validation(Required=false)]
                public int? BedNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.8*2.0m</para>
                /// </summary>
                [NameInMap("bed_size")]
                [Validation(Required=false)]
                public string BedSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("bed_type")]
                [Validation(Required=false)]
                public string BedType { get; set; }

                [NameInMap("length")]
                [Validation(Required=false)]
                public string Length { get; set; }

                [NameInMap("width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("extra_bed")]
            [Validation(Required=false)]
            public int? ExtraBed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("extra_bed_desc")]
            [Validation(Required=false)]
            public string ExtraBedDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("floor")]
            [Validation(Required=false)]
            public string Floor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("internet_way")]
            [Validation(Required=false)]
            public string InternetWay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>84536009</para>
            /// </summary>
            [NameInMap("room_id")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>//img.alicdn.com/imgextra/i2/6000000007493/O1CN010Vmxaz25DqUblX82A_!!6000000007493-2-hotel.png</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i3/6000000000003/O1CN01xkZQR41BtPxK1PQCb_!!6000000000003-0-hotel.jpg">https://img.alicdn.com/imgextra/i3/6000000000003/O1CN01xkZQR41BtPxK1PQCb_!!6000000000003-0-hotel.jpg</a></para>
                /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("rooms")]
            [Validation(Required=false)]
            public int? Rooms { get; set; }

            [NameInMap("smoke")]
            [Validation(Required=false)]
            public string Smoke { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("window")]
            [Validation(Required=false)]
            public string Window { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("window_bad")]
            [Validation(Required=false)]
            public string WindowBad { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("window_view")]
            [Validation(Required=false)]
            public string WindowView { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
