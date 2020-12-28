// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateVirtualMFADeviceResponseBody : TeaModel {
        [NameInMap("VirtualMFADevice")]
        [Validation(Required=false)]
        public CreateVirtualMFADeviceResponseBodyVirtualMFADevice VirtualMFADevice { get; set; }
        public class CreateVirtualMFADeviceResponseBodyVirtualMFADevice : TeaModel {
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }
            [NameInMap("QRCodePNG")]
            [Validation(Required=false)]
            public string QRCodePNG { get; set; }
            [NameInMap("Base32StringSeed")]
            [Validation(Required=false)]
            public string Base32StringSeed { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
