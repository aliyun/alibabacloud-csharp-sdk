/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class AddChatappPhoneNumberRequest : TeaModel {
        /// <summary>
        /// The country code.
        /// </summary>
        [NameInMap("Cc")]
        [Validation(Required=false)]
        public string Cc { get; set; }

        /// <summary>
        /// The space ID of the user within the independent software vendor (ISV) account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The phone number without a country code.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The ID of the pre-registered phone number.
        /// </summary>
        [NameInMap("PreValidateId")]
        [Validation(Required=false)]
        public string PreValidateId { get; set; }

        /// <summary>
        /// The display name of the phone number.
        /// </summary>
        [NameInMap("VerifiedName")]
        [Validation(Required=false)]
        public string VerifiedName { get; set; }

    }

}
