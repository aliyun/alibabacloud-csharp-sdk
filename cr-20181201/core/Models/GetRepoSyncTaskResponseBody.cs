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
        /// <para>Indicates whether the synchronization task is performed across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CrossUser")]
        [Validation(Required=false)]
        public bool? CrossUser { get; set; }

        /// <summary>
        /// <para>The source address of the image.</para>
        /// </summary>
        [NameInMap("ImageFrom")]
        [Validation(Required=false)]
        public GetRepoSyncTaskResponseBodyImageFrom ImageFrom { get; set; }
        public class GetRepoSyncTaskResponseBodyImageFrom : TeaModel {
            /// <summary>
            /// <para>The tag of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-sgedpenzw80e****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The name of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

        }

        /// <summary>
        /// <para>The destination address of the image.</para>
        /// </summary>
        [NameInMap("ImageTo")]
        [Validation(Required=false)]
        public GetRepoSyncTaskResponseBodyImageTo ImageTo { get; set; }
        public class GetRepoSyncTaskResponseBodyImageTo : TeaModel {
            /// <summary>
            /// <para>The tag of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-leqzomz5vijc****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eu-west-1</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The name of the namespace.</para>
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
        /// <para>The synchronization tasks for the image layer.</para>
        /// </summary>
        [NameInMap("LayerTasks")]
        [Validation(Required=false)]
        public List<GetRepoSyncTaskResponseBodyLayerTasks> LayerTasks { get; set; }
        public class GetRepoSyncTaskResponseBodyLayerTasks : TeaModel {
            /// <summary>
            /// <para>The digest of the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:36fb85fcb5e919cb60e782397a6be04201868fe7b38ef7669fc01caec1c8fc4e</para>
            /// </summary>
            [NameInMap("ArtifactDigest")]
            [Validation(Required=false)]
            public string ArtifactDigest { get; set; }

            /// <summary>
            /// <para>The digest of the image layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:36fb85fcb5e919cb60e782397a6be04201868fe7b38ef7669fc01caec1c8fc4e</para>
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// <para>The size of synchronized image layers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23655489</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization task for the image layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rslt-074x4q20fx2d****</para>
            /// </summary>
            [NameInMap("SyncLayerTaskId")]
            [Validation(Required=false)]
            public string SyncLayerTaskId { get; set; }

            /// <summary>
            /// <para>The size of the image layer that is synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23655489</para>
            /// </summary>
            [NameInMap("SyncedSize")]
            [Validation(Required=false)]
            public long? SyncedSize { get; set; }

            /// <summary>
            /// <para>The status of the synchronization task. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>The synchronization progress. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>0</c>: The synchronization starts or failed.</description></item>
        /// <item><description><c>1</c>: The synchronization is successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A6DEF8B0-5D45-46D6-867D-8C7FF0966B07</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the synchronization task in which multiple images are synchronized at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a9434731-95ef-4087-9cf4-369c8e90****</para>
        /// </summary>
        [NameInMap("SyncBatchTaskId")]
        [Validation(Required=false)]
        public string SyncBatchTaskId { get; set; }

        /// <summary>
        /// <para>The ID of the synchronization rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crsr-cllro6ho3wne****</para>
        /// </summary>
        [NameInMap("SyncRuleId")]
        [Validation(Required=false)]
        public string SyncRuleId { get; set; }

        /// <summary>
        /// <para>The ID of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rst-zxjkiv5oil6f****</para>
        /// </summary>
        [NameInMap("SyncTaskId")]
        [Validation(Required=false)]
        public string SyncTaskId { get; set; }

        /// <summary>
        /// <para>Indicates whether transfer acceleration is enabled in the synchronization process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SyncTransAccelerate")]
        [Validation(Required=false)]
        public bool? SyncTransAccelerate { get; set; }

        /// <summary>
        /// <para>The size of the image layer that is synchronized. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23655489</para>
        /// </summary>
        [NameInMap("SyncedSize")]
        [Validation(Required=false)]
        public long? SyncedSize { get; set; }

        [NameInMap("TaskIssue")]
        [Validation(Required=false)]
        public string TaskIssue { get; set; }

        /// <summary>
        /// <para>The status of the task. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The policy that is used to trigger the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("TaskTrigger")]
        [Validation(Required=false)]
        public string TaskTrigger { get; set; }

    }

}
