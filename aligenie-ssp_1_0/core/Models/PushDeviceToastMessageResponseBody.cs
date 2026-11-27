// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class PushDeviceToastMessageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public PushDeviceToastMessageResponseBodyResult Result { get; set; }
        public class PushDeviceToastMessageResponseBodyResult : TeaModel {
            [NameInMap("Accepted")]
            [Validation(Required=false)]
            public bool? Accepted { get; set; }

            [NameInMap("FailCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

        }

    }

}
