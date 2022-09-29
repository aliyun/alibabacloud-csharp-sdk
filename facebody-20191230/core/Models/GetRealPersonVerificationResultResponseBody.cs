// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GetRealPersonVerificationResultResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRealPersonVerificationResultResponseBodyData Data { get; set; }
        public class GetRealPersonVerificationResultResponseBodyData : TeaModel {
            [NameInMap("IdentityInfo")]
            [Validation(Required=false)]
            public string IdentityInfo { get; set; }

            [NameInMap("MaterialMatch")]
            [Validation(Required=false)]
            public string MaterialMatch { get; set; }

            [NameInMap("Passed")]
            [Validation(Required=false)]
            public bool? Passed { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
