// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Figure : TeaModel {
        [NameInMap("Age")]
        [Validation(Required=false)]
        public long? Age { get; set; }

        [NameInMap("AgeSD")]
        [Validation(Required=false)]
        public float? AgeSD { get; set; }

        [NameInMap("Attractive")]
        [Validation(Required=false)]
        public float? Attractive { get; set; }

        [NameInMap("Beard")]
        [Validation(Required=false)]
        public string Beard { get; set; }

        [NameInMap("BeardConfidence")]
        [Validation(Required=false)]
        public float? BeardConfidence { get; set; }

        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        [NameInMap("Emotion")]
        [Validation(Required=false)]
        public string Emotion { get; set; }

        [NameInMap("EmotionConfidence")]
        [Validation(Required=false)]
        public float? EmotionConfidence { get; set; }

        [NameInMap("FaceQuality")]
        [Validation(Required=false)]
        public float? FaceQuality { get; set; }

        [NameInMap("FigureClusterConfidence")]
        [Validation(Required=false)]
        public float? FigureClusterConfidence { get; set; }

        [NameInMap("FigureClusterId")]
        [Validation(Required=false)]
        public string FigureClusterId { get; set; }

        [NameInMap("FigureConfidence")]
        [Validation(Required=false)]
        public float? FigureConfidence { get; set; }

        [NameInMap("FigureId")]
        [Validation(Required=false)]
        public string FigureId { get; set; }

        [NameInMap("FigureType")]
        [Validation(Required=false)]
        public string FigureType { get; set; }

        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("GenderConfidence")]
        [Validation(Required=false)]
        public float? GenderConfidence { get; set; }

        [NameInMap("Glasses")]
        [Validation(Required=false)]
        public string Glasses { get; set; }

        [NameInMap("GlassesConfidence")]
        [Validation(Required=false)]
        public float? GlassesConfidence { get; set; }

        [NameInMap("Hat")]
        [Validation(Required=false)]
        public string Hat { get; set; }

        [NameInMap("HatConfidence")]
        [Validation(Required=false)]
        public float? HatConfidence { get; set; }

        [NameInMap("HeadPose")]
        [Validation(Required=false)]
        public HeadPose HeadPose { get; set; }

        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        [NameInMap("MaskConfidence")]
        [Validation(Required=false)]
        public float? MaskConfidence { get; set; }

        [NameInMap("Mouth")]
        [Validation(Required=false)]
        public string Mouth { get; set; }

        [NameInMap("MouthConfidence")]
        [Validation(Required=false)]
        public float? MouthConfidence { get; set; }

        [NameInMap("Sharpness")]
        [Validation(Required=false)]
        public float? Sharpness { get; set; }

    }

}
