// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserRatePlanInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter for rate plan instances that have a remaining site quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Returns only rate plan instances that have a remaining site quota.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Returns all rate plan instances for the user.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CheckRemainingSiteQuota")]
        [Validation(Required=false)]
        public string CheckRemainingSiteQuota { get; set; }

        /// <summary>
        /// <para>The ID of the rate plan instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. The default value is <b>1</b>. The value must be in the range of <b>1 to 100,000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PlanNameEn")]
        [Validation(Required=false)]
        public string PlanNameEn { get; set; }

        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        [NameInMap("RemainingExpireDays")]
        [Validation(Required=false)]
        public int? RemainingExpireDays { get; set; }

        /// <summary>
        /// <para>The sort field. By default, results are sorted by creation time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CreateTime</b>: Sorts by creation time.</para>
        /// </description></item>
        /// <item><description><para><b>ExpireTime</b>: Sorts by expiration time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort order. The default is descending. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>asc</b>: Sorts in ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>desc</b>: Sorts in descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The status of the rate plan instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>online</b>: The instance is in service.</para>
        /// </description></item>
        /// <item><description><para><b>offline</b>: The instance has expired and is unavailable.</para>
        /// </description></item>
        /// <item><description><para><b>disable</b>: The instance is released.</para>
        /// </description></item>
        /// <item><description><para><b>overdue</b>: The instance is overdue.</para>
        /// </description></item>
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
