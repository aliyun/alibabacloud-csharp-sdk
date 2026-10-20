// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserRatePlanInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter plan instances that have remaining site quotas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Filters plan instances that have remaining site quotas.</description></item>
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
        /// <para>Instance ID of the plan instance. You can obtain instance ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>The page number Settings for a paging query. Default value: <b>1</b>. Valid values: <b>1</b> to <b>100000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paging query. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the plan in English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entranceplan</para>
        /// </summary>
        [NameInMap("PlanNameEn")]
        [Validation(Required=false)]
        public string PlanNameEn { get; set; }

        /// <summary>
        /// <para>The type of the plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: Fixed plan.</description></item>
        /// <item><description>enterprise: Enterprise plan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        /// <summary>
        /// <para>Queries plan instances whose remaining validity period is less than or equal to the specified number of days. The value must be a positive integer. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RemainingExpireDays")]
        [Validation(Required=false)]
        public int? RemainingExpireDays { get; set; }

        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public long? ResourceOwner { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. By default, the results are sorted by creation time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateTime</b>: Sorts by creation time.</description></item>
        /// <item><description><b>ExpireTime</b>: Sorts by expiration time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort order. By default, the results are sorted in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: Ascending order.</description></item>
        /// <item><description><b>desc</b>: Descending order.</description></item>
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
        /// <item><description><b>online</b>: The instance is in normal service status.</description></item>
        /// <item><description><b>offline</b>: The instance has expired but is not overdue, and is in an inactive state.</description></item>
        /// <item><description><b>disable</b>: The instance is released.</description></item>
        /// <item><description><b>overdue</b>: The instance has an overdue payment.</description></item>
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
        /// <para>The subscription type of the plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>entranceplan: Free Edition (Chinese mainland)</description></item>
        /// <item><description>entranceplan_intl: Free Edition (International)</description></item>
        /// <item><description>basicplan: Basic Edition</description></item>
        /// <item><description>standardplan: Standard Edition</description></item>
        /// <item><description>advancedplan: Advanced Edition</description></item>
        /// <item><description>enterpriseplan: Enterprise Edition</description></item>
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
