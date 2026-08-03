// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class QueryCalendarAvailabilityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCalendarAvailabilityResponseBodyData Data { get; set; }
        public class QueryCalendarAvailabilityResponseBodyData : TeaModel {
            [NameInMap("FailedHotels")]
            [Validation(Required=false)]
            public List<QueryCalendarAvailabilityResponseBodyDataFailedHotels> FailedHotels { get; set; }
            public class QueryCalendarAvailabilityResponseBodyDataFailedHotels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>HOTEL_NOT_FOUND</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>酒店不存在</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>H001</para>
                /// </summary>
                [NameInMap("StandardHotelId")]
                [Validation(Required=false)]
                public string StandardHotelId { get; set; }

            }

            [NameInMap("Hotels")]
            [Validation(Required=false)]
            public Dictionary<string, List<DataHotelsValue>> Hotels { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TraceId</para>
            /// </summary>
            [NameInMap("TracerId")]
            [Validation(Required=false)]
            public string TracerId { get; set; }

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
        /// <para>TraceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
