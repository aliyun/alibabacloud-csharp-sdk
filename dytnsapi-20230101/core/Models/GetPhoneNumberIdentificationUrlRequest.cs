// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20230101.Models
{
    public class GetPhoneNumberIdentificationUrlRequest : TeaModel {
        /// <summary>
        /// The authorization code.
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// The IP address of the subscriber\"s phone.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The external ID.
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The phone number of the subscriber. The phone number is in the Mobile Station International Subscriber Directory Number (MSISDN) format.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Specifies whether to remember the phone number.
        /// </summary>
        [NameInMap("RememberPhoneNumber")]
        [Validation(Required=false)]
        public bool? RememberPhoneNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
