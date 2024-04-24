// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResponseCodeTrendGraphResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The array of the statistics of the error codes.
        /// </summary>
        [NameInMap("ResponseCodes")]
        [Validation(Required=false)]
        public List<DescribeResponseCodeTrendGraphResponseBodyResponseCodes> ResponseCodes { get; set; }
        public class DescribeResponseCodeTrendGraphResponseBodyResponseCodes : TeaModel {
            /// <summary>
            /// The number of 302 error codes that are returned.
            /// </summary>
            [NameInMap("302Pv")]
            [Validation(Required=false)]
            public long? Code302Pv { get; set; }

            /// <summary>
            /// The number of 405 error codes that are returned.
            /// </summary>
            [NameInMap("405Pv")]
            [Validation(Required=false)]
            public long? Code405Pv { get; set; }

            /// <summary>
            /// The number of 444 error codes that are returned.
            /// </summary>
            [NameInMap("444Pv")]
            [Validation(Required=false)]
            public long? Code444Pv { get; set; }

            /// <summary>
            /// The number of 499 error codes that are returned.
            /// </summary>
            [NameInMap("499Pv")]
            [Validation(Required=false)]
            public long? Code499Pv { get; set; }

            /// <summary>
            /// The number of 5xx error codes that are returned.
            /// </summary>
            [NameInMap("5xxPv")]
            [Validation(Required=false)]
            public long? Code5xxPv { get; set; }

            /// <summary>
            /// The serial number of the time interval. The serial numbers are arranged in chronological order.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

        }

    }

}
