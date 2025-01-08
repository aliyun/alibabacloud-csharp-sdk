// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetUserMFAInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the MFA device that is attached to the RAM user.</para>
        /// </summary>
        [NameInMap("MFADevice")]
        [Validation(Required=false)]
        public GetUserMFAInfoResponseBodyMFADevice MFADevice { get; set; }
        public class GetUserMFAInfoResponseBodyMFADevice : TeaModel {
            /// <summary>
            /// <para>The serial number of the MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::177242285274****:mfa/test</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The type of the MFA device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>VMFA: virtual MFA device</description></item>
            /// <item><description>U2F: Universal 2nd Factor (U2F) security key</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VMFA</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
