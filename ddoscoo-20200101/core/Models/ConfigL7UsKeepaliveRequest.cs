// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigL7UsKeepaliveRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website service.</para>
        /// <remarks>
        /// <para>The domain name must have a website service forwarding rule configured. You can call <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> to query all domain names.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The idle timeout period of the persistent connection between the client and Anti-DDoS Proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("DownstreamKeepalive")]
        [Validation(Required=false)]
        public string DownstreamKeepalive { get; set; }

        /// <summary>
        /// <para>The persistent connection settings for back-to-origin requests of Anti-DDoS Proxy. The value is a string that represents a JSON struct. The JSON struct contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: Boolean | Required | Specifies whether to enable persistent connections for back-to-origin requests.</description></item>
        /// <item><description><b>keepalive_requests</b>: Integer | Required | The number of requests that can be sent over a persistent connection.</description></item>
        /// <item><description><b>keepalive_timeout</b>: Integer | Required | The idle timeout period of a persistent connection.</description></item>
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
