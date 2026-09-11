// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskExecutionRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaboration group to which the task belongs, such as cg_101. If this parameter is specified, a group workspace task is created and the caller must be a valid group member. If this parameter is left empty, a personal task is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1112</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The platform user ID of the initiator for filtering. The scope is the executor of the record. For manual execution, this is the user who triggered the execution. For automatic execution, this is the task creator. To view only tasks initiated by yourself, pass the current user ID.</para>
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
        /// <para>The execution status filter (lowercase). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pending: Queued.</description></item>
        /// <item><description>running: Running.</description></item>
        /// <item><description>success: Succeeded.</description></item>
        /// <item><description>failed: Failed.</description></item>
        /// <item><description>timeout: Timed out.</description></item>
        /// <item><description>cancelled: Cancelled.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, no status filtering is applied. If this parameter is specified, future planned items are no longer generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>failed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of a single task for pre-filtering. If this parameter is not specified, execution records of all visible tasks are returned.</para>
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
