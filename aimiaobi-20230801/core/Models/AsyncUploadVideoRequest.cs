// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncUploadVideoRequest : TeaModel {
        /// <summary>
        /// <para>Shot segmentation threshold. A smaller value increases sensitivity. Valid range is 1 to 10. Default value is 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("AdaptiveThreshold")]
        [Validation(Required=false)]
        public float? AdaptiveThreshold { get; set; }

        /// <summary>
        /// <para>The prompt for video understanding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>重点理解视频中的风景信息</para>
        /// </summary>
        [NameInMap("AnlysisPrompt")]
        [Validation(Required=false)]
        public string AnlysisPrompt { get; set; }

        /// <summary>
        /// <para>The similarity threshold for character recognition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("FaceIdentitySimilarityMinScore")]
        [Validation(Required=false)]
        public double? FaceIdentitySimilarityMinScore { get; set; }

        /// <summary>
        /// <para>Information about the reference video.</para>
        /// </summary>
        [NameInMap("ReferenceVideo")]
        [Validation(Required=false)]
        public AsyncUploadVideoRequestReferenceVideo ReferenceVideo { get; set; }
        public class AsyncUploadVideoRequestReferenceVideo : TeaModel {
            /// <summary>
            /// <para>Additional information for video understanding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>手机cpu采用3纳米技术</para>
            /// </summary>
            [NameInMap("VideoExtraInfo")]
            [Validation(Required=false)]
            public string VideoExtraInfo { get; set; }

            /// <summary>
            /// <para>The name of the reference video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>refvideo.mp4</para>
            /// </summary>
            [NameInMap("VideoName")]
            [Validation(Required=false)]
            public string VideoName { get; set; }

            /// <summary>
            /// <para>The URL of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://viapi-customer-pop.oss-cn-shanghai.aliyuncs.com/d71e_208334498220521996_51298e0a909d457693166eb883768c7a">http://viapi-customer-pop.oss-cn-shanghai.aliyuncs.com/d71e_208334498220521996_51298e0a909d457693166eb883768c7a</a></para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        /// <summary>
        /// <para>Removes captions from the material.</para>
        /// </summary>
        [NameInMap("RemoveSubtitle")]
        [Validation(Required=false)]
        public bool? RemoveSubtitle { get; set; }

        /// <summary>
        /// <para>The structure of the video editing materials.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceVideos")]
        [Validation(Required=false)]
        public List<AsyncUploadVideoRequestSourceVideos> SourceVideos { get; set; }
        public class AsyncUploadVideoRequestSourceVideos : TeaModel {
            /// <summary>
            /// <para>Additional description of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>视频中有一个房子</para>
            /// </summary>
            [NameInMap("VideoExtraInfo")]
            [Validation(Required=false)]
            public string VideoExtraInfo { get; set; }

            /// <summary>
            /// <para>The name of the video.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.mp4</para>
            /// </summary>
            [NameInMap("VideoName")]
            [Validation(Required=false)]
            public string VideoName { get; set; }

            /// <summary>
            /// <para>The URL of the video.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://123.mp4">http://123.mp4</a>
            /// 目前该接口只进行视频理解额和分析，并没有对文件进行转存。请保证视频地址在任务执行期间有效。</para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        /// <summary>
        /// <para>The time interval for video understanding shots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>默认1</para>
        /// </summary>
        [NameInMap("SplitInterval")]
        [Validation(Required=false)]
        public int? SplitInterval { get; set; }

        /// <summary>
        /// <para>Job name</para>
        /// 
        /// <b>Example:</b>
        /// <para>task001</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>Task Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>type001</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>Face information of the roles.</para>
        /// </summary>
        [NameInMap("VideoRoles")]
        [Validation(Required=false)]
        public List<AsyncUploadVideoRequestVideoRoles> VideoRoles { get; set; }
        public class AsyncUploadVideoRequestVideoRoles : TeaModel {
            /// <summary>
            /// <para>Information about the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李晓明是一位警察</para>
            /// </summary>
            [NameInMap("RoleInfo")]
            [Validation(Required=false)]
            public string RoleInfo { get; set; }

            /// <summary>
            /// <para>The name of the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李晓明</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The URLs of the role photos.</para>
            /// </summary>
            [NameInMap("RoleUrls")]
            [Validation(Required=false)]
            public List<AsyncUploadVideoRequestVideoRolesRoleUrls> RoleUrls { get; set; }
            public class AsyncUploadVideoRequestVideoRolesRoleUrls : TeaModel {
                /// <summary>
                /// <para>The file name of the role\&quot;s facial image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>王小明.jpeg</para>
                /// </summary>
                [NameInMap("RoleFileName")]
                [Validation(Required=false)]
                public string RoleFileName { get; set; }

                /// <summary>
                /// <para>The public URL of the role\&quot;s facial image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxx/xxx.jpeg">http://xxx/xxx.jpeg</a></para>
                /// </summary>
                [NameInMap("RoleFileUrl")]
                [Validation(Required=false)]
                public string RoleFileUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of frames sampled from a single shot for character matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("VideoShotFaceIdentityCount")]
        [Validation(Required=false)]
        public int? VideoShotFaceIdentityCount { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">The ID of the Alibaba Cloud Model Studio workspace.</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
