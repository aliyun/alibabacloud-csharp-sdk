// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyPhoneBusinessProfileRequest : TeaModel {
        /// <summary>
        /// The space ID of the user under the independent software vendor (ISV) account.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// Modifies the business information of the account to which a specified phone number is bound.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The address.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The industry.
        /// 
        /// > Enum: {OTHER, AUTO, BEAUTY, APPAREL, EDU, ENTERTAIN, EVENT_PLAN, FINANCE, GROCERY, GOVT, HOTEL, HEALTH, NONPROFIT, PROF_SERVICES, RETAIL, TRAVEL, RESTAURANT}
        /// </summary>
        [NameInMap("ProfilePictureUrl")]
        [Validation(Required=false)]
        public string ProfilePictureUrl { get; set; }

        /// <summary>
        /// Sichuan
        /// </summary>
        [NameInMap("Vertical")]
        [Validation(Required=false)]
        public string Vertical { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        [NameInMap("Websites")]
        [Validation(Required=false)]
        public List<string> Websites { get; set; }

    }

}
