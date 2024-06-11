// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetUserMFAInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the MFA device that is attached to the RAM user.
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
