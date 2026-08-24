// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class PurchaseElasticityAssuranceRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public PurchaseElasticityAssuranceRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class PurchaseElasticityAssuranceRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the elastic capacity reservation service.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The matching mode of the elastic capacity reservation service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open mode. The system automatically matches available open private pool capacity when instances are launched. If no matching private pool capacity is available, public pool resources are used.</description></item>
            /// <item><description>Target: targeted mode. Instances are launched by using the specified private pool capacity. If the specified private pool capacity is unavailable, the instances fail to be launched.</description></item>
            /// </list>
            /// <para>Default value: Open.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        /// <summary>
        /// <para>Ensures the idempotence of the request. The value is generated from your client and must be unique among different requests. The <c>ClientToken</c> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>The purchase duration. The unit of the duration is determined by the PeriodUnit parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If PeriodUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, and 9.</description></item>
        /// <item><description>If PeriodUnit is set to Year: 1, 2, 3, 4, and 5.</description></item>
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
        /// <para>The unit of the purchase duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month: month.</description></item>
        /// <item><description>Year: year.</description></item>
        /// </list>
        /// <para>Default value: Year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID of the elastic capacity reservation service. You can call <a href="https://help.aliyun.com/document_detail/2679950.html">DescribeRegions</a> to query the most recent region list.</para>
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

        /// <summary>
        /// <para>The effective period of the elastic capacity reservation service. By default, the service takes effect when the operation is invoked. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-18T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
