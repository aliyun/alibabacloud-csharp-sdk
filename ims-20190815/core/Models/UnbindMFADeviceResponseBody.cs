// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
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
            /// <para>acs:ram::151298381312****:mfa/device001</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A26CB3E9-1021-452A-AC57-3134B3BA0E4C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
