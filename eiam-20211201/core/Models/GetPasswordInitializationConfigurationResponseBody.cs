// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetPasswordInitializationConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The password initialization configuration.</para>
        /// </summary>
        [NameInMap("PasswordInitializationConfiguration")]
        [Validation(Required=false)]
        public GetPasswordInitializationConfigurationResponseBodyPasswordInitializationConfiguration PasswordInitializationConfiguration { get; set; }
        public class GetPasswordInitializationConfigurationResponseBodyPasswordInitializationConfiguration : TeaModel {
            /// <summary>
            /// <para>The status of forced password update. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordForcedUpdateStatus")]
            [Validation(Required=false)]
            public string PasswordForcedUpdateStatus { get; set; }

            /// <summary>
            /// <para>The list of password initialization notification channels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>email</para>
            /// </summary>
            [NameInMap("PasswordInitializationNotificationChannels")]
            [Validation(Required=false)]
            public List<string> PasswordInitializationNotificationChannels { get; set; }

            /// <summary>
            /// <para>The status of the password initialization configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordInitializationStatus")]
            [Validation(Required=false)]
            public string PasswordInitializationStatus { get; set; }

            /// <summary>
            /// <para>The password initialization method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>random: Random.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>random</para>
            /// </summary>
            [NameInMap("PasswordInitializationType")]
            [Validation(Required=false)]
            public string PasswordInitializationType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
