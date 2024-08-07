// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ModifyLosslessRuleRequest : TeaModel {
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
        /// Specifies whether to align the lifecycle of the application in the Kubernetes cluster with that of the microservice.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Aligned")]
        [Validation(Required=false)]
        public bool? Aligned { get; set; }

        /// <summary>
        /// The ID of the application.
        /// 
        /// This parameter is required.
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
        /// The registration latency.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public int? DelayTime { get; set; }

        /// <summary>
        /// Specifies whether to enable the alert rule. Valid values:
        /// 
        /// *   `true`: enables the rule.
        /// *   `false`: disables the rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The slope of the prefetching curve.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FuncType")]
        [Validation(Required=false)]
        public int? FuncType { get; set; }

        /// <summary>
        /// Specifies whether to display online and offline processing details.
        /// </summary>
        [NameInMap("LossLessDetail")]
        [Validation(Required=false)]
        public bool? LossLessDetail { get; set; }

        /// <summary>
        /// The microservice namespace to which the rule applies.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Specifies whether to enable notification.
        /// </summary>
        [NameInMap("Notice")]
        [Validation(Required=false)]
        public bool? Notice { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to associate with service prefetching.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Related")]
        [Validation(Required=false)]
        public bool? Related { get; set; }

        /// <summary>
        /// The prefetching duration.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WarmupTime")]
        [Validation(Required=false)]
        public int? WarmupTime { get; set; }

    }

}
