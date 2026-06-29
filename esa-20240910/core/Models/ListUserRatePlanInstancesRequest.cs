// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserRatePlanInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter plan instances that have remaining site quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Filters plan instances that have remaining site quota.</description></item>
        /// <item><description><b>false</b>: Queries all plan instances under the user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CheckRemainingSiteQuota")]
        [Validation(Required=false)]
        public string CheckRemainingSiteQuota { get; set; }

        /// <summary>
        /// <para>The plan instance ID. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number to return in a paged query. Default value: <b>1</b>. Valid values: <b>1</b> to <b>100000</b>. Settings for paging take effect only when this parameter is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Valid values: 1 to 500. This parameter is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The plan name in English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entranceplan</para>
        /// </summary>
        [NameInMap("PlanNameEn")]
        [Validation(Required=false)]
        public string PlanNameEn { get; set; }

        /// <summary>
        /// <para>The plan type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: fixed-version plan</description></item>
        /// <item><description>enterprise: Enterprise Edition plan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        /// <summary>
        /// <para>Queries plan instances whose remaining validity period is within the specified number of days. The value must be a positive integer. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RemainingExpireDays")]
        [Validation(Required=false)]
        public int? RemainingExpireDays { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. By default, results are sorted by purchase time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateTime</b>: purchase time.</description></item>
        /// <item><description><b>ExpireTime</b>: expiration time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: desc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: ascending order.</description></item>
        /// <item><description><b>desc</b>: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: The plan instance is in normal service.</description></item>
        /// <item><description><b>offline</b>: The plan instance has expired but has not exceeded the grace period and is not active.</description></item>
        /// <item><description><b>disable</b>: The plan instance has been released.</description></item>
        /// <item><description><b>overdue</b>: The plan instance has an overdue payment.</description></item>
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

        /// <summary>
        /// <para>The plan subscription type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>entranceplan: Free Edition (Chinese mainland)</description></item>
        /// <item><description>entranceplan_intl: Free Edition (International)</description></item>
        /// <item><description>basicplan: Basic Edition</description></item>
        /// <item><description>standardplan: Standard Edition</description></item>
        /// <item><description>advancedplan: Premium Edition</description></item>
        /// <item><description>enterpriseplan: Enterprise Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basicplan</para>
        /// </summary>
        [NameInMap("SubscribeType")]
        [Validation(Required=false)]
        public string SubscribeType { get; set; }

    }

}
