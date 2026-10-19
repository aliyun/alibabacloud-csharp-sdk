// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnassociateNetworkCidrBlockRequest : TeaModel {
        /// <summary>
        /// <para>The secondary IPv6 CIDR block to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:a600::/110</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The network ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-257gqcdfvx6n****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The secondary IPv4 CIDR block to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XX.XX.0/24</para>
        /// </summary>
        [NameInMap("SecondaryCidrBlock")]
        [Validation(Required=false)]
        public string SecondaryCidrBlock { get; set; }

    }

}
