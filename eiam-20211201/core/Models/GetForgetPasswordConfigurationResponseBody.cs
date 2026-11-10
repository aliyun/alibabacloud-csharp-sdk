// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetForgetPasswordConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The forgot password configuration.</para>
        /// </summary>
        [NameInMap("OpenForgetPasswordConfiguration")]
        [Validation(Required=false)]
        public GetForgetPasswordConfigurationResponseBodyOpenForgetPasswordConfiguration OpenForgetPasswordConfiguration { get; set; }
        public class GetForgetPasswordConfigurationResponseBodyOpenForgetPasswordConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of forgot password authentication channels. Required when ForgetPasswordStatus is set to enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>email: Email.</description></item>
            /// <item><description>sms: SMS.</description></item>
            /// <item><description>totp: OTP dynamic password.</description></item>
            /// <item><description>web_authn: WebAuthn.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AuthenticationChannels")]
            [Validation(Required=false)]
            public List<string> AuthenticationChannels { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Indicates whether the forgot password feature is enabled. This parameter is deprecated. Use the ForgetPasswordStatus parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deprecated: true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Indicates whether email is enabled as a forgot password authentication method. This parameter is deprecated. Use the AuthenticationChannels parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deprecated: true</para>
            /// </summary>
            [NameInMap("EnableEmail")]
            [Validation(Required=false)]
            public bool? EnableEmail { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Indicates whether SMS is enabled as a forgot password authentication method. This parameter is deprecated. Use the AuthenticationChannels parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deprecated: true</para>
            /// </summary>
            [NameInMap("EnableSms")]
            [Validation(Required=false)]
            public bool? EnableSms { get; set; }

            /// <summary>
            /// <para>The forgot password configuration status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ForgetPasswordStatus")]
            [Validation(Required=false)]
            public string ForgetPasswordStatus { get; set; }

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
