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
            /// <para>The number of consecutive failures to bind the virtual MFA device, or the number of authentication failures based on the virtual MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ConsecutiveFails")]
            [Validation(Required=false)]
            public int? ConsecutiveFails { get; set; }

            /// <summary>
            /// <para>The type of the virtual MFA device. The value can only be TOTP_VIRTUAL. This value indicates that the virtual MFA device follows the Time-based One-time Password (TOTP) algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TOTP_VIRTUAL</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The username of the convenience user that uses the virtual MFA device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The time when the virtual MFA device was enabled. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-22T06:20:49Z</para>
            /// </summary>
            [NameInMap("GmtEnabled")]
            [Validation(Required=false)]
            public string GmtEnabled { get; set; }

            /// <summary>
            /// <para>The time when the locked virtual MFA device was automatically unlocked. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-23T06:20:49Z</para>
            /// </summary>
            [NameInMap("GmtUnlock")]
            [Validation(Required=false)]
            public string GmtUnlock { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The serial number of the virtual MFA device. The serial number is unique for each device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc856334-446b-4035-bfbc-18af261e****</para>
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
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
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
