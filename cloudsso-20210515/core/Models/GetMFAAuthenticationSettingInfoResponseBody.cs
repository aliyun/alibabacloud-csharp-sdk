// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetMFAAuthenticationSettingInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The global MFA verification configuration.</para>
        /// </summary>
        [NameInMap("MFAAuthenticationSettingInfo")]
        [Validation(Required=false)]
        public GetMFAAuthenticationSettingInfoResponseBodyMFAAuthenticationSettingInfo MFAAuthenticationSettingInfo { get; set; }
        public class GetMFAAuthenticationSettingInfoResponseBodyMFAAuthenticationSettingInfo : TeaModel {
            [NameInMap("AllowedVerificationTypes")]
            [Validation(Required=false)]
            public List<string> AllowedVerificationTypes { get; set; }

            /// <summary>
            /// <para>The global MFA verification policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: MFA verification is enabled for all users.</description></item>
            /// <item><description>Byuser: MFA verification depends on the independent MFA configuration of each user. For more information about user-specific MFA configuration, see <a href="https://help.aliyun.com/document_detail/450135.html">UpdateUserMFAAuthenticationSettings</a>.</description></item>
            /// <item><description>Disabled: MFA verification is disabled for all users.</description></item>
            /// <item><description>OnlyRiskyLogin: MFA verification is required only for unusual logon attempts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OnlyRiskyLogin</para>
            /// </summary>
            [NameInMap("MfaAuthenticationAdvanceSettings")]
            [Validation(Required=false)]
            public string MfaAuthenticationAdvanceSettings { get; set; }

            /// <summary>
            /// <para>The MFA verification policy for unusual logon attempts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Autonomous: Users can skip MFA binding during unusual logon, but users who have already bound MFA must complete verification.</description></item>
            /// <item><description>EnforceVerify: Users are required to bind or verify MFA during unusual logon.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is displayed only when MfaAuthenticationAdvanceSettings is set to Byuser or OnlyRiskyLogin.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>EnforceVerify</para>
            /// </summary>
            [NameInMap("OperationForRiskLogin")]
            [Validation(Required=false)]
            public string OperationForRiskLogin { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95D3B107-DA80-5B34-A3D0-9E82F8F0DA0E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
