// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The pagination cursor.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The returned data contains a JSON string that may consist of several or all of the following parameters:
        /// 
        /// *   Error4XXRate: the percentage of detection results with 4XX status codes.
        /// *   Error6XXRate: the percentage of detection results with 6XX status codes.
        /// *   Error5XXRate: the percentage of detection results with 5XX status codes.
        /// *   Error4XXNumber: the number of detection results with 4XX status codes.
        /// *   Error5XXNumber: the number of detection results with 5XX status codes.
        /// *   Error6XXNumber: the number of detection results with 6XX status codes.
        /// *   Over5totalTime: the percentage of detection requests to which the response time exceeds 5,000 ms.
        /// *   Over3totalTime: the percentage of detection requests to which the response time exceeds 3,000 ms.
        /// *   Over2totalTime: the percentage of detection requests to which the response time exceeds 2,000 ms.
        /// *   Over10FailureRate: the percentage of detection points whose failure rate of detection requests exceeds 10%.
        /// *   Over100FailureRate: the percentage of detection points whose failure rate of detection requests exceeds 99%.
        /// *   Over30FailureRate: the percentage of detection points whose failure rate of detection requests exceeds 30%.
        /// *   Over50FailureRate: the percentage of detection points whose failure rate of detection requests exceeds 50%.
        /// *   Over80FailureRate: the percentage of detection points whose failure rate of detection requests exceeds 80%.
        /// *   Over90FailureRate: the percentage of detection points whose failure rate of detection requests exceeds 90%.
        /// *   Over400NumberRate: the percentage of detection results with status codes that are greater than 400.
        /// *   Over400NumberRate: the percentage of detection results with status codes that are greater than 500.
        /// *   AvailableNumber: the number of detection results in which the status code is smaller than 400.
        /// *   UnavailableNumber: the number of detection results in which the status code is greater than 399.
        /// *   Availability: the percentage of detection results in which the status code is smaller than 400.
        /// *   Unavailability: the percentage of detection results in which the status code is greater than 399.
        /// *   ErrorCodeMaximum: the maximum error code in the detection results that were returned in a specific period. Assume that five status codes are returned in a minute after detection requests are sent from five detection points. The status code in four detection results is 200 and that in one detection result is 404. In this case, the maximum error code is 404.
        /// *   ErrorCodeMinimum: the minimum error code in the detection results returned in a monitoring period. Assume that five status codes are returned in a minute after detection requests are sent from five detection points. The status code in four detection results is 200 and that in one detection result is 404. In this case, the minimum error code is 200.
        /// 
        /// >  We recommend that you use the AvailableNumber, UnavailableNumber, Availability, Unavailability, ErrorCodeMaximum, or ErrorCodeMinimum metric, whose value is easy to calculate.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. The value true indicates a success. The value false indicates a failure.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
