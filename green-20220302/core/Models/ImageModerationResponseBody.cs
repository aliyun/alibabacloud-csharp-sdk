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
                [NameInMap("CustomImage")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtCustomImage> CustomImage { get; set; }
                public class ImageModerationResponseBodyDataExtCustomImage : TeaModel {
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    [NameInMap("LibId")]
                    [Validation(Required=false)]
                    public string LibId { get; set; }

                    [NameInMap("LibName")]
                    [Validation(Required=false)]
                    public string LibName { get; set; }

                }

                [NameInMap("LogoData")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtLogoData> LogoData { get; set; }
                public class ImageModerationResponseBodyDataExtLogoData : TeaModel {
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public ImageModerationResponseBodyDataExtLogoDataLocation Location { get; set; }
                    public class ImageModerationResponseBodyDataExtLogoDataLocation : TeaModel {
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

                    [NameInMap("Logo")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtLogoDataLogo> Logo { get; set; }
                    public class ImageModerationResponseBodyDataExtLogoDataLogo : TeaModel {
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

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

                [NameInMap("PublicFigure")]
                [Validation(Required=false)]
                public List<ImageModerationResponseBodyDataExtPublicFigure> PublicFigure { get; set; }
                public class ImageModerationResponseBodyDataExtPublicFigure : TeaModel {
                    [NameInMap("FigureId")]
                    [Validation(Required=false)]
                    public string FigureId { get; set; }

                    [NameInMap("FigureName")]
                    [Validation(Required=false)]
                    public string FigureName { get; set; }

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

                [NameInMap("TextInImage")]
                [Validation(Required=false)]
                public ImageModerationResponseBodyDataExtTextInImage TextInImage { get; set; }
                public class ImageModerationResponseBodyDataExtTextInImage : TeaModel {
                    [NameInMap("CustomText")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtTextInImageCustomText> CustomText { get; set; }
                    public class ImageModerationResponseBodyDataExtTextInImageCustomText : TeaModel {
                        [NameInMap("KeyWords")]
                        [Validation(Required=false)]
                        public string KeyWords { get; set; }

                        [NameInMap("LibId")]
                        [Validation(Required=false)]
                        public string LibId { get; set; }

                        [NameInMap("LibName")]
                        [Validation(Required=false)]
                        public string LibName { get; set; }

                    }

                    [NameInMap("OcrResult")]
                    [Validation(Required=false)]
                    public List<ImageModerationResponseBodyDataExtTextInImageOcrResult> OcrResult { get; set; }
                    public class ImageModerationResponseBodyDataExtTextInImageOcrResult : TeaModel {
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public ImageModerationResponseBodyDataExtTextInImageOcrResultLocation Location { get; set; }
                        public class ImageModerationResponseBodyDataExtTextInImageOcrResultLocation : TeaModel {
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

                    [NameInMap("RiskWord")]
                    [Validation(Required=false)]
                    public List<string> RiskWord { get; set; }

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

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
