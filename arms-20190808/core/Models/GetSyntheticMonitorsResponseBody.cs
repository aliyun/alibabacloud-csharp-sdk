// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticMonitorsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The list of monitoring points.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSyntheticMonitorsResponseBodyData> Data { get; set; }
        public class GetSyntheticMonitorsResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the monitoring point is available. Valid values: true and false.
            /// </summary>
            [NameInMap("Available")]
            [Validation(Required=false)]
            public string Available { get; set; }

            /// <summary>
            /// Indicates whether the monitoring point is selected. Valid values: true and false.
            /// </summary>
            [NameInMap("CanBeSelected")]
            [Validation(Required=false)]
            public bool? CanBeSelected { get; set; }

            /// <summary>
            /// The city.
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// The city code.
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// The client type of the monitoring point. Valid values: 1: data center. 2: Internet. 3: mobile device. 4: ECS instance.
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            /// <summary>
            /// The country.
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// Indicates whether IPv6 is supported. Valid values: 0: IPv6 is not supported. 1: IPv6 is supported.
            /// </summary>
            [NameInMap("Ipv6")]
            [Validation(Required=false)]
            public int? Ipv6 { get; set; }

            /// <summary>
            /// The carrier.
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The carrier code.
            /// </summary>
            [NameInMap("OperatorCode")]
            [Validation(Required=false)]
            public string OperatorCode { get; set; }

            /// <summary>
            /// The region.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
