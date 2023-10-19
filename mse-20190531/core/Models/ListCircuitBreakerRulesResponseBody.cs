// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListCircuitBreakerRulesResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the rule.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCircuitBreakerRulesResponseBodyData Data { get; set; }
        public class ListCircuitBreakerRulesResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The returned result.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListCircuitBreakerRulesResponseBodyDataResult> Result { get; set; }
            public class ListCircuitBreakerRulesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// Indicates whether the rule was enabled.
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// The behavior that was bound to the rule.
                /// </summary>
                [NameInMap("FallbackObject")]
                [Validation(Required=false)]
                public string FallbackObject { get; set; }

                /// <summary>
                /// The minimum number of requests that can be passed in each step after circuit breaking recovers.
                /// </summary>
                [NameInMap("HalfOpenBaseAmountPerStep")]
                [Validation(Required=false)]
                public int? HalfOpenBaseAmountPerStep { get; set; }

                /// <summary>
                /// The number of circuit breaking recovery steps.
                /// </summary>
                [NameInMap("HalfOpenRecoveryStepNum")]
                [Validation(Required=false)]
                public int? HalfOpenRecoveryStepNum { get; set; }

                /// <summary>
                /// The maximum response time (RT). Unit: milliseconds. If the RT of a request is greater than the value of this parameter, a slow call is counted. If you set Strategy to 0, you must specify this parameter.
                /// </summary>
                [NameInMap("MaxAllowedRtMs")]
                [Validation(Required=false)]
                public int? MaxAllowedRtMs { get; set; }

                /// <summary>
                /// The minimum number of requests to trigger circuit breaking. If the number of requests in the current time window is less than the value of this parameter, circuit breaking is not triggered even if the circuit breaking rule is met.
                /// </summary>
                [NameInMap("MinRequestAmount")]
                [Validation(Required=false)]
                public int? MinRequestAmount { get; set; }

                /// <summary>
                /// The microservice namespace to which the application belongs.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The region where the cluster resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the interface to which the rule is applicable. The interface name must be the same as the name on the interface details page in the console.
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                /// <summary>
                /// The period in which circuit breaking is implemented. Unit: milliseconds. If circuit breaking is implemented on the requests for the route, the calls to all the requests for the route fail in the configured circuit breaking period.
                /// </summary>
                [NameInMap("RetryTimeoutMs")]
                [Validation(Required=false)]
                public int? RetryTimeoutMs { get; set; }

                /// <summary>
                /// The ID of the rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// The length of the time window. Unit: milliseconds. The valid range is from 1 second to 120 minutes.
                /// </summary>
                [NameInMap("StatIntervalMs")]
                [Validation(Required=false)]
                public int? StatIntervalMs { get; set; }

                /// <summary>
                /// The threshold type.
                /// 
                /// Valid values:
                /// 
                /// *   0
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     slow call proportion
                /// 
                ///     <!-- -->
                /// 
                /// *   1
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     abnormal proportion
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public int? Strategy { get; set; }

                /// <summary>
                /// A percentage threshold for triggering circuit breaking. Valid values: 0-1. These values represent 0% to 100%.
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

            }

            /// <summary>
            /// The total number of pages.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
