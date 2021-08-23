// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class ListImagesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListImagesResponseBodyImages> Images { get; set; }
        public class ListImagesResponseBodyImages : TeaModel {
            [NameInMap("CroppingSuggestionStatus")]
            [Validation(Required=false)]
            public string CroppingSuggestionStatus { get; set; }

            [NameInMap("ImageQualityModifyTime")]
            [Validation(Required=false)]
            public string ImageQualityModifyTime { get; set; }

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

            [NameInMap("AddressModifyTime")]
            [Validation(Required=false)]
            public string AddressModifyTime { get; set; }

            [NameInMap("ImageQualityFailReason")]
            [Validation(Required=false)]
            public string ImageQualityFailReason { get; set; }

            [NameInMap("FacesStatus")]
            [Validation(Required=false)]
            public string FacesStatus { get; set; }

            [NameInMap("RemarksArrayA")]
            [Validation(Required=false)]
            public string RemarksArrayA { get; set; }

            [NameInMap("ImageHeight")]
            [Validation(Required=false)]
            public int? ImageHeight { get; set; }

            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("SourceUri")]
            [Validation(Required=false)]
            public string SourceUri { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("SourcePosition")]
            [Validation(Required=false)]
            public string SourcePosition { get; set; }

            [NameInMap("ImageQualityStatus")]
            [Validation(Required=false)]
            public string ImageQualityStatus { get; set; }

            [NameInMap("OCRFailReason")]
            [Validation(Required=false)]
            public string OCRFailReason { get; set; }

            [NameInMap("AddressFailReason")]
            [Validation(Required=false)]
            public string AddressFailReason { get; set; }

            [NameInMap("CroppingSuggestionModifyTime")]
            [Validation(Required=false)]
            public string CroppingSuggestionModifyTime { get; set; }

            [NameInMap("ImageFormat")]
            [Validation(Required=false)]
            public string ImageFormat { get; set; }

            [NameInMap("ImageWidth")]
            [Validation(Required=false)]
            public int? ImageWidth { get; set; }

            [NameInMap("RemarksArrayB")]
            [Validation(Required=false)]
            public string RemarksArrayB { get; set; }

            [NameInMap("Orientation")]
            [Validation(Required=false)]
            public string Orientation { get; set; }

            [NameInMap("RemarksD")]
            [Validation(Required=false)]
            public string RemarksD { get; set; }

            [NameInMap("TagsStatus")]
            [Validation(Required=false)]
            public string TagsStatus { get; set; }

            [NameInMap("CroppingSuggestionFailReason")]
            [Validation(Required=false)]
            public string CroppingSuggestionFailReason { get; set; }

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

            [NameInMap("AddressStatus")]
            [Validation(Required=false)]
            public string AddressStatus { get; set; }

            [NameInMap("Exif")]
            [Validation(Required=false)]
            public string Exif { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("RemarksB")]
            [Validation(Required=false)]
            public string RemarksB { get; set; }

            [NameInMap("CroppingSuggestion")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyImagesCroppingSuggestion> CroppingSuggestion { get; set; }
            public class ListImagesResponseBodyImagesCroppingSuggestion : TeaModel {
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("AspectRatio")]
                [Validation(Required=false)]
                public string AspectRatio { get; set; }

                [NameInMap("CroppingBoundary")]
                [Validation(Required=false)]
                public ListImagesResponseBodyImagesCroppingSuggestionCroppingBoundary CroppingBoundary { get; set; }
                public class ListImagesResponseBodyImagesCroppingSuggestionCroppingBoundary : TeaModel {
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

            [NameInMap("Faces")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyImagesFaces> Faces { get; set; }
            public class ListImagesResponseBodyImagesFaces : TeaModel {
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
                public ListImagesResponseBodyImagesFacesEmotionDetails EmotionDetails { get; set; }
                public class ListImagesResponseBodyImagesFacesEmotionDetails : TeaModel {
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
                public ListImagesResponseBodyImagesFacesFaceAttributes FaceAttributes { get; set; }
                public class ListImagesResponseBodyImagesFacesFaceAttributes : TeaModel {
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
                    public ListImagesResponseBodyImagesFacesFaceAttributesFaceBoundary FaceBoundary { get; set; }
                    public class ListImagesResponseBodyImagesFacesFaceAttributesFaceBoundary : TeaModel {
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
                    public ListImagesResponseBodyImagesFacesFaceAttributesHeadPose HeadPose { get; set; }
                    public class ListImagesResponseBodyImagesFacesFaceAttributesHeadPose : TeaModel {
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
            public List<ListImagesResponseBodyImagesTags> Tags { get; set; }
            public class ListImagesResponseBodyImagesTags : TeaModel {
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
            public List<ListImagesResponseBodyImagesOCR> OCR { get; set; }
            public class ListImagesResponseBodyImagesOCR : TeaModel {
                [NameInMap("OCRConfidence")]
                [Validation(Required=false)]
                public float? OCRConfidence { get; set; }

                [NameInMap("OCRContents")]
                [Validation(Required=false)]
                public string OCRContents { get; set; }

                [NameInMap("OCRBoundary")]
                [Validation(Required=false)]
                public ListImagesResponseBodyImagesOCROCRBoundary OCRBoundary { get; set; }
                public class ListImagesResponseBodyImagesOCROCRBoundary : TeaModel {
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

            [NameInMap("ImageQuality")]
            [Validation(Required=false)]
            public ListImagesResponseBodyImagesImageQuality ImageQuality { get; set; }
            public class ListImagesResponseBodyImagesImageQuality : TeaModel {
                [NameInMap("OverallScore")]
                [Validation(Required=false)]
                public float? OverallScore { get; set; }
                [NameInMap("Color")]
                [Validation(Required=false)]
                public float? Color { get; set; }
                [NameInMap("ColorScore")]
                [Validation(Required=false)]
                public float? ColorScore { get; set; }
                [NameInMap("ContrastScore")]
                [Validation(Required=false)]
                public float? ContrastScore { get; set; }
                [NameInMap("Contrast")]
                [Validation(Required=false)]
                public float? Contrast { get; set; }
                [NameInMap("ExposureScore")]
                [Validation(Required=false)]
                public float? ExposureScore { get; set; }
                [NameInMap("ClarityScore")]
                [Validation(Required=false)]
                public float? ClarityScore { get; set; }
                [NameInMap("Clarity")]
                [Validation(Required=false)]
                public float? Clarity { get; set; }
                [NameInMap("Exposure")]
                [Validation(Required=false)]
                public float? Exposure { get; set; }
                [NameInMap("CompositionScore")]
                [Validation(Required=false)]
                public float? CompositionScore { get; set; }
            };

            [NameInMap("Address")]
            [Validation(Required=false)]
            public ListImagesResponseBodyImagesAddress Address { get; set; }
            public class ListImagesResponseBodyImagesAddress : TeaModel {
                [NameInMap("Township")]
                [Validation(Required=false)]
                public string Township { get; set; }
                [NameInMap("District")]
                [Validation(Required=false)]
                public string District { get; set; }
                [NameInMap("AddressLine")]
                [Validation(Required=false)]
                public string AddressLine { get; set; }
                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }
                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }
            };

        }

    }

}
