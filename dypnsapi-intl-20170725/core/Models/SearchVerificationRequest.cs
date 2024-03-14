// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi_intl20170725.Models
{
    public class SearchVerificationRequest : TeaModel {
        /// <summary>
        /// The verification code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The time when a text message is sent, in milliseconds. You can query text messages that were sent within the last 30 days.
        /// 
        /// Example: 1677600000000.
        /// </summary>
        [NameInMap("SendDate")]
        [Validation(Required=false)]
        public long? SendDate { get; set; }

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
