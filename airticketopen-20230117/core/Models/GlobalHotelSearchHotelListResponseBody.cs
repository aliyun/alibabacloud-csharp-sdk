// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelSearchHotelListResponseBody : TeaModel {
        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelSearchHotelListResponseBodyData Data { get; set; }
        public class GlobalHotelSearchHotelListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of hotels.</para>
            /// </summary>
            [NameInMap("Hotels")]
            [Validation(Required=false)]
            public List<GlobalHotelSearchHotelListResponseBodyDataHotels> Hotels { get; set; }
            public class GlobalHotelSearchHotelListResponseBodyDataHotels : TeaModel {
                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The country name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <para>The hotel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing Hotel</para>
                /// </summary>
                [NameInMap("HotelName")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <para>The platform standard hotel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>H001</para>
                /// </summary>
                [NameInMap("StandardHotelId")]
                [Validation(Required=false)]
                public string StandardHotelId { get; set; }

                /// <summary>
                /// <para>The hotel status (ONLINE/OFFLINE).</para>
                /// 
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of hotels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CityCodeRequired</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>City code cannot be empty</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>traceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
