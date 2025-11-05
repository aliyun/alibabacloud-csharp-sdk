// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserRatePlanInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query only the plans that have remaining quota for associating websites. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: queries only the plans that have remaining quota for associating websites.</description></item>
        /// <item><description>false: queries all plans in your account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CheckRemainingSiteQuota")]
        [Validation(Required=false)]
        public string CheckRemainingSiteQuota { get; set; }

        /// <summary>
        /// <para>The plan ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: <b>1</b> to <b>100000</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        [NameInMap("RemainingExpireDays")]
        [Validation(Required=false)]
        public int? RemainingExpireDays { get; set; }

        /// <summary>
        /// <para>The sorting field. By default, the queried plans are sorted by purchase time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: the time when the plans were purchased.</description></item>
        /// <item><description>ExpireTime: the time when the plans expire.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the query results. Default value: desc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: in ascending order.</description></item>
        /// <item><description>desc: in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The plan status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>online: The plan is in service.</description></item>
        /// <item><description>offline: The plan has expired within an allowable period. In this state, the plan is unavailable.</description></item>
        /// <item><description>disable: The plan is released.</description></item>
        /// <item><description>overdue: The plan is stopped due to overdue payments.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubscribeType")]
        [Validation(Required=false)]
        public string SubscribeType { get; set; }

    }

}
