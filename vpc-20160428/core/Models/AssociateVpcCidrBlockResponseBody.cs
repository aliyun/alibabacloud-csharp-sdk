// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateVpcCidrBlockResponseBody : TeaModel {
        /// <summary>
        /// <para>The IPv4 CIDR block to be added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/16</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The version of the IP address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPV4</b>: the IPv4 address.</description></item>
        /// <item><description><b>IPV6</b>: the IPv6 address.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1221A1F-2ACD-4592-8F27-474E02883159</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
