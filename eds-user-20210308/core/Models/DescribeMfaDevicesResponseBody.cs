// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeMfaDevicesResponseBody : TeaModel {
        /// <summary>
        /// The information about the virtual MFA devices.
        /// </summary>
        [NameInMap("MfaDevices")]
        [Validation(Required=false)]
        public List<DescribeMfaDevicesResponseBodyMfaDevices> MfaDevices { get; set; }
        public class DescribeMfaDevicesResponseBodyMfaDevices : TeaModel {
            /// <summary>
            /// The number of consecutive failures to bind the virtual MFA device, or the number of authentication failures based on the virtual MFA device.
            /// </summary>
            [NameInMap("ConsecutiveFails")]
            [Validation(Required=false)]
            public int? ConsecutiveFails { get; set; }

            /// <summary>
            /// The type of the virtual MFA device. The value can only be TOTP_VIRTUAL. This value indicates that the virtual MFA device follows the Time-based One-time Password (TOTP) algorithm.
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// >  This parameter is not publicly available.
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
            /// The time when the locked virtual MFA device was automatically unlocked. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtUnlock")]
            [Validation(Required=false)]
            public string GmtUnlock { get; set; }

            /// <summary>
            /// >  This parameter is not publicly available.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The serial number of the virtual MFA device. The serial number is unique for each device.
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// The status of the virtual MFA device.
            /// 
            /// Valid values:
            /// 
            /// *   LOCKED
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   UNBOUND
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NORMAL
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
