// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetTrailStatusResponseBody : TeaModel {
        [NameInMap("IsLogging")]
        [Validation(Required=false)]
        public bool? IsLogging { get; set; }

        [NameInMap("LatestDeliveryError")]
        [Validation(Required=false)]
        public string LatestDeliveryError { get; set; }

        [NameInMap("LatestDeliveryLogServiceError")]
        [Validation(Required=false)]
        public string LatestDeliveryLogServiceError { get; set; }

        [NameInMap("LatestDeliveryLogServiceTime")]
        [Validation(Required=false)]
        public string LatestDeliveryLogServiceTime { get; set; }

        [NameInMap("LatestDeliveryTime")]
        [Validation(Required=false)]
        public string LatestDeliveryTime { get; set; }

        [NameInMap("OssBucketStatus")]
        [Validation(Required=false)]
        public bool? OssBucketStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlsLogStoreStatus")]
        [Validation(Required=false)]
        public bool? SlsLogStoreStatus { get; set; }

        [NameInMap("StartLoggingTime")]
        [Validation(Required=false)]
        public string StartLoggingTime { get; set; }

        [NameInMap("StopLoggingTime")]
        [Validation(Required=false)]
        public string StopLoggingTime { get; set; }

    }

}
