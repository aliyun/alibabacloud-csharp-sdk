// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListRayHistoryServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of RayHistoryServer entries.</para>
        /// </summary>
        [NameInMap("RayHistoryServers")]
        [Validation(Required=false)]
        public List<ListRayHistoryServersResponseBodyRayHistoryServers> RayHistoryServers { get; set; }
        public class ListRayHistoryServersResponseBodyRayHistoryServers : TeaModel {
            /// <summary>
            /// <para>The visibility of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PUBLIC: visible to all users in the workspace.</description></item>
            /// <item><description>PRIVATE (default): visible only to you and administrators in the workspace.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("Accessibility")]
            [Validation(Required=false)]
            public string Accessibility { get; set; }

            /// <summary>
            /// <para>The display name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AEB-RECHARGE-TASK-14478-1778466397-main-4-</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The hardware specifications of the public resource group. Visit <a href="https://help.aliyun.com/document_detail/171758.html">PAI-DLC billing</a> for a detailed list of specifications.&gt;Notice: Prices vary depending on the specifications..</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.xlarge</para>
            /// </summary>
            [NameInMap("EcsSpec")]
            [Validation(Required=false)]
            public string EcsSpec { get; set; }

            /// <summary>
            /// <para>The time when the job was created, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-30T02:43:52Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the job ended, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-27T09:17:11Z</para>
            /// </summary>
            [NameInMap("GmtFinishTime")]
            [Validation(Required=false)]
            public string GmtFinishTime { get; set; }

            /// <summary>
            /// <para>The time when the job was last modified, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-19T04:05:46Z</para>
            /// </summary>
            [NameInMap("GmtModifyTime")]
            [Validation(Required=false)]
            public string GmtModifyTime { get; set; }

            /// <summary>
            /// <para>The maximum runtime in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxRuntimeMinutes")]
            [Validation(Required=false)]
            public int? MaxRuntimeMinutes { get; set; }

            /// <summary>
            /// <para>The ID of the created RayHistoryServer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rhsxxx</para>
            /// </summary>
            [NameInMap("RayHistoryServerId")]
            [Validation(Required=false)]
            public string RayHistoryServerId { get; set; }

            /// <summary>
            /// <para>Ray Dashboard URL。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://rhsxxx-dashboard.dsw-gateway-cn-wulanchabu.data.aliyun.com/">https://rhsxxx-dashboard.dsw-gateway-cn-wulanchabu.data.aliyun.com/</a></para>
            /// </summary>
            [NameInMap("RayHistoryServerUrl")]
            [Validation(Required=false)]
            public string RayHistoryServerUrl { get; set; }

            /// <summary>
            /// <para>The status detail code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The status details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PyTorchJob dlc1tx4b9lw3ntb9 is running.</para>
            /// </summary>
            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            /// <summary>
            /// <para>The resource group ID. For information about how to query the ID of a dedicated resource group, see <a href="https://help.aliyun.com/document_detail/2651299.html">Manage resource quotas</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quotazoqd53w0q75</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The name of the resource on which the job runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OWNER_REPO</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The RayHistoryServer status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: being created.</description></item>
            /// <item><description>Running: running.</description></item>
            /// <item><description>Stopped: stopped.</description></item>
            /// <item><description>Succeeded: succeeded.</description></item>
            /// <item><description>Failed: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage path of Ray logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket-test-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/tmp</para>
            /// </summary>
            [NameInMap("StoragePath")]
            [Validation(Required=false)]
            public string StoragePath { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1335237941080704</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myusername</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <para>The workspace ID. &lt;props=&quot;china&quot;&gt;For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>..</para>
            /// 
            /// <b>Example:</b>
            /// <para>153466</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used for diagnostics and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-xxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
