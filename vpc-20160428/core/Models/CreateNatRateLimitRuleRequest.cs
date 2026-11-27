// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatRateLimitRuleRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth limit. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public string BandwidthLimit { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The system prechecks the request without creating the rate limiting rule. The system checks whether the required parameters are specified, and validates the request format and limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): The system sends a normal request. If the request passes the precheck, the rate limiting rule is created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The source match type for rate limiting. Valid values:</para>
        /// <para>CIDR: CIDR block match. This is the default value.
        /// TUNNEL: tunnel match. If you set the value to TUNNEL, a corresponding SNAT rule of the TUNNEL type must exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CIDR</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway to which the rate limiting rule belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
        /// <para>You can call the DescribeRegions operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The description of the rate limiting rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test rule description</para>
        /// </summary>
        [NameInMap("RuleDescription")]
        [Validation(Required=false)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// <para>The name of the rate limiting rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-rule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The list of source CIDR blocks to which the rate limiting rule applies.</para>
        /// </summary>
        [NameInMap("SourceCIDRs")]
        [Validation(Required=false)]
        public List<string> SourceCIDRs { get; set; }

        /// <summary>
        /// <para>The tunnel index. If MatchType is set to TUNNEL, a corresponding SNAT rule must exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TunnelIndex")]
        [Validation(Required=false)]
        public string TunnelIndex { get; set; }

    }

}
