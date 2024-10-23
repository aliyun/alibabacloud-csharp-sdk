// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetUserMFAInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the MFA device is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsMFAEnable")]
        [Validation(Required=false)]
        public bool? IsMFAEnable { get; set; }

        /// <summary>
        /// <para>The information about the MFA device.</para>
        /// </summary>
        [NameInMap("MFADevice")]
        [Validation(Required=false)]
        public GetUserMFAInfoResponseBodyMFADevice MFADevice { get; set; }
        public class GetUserMFAInfoResponseBodyMFADevice : TeaModel {
            /// <summary>
            /// <para>The serial number of the MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::177242285274****:mfa/device001</para>
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
        /// <para>FCF7322A-20A9-4F68-8B7F-F86958839BC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
