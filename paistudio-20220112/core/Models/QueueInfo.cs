// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QueueInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>roleMaximumResource</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ConfigRule</para>
        /// </summary>
        [NameInMap("CodeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;2023-06-22T00:00:00Z&quot;</para>
        /// </summary>
        [NameInMap("GmtDequeuedTime")]
        [Validation(Required=false)]
        public string GmtDequeuedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>“2023-06-22T00:00:00Z”</para>
        /// </summary>
        [NameInMap("GmtEnqueuedTime")]
        [Validation(Required=false)]
        public string GmtEnqueuedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;2023-06-22T00:00:00Z&quot;</para>
        /// </summary>
        [NameInMap("GmtPositionModifiedTime")]
        [Validation(Required=false)]
        public string GmtPositionModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-label-79f5498dd-9qrzs</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public long? Position { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PaiStrategyIntelligent</para>
        /// </summary>
        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>“quotamtl37ge7gkvdz”</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Current GPU Limit is 5, limited by Role PAI.AlgoDeveloper</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ResourceAmount Resource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enqueued</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UseOversoldResource")]
        [Validation(Required=false)]
        public bool? UseOversoldResource { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlcxxxx</para>
        /// </summary>
        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

        [NameInMap("WorkloadName")]
        [Validation(Required=false)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PreAllocation</para>
        /// </summary>
        [NameInMap("WorkloadStatus")]
        [Validation(Required=false)]
        public string WorkloadStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>“432524”</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
