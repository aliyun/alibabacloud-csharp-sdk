// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScenePreviewInfoResponseBodyData Data { get; set; }
        public class GetScenePreviewInfoResponseBodyData : TeaModel {
            [NameInMap("ModelPath")]
            [Validation(Required=false)]
            public string ModelPath { get; set; }
            [NameInMap("PanoList")]
            [Validation(Required=false)]
            public string PanoList { get; set; }
            [NameInMap("TextureModelPath")]
            [Validation(Required=false)]
            public string TextureModelPath { get; set; }
            [NameInMap("TexturePanoPath")]
            [Validation(Required=false)]
            public string TexturePanoPath { get; set; }
        };

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
