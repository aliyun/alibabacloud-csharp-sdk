// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListMessageContactsResponseBody : TeaModel {
        /// <summary>
        /// The time when the contact was bound to the objects.
        /// </summary>
        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public List<ListMessageContactsResponseBodyContacts> Contacts { get; set; }
        public class ListMessageContactsResponseBodyContacts : TeaModel {
            /// <summary>
            /// The time when the contact was bound to the objects.
            /// </summary>
            [NameInMap("AssociatedDate")]
            [Validation(Required=false)]
            public string AssociatedDate { get; set; }

            /// <summary>
            /// The ID of the contact.
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// The time when the contact was added.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The email address of the contact.
            /// </summary>
            [NameInMap("EmailAddress")]
            [Validation(Required=false)]
            public string EmailAddress { get; set; }

            /// <summary>
            /// The IDs of objects to which the contact is bound.
            /// </summary>
            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<string> Members { get; set; }

            /// <summary>
            /// The types of messages received by the contact.
            /// </summary>
            [NameInMap("MessageTypes")]
            [Validation(Required=false)]
            public List<string> MessageTypes { get; set; }

            /// <summary>
            /// The name of the contact.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The mobile phone number of the contact.
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// The status of the contact. Valid values:
            /// 
            /// - Verifying
            /// - Active
            /// - Deleting
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The job title of the contact.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
