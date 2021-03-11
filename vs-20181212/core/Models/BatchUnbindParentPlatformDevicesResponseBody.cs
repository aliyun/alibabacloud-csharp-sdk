// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchUnbindParentPlatformDevicesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<BatchUnbindParentPlatformDevicesResponseBodyResults> Results { get; set; }
        public class BatchUnbindParentPlatformDevicesResponseBodyResults : TeaModel {
            [NameInMap("ParentPlatformId")]
            [Validation(Required=false)]
            public string ParentPlatformId { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

        }

    }

}
