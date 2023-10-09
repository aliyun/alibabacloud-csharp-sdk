// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CompanyFourElementsVerificationResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompanyFourElementsVerificationResponseBodyData Data { get; set; }
        public class CompanyFourElementsVerificationResponseBodyData : TeaModel {
            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public CompanyFourElementsVerificationResponseBodyDataDetailInfo DetailInfo { get; set; }
            public class CompanyFourElementsVerificationResponseBodyDataDetailInfo : TeaModel {
                [NameInMap("EnterpriseStatus")]
                [Validation(Required=false)]
                public string EnterpriseStatus { get; set; }

                [NameInMap("OpenTime")]
                [Validation(Required=false)]
                public string OpenTime { get; set; }

            }

            [NameInMap("InconsistentData")]
            [Validation(Required=false)]
            public List<string> InconsistentData { get; set; }

            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public long? ReasonCode { get; set; }

            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
