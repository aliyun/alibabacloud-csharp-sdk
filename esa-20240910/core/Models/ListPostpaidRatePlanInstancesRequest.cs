// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListPostpaidRatePlanInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return only instances that have remaining site quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Returns only instances with remaining site quota.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Returns all instances, regardless of site quota.</para>
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
        /// <para>The ID of the instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-dps-xxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The maximum value is 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field to sort the results by. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>CreateTime</c>: Sorts by creation time.</description></item>
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
        /// <item><description><para><c>asc</c>: ascending</para>
        /// </description></item>
        /// <item><description><para><c>desc</c>: descending</para>
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
        /// <item><description><para><c>online</c>: The instance is running.</para>
        /// </description></item>
        /// <item><description><para><c>overdue</c>: The payment for the instance is overdue.</para>
        /// </description></item>
        /// <item><description><para><c>disable</c>: The instance is released.</para>
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
        /// <para>The type of add-on service to filter by, such as <c>bot</c> or <c>ddos</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bot</para>
        /// </summary>
        [NameInMap("UnrelatedType")]
        [Validation(Required=false)]
        public string UnrelatedType { get; set; }

    }

}
