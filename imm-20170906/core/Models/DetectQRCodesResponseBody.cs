// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class DetectQRCodesResponseBody : TeaModel {
        [NameInMap("FailDetails")]
        [Validation(Required=false)]
        public List<DetectQRCodesResponseBodyFailDetails> FailDetails { get; set; }
        public class DetectQRCodesResponseBodyFailDetails : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("SrcUri")]
            [Validation(Required=false)]
            public string SrcUri { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessDetails")]
        [Validation(Required=false)]
        public List<DetectQRCodesResponseBodySuccessDetails> SuccessDetails { get; set; }
        public class DetectQRCodesResponseBodySuccessDetails : TeaModel {
            [NameInMap("QRCodes")]
            [Validation(Required=false)]
            public List<DetectQRCodesResponseBodySuccessDetailsQRCodes> QRCodes { get; set; }
            public class DetectQRCodesResponseBodySuccessDetailsQRCodes : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("QRCodesRectangle")]
                [Validation(Required=false)]
                public DetectQRCodesResponseBodySuccessDetailsQRCodesQRCodesRectangle QRCodesRectangle { get; set; }
                public class DetectQRCodesResponseBodySuccessDetailsQRCodesQRCodesRectangle : TeaModel {
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public string Left { get; set; }
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public string Top { get; set; }
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }
                };

            }

            [NameInMap("SrcUri")]
            [Validation(Required=false)]
            public string SrcUri { get; set; }

        }

    }

}
