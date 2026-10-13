// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListStorageProjectsInfoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ascOrder")]
        [Validation(Required=false)]
        public bool? AscOrder { get; set; }

        /// <summary>
        /// <para>The statistical date, in the YYYYMMdd format. Data is collected on a daily basis.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20241205</para>
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The sort column. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>totalStorage</description></item>
        /// <item><description>longTermStorage</description></item>
        /// <item><description>lowFreqStorage</description></item>
        /// <item><description>standardStorage</description></item>
        /// <item><description>recycleBinStorage</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>totalStorage</para>
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
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The prefix of the MaxCompute project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps_project</para>
        /// </summary>
        [NameInMap("projectPrefix")]
        [Validation(Required=false)]
        public string ProjectPrefix { get; set; }

        /// <summary>
        /// <para>The number of days used for comparison.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("recentDays")]
        [Validation(Required=false)]
        public int? RecentDays { get; set; }

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
        /// <para>The tenant ID. You can view the tenant ID by logging on to the MaxCompute console and choosing <b>Tenant Management</b> &gt; <b>Tenant Properties</b> in the left-side navigation pane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28074710977****</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
