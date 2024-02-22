// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCustomizeRuleTestHistogramResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The return value for the request.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeCustomizeRuleTestHistogramResponseBodyData> Data { get; set; }
        public class DescribeCustomizeRuleTestHistogramResponseBodyData : TeaModel {
            /// <summary>
            /// The number of alerts that are generated in the query time range.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The start of the time range for querying alerts. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("From")]
            [Validation(Required=false)]
            public long? From { get; set; }

            /// <summary>
            /// The end of the time range for querying alerts. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public long? To { get; set; }

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

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
