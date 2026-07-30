// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelRoomInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The data. An empty array is returned when no data is available.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<HotelRoomInfoResponseBodyModule> Module { get; set; }
        public class HotelRoomInfoResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The bed type groups. Bed types within a group have an AND relationship, and groups have an OR relationship. An empty array is returned when no data is available.</para>
            /// </summary>
            [NameInMap("bed_info_group_list")]
            [Validation(Required=false)]
            public List<HotelRoomInfoResponseBodyModuleBedInfoGroupList> BedInfoGroupList { get; set; }
            public class HotelRoomInfoResponseBodyModuleBedInfoGroupList : TeaModel {
                /// <summary>
                /// <para>The bed type information. An empty array is returned when no data is available.</para>
                /// </summary>
                [NameInMap("bed_infos")]
                [Validation(Required=false)]
                public List<HotelRoomInfoResponseBodyModuleBedInfoGroupListBedInfos> BedInfos { get; set; }
                public class HotelRoomInfoResponseBodyModuleBedInfoGroupListBedInfos : TeaModel {
                    /// <summary>
                    /// <para>The number of beds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("bed_desc")]
                    [Validation(Required=false)]
                    public string BedDesc { get; set; }

                    /// <summary>
                    /// <para>The bed description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2张单人床(1.2M)</para>
                    /// </summary>
                    [NameInMap("bed_num")]
                    [Validation(Required=false)]
                    public int? BedNum { get; set; }

                    /// <summary>
                    /// <para>The bed size description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.8*2.0m</para>
                    /// </summary>
                    [NameInMap("bed_size")]
                    [Validation(Required=false)]
                    public string BedSize { get; set; }

                    /// <summary>
                    /// <para>The bed type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("bed_type")]
                    [Validation(Required=false)]
                    public string BedType { get; set; }

                    /// <summary>
                    /// <para>The bed length.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1280</para>
                    /// </summary>
                    [NameInMap("length")]
                    [Validation(Required=false)]
                    public string Length { get; set; }

                    /// <summary>
                    /// <para>The bed width.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1280</para>
                    /// </summary>
                    [NameInMap("width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of bed types for this room type. An empty array is returned when no data is available.</para>
            /// </summary>
            [NameInMap("bed_infos")]
            [Validation(Required=false)]
            public List<HotelRoomInfoResponseBodyModuleBedInfos> BedInfos { get; set; }
            public class HotelRoomInfoResponseBodyModuleBedInfos : TeaModel {
                /// <summary>
                /// <para>The bed description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2张单人床(1.2M)</para>
                /// </summary>
                [NameInMap("bed_desc")]
                [Validation(Required=false)]
                public string BedDesc { get; set; }

                /// <summary>
                /// <para>The number of beds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("bed_num")]
                [Validation(Required=false)]
                public int? BedNum { get; set; }

                /// <summary>
                /// <para>The bed size description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.8*2.0m</para>
                /// </summary>
                [NameInMap("bed_size")]
                [Validation(Required=false)]
                public string BedSize { get; set; }

                /// <summary>
                /// <para>The bed type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("bed_type")]
                [Validation(Required=false)]
                public string BedType { get; set; }

                /// <summary>
                /// <para>The bed length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("length")]
                [Validation(Required=false)]
                public string Length { get; set; }

                /// <summary>
                /// <para>The bed width.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether an extra bed can be added. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("extra_bed")]
            [Validation(Required=false)]
            public int? ExtraBed { get; set; }

            /// <summary>
            /// <para>The extra bed description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("extra_bed_desc")]
            [Validation(Required=false)]
            public string ExtraBedDesc { get; set; }

            /// <summary>
            /// <para>The floor where the room is located, such as &quot;2&quot; or &quot;2-3&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("floor")]
            [Validation(Required=false)]
            public string Floor { get; set; }

            /// <summary>
            /// <para>The Internet access type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Wired Internet (free).</description></item>
            /// <item><description>1: Wired Internet (unavailable).</description></item>
            /// <item><description>2: Wired Internet (paid).</description></item>
            /// <item><description>3: Wired Internet (partially available and free).</description></item>
            /// <item><description>4: Wired Internet (partially available and paid).</description></item>
            /// <item><description>5: Wireless Internet (free).</description></item>
            /// <item><description>6: Wireless Internet (paid).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("internet_way")]
            [Validation(Required=false)]
            public string InternetWay { get; set; }

            /// <summary>
            /// <para>The maximum number of guests the room can accommodate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("max_occupancy")]
            [Validation(Required=false)]
            public int? MaxOccupancy { get; set; }

            /// <summary>
            /// <para>The room type description (N/A).</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo（暂无）</para>
            /// </summary>
            [NameInMap("room_desc")]
            [Validation(Required=false)]
            public string RoomDesc { get; set; }

            /// <summary>
            /// <para>The room facilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>免费wifi</para>
            /// </summary>
            [NameInMap("room_facilities")]
            [Validation(Required=false)]
            public string RoomFacilities { get; set; }

            /// <summary>
            /// <para>The list of room facilities. An empty array is returned when no data is available.</para>
            /// </summary>
            [NameInMap("room_facility_list")]
            [Validation(Required=false)]
            public List<string> RoomFacilityList { get; set; }

            /// <summary>
            /// <para>The room type ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>84536009</para>
            /// </summary>
            [NameInMap("room_id")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            /// <summary>
            /// <para>The URL of the room type main image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>//img.alicdn.com/imgextra/i2/6000000007493/O1CN010Vmxaz25DqUblX82A_!!6000000007493-2-hotel.png</para>
            /// </summary>
            [NameInMap("room_image")]
            [Validation(Required=false)]
            public string RoomImage { get; set; }

            /// <summary>
            /// <para>The list of room type image URLs. An empty array is returned when no data is available.</para>
            /// </summary>
            [NameInMap("room_images")]
            [Validation(Required=false)]
            public List<HotelRoomInfoResponseBodyModuleRoomImages> RoomImages { get; set; }
            public class HotelRoomInfoResponseBodyModuleRoomImages : TeaModel {
                /// <summary>
                /// <para>The image description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo（暂无）</para>
                /// </summary>
                [NameInMap("bed_infos2")]
                [Validation(Required=false)]
                public string BedInfos2 { get; set; }

                /// <summary>
                /// <para>The image type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo（暂无）</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public int? Tag { get; set; }

                /// <summary>
                /// <para>The URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i3/6000000000003/O1CN01xkZQR41BtPxK1PQCb_!!6000000000003-0-hotel.jpg">https://img.alicdn.com/imgextra/i3/6000000000003/O1CN01xkZQR41BtPxK1PQCb_!!6000000000003-0-hotel.jpg</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The room type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>大床房测试</para>
            /// </summary>
            [NameInMap("room_name")]
            [Validation(Required=false)]
            public string RoomName { get; set; }

            /// <summary>
            /// <para>The room type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo（暂无）</para>
            /// </summary>
            [NameInMap("room_type")]
            [Validation(Required=false)]
            public int? RoomType { get; set; }

            /// <summary>
            /// <para>The room area.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35平</para>
            /// </summary>
            [NameInMap("roomarea")]
            [Validation(Required=false)]
            public string Roomarea { get; set; }

            /// <summary>
            /// <para>The number of rooms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("rooms")]
            [Validation(Required=false)]
            public int? Rooms { get; set; }

            /// <summary>
            /// <para>The room smoking policy (non-smoking or smoking allowed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>部分客房禁烟</para>
            /// </summary>
            [NameInMap("smoke")]
            [Validation(Required=false)]
            public string Smoke { get; set; }

            /// <summary>
            /// <para>The window type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No window.</description></item>
            /// <item><description>1: Has window.</description></item>
            /// <item><description>2: Partial window.</description></item>
            /// <item><description>3: Opaque window.</description></item>
            /// <item><description>4: Floor-to-ceiling window.</description></item>
            /// <item><description>5: Floor-to-ceiling window.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("window")]
            [Validation(Required=false)]
            public string Window { get; set; }

            /// <summary>
            /// <para>The window defect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Window cannot be opened for ventilation.</description></item>
            /// <item><description>1: View is obstructed outside the window.</description></item>
            /// <item><description>2: Window faces the hotel interior.</description></item>
            /// <item><description>3: Window is located in a corridor or hallway.</description></item>
            /// <item><description>4: Window can be opened for ventilation, and the view outside is an open outdoor environment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("window_bad")]
            [Validation(Required=false)]
            public string WindowBad { get; set; }

            /// <summary>
            /// <para>The window view description.</para>
            /// 
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
