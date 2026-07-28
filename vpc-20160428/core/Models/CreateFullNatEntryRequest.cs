// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateFullNatEntryRequest : TeaModel {
        /// <summary>
        /// <para>The backend domain name for FULLNAT address translation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.com</para>
        /// </summary>
        [NameInMap("AccessDomain")]
        [Validation(Required=false)]
        public string AccessDomain { get; set; }

        /// <summary>
        /// <para>The backend IP address for FULLNAT address translation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("AccessIp")]
        [Validation(Required=false)]
        public string AccessIp { get; set; }

        /// <summary>
        /// <para>The backend port for FULLNAT port mapping. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("AccessPort")]
        [Validation(Required=false)]
        public string AccessPort { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
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
        /// <item><description><b>true</b>: sends a dry run request. The system checks the request for potential issues, including missing required parameters, invalid parameter values, and whether the Resource Access Management (RAM) user is granted the required authorization. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request. If the request passes the check, a 2xx HTTP status code is returned and the FULLNAT entry is added.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The description of the FULLNAT entry.</para>
        /// <para>The description can be empty or 2 to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("FullNatEntryDescription")]
        [Validation(Required=false)]
        public string FullNatEntryDescription { get; set; }

        /// <summary>
        /// <para>The name of the FULLNAT entry. The name must be 2 to 128 characters in length and must start with a letter or Chinese character. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FullNatEntryName")]
        [Validation(Required=false)]
        public string FullNatEntryName { get; set; }

        /// <summary>
        /// <para>The ID of the FULLNAT table to which the FULLNAT entry belongs.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><b>TCP</b>: forwards TCP packets. </description></item>
        /// <item><description><b>UDP</b>: forwards UDP packets.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The NAT IP address that provides address translation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// <para>The frontend port for FULLNAT port mapping. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system randomly assigns an available port.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("NatIpPort")]
        [Validation(Required=false)]
        public string NatIpPort { get; set; }

        /// <summary>
        /// <para>The ID of the network interface controller (NIC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-gw8g131ef2dnbu3k****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC NAT gateway to which the FULLNAT entry belongs.</para>
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
