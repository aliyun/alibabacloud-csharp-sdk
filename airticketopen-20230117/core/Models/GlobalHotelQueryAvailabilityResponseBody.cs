// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelQueryAvailabilityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelQueryAvailabilityResponseBodyData Data { get; set; }
        public class GlobalHotelQueryAvailabilityResponseBodyData : TeaModel {
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
