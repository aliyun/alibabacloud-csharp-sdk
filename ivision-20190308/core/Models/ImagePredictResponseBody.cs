// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class ImagePredictResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ImagePredict")]
        [Validation(Required=false)]
        public ImagePredictResponseBodyImagePredict ImagePredict { get; set; }
        public class ImagePredictResponseBodyImagePredict : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("PredictResult")]
            [Validation(Required=false)]
            public string PredictResult { get; set; }
            [NameInMap("PredictId")]
            [Validation(Required=false)]
            public string PredictId { get; set; }
            [NameInMap("PredictTime")]
            [Validation(Required=false)]
            public string PredictTime { get; set; }
            [NameInMap("DataUrl")]
            [Validation(Required=false)]
            public string DataUrl { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }
        };

    }

}
