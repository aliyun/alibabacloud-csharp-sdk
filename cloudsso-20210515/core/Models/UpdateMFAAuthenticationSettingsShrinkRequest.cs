// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateMFAAuthenticationSettingsShrinkRequest : TeaModel {
        [NameInMap("AllowedVerificationTypes")]
        [Validation(Required=false)]
        public string AllowedVerificationTypesShrink { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The global MFA settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: MFA verification is enabled for all users.</description></item>
        /// <item><description>Byuser: MFA verification depends on the individual MFA settings of each user. For more information about individual user MFA settings, see <a href="https://help.aliyun.com/document_detail/450135.html">UpdateUserMFAAuthenticationSettings</a>.</description></item>
        /// <item><description>Disabled: MFA verification is disabled for all users.</description></item>
        /// <item><description>OnlyRiskyLogin: MFA verification is required only for unusual logon attempts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("MFAAuthenticationSettings")]
        [Validation(Required=false)]
        public string MFAAuthenticationSettings { get; set; }

        /// <summary>
        /// <para>The action to take when the MFA settings option is set to verify only for unusual logon attempts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Autonomous: Users can skip MFA binding during unusual logon, but users who have already bound MFA must complete MFA verification.</description></item>
        /// <item><description>EnforceVerify: Users who have not bound MFA are required to bind it, and users who have already bound MFA must complete verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Autonomous</para>
        /// </summary>
        [NameInMap("OperationForRiskLogin")]
        [Validation(Required=false)]
        public string OperationForRiskLogin { get; set; }

    }

}
