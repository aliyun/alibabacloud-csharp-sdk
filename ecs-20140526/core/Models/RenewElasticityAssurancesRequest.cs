// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RenewElasticityAssurancesRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public RenewElasticityAssurancesRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class RenewElasticityAssurancesRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The list of elasticity assurance service IDs.</para>
            /// <para><b>Limit</b>: You can renew up to 20 elasticity assurance services at a time.</para>
            /// <para>You can call <a href="https://help.aliyun.com/document_detail/2679748.html">DescribeElasticityAssurances</a> to query purchased elasticity assurance services.</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public List<string> Id { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Automatic payment is enabled.</description></item>
        /// <item><description>false: Automatic payment is not enabled.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Auto-renewal is not enabled.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. Unit: months. Valid values: 1, 2, 3, 6, 12, 24, and 36.</para>
        /// <list type="bullet">
        /// <item><description><para>When <c>PeriodUnit=Month</c>, the default value is 1.</para>
        /// </description></item>
        /// <item><description><para>When <c>PeriodUnit=Year</c>, the default value is 12.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <c>AutoRenew</c> is set to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests.</para>
        /// <para><c>ClientToken</c> supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The renewal duration. The unit of the duration is determined by the <c>PeriodUnit</c> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>When <c>PeriodUnit</c> is set to <c>Weekly</c>: 1, 2, and 3.</para>
        /// </description></item>
        /// <item><description><para>When <c>PeriodUnit</c> is set to <c>Month</c>: 1, 2, 3, 4, 5, 6, 7, 8, and 9.</para>
        /// </description></item>
        /// <item><description><para>When <c>PeriodUnit</c> is set to <c>Year</c>: 1, 2, 3, 4, and 5.</para>
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
        /// <item><description><para>Weekly: week</para>
        /// </description></item>
        /// <item><description><para>Month: month</para>
        /// </description></item>
        /// <item><description><para>Year: year</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID of the elasticity assurance service.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2680071.html">DescribeRegions</a> to query the most recent region list.</para>
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
