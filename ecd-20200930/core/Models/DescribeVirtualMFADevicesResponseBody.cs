// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVirtualMFADevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token for the next query. If NextToken is empty, no more results exist.</para>
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
        /// <para>The information about virtual MFA devices.</para>
        /// </summary>
        [NameInMap("VirtualMFADevices")]
        [Validation(Required=false)]
        public List<DescribeVirtualMFADevicesResponseBodyVirtualMFADevices> VirtualMFADevices { get; set; }
        public class DescribeVirtualMFADevicesResponseBodyVirtualMFADevices : TeaModel {
            /// <summary>
            /// <para>The AD domain user information.</para>
            /// </summary>
            [NameInMap("AdUser")]
            [Validation(Required=false)]
            public DescribeVirtualMFADevicesResponseBodyVirtualMFADevicesAdUser AdUser { get; set; }
            public class DescribeVirtualMFADevicesResponseBodyVirtualMFADevicesAdUser : TeaModel {
                /// <summary>
                /// <para>The display name of the AD account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aduser</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The new display name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("DisplayNameNew")]
                [Validation(Required=false)]
                public string DisplayNameNew { get; set; }

                /// <summary>
                /// <para>The username of the AD account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aduser</para>
                /// </summary>
                [NameInMap("EndUser")]
                [Validation(Required=false)]
                public string EndUser { get; set; }

                /// <summary>
                /// <para>The user principal name (UPN).</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
                /// </summary>
                [NameInMap("UserPrincipalName")]
                [Validation(Required=false)]
                public string UserPrincipalName { get; set; }

            }

            /// <summary>
            /// <para>The number of consecutive failures to bind or authenticate the virtual MFA device.</para>
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
            /// <para>The username of the AD account that uses the virtual MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usertest</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The time when the virtual MFA device was enabled. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-20T14:52:28Z</para>
            /// </summary>
            [NameInMap("GmtEnabled")]
            [Validation(Required=false)]
            public string GmtEnabled { get; set; }

            /// <summary>
            /// <para>The automatic unlock time after the virtual MFA device is locked. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-21T15:21:28Z</para>
            /// </summary>
            [NameInMap("GmtUnlock")]
            [Validation(Required=false)]
            public string GmtUnlock { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-269345****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The serial number of the virtual MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a25f297f-f2e1-4a44-bbf1-5f48a6e5****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The status of the virtual MFA device.</para>
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
