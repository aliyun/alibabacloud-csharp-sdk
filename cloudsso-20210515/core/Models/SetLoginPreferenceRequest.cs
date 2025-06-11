// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetLoginPreferenceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow a user to obtain the application access credential after logon to the portal. Valid values:</para>
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
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The IP address whitelist. CloudSSO users can log on to the CloudSSO user portal only by using the IP addresses in the whitelist. Limits:</para>
        /// <list type="bullet">
        /// <item><description>You can enter IP addresses or CIDR blocks. IPv4 addresses are supported.</description></item>
        /// <item><description>You can enter up to 100 IP addresses or CIDR blocks. Separate multiple IP addresses or CIDR blocks with semicolons <c>(;)</c>.</description></item>
        /// <item><description>If you do not specify this parameter, the original settings are retained.</description></item>
        /// <item><description>If you set this parameter to a semicolon (<c>;</c>), the value of this parameter is cleared.</description></item>
        /// <item><description>The IP address whitelist takes effect only on CloudSSO users who want to log on to the CloudSSO user portal by using the username-password logon or single sign-on (SSO) method. The IP address whitelist does not take effect on CloudSSO users who access accounts in a resource directory from the CloudSSO user portal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/16;10.0.0.0/8</para>
        /// </summary>
        [NameInMap("LoginNetworkMasks")]
        [Validation(Required=false)]
        public string LoginNetworkMasks { get; set; }

    }

}
