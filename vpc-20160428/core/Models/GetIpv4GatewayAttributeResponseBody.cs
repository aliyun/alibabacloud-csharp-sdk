// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetIpv4GatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the IPv4 gateway was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-24T09:02:36Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the IPv4 gateway is activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The IPv4 gateway is activated.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The IPv4 gateway is not activated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The description of the IPv4 gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new</para>
        /// </summary>
        [NameInMap("Ipv4GatewayDescription")]
        [Validation(Required=false)]
        public string Ipv4GatewayDescription { get; set; }

        /// <summary>
        /// <para>The instance ID of the IPv4 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4gw-5tsnc6s4ogsedtp3k****</para>
        /// </summary>
        [NameInMap("Ipv4GatewayId")]
        [Validation(Required=false)]
        public string Ipv4GatewayId { get; set; }

        /// <summary>
        /// <para>The name of the IPv4 gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Ipv4GatewayName")]
        [Validation(Required=false)]
        public string Ipv4GatewayName { get; set; }

        /// <summary>
        /// <para>The ID of the route table associated with the IPv4 gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-5ts0ohchwkp3dydt2****</para>
        /// </summary>
        [NameInMap("Ipv4GatewayRouteTableId")]
        [Validation(Required=false)]
        public string Ipv4GatewayRouteTableId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F79A919-6FE9-50C4-967B-45705E1F9C38</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the IPv4 gateway belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the IPv4 gateway instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Creating</b>: The IPv4 gateway is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Created</b>: The IPv4 gateway is created and available.</para>
        /// </description></item>
        /// <item><description><para><b>Modifying</b>: The IPv4 gateway is being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The IPv4 gateway is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>Deleted</b>: The IPv4 gateway is deleted.</para>
        /// </description></item>
        /// <item><description><para><b>Activating</b>: The IPv4 gateway is being activated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetIpv4GatewayAttributeResponseBodyTags> Tags { get; set; }
        public class GetIpv4GatewayAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC associated with the IPv4 gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-5tsrxlw7dv074gci4****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
