// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Experiment : TeaModel {
        /// <summary>
        /// <para>The visibility of the experiment. PRIVATE indicates that the experiment is visible only to the creator and their Alibaba Cloud account. PUBLIC indicates that the experiment is visible to all users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The default artifact output path for tasks associated with the experiment. Currently, only OSS paths are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket.oss-cn-hangzhou.aliyuncs.com/test</para>
        /// </summary>
        [NameInMap("ArtifactUri")]
        [Validation(Required=false)]
        public string ArtifactUri { get; set; }

        /// <summary>
        /// <para>The experiment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-1zpfthdx******</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// <para>The time when the experiment was created.</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the experiment was last modified.</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The list of labels for the experiment.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<ExperimentLabel> Labels { get; set; }

        /// <summary>
        /// <para>LatestRun</para>
        /// </summary>
        [NameInMap("LatestRun")]
        [Validation(Required=false)]
        public Run LatestRun { get; set; }

        /// <summary>
        /// <para>The name of the experiment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the experiment owner.</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The default OSS storage path for TensorBoard logs of each trial in the experiment.</para>
        /// </summary>
        [NameInMap("TensorboardLogUri")]
        [Validation(Required=false)]
        public string TensorboardLogUri { get; set; }

        /// <summary>
        /// <para>The user ID of the experiment creator.</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the experiment belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1517**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
