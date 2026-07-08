// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncUploadVideoShrinkRequest : TeaModel {
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
        public string ReferenceVideoShrink { get; set; }

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
        public string SourceVideosShrink { get; set; }

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
        public string VideoRolesShrink { get; set; }

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
