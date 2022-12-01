// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAccountDeletionStatusResponseBody : TeaModel {
        [NameInMap("RdAccountDeletionStatus")]
        [Validation(Required=false)]
        public GetAccountDeletionStatusResponseBodyRdAccountDeletionStatus RdAccountDeletionStatus { get; set; }
        public class GetAccountDeletionStatusResponseBodyRdAccountDeletionStatus : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeletionTime")]
            [Validation(Required=false)]
            public string DeletionTime { get; set; }

            [NameInMap("DeletionType")]
            [Validation(Required=false)]
            public string DeletionType { get; set; }

            [NameInMap("FailReasonList")]
            [Validation(Required=false)]
            public List<GetAccountDeletionStatusResponseBodyRdAccountDeletionStatusFailReasonList> FailReasonList { get; set; }
            public class GetAccountDeletionStatusResponseBodyRdAccountDeletionStatusFailReasonList : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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
