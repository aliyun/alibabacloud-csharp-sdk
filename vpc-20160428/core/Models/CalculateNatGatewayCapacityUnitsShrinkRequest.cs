// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CalculateNatGatewayCapacityUnitsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. Note: If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId of each API request may be different.</para>
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
        /// <item><description>true: sends the request without upgrading the Internet NAT gateway. The system checks whether your AccessKey pair is valid, the authorization of the Resource Access Management (RAM) user, and whether the required parameters are specified. If the request fails the check, an error message is returned. If the request passes the check, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false (default value): sends a normal request. If the request passes the check, a 2xx HTTP status code is returned and the Internet NAT gateway is directly upgraded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The details of the reserved capacity units (CUs) to be calculated.</para>
        /// </summary>
        [NameInMap("NatGatewayCapacity")]
        [Validation(Required=false)]
        public string NatGatewayCapacityShrink { get; set; }

        /// <summary>
        /// <para>The instance ID of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-2ze0dcn4mq31qx2jc****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The details of the resource reservation metrics to be calculated.</para>
        /// </summary>
        [NameInMap("NatGatewayPerformanceValues")]
        [Validation(Required=false)]
        public string NatGatewayPerformanceValuesShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
