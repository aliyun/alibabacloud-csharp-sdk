// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogCountResponseBody : TeaModel {
        /// <summary>
        /// The statistics of alert logs.
        /// </summary>
        [NameInMap("AlertLogCount")]
        [Validation(Required=false)]
        public List<DescribeAlertLogCountResponseBodyAlertLogCount> AlertLogCount { get; set; }
        public class DescribeAlertLogCountResponseBodyAlertLogCount : TeaModel {
            /// <summary>
            /// The number of alert logs.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The details about alert logs.
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeAlertLogCountResponseBodyAlertLogCountLogs> Logs { get; set; }
            public class DescribeAlertLogCountResponseBodyAlertLogCountLogs : TeaModel {
                /// <summary>
                /// The name of the dimension field based on which alert logs are aggregated.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the dimension field based on which alert logs are aggregated.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
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
