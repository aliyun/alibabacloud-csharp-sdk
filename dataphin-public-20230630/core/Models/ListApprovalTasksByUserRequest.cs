// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListApprovalTasksByUserRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListApprovalTasksByUserRequestListQuery ListQuery { get; set; }
        public class ListApprovalTasksByUserRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The approval task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>APPROVE: Permission approval.</description></item>
            /// <item><description>MANAGE: Management.</description></item>
            /// <item><description>OTHERS: Others.</description></item>
            /// <item><description>ATOMIC: Atomic metric approval.</description></item>
            /// <item><description>BIZ_OBJECT: Business object approval.</description></item>
            /// <item><description>BIZ_PROCESS: Business process approval.</description></item>
            /// <item><description>PUBLISH_APPROVE: Publish approval.</description></item>
            /// <item><description>BASELINE_APPROVE: Baseline approval.</description></item>
            /// <item><description>CODE_REVIEW: Asset approval.</description></item>
            /// <item><description>OBJECT_CODE_REVIEW: Code review.</description></item>
            /// <item><description>STANDARD_APPROVAL: Standard online approval.</description></item>
            /// <item><description>BATCH_STANDARD_APPROVAL: Batch standard online approval.</description></item>
            /// <item><description>STANDARD_OFFLINE_APPROVAL: Standard offline approval.</description></item>
            /// <item><description>BATCH_STANDARD_OFFLINE_APPROVAL: Batch standard offline approval.</description></item>
            /// <item><description>PRIVILEGE_TRANSFER_APPROVAL: Permission transfer approval.</description></item>
            /// <item><description>QD_FEATURE_ONLINE: Label listing.</description></item>
            /// <item><description>QD_FEATURE_OFFLINE: Label delisting.</description></item>
            /// <item><description>QD_CLUSTER_ONLINE: Group online.</description></item>
            /// <item><description>QD_CLUSTER_OFFLINE: Group offline.</description></item>
            /// <item><description>QD_MEMBER_ADD_APP: Add member to application.</description></item>
            /// <item><description>QD_FEATURE_ADD_APP: Add label to application.</description></item>
            /// <item><description>QD_CLUSTER_ADD_APP: Add group to application.</description></item>
            /// <item><description>QD_FEATURE_ADD_PROJECT: Add label to project.</description></item>
            /// <item><description>QD_CLUSTER_ADD_PROJECT: Add group to project.</description></item>
            /// <item><description>TASK_DATA_DOWNLOAD: Data download.</description></item>
            /// <item><description>CUSTOM_OPERATE: Custom operation.</description></item>
            /// <item><description>PRIVACY_COMPUTING: Privacy-preserving computation.</description></item>
            /// <item><description>MDC_TOPIC_DIR_PUBLISH: Asset topic directory publish.</description></item>
            /// <item><description>ASSET_PUBLISH: Asset listing approval.</description></item>
            /// <item><description>ASSET_UN_PUBLISH: Asset delisting approval.</description></item>
            /// <item><description>APPLICATION_CREATE: Application creation approval.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_SOURCE</para>
            /// </summary>
            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public string ApprovalType { get; set; }

            /// <summary>
            /// <para>The keyword for fuzzy match on the task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>datasource</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The page number, starting from 1. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of records per page. Default value: 20. Maximum value: 100. Values greater than 100 are automatically adjusted to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The relationship type between the current user and the approval task. This parameter is required. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUBMITTED: Submitted by me.</description></item>
            /// <item><description>PENDING_APPROVAL: Pending my approval.</description></item>
            /// <item><description>PROCESSED: Processed by me.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUBMITTED</para>
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// <para>The approval status filter. Status filtering is not supported in the pending scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>APPROVING: Approving.</description></item>
            /// <item><description>APPROVED: Approved.</description></item>
            /// <item><description>REJECTED: Rejected.</description></item>
            /// <item><description>REVOKED: Revoked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APPROVED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The start of the submission time range, in the format yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("SubmittedFrom")]
            [Validation(Required=false)]
            public string SubmittedFrom { get; set; }

            /// <summary>
            /// <para>The end of the submission time range, in the format yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-31 23:59:59</para>
            /// </summary>
            [NameInMap("SubmittedTo")]
            [Validation(Required=false)]
            public string SubmittedTo { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
