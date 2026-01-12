// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeInstanceAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The API keys.</para>
        /// </summary>
        [NameInMap("ApiKeys")]
        [Validation(Required=false)]
        public DescribeInstanceAuthInfoResponseBodyApiKeys ApiKeys { get; set; }
        public class DescribeInstanceAuthInfoResponseBodyApiKeys : TeaModel {
            /// <summary>
            /// <para>The ANON_KEY of Supabase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyxxxJ9.ey****</para>
            /// </summary>
            [NameInMap("AnonKey")]
            [Validation(Required=false)]
            public string AnonKey { get; set; }

            /// <summary>
            /// <para>The SERVICE_ROLE_KEY of Supabase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyxxxJ9.ey****KfQ.DaYxxxt4Q</para>
            /// </summary>
            [NameInMap("ServiceKey")]
            [Validation(Required=false)]
            public string ServiceKey { get; set; }

        }

        /// <summary>
        /// <para>The authentication configurations.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeInstanceAuthInfoResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeInstanceAuthInfoResponseBodyConfigList : TeaModel {
            /// <summary>
            /// <para>The name of the configuration item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>GOTRUE_EXTERNAL_EMAIL_ENABLED</b>: Enables authentication via external email addresses.</description></item>
            /// <item><description><b>GOTRUE_SITE_URL</b>: the URL that is displayed in the emails sent from the instance.</description></item>
            /// <item><description><b>GOTRUE_SMTP_PORT</b>: the port of the SMTP service provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_SENDER_NAME</b>: the name of the sender of the email.</description></item>
            /// <item><description><b>GOTRUE_SMTP_USER</b>: the username of the SMTP service provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_PASS</b>: the key of the SMTP service provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_ADMIN_EMAIL</b>: the email address of the SMTP service provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_HOST</b>: The host address of the SMTP service provider.</description></item>
            /// <item><description><b>GOTRUE_MAILER_AUTOCONFIRM</b>: specifies whether to enable automatic confirmation.</description></item>
            /// <item><description><b>GOTRUE_MAILER_OTP_EXP</b>: The validity period of the one-time password (OTP). Unit: seconds.</description></item>
            /// <item><description><b>GOTRUE_MAILER_OTP_LENGTH</b>: The verification code length of the one-time password (OTP). The value must be an integer greater than or equal to 6.</description></item>
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
        /// <para>The ID of the RDS Supabase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The JWT key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i5o1XAp4sR*****oyOb3O</para>
        /// </summary>
        [NameInMap("JwtSecret")]
        [Validation(Required=false)]
        public string JwtSecret { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87249A6F-xxx-804C-E1E0AD1FAD90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
