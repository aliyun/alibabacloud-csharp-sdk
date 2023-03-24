// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateVirtualMFADeviceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the MFA device.
        /// </summary>
        [NameInMap("VirtualMFADevice")]
        [Validation(Required=false)]
        public CreateVirtualMFADeviceResponseBodyVirtualMFADevice VirtualMFADevice { get; set; }
        public class CreateVirtualMFADeviceResponseBodyVirtualMFADevice : TeaModel {
            /// <summary>
            /// The key of the MFA device.
            /// </summary>
            [NameInMap("Base32StringSeed")]
            [Validation(Required=false)]
            public string Base32StringSeed { get; set; }

            /// <summary>
            /// The Base64-encoded QR code of the key.
            /// </summary>
            [NameInMap("QRCodePNG")]
            [Validation(Required=false)]
            public string QRCodePNG { get; set; }

            /// <summary>
            /// The serial number of the MFA device.
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

        }

    }

}
