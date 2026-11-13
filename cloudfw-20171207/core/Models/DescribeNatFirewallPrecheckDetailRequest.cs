// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallPrecheckDetailRequest : TeaModel {
        /// <summary>
        /// <para>The language type of the request and response messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway. Although this parameter is marked as optional in the API definition, it is required when you call this operation. If this parameter is not specified or its value does not start with <c>ngw-</c>, the API returns a 400 error (<c>ErrorParameters</c>, error code <c>-360103</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1okz6k7dge****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

    }

}
