// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GetDeviceAppUpdateFunnelEventsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<GetDeviceAppUpdateFunnelEventsResponseBodyEventList> EventList { get; set; }
        public class GetDeviceAppUpdateFunnelEventsResponseBodyEventList : TeaModel {
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("TargetVersionCode")]
            [Validation(Required=false)]
            public string TargetVersionCode { get; set; }

            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("ReportTime")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            [NameInMap("ReportTimestamp")]
            [Validation(Required=false)]
            public long? ReportTimestamp { get; set; }

        }

    }

}
