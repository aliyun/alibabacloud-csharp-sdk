// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelAskingPriceResponseBody : TeaModel {
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
        public HotelAskingPriceResponseBodyModule Module { get; set; }
        public class HotelAskingPriceResponseBodyModule : TeaModel {
            [NameInMap("hotel_asking_price_details")]
            [Validation(Required=false)]
            public List<HotelAskingPriceResponseBodyModuleHotelAskingPriceDetails> HotelAskingPriceDetails { get; set; }
            public class HotelAskingPriceResponseBodyModuleHotelAskingPriceDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>652302</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

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

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("min_price")]
                [Validation(Required=false)]
                public double? MinPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("original_min_price")]
                [Validation(Required=false)]
                public double? OriginalMinPrice { get; set; }

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
        /// <para>210bcc3a16583004579056128d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
