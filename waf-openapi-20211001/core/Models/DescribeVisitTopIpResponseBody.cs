// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeVisitTopIpResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The array of the top 10 IP addresses from which requests are sent.
        /// </summary>
        [NameInMap("TopIp")]
        [Validation(Required=false)]
        public List<DescribeVisitTopIpResponseBodyTopIp> TopIp { get; set; }
        public class DescribeVisitTopIpResponseBodyTopIp : TeaModel {
            /// <summary>
            /// The ordinal number of the area to which the IP address belongs.
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// The total number of requests that are sent from the IP address.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The ISP.
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

        }

    }

}
