// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateCustomerGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The autonomous system number (ASN) of the gateway device in the data center.</para>
        /// <para><b>Asn</b> is a 4-byte number. You can enter the number in two segments and separate the first 16 bits from the following 16 bits with a period (.). Enter the number in each segment in the decimal format.</para>
        /// <para>For example, if you enter 123.456, the ASN is: 123 × 65536 + 456 = 8061384.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65530</para>
        /// </summary>
        [NameInMap("Asn")]
        [Validation(Required=false)]
        public string Asn { get; set; }

        /// <summary>
        /// <para>The authentication key of the BGP routing protocol for the gateway device in the data center.</para>
        /// <para>The key must be 1 to 64 characters in length. It can contain only ASCII characters and cannot contain spaces or question marks (?).</para>
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
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the customer gateway.</para>
        /// <para>The description must be 1 to 100 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The public IP address of the gateway device in the data center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.12.XX.XX</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The name of the customer gateway.</para>
        /// <para>The name must be 1 to 100 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The region ID of the customer gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query the resource group list.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify a resource group, the customer gateway will belong to the default resource group after being created.</para>
        /// </description></item>
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
        /// <para>The tag value.</para>
        /// <para>The tag value can be an empty string and cannot exceed 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// <para>Each tag key corresponds to one tag value. You can specify up to 20 tag values in each call.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateCustomerGatewayRequestTags> Tags { get; set; }
        public class CreateCustomerGatewayRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string.</para>
            /// <para>It can be at most 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be an empty string and cannot exceed 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key corresponds to one tag value. You can specify at most 20 tag values in each call.</para>
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
