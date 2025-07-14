// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetVerificationInfoRequest : TeaModel {
        /// <summary>
        /// <para>The email address.</para>
        /// <remarks>
        /// <para> If you set <c>VerifyType</c> to <c>email</c>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The mobile phone number.</para>
        /// <remarks>
        /// <para> If you set <c>VerifyType</c> to <c>sms</c>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86-13900001234</para>
        /// </summary>
        [NameInMap("MobilePhone")]
        [Validation(Required=false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// <para>The logon name of the RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// <para>The multi-factor authentication (MFA) method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sms: mobile phone.</description></item>
        /// <item><description>email: email.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sms</para>
        /// </summary>
        [NameInMap("VerifyType")]
        [Validation(Required=false)]
        public string VerifyType { get; set; }

    }

}
