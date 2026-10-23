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
            /// <para>The list of elasticity assurance IDs. This parameter is required. If this parameter is not specified, the API returns MissingParameter.PrivatePoolOptions.Id.</para>
            /// <para><b>Limits</b>: You can renew up to 20 elasticity assurances at a time.</para>
            /// <para>You can call <a href="https://help.aliyun.com/document_detail/2679748.html">DescribeElasticityAssurances</a> to query the purchased elasticity assurances.</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public List<string> Id { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes.</description></item>
        /// <item><description>false: no.</description></item>
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
        /// <item><description><para>true: enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para>false: disables auto-renewal.</para>
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
        /// <para>The auto-renewal duration in months. Valid values: 1, 2, 3, 6, 12, 24, and 36.</para>
        /// <list type="bullet">
        /// <item><description><para>If PeriodUnit is set to Month, the default value is 1.</para>
        /// </description></item>
        /// <item><description><para>If PeriodUnit is set to Year, the default value is 12.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when AutoRenew is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>Ensures the idempotence of the request. You can generate a value from your client to ensure that the value is unique across different requests. ClientToken supports only ASCII characters and can be up to 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>The renewal duration. The unit is specified by the PeriodUnit parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If PeriodUnit is set to Weekly, valid values are 1, 2, and 3.</para>
        /// </description></item>
        /// <item><description><para>If PeriodUnit is set to Month, valid values are 1, 2, 3, 4, 5, 6, 7, 8, and 9.</para>
        /// </description></item>
        /// <item><description><para>If PeriodUnit is set to Year, valid values are 1, 2, 3, 4, and 5.</para>
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
        /// <item><description><para>Weekly: week.</para>
        /// </description></item>
        /// <item><description><para>Month: month.</para>
        /// </description></item>
        /// <item><description><para>Year: year.</para>
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
        /// <para>The region ID of the elasticity assurance. You can call <a href="https://help.aliyun.com/document_detail/2680071.html">DescribeRegions</a> to query the latest Alibaba Cloud region list.</para>
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
