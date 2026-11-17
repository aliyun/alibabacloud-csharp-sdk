// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyNatRateLimitRuleRequest : TeaModel {
        /// <summary>
        /// <para>The new bandwidth limit. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public string BandwidthLimit { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without querying the resource status. The system checks whether your AccessKey pair is valid, the authorization of the Resource Access Management (RAM) user, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the dry run, a 2xx HTTP status code is returned and the resource status is queried.</para>
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
        /// <para>The ID of the NAT gateway to which the rate limiting rule belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1b0lic8uz4r6vf2****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The new description of the rate limiting rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RuleDescription")]
        [Validation(Required=false)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// <para>The ID of the rate limiting rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>limit-rule-****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The new name of the rate limiting rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-rule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The new list of source CIDR blocks for the rate limiting rule.</para>
        /// </summary>
        [NameInMap("SourceCIDRs")]
        [Validation(Required=false)]
        public List<string> SourceCIDRs { get; set; }

    }

}
