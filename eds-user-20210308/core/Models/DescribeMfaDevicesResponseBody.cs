// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeMfaDevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the virtual MFA devices.</para>
        /// </summary>
        [NameInMap("MfaDevices")]
        [Validation(Required=false)]
        public List<DescribeMfaDevicesResponseBodyMfaDevices> MfaDevices { get; set; }
        public class DescribeMfaDevicesResponseBodyMfaDevices : TeaModel {
            /// <summary>
            /// <para>The information about the AD user associated with the virtual MFA device.</para>
            /// </summary>
            [NameInMap("AdUser")]
            [Validation(Required=false)]
            public DescribeMfaDevicesResponseBodyMfaDevicesAdUser AdUser { get; set; }
            public class DescribeMfaDevicesResponseBodyMfaDevicesAdUser : TeaModel {
                /// <summary>
                /// <para>The display name of the AD user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aduser</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The new display name of the AD user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("DisplayNameNew")]
                [Validation(Required=false)]
                public string DisplayNameNew { get; set; }

                /// <summary>
                /// <para>The AD username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aduser</para>
                /// </summary>
                [NameInMap("EndUser")]
                [Validation(Required=false)]
                public string EndUser { get; set; }

                /// <summary>
                /// <para>The user principal name of the AD user.</para>
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("ConsecutiveFails")]
            [Validation(Required=false)]
            public int? ConsecutiveFails { get; set; }

            /// <summary>
            /// <para>The type of the virtual MFA device. Currently, only <c>TOTP_VIRTUAL</c> is supported, which indicates a virtual MFA device that complies with the TOTP algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TOTP_VIRTUAL</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The username of the convenience account that uses the virtual MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The time when the virtual MFA device was enabled. The time is specified in ISO 8601 format in UTC. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-22T06:20:49Z</para>
            /// </summary>
            [NameInMap("GmtEnabled")]
            [Validation(Required=false)]
            public string GmtEnabled { get; set; }

            /// <summary>
            /// <para>The automatic unlock time after the virtual MFA device is locked. The time is specified in ISO 8601 format in UTC. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-23T06:20:49Z</para>
            /// </summary>
            [NameInMap("GmtUnlock")]
            [Validation(Required=false)]
            public string GmtUnlock { get; set; }

            /// <summary>
            /// <para>The ID of the virtual MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The serial number of the virtual MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc856334-446b-4035-bfbc-18af261e****</para>
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
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The token used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6na6YlN9asMM31MsMcdQNpp</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33DBB8EC-6E68-4726-91C4-E09C59D9A7D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
