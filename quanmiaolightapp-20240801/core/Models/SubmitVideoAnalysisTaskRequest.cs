// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class SubmitVideoAnalysisTaskRequest : TeaModel {
        [NameInMap("faceIdentitySimilarityMinScore")]
        [Validation(Required=false)]
        public float? FaceIdentitySimilarityMinScore { get; set; }

        [NameInMap("frameSampleMethod")]
        [Validation(Required=false)]
        public SubmitVideoAnalysisTaskRequestFrameSampleMethod FrameSampleMethod { get; set; }
        public class SubmitVideoAnalysisTaskRequestFrameSampleMethod : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("interval")]
            [Validation(Required=false)]
            public double? Interval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("methodName")]
            [Validation(Required=false)]
            public string MethodName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>768</para>
            /// </summary>
            [NameInMap("pixel")]
            [Validation(Required=false)]
            public int? Pixel { get; set; }

        }

        [NameInMap("generateOptions")]
        [Validation(Required=false)]
        public List<string> GenerateOptions { get; set; }

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
        public List<SubmitVideoAnalysisTaskRequestTextProcessTasks> TextProcessTasks { get; set; }
        public class SubmitVideoAnalysisTaskRequestTextProcessTasks : TeaModel {
            [NameInMap("modelCustomPromptTemplate")]
            [Validation(Required=false)]
            public string ModelCustomPromptTemplate { get; set; }

            [NameInMap("modelCustomPromptTemplateId")]
            [Validation(Required=false)]
            public string ModelCustomPromptTemplateId { get; set; }

            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

        }

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
        public List<SubmitVideoAnalysisTaskRequestVideoRoles> VideoRoles { get; set; }
        public class SubmitVideoAnalysisTaskRequestVideoRoles : TeaModel {
            [NameInMap("roleInfo")]
            [Validation(Required=false)]
            public string RoleInfo { get; set; }

            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("urls")]
            [Validation(Required=false)]
            public List<string> Urls { get; set; }

        }

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
