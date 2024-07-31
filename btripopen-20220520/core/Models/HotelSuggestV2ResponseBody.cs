// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSuggestV2ResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelSuggestV2ResponseBodyModule Module { get; set; }
        public class HotelSuggestV2ResponseBodyModule : TeaModel {
            [NameInMap("guess_suggest_infos")]
            [Validation(Required=false)]
            public List<HotelSuggestV2ResponseBodyModuleGuessSuggestInfos> GuessSuggestInfos { get; set; }
            public class HotelSuggestV2ResponseBodyModuleGuessSuggestInfos : TeaModel {
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("city_code")]
                [Validation(Required=false)]
                public int? CityCode { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("display_name")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("point")]
                [Validation(Required=false)]
                public string Point { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                [NameInMap("region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("type_desc")]
                [Validation(Required=false)]
                public string TypeDesc { get; set; }

            }

            [NameInMap("keyword_suggest_infos")]
            [Validation(Required=false)]
            public List<HotelSuggestV2ResponseBodyModuleKeywordSuggestInfos> KeywordSuggestInfos { get; set; }
            public class HotelSuggestV2ResponseBodyModuleKeywordSuggestInfos : TeaModel {
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("business_area_with_city")]
                [Validation(Required=false)]
                public List<HotelSuggestV2ResponseBodyModuleKeywordSuggestInfosBusinessAreaWithCity> BusinessAreaWithCity { get; set; }
                public class HotelSuggestV2ResponseBodyModuleKeywordSuggestInfosBusinessAreaWithCity : TeaModel {
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public int? CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("display_name")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("hotel_id")]
                    [Validation(Required=false)]
                    public string HotelId { get; set; }

                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    [NameInMap("point")]
                    [Validation(Required=false)]
                    public string Point { get; set; }

                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    [NameInMap("region")]
                    [Validation(Required=false)]
                    public int? Region { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    [NameInMap("type_desc")]
                    [Validation(Required=false)]
                    public string TypeDesc { get; set; }

                }

                [NameInMap("city_code")]
                [Validation(Required=false)]
                public int? CityCode { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("display_name")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("point")]
                [Validation(Required=false)]
                public string Point { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                [NameInMap("region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("type_desc")]
                [Validation(Required=false)]
                public string TypeDesc { get; set; }

            }

            [NameInMap("popular_suggest_infos")]
            [Validation(Required=false)]
            public List<HotelSuggestV2ResponseBodyModulePopularSuggestInfos> PopularSuggestInfos { get; set; }
            public class HotelSuggestV2ResponseBodyModulePopularSuggestInfos : TeaModel {
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("popular_infos")]
                [Validation(Required=false)]
                public List<HotelSuggestV2ResponseBodyModulePopularSuggestInfosPopularInfos> PopularInfos { get; set; }
                public class HotelSuggestV2ResponseBodyModulePopularSuggestInfosPopularInfos : TeaModel {
                    [NameInMap("display_name")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

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
