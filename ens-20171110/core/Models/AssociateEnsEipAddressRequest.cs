// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AssociateEnsEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP that you want to associate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-5sc1sgcrsrwgwdvx44hru3p63</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud service with which the EIP is associated.</para>
        /// <remarks>
        /// <para> You can specify the ID of an Edge Load Balancer (ELB) instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5saivuir6b1mupxjfbhmk1xkb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of instance with which you want to associate the EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Nat</b>: NAT gateway.</description></item>
        /// <item><description><b>SlbInstance</b>: Edge Load Balancer (ELB) instance.</description></item>
        /// <item><description><b>NetworkInterface</b>: secondary elastic network interface (ENI).</description></item>
        /// <item><description><b>NatSlbInstance</b>: If you want to associate multiple EIPs with an ELB instance, you need to set the parameter to this value.</description></item>
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
        /// <para>Specifies whether the EIP is a secondary EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
