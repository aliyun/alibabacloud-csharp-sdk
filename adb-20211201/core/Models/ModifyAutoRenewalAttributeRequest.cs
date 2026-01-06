// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyAutoRenewalAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The duration of the auto-renewal. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <b>AutoRenewalPeriod</b> is set to <b>Month</b>, the value ranges from 1 to 11 (integer).</description></item>
        /// <item><description>When <b>AutoRenewalPeriod</b> is set to <b>Month</b>, the valid values are 1, 2, 3, and 5 (integer).</description></item>
        /// </list>
        /// <remarks>
        /// <para> Longer renewal periods offer better pricing. Renewing for 1 year is more cost-effective than renewing for 10 or 11 months.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewalPeriod")]
        [Validation(Required=false)]
        public string AutoRenewalPeriod { get; set; }

        /// <summary>
        /// <para>Auto-renewal duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Year.</description></item>
        /// <item><description>Month.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("AutoRenewalPeriodUnit")]
        [Validation(Required=false)]
        public string AutoRenewalPeriodUnit { get; set; }

        /// <summary>
        /// <para>The renewal method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AutoRenewal</b>: The cluster is automatically renewed.</description></item>
        /// <item><description><b>Normal</b>: The cluster is manually renewed. Before the cluster expires, the system sends you a reminder by SMS message.</description></item>
        /// <item><description><b>NotRenewal</b>: The cluster is not renewed. Reminders are only sent three days before cluster expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRenewal</para>
        /// </summary>
        [NameInMap("AutoRenewalStatus")]
        [Validation(Required=false)]
        public string AutoRenewalStatus { get; set; }

        /// <summary>
        /// <para>The ID of cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-uf6pl56w1j8h****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
