// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class UnbindMFADeviceResponseBody : TeaModel {
        /// <summary>
        /// The information of the MFA device.
        /// </summary>
        [NameInMap("MFADevice")]
        [Validation(Required=false)]
        public UnbindMFADeviceResponseBodyMFADevice MFADevice { get; set; }
        public class UnbindMFADeviceResponseBodyMFADevice : TeaModel {
            /// <summary>
            /// The serial number of the MFA device.
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
