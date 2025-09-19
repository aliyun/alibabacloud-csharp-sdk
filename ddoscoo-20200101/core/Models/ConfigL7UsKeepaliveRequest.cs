// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigL7UsKeepaliveRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para> A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("DownstreamKeepalive")]
        [Validation(Required=false)]
        public string DownstreamKeepalive { get; set; }

        /// <summary>
        /// <para>The settings for back-to-origin persistent connections. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: the switch for back-to-origin persistent connections. This field is required, and the value is of the Boolean type.</description></item>
        /// <item><description><b>keepalive_requests</b>: the number of requests that reuse a persistent connection. This field is required, and the value is of the integer type.</description></item>
        /// <item><description><b>keepalive_timeout</b>: the timeout period for an idle persistent connection. This field is required, and the value is of the integer type.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enabled&quot;: true, &quot;keepalive_requests&quot;: 1000,&quot;keepalive_timeout&quot;: 30}</para>
        /// </summary>
        [NameInMap("UpstreamKeepalive")]
        [Validation(Required=false)]
        public string UpstreamKeepalive { get; set; }

    }

}
