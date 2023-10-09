// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CompanyThreeElementsVerificationResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompanyThreeElementsVerificationResponseBodyData Data { get; set; }
        public class CompanyThreeElementsVerificationResponseBodyData : TeaModel {
            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public CompanyThreeElementsVerificationResponseBodyDataDetailInfo DetailInfo { get; set; }
            public class CompanyThreeElementsVerificationResponseBodyDataDetailInfo : TeaModel {
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
