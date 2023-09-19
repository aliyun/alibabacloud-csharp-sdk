// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogHistogramResponseBody : TeaModel {
        /// <summary>
        /// The number of alert logs that were generated during each interval of a time period.
        /// </summary>
        [NameInMap("AlertLogHistogramList")]
        [Validation(Required=false)]
        public List<DescribeAlertLogHistogramResponseBodyAlertLogHistogramList> AlertLogHistogramList { get; set; }
        public class DescribeAlertLogHistogramResponseBodyAlertLogHistogramList : TeaModel {
            /// <summary>
            /// The number of alert logs.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The start timestamp of the queried alert logs.
            /// 
            /// Unit: seconds.
            /// </summary>
            [NameInMap("From")]
            [Validation(Required=false)]
            public long? From { get; set; }

            /// <summary>
            /// The end timestamp of the queried alert logs.
            /// 
            /// Unit: seconds.
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public long? To { get; set; }

        }

        /// <summary>
        /// The response code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
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
