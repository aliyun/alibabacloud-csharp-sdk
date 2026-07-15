// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListRayHistoryServersRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The end time of the query range. The job creation time is used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>按ID前缀过滤</para>
        /// </summary>
        [NameInMap("IdPrefix")]
        [Validation(Required=false)]
        public string IdPrefix { get; set; }

        /// <summary>
        /// <para>Filters results by the time after which they were modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T16:00:00Z</para>
        /// </summary>
        [NameInMap("ModifiedAfter")]
        [Validation(Required=false)]
        public string ModifiedAfter { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: descending order.</description></item>
        /// <item><description>asc: ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number of the page to return in a paged query. Paging starts from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of RayHistoryServer entries to return on each page in a paged query. Paging is used to return results in batches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid</description></item>
        /// <item><description>PostPaid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The resource group ID. For information about how to query the ID of a dedicated resource group, see <a href="https://help.aliyun.com/document_detail/2651299.html">Manage resource quotas</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotaxxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only the RayHistoryServer entries created by the current user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowOwn")]
        [Validation(Required=false)]
        public bool? ShowOwn { get; set; }

        /// <summary>
        /// <para>The field by which to sort the returned results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DisplayName</description></item>
        /// <item><description>GmtCreateTime</description></item>
        /// <item><description>UserId</description></item>
        /// <item><description>ResourceId</description></item>
        /// <item><description>Status</description></item>
        /// <item><description>GmtModifyTime.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The RayHistoryServer status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: being created.</description></item>
        /// <item><description>Queuing: waiting in queue.</description></item>
        /// <item><description>Running: running.</description></item>
        /// <item><description>Stopped: stopped.</description></item>
        /// <item><description>Failed: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
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
        /// <para>Filters results by user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserIdForFilter")]
        [Validation(Required=false)]
        public string UserIdForFilter { get; set; }

        /// <summary>
        /// <para>Filters results by username.</para>
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
        /// <para>268</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
