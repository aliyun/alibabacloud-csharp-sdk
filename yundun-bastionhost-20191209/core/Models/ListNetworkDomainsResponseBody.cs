// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListNetworkDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The network domains that are returned.</para>
        /// </summary>
        [NameInMap("NetworkDomains")]
        [Validation(Required=false)]
        public List<ListNetworkDomainsResponseBodyNetworkDomains> NetworkDomains { get; set; }
        public class ListNetworkDomainsResponseBodyNetworkDomains : TeaModel {
            /// <summary>
            /// <para>The remarks of the network domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Indicates whether the network domain is built-in.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            /// <summary>
            /// <para>The network domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NetworkDomainId")]
            [Validation(Required=false)]
            public string NetworkDomainId { get; set; }

            /// <summary>
            /// <para>The name of the network domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NetworkDomainName")]
            [Validation(Required=false)]
            public string NetworkDomainName { get; set; }

            /// <summary>
            /// <para>The connection mode of the network domain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Direct</b></description></item>
            /// <item><description><b>Proxy</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Proxy</para>
            /// </summary>
            [NameInMap("NetworkDomainType")]
            [Validation(Required=false)]
            public string NetworkDomainType { get; set; }

            [NameInMap("ProxiesState")]
            [Validation(Required=false)]
            public List<ListNetworkDomainsResponseBodyNetworkDomainsProxiesState> ProxiesState { get; set; }
            public class ListNetworkDomainsResponseBodyNetworkDomainsProxiesState : TeaModel {
                /// <summary>
                /// <para>The node type of the proxy server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Master</b>: primary proxy server.</description></item>
                /// <item><description><b>Slave</b>: secondary proxy server.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Master</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The status of the proxy server.</para>
                /// <list type="bullet">
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>Unavailable</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("ProxyState")]
                [Validation(Required=false)]
                public string ProxyState { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of network domains that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
