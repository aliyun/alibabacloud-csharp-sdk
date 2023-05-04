// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetAccountDeletionCheckResultResponseBody : TeaModel {
        [NameInMap("AccountDeletionCheckResultInfo")]
        [Validation(Required=false)]
        public GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfo AccountDeletionCheckResultInfo { get; set; }
        public class GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfo : TeaModel {
            [NameInMap("AbandonableChecks")]
            [Validation(Required=false)]
            public List<GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoAbandonableChecks> AbandonableChecks { get; set; }
            public class GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoAbandonableChecks : TeaModel {
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            [NameInMap("AllowDelete")]
            [Validation(Required=false)]
            public string AllowDelete { get; set; }

            [NameInMap("NotAllowReason")]
            [Validation(Required=false)]
            public List<GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoNotAllowReason> NotAllowReason { get; set; }
            public class GetAccountDeletionCheckResultResponseBodyAccountDeletionCheckResultInfoNotAllowReason : TeaModel {
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

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
