// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListVirtualMFADevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para> This parameter is returned only when <c>IsTruncated</c> is <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32272612-DF82-485E-8BA9-AFA4E0C3D0BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the MFA device.</para>
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
                /// <para>The time when the MFA device was activated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-16T06:02:09Z</para>
                /// </summary>
                [NameInMap("ActivateDate")]
                [Validation(Required=false)]
                public string ActivateDate { get; set; }

                /// <summary>
                /// <para>The serial number of the MFA device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::177242285274****:mfa/test</para>
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// <para>The information of the RAM user that has an MFA device bound.</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADeviceUser User { get; set; }
                public class ListVirtualMFADevicesResponseBodyVirtualMFADevicesVirtualMFADeviceUser : TeaModel {
                    /// <summary>
                    /// <para>The display name of the RAM user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The ID of the RAM user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20732900249392****</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <para>The logon name of the RAM user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test@177242285274****.onaliyun.com</para>
                    /// </summary>
                    [NameInMap("UserPrincipalName")]
                    [Validation(Required=false)]
                    public string UserPrincipalName { get; set; }

                }

            }

        }

    }

}
