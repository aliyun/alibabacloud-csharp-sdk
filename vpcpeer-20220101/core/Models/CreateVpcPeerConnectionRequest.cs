// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcPeer20220101.Models
{
    public class CreateVpcPeerConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the acceptor of the VPC peering connection belongs.</para>
        /// <list type="bullet">
        /// <item><description><para>If you enter your own Alibaba Cloud account ID, a same-account VPC peering connection is created.</para>
        /// </description></item>
        /// <item><description><para>If you enter the ID of another Alibaba Cloud account, a cross-account VPC peering connection is created.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the acceptor account is a Resource Access Management (RAM) user, you must enter the ID of the Alibaba Cloud account to which the RAM user belongs in <b>AcceptingAliUid</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1210123456123456</para>
        /// </summary>
        [NameInMap("AcceptingAliUid")]
        [Validation(Required=false)]
        public long? AcceptingAliUid { get; set; }

        /// <summary>
        /// <para>The ID of the region where the acceptor of the VPC peering connection is deployed.</para>
        /// <list type="bullet">
        /// <item><description><para>To create an intra-region VPC peering connection, enter the same region ID as the initiator.</para>
        /// </description></item>
        /// <item><description><para>To create an inter-region VPC peering connection, enter a region ID different from that of the initiator.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AcceptingRegionId")]
        [Validation(Required=false)]
        public string AcceptingRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC that acts as the acceptor of the VPC peering connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1vzjkp2q1xgnind****</para>
        /// </summary>
        [NameInMap("AcceptingVpcId")]
        [Validation(Required=false)]
        public string AcceptingVpcId { get; set; }

        /// <summary>
        /// <para>The bandwidth of the VPC peering connection. Unit: Mbit/s. The value must be a positive integer.</para>
        /// <remarks>
        /// <para>If you want to specify this parameter, make sure that you are creating an inter-region peering connection.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the VPC peering connection. The description must be 2 to 256 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run and does not create a VPC peering connection. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the dry run, the corresponding error is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a Normal request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the jumbo frame feature for the VPC peering connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false: disabled.<remarks>
        /// <para>Note: If you want to specify this parameter, make sure that you are creating an inter-region peering connection.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableJumboFrame")]
        [Validation(Required=false)]
        public bool? EnableJumboFrame { get; set; }

        /// <summary>
        /// <para>The link type.</para>
        /// <para>Valid values: Platinum and Gold. Default value: Gold.</para>
        /// <remarks>
        /// <para>If you want to specify this parameter, make sure that you are creating an inter-region peering connection.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Gold</para>
        /// </summary>
        [NameInMap("LinkType")]
        [Validation(Required=false)]
        public string LinkType { get; set; }

        /// <summary>
        /// <para>The name of the VPC peering connection. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpcpeer</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the region where you want to create a VPC peering connection. </para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.html">What is a resource group?</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVpcPeerConnectionRequestTag> Tag { get; set; }
        public class CreateVpcPeerConnectionRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You must specify at least one tag key and can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You must specify at least one tag value and can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID create a VPC that acts as the initiator create a VPC peering connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1gsk7h12ew7oegk****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
