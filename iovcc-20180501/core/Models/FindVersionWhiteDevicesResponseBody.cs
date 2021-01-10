// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindVersionWhiteDevicesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public FindVersionWhiteDevicesResponseBodyDeviceList DeviceList { get; set; }
        public class FindVersionWhiteDevicesResponseBodyDeviceList : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindVersionWhiteDevicesResponseBodyDeviceListItems> Items { get; set; }
            public class FindVersionWhiteDevicesResponseBodyDeviceListItems : TeaModel {
                public long? GmtCreateTimestamp { get; set; }
                public string OriginalId { get; set; }
                public string DeviceId { get; set; }
                public string IdType { get; set; }
                public string GmtCreate { get; set; }
                public long? Id { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
