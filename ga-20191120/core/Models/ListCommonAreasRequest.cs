// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCommonAreasRequest : TeaModel {
        /// <summary>
        /// <para>The IP version used to connect to the GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b> (default)</description></item>
        /// <item><description><b>IPv6</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to query regions where endpoint groups of GA can be deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsEpg")]
        [Validation(Required=false)]
        public bool? IsEpg { get; set; }

        /// <summary>
        /// <para>Specifies whether to query regions supported by GA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
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
