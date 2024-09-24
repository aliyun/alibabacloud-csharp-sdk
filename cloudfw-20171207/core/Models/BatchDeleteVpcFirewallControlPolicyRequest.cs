// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class BatchDeleteVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The UUIDs of access control policies.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AclUuidList")]
        [Validation(Required=false)]
        public List<string> AclUuidList { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-m5e7dbc4y****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
