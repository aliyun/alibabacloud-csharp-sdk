// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MscOpenSubscription20210713.Models
{
    public class ListContactsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public List<ListContactsResponseBodyContacts> Contacts { get; set; }
        public class ListContactsResponseBodyContacts : TeaModel {
            [NameInMap("AccountUid")]
            [Validation(Required=false)]
            public long? AccountUid { get; set; }

            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("IsAccount")]
            [Validation(Required=false)]
            public bool? IsAccount { get; set; }

            [NameInMap("IsObsolete")]
            [Validation(Required=false)]
            public bool? IsObsolete { get; set; }

            [NameInMap("IsVerifiedEmail")]
            [Validation(Required=false)]
            public bool? IsVerifiedEmail { get; set; }

            [NameInMap("IsVerifiedMobile")]
            [Validation(Required=false)]
            public bool? IsVerifiedMobile { get; set; }

            [NameInMap("LastEmailVerificationTimeStamp")]
            [Validation(Required=false)]
            public long? LastEmailVerificationTimeStamp { get; set; }

            [NameInMap("LastMobileVerificationTimeStamp")]
            [Validation(Required=false)]
            public long? LastMobileVerificationTimeStamp { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("Position")]
            [Validation(Required=false)]
            public string Position { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
