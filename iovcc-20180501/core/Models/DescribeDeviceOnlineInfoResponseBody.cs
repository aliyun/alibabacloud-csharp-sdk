// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeDeviceOnlineInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<DescribeDeviceOnlineInfoResponseBodyDevices> Devices { get; set; }
        public class DescribeDeviceOnlineInfoResponseBodyDevices : TeaModel {
            [NameInMap("LoginTime")]
            [Validation(Required=false)]
            public long? LoginTime { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("Online")]
            [Validation(Required=false)]
            public int? Online { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("IasId")]
            [Validation(Required=false)]
            public string IasId { get; set; }

            [NameInMap("SystemVersion")]
            [Validation(Required=false)]
            public string SystemVersion { get; set; }

            [NameInMap("Terminal")]
            [Validation(Required=false)]
            public string Terminal { get; set; }

            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

        }

    }

}
