// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class GeoCodeResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GeoCodeResponseBodyData> Data { get; set; }
        public class GeoCodeResponseBodyData : TeaModel {
            [NameInMap("building")]
            [Validation(Required=false)]
            public GeoCodeResponseBodyDataBuilding Building { get; set; }
            public class GeoCodeResponseBodyDataBuilding : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>timeliness_ms</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>internal</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("city")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("district")]
            [Validation(Required=false)]
            public string District { get; set; }

            [NameInMap("districtCode")]
            [Validation(Required=false)]
            public string DistrictCode { get; set; }

            [NameInMap("latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12201281024024</para>
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            [NameInMap("province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("street")]
            [Validation(Required=false)]
            public string Street { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Pop sign mismatch, please check log.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
