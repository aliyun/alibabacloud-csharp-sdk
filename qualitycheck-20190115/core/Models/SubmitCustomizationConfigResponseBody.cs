// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class SubmitCustomizationConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitCustomizationConfigResponseBodyData Data { get; set; }
        public class SubmitCustomizationConfigResponseBodyData : TeaModel {
            [NameInMap("ModelStatus")]
            [Validation(Required=false)]
            public int? ModelStatus { get; set; }
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public long? ModelId { get; set; }
            [NameInMap("ModeCustomizationId")]
            [Validation(Required=false)]
            public string ModeCustomizationId { get; set; }
        };

    }

}
