// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSearchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
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
        public HotelSearchResponseBodyModule Module { get; set; }
        public class HotelSearchResponseBodyModule : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<HotelSearchResponseBodyModuleItems> Items { get; set; }
            public class HotelSearchResponseBodyModuleItems : TeaModel {
                [NameInMap("brand_name")]
                [Validation(Required=false)]
                public string BrandName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1902</para>
                /// </summary>
                [NameInMap("btand_code")]
                [Validation(Required=false)]
                public string BtandCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("discount_desc")]
                [Validation(Required=false)]
                public HotelSearchResponseBodyModuleItemsDiscountDesc DiscountDesc { get; set; }
                public class HotelSearchResponseBodyModuleItemsDiscountDesc : TeaModel {
                    [NameInMap("cash_reduce_total")]
                    [Validation(Required=false)]
                    public string CashReduceTotal { get; set; }

                    [NameInMap("dinamic_label")]
                    [Validation(Required=false)]
                    public string DinamicLabel { get; set; }

                    [NameInMap("discount_detail")]
                    [Validation(Required=false)]
                    public List<HotelSearchResponseBodyModuleItemsDiscountDescDiscountDetail> DiscountDetail { get; set; }
                    public class HotelSearchResponseBodyModuleItemsDiscountDescDiscountDetail : TeaModel {
                        [NameInMap("label_name")]
                        [Validation(Required=false)]
                        public List<string> LabelName { get; set; }

                        [NameInMap("money_desc")]
                        [Validation(Required=false)]
                        public string MoneyDesc { get; set; }

                    }

                    [NameInMap("sub_title")]
                    [Validation(Required=false)]
                    public string SubTitle { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("distance")]
                [Validation(Required=false)]
                public int? Distance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("district_code")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                [NameInMap("hotel_address")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>55335212</para>
                /// </summary>
                [NameInMap("hotel_code")]
                [Validation(Required=false)]
                public string HotelCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Business travel hotel</para>
                /// </summary>
                [NameInMap("hotel_en_name")]
                [Validation(Required=false)]
                public string HotelEnName { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("hotel_star")]
                [Validation(Required=false)]
                public string HotelStar { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i3/6000000000003/O1CN01xkZQR41BtPxK1PQCb_!!6000000000003-0-hotel.jpg">https://img.alicdn.com/imgextra/i3/6000000000003/O1CN01xkZQR41BtPxK1PQCb_!!6000000000003-0-hotel.jpg</a></para>
                /// </summary>
                [NameInMap("image_url")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>119.844005,30.054384</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("min_price")]
                [Validation(Required=false)]
                public double? MinPrice { get; set; }

                [NameInMap("original_min_price")]
                [Validation(Required=false)]
                public double? OriginalMinPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3.2</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0571-88886784-8888</para>
                /// </summary>
                [NameInMap("tel")]
                [Validation(Required=false)]
                public string Tel { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
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
