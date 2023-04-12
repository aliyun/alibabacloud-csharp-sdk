// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetMessageContactDeletionStatusResponseBody : TeaModel {
        [NameInMap("ContactDeletionStatus")]
        [Validation(Required=false)]
        public GetMessageContactDeletionStatusResponseBodyContactDeletionStatus ContactDeletionStatus { get; set; }
        public class GetMessageContactDeletionStatusResponseBodyContactDeletionStatus : TeaModel {
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("FailReasonList")]
            [Validation(Required=false)]
            public List<GetMessageContactDeletionStatusResponseBodyContactDeletionStatusFailReasonList> FailReasonList { get; set; }
            public class GetMessageContactDeletionStatusResponseBodyContactDeletionStatusFailReasonList : TeaModel {
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("MessageTypes")]
                [Validation(Required=false)]
                public List<string> MessageTypes { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
