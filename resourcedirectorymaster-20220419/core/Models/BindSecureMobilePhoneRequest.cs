// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class BindSecureMobilePhoneRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138660628348****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The mobile phone number that you want to bind to the member for security purposes.</para>
        /// <para>The mobile phone number you specify must be the same as the mobile phone number that you specify when you call the <a href="~~SendVerificationCodeForBindSecureMobilePhone~~">SendVerificationCodeForBindSecureMobilePhone</a> operation to obtain a verification code.</para>
        /// <para>Specify the mobile phone number in the \<Country code>-\<Mobile phone number> format.</para>
        /// <remarks>
        /// <para>Mobile phone numbers in the <c>86-&lt;Mobile phone number&gt;</c> format in the Chinese mainland are not supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx-13900001234</para>
        /// </summary>
        [NameInMap("SecureMobilePhone")]
        [Validation(Required=false)]
        public string SecureMobilePhone { get; set; }

        /// <summary>
        /// <para>The verification code.</para>
        /// <para>You can call the <a href="~~SendVerificationCodeForBindSecureMobilePhone~~">SendVerificationCodeForBindSecureMobilePhone</a> operation to obtain the verification code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("VerificationCode")]
        [Validation(Required=false)]
        public string VerificationCode { get; set; }

    }

}
