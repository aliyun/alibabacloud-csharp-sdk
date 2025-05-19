// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class GetContactsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public GetContactsResponseBodyDatapoints Datapoints { get; set; }
        public class GetContactsResponseBodyDatapoints : TeaModel {
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public GetContactsResponseBodyDatapointsContacts Contacts { get; set; }
            public class GetContactsResponseBodyDatapointsContacts : TeaModel {
                [NameInMap("Contact")]
                [Validation(Required=false)]
                public List<string> Contact { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
