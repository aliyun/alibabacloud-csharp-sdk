// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSuggestV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
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
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The result details.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelSuggestV2ResponseBodyModule Module { get; set; }
        public class HotelSuggestV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The intelligent recommendation details. Returned when keyword_suggest_infos has no results.</para>
            /// </summary>
            [NameInMap("guess_suggest_infos")]
            [Validation(Required=false)]
            public List<HotelSuggestV2ResponseBodyModuleGuessSuggestInfos> GuessSuggestInfos { get; set; }
            public class HotelSuggestV2ResponseBodyModuleGuessSuggestInfos : TeaModel {
                /// <summary>
                /// <para>The address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州湖墅南路XX号</para>
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public int? CityCode { get; set; }

                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州JW万豪酒店</para>
                /// </summary>
                [NameInMap("display_name")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The hotel ID. Returned when type is 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>53853318</para>
                /// </summary>
                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                /// <summary>
                /// <para>The icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png">https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png</a></para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <para>The rating score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.8分</para>
                /// </summary>
                [NameInMap("point")]
                [Validation(Required=false)]
                public string Point { get; set; }

                /// <summary>
                /// <para>The starting price of the hotel, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>524</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

                /// <summary>
                /// <para>The keyword type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The type description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>酒店</para>
                /// </summary>
                [NameInMap("type_desc")]
                [Validation(Required=false)]
                public string TypeDesc { get; set; }

            }

            /// <summary>
            /// <para>The keyword search suggestion details.</para>
            /// </summary>
            [NameInMap("keyword_suggest_infos")]
            [Validation(Required=false)]
            public List<HotelSuggestV2ResponseBodyModuleKeywordSuggestInfos> KeywordSuggestInfos { get; set; }
            public class HotelSuggestV2ResponseBodyModuleKeywordSuggestInfos : TeaModel {
                /// <summary>
                /// <para>The address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州湖墅南路XX号</para>
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The business area. Returned during city search.</para>
                /// </summary>
                [NameInMap("business_area_with_city")]
                [Validation(Required=false)]
                public List<HotelSuggestV2ResponseBodyModuleKeywordSuggestInfosBusinessAreaWithCity> BusinessAreaWithCity { get; set; }
                public class HotelSuggestV2ResponseBodyModuleKeywordSuggestInfosBusinessAreaWithCity : TeaModel {
                    /// <summary>
                    /// <para>The address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>成都市高新区天府大道北段1700号1栋2单元18层1801号</para>
                    /// </summary>
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>The city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300100</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public int? CityCode { get; set; }

                    /// <summary>
                    /// <para>The city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// <para>The display name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>阿里巴巴/未来科技城</para>
                    /// </summary>
                    [NameInMap("display_name")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The hotel ID. Returned when type is 10.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>57140953</para>
                    /// </summary>
                    [NameInMap("hotel_id")]
                    [Validation(Required=false)]
                    public string HotelId { get; set; }

                    /// <summary>
                    /// <para>The icon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png">https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png</a></para>
                    /// </summary>
                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// <para>The rating score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4.8分</para>
                    /// </summary>
                    [NameInMap("point")]
                    [Validation(Required=false)]
                    public string Point { get; set; }

                    /// <summary>
                    /// <para>The starting price of the hotel, in CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>524</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    /// <summary>
                    /// <para>The region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("region")]
                    [Validation(Required=false)]
                    public int? Region { get; set; }

                    /// <summary>
                    /// <para>The keyword type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>The type description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>商圈</para>
                    /// </summary>
                    [NameInMap("type_desc")]
                    [Validation(Required=false)]
                    public string TypeDesc { get; set; }

                }

                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public int? CityCode { get; set; }

                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州JW万豪酒店</para>
                /// </summary>
                [NameInMap("display_name")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The hotel ID. Returned when type is 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>53853318</para>
                /// </summary>
                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                /// <summary>
                /// <para>The icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png">https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png</a></para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <para>The rating score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.8分</para>
                /// </summary>
                [NameInMap("point")]
                [Validation(Required=false)]
                public string Point { get; set; }

                /// <summary>
                /// <para>The starting price of the hotel, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>524</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

                /// <summary>
                /// <para>The keyword type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The keyword type description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>酒店</para>
                /// </summary>
                [NameInMap("type_desc")]
                [Validation(Required=false)]
                public string TypeDesc { get; set; }

            }

            /// <summary>
            /// <para>The popular search details.</para>
            /// </summary>
            [NameInMap("popular_suggest_infos")]
            [Validation(Required=false)]
            public List<HotelSuggestV2ResponseBodyModulePopularSuggestInfos> PopularSuggestInfos { get; set; }
            public class HotelSuggestV2ResponseBodyModulePopularSuggestInfos : TeaModel {
                /// <summary>
                /// <para>The icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://gw.alicdn.com/imgextra/i1/O1CN01x0q19E1QZSqLHVVNh_!!6000000001990-2-tps-54-54.png">https://gw.alicdn.com/imgextra/i1/O1CN01x0q19E1QZSqLHVVNh_!!6000000001990-2-tps-54-54.png</a></para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <para>The popular content.</para>
                /// </summary>
                [NameInMap("popular_infos")]
                [Validation(Required=false)]
                public List<HotelSuggestV2ResponseBodyModulePopularSuggestInfosPopularInfos> PopularInfos { get; set; }
                public class HotelSuggestV2ResponseBodyModulePopularSuggestInfosPopularInfos : TeaModel {
                    /// <summary>
                    /// <para>The display name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州东站</para>
                    /// </summary>
                    [NameInMap("display_name")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>热门搜索</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The prompt text displayed on the frontend.</para>
            /// 
            /// <b>Example:</b>
            /// <para>以下是当前城市和周边的查询结果 (酒店起价为参考)</para>
            /// </summary>
            [NameInMap("tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

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
        /// <para>Indicates whether the request was successful.</para>
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
