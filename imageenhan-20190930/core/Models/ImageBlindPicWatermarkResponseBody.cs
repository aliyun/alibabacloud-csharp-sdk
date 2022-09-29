// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ImageBlindPicWatermarkResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageBlindPicWatermarkResponseBodyData Data { get; set; }
        public class ImageBlindPicWatermarkResponseBodyData : TeaModel {
            [NameInMap("LogoURL")]
            [Validation(Required=false)]
            public string LogoURL { get; set; }

            [NameInMap("WatermarkImageURL")]
            [Validation(Required=false)]
            public string WatermarkImageURL { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
