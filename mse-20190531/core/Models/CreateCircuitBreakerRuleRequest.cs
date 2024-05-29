// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateCircuitBreakerRuleRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The application name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// Specifies whether to enable the rule.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The minimum number of requests that can be passed in each step after circuit breaking recovers. Default value: 1.
        /// </summary>
        [NameInMap("HalfOpenBaseAmountPerStep")]
        [Validation(Required=false)]
        public int? HalfOpenBaseAmountPerStep { get; set; }

        /// <summary>
        /// The number of circuit breaking recovery steps. Default value: 1.
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
        /// The minimum number of requests to trigger circuit breaking. If the number of requests in the current time window is less than the value of this parameter, circuit breaking is not triggered even if the circuit breaking rule is met. Default value: 10.
        /// </summary>
        [NameInMap("MinRequestAmount")]
        [Validation(Required=false)]
        public int? MinRequestAmount { get; set; }

        /// <summary>
        /// The microservice namespace to which the application belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The region in which the instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the interface to which the rule applies. The interface name must be the same as the name on the interface details page in the console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// The period in which circuit breaking is implemented. Unit: milliseconds. If circuit breaking is implemented on the requests for the route, the calls to all the requests for the route fail in the configured circuit breaking period. The value must be an integral multiple of 1,000. Default value: 10000. This value indicates 10 seconds.
        /// </summary>
        [NameInMap("RetryTimeoutMs")]
        [Validation(Required=false)]
        public int? RetryTimeoutMs { get; set; }

        /// <summary>
        /// The length of the time window. Unit: milliseconds. The valid range is from 1 second to 120 minutes. The default value is 20000. This value indicates 20 seconds.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public int? Strategy { get; set; }

        /// <summary>
        /// A percentage threshold for triggering circuit breaking. Valid values: 0-1. These values represent 0% to 100%.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
