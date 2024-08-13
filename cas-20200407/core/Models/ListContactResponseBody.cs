// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListContactResponseBody : TeaModel {
        /// <summary>
        /// The contacts.
        /// </summary>
        [NameInMap("ContactList")]
        [Validation(Required=false)]
        public List<ListContactResponseBodyContactList> ContactList { get; set; }
        public class ListContactResponseBodyContactList : TeaModel {
            /// <summary>
            /// The ID of the contact.
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            /// <summary>
            /// The email address of the contact.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// Indicates whether the email address passed the verification.
            /// </summary>
            [NameInMap("EmailStatus")]
            [Validation(Required=false)]
            public int? EmailStatus { get; set; }

            /// <summary>
            /// The phone number.
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// Indicates whether the phone number was verified.
            /// </summary>
            [NameInMap("MobileStatus")]
            [Validation(Required=false)]
            public int? MobileStatus { get; set; }

            /// <summary>
            /// The name of the contact.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The webhook URL of the chatbot.
            /// </summary>
            [NameInMap("Webhooks")]
            [Validation(Required=false)]
            public string Webhooks { get; set; }

        }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The keyword used in the fuzzy search.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of certificates per page. Default value: **20**.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
