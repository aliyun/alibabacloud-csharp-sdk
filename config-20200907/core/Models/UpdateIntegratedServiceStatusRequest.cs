// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateIntegratedServiceStatusRequest : TeaModel {
        /// <summary>
        /// The types of the integrated events. Separate multiple event types with commas (,). Valid values:
        /// 
        /// *   ConfigurationItemChangeNotification: resource change event
        /// *   NonCompliantNotification: non-compliance event
        /// </summary>
        [NameInMap("IntegratedTypes")]
        [Validation(Required=false)]
        public string IntegratedTypes { get; set; }

        /// <summary>
        /// The identity of the cloud service that is integrated with Cloud Config. Valid values:
        /// 
        /// *   eventbridge: EventBridge
        /// *   cms: CloudMonitor
        /// *   bpstudio: Cloud Architect Design Tools
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Specifies whether you want the product to be integrated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
