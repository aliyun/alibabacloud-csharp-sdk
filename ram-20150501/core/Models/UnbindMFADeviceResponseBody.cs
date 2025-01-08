// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class UnbindMFADeviceResponseBody : TeaModel {
        [NameInMap("MFADevice")]
        [Validation(Required=false)]
        public UnbindMFADeviceResponseBodyMFADevice MFADevice { get; set; }
        public class UnbindMFADeviceResponseBodyMFADevice : TeaModel {
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
