// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListIntegratedServiceResponseBody : TeaModel {
        /// <summary>
        /// The information about the cloud service that can be integrated.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListIntegratedServiceResponseBodyData> Data { get; set; }
        public class ListIntegratedServiceResponseBodyData : TeaModel {
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
            /// The identifier of the cloud service. Valid values:
            /// 
            /// *   eventbridge: EventBridge
            /// *   cms: CloudMonitor
            /// *   bpstudio: Cloud Architect Design Tools
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// The name of the cloud service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The integration status of the cloud service. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
