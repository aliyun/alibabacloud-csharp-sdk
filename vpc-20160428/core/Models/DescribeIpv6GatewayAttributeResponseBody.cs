// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6GatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status of the IPv6 gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: Normal.</para>
        /// </description></item>
        /// <item><description><para><b>FinancialLocked</b>: financial lock.</para>
        /// </description></item>
        /// <item><description><para><b>SecurityLocked</b>: security lock.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The time when the IPv6 gateway was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-05T09:21:35Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The description of the IPv6 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expiration time of the IPv6 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-1-05T09:21:35Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The ID of the gateway route table associated with the IPv6 gateway.</para>
        /// <remarks>
        /// <para>This parameter is displayed only for IPv6 gateways that are associated with a gateway route table.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-5ts0ohchwkp3dydt2****</para>
        /// </summary>
        [NameInMap("GatewayRouteTableId")]
        [Validation(Required=false)]
        public string GatewayRouteTableId { get; set; }

        /// <summary>
        /// <para>The billing method of the IPv6 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance ID of the IPv6 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6gw-hp3y0l3ln89j8cdvf****</para>
        /// </summary>
        [NameInMap("Ipv6GatewayId")]
        [Validation(Required=false)]
        public string Ipv6GatewayId { get; set; }

        /// <summary>
        /// <para>The name of the IPv6 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the IPv6 gateway owner.</para>
        /// <remarks>
        /// <para>Notice: This value is of the Long type. Precision loss may occur in certain programming languages. Use this value with caution.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2546073170691****</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the IPv6 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the IPv6 gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Pending</b>: being configured.</para>
        /// </description></item>
        /// <item><description><para><b>Available</b>: active.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeIpv6GatewayAttributeResponseBodyTags Tags { get; set; }
        public class DescribeIpv6GatewayAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeIpv6GatewayAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeIpv6GatewayAttributeResponseBodyTagsTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the VPC to which the IPv6 gateway belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-123sedrfswd23****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
