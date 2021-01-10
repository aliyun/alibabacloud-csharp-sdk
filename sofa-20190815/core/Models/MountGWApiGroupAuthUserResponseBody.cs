// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class MountGWApiGroupAuthUserResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public MountGWApiGroupAuthUserResponseBodyData Data { get; set; }
        public class MountGWApiGroupAuthUserResponseBodyData : TeaModel {
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<MountGWApiGroupAuthUserResponseBodyDataResults> Results { get; set; }
            public class MountGWApiGroupAuthUserResponseBodyDataResults : TeaModel {
                public string Code { get; set; }
                public string ErrorMessage { get; set; }
                public string Id { get; set; }
                public bool? Success { get; set; }
            }
        };

    }

}
