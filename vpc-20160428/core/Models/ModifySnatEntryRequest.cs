// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifySnatEntryRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without modifying the SNAT entry. The system checks the required parameters, request format, and service limits. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and sends the request. After the check succeeds, a 2xx HTTP status code is returned and the SNAT entry is modified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable EIP affinity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: disables EIP affinity.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: enables EIP affinity.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After you enable EIP affinity, if the SNAT entry is associated with multiple EIPs or NAT IP addresses, the same client uses the same EIP or NAT IP address for access. Otherwise, the client randomly selects an EIP or NAT IP address from the associated ones for access.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EipAffinity")]
        [Validation(Required=false)]
        public int? EipAffinity { get; set; }

        /// <summary>
        /// <para>The ID of the elastic network interfaces (ENIs).</para>
        /// <remarks>
        /// <para>The IPv4 addresses of the network interface controller (NIC) are used as the SNAT addresses.</para>
        /// </remarks>
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
        /// <para>The region ID of the NAT gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The ID of the SNAT entry that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snat-bp1vcgcf8tm0plqcg****</para>
        /// </summary>
        [NameInMap("SnatEntryId")]
        [Validation(Required=false)]
        public string SnatEntryId { get; set; }

        /// <summary>
        /// <para>The name of the SNAT entry.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SnatEntry-1</para>
        /// </summary>
        [NameInMap("SnatEntryName")]
        [Validation(Required=false)]
        public string SnatEntryName { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>When you modify an SNAT entry for an Internet NAT gateway, this parameter specifies the EIPs in the SNAT entry. Separate multiple EIPs with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para>When you specify multiple EIPs to allocate an SNAT IP IPAM pool, service traffic is distributed across the EIPs by using a hash algorithm. Because traffic varies across connections, service traffic may be unevenly distributed across the EIPs. Add all EIPs to the same Internet Shared Bandwidth instance to prevent service interruptions caused by bandwidth throttling on a single EIP.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>When you modify an SNAT entry for a VPC NAT gateway, this parameter specifies the NAT IP addresses in the SNAT entry. Separate multiple NAT IP addresses with commas (,).</para>
        /// </description></item>
        /// <item><description><para>The SnatIp and NetworkInterfaceId parameters cannot be specified at the same time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>47.98.XX.XX</para>
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        /// <summary>
        /// <para>The ID of the SNAT table to which the SNAT entry belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stb-8vbczigrhop8x5u3t****</para>
        /// </summary>
        [NameInMap("SnatTableId")]
        [Validation(Required=false)]
        public string SnatTableId { get; set; }

    }

}
