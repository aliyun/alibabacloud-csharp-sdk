// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class SubmitVideoAnalysisTaskRequest : TeaModel {
        [NameInMap("addDocumentParam")]
        [Validation(Required=false)]
        public SubmitVideoAnalysisTaskRequestAddDocumentParam AddDocumentParam { get; set; }
        public class SubmitVideoAnalysisTaskRequestAddDocumentParam : TeaModel {
            [NameInMap("datasetId")]
            [Validation(Required=false)]
            public long? DatasetId { get; set; }

            [NameInMap("datasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            [NameInMap("document")]
            [Validation(Required=false)]
            public SubmitVideoAnalysisTaskRequestAddDocumentParamDocument Document { get; set; }
            public class SubmitVideoAnalysisTaskRequestAddDocumentParamDocument : TeaModel {
                [NameInMap("categoryUuid")]
                [Validation(Required=false)]
                public string CategoryUuid { get; set; }

                [NameInMap("docId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                [NameInMap("extend1")]
                [Validation(Required=false)]
                public string Extend1 { get; set; }

                [NameInMap("extend2")]
                [Validation(Required=false)]
                public string Extend2 { get; set; }

                [NameInMap("extend3")]
                [Validation(Required=false)]
                public string Extend3 { get; set; }

                [NameInMap("metadata")]
                [Validation(Required=false)]
                public SubmitVideoAnalysisTaskRequestAddDocumentParamDocumentMetadata Metadata { get; set; }
                public class SubmitVideoAnalysisTaskRequestAddDocumentParamDocumentMetadata : TeaModel {
                    [NameInMap("keyValues")]
                    [Validation(Required=false)]
                    public List<SubmitVideoAnalysisTaskRequestAddDocumentParamDocumentMetadataKeyValues> KeyValues { get; set; }
                    public class SubmitVideoAnalysisTaskRequestAddDocumentParamDocumentMetadataKeyValues : TeaModel {
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

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
        public List<string> ExcludeGenerateOptions { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>fixDuration</para>
        /// </summary>
        [NameInMap("splitType")]
        [Validation(Required=false)]
        public string SplitType { get; set; }

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

        [NameInMap("videoCaptionInfo")]
        [Validation(Required=false)]
        public SubmitVideoAnalysisTaskRequestVideoCaptionInfo VideoCaptionInfo { get; set; }
        public class SubmitVideoAnalysisTaskRequestVideoCaptionInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>oss:// | http://</para>
            /// </summary>
            [NameInMap("videoCaptionFileUrl")]
            [Validation(Required=false)]
            public string VideoCaptionFileUrl { get; set; }

            [NameInMap("videoCaptions")]
            [Validation(Required=false)]
            public List<SubmitVideoAnalysisTaskRequestVideoCaptionInfoVideoCaptions> VideoCaptions { get; set; }
            public class SubmitVideoAnalysisTaskRequestVideoCaptionInfoVideoCaptions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("speaker")]
                [Validation(Required=false)]
                public string Speaker { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>你好</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

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
            [NameInMap("isAutoRecognition")]
            [Validation(Required=false)]
            public bool? IsAutoRecognition { get; set; }

            [NameInMap("roleInfo")]
            [Validation(Required=false)]
            public string RoleInfo { get; set; }

            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("timeIntervals")]
            [Validation(Required=false)]
            public List<SubmitVideoAnalysisTaskRequestVideoRolesTimeIntervals> TimeIntervals { get; set; }
            public class SubmitVideoAnalysisTaskRequestVideoRolesTimeIntervals : TeaModel {
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            [NameInMap("urls")]
            [Validation(Required=false)]
            public List<string> Urls { get; set; }

        }

        [NameInMap("videoShotFaceIdentityCount")]
        [Validation(Required=false)]
        public int? VideoShotFaceIdentityCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxxx.mp4">http://xxxx.mp4</a></para>
        /// </summary>
        [NameInMap("videoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

        [NameInMap("videoUrls")]
        [Validation(Required=false)]
        public List<string> VideoUrls { get; set; }

    }

}
