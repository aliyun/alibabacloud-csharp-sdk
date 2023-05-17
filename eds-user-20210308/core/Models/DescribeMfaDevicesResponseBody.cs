// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeMfaDevicesResponseBody : TeaModel {
        /// <summary>
        /// The serial number of the virtual MFA device, which is a unique identifier.
        /// </summary>
        [NameInMap("MfaDevices")]
        [Validation(Required=false)]
        public List<DescribeMfaDevicesResponseBodyMfaDevices> MfaDevices { get; set; }
        public class DescribeMfaDevicesResponseBodyMfaDevices : TeaModel {
            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("ConsecutiveFails")]
            [Validation(Required=false)]
            public int? ConsecutiveFails { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// The username of the convenience user that uses the virtual MFA device.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// The types of the virtual MFA device. Set the value to TOTP_VIRTUAL, which indicates that the virtual MFA devices follow the Time-based One-time Password (TOTP) algorithm.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The serial numbers of the virtual MFA devices.
            /// </summary>
            [NameInMap("GmtEnabled")]
            [Validation(Required=false)]
            public string GmtEnabled { get; set; }

            /// <summary>
            /// The serial number of the virtual MFA device, which is a unique identifier.
            /// </summary>
            [NameInMap("GmtUnlock")]
            [Validation(Required=false)]
            public string GmtUnlock { get; set; }

            /// <summary>
            /// The maximum number of entries to return. Valid values: 1 to 500.
            /// 
            /// Default value: 100.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Queries the information about virtual MFA devices that are bound to convenience users.
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The operation that you want to perform. Set the value to DescribeMfaDevices.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// This parameter is unavailable.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
