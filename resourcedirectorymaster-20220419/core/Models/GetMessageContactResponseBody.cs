// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetMessageContactResponseBody : TeaModel {
        [NameInMap("Contact")]
        [Validation(Required=false)]
        public GetMessageContactResponseBodyContact Contact { get; set; }
        public class GetMessageContactResponseBodyContact : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
