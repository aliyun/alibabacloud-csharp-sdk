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
        /// <para>The upstream node IDs.</para>
        /// </summary>
        [NameInMap("extNodeIdList")]
        [Validation(Required=false)]
        public List<string> ExtNodeIdList { get; set; }

        /// <summary>
        /// <para>The start timestamp.</para>
        /// <remarks>
        /// <para>This parameter is invalid. The end timestamp specifies the snapshot time to query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1706840714</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>The job instance Id.</para>
        /// </summary>
        [NameInMap("instanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>The list of job owners.</para>
        /// </summary>
        [NameInMap("jobOwnerList")]
        [Validation(Required=false)]
        public List<string> JobOwnerList { get; set; }

        /// <summary>
        /// <para>The job priorities.</para>
        /// </summary>
        [NameInMap("priorityList")]
        [Validation(Required=false)]
        public List<long?> PriorityList { get; set; }

        /// <summary>
        /// <para>The project names.</para>
        /// </summary>
        [NameInMap("projectList")]
        [Validation(Required=false)]
        public List<string> ProjectList { get; set; }

        /// <summary>
        /// <para>The nickname of the compute quota used by the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota_A</para>
        /// </summary>
        [NameInMap("quotaNickname")]
        [Validation(Required=false)]
        public string QuotaNickname { get; set; }

        /// <summary>
        /// <para>The SQL job signatures.</para>
        /// </summary>
        [NameInMap("signatureList")]
        [Validation(Required=false)]
        public List<string> SignatureList { get; set; }

        /// <summary>
        /// <para>The multi-column sort fields.</para>
        /// </summary>
        [NameInMap("sortByList")]
        [Validation(Required=false)]
        public List<string> SortByList { get; set; }

        /// <summary>
        /// <para>The multi-column sort orders.</para>
        /// </summary>
        [NameInMap("sortOrderList")]
        [Validation(Required=false)]
        public List<string> SortOrderList { get; set; }

        /// <summary>
        /// <para>The job statuses.</para>
        /// </summary>
        [NameInMap("statusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// <para>The end timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1706840714</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public long? To { get; set; }

        /// <summary>
        /// <para>The job types.</para>
        /// </summary>
        [NameInMap("typeList")]
        [Validation(Required=false)]
        public List<string> TypeList { get; set; }

        /// <summary>
        /// <para>The sort column. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>submittedAtTime</description></item>
        /// <item><description>waitingTime</description></item>
        /// <item><description>runningAtTime</description></item>
        /// <item><description>runningTime</description></item>
        /// <item><description>snapshotTime</description></item>
        /// <item><description>totalTime</description></item>
        /// <item><description>cpuUsage </description></item>
        /// <item><description>memoryUsage</description></item>
        /// <item><description>minCpuPct</description></item>
        /// <item><description>minMemoryPct</description></item>
        /// <item><description>priority</description></item>
        /// <item><description>cpuRequest</description></item>
        /// <item><description>memoryRequest</description></item>
        /// <item><description>cpuUsageToRequestRatio</description></item>
        /// <item><description>memoryUsageToRequestRatio</description></item>
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
        /// <para>The page size, which is the maximum number of entries to return per page.</para>
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
        /// <para>The tenant ID. You can view the tenant ID by logging on to the MaxCompute console and choosing Tenant Management &gt; Tenant Properties in the left-side navigation pane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478403690625249</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
