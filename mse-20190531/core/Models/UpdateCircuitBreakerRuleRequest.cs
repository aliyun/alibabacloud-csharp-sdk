// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateCircuitBreakerRuleRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values: zh-CN and en-US. Default value: zh-CN. The value zh-CN indicates Chinese, and the value en-US indicates English.
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
        /// The name of the application.
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
        /// The period in which circuit breaking is implemented. Unit: milliseconds. If circuit breaking is implemented on the requests for the route, the calls to all the requests for the route fail in the configured circuit breaking period. The value must be an integral multiple of 1,000. Default value: 10000. This value indicates 10 seconds.
        /// </summary>
        [NameInMap("RetryTimeoutMs")]
        [Validation(Required=false)]
        public int? RetryTimeoutMs { get; set; }

        /// <summary>
        /// The rule ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

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

}
