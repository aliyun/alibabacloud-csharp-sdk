// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnAssociateEnsEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the edge elastic IP address (EIP).</para>
        /// <para>If the EIP is referenced by an SNAT entry, invoke DeleteSnatIpForSnatEntry to remove it first. If the EIP is referenced by a DNAT entry, invoke DeleteForwardEntry to delete it first, or set Force to true under Settings as needed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-5sqa431nx3vee8heqxfxp****</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly disassociate the EIP when the EIP is bound to a NAT gateway that has DNAT or SNAT entries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): does not forcibly disassociate the EIP.</description></item>
        /// <item><description><b>true</b>: forcibly disassociates the EIP.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
