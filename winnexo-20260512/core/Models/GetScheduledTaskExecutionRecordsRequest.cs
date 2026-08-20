// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskExecutionRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaboration group to which the task belongs (such as cg_101). If specified, a group space task is created (the caller must be a valid group member). If left empty, a personal task is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1112</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>Filters by initiator (platform user ID). The scope is the executor of the record (manual execution = the person who triggered it, automatic execution = the task creator). To view only tasks initiated by yourself, pass the current user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("initiatorUserId")]
        [Validation(Required=false)]
        public string InitiatorUserId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. Minimum value: 1. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleCollaborationGroupId</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by execution status (lowercase). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pending: queued.</description></item>
        /// <item><description>running: in progress.</description></item>
        /// <item><description>success: succeeded.</description></item>
        /// <item><description>failed: failed.</description></item>
        /// <item><description>timeout: timed out.</description></item>
        /// <item><description>cancelled: terminated.</description></item>
        /// </list>
        /// <para>If not specified, no status filter is applied. If specified, future planned items are no longer generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>failed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Filters by a single task ID. If not specified, execution records of all visible tasks are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTaskId</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The ID of the effective tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
