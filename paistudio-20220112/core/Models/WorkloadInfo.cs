// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class WorkloadInfo : TeaModel {
        /// <summary>
        /// <para>Specifies whether the workload is scheduled. Valid values are <c>true</c> and <c>false</c>.</para>
        /// </summary>
        [NameInMap("IsScheduled")]
        [Validation(Required=false)]
        public string IsScheduled { get; set; }

        /// <summary>
        /// <para>The scheduling priority of the workload. A higher value indicates a higher priority.</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>A list of metadata for the queues associated with the workload.</para>
        /// </summary>
        [NameInMap("QueueMetas")]
        [Validation(Required=false)]
        public List<QueueMeta> QueueMetas { get; set; }

        /// <summary>
        /// <para>The ID of the tenant that contains the workload.</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the workload.</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The name of the user who created the workload.</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The creation time of the workload, in UTC format.</para>
        /// </summary>
        [NameInMap("WorkloadCreatedTime")]
        [Validation(Required=false)]
        public string WorkloadCreatedTime { get; set; }

        /// <summary>
        /// <para>The unique, system-generated ID for the workload.</para>
        /// </summary>
        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// <para>The user-defined name of the workload.</para>
        /// </summary>
        [NameInMap("WorkloadName")]
        [Validation(Required=false)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// <para>The current status of the workload. Possible values include <c>Pending</c>, <c>Running</c>, <c>Succeeded</c>, and <c>Failed</c>.</para>
        /// </summary>
        [NameInMap("WorkloadStatus")]
        [Validation(Required=false)]
        public string WorkloadStatus { get; set; }

        /// <summary>
        /// <para>The type of the workload.</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that contains the workload.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The name of the workspace that contains the workload.</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
