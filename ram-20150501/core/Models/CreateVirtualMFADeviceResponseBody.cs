// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateVirtualMFADeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
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
            /// <para>DSF98HAD982KJA9SDFNAS9D8FU839B8ADHBGS****</para>
            /// </summary>
            [NameInMap("Base32StringSeed")]
            [Validation(Required=false)]
            public string Base32StringSeed { get; set; }

            /// <summary>
            /// <para>The Base64-encoded QR code, in the PNG format.</para>
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
            /// <para>acs:ram::123456789012****:mfa/device001</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

        }

    }

}
