// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyElasticityAssuranceAutoRenewAttributeRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ModifyElasticityAssuranceAutoRenewAttributeRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ModifyElasticityAssuranceAutoRenewAttributeRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The IDs of the elasticity assurances to be modified. This parameter is required. If this parameter is not specified, the MissingParameter.PrivatePoolOptionsId error is returned.</para>
            /// <remarks>
            /// <para>You can modify up to 50 elasticity assurances at a time.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public List<string> Id { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies the auto-renewal duration for the instance.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values are 1, 3, and 5.</para>
        /// </description></item>
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Month</c>, the valid value is 1.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the renewal duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Month</para>
        /// </description></item>
        /// <item><description><para>Year</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID of the elasticity assurance. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The auto-renewal status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AutoRenewal: enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para>Normal: disables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para>NotRenewal: does not renew the instance. If you set this parameter to NotRenewal, the system no longer sends expiration reminders and sends a non-renewal reminder only three days before expiration. You can change the status of an elasticity assurance that is set to NotRenewal to Normal, and then manually renew it or enable auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
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
