// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelStaticInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
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

        /// <summary>
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelStaticInfoResponseBodyModule Module { get; set; }
        public class HotelStaticInfoResponseBodyModule : TeaModel {
            [NameInMap("hotel_static_infos")]
            [Validation(Required=false)]
            public List<HotelStaticInfoResponseBodyModuleHotelStaticInfos> HotelStaticInfos { get; set; }
            public class HotelStaticInfoResponseBodyModuleHotelStaticInfos : TeaModel {
                [NameInMap("block_room_type_information")]
                [Validation(Required=false)]
                public Dictionary<string, string> BlockRoomTypeInformation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19039</para>
                /// </summary>
                [NameInMap("brand")]
                [Validation(Required=false)]
                public string Brand { get; set; }

                [NameInMap("brand_name")]
                [Validation(Required=false)]
                public string BrandName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330183</para>
                /// </summary>
                [NameInMap("district")]
                [Validation(Required=false)]
                public string District { get; set; }

                [NameInMap("district_name")]
                [Validation(Required=false)]
                public string DistrictName { get; set; }

                [NameInMap("expand_info")]
                [Validation(Required=false)]
                public HotelStaticInfoResponseBodyModuleHotelStaticInfosExpandInfo ExpandInfo { get; set; }
                public class HotelStaticInfoResponseBodyModuleHotelStaticInfosExpandInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>17:00</para>
                    /// </summary>
                    [NameInMap("check_in")]
                    [Validation(Required=false)]
                    public string CheckIn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12:00</para>
                    /// </summary>
                    [NameInMap("check_out")]
                    [Validation(Required=false)]
                    public string CheckOut { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020</para>
                    /// </summary>
                    [NameInMap("decorate_time")]
                    [Validation(Required=false)]
                    public string DecorateTime { get; set; }

                    [NameInMap("floors")]
                    [Validation(Required=false)]
                    public string Floors { get; set; }

                    [NameInMap("hotel_facilities")]
                    [Validation(Required=false)]
                    public List<string> HotelFacilities { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("hotel_type")]
                    [Validation(Required=false)]
                    public int? HotelType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020</para>
                    /// </summary>
                    [NameInMap("opening_time")]
                    [Validation(Required=false)]
                    public string OpeningTime { get; set; }

                    [NameInMap("room_facilities")]
                    [Validation(Required=false)]
                    public List<string> RoomFacilities { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("rooms")]
                    [Validation(Required=false)]
                    public int? Rooms { get; set; }

                    [NameInMap("service")]
                    [Validation(Required=false)]
                    public List<string> Service { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("theme_tag")]
                    [Validation(Required=false)]
                    public string ThemeTag { get; set; }

                }

                [NameInMap("hotel_address")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Building 5, Haichuang Building, 998 Wenyi West Road</para>
                /// </summary>
                [NameInMap("hotel_en_address")]
                [Validation(Required=false)]
                public string HotelEnAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Business travel hotel</para>
                /// </summary>
                [NameInMap("hotel_en_name")]
                [Validation(Required=false)]
                public string HotelEnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>55335212</para>
                /// </summary>
                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020</para>
                /// </summary>
                [NameInMap("hotel_open_time")]
                [Validation(Required=false)]
                public string HotelOpenTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0086#0571#28350117</para>
                /// </summary>
                [NameInMap("hotel_phones")]
                [Validation(Required=false)]
                public string HotelPhones { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("hotel_policies")]
                [Validation(Required=false)]
                public string HotelPolicies { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0086#0571#28350117</para>
                /// </summary>
                [NameInMap("hotelfax")]
                [Validation(Required=false)]
                public string Hotelfax { get; set; }

                [NameInMap("hotelpics")]
                [Validation(Required=false)]
                public string Hotelpics { get; set; }

                [NameInMap("imageinfos")]
                [Validation(Required=false)]
                public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosImageinfos> Imageinfos { get; set; }
                public class HotelStaticInfoResponseBodyModuleHotelStaticInfosImageinfos : TeaModel {
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_provider_method")]
                [Validation(Required=false)]
                public string InvoiceProviderMethod { get; set; }

                [NameInMap("invoice_types")]
                [Validation(Required=false)]
                public List<int?> InvoiceTypes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>119.844005,30.054384</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330000</para>
                /// </summary>
                [NameInMap("province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                [NameInMap("province_name")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("rating_average")]
                [Validation(Required=false)]
                public string RatingAverage { get; set; }

                [NameInMap("room_infos")]
                [Validation(Required=false)]
                public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfos> RoomInfos { get; set; }
                public class HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfos : TeaModel {
                    [NameInMap("bed_info_group_list")]
                    [Validation(Required=false)]
                    public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfoGroupList> BedInfoGroupList { get; set; }
                    public class HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfoGroupList : TeaModel {
                        [NameInMap("bed_Infos")]
                        [Validation(Required=false)]
                        public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfoGroupListBedInfos> BedInfos { get; set; }
                        public class HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfoGroupListBedInfos : TeaModel {
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
                    public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfos> BedInfos { get; set; }
                    public class HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfos : TeaModel {
                        [NameInMap("bed_desc")]
                        [Validation(Required=false)]
                        public string BedDesc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("bed_num")]
                        [Validation(Required=false)]
                        public int? BedNum { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1.8m</para>
                        /// </summary>
                        [NameInMap("bed_size")]
                        [Validation(Required=false)]
                        public string BedSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
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
                    /// <para>1,2,3,4,5,6</para>
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("max_occupancy")]
                    [Validation(Required=false)]
                    public int? MaxOccupancy { get; set; }

                    [NameInMap("room_facilities")]
                    [Validation(Required=false)]
                    public string RoomFacilities { get; set; }

                    [NameInMap("room_facility_list")]
                    [Validation(Required=false)]
                    public List<string> RoomFacilityList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>71652158</para>
                    /// </summary>
                    [NameInMap("room_id")]
                    [Validation(Required=false)]
                    public string RoomId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>//img.alicdn.com/imgextra/i3/6000000000003/O1CN01xkZQR41BtPxK1PQCb_!!6000000000003-0-hotel.jpg</para>
                    /// </summary>
                    [NameInMap("room_image")]
                    [Validation(Required=false)]
                    public string RoomImage { get; set; }

                    [NameInMap("room_images")]
                    [Validation(Required=false)]
                    public List<string> RoomImages { get; set; }

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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("rooms")]
                    [Validation(Required=false)]
                    public int? Rooms { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
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
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("star")]
                [Validation(Required=false)]
                public string Star { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("star_rate")]
                [Validation(Required=false)]
                public string StarRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("themes")]
                [Validation(Required=false)]
                public string Themes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("visa_reminding")]
                [Validation(Required=false)]
                public bool? VisaReminding { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
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
