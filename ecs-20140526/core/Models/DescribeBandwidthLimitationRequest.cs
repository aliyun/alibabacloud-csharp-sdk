// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeBandwidthLimitationRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/25398.html">Billing overview</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The operation type for querying public bandwidth limits. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Upgrade: upgrades the public bandwidth.</description></item>
        /// <item><description>Downgrade: downgrades the public bandwidth.</description></item>
        /// <item><description>Create: creates an ECS instance.</description></item>
        /// </list>
        /// <para>Default value: Create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the target region. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <remarks>
        /// <para>When you set the OperationType parameter to Upgrade or Downgrade, the ResourceId parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph***</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The bidding strategy for pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: a preemptible instance with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: a preemptible instance priced at the market price at the time of purchase.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// <remarks>
        /// <para>The SpotStrategy parameter takes effect only when the InstanceChargeType parameter is set to PostPaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

    }

}
