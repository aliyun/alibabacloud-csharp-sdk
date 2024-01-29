// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetIntegratedServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the product has been integrated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
