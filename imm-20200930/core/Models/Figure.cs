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
        /// <para>The standard deviation of the age.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AgeSD")]
        [Validation(Required=false)]
        public float? AgeSD { get; set; }

        /// <summary>
        /// <para>The face attractiveness. A high score indicates strong attractiveness. Valid values: 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.96</para>
        /// </summary>
        [NameInMap("Attractive")]
        [Validation(Required=false)]
        public float? Attractive { get; set; }

        /// <summary>
        /// <para>Specifies whether the figure has a beard. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>beard</description></item>
        /// <item><description>none</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Beard")]
        [Validation(Required=false)]
        public string Beard { get; set; }

        /// <summary>
        /// <para>The confidence level of detecting whether the figure has a beard. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
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
        /// <para>The emotion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>happiness</description></item>
        /// <item><description>none</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>happiness</para>
        /// </summary>
        [NameInMap("Emotion")]
        [Validation(Required=false)]
        public string Emotion { get; set; }

        /// <summary>
        /// <para>The confidence level of the emotion. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.707845687866210</para>
        /// </summary>
        [NameInMap("EmotionConfidence")]
        [Validation(Required=false)]
        public float? EmotionConfidence { get; set; }

        /// <summary>
        /// <para>The face quality.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.960875928401947</para>
        /// </summary>
        [NameInMap("FaceQuality")]
        [Validation(Required=false)]
        public float? FaceQuality { get; set; }

        /// <summary>
        /// <para>The confidence level of the face clustering task. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FigureClusterConfidence")]
        [Validation(Required=false)]
        public float? FigureClusterConfidence { get; set; }

        /// <summary>
        /// <para>The ID of the face clustering task. The following IDs of special face clustering tasks are reserved:</para>
        /// <list type="bullet">
        /// <item><description>figure-cluster-id-independent: the ID of a face clustering task in which faces do not belong to any face group. After images are added to a dataset, the faces may be categorized into different face groups when you perform face clustering.</description></item>
        /// <item><description>figure-cluster-id-unavailable: the ID of a face clustering task in which face clustering is not performed after images are added to a dataset.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster-dbe72fec-b84c-4ab6-885b-3678e64****</para>
        /// </summary>
        [NameInMap("FigureClusterId")]
        [Validation(Required=false)]
        public string FigureClusterId { get; set; }

        /// <summary>
        /// <para>The confidence level of the figure. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FigureConfidence")]
        [Validation(Required=false)]
        public float? FigureConfidence { get; set; }

        /// <summary>
        /// <para>The figure ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>868a9e74-cde5-4c7a-9013-28bb984****</para>
        /// </summary>
        [NameInMap("FigureId")]
        [Validation(Required=false)]
        public string FigureId { get; set; }

        /// <summary>
        /// <para>The figure type.</para>
        /// <para>Set this parameter to face.</para>
        /// 
        /// <b>Example:</b>
        /// <para>face</para>
        /// </summary>
        [NameInMap("FigureType")]
        [Validation(Required=false)]
        public string FigureType { get; set; }

        /// <summary>
        /// <para>The gender. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>female</description></item>
        /// <item><description>male</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>female</para>
        /// </summary>
        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <para>The confidence level of the gender. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GenderConfidence")]
        [Validation(Required=false)]
        public float? GenderConfidence { get; set; }

        /// <summary>
        /// <para>Specifies whether the figure wears glasses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>glasses</description></item>
        /// <item><description>sunglasses</description></item>
        /// <item><description>none</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Glasses")]
        [Validation(Required=false)]
        public string Glasses { get; set; }

        /// <summary>
        /// <para>The confidence level of detecting whether the figure wears glasses. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("GlassesConfidence")]
        [Validation(Required=false)]
        public float? GlassesConfidence { get; set; }

        /// <summary>
        /// <para>Specifies whether the figure wears a hat. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hat</description></item>
        /// <item><description>none</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Hat")]
        [Validation(Required=false)]
        public string Hat { get; set; }

        /// <summary>
        /// <para>The confidence level of detecting whether the figure wears a hat.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HatConfidence")]
        [Validation(Required=false)]
        public float? HatConfidence { get; set; }

        /// <summary>
        /// <para>The head orientation.</para>
        /// </summary>
        [NameInMap("HeadPose")]
        [Validation(Required=false)]
        public HeadPose HeadPose { get; set; }

        /// <summary>
        /// <para>Specifies whether the figure wears a mask. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mask</description></item>
        /// <item><description>none</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        /// <summary>
        /// <para>The confidence level of detecting whether the figure wears a mask. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaskConfidence")]
        [Validation(Required=false)]
        public float? MaskConfidence { get; set; }

        /// <summary>
        /// <para>Specifies whether the mouth is open. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>open</description></item>
        /// <item><description>close</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>close</para>
        /// </summary>
        [NameInMap("Mouth")]
        [Validation(Required=false)]
        public string Mouth { get; set; }

        /// <summary>
        /// <para>The confidence level of detecting whether the mouth is open. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MouthConfidence")]
        [Validation(Required=false)]
        public float? MouthConfidence { get; set; }

        /// <summary>
        /// <para>The clarity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("Sharpness")]
        [Validation(Required=false)]
        public float? Sharpness { get; set; }

    }

}
