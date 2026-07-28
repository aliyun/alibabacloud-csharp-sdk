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
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses <b>RequestId</b> as <b>ClientToken</b>. The value of <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The origin of the NAT IP address to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>prefix: a NAT IP address that belongs to an IP prefix.</para>
        /// </description></item>
        /// <item><description><para>cidr: a standalone NAT IP address that does not belong to any IP prefix.</para>
        /// </description></item>
        /// <item><description><para>Empty: queries all NAT IP addresses.</para>
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
        /// <para>The number of entries per page for a paged query. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
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
        /// <para>The instance ID of the NAT IP address to query. Valid values of <b>N</b>: <b>1</b> to <b>20</b>.</para>
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
        /// <item><description><b>Available</b>: available.</description></item>
        /// <item><description><b>Deleting</b>: being deleted.</description></item>
        /// <item><description><b>Creating</b>: being created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("NatIpStatus")]
        [Validation(Required=false)]
        public string NatIpStatus { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request or if no subsequent query exists.</description></item>
        /// <item><description>If a next query exists, set the value to the NextToken value returned in the previous API call.</description></item>
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
