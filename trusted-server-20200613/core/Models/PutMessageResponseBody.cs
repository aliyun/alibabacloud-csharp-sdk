// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class PutMessageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public PutMessageResponseBodyData Data { get; set; }
        public class PutMessageResponseBodyData : TeaModel {
            [NameInMap("kmoduleVerificationResult")]
            [Validation(Required=false)]
            public PutMessageResponseBodyDataKmoduleVerificationResult KmoduleVerificationResult { get; set; }
            public class PutMessageResponseBodyDataKmoduleVerificationResult : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("nextClientIMAIndex")]
            [Validation(Required=false)]
            public long? NextClientIMAIndex { get; set; }

            [NameInMap("policyProcResult")]
            [Validation(Required=false)]
            public PutMessageResponseBodyDataPolicyProcResult PolicyProcResult { get; set; }
            public class PutMessageResponseBodyDataPolicyProcResult : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("procData")]
                [Validation(Required=false)]
                public string ProcData { get; set; }

            }

            [NameInMap("programVerificationResult")]
            [Validation(Required=false)]
            public PutMessageResponseBodyDataProgramVerificationResult ProgramVerificationResult { get; set; }
            public class PutMessageResponseBodyDataProgramVerificationResult : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("systemVerificationResult")]
            [Validation(Required=false)]
            public PutMessageResponseBodyDataSystemVerificationResult SystemVerificationResult { get; set; }
            public class PutMessageResponseBodyDataSystemVerificationResult : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

    }

}
