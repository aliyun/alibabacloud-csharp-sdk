// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelAskingPriceResponseBody : TeaModel {
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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The module information.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelAskingPriceResponseBodyModule Module { get; set; }
        public class HotelAskingPriceResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of hotel prices.</para>
            /// </summary>
            [NameInMap("hotel_asking_price_details")]
            [Validation(Required=false)]
            public List<HotelAskingPriceResponseBodyModuleHotelAskingPriceDetails> HotelAskingPriceDetails { get; set; }
            public class HotelAskingPriceResponseBodyModuleHotelAskingPriceDetails : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>652302</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

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
                /// <para>The hotel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅酒店</para>
                /// </summary>
                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <para>Indicates whether the price is a contracted price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                /// <summary>
                /// <para>The starting price of the hotel.</para>
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
                /// <para>100</para>
                /// </summary>
                [NameInMap("original_min_price")]
                [Validation(Required=false)]
                public double? OriginalMinPrice { get; set; }

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
        /// <para>210bcc3a16583004579056128d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
