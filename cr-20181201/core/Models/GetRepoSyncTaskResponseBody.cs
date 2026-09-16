// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoSyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the synchronization is cross-account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CrossUser")]
        [Validation(Required=false)]
        public bool? CrossUser { get; set; }

        /// <summary>
        /// <para>The source image.</para>
        /// </summary>
        [NameInMap("ImageFrom")]
        [Validation(Required=false)]
        public GetRepoSyncTaskResponseBodyImageFrom ImageFrom { get; set; }
        public class GetRepoSyncTaskResponseBodyImageFrom : TeaModel {
            /// <summary>
            /// <para>The image tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-sgedpenzw80e****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The repository name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

        }

        /// <summary>
        /// <para>The destination image.</para>
        /// </summary>
        [NameInMap("ImageTo")]
        [Validation(Required=false)]
        public GetRepoSyncTaskResponseBodyImageTo ImageTo { get; set; }
        public class GetRepoSyncTaskResponseBodyImageTo : TeaModel {
            /// <summary>
            /// <para>The image tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-leqzomz5vijc****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eu-west-1</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The repository name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The list of image layer synchronization tasks.</para>
        /// </summary>
        [NameInMap("LayerTasks")]
        [Validation(Required=false)]
        public List<GetRepoSyncTaskResponseBodyLayerTasks> LayerTasks { get; set; }
        public class GetRepoSyncTaskResponseBodyLayerTasks : TeaModel {
            /// <summary>
            /// <para>The digest value of the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:36fb85fcb5e919cb60e782397a6be04201868fe7b38ef7669fc01caec1c8fc4e</para>
            /// </summary>
            [NameInMap("ArtifactDigest")]
            [Validation(Required=false)]
            public string ArtifactDigest { get; set; }

            /// <summary>
            /// <para>The image digest value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:36fb85fcb5e919cb60e782397a6be04201868fe7b38ef7669fc01caec1c8fc4e</para>
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// <para>The size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23655489</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The synchronization layer task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rslt-074x4q20fx2d****</para>
            /// </summary>
            [NameInMap("SyncLayerTaskId")]
            [Validation(Required=false)]
            public string SyncLayerTaskId { get; set; }

            /// <summary>
            /// <para>The synchronized size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23655489</para>
            /// </summary>
            [NameInMap("SyncedSize")]
            [Validation(Required=false)]
            public long? SyncedSize { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>The execution priority of the synchronization task. Synchronization tasks are executed in descending order of priority. Tasks with the same priority are executed in random order.</para>
        /// <para>Valid values: 1 to 5.</para>
        /// <para>Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The synchronization progress. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: The synchronization has just started or failed.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: The synchronization succeeded.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A6DEF8B0-5D45-46D6-867D-8C7FF0966B07</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The synchronization batch task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a9434731-95ef-4087-9cf4-369c8e90****</para>
        /// </summary>
        [NameInMap("SyncBatchTaskId")]
        [Validation(Required=false)]
        public string SyncBatchTaskId { get; set; }

        /// <summary>
        /// <para>The synchronization rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crsr-cllro6ho3wne****</para>
        /// </summary>
        [NameInMap("SyncRuleId")]
        [Validation(Required=false)]
        public string SyncRuleId { get; set; }

        /// <summary>
        /// <para>The synchronization task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rst-zxjkiv5oil6f****</para>
        /// </summary>
        [NameInMap("SyncTaskId")]
        [Validation(Required=false)]
        public string SyncTaskId { get; set; }

        /// <summary>
        /// <para>Indicates whether transfer acceleration is enabled for synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SyncTransAccelerate")]
        [Validation(Required=false)]
        public bool? SyncTransAccelerate { get; set; }

        /// <summary>
        /// <para>The synchronized size, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23655489</para>
        /// </summary>
        [NameInMap("SyncedSize")]
        [Validation(Required=false)]
        public long? SyncedSize { get; set; }

        /// <summary>
        /// <para>The task failure information.</para>
        /// <remarks>
        /// <para>When the synchronization task fails, this field returns information about the failure.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NETWORK_ERROR</para>
        /// </summary>
        [NameInMap("TaskIssue")]
        [Validation(Required=false)]
        public string TaskIssue { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <para><c>PENDING</c>: The synchronization is pending.</para>
        /// <para><c>SYNCHRONIZING</c>: The synchronization is in progress.</para>
        /// <para><c>SUCCESS</c>: The synchronization succeeded.</para>
        /// <para><c>ERROR</c>: The synchronization failed.</para>
        /// <para><c>CANCELED</c>: The synchronization task is canceled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The trigger type of the synchronization task. Valid values:</para>
        /// <para><c>PASSIVE</c>: The synchronization task is automatically triggered.</para>
        /// <para><c>INITIATIVE</c>: The synchronization task is manually triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PASSIVE</para>
        /// </summary>
        [NameInMap("TaskTrigger")]
        [Validation(Required=false)]
        public string TaskTrigger { get; set; }

    }

}
