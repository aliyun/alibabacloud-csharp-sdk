// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchBindParentPlatformDevicesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<BatchBindParentPlatformDevicesResponseBodyResults> Results { get; set; }
        public class BatchBindParentPlatformDevicesResponseBodyResults : TeaModel {
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("ParentPlatformId")]
            [Validation(Required=false)]
            public string ParentPlatformId { get; set; }

        }

    }

}
