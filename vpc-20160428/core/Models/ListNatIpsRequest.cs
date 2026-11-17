// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatIpsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among multiple requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system prechecks the request without querying the NAT IP addresses. The system checks whether required parameters are specified, the request format is valid, and the service limits are met. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): The system sends a normal request. If the request passes the precheck, the system returns an HTTP 2xx status code and performs the operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The origin of the NAT IP addresses to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>prefix: NAT IP addresses that belong to an IP prefix.</para>
        /// </description></item>
        /// <item><description><para>cidr: Standalone NAT IP addresses that do not belong to any IP prefix.</para>
        /// </description></item>
        /// <item><description><para>Empty: All NAT IP addresses.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cidr</para>
        /// </summary>
        [NameInMap("IpOrigin")]
        [Validation(Required=false)]
        public string IpOrigin { get; set; }

        /// <summary>
        /// <para>The CIDR block of the IP prefix to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/28</para>
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public string Ipv4Prefix { get; set; }

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
        /// <para>The instance ID of the NAT gateway to which the NAT IP addresses belong.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-gw8v16wgvtq26vh59****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The CIDR block to which the NAT IP addresses belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24</para>
        /// </summary>
        [NameInMap("NatIpCidr")]
        [Validation(Required=false)]
        public string NatIpCidr { get; set; }

        /// <summary>
        /// <para>The instance IDs of the NAT IP addresses to query. Valid values of <b>N</b>: <b>1</b> to <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpcnatip-gw8a863sut1zijxh0****</para>
        /// </summary>
        [NameInMap("NatIpIds")]
        [Validation(Required=false)]
        public List<string> NatIpIds { get; set; }

        /// <summary>
        /// <para>The name of the NAT IP address to query. Valid values of <b>N</b>: <b>1</b> to <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NatIpName")]
        [Validation(Required=false)]
        public List<string> NatIpName { get; set; }

        /// <summary>
        /// <para>The status of the NAT IP addresses to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Available</b>: Available.</description></item>
        /// <item><description><b>Deleting</b>: Deleting.</description></item>
        /// <item><description><b>Creating</b>: Creating.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("NatIpStatus")]
        [Validation(Required=false)]
        public string NatIpStatus { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first query or no next query is to be sent, ignore this parameter.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the NextToken value returned in the last API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****f84eb48b699f0a4883</para>
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
        /// <para>The region ID of the NAT gateway instance to which the NAT IP addresses belong.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
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
