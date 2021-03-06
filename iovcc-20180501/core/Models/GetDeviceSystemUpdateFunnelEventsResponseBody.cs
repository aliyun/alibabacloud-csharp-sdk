// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GetDeviceSystemUpdateFunnelEventsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<GetDeviceSystemUpdateFunnelEventsResponseBodyEventList> EventList { get; set; }
        public class GetDeviceSystemUpdateFunnelEventsResponseBodyEventList : TeaModel {
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("TargetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("ReportTimestamp")]
            [Validation(Required=false)]
            public long? ReportTimestamp { get; set; }

            [NameInMap("ReportTime")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
