// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyInstanceAuthConfigRequest : TeaModel {
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <para>The list of authentication configurations.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<ModifyInstanceAuthConfigRequestConfigList> ConfigList { get; set; }
        public class ModifyInstanceAuthConfigRequestConfigList : TeaModel {
            /// <summary>
            /// <para>The configuration item name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>GOTRUE_EXTERNAL_EMAIL_ENABLED</b>: specifies whether to allow external email addresses.</description></item>
            /// <item><description><b>GOTRUE_SITE_URL</b>: the website URL displayed when the AI application sends emails.</description></item>
            /// <item><description><b>GOTRUE_SMTP_PORT</b>: the port of the SMTP provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_SENDER_NAME</b>: the name of the email sender.</description></item>
            /// <item><description><b>GOTRUE_SMTP_USER</b>: the username of the SMTP provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_PASS</b>: the secret key of the SMTP provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_ADMIN_EMAIL</b>: the email address of the SMTP provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_HOST</b>: the host address of the SMTP provider.</description></item>
            /// <item><description><b>GOTRUE_MAILER_AUTOCONFIRM</b>: specifies whether to enable automatic confirmation.</description></item>
            /// <item><description><b>GOTRUE_MAILER_OTP_EXP</b>: the validity period of the one-time password (OTP). Unit: seconds.</description></item>
            /// <item><description><b>GOTRUE_MAILER_OTP_LENGTH</b>: the length of the one-time password (OTP) verification code. The value must be an integer greater than or equal to 6.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GOTRUE_SITE_URL</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://8.152">http://8.152</a>. XXX.XXX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance ID of the AI application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
