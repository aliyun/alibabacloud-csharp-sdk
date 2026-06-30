// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCommonAreasRequest : TeaModel {
        /// <summary>
        /// <para>The IP address protocol used to connect to Global Accelerator (GA). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b> (default): IPv4 address protocol. Queries regions that support IPv4.</description></item>
        /// <item><description><b>IPv6</b>: IPv6 address protocol. Queries regions that support IPv6.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether the region is an endpoint group region supported by Global Accelerator.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b> (default): No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsEpg")]
        [Validation(Required=false)]
        public bool? IsEpg { get; set; }

        /// <summary>
        /// <para>Specifies whether the region is an acceleration area supported by Global Accelerator.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b> (default): No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsIpSet")]
        [Validation(Required=false)]
        public bool? IsIpSet { get; set; }

    }

}
