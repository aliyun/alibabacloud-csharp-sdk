// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class WorkloadInfo : TeaModel {
        /// <summary>
        /// <para>Specifies whether the task is scheduled.</para>
        /// </summary>
        [NameInMap("IsScheduled")]
        [Validation(Required=false)]
        public string IsScheduled { get; set; }

        /// <summary>
        /// <para>The task priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The information about the queue where the task resides.</para>
        /// </summary>
        [NameInMap("QueueMetas")]
        [Validation(Required=false)]
        public List<QueueMeta> QueueMetas { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that created the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user that created the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username of the task creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("WorkloadCreatedTime")]
        [Validation(Required=false)]
        public string WorkloadCreatedTime { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlcxxxx</para>
        /// </summary>
        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-job</para>
        /// </summary>
        [NameInMap("WorkloadName")]
        [Validation(Required=false)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("WorkloadStatus")]
        [Validation(Required=false)]
        public string WorkloadStatus { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace where the task resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The name of the workspace where the task resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myshellprod</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
