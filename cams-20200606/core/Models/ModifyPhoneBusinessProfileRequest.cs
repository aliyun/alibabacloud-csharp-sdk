// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyPhoneBusinessProfileRequest : TeaModel {
        /// <summary>
        /// The address.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The space ID of the user under the independent software vendor (ISV) account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The URL of the profile picture.
        /// </summary>
        [NameInMap("ProfilePictureUrl")]
        [Validation(Required=false)]
        public string ProfilePictureUrl { get; set; }

        /// <summary>
        /// The industry.
        /// </summary>
        [NameInMap("Vertical")]
        [Validation(Required=false)]
        public string Vertical { get; set; }

        /// <summary>
        /// The websites.
        /// </summary>
        [NameInMap("Websites")]
        [Validation(Required=false)]
        public List<string> Websites { get; set; }

    }

}
