// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UnassociateVpcCidrBlockRequest : TeaModel {
        /// <summary>
        /// <para>The secondary IPv6 CIDR block to be deleted.</para>
        /// <remarks>
        /// <para> You must set one of the <b>Ipv6CidrBlock</b> and <b>SecondaryCidrBlock</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:6a::/56</para>
        /// </summary>
        [NameInMap("IPv6CidrBlock")]
        [Validation(Required=false)]
        public string IPv6CidrBlock { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC to which the secondary CIDR block to be deleted belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ch-hangzhou</para>
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
        /// <para>The secondary IPv4 CIDR block to be deleted.</para>
        /// <remarks>
        /// <para> You must set one of the <b>SecondaryCidrBlock</b> and <b>Ipv6CidrBlock</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/16</para>
        /// </summary>
        [NameInMap("SecondaryCidrBlock")]
        [Validation(Required=false)]
        public string SecondaryCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the VPC from which you want to delete a secondary CIDR block.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-o6wrloqsdqc9io3mg****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
