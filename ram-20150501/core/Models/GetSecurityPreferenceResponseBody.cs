// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetSecurityPreferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC1213F1-A9D5-4A01-A996-44983689126C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security preferences.</para>
        /// </summary>
        [NameInMap("SecurityPreference")]
        [Validation(Required=false)]
        public GetSecurityPreferenceResponseBodySecurityPreference SecurityPreference { get; set; }
        public class GetSecurityPreferenceResponseBodySecurityPreference : TeaModel {
            /// <summary>
            /// <para>The AccessKey pair preference.</para>
            /// </summary>
            [NameInMap("AccessKeyPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference AccessKeyPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether Resource Access Management (RAM) users can manage their AccessKey pairs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowUserToManageAccessKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManageAccessKeys { get; set; }

            }

            /// <summary>
            /// <para>The logon preference.</para>
            /// </summary>
            [NameInMap("LoginProfilePreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference LoginProfilePreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can change their passwords. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
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
                /// <para>Indicates whether RAM users can save security codes for MFA during logon. Each security code is valid for seven days. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableSaveMFATicket")]
                [Validation(Required=false)]
                public bool? EnableSaveMFATicket { get; set; }

                /// <summary>
                /// <para>The subnet mask that indicates the IP addresses from which logon to the Alibaba Cloud Management Console is allowed. This parameter applies to password-based logon and single sign-on (SSO). However, this parameter does not apply to API calls that are authenticated based on AccessKey pairs.</para>
                /// <list type="bullet">
                /// <item><description>If you specify a subnet mask, RAM users can use only the IP addresses in the subnet mask to log on to the Alibaba Cloud Management Console.</description></item>
                /// <item><description>If you do not specify a subnet mask, RAM users can use all IP addresses to log on to the Alibaba Cloud Management Console.</description></item>
                /// </list>
                /// <para>If you want to specify more than one subnet mask, separate the masks with semicolons (;). Example: 192.168.0.0/16;10.0.0.0/8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/8</para>
                /// </summary>
                [NameInMap("LoginNetworkMasks")]
                [Validation(Required=false)]
                public string LoginNetworkMasks { get; set; }

                /// <summary>
                /// <para>The validity period of the logon session of RAM users. Unit: hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("LoginSessionDuration")]
                [Validation(Required=false)]
                public int? LoginSessionDuration { get; set; }

            }

            /// <summary>
            /// <para>The multi-factor authentication (MFA) preference.</para>
            /// </summary>
            [NameInMap("MFAPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference MFAPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their MFA devices. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowUserToManageMFADevices")]
                [Validation(Required=false)]
                public bool? AllowUserToManageMFADevices { get; set; }

            }

            /// <summary>
            /// <para>The public key preference.</para>
            /// <remarks>
            /// <para> This parameter is valid only for the Japan site.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("PublicKeyPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferencePublicKeyPreference PublicKeyPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferencePublicKeyPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their public keys. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowUserToManagePublicKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManagePublicKeys { get; set; }

            }

        }

    }

}
