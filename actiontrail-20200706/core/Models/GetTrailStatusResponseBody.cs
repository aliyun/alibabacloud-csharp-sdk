// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetTrailStatusResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether logging is enabled for the trail. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IsLogging")]
        [Validation(Required=false)]
        public bool? IsLogging { get; set; }

        /// <summary>
        /// The log of the last failed delivery.
        /// </summary>
        [NameInMap("LatestDeliveryError")]
        [Validation(Required=false)]
        public string LatestDeliveryError { get; set; }

        /// <summary>
        /// The log of the last failed delivery to Log Service.
        /// </summary>
        [NameInMap("LatestDeliveryLogServiceError")]
        [Validation(Required=false)]
        public string LatestDeliveryLogServiceError { get; set; }

        /// <summary>
        /// The most recent time when an event was delivered to Log Service.
        /// </summary>
        [NameInMap("LatestDeliveryLogServiceTime")]
        [Validation(Required=false)]
        public string LatestDeliveryLogServiceTime { get; set; }

        /// <summary>
        /// The most recent time when an event was delivered by the trail.
        /// </summary>
        [NameInMap("LatestDeliveryTime")]
        [Validation(Required=false)]
        public string LatestDeliveryTime { get; set; }

        /// <summary>
        /// Indicates whether the destination Object Storage Service (OSS) bucket is available. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("OssBucketStatus")]
        [Validation(Required=false)]
        public bool? OssBucketStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the destination Log Service Logstore is available. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("SlsLogStoreStatus")]
        [Validation(Required=false)]
        public bool? SlsLogStoreStatus { get; set; }

        /// <summary>
        /// The time when logging was last enabled for the trail.
        /// </summary>
        [NameInMap("StartLoggingTime")]
        [Validation(Required=false)]
        public string StartLoggingTime { get; set; }

        /// <summary>
        /// The time when logging was last disabled for the trail.
        /// </summary>
        [NameInMap("StopLoggingTime")]
        [Validation(Required=false)]
        public string StopLoggingTime { get; set; }

    }

}
