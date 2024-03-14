/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi_intl20170725.Models
{
    public class CheckVerificationRequest : TeaModel {
        /// <summary>
        /// The verification code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The service ID that is displayed in the Phone Number Verification Service console.
        /// </summary>
        [NameInMap("ServiceSid")]
        [Validation(Required=false)]
        public string ServiceSid { get; set; }

        /// <summary>
        /// The mobile phone number of the recipient. You must add the country code to the beginning of the mobile phone number. Example: 6212345\*\*\*\*01.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// The unique authentication ID that is returned by calling the StartVerification operation.
        /// </summary>
        [NameInMap("VerificationId")]
        [Validation(Required=false)]
        public string VerificationId { get; set; }

    }

}
