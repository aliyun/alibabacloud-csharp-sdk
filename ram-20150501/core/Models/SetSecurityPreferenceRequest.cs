// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class SetSecurityPreferenceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether RAM users can change their passwords. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowUserToChangePassword")]
        [Validation(Required=false)]
        public bool? AllowUserToChangePassword { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can manage their AccessKey pairs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowUserToManageAccessKeys")]
        [Validation(Required=false)]
        public bool? AllowUserToManageAccessKeys { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can manage their MFA devices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowUserToManageMFADevices")]
        [Validation(Required=false)]
        public bool? AllowUserToManageMFADevices { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can manage their public keys. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is valid only for the Japan site.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowUserToManagePublicKeys")]
        [Validation(Required=false)]
        public bool? AllowUserToManagePublicKeys { get; set; }

        /// <summary>
        /// <para>Specifies whether to remember the multi-factor authentication (MFA) devices of Resource Access Management (RAM) users for seven days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSaveMFATicket")]
        [Validation(Required=false)]
        public bool? EnableSaveMFATicket { get; set; }

        /// <summary>
        /// <para>The subnet mask that specifies the IP addresses from which you can log on to the Alibaba Cloud Management Console. This parameter takes effect on password-based logon and single sign-on (SSO). However, this parameter does not take effect on API calls that are authenticated by using AccessKey pairs.</para>
        /// <list type="bullet">
        /// <item><description>If you specify a subnet mask, RAM users can use only the IP addresses in the subnet mask to log on to the Alibaba Cloud Management Console.</description></item>
        /// <item><description>If you do not specify a subnet mask, RAM users can use all IP addresses to log on to the Alibaba Cloud Management Console.</description></item>
        /// </list>
        /// <para>If you need to specify multiple subnet masks, separate the subnet masks with semicolons (;). Example: 192.168.0.0/16;10.0.0.0/8.</para>
        /// <para>You can specify up to 40 subnet masks. The total length of the subnet masks can be a maximum of 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("LoginNetworkMasks")]
        [Validation(Required=false)]
        public string LoginNetworkMasks { get; set; }

        /// <summary>
        /// <para>The validity period of the logon session of RAM users.</para>
        /// <para>Valid values: 1 to 24. Default value: 6. Unit: hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("LoginSessionDuration")]
        [Validation(Required=false)]
        public int? LoginSessionDuration { get; set; }

    }

}
