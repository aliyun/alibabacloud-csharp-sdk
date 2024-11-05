// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetNetworkDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the network domain.</para>
        /// </summary>
        [NameInMap("NetworkDomain")]
        [Validation(Required=false)]
        public GetNetworkDomainResponseBodyNetworkDomain NetworkDomain { get; set; }
        public class GetNetworkDomainResponseBodyNetworkDomain : TeaModel {
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
            /// <para>Indicates whether the network domain is a built-in network domain.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
            /// <para>SSH Proxy</para>
            /// </summary>
            [NameInMap("NetworkDomainName")]
            [Validation(Required=false)]
            public string NetworkDomainName { get; set; }

            /// <summary>
            /// <para>The connection mode of the network domain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Direct</description></item>
            /// <item><description>Proxy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Proxy</para>
            /// </summary>
            [NameInMap("NetworkDomainType")]
            [Validation(Required=false)]
            public string NetworkDomainType { get; set; }

            /// <summary>
            /// <para>The information about the proxy servers.</para>
            /// </summary>
            [NameInMap("Proxies")]
            [Validation(Required=false)]
            public List<GetNetworkDomainResponseBodyNetworkDomainProxies> Proxies { get; set; }
            public class GetNetworkDomainResponseBodyNetworkDomainProxies : TeaModel {
                /// <summary>
                /// <para>The IP address of the proxy server.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>47.102.**.**</c></para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>Indicates whether the proxy server has a password. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasPassword")]
                [Validation(Required=false)]
                public bool? HasPassword { get; set; }

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
                /// <para>The port of the proxy server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The status of the proxy server.</para>
                /// <list type="bullet">
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>Unavailable</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unavailable</para>
                /// </summary>
                [NameInMap("ProxyState")]
                [Validation(Required=false)]
                public string ProxyState { get; set; }

                /// <summary>
                /// <para>The error code that indicates the status of the proxy server.</para>
                /// <list type="bullet">
                /// <item><description><b>CHECK_PWD_FAILED</b>: The password is invalid.</description></item>
                /// <item><description><b>CHECK_PWD_TIMEOUT</b>: The password verification session timed out.</description></item>
                /// <item><description><b>CHECK_PWD_NETWORK_ERR</b>: A network error occurred.</description></item>
                /// <item><description><b>UNEXPECTED</b>: An unknown error occurred.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK_PWD_TIMEOUT</para>
                /// </summary>
                [NameInMap("ProxyStateErrorCode")]
                [Validation(Required=false)]
                public string ProxyStateErrorCode { get; set; }

                /// <summary>
                /// <para>The proxy type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SSHProxy</b></description></item>
                /// <item><description><b>HTTPProxy</b></description></item>
                /// <item><description><b>Socks5Proxy</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTPProxy</para>
                /// </summary>
                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public string ProxyType { get; set; }

                /// <summary>
                /// <para>The username of the proxy server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05F59944-2E24-595C-B21A-8C9955E60FAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
