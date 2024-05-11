// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageModerationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageModerationResponseBodyData Data { get; set; }
        public class ImageModerationResponseBodyData : TeaModel {
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("Ext")]
            [Validation(Required=false)]
            public ImageModerationResponseBodyDataExt Ext { get; set; }
            public class ImageModerationResponseBodyDataExt : TeaModel {
                [NameInMap("OcrResult")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtOcrResult> OcrResult { get; set; }
                public class ImageModerationResponseBodyDataExtOcrResult : TeaModel {
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtOcrResultLocation Location { get; set; }
                    public class ImageModerationResponseBodyDataExtOcrResultLocation : TeaModel {
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("Recognition")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtRecognition> Recognition { get; set; }
                public class ImageModerationResponseBodyDataExtRecognition : TeaModel {
                    [NameInMap("Classification")]
                    [Validation(Required=false)]
                    public string Classification { get; set; }

                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                }

            }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ImageModerationResponseBodyDataResult> Result { get; set; }
            public class ImageModerationResponseBodyDataResult : TeaModel {
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
