// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class BatchIntrudeDomainsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchIntrudeDomainsResponseBodyData Data { get; set; }
        public class BatchIntrudeDomainsResponseBodyData : TeaModel {
            [NameInMap("FailureCount")]
            [Validation(Required=false)]
            public int? FailureCount { get; set; }

            [NameInMap("FailureList")]
            [Validation(Required=false)]
            public List<BatchIntrudeDomainsResponseBodyDataFailureList> FailureList { get; set; }
            public class BatchIntrudeDomainsResponseBodyDataFailureList : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            [NameInMap("SuccessList")]
            [Validation(Required=false)]
            public List<BatchIntrudeDomainsResponseBodyDataSuccessList> SuccessList { get; set; }
            public class BatchIntrudeDomainsResponseBodyDataSuccessList : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
