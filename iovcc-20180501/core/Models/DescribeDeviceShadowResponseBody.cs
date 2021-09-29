// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeDeviceShadowResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceShadow")]
        [Validation(Required=false)]
        public DescribeDeviceShadowResponseBodyDeviceShadow DeviceShadow { get; set; }
        public class DescribeDeviceShadowResponseBodyDeviceShadow : TeaModel {
            [NameInMap("DeviceShadow")]
            [Validation(Required=false)]
            public string DeviceShadow { get; set; }
            [NameInMap("DeviceInfo")]
            [Validation(Required=false)]
            public string DeviceInfo { get; set; }
        };

    }

}
