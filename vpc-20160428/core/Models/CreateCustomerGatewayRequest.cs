// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateCustomerGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The autonomous system number (ASN) of the gateway device in the on-premises data center. This parameter is required if you plan to enable the BGP dynamic routing protocol for the IPsec-VPN connection. Valid values: 1 to 4294967295. The value 45104 is not supported.</para>
        /// <para><b>Asn</b> is a 4-byte number. You can enter the value in two-segment format: the first 16 bits.the last 16 bits. Each segment is entered in decimal format.</para>
        /// <para>For example, if you enter 123.456, the ASN is 123 × 65536 + 456 = 8061384.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Use a private ASN to establish a BGP connection with Alibaba Cloud. For more information about the range of private ASNs, refer to the relevant documentation.</description></item>
        /// <item><description>45104 is a unique identity allocated to Alibaba Cloud Computing Co., Ltd. by the Internet Assigned Numbers Authority (IANA). It is used to identify Alibaba Cloud in global Internet routing and data transmission.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65530</para>
        /// </summary>
        [NameInMap("Asn")]
        [Validation(Required=false)]
        public string Asn { get; set; }

        /// <summary>
        /// <para>The authentication key of the BGP routing protocol for the gateway device in the on-premises data center.</para>
        /// <para>The key must be 1 to 64 characters in length and can contain only ASCII characters. Spaces, Chinese characters, and half-width question marks (?) are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AuthKey****</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the customer gateway.  </para>
        /// <para>The description must be 1 to 100 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The static IP address of the gateway device in the on-premises data center.</para>
        /// <list type="bullet">
        /// <item><description><para>If you want to create an IPsec-VPN connection that uses the public network type, enter a public IP address.</para>
        /// </description></item>
        /// <item><description><para>If you want to create an IPsec-VPN connection that uses the private network type, enter a private IP address.</para>
        /// </description></item>
        /// </list>
        /// <para>The following IP addresses are not supported. If you use these IP addresses, the IPsec-VPN connection cannot be established:</para>
        /// <list type="bullet">
        /// <item><description>100.64.0.0 to 100.127.255.255</description></item>
        /// <item><description>127.0.0.0 to 127.255.255.255</description></item>
        /// <item><description>169.254.0.0 to 169.254.255.255</description></item>
        /// <item><description>224.0.0.0 to 239.255.255.255</description></item>
        /// <item><description>255.0.0.0 to 255.255.255.255</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.12.XX.XX</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The name of the customer gateway.  </para>
        /// <para>The name must be 1 to 100 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the customer gateway. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the customer gateway belongs.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query the resource group ID.</description></item>
        /// <item><description>If you do not specify a resource group, the customer gateway belongs to the default resource group after it is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2qo2h4jy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags to add to the customer gateway.</para>
        /// <para>You can add up to 20 tags to a customer gateway at a time.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateCustomerGatewayRequestTags> Tags { get; set; }
        public class CreateCustomerGatewayRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. If you specify this parameter, the value cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be up to 128 characters in length and can be an empty string. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key corresponds to one tag value. You can specify up to 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
