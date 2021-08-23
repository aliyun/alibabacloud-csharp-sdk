// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class DetectImageQRCodesResponseBody : TeaModel {
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("QRCodes")]
        [Validation(Required=false)]
        public List<DetectImageQRCodesResponseBodyQRCodes> QRCodes { get; set; }
        public class DetectImageQRCodesResponseBodyQRCodes : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("QRCodeBoundary")]
            [Validation(Required=false)]
            public DetectImageQRCodesResponseBodyQRCodesQRCodeBoundary QRCodeBoundary { get; set; }
            public class DetectImageQRCodesResponseBodyQRCodesQRCodeBoundary : TeaModel {
                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }
            };

        }

    }

}
