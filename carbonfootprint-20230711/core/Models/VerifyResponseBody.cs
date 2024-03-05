// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CarbonFootprint20230711.Models
{
    public class VerifyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifyResponseBodyData Data { get; set; }
        public class VerifyResponseBodyData : TeaModel {
            [NameInMap("AllowedUids")]
            [Validation(Required=false)]
            public List<string> AllowedUids { get; set; }

            [NameInMap("accountType")]
            [Validation(Required=false)]
            public int? AccountType { get; set; }

            [NameInMap("allMultiAccountUids")]
            [Validation(Required=false)]
            public List<VerifyResponseBodyDataAllMultiAccountUids> AllMultiAccountUids { get; set; }
            public class VerifyResponseBodyDataAllMultiAccountUids : TeaModel {
                [NameInMap("accountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("multiAccountsAllow")]
            [Validation(Required=false)]
            public int? MultiAccountsAllow { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
