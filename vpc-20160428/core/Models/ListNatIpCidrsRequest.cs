// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatIpCidrsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the system automatically uses <b>RequestId</b> as <b>ClientToken</b>. <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: checks the API request. The CIDR blocks of the NAT gateway are not queried if the API request passes the precheck. The system checks whether your AccessKey pair is valid, whether the Resource Access Management (RAM) user is authorized, and whether the required parameters are set. If the request fails to pass the precheck, the corresponding error message is returned. If the check succeeds, the DryRunOperation error code is returned.</description></item>
        /// <item><description><b>false</b>: sends the API request. If the request passes the precheck, 2xx HTTP status code is returned and the CIDR blocks of the NAT gateway are queried. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of the VPC NAT gateway that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-gw8v16wgvtq26vh59****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The CIDR block of the NAT gateway that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/24</para>
        /// </summary>
        [NameInMap("NatIpCidr")]
        [Validation(Required=false)]
        public string NatIpCidr { get; set; }

        /// <summary>
        /// <para>The name of the CIDR block that you want to query. Valid values of <b>N</b>: <b>1</b> to <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NatIpCidrName")]
        [Validation(Required=false)]
        public List<string> NatIpCidrName { get; set; }

        /// <summary>
        /// <para>The status of the CIDR block that you want to query. Set the value to <b>Available</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("NatIpCidrStatus")]
        [Validation(Required=false)]
        public string NatIpCidrStatus { get; set; }

        /// <summary>
        /// <para>The CIDR block of the NAT gateway that you want to query. Valid values of <b>N</b>: <b>1</b> to <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/24</para>
        /// </summary>
        [NameInMap("NatIpCidrs")]
        [Validation(Required=false)]
        public List<string> NatIpCidrs { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Set the value as needed.</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query or no next query is to be sent, ignore this parameter.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the value of NextToken that is returned from the last call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Virtual Private Cloud (VPC) NAT gateway that you want to query.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eu-central-1</para>
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
