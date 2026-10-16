// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class SendVerificationCodeForBindSecureMobilePhoneRequest : TeaModel {
        /// <summary>
        /// <para>The account ID of the member.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138660628348****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The secure phone number.</para>
        /// <para>Format: <Country code>-<Phone number>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>Only phone numbers in the Chinese mainland in the format of <c>86-&lt;Phone number&gt;</c> are supported.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>Phone numbers in the Chinese mainland in the format of <c>86-&lt;Phone number&gt;</c> are not supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx-13900001234</para>
        /// </summary>
        [NameInMap("SecureMobilePhone")]
        [Validation(Required=false)]
        public string SecureMobilePhone { get; set; }

    }

}
