// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelSearchHotelListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelSearchHotelListResponseBodyData Data { get; set; }
        public class GlobalHotelSearchHotelListResponseBodyData : TeaModel {
            [NameInMap("Hotels")]
            [Validation(Required=false)]
            public List<GlobalHotelSearchHotelListResponseBodyDataHotels> Hotels { get; set; }
            public class GlobalHotelSearchHotelListResponseBodyDataHotels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>北京市</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>中国</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>北京饭店</para>
                /// </summary>
                [NameInMap("HotelName")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>H001</para>
                /// </summary>
                [NameInMap("StandardHotelId")]
                [Validation(Required=false)]
                public string StandardHotelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CityCodeRequired</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>城市编码不能为空</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>traceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
