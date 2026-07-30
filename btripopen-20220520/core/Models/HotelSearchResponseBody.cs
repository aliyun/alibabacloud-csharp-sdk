// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSearchResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description of the return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The hotel list.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelSearchResponseBodyModule Module { get; set; }
        public class HotelSearchResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The total number of hotels. This is an approximate number and may not equal the final number of hotels returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>173</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The hotel list. An empty array is returned if no results are found.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<HotelSearchResponseBodyModuleItems> Items { get; set; }
            public class HotelSearchResponseBodyModuleItems : TeaModel {
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
                /// <para>The brand code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1902</para>
                /// </summary>
                [NameInMap("btand_code")]
                [Validation(Required=false)]
                public string BtandCode { get; set; }

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
                /// <para>The discount information. An empty array is returned if no discounts are available.</para>
                /// </summary>
                [NameInMap("discount_desc")]
                [Validation(Required=false)]
                public HotelSearchResponseBodyModuleItemsDiscountDesc DiscountDesc { get; set; }
                public class HotelSearchResponseBodyModuleItemsDiscountDesc : TeaModel {
                    /// <summary>
                    /// <para>The total discount amount per room per night.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("cash_reduce_total")]
                    [Validation(Required=false)]
                    public string CashReduceTotal { get; set; }

                    /// <summary>
                    /// <para>The membership marketing label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>F3会员价</para>
                    /// </summary>
                    [NameInMap("dinamic_label")]
                    [Validation(Required=false)]
                    public string DinamicLabel { get; set; }

                    /// <summary>
                    /// <para>The discount details.</para>
                    /// </summary>
                    [NameInMap("discount_detail")]
                    [Validation(Required=false)]
                    public List<HotelSearchResponseBodyModuleItemsDiscountDescDiscountDetail> DiscountDetail { get; set; }
                    public class HotelSearchResponseBodyModuleItemsDiscountDescDiscountDetail : TeaModel {
                        /// <summary>
                        /// <para>The discount name. Not returned if empty.</para>
                        /// </summary>
                        [NameInMap("label_name")]
                        [Validation(Required=false)]
                        public List<string> LabelName { get; set; }

                        /// <summary>
                        /// <para>The discount amount details.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-¥3</para>
                        /// </summary>
                        [NameInMap("money_desc")]
                        [Validation(Required=false)]
                        public string MoneyDesc { get; set; }

                    }

                    /// <summary>
                    /// <para>The discount detail subtitle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>最终优惠以下单页为准</para>
                    /// </summary>
                    [NameInMap("sub_title")]
                    [Validation(Required=false)]
                    public string SubTitle { get; set; }

                    /// <summary>
                    /// <para>The discount title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>每晚优惠说明</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The distance from the specified location. Unit: meters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("distance")]
                [Validation(Required=false)]
                public int? Distance { get; set; }

                /// <summary>
                /// <para>The district code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("district_code")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

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
                /// <para>The hotel code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>55335212</para>
                /// </summary>
                [NameInMap("hotel_code")]
                [Validation(Required=false)]
                public string HotelCode { get; set; }

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
                /// <para>The hotel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅酒店</para>
                /// </summary>
                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <para>The hotel star rating.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("hotel_star")]
                [Validation(Required=false)]
                public string HotelStar { get; set; }

                /// <summary>
                /// <para>The URL of the hotel main image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i3/6000000000003/O1CN01xkZQR41BtPxK1PQCb_!!6000000000003-0-hotel.jpg">https://img.alicdn.com/imgextra/i3/6000000000003/O1CN01xkZQR41BtPxK1PQCb_!!6000000000003-0-hotel.jpg</a></para>
                /// </summary>
                [NameInMap("image_url")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>Indicates whether the hotel offers a protocol price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                /// <summary>
                /// <para>The hotel coordinates (longitude and latitude).</para>
                /// 
                /// <b>Example:</b>
                /// <para>119.844005,30.054384</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The hotel starting price. Unit: cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("min_price")]
                [Validation(Required=false)]
                public double? MinPrice { get; set; }

                /// <summary>
                /// <para>The price before discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("original_min_price")]
                [Validation(Required=false)]
                public double? OriginalMinPrice { get; set; }

                /// <summary>
                /// <para>The hotel rating score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.2</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The room availability status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The hotel is available for booking.</description></item>
                /// <item><description>1: The hotel is unavailable for booking (fully booked).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The hotel phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571-88886784-8888</para>
                /// </summary>
                [NameInMap("tel")]
                [Validation(Required=false)]
                public string Tel { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
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
