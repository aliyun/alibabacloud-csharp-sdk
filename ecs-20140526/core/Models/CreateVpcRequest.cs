// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateVpcRequest : TeaModel {
        /// <summary>
        /// <para>The IPv4 CIDR block of the VPC. You can use one of the following standard IPv4 CIDR blocks or their subnets:</para>
        /// <list type="bullet">
        /// <item><description><c>10.0.0.0/8</c></description></item>
        /// <item><description><c>172.16.0.0/12</c></description></item>
        /// <item><description><c>192.168.0.0/16</c></description></item>
        /// </list>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request. The token must be unique across requests, contain only ASCII characters, and not exceed 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The VPC description. The description must be 2 to 256 characters long and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the VPC will be created. You can call the <c>DescribeRegions</c> operation to query the latest list of regions.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The user CIDR block. You can specify a user CIDR block as an alternative to the standard CIDR blocks. This lets you use a private IP address range other than <c>10.0.0.0/8</c>, <c>172.16.0.0/12</c>, or <c>192.168.0.0/16</c> as the CIDR block for the VPC.</para>
        /// </summary>
        [NameInMap("UserCidr")]
        [Validation(Required=false)]
        public string UserCidr { get; set; }

        /// <summary>
        /// <para>The VPC name. It must be 2 to 128 characters long, start with a letter, and contain only letters, digits, underscores (_), and hyphens (-).</para>
        /// </summary>
        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

    }

}
