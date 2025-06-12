// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListVirtualMFADevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the MFA devices.</para>
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
                /// <para>The time when the MFA device was enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-02-18T17:22:08Z</para>
                /// </summary>
                [NameInMap("ActivateDate")]
                [Validation(Required=false)]
                public string ActivateDate { get; set; }

                /// <summary>
                /// <para>The serial number of the MFA device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::123456789012****:mfa/device002</para>
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// <para>The basic information about the Resource Access Management (RAM) user to which the MFA device is bound.</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADeviceUser User { get; set; }
                public class ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADeviceUser : TeaModel {
                    /// <summary>
                    /// <para>The display name of the RAM user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhangq****</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the RAM user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>122748924538****</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <para>The name of the RAM user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhangq****</para>
                    /// </summary>
                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

        }

    }

}
