// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Figure : TeaModel {
        /// <summary>
        /// <para>The age.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29</para>
        /// </summary>
        [NameInMap("Age")]
        [Validation(Required=false)]
        public long? Age { get; set; }

        /// <summary>
        /// <para>The age standard deviation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AgeSD")]
        [Validation(Required=false)]
        public float? AgeSD { get; set; }

        /// <summary>
        /// <para>The face attractiveness score. A higher score indicates greater attractiveness. Valid values: 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.96</para>
        /// </summary>
        [NameInMap("Attractive")]
        [Validation(Required=false)]
        public float? Attractive { get; set; }

        /// <summary>
        /// <para>Indicates whether the person has a beard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Beard")]
        [Validation(Required=false)]
        public string Beard { get; set; }

        /// <summary>
        /// <para>The confidence score for whether the person has a beard. Valid values: 0 (lowest confidence) to 1 (highest confidence).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BeardConfidence")]
        [Validation(Required=false)]
        public float? BeardConfidence { get; set; }

        /// <summary>
        /// <para>The face boundary information.</para>
        /// </summary>
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        /// <summary>
        /// <para>The emotion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>happiness</para>
        /// </summary>
        [NameInMap("Emotion")]
        [Validation(Required=false)]
        public string Emotion { get; set; }

        /// <summary>
        /// <para>The emotion confidence score. Valid values: 0 (lowest confidence) to 1 (highest confidence).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.707845687866210</para>
        /// </summary>
        [NameInMap("EmotionConfidence")]
        [Validation(Required=false)]
        public float? EmotionConfidence { get; set; }

        /// <summary>
        /// <para>The face quality score, which evaluates whether the image quality is suitable for face recognition. A higher score indicates better quality. Valid values: 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.960875928401947</para>
        /// </summary>
        [NameInMap("FaceQuality")]
        [Validation(Required=false)]
        public float? FaceQuality { get; set; }

        /// <summary>
        /// <para>The clustering confidence score. Valid values: 0 (lowest confidence) to 1 (highest confidence).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FigureClusterConfidence")]
        [Validation(Required=false)]
        public float? FigureClusterConfidence { get; set; }

        /// <summary>
        /// <para>The figure cluster ID. The following reserved special cluster ID names are included:</para>
        /// <list type="bullet">
        /// <item><description><para>figure-cluster-id-independent: The face does not currently belong to any suitable group. After new images are added to the dataset and face clustering is performed, the face may be assigned to a group.</para>
        /// </description></item>
        /// <item><description><para>figure-cluster-id-unavailable: The face has not been clustered yet. This means that after new images were added to the dataset, face clustering has not been performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster-dbe72fec-b84c-4ab6-885b-3678e64****</para>
        /// </summary>
        [NameInMap("FigureClusterId")]
        [Validation(Required=false)]
        public string FigureClusterId { get; set; }

        /// <summary>
        /// <para>The confidence score of the figure object. Valid values: 0 (lowest confidence) to 1 (highest confidence).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FigureConfidence")]
        [Validation(Required=false)]
        public float? FigureConfidence { get; set; }

        /// <summary>
        /// <para>The ID of the figure object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>868a9e74-cde5-4c7a-9013-28bb984****</para>
        /// </summary>
        [NameInMap("FigureId")]
        [Validation(Required=false)]
        public string FigureId { get; set; }

        /// <summary>
        /// <para>The figure type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>face</para>
        /// </summary>
        [NameInMap("FigureType")]
        [Validation(Required=false)]
        public string FigureType { get; set; }

        /// <summary>
        /// <para>The gender.</para>
        /// 
        /// <b>Example:</b>
        /// <para>female</para>
        /// </summary>
        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <para>The gender confidence score. Valid values: 0 (lowest confidence) to 1 (highest confidence).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GenderConfidence")]
        [Validation(Required=false)]
        public float? GenderConfidence { get; set; }

        /// <summary>
        /// <para>Indicates whether the person is wearing glasses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Glasses")]
        [Validation(Required=false)]
        public string Glasses { get; set; }

        /// <summary>
        /// <para>The confidence score for whether the person is wearing glasses. Valid values: 0 (lowest confidence) to 1 (highest confidence).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("GlassesConfidence")]
        [Validation(Required=false)]
        public float? GlassesConfidence { get; set; }

        /// <summary>
        /// <para>Indicates whether the person is wearing a hat.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Hat")]
        [Validation(Required=false)]
        public string Hat { get; set; }

        /// <summary>
        /// <para>The confidence score for whether the person is wearing a hat. Valid values: 0 (lowest confidence) to 1 (highest confidence).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HatConfidence")]
        [Validation(Required=false)]
        public float? HatConfidence { get; set; }

        /// <summary>
        /// <para>The head pose information.</para>
        /// </summary>
        [NameInMap("HeadPose")]
        [Validation(Required=false)]
        public HeadPose HeadPose { get; set; }

        /// <summary>
        /// <para>Indicates whether the person is wearing a mask.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>The confidence score for whether the person is wearing a mask. Valid values: 0 (lowest confidence) to 1 (highest confidence).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaskConfidence")]
        [Validation(Required=false)]
        public float? MaskConfidence { get; set; }

        /// <summary>
        /// <para>Indicates whether the mouth is open.</para>
        /// 
        /// <b>Example:</b>
        /// <para>close</para>
        /// </summary>
        [NameInMap("Mouth")]
        [Validation(Required=false)]
        public string Mouth { get; set; }

        /// <summary>
        /// <para>The confidence score for whether the mouth is open. Valid values: 0 (lowest confidence) to 1 (highest confidence).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MouthConfidence")]
        [Validation(Required=false)]
        public float? MouthConfidence { get; set; }

        /// <summary>
        /// <para>The sharpness score. A higher score indicates a clearer face. Valid values: 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("Sharpness")]
        [Validation(Required=false)]
        public float? Sharpness { get; set; }

    }

}
