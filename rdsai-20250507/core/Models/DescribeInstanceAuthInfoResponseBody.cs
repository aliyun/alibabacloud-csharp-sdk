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
            /// <para>The Supabase ANON_KEY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJ0eXAiOiJKV1QiLCJhbGciOiJIUz<b><b>J9.eyJpc3MiOiJzdXBhYmFzZSIsInJvbGUiOiJhbm9uIiwiaWF0IjoxNzU1Nzg1ODc1LCJleHAiOjEzMjY2NDI1ODc1fQ.EGNFdeWRZBsdB051EzQsBwvDJveC9IMEXWUCDLX</b></b></para>
            /// </summary>
            [NameInMap("AnonKey")]
            [Validation(Required=false)]
            public string AnonKey { get; set; }

            /// <summary>
            /// <para>The API key used to access E2B-compatible sandbox APIs. This parameter is returned when the sandbox is enabled and a service key exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e2b_65794a30655841694f694a4b563151694c434a68624763694f694a49557a49314e694a392e65794a7063334d694f694a7a64584268596d467a5a534973496e4a76624755694f694a7a5a584a3261574e6c58334a766247556****34a70595851694f6a45334f5451314d6a67774d444173496d5634634349364d544d7a4d4455784e6a67774d4442392e41414543417751464267634943516f4c4441304f4478415245684d554652595847426b6147787764486838</para>
            /// </summary>
            [NameInMap("E2bApiKey")]
            [Validation(Required=false)]
            public string E2bApiKey { get; set; }

            /// <summary>
            /// <para>The Supabase SERVICE_ROLE_KEY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJ0eXAiOiJKV1QiLCJhbGciOiJIUz<b><b>J9.eyJpc3MiOiJzdXBhYmFzZSIsInJvbGUiOiJzZXJ2aWNlX3JvbGUiLCJpYXQiOjE3NTU3ODU4NzUsImV4cCI6MTMyNjY0MjU4NzV9.oJt4UF8cpSDOvjW39IM4fLp2750rEvxFnkNqcVM</b></b></para>
            /// </summary>
            [NameInMap("ServiceKey")]
            [Validation(Required=false)]
            public string ServiceKey { get; set; }

        }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <para>The list of authentication information.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeInstanceAuthInfoResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeInstanceAuthInfoResponseBodyConfigList : TeaModel {
            /// <summary>
            /// <para>The name of the configuration item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>GOTRUE_EXTERNAL_EMAIL_ENABLED</b>: Specifies whether to allow external emails.</description></item>
            /// <item><description><b>GOTRUE_SITE_URL</b>: The website URL displayed when the AI application sends emails.</description></item>
            /// <item><description><b>GOTRUE_SMTP_PORT</b>: The port of the SMTP service provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_SENDER_NAME</b>: The name of the email sender.</description></item>
            /// <item><description><b>GOTRUE_SMTP_USER</b>: The username of the SMTP service provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_PASS</b>: The password of the SMTP service provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_ADMIN_EMAIL</b>: The email address of the SMTP service provider.</description></item>
            /// <item><description><b>GOTRUE_SMTP_HOST</b>: The host address of the SMTP service provider.</description></item>
            /// <item><description><b>GOTRUE_MAILER_AUTOCONFIRM</b>: Specifies whether to enable automatic confirmation.</description></item>
            /// <item><description><b>GOTRUE_MAILER_OTP_EXP</b>: The validity period of the one-time password (OTP). Unit: seconds.</description></item>
            /// <item><description><b>GOTRUE_MAILER_OTP_LENGTH</b>: The length of the one-time password (OTP). The value must be an integer greater than or equal to 6.</description></item>
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
        /// <para>The JWT secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g7jgepleljS8nxAwsOd2EDWkBWi7JcU1m2Gj****</para>
        /// </summary>
        [NameInMap("JwtSecret")]
        [Validation(Required=false)]
        public string JwtSecret { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
