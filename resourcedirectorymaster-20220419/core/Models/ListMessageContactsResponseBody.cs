// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListMessageContactsResponseBody : TeaModel {
        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public List<ListMessageContactsResponseBodyContacts> Contacts { get; set; }
        public class ListMessageContactsResponseBodyContacts : TeaModel {
            [NameInMap("AssociatedDate")]
            [Validation(Required=false)]
            public string AssociatedDate { get; set; }

            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("EmailAddress")]
            [Validation(Required=false)]
            public string EmailAddress { get; set; }

            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<string> Members { get; set; }

            [NameInMap("MessageTypes")]
            [Validation(Required=false)]
            public List<string> MessageTypes { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
