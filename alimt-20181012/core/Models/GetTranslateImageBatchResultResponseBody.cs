// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetTranslateImageBatchResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTranslateImageBatchResultResponseBodyData Data { get; set; }
        public class GetTranslateImageBatchResultResponseBodyData : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetTranslateImageBatchResultResponseBodyDataResult> Result { get; set; }
            public class GetTranslateImageBatchResultResponseBodyDataResult : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                [NameInMap("FinalImageUrl")]
                [Validation(Required=false)]
                public string FinalImageUrl { get; set; }

                [NameInMap("InPaintingUrl")]
                [Validation(Required=false)]
                public string InPaintingUrl { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("SourceImageUrl")]
                [Validation(Required=false)]
                public string SourceImageUrl { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                [NameInMap("TemplateJson")]
                [Validation(Required=false)]
                public string TemplateJson { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
