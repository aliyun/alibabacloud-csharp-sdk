// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ForwardInfo : TeaModel {
        /// <summary>
        /// <para>EIP Allocation ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-h29r78ieufbih</para>
        /// </summary>
        [NameInMap("EipAllocationId")]
        [Validation(Required=false)]
        public string EipAllocationId { get; set; }

        /// <summary>
        /// <para>NAT Gateway ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-7j4mka9wguxj</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

    }

}
