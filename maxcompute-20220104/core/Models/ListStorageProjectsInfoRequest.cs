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
        /// <para>The statistics collection date. The date is accurate to the day. The date must be in the <c>YYYYMMdd</c> format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20241205</para>
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The column to sort by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>totalStorage</para>
        /// </description></item>
        /// <item><description><para>longTermStorage</para>
        /// </description></item>
        /// <item><description><para>lowFreqStorage</para>
        /// </description></item>
        /// <item><description><para>standardStorage</para>
        /// </description></item>
        /// <item><description><para>recycleBinStorage</para>
        /// </description></item>
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
        /// <para>The number of days for year-over-year comparison.</para>
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
        /// <para>The tenant ID. You can log on to the MaxCompute console and choose <b>Tenant Property</b> in the navigation pane on the left to view the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28074710977****</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
