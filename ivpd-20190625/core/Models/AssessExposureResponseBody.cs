// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class AssessExposureResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AssessExposureResponseBodyData Data { get; set; }
        public class AssessExposureResponseBodyData : TeaModel {
            [NameInMap("Exposure")]
            [Validation(Required=false)]
            public float? Exposure { get; set; }
        };

    }

}
