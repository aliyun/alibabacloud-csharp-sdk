// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogHistogramResponseBody : TeaModel {
        /// <summary>
        /// The end timestamp of queried alert logs in an interval. Unit: seconds.
        /// </summary>
        [NameInMap("AlertLogHistogramList")]
        [Validation(Required=false)]
        public List<DescribeAlertLogHistogramResponseBodyAlertLogHistogramList> AlertLogHistogramList { get; set; }
        public class DescribeAlertLogHistogramResponseBodyAlertLogHistogramList : TeaModel {
            /// <summary>
            /// For more information about common request parameters, see [Common parameters](~~199331~~).
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The number of alert logs.
            /// </summary>
            [NameInMap("From")]
            [Validation(Required=false)]
            public long? From { get; set; }

            /// <summary>
            /// This topic provides an example on how to query the number of alert logs of Elastic Compute Service (ECS) from the cloud service dimension.
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public long? To { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The details about the number of alert logs that were generated during each interval of a time period.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start timestamp of queried alert logs in an interval. Unit: seconds.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
