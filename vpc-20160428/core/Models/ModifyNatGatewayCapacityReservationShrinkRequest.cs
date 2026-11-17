// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyNatGatewayCapacityReservationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters. Note: If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Performs a dry run without upgrading the Internet NAT gateway. The system checks whether your AccessKey pair is valid, the authorization of the Resource Access Management (RAM) user, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false (default): Sends a Normal request. If the request passes the dry run, a 2xx HTTP status code is returned and the Internet NAT gateway is upgraded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The number of capacity units (CUs) for the NAT resource reservation.</para>
        /// </summary>
        [NameInMap("NatGatewayCapacity")]
        [Validation(Required=false)]
        public string NatGatewayCapacityShrink { get; set; }

        /// <summary>
        /// <para>The instance ID of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-112za33e4****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to cancel the resource reservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Cancels the resource reservation.</description></item>
        /// <item><description><b>false</b> (default): Does not cancel the resource reservation. You do not need to specify this parameter when you create or modify a resource reservation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResetCapacityReservation")]
        [Validation(Required=false)]
        public string ResetCapacityReservation { get; set; }

    }

}
