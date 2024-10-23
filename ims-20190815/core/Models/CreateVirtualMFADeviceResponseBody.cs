// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateVirtualMFADeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C609CC97-10FE-43EB-BE32-BDC219D8F1E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the MFA device.</para>
        /// </summary>
        [NameInMap("VirtualMFADevice")]
        [Validation(Required=false)]
        public CreateVirtualMFADeviceResponseBodyVirtualMFADevice VirtualMFADevice { get; set; }
        public class CreateVirtualMFADeviceResponseBodyVirtualMFADevice : TeaModel {
            /// <summary>
            /// <para>The key of the MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LD3CJ23Z2VGEX6R7ZTQCOA4XL2KODS5PKH7442NLKYX2PVHSHYB7UT3TS5HA****</para>
            /// </summary>
            [NameInMap("Base32StringSeed")]
            [Validation(Required=false)]
            public string Base32StringSeed { get; set; }

            /// <summary>
            /// <para>The Base64-encoded QR code of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YXNkZmFzZDlmeW5hc2Q5OGZoODd4bXJmcThhaGU5aSBmYXNkZiBzYWRmIGFGIDRxd2VjIGEgdHEz****</para>
            /// </summary>
            [NameInMap("QRCodePNG")]
            [Validation(Required=false)]
            public string QRCodePNG { get; set; }

            /// <summary>
            /// <para>The serial number of the MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::177242285274****:mfa/device001</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

        }

    }

}
