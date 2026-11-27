// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class SendVerificationCodeForEnableRDRequest : TeaModel {
        /// <summary>
        /// <para>The secure phone number of the newly created management account. If you leave this parameter empty, the secure phone number of the current logon account is used.</para>
        /// <para>Format: <c>&lt;country code&gt;-&lt;phone number&gt;</c>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>You cannot enter a phone number in the Chinese mainland in the <c>86-&lt;phone number&gt;</c> format.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>You can only enter a phone number in the Chinese mainland in the <c>86-&lt;phone number&gt;</c> format.</para>
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
