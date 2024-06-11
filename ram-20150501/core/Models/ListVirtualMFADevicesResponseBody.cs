// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListVirtualMFADevicesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of MFA devices.
        /// </summary>
        [NameInMap("VirtualMFADevices")]
        [Validation(Required=false)]
        public ListVirtualMFADevicesResponseBodyVirtualMFADevices VirtualMFADevices { get; set; }
        public class ListVirtualMFADevicesResponseBodyVirtualMFADevices : TeaModel {
            [NameInMap("VirtualMFADevice")]
            [Validation(Required=false)]
            public List<ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADevice> VirtualMFADevice { get; set; }
            public class ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADevice : TeaModel {
                /// <summary>
                /// The time when the MFA device was enabled.
                /// </summary>
                [NameInMap("ActivateDate")]
                [Validation(Required=false)]
                public string ActivateDate { get; set; }

                /// <summary>
                /// The serial number of the MFA device.
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// The basic information of the RAM user to which the MFA device is attached.
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADeviceUser User { get; set; }
                public class ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADeviceUser : TeaModel {
                    /// <summary>
                    /// The display name of the RAM user.
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// The unique ID of the RAM user.
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// The name of the RAM user.
                    /// </summary>
                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

        }

    }

}
