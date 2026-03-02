// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateVirtualMFADeviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VirtualMFADevice")]
        [Validation(Required=false)]
        public CreateVirtualMFADeviceResponseBodyVirtualMFADevice VirtualMFADevice { get; set; }
        public class CreateVirtualMFADeviceResponseBodyVirtualMFADevice : TeaModel {
            [NameInMap("Base32StringSeed")]
            [Validation(Required=false)]
            public string Base32StringSeed { get; set; }

            [NameInMap("QRCodePNG")]
            [Validation(Required=false)]
            public string QRCodePNG { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

        }

    }

}
