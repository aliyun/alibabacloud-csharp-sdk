// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateImageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TranslateImageResponseBodyData Data { get; set; }
        public class TranslateImageResponseBodyData : TeaModel {
            [NameInMap("FinalImageUrl")]
            [Validation(Required=false)]
            public string FinalImageUrl { get; set; }
            [NameInMap("InPaintingUrl")]
            [Validation(Required=false)]
            public string InPaintingUrl { get; set; }
            [NameInMap("TemplateJson")]
            [Validation(Required=false)]
            public string TemplateJson { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
