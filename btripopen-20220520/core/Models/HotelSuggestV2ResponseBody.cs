// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSuggestV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>300100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public int? CityCode { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("display_name")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>53853318</para>
                /// </summary>
                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png">https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png</a></para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("point")]
                [Validation(Required=false)]
                public string Point { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>524</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>300100</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public int? CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("display_name")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>57140953</para>
                    /// </summary>
                    [NameInMap("hotel_id")]
                    [Validation(Required=false)]
                    public string HotelId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png">https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png</a></para>
                    /// </summary>
                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    [NameInMap("point")]
                    [Validation(Required=false)]
                    public string Point { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>524</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("region")]
                    [Validation(Required=false)]
                    public int? Region { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    [NameInMap("type_desc")]
                    [Validation(Required=false)]
                    public string TypeDesc { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public int? CityCode { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("display_name")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>53853318</para>
                /// </summary>
                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png">https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png</a></para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("point")]
                [Validation(Required=false)]
                public string Point { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>524</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://gw.alicdn.com/imgextra/i1/O1CN01x0q19E1QZSqLHVVNh_!!6000000001990-2-tps-54-54.png">https://gw.alicdn.com/imgextra/i1/O1CN01x0q19E1QZSqLHVVNh_!!6000000001990-2-tps-54-54.png</a></para>
                /// </summary>
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
