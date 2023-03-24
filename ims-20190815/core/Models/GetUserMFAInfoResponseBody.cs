// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetUserMFAInfoResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the MFA device is enabled. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IsMFAEnable")]
        [Validation(Required=false)]
        public bool? IsMFAEnable { get; set; }

        /// <summary>
        /// The information about the MFA device.
        /// </summary>
        [NameInMap("MFADevice")]
        [Validation(Required=false)]
        public GetUserMFAInfoResponseBodyMFADevice MFADevice { get; set; }
        public class GetUserMFAInfoResponseBodyMFADevice : TeaModel {
            /// <summary>
            /// The serial number of the MFA device.
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// The type of the MFA device. Valid values:
            /// 
            /// *   VMFA: virtual MFA device
            /// *   U2F: Universal 2nd Factor (U2F) security key
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
