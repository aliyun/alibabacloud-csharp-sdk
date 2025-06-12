// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class UnbindMFADeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the MFA device.</para>
        /// </summary>
        [NameInMap("MFADevice")]
        [Validation(Required=false)]
        public UnbindMFADeviceResponseBodyMFADevice MFADevice { get; set; }
        public class UnbindMFADeviceResponseBodyMFADevice : TeaModel {
            /// <summary>
            /// <para>The serial number of the MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456789012****:mfa/device002</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
