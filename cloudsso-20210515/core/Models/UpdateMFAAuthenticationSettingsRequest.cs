// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateMFAAuthenticationSettingsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable MFA for all users. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: enables MFA for all users.</description></item>
        /// <item><description>Byuser: uses user-specific settings. For more information about how to configure MFA for a single user, see <a href="https://help.aliyun.com/document_detail/450135.html">UpdateUserMFAAuthenticationSettings</a>.</description></item>
        /// <item><description>Disabled: disables MFA for all users.</description></item>
        /// <item><description>OnlyRiskyLogin: MFA is required only for unusual logons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("MFAAuthenticationSettings")]
        [Validation(Required=false)]
        public string MFAAuthenticationSettings { get; set; }

        /// <summary>
        /// <para>Specifies whether MFA is required for users who initiated unusual logons. Valid values:</para>
        /// <para>Autonomous: MFA is prompted for users who initiated unusual logons. However, the users are allowed to skip MFA. If an MFA device is bound to a user who initiated an unusual logon, the user must pass MFA. EnforceVerify: MFA is required. If no MFA devices are bound to a user who initiated an unusual logon, the user must bind an MFA device. If an MFA device is already bound to a user who initiated an unusual logon, the user must pass MFA.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Autonomous</para>
        /// </summary>
        [NameInMap("OperationForRiskLogin")]
        [Validation(Required=false)]
        public string OperationForRiskLogin { get; set; }

    }

}
