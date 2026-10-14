// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AssociateEnsEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP to be associated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-5sc1sgcrsrwgwdvx44hru****</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud product instance to attach the EIP to.</para>
        /// <remarks>
        /// <para>Load balancing (ELB) instance IDs are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5saivuir6b1mupxjfbhmk****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the EIP instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Nat</b>: NAT gateway.</description></item>
        /// <item><description><b>SlbInstance</b>: load balancing (ELB).</description></item>
        /// <item><description><b>NetworkInterface</b>: secondary network interface controller (NIC).</description></item>
        /// <item><description><b>NatSlbInstance</b>: select this value when attaching multiple EIPs to an ELB.</description></item>
        /// <item><description><b>EnsInstance</b> (default): ENS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SlbInstance</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether the EIP is a standby EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: standby.</para>
        /// </description></item>
        /// <item><description><para>false: not standby.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Standby")]
        [Validation(Required=false)]
        public bool? Standby { get; set; }

    }

}
