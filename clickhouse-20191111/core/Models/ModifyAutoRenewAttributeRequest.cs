// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The cluster IDs. Separate multiple cluster IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp1uy5ff6*****</para>
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// <para>The renewal duration. Default value: <b>1</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If PeriodUnit is set to <b>Month</b>, valid values are 1 to 11.</para>
        /// </description></item>
        /// <item><description><para>If PeriodUnit is set to <b>Year</b>, valid values are 1, 2, 3, and 5.</para>
        /// <remarks>
        /// <para>A longer subscription duration offers a greater discount. For example, a 1-year subscription is more cost-effective than a 10-month or 11-month subscription.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>The unit of the renewal duration, which is the unit of the Duration parameter. Valid values: Month and Year.</para>
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
        /// <para>The renewal status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AutoRenewal</b>: Auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>Normal</b>: Manual renewal.</para>
        /// </description></item>
        /// <item><description><para><b>NotRenewal</b>: No renewal upon expiration.</para>
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
