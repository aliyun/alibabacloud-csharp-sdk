// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelStaticInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelStaticInfoResponseBodyModule Module { get; set; }
        public class HotelStaticInfoResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of room type information. An empty array is returned when no data is available.</para>
            /// </summary>
            [NameInMap("hotel_static_infos")]
            [Validation(Required=false)]
            public List<HotelStaticInfoResponseBodyModuleHotelStaticInfos> HotelStaticInfos { get; set; }
            public class HotelStaticInfoResponseBodyModuleHotelStaticInfos : TeaModel {
                /// <summary>
                /// <para>The blocked room type information. An empty map is returned when no data is available.</para>
                /// </summary>
                [NameInMap("block_room_type_information")]
                [Validation(Required=false)]
                public Dictionary<string, string> BlockRoomTypeInformation { get; set; }

                /// <summary>
                /// <para>The brand code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19039</para>
                /// </summary>
                [NameInMap("brand")]
                [Validation(Required=false)]
                public string Brand { get; set; }

                /// <summary>
                /// <para>The brand name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>万豪</para>
                /// </summary>
                [NameInMap("brand_name")]
                [Validation(Required=false)]
                public string BrandName { get; set; }

                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The name of the country where the hotel is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <para>The code of the country where the hotel is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <para>The hotel description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>未来酒店</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The district code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330183</para>
                /// </summary>
                [NameInMap("district")]
                [Validation(Required=false)]
                public string District { get; set; }

                /// <summary>
                /// <para>The district name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>富阳</para>
                /// </summary>
                [NameInMap("district_name")]
                [Validation(Required=false)]
                public string DistrictName { get; set; }

                /// <summary>
                /// <para>The hotel extended information.</para>
                /// </summary>
                [NameInMap("expand_info")]
                [Validation(Required=false)]
                public HotelStaticInfoResponseBodyModuleHotelStaticInfosExpandInfo ExpandInfo { get; set; }
                public class HotelStaticInfoResponseBodyModuleHotelStaticInfosExpandInfo : TeaModel {
                    /// <summary>
                    /// <para>The check-in time (earliest check-in time).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17:00</para>
                    /// </summary>
                    [NameInMap("check_in")]
                    [Validation(Required=false)]
                    public string CheckIn { get; set; }

                    /// <summary>
                    /// <para>The check-out time (earliest check-out time).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12:00</para>
                    /// </summary>
                    [NameInMap("check_out")]
                    [Validation(Required=false)]
                    public string CheckOut { get; set; }

                    /// <summary>
                    /// <para>The renovation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020</para>
                    /// </summary>
                    [NameInMap("decorate_time")]
                    [Validation(Required=false)]
                    public string DecorateTime { get; set; }

                    /// <summary>
                    /// <para>The floor information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4-6层</para>
                    /// </summary>
                    [NameInMap("floors")]
                    [Validation(Required=false)]
                    public string Floors { get; set; }

                    /// <summary>
                    /// <para>The hotel facilities. An empty array is returned when no data is available.</para>
                    /// </summary>
                    [NameInMap("hotel_facilities")]
                    [Validation(Required=false)]
                    public List<string> HotelFacilities { get; set; }

                    /// <summary>
                    /// <para>The hotel type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: Hotel.</description></item>
                    /// <item><description>1: Inn.</description></item>
                    /// <item><description>2: Non-standard homestay.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("hotel_type")]
                    [Validation(Required=false)]
                    public int? HotelType { get; set; }

                    /// <summary>
                    /// <para>The opening time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020</para>
                    /// </summary>
                    [NameInMap("opening_time")]
                    [Validation(Required=false)]
                    public string OpeningTime { get; set; }

                    /// <summary>
                    /// <para>The room facilities. An empty array is returned when no data is available.</para>
                    /// </summary>
                    [NameInMap("room_facilities")]
                    [Validation(Required=false)]
                    public List<string> RoomFacilities { get; set; }

                    /// <summary>
                    /// <para>The number of rooms in the hotel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("rooms")]
                    [Validation(Required=false)]
                    public int? Rooms { get; set; }

                    /// <summary>
                    /// <para>The hotel services. An empty array is returned when no data is available.</para>
                    /// </summary>
                    [NameInMap("service")]
                    [Validation(Required=false)]
                    public List<string> Service { get; set; }

                    /// <summary>
                    /// <para>The hotel feature. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: Business hotel.</description></item>
                    /// <item><description>2: Budget chain.</description></item>
                    /// <item><description>3: Serviced apartment.</description></item>
                    /// <item><description>4: Inn.</description></item>
                    /// <item><description>5: Boutique hotel.</description></item>
                    /// <item><description>6: Youth hostel.</description></item>
                    /// <item><description>7: Family hotel.</description></item>
                    /// <item><description>8: Convention hotel.</description></item>
                    /// <item><description>9: Resort hotel.</description></item>
                    /// <item><description>10: Luxury hotel.</description></item>
                    /// <item><description>11: Couple hotel.</description></item>
                    /// <item><description>12: Seaside hotel.</description></item>
                    /// <item><description>13: Hot spring hotel.</description></item>
                    /// <item><description>14: Courtyard house.</description></item>
                    /// <item><description>15: Garden courtyard.</description></item>
                    /// <item><description>16: Farmhouse.</description></item>
                    /// <item><description>17: Golf hotel.</description></item>
                    /// <item><description>18: Guesthouse.</description></item>
                    /// <item><description>19: Country villa.</description></item>
                    /// <item><description>20: Premium chain.</description></item>
                    /// <item><description>21: Other hotel.</description></item>
                    /// <item><description>22: Other inn.</description></item>
                    /// <item><description>23: Theme hotel.</description></item>
                    /// <item><description>24: Comfort luxury.</description></item>
                    /// <item><description>25: Chain brand.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("theme_tag")]
                    [Validation(Required=false)]
                    public string ThemeTag { get; set; }

                }

                /// <summary>
                /// <para>The hotel address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文一西路998号海创大厦5号楼</para>
                /// </summary>
                [NameInMap("hotel_address")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                /// <summary>
                /// <para>The English address of the hotel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Building 5, Haichuang Building, 998 Wenyi West Road</para>
                /// </summary>
                [NameInMap("hotel_en_address")]
                [Validation(Required=false)]
                public string HotelEnAddress { get; set; }

                /// <summary>
                /// <para>The English name of the hotel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business travel hotel</para>
                /// </summary>
                [NameInMap("hotel_en_name")]
                [Validation(Required=false)]
                public string HotelEnName { get; set; }

                /// <summary>
                /// <para>The hotel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>55335212</para>
                /// </summary>
                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                /// <summary>
                /// <para>The hotel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅酒店测试</para>
                /// </summary>
                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <para>The hotel opening time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020</para>
                /// </summary>
                [NameInMap("hotel_open_time")]
                [Validation(Required=false)]
                public string HotelOpenTime { get; set; }

                /// <summary>
                /// <para>The hotel phone numbers (format: country code#area code#phone number#extension. Mobile: ##mobile number. 400 number: ##400823823. Non-standard homestays may contain the landlord phone number). Multiple numbers are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0086#0571#28350117</para>
                /// </summary>
                [NameInMap("hotel_phones")]
                [Validation(Required=false)]
                public string HotelPhones { get; set; }

                /// <summary>
                /// <para>The hotel check-in policies (for international hotels, including children and extra bed information).</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("hotel_policies")]
                [Validation(Required=false)]
                public string HotelPolicies { get; set; }

                /// <summary>
                /// <para>The hotel fax numbers. Multiple numbers are separated by commas (format: country code#area code#phone number#extension. Mobile: ##mobile number. 400 number: ##400823823. Non-standard homestays may contain the landlord phone number).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0086#0571#28350117</para>
                /// </summary>
                [NameInMap("hotelfax")]
                [Validation(Required=false)]
                public string Hotelfax { get; set; }

                /// <summary>
                /// <para>Multiple image URLs separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>//img.alicdn.com/imgextra/i4/6000000006401/O1CN01lF6MGK1x9hzQFGg9r_!!6000000006401-0-hotel.jpg</para>
                /// </summary>
                [NameInMap("hotelpics")]
                [Validation(Required=false)]
                public string Hotelpics { get; set; }

                /// <summary>
                /// <para>The image list. This field is deprecated.</para>
                /// </summary>
                [NameInMap("imageinfos")]
                [Validation(Required=false)]
                public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosImageinfos> Imageinfos { get; set; }
                public class HotelStaticInfoResponseBodyModuleHotelStaticInfosImageinfos : TeaModel {
                    /// <summary>
                    /// <para>The image description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo（暂无）</para>
                    /// </summary>
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

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
                /// <para>The invoice provision method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: No invoice.</description></item>
                /// <item><description>1: Invoice issued by the hotel.</description></item>
                /// <item><description>2: Invoice issued by the TMC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_provider_method")]
                [Validation(Required=false)]
                public string InvoiceProviderMethod { get; set; }

                /// <summary>
                /// <para>The invoice type. This field is deprecated.</para>
                /// </summary>
                [NameInMap("invoice_types")]
                [Validation(Required=false)]
                public List<int?> InvoiceTypes { get; set; }

                /// <summary>
                /// <para>The longitude and latitude of the hotel address (AMAP).</para>
                /// 
                /// <b>Example:</b>
                /// <para>119.844005,30.054384</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The code of the province where the hotel is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330000</para>
                /// </summary>
                [NameInMap("province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                /// <summary>
                /// <para>The name of the province where the hotel is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江</para>
                /// </summary>
                [NameInMap("province_name")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                /// <summary>
                /// <para>The hotel rating.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("rating_average")]
                [Validation(Required=false)]
                public string RatingAverage { get; set; }

                /// <summary>
                /// <para>The room type list. An empty array is returned when no data is available.</para>
                /// </summary>
                [NameInMap("room_infos")]
                [Validation(Required=false)]
                public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfos> RoomInfos { get; set; }
                public class HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfos : TeaModel {
                    /// <summary>
                    /// <para>Multiple bed type groups. Beds within a group have an AND relationship, and groups have an OR relationship (use this field). An empty array is returned when no data is available.</para>
                    /// </summary>
                    [NameInMap("bed_info_group_list")]
                    [Validation(Required=false)]
                    public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfoGroupList> BedInfoGroupList { get; set; }
                    public class HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfoGroupList : TeaModel {
                        /// <summary>
                        /// <para>The bed type list. An empty array is returned when no data is available.</para>
                        /// </summary>
                        [NameInMap("bed_Infos")]
                        [Validation(Required=false)]
                        public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfoGroupListBedInfos> BedInfos { get; set; }
                        public class HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfoGroupListBedInfos : TeaModel {
                            /// <summary>
                            /// <para>The bed description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1张大床(1.8M)</para>
                            /// </summary>
                            [NameInMap("bed_desc")]
                            [Validation(Required=false)]
                            public string BedDesc { get; set; }

                            /// <summary>
                            /// <para>The number of beds.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("bed_num")]
                            [Validation(Required=false)]
                            public int? BedNum { get; set; }

                            /// <summary>
                            /// <para>The bed size description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1.8m</para>
                            /// </summary>
                            [NameInMap("bed_size")]
                            [Validation(Required=false)]
                            public string BedSize { get; set; }

                            /// <summary>
                            /// <para>The bed type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
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
                    /// <para>The bed type list for this room type. This field is deprecated. Use bed_info_group_list instead.</para>
                    /// </summary>
                    [NameInMap("bed_infos")]
                    [Validation(Required=false)]
                    public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfos> BedInfos { get; set; }
                    public class HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfos : TeaModel {
                        /// <summary>
                        /// <para>The bed description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1张大床(1.8M)</para>
                        /// </summary>
                        [NameInMap("bed_desc")]
                        [Validation(Required=false)]
                        public string BedDesc { get; set; }

                        /// <summary>
                        /// <para>The number of beds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("bed_num")]
                        [Validation(Required=false)]
                        public int? BedNum { get; set; }

                        /// <summary>
                        /// <para>The bed size description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.8m</para>
                        /// </summary>
                        [NameInMap("bed_size")]
                        [Validation(Required=false)]
                        public string BedSize { get; set; }

                        /// <summary>
                        /// <para>The bed type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
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
                    /// <para>Indicates whether an extra bed can be added.</para>
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
                    /// <para>1,2,3,4,5,6</para>
                    /// </summary>
                    [NameInMap("floor")]
                    [Validation(Required=false)]
                    public string Floor { get; set; }

                    /// <summary>
                    /// <para>The broadband internet access type.</para>
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("max_occupancy")]
                    [Validation(Required=false)]
                    public int? MaxOccupancy { get; set; }

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
                    /// <para>The room facility list. This field is deprecated.</para>
                    /// </summary>
                    [NameInMap("room_facility_list")]
                    [Validation(Required=false)]
                    public List<string> RoomFacilityList { get; set; }

                    /// <summary>
                    /// <para>The room type ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>71652158</para>
                    /// </summary>
                    [NameInMap("room_id")]
                    [Validation(Required=false)]
                    public string RoomId { get; set; }

                    /// <summary>
                    /// <para>The main image URL of the room type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>//img.alicdn.com/imgextra/i3/6000000000003/O1CN01xkZQR41BtPxK1PQCb_!!6000000000003-0-hotel.jpg</para>
                    /// </summary>
                    [NameInMap("room_image")]
                    [Validation(Required=false)]
                    public string RoomImage { get; set; }

                    /// <summary>
                    /// <para>The list of room type image URLs. An empty array is returned when no images are available.</para>
                    /// </summary>
                    [NameInMap("room_images")]
                    [Validation(Required=false)]
                    public List<string> RoomImages { get; set; }

                    /// <summary>
                    /// <para>The room type name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>公寓房</para>
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("rooms")]
                    [Validation(Required=false)]
                    public int? Rooms { get; set; }

                    /// <summary>
                    /// <para>The window type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: No window.</description></item>
                    /// <item><description>1: With window.</description></item>
                    /// <item><description>2: Partial window.</description></item>
                    /// <item><description>3: Frosted window.</description></item>
                    /// <item><description>4: Partial frosted window.</description></item>
                    /// <item><description>5: Floor-to-ceiling window.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
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
                    /// <para>demo（暂无）</para>
                    /// </summary>
                    [NameInMap("window_bad")]
                    [Validation(Required=false)]
                    public string WindowBad { get; set; }

                    /// <summary>
                    /// <para>The window view description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo（暂无）</para>
                    /// </summary>
                    [NameInMap("window_view")]
                    [Validation(Required=false)]
                    public string WindowView { get; set; }

                }

                /// <summary>
                /// <para>The hotel class (class is not the same as star rating).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("star")]
                [Validation(Required=false)]
                public string Star { get; set; }

                /// <summary>
                /// <para>The star rating assessed by the tourism authority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("star_rate")]
                [Validation(Required=false)]
                public string StarRate { get; set; }

                /// <summary>
                /// <para>The hotel status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: In operation.</description></item>
                /// <item><description>-1: Under construction.</description></item>
                /// <item><description>-2: Temporarily closed.</description></item>
                /// <item><description>-3: Permanently closed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The hotel themes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("themes")]
                [Validation(Required=false)]
                public string Themes { get; set; }

                /// <summary>
                /// <para>The visa reminder at the country level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("visa_reminding")]
                [Validation(Required=false)]
                public bool? VisaReminding { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID of the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
