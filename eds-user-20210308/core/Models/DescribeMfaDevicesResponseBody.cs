// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeMfaDevicesResponseBody : TeaModel {
        /// <summary>
        /// Details about the virtual MFA devices.
        /// </summary>
        [NameInMap("MfaDevices")]
        [Validation(Required=false)]
        public List<DescribeMfaDevicesResponseBodyMfaDevices> MfaDevices { get; set; }
        public class DescribeMfaDevicesResponseBodyMfaDevices : TeaModel {
            /// <summary>
            /// The number of consecutive failures to bind the virtual MFA device, or the number of MFA failures based on the virtual MFA device.
            /// </summary>
            [NameInMap("ConsecutiveFails")]
            [Validation(Required=false)]
            public int? ConsecutiveFails { get; set; }

            /// <summary>
            /// The types of the virtual MFA device. Set the value to TOTP_VIRTUAL, which indicates that the virtual MFA devices follow the Time-based One-time Password (TOTP) algorithm.
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// This parameter is unavailable.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// The username of the convenience user that uses the virtual MFA device.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The time when the virtual MFA device was enabled. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtEnabled")]
            [Validation(Required=false)]
            public string GmtEnabled { get; set; }

            /// <summary>
            /// The time when a locked virtual MFA device is automatically unlocked. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtUnlock")]
            [Validation(Required=false)]
            public string GmtUnlock { get; set; }

            /// <summary>
            /// This parameter is unavailable.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The serial number of the virtual MFA device, which is a unique identifier.
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// The status of the virtual MFA device. Valid values:
            /// 
            /// *   UNBOUND
            /// *   NORMAL
            /// *   LOCKED
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
