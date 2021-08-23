// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class ListVideoFramesResponseBody : TeaModel {
        [NameInMap("VideoUri")]
        [Validation(Required=false)]
        public string VideoUri { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("Frames")]
        [Validation(Required=false)]
        public List<ListVideoFramesResponseBodyFrames> Frames { get; set; }
        public class ListVideoFramesResponseBodyFrames : TeaModel {
            [NameInMap("TagsFailReason")]
            [Validation(Required=false)]
            public string TagsFailReason { get; set; }

            [NameInMap("RemarksC")]
            [Validation(Required=false)]
            public string RemarksC { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("FacesFailReason")]
            [Validation(Required=false)]
            public string FacesFailReason { get; set; }

            [NameInMap("FacesModifyTime")]
            [Validation(Required=false)]
            public string FacesModifyTime { get; set; }

            [NameInMap("ImageTime")]
            [Validation(Required=false)]
            public string ImageTime { get; set; }

            [NameInMap("OCRModifyTime")]
            [Validation(Required=false)]
            public string OCRModifyTime { get; set; }

            [NameInMap("FacesStatus")]
            [Validation(Required=false)]
            public string FacesStatus { get; set; }

            [NameInMap("ImageHeight")]
            [Validation(Required=false)]
            public int? ImageHeight { get; set; }

            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("SourceUri")]
            [Validation(Required=false)]
            public string SourceUri { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            [NameInMap("SourcePosition")]
            [Validation(Required=false)]
            public string SourcePosition { get; set; }

            [NameInMap("OCRFailReason")]
            [Validation(Required=false)]
            public string OCRFailReason { get; set; }

            [NameInMap("ImageFormat")]
            [Validation(Required=false)]
            public string ImageFormat { get; set; }

            [NameInMap("ImageWidth")]
            [Validation(Required=false)]
            public int? ImageWidth { get; set; }

            [NameInMap("Orientation")]
            [Validation(Required=false)]
            public string Orientation { get; set; }

            [NameInMap("RemarksD")]
            [Validation(Required=false)]
            public string RemarksD { get; set; }

            [NameInMap("TagsStatus")]
            [Validation(Required=false)]
            public string TagsStatus { get; set; }

            [NameInMap("RemarksA")]
            [Validation(Required=false)]
            public string RemarksA { get; set; }

            [NameInMap("ImageUri")]
            [Validation(Required=false)]
            public string ImageUri { get; set; }

            [NameInMap("TagsModifyTime")]
            [Validation(Required=false)]
            public string TagsModifyTime { get; set; }

            [NameInMap("OCRStatus")]
            [Validation(Required=false)]
            public string OCRStatus { get; set; }

            [NameInMap("Exif")]
            [Validation(Required=false)]
            public string Exif { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("RemarksB")]
            [Validation(Required=false)]
            public string RemarksB { get; set; }

            [NameInMap("Faces")]
            [Validation(Required=false)]
            public List<ListVideoFramesResponseBodyFramesFaces> Faces { get; set; }
            public class ListVideoFramesResponseBodyFramesFaces : TeaModel {
                [NameInMap("EmotionConfidence")]
                [Validation(Required=false)]
                public float? EmotionConfidence { get; set; }

                [NameInMap("Attractive")]
                [Validation(Required=false)]
                public float? Attractive { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                [NameInMap("FaceId")]
                [Validation(Required=false)]
                public string FaceId { get; set; }

                [NameInMap("GenderConfidence")]
                [Validation(Required=false)]
                public float? GenderConfidence { get; set; }

                [NameInMap("FaceQuality")]
                [Validation(Required=false)]
                public float? FaceQuality { get; set; }

                [NameInMap("Emotion")]
                [Validation(Required=false)]
                public string Emotion { get; set; }

                [NameInMap("Age")]
                [Validation(Required=false)]
                public int? Age { get; set; }

                [NameInMap("FaceConfidence")]
                [Validation(Required=false)]
                public float? FaceConfidence { get; set; }

                [NameInMap("EmotionDetails")]
                [Validation(Required=false)]
                public ListVideoFramesResponseBodyFramesFacesEmotionDetails EmotionDetails { get; set; }
                public class ListVideoFramesResponseBodyFramesFacesEmotionDetails : TeaModel {
                    [NameInMap("HAPPY")]
                    [Validation(Required=false)]
                    public float? HAPPY { get; set; }
                    [NameInMap("SURPRISED")]
                    [Validation(Required=false)]
                    public float? SURPRISED { get; set; }
                    [NameInMap("CALM")]
                    [Validation(Required=false)]
                    public float? CALM { get; set; }
                    [NameInMap("DISGUSTED")]
                    [Validation(Required=false)]
                    public float? DISGUSTED { get; set; }
                    [NameInMap("ANGRY")]
                    [Validation(Required=false)]
                    public float? ANGRY { get; set; }
                    [NameInMap("SAD")]
                    [Validation(Required=false)]
                    public float? SAD { get; set; }
                    [NameInMap("SCARED")]
                    [Validation(Required=false)]
                    public float? SCARED { get; set; }
                };

                [NameInMap("FaceAttributes")]
                [Validation(Required=false)]
                public ListVideoFramesResponseBodyFramesFacesFaceAttributes FaceAttributes { get; set; }
                public class ListVideoFramesResponseBodyFramesFacesFaceAttributes : TeaModel {
                    [NameInMap("GlassesConfidence")]
                    [Validation(Required=false)]
                    public float? GlassesConfidence { get; set; }
                    [NameInMap("Glasses")]
                    [Validation(Required=false)]
                    public string Glasses { get; set; }
                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public string Mask { get; set; }
                    [NameInMap("BeardConfidence")]
                    [Validation(Required=false)]
                    public float? BeardConfidence { get; set; }
                    [NameInMap("MaskConfidence")]
                    [Validation(Required=false)]
                    public float? MaskConfidence { get; set; }
                    [NameInMap("Beard")]
                    [Validation(Required=false)]
                    public string Beard { get; set; }
                    [NameInMap("FaceBoundary")]
                    [Validation(Required=false)]
                    public ListVideoFramesResponseBodyFramesFacesFaceAttributesFaceBoundary FaceBoundary { get; set; }
                    public class ListVideoFramesResponseBodyFramesFacesFaceAttributesFaceBoundary : TeaModel {
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

                    }
                    [NameInMap("HeadPose")]
                    [Validation(Required=false)]
                    public ListVideoFramesResponseBodyFramesFacesFaceAttributesHeadPose HeadPose { get; set; }
                    public class ListVideoFramesResponseBodyFramesFacesFaceAttributesHeadPose : TeaModel {
                        [NameInMap("Pitch")]
                        [Validation(Required=false)]
                        public float? Pitch { get; set; }

                        [NameInMap("Roll")]
                        [Validation(Required=false)]
                        public float? Roll { get; set; }

                        [NameInMap("Yaw")]
                        [Validation(Required=false)]
                        public float? Yaw { get; set; }

                    }
                };

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVideoFramesResponseBodyFramesTags> Tags { get; set; }
            public class ListVideoFramesResponseBodyFramesTags : TeaModel {
                [NameInMap("TagLevel")]
                [Validation(Required=false)]
                public int? TagLevel { get; set; }

                [NameInMap("ParentTagName")]
                [Validation(Required=false)]
                public string ParentTagName { get; set; }

                [NameInMap("TagConfidence")]
                [Validation(Required=false)]
                public float? TagConfidence { get; set; }

                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            [NameInMap("OCR")]
            [Validation(Required=false)]
            public List<ListVideoFramesResponseBodyFramesOCR> OCR { get; set; }
            public class ListVideoFramesResponseBodyFramesOCR : TeaModel {
                [NameInMap("OCRConfidence")]
                [Validation(Required=false)]
                public float? OCRConfidence { get; set; }

                [NameInMap("OCRContents")]
                [Validation(Required=false)]
                public string OCRContents { get; set; }

                [NameInMap("OCRBoundary")]
                [Validation(Required=false)]
                public ListVideoFramesResponseBodyFramesOCROCRBoundary OCRBoundary { get; set; }
                public class ListVideoFramesResponseBodyFramesOCROCRBoundary : TeaModel {
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

}
