// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ImageBlindCharacterWatermarkResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageBlindCharacterWatermarkResponseBodyData Data { get; set; }
        public class ImageBlindCharacterWatermarkResponseBodyData : TeaModel {
            [NameInMap("WatermarkImageURL")]
            [Validation(Required=false)]
            public string WatermarkImageURL { get; set; }
            [NameInMap("TextImageURL")]
            [Validation(Required=false)]
            public string TextImageURL { get; set; }
        };

    }

}
