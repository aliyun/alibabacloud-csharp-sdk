// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class SwitchSecurityProxyRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default)</description></item>
        /// <item><description><b>en</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the NAT firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy-natbfd2fafbb77042308d1b</para>
        /// </summary>
        [NameInMap("ProxyId")]
        [Validation(Required=false)]
        public string ProxyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the NAT firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>open: yes</description></item>
        /// <item><description>close: no</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("Switch")]
        [Validation(Required=false)]
        public string Switch { get; set; }

    }

}
