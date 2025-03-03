// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class SendVerificationCodeForEnableRDRequest : TeaModel {
        /// <summary>
        /// <para>The mobile phone number that is bound to the newly created account. If you leave this parameter empty, the mobile phone number that is bound to the current account is used.</para>
        /// <para>Specify the mobile phone number in the <c>&lt;Country code&gt;-&lt;Mobile phone number&gt;</c> format.</para>
        /// <remarks>
        /// <para> Mobile phone numbers in the <c>86-&lt;Mobile phone number&gt;</c> format in the Chinese mainland are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xx-13900001234</para>
        /// </summary>
        [NameInMap("SecureMobilePhone")]
        [Validation(Required=false)]
        public string SecureMobilePhone { get; set; }

    }

}
