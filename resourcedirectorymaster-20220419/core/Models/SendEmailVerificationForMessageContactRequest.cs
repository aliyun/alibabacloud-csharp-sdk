// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class SendEmailVerificationForMessageContactRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-5gsZAGt***PGduDF</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>The email address of the contact.</para>
        /// <para>The specified email address must be the one you specify when you call <a href="~~AddMessageContact~~">AddMessageContact</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>someone***@example.com</para>
        /// </summary>
        [NameInMap("EmailAddress")]
        [Validation(Required=false)]
        public string EmailAddress { get; set; }

    }

}
