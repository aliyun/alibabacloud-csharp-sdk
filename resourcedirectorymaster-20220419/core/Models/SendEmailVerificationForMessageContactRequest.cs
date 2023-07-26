// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class SendEmailVerificationForMessageContactRequest : TeaModel {
        /// <summary>
        /// The ID of the contact.
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// The email address of the contact.
        /// 
        /// The specified email address must be the one you specify when you call [AddMessageContact](~~AddMessageContact~~).
        /// </summary>
        [NameInMap("EmailAddress")]
        [Validation(Required=false)]
        public string EmailAddress { get; set; }

    }

}
