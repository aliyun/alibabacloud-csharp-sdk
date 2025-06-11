// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetLoginPreferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The logon preference.</para>
        /// </summary>
        [NameInMap("LoginPreference")]
        [Validation(Required=false)]
        public GetLoginPreferenceResponseBodyLoginPreference LoginPreference { get; set; }
        public class GetLoginPreferenceResponseBodyLoginPreference : TeaModel {
            /// <summary>
            /// <para>Indicates whether a user can obtain the application access credential after logon to the portal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True</description></item>
            /// <item><description>False (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("AllowUserToGetCredentials")]
            [Validation(Required=false)]
            public bool? AllowUserToGetCredentials { get; set; }

            /// <summary>
            /// <para>The IP address whitelist. CloudSSO users can log on to the CloudSSO user portal only by using the IP addresses in the whitelist.</para>
            /// <para>The IP address whitelist takes effect only on CloudSSO users who want to log on to the CloudSSO user portal by using the username-password logon or single sign-on (SSO) method. The IP address whitelist does not take effect on CloudSSO users who access accounts in a resource directory from the CloudSSO user portal.</para>
            /// <para>If the return value of this parameter is empty, no IP address whitelists are configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16;10.0.0.0/8</para>
            /// </summary>
            [NameInMap("LoginNetworkMasks")]
            [Validation(Required=false)]
            public string LoginNetworkMasks { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CE8B990-193D-50CE-A604-69F3E7DCE740</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
