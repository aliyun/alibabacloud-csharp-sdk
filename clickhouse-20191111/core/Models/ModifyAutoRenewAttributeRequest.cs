// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID. To specify multiple cluster IDs, separate them with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp1uy5ff6*****</para>
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// <para>The renewal duration. The default value is <b>1</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set \<c>PeriodUnit\\</c> to <b>Month</b>, valid values are integers from 1 to 11.</para>
        /// </description></item>
        /// <item><description><para>If you set \<c>PeriodUnit\\</c> to <b>Year</b>, valid values are 1, 2, 3, and 5.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>A longer subscription period offers a better price. For example, a one-year subscription is more cost-effective than a 10-month or 11-month subscription.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The unit of the renewal duration specified by the \<c>Duration\\</c> parameter. Valid values: Month and Year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The renewal method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AutoRenewal</b>: Auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>Normal</b>: Manual renewal.</para>
        /// </description></item>
        /// <item><description><para><b>NotRenewal</b>: The cluster is not renewed after it expires.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRenewal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
