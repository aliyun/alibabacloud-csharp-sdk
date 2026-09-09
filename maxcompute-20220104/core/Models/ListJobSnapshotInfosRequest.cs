// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListJobSnapshotInfosRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ascOrder")]
        [Validation(Required=false)]
        public bool? AscOrder { get; set; }

        /// <summary>
        /// <para>The upstream node ID.</para>
        /// </summary>
        [NameInMap("extNodeIdList")]
        [Validation(Required=false)]
        public List<string> ExtNodeIdList { get; set; }

        /// <summary>
        /// <para>The start UNIX timestamp.</para>
        /// <remarks>
        /// <para>This parameter is invalid. The end timestamp is the point in time for the snapshot that you want to view.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1706840714</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>The job instance ID.</para>
        /// </summary>
        [NameInMap("instanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>The job owner.</para>
        /// </summary>
        [NameInMap("jobOwnerList")]
        [Validation(Required=false)]
        public List<string> JobOwnerList { get; set; }

        /// <summary>
        /// <para>The job priority.</para>
        /// </summary>
        [NameInMap("priorityList")]
        [Validation(Required=false)]
        public List<long?> PriorityList { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// </summary>
        [NameInMap("projectList")]
        [Validation(Required=false)]
        public List<string> ProjectList { get; set; }

        /// <summary>
        /// <para>The nickname of the computing quota that the job uses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota_A</para>
        /// </summary>
        [NameInMap("quotaNickname")]
        [Validation(Required=false)]
        public string QuotaNickname { get; set; }

        /// <summary>
        /// <para>The signature of the SQL job.</para>
        /// </summary>
        [NameInMap("signatureList")]
        [Validation(Required=false)]
        public List<string> SignatureList { get; set; }

        /// <summary>
        /// <para>The fields for multi-column sorting.</para>
        /// </summary>
        [NameInMap("sortByList")]
        [Validation(Required=false)]
        public List<string> SortByList { get; set; }

        /// <summary>
        /// <para>The sort orders for multi-column sorting.</para>
        /// </summary>
        [NameInMap("sortOrderList")]
        [Validation(Required=false)]
        public List<string> SortOrderList { get; set; }

        /// <summary>
        /// <para>The job status.</para>
        /// </summary>
        [NameInMap("statusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// <para>The end UNIX timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1706840714</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public long? To { get; set; }

        /// <summary>
        /// <para>The job type.</para>
        /// </summary>
        [NameInMap("typeList")]
        [Validation(Required=false)]
        public List<string> TypeList { get; set; }

        /// <summary>
        /// <para>The column to sort by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>submittedAtTime</para>
        /// </description></item>
        /// <item><description><para>waitingTime</para>
        /// </description></item>
        /// <item><description><para>runningAtTime</para>
        /// </description></item>
        /// <item><description><para>runningTime</para>
        /// </description></item>
        /// <item><description><para>snapshotTime</para>
        /// </description></item>
        /// <item><description><para>totalTime</para>
        /// </description></item>
        /// <item><description><para>cpuUsage</para>
        /// </description></item>
        /// <item><description><para>memoryUsage</para>
        /// </description></item>
        /// <item><description><para>minCpuPct</para>
        /// </description></item>
        /// <item><description><para>minMemoryPct</para>
        /// </description></item>
        /// <item><description><para>priority</para>
        /// </description></item>
        /// <item><description><para>cpuRequest</para>
        /// </description></item>
        /// <item><description><para>memoryRequest</para>
        /// </description></item>
        /// <item><description><para>cpuUsageToRequestRatio</para>
        /// </description></item>
        /// <item><description><para>memoryUsageToRequestRatio</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cpuUsage</para>
        /// </summary>
        [NameInMap("orderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The tenant ID. To view the tenant ID, log on to the MaxCompute console. In the navigation pane on the left, choose Tenant Management &gt; Tenant Properties.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478403690625249</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
