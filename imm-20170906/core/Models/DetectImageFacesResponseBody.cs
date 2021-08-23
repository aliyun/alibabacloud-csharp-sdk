// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class DetectImageFacesResponseBody : TeaModel {
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Faces")]
        [Validation(Required=false)]
        public List<DetectImageFacesResponseBodyFaces> Faces { get; set; }
        public class DetectImageFacesResponseBodyFaces : TeaModel {
            [NameInMap("EmotionConfidence")]
            [Validation(Required=false)]
            public float? EmotionConfidence { get; set; }

            [NameInMap("Attractive")]
            [Validation(Required=false)]
            public float? Attractive { get; set; }

            [NameInMap("AttractiveConfidence")]
            [Validation(Required=false)]
            public float? AttractiveConfidence { get; set; }

            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("AgeConfidence")]
            [Validation(Required=false)]
            public float? AgeConfidence { get; set; }

            [NameInMap("GenderConfidence")]
            [Validation(Required=false)]
            public float? GenderConfidence { get; set; }

            [NameInMap("FaceId")]
            [Validation(Required=false)]
            public string FaceId { get; set; }

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

            [NameInMap("FaceAttributes")]
            [Validation(Required=false)]
            public DetectImageFacesResponseBodyFacesFaceAttributes FaceAttributes { get; set; }
            public class DetectImageFacesResponseBodyFacesFaceAttributes : TeaModel {
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
                public DetectImageFacesResponseBodyFacesFaceAttributesFaceBoundary FaceBoundary { get; set; }
                public class DetectImageFacesResponseBodyFacesFaceAttributesFaceBoundary : TeaModel {
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
                public DetectImageFacesResponseBodyFacesFaceAttributesHeadPose HeadPose { get; set; }
                public class DetectImageFacesResponseBodyFacesFaceAttributesHeadPose : TeaModel {
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

            [NameInMap("EmotionDetails")]
            [Validation(Required=false)]
            public DetectImageFacesResponseBodyFacesEmotionDetails EmotionDetails { get; set; }
            public class DetectImageFacesResponseBodyFacesEmotionDetails : TeaModel {
                [NameInMap("HAPPY")]
                [Validation(Required=false)]
                public float? HAPPY { get; set; }
                [NameInMap("CALM")]
                [Validation(Required=false)]
                public float? CALM { get; set; }
                [NameInMap("SURPRISED")]
                [Validation(Required=false)]
                public float? SURPRISED { get; set; }
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

        }

    }

}
