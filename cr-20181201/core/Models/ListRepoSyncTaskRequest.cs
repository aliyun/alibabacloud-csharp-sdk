// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoSyncTaskRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The name of the repository namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns</para>
        /// </summary>
        [NameInMap("RepoNamespaceName")]
        [Validation(Required=false)]
        public string RepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The ID of the sync task. This ID is also the <c>SyncBatchTaskId</c> returned in the response, which identifies the image\&quot;s sync batch task.</para>
        /// <remarks>
        /// <para>An image that matches multiple sync rules generates multiple sync tasks, each with the same <c>SyncBatchTaskId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9d8ac4f6-8138-4c15-a2e3-60624ad3****</para>
        /// </summary>
        [NameInMap("SyncRecordId")]
        [Validation(Required=false)]
        public string SyncRecordId { get; set; }

        /// <summary>
        /// <para>The image tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
