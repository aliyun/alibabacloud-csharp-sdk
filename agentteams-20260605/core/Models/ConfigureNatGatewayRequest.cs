// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class ConfigureNatGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The client idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description for the NAT gateway, EIP, and SNAT rule creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create public nat gateway for agentteams instance</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The allocation ID of the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-xxx</para>
        /// </summary>
        [NameInMap("EipAllocationId")]
        [Validation(Required=false)]
        public string EipAllocationId { get; set; }

        /// <summary>
        /// <para>The bandwidth of the automatically applied EIP. Valid values: 1 to 200. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the AgentTeams instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <instanceId>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-xxxx</para>
        /// </summary>
        [NameInMap("NatGatewayInstanceId")]
        [Validation(Required=false)]
        public string NatGatewayInstanceId { get; set; }

    }

}
