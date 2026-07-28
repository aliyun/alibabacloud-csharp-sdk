// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListFullNatEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the FULLNAT entry to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fullnat-gw8fz23jezpbblf1j****</para>
        /// </summary>
        [NameInMap("FullNatEntryId")]
        [Validation(Required=false)]
        public string FullNatEntryId { get; set; }

        /// <summary>
        /// <para>The names of the FULLNAT entries to query. You can specify up to 20 names.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, hyphens (-), and underscores (_). The name must start with a letter or Chinese character.</para>
        /// </summary>
        [NameInMap("FullNatEntryNames")]
        [Validation(Required=false)]
        public List<string> FullNatEntryNames { get; set; }

        /// <summary>
        /// <para>The ID of the FULLNAT table to which the FULLNAT entries belong.</para>
        /// <remarks>
        /// <para>You must specify at least one of <b>FullNatTableId</b> and <b>NatGatewayId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fulltb-gw88z7hhlv43rmb26****</para>
        /// </summary>
        [NameInMap("FullNatTableId")]
        [Validation(Required=false)]
        public string FullNatTableId { get; set; }

        /// <summary>
        /// <para>The protocol type of the Redirection Port. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b>: forwards TCP packets.</description></item>
        /// <item><description><b>UDP</b>: forwards UDP packets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway to query.</para>
        /// <remarks>
        /// <para>You must specify at least one of <b>FullNatTableId</b> and <b>NatGatewayId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1uewa15k4iy5770****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The NAT IP address in the FULLNAT entry to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX</para>
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// <para>The frontend port in the FULLNAT entry to query. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("NatIpPort")]
        [Validation(Required=false)]
        public string NatIpPort { get; set; }

        /// <summary>
        /// <para>The IDs of the elastic network interfaces (ENIs) to query.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request or if no next query exists.</description></item>
        /// <item><description>If a next query exists, set the value to the <b>NextToken</b> value returned in the previous API call.</description></item>
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
        /// <para>The region ID of the VPC NAT gateway to which the FULLNAT entries belong.</para>
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
