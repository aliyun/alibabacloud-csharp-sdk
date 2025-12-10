// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncUploadVideoShrinkRequest : TeaModel {
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
        public string ReferenceVideoShrink { get; set; }

        [NameInMap("RemoveSubtitle")]
        [Validation(Required=false)]
        public bool? RemoveSubtitle { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceVideos")]
        [Validation(Required=false)]
        public string SourceVideosShrink { get; set; }

        [NameInMap("SplitInterval")]
        [Validation(Required=false)]
        public int? SplitInterval { get; set; }

        [NameInMap("VideoRoles")]
        [Validation(Required=false)]
        public string VideoRolesShrink { get; set; }

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
