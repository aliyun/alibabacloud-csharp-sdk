// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class NetworkConfiguration : TeaModel {
        /// <summary>
        /// <para>The network access mode. Valid values: PUBLIC (public network only), PRIVATE (VPC only), PUBLIC_AND_PRIVATE (both public network and VPC are reachable).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC_AND_PRIVATE</para>
        /// </summary>
        [NameInMap("networkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <para>The ID of the security group used by the sandboxed container instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-****</para>
        /// </summary>
        [NameInMap("securityGroupID")]
        [Validation(Required=false)]
        public string SecurityGroupID { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the sandboxed container instances are connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-****</para>
        /// </summary>
        [NameInMap("vpcID")]
        [Validation(Required=false)]
        public string VpcID { get; set; }

        /// <summary>
        /// <para>The list of vSwitch IDs to which the sandboxed container instances are connected. Configure vSwitches in multiple zones to improve availability.</para>
        /// </summary>
        [NameInMap("vswitchIDs")]
        [Validation(Required=false)]
        public List<string> VswitchIDs { get; set; }

    }

}
