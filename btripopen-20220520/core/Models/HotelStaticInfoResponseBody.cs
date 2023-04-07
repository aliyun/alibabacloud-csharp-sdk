// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelStaticInfoResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module
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

                [NameInMap("brand")]
                [Validation(Required=false)]
                public string Brand { get; set; }

                [NameInMap("brand_name")]
                [Validation(Required=false)]
                public string BrandName { get; set; }

                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

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
                    [NameInMap("check_in")]
                    [Validation(Required=false)]
                    public string CheckIn { get; set; }

                    [NameInMap("check_out")]
                    [Validation(Required=false)]
                    public string CheckOut { get; set; }

                    [NameInMap("decorate_time")]
                    [Validation(Required=false)]
                    public string DecorateTime { get; set; }

                    [NameInMap("floors")]
                    [Validation(Required=false)]
                    public string Floors { get; set; }

                    [NameInMap("hotel_facilities")]
                    [Validation(Required=false)]
                    public List<string> HotelFacilities { get; set; }

                    [NameInMap("hotel_type")]
                    [Validation(Required=false)]
                    public int? HotelType { get; set; }

                    [NameInMap("opening_time")]
                    [Validation(Required=false)]
                    public string OpeningTime { get; set; }

                    [NameInMap("room_facilities")]
                    [Validation(Required=false)]
                    public List<string> RoomFacilities { get; set; }

                    [NameInMap("rooms")]
                    [Validation(Required=false)]
                    public int? Rooms { get; set; }

                    [NameInMap("service")]
                    [Validation(Required=false)]
                    public List<string> Service { get; set; }

                    [NameInMap("theme_tag")]
                    [Validation(Required=false)]
                    public string ThemeTag { get; set; }

                }

                [NameInMap("hotel_address")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                [NameInMap("hotel_en_address")]
                [Validation(Required=false)]
                public string HotelEnAddress { get; set; }

                [NameInMap("hotel_en_name")]
                [Validation(Required=false)]
                public string HotelEnName { get; set; }

                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("hotel_open_time")]
                [Validation(Required=false)]
                public string HotelOpenTime { get; set; }

                [NameInMap("hotel_phones")]
                [Validation(Required=false)]
                public string HotelPhones { get; set; }

                [NameInMap("hotel_policies")]
                [Validation(Required=false)]
                public string HotelPolicies { get; set; }

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

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("invoice_provider_method")]
                [Validation(Required=false)]
                public string InvoiceProviderMethod { get; set; }

                [NameInMap("invoice_types")]
                [Validation(Required=false)]
                public List<int?> InvoiceTypes { get; set; }

                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                [NameInMap("province_name")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                [NameInMap("rating_average")]
                [Validation(Required=false)]
                public string RatingAverage { get; set; }

                [NameInMap("room_infos")]
                [Validation(Required=false)]
                public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfos> RoomInfos { get; set; }
                public class HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfos : TeaModel {
                    [NameInMap("bed_infos")]
                    [Validation(Required=false)]
                    public List<HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfos> BedInfos { get; set; }
                    public class HotelStaticInfoResponseBodyModuleHotelStaticInfosRoomInfosBedInfos : TeaModel {
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

                [NameInMap("star")]
                [Validation(Required=false)]
                public string Star { get; set; }

                [NameInMap("star_rate")]
                [Validation(Required=false)]
                public string StarRate { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("themes")]
                [Validation(Required=false)]
                public string Themes { get; set; }

                [NameInMap("visa_reminding")]
                [Validation(Required=false)]
                public bool? VisaReminding { get; set; }

            }

        }

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
