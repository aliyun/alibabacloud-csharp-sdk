// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListPostpaidRatePlanInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to check for remaining site quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Queries instances that have remaining site quota.</para>
        /// </description></item>
        /// <item><description><para>false: Does not filter by this condition.</para>
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
        /// <para>The instance ID. Use this parameter to query a specific instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-dps-xxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number for paging queries. The value must be greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging queries. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public long? ResourceOwner { get; set; }

        /// <summary>
        /// <para>The field by which to sort results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: sorted by creation time</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asc: ascending order</para>
        /// </description></item>
        /// <item><description><para>desc: descending order</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>online: Normal.</para>
        /// </description></item>
        /// <item><description><para>overdue: Overdue payment.</para>
        /// </description></item>
        /// <item><description><para>disable: Released.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance has purchased additional bot or DDoS protection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bot</para>
        /// </summary>
        [NameInMap("UnrelatedType")]
        [Validation(Required=false)]
        public string UnrelatedType { get; set; }

    }

}
