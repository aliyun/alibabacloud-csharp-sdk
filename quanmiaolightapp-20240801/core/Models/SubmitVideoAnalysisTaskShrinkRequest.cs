// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class SubmitVideoAnalysisTaskShrinkRequest : TeaModel {
        [NameInMap("autoRoleRecognitionVideoUrl")]
        [Validation(Required=false)]
        public string AutoRoleRecognitionVideoUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deduplicationId")]
        [Validation(Required=false)]
        public string DeduplicationId { get; set; }

        [NameInMap("excludeGenerateOptions")]
        [Validation(Required=false)]
        public string ExcludeGenerateOptionsShrink { get; set; }

        [NameInMap("faceIdentitySimilarityMinScore")]
        [Validation(Required=false)]
        public float? FaceIdentitySimilarityMinScore { get; set; }

        [NameInMap("frameSampleMethod")]
        [Validation(Required=false)]
        public string FrameSampleMethodShrink { get; set; }

        [NameInMap("generateOptions")]
        [Validation(Required=false)]
        public string GenerateOptionsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chinese</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("modelCustomPromptTemplate")]
        [Validation(Required=false)]
        public string ModelCustomPromptTemplate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PlotDetail</para>
        /// </summary>
        [NameInMap("modelCustomPromptTemplateId")]
        [Validation(Required=false)]
        public string ModelCustomPromptTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("snapshotInterval")]
        [Validation(Required=false)]
        public double? SnapshotInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("splitInterval")]
        [Validation(Required=false)]
        public int? SplitInterval { get; set; }

        [NameInMap("textProcessTasks")]
        [Validation(Required=false)]
        public string TextProcessTasksShrink { get; set; }

        [NameInMap("videoCaptionInfo")]
        [Validation(Required=false)]
        public string VideoCaptionInfoShrink { get; set; }

        [NameInMap("videoExtraInfo")]
        [Validation(Required=false)]
        public string VideoExtraInfo { get; set; }

        [NameInMap("videoModelCustomPromptTemplate")]
        [Validation(Required=false)]
        public string VideoModelCustomPromptTemplate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-vl-max-latest</para>
        /// </summary>
        [NameInMap("videoModelId")]
        [Validation(Required=false)]
        public string VideoModelId { get; set; }

        [NameInMap("videoRoles")]
        [Validation(Required=false)]
        public string VideoRolesShrink { get; set; }

        [NameInMap("videoShotFaceIdentityCount")]
        [Validation(Required=false)]
        public int? VideoShotFaceIdentityCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxx.mp4">http://xxxx.mp4</a></para>
        /// </summary>
        [NameInMap("videoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
