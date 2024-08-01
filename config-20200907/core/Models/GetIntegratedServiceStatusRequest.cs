// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetIntegratedServiceStatusRequest : TeaModel {
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

    }

}
