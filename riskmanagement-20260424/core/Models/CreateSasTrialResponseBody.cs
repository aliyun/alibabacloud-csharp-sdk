// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class CreateSasTrialResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSasTrialResponseBodyData Data { get; set; }
        public class CreateSasTrialResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public CreateSasTrialResponseBodyDataBody Body { get; set; }
            public class CreateSasTrialResponseBodyDataBody : TeaModel {
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
