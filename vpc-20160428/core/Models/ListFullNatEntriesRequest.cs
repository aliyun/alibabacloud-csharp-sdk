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
        /// <para>You can generate the value from your client and make sure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters.</para>
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
        /// <para>The ID of the FULLNAT entry to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fullnat-gw8fz23jezpbblf1j****</para>
        /// </summary>
        [NameInMap("FullNatEntryId")]
        [Validation(Required=false)]
        public string FullNatEntryId { get; set; }

        /// <summary>
        /// <para>The names of the FULLNAT entries to be queried. You can query the names of up to 20 FULLNAT entries.</para>
        /// <para>The name must be 2 to 128 characters in length, and must start with a letter or a Chinese character. It can contain digits, hyphens (-), and underscores (_).</para>
        /// </summary>
        [NameInMap("FullNatEntryNames")]
        [Validation(Required=false)]
        public List<string> FullNatEntryNames { get; set; }

        /// <summary>
        /// <para>The ID of the FULLNAT table to which the FULLNAT entries to be queried belong.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>FullNatTableId</b> and <b>NatGatewayId</b> parameters.</para>
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
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway to be queried.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>FullNatTableId</b> and <b>NatGatewayId</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1uewa15k4iy5770****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The NAT IP address of the FULLNAT entry to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX</para>
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// <para>The frontend port of the FULLNAT entry to be queried. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("NatIpPort")]
        [Validation(Required=false)]
        public string NatIpPort { get; set; }

        /// <summary>
        /// <para>The IDs of the elastic network interfaces (ENIs) to be queried.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first query or no next query is to be sent, you do not need to specify this parameter.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the <b>NextToken</b> value returned from the last API call.</description></item>
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
        /// <para>The region ID of the VPC NAT gateway to which the FULLNAT entries to be queried belong.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
