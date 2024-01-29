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
        /// The product code of the cloud product. Valid values:
        /// 
        /// *   cadt: Cloud Architecture Design Tool
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Specifies whether you want the product to be integrated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
