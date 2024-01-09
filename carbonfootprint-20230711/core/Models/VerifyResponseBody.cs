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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
