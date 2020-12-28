// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20171204.Models
{
    public class GetTrailStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartLoggingTime")]
        [Validation(Required=false)]
        public string StartLoggingTime { get; set; }

        [NameInMap("LatestDeliveryError")]
        [Validation(Required=false)]
        public string LatestDeliveryError { get; set; }

        [NameInMap("StopLoggingTime")]
        [Validation(Required=false)]
        public string StopLoggingTime { get; set; }

        [NameInMap("IsLogging")]
        [Validation(Required=false)]
        public bool? IsLogging { get; set; }

        [NameInMap("LatestDeliveryTime")]
        [Validation(Required=false)]
        public string LatestDeliveryTime { get; set; }

    }

}
