// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindPrepublishPassedDevicesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public FindPrepublishPassedDevicesResponseBodyDeviceList DeviceList { get; set; }
        public class FindPrepublishPassedDevicesResponseBodyDeviceList : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindPrepublishPassedDevicesResponseBodyDeviceListItems> Items { get; set; }
            public class FindPrepublishPassedDevicesResponseBodyDeviceListItems : TeaModel {
                public string DeviceId { get; set; }
                public string GmtCreate { get; set; }
                public long? GmtCreateTimestamp { get; set; }
            }
        };

    }

}
