// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Figure : TeaModel {
        /// <summary>
        /// Age
        /// </summary>
        [NameInMap("Age")]
        [Validation(Required=false)]
        public long? Age { get; set; }

        /// <summary>
        /// AgeSD
        /// </summary>
        [NameInMap("AgeSD")]
        [Validation(Required=false)]
        public float? AgeSD { get; set; }

        /// <summary>
        /// Attractive
        /// </summary>
        [NameInMap("Attractive")]
        [Validation(Required=false)]
        public float? Attractive { get; set; }

        /// <summary>
        /// Beard
        /// </summary>
        [NameInMap("Beard")]
        [Validation(Required=false)]
        public string Beard { get; set; }

        /// <summary>
        /// BeardConfidence
        /// </summary>
        [NameInMap("BeardConfidence")]
        [Validation(Required=false)]
        public float? BeardConfidence { get; set; }

        /// <summary>
        /// Boundary
        /// </summary>
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        /// <summary>
        /// Emotion
        /// </summary>
        [NameInMap("Emotion")]
        [Validation(Required=false)]
        public string Emotion { get; set; }

        /// <summary>
        /// EmotionConfidence
        /// </summary>
        [NameInMap("EmotionConfidence")]
        [Validation(Required=false)]
        public float? EmotionConfidence { get; set; }

        /// <summary>
        /// FaceQuality
        /// </summary>
        [NameInMap("FaceQuality")]
        [Validation(Required=false)]
        public float? FaceQuality { get; set; }

        /// <summary>
        /// FigureClusterConfidence
        /// </summary>
        [NameInMap("FigureClusterConfidence")]
        [Validation(Required=false)]
        public float? FigureClusterConfidence { get; set; }

        /// <summary>
        /// FigureClusterId
        /// </summary>
        [NameInMap("FigureClusterId")]
        [Validation(Required=false)]
        public string FigureClusterId { get; set; }

        /// <summary>
        /// FigureConfidence
        /// </summary>
        [NameInMap("FigureConfidence")]
        [Validation(Required=false)]
        public float? FigureConfidence { get; set; }

        /// <summary>
        /// FigureId
        /// </summary>
        [NameInMap("FigureId")]
        [Validation(Required=false)]
        public string FigureId { get; set; }

        /// <summary>
        /// FigureType
        /// </summary>
        [NameInMap("FigureType")]
        [Validation(Required=false)]
        public string FigureType { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// GenderConfidence
        /// </summary>
        [NameInMap("GenderConfidence")]
        [Validation(Required=false)]
        public float? GenderConfidence { get; set; }

        /// <summary>
        /// Glasses
        /// </summary>
        [NameInMap("Glasses")]
        [Validation(Required=false)]
        public string Glasses { get; set; }

        /// <summary>
        /// GlassesConfidence
        /// </summary>
        [NameInMap("GlassesConfidence")]
        [Validation(Required=false)]
        public float? GlassesConfidence { get; set; }

        /// <summary>
        /// Hat
        /// </summary>
        [NameInMap("Hat")]
        [Validation(Required=false)]
        public string Hat { get; set; }

        /// <summary>
        /// HatConfidence
        /// </summary>
        [NameInMap("HatConfidence")]
        [Validation(Required=false)]
        public float? HatConfidence { get; set; }

        [NameInMap("HeadPose")]
        [Validation(Required=false)]
        public HeadPose HeadPose { get; set; }

        /// <summary>
        /// Mask
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// MaskConfidence
        /// </summary>
        [NameInMap("MaskConfidence")]
        [Validation(Required=false)]
        public float? MaskConfidence { get; set; }

        /// <summary>
        /// Mouth
        /// </summary>
        [NameInMap("Mouth")]
        [Validation(Required=false)]
        public string Mouth { get; set; }

        /// <summary>
        /// MouthConfidence
        /// </summary>
        [NameInMap("MouthConfidence")]
        [Validation(Required=false)]
        public float? MouthConfidence { get; set; }

        /// <summary>
        /// Sharpness
        /// </summary>
        [NameInMap("Sharpness")]
        [Validation(Required=false)]
        public float? Sharpness { get; set; }

    }

}
