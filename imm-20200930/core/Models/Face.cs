// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Face : TeaModel {
        /// <summary>
        /// FaceId
        /// </summary>
        [NameInMap("FaceId")]
        [Validation(Required=false)]
        public string FaceId { get; set; }

        /// <summary>
        /// FaceConfidence
        /// </summary>
        [NameInMap("FaceConfidence")]
        [Validation(Required=false)]
        public float? FaceConfidence { get; set; }

        /// <summary>
        /// Age
        /// </summary>
        [NameInMap("Age")]
        [Validation(Required=false)]
        public long? Age { get; set; }

        /// <summary>
        /// AgeConfidence
        /// </summary>
        [NameInMap("AgeConfidence")]
        [Validation(Required=false)]
        public float? AgeConfidence { get; set; }

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
        /// FaceClusterId
        /// </summary>
        [NameInMap("FaceClusterId")]
        [Validation(Required=false)]
        public string FaceClusterId { get; set; }

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

        /// <summary>
        /// Race
        /// </summary>
        [NameInMap("Race")]
        [Validation(Required=false)]
        public string Race { get; set; }

        /// <summary>
        /// RaceConfidence
        /// </summary>
        [NameInMap("RaceConfidence")]
        [Validation(Required=false)]
        public float? RaceConfidence { get; set; }

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
        /// LeftEye
        /// </summary>
        [NameInMap("LeftEye")]
        [Validation(Required=false)]
        public string LeftEye { get; set; }

        /// <summary>
        /// LeftEyeConfidence
        /// </summary>
        [NameInMap("LeftEyeConfidence")]
        [Validation(Required=false)]
        public float? LeftEyeConfidence { get; set; }

        /// <summary>
        /// RightEye
        /// </summary>
        [NameInMap("RightEye")]
        [Validation(Required=false)]
        public string RightEye { get; set; }

        /// <summary>
        /// RightEyeConfidence
        /// </summary>
        [NameInMap("RightEyeConfidence")]
        [Validation(Required=false)]
        public float? RightEyeConfidence { get; set; }

        [NameInMap("HeadPose")]
        [Validation(Required=false)]
        public HeadPose HeadPose { get; set; }

        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        /// <summary>
        /// EmbeddingsFloat32
        /// </summary>
        [NameInMap("EmbeddingsFloat32")]
        [Validation(Required=false)]
        public List<float?> EmbeddingsFloat32 { get; set; }

        /// <summary>
        /// EmbeddingsInt8
        /// </summary>
        [NameInMap("EmbeddingsInt8")]
        [Validation(Required=false)]
        public List<int?> EmbeddingsInt8 { get; set; }

    }

}
