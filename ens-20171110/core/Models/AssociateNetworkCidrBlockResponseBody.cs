// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AssociateNetworkCidrBlockResponseBody : TeaModel {
        /// <summary>
        /// <para>The allocated secondary CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:a600::/110</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The IP address type of the secondary CIDR block. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4: IPv4 address.</description></item>
        /// <item><description>IPV6: IPv6 address.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPV6</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
