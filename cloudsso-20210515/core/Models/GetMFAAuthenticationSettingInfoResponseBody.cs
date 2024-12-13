// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetMFAAuthenticationSettingInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The MFA setting of all users.</para>
        /// </summary>
        [NameInMap("MFAAuthenticationSettingInfo")]
        [Validation(Required=false)]
        public GetMFAAuthenticationSettingInfoResponseBodyMFAAuthenticationSettingInfo MFAAuthenticationSettingInfo { get; set; }
        public class GetMFAAuthenticationSettingInfoResponseBodyMFAAuthenticationSettingInfo : TeaModel {
            /// <summary>
            /// <para>The MFA policy of all users. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: MFA is enabled for all users.</description></item>
            /// <item><description>Byuser: User-specific settings are applied. For more information about how to configure MFA for a single user, see <a href="https://help.aliyun.com/document_detail/450135.html">UpdateUserMFAAuthenticationSettings</a>.</description></item>
            /// <item><description>Disabled: MFA is disabled for all users.</description></item>
            /// <item><description>OnlyRiskyLogin: MFA is required only for unusual logons.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OnlyRiskyLogin</para>
            /// </summary>
            [NameInMap("MfaAuthenticationAdvanceSettings")]
            [Validation(Required=false)]
            public string MfaAuthenticationAdvanceSettings { get; set; }

            /// <summary>
            /// <para>The MFA policy for unusual logons. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Autonomous: MFA is prompted for users who initiated unusual logons. However, the users are allowed to skip MFA. If an MFA device is bound to a user who initiated an unusual logon, the user must pass MFA.</description></item>
            /// <item><description>EnforceVerify: MFA is required. If no MFA devices are bound to a user who initiated an unusual logon, the user must bind an MFA device. If an MFA device is already bound to a user who initiated an unusual logon, the user must pass MFA.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is displayed only when Byuser or OnlyRiskyLogin is returned for the MfaAuthenticationAdvanceSettings parameter.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95D3B107-DA80-5B34-A3D0-9E82F8F0DA0E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
