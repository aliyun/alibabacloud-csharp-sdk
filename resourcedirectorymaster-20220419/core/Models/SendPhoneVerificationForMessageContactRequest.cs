// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class SendPhoneVerificationForMessageContactRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-qL4HqKONzOM7****</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the contact.</para>
        /// <para>The value must be in the <c>&lt;Country code&gt;-&lt;Mobile phone number&gt;</c> format.</para>
        /// <para>The specified mobile phone number must be the one you specify when you call the <a href="~~AddMessageContact~~">AddMessageContact</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86-139****1234</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

    }

}
