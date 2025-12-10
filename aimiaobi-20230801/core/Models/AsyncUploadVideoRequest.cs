// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncUploadVideoRequest : TeaModel {
        [NameInMap("AnlysisPrompt")]
        [Validation(Required=false)]
        public string AnlysisPrompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("FaceIdentitySimilarityMinScore")]
        [Validation(Required=false)]
        public double? FaceIdentitySimilarityMinScore { get; set; }

        [NameInMap("ReferenceVideo")]
        [Validation(Required=false)]
        public AsyncUploadVideoRequestReferenceVideo ReferenceVideo { get; set; }
        public class AsyncUploadVideoRequestReferenceVideo : TeaModel {
            [NameInMap("VideoExtraInfo")]
            [Validation(Required=false)]
            public string VideoExtraInfo { get; set; }

            [NameInMap("VideoName")]
            [Validation(Required=false)]
            public string VideoName { get; set; }

            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("RemoveSubtitle")]
        [Validation(Required=false)]
        public bool? RemoveSubtitle { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceVideos")]
        [Validation(Required=false)]
        public List<AsyncUploadVideoRequestSourceVideos> SourceVideos { get; set; }
        public class AsyncUploadVideoRequestSourceVideos : TeaModel {
            [NameInMap("VideoExtraInfo")]
            [Validation(Required=false)]
            public string VideoExtraInfo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.mp4</para>
            /// </summary>
            [NameInMap("VideoName")]
            [Validation(Required=false)]
            public string VideoName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("SplitInterval")]
        [Validation(Required=false)]
        public int? SplitInterval { get; set; }

        [NameInMap("VideoRoles")]
        [Validation(Required=false)]
        public List<AsyncUploadVideoRequestVideoRoles> VideoRoles { get; set; }
        public class AsyncUploadVideoRequestVideoRoles : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>李晓明是一位警察</para>
            /// </summary>
            [NameInMap("RoleInfo")]
            [Validation(Required=false)]
            public string RoleInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李晓明</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("RoleUrls")]
            [Validation(Required=false)]
            public List<AsyncUploadVideoRequestVideoRolesRoleUrls> RoleUrls { get; set; }
            public class AsyncUploadVideoRequestVideoRolesRoleUrls : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>王小明.jpeg</para>
                /// </summary>
                [NameInMap("RoleFileName")]
                [Validation(Required=false)]
                public string RoleFileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxx/xxx.jpeg">http://xxx/xxx.jpeg</a></para>
                /// </summary>
                [NameInMap("RoleFileUrl")]
                [Validation(Required=false)]
                public string RoleFileUrl { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("VideoShotFaceIdentityCount")]
        [Validation(Required=false)]
        public int? VideoShotFaceIdentityCount { get; set; }

        /// <summary>
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
