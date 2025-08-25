// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVirtualMFADevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL23as</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FB550AAB-FB36-4A91-93F6-F4374AF65403</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the virtual MFA devices.</para>
        /// </summary>
        [NameInMap("VirtualMFADevices")]
        [Validation(Required=false)]
        public List<DescribeVirtualMFADevicesResponseBodyVirtualMFADevices> VirtualMFADevices { get; set; }
        public class DescribeVirtualMFADevicesResponseBodyVirtualMFADevices : TeaModel {
            [NameInMap("AdUser")]
            [Validation(Required=false)]
            public DescribeVirtualMFADevicesResponseBodyVirtualMFADevicesAdUser AdUser { get; set; }
            public class DescribeVirtualMFADevicesResponseBodyVirtualMFADevicesAdUser : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("DisplayNameNew")]
                [Validation(Required=false)]
                public string DisplayNameNew { get; set; }

                [NameInMap("EndUser")]
                [Validation(Required=false)]
                public string EndUser { get; set; }

                [NameInMap("UserPrincipalName")]
                [Validation(Required=false)]
                public string UserPrincipalName { get; set; }

            }

            /// <summary>
            /// <para>The number of consecutive failures to bind the virtual MFA device, or the number of failures on the verification of the virtual MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ConsecutiveFails")]
            [Validation(Required=false)]
            public int? ConsecutiveFails { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-gx2x1dhsmu52rd****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The name of the AD user who uses the virtual MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usertest</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The time when the virtual MFA device was started. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-20T14:52:28Z</para>
            /// </summary>
            [NameInMap("GmtEnabled")]
            [Validation(Required=false)]
            public string GmtEnabled { get; set; }

            /// <summary>
            /// <para>The time when a locked virtual MFA device was automatically unlocked. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-21T15:21:28Z</para>
            /// </summary>
            [NameInMap("GmtUnlock")]
            [Validation(Required=false)]
            public string GmtUnlock { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-269345****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The serial number of the virtual MFA device, which is a unique identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a25f297f-f2e1-4a44-bbf1-5f48a6e5****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The status of the virtual MFA device.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>LOCKED</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>UNBOUND</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>NORMAL</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
