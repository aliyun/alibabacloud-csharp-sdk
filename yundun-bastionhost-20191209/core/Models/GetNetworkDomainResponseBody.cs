// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetNetworkDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the network domain.</para>
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
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
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
            /// <para>The network domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SSH Proxy</para>
            /// </summary>
            [NameInMap("NetworkDomainName")]
            [Validation(Required=false)]
            public string NetworkDomainName { get; set; }

            /// <summary>
            /// <para>The network domain type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Direct: direct connection</description></item>
            /// <item><description>Proxy: proxy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Proxy</para>
            /// </summary>
            [NameInMap("NetworkDomainType")]
            [Validation(Required=false)]
            public string NetworkDomainType { get; set; }

            /// <summary>
            /// <para>The proxy server information.</para>
            /// </summary>
            [NameInMap("Proxies")]
            [Validation(Required=false)]
            public List<GetNetworkDomainResponseBodyNetworkDomainProxies> Proxies { get; set; }
            public class GetNetworkDomainResponseBodyNetworkDomainProxies : TeaModel {
                /// <summary>
                /// <para>The proxy server address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>47.102.**.**</c></para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>Indicates whether a password is set for the proxy server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: A password is set.</description></item>
                /// <item><description><b>false</b>: No password is set.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasPassword")]
                [Validation(Required=false)]
                public bool? HasPassword { get; set; }

                /// <summary>
                /// <para>The proxy server node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Master: primary proxy server</description></item>
                /// <item><description>Slave: secondary proxy server</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Master</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The proxy server port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The proxy server status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Available</b>: The proxy server is available.</description></item>
                /// <item><description><b>Unavailable</b>: The proxy server is unavailable.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unavailable</para>
                /// </summary>
                [NameInMap("ProxyState")]
                [Validation(Required=false)]
                public string ProxyState { get; set; }

                /// <summary>
                /// <para>The error code of the proxy server status.</para>
                /// <list type="bullet">
                /// <item><description>CHECK_PWD_FAILED: The password is incorrect. Password verification failed.</description></item>
                /// <item><description>CHECK_PWD_TIMEOUT: Password verification timed out.</description></item>
                /// <item><description>CHECK_PWD_NETWORK_ERR: A network error occurred.</description></item>
                /// <item><description>UNEXPECTED: An unknown error occurred.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK_PWD_TIMEOUT</para>
                /// </summary>
                [NameInMap("ProxyStateErrorCode")]
                [Validation(Required=false)]
                public string ProxyStateErrorCode { get; set; }

                /// <summary>
                /// <para>The proxy method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SSHProxy: SSH proxy</description></item>
                /// <item><description>HTTPProxy: HTTP proxy</description></item>
                /// <item><description>Socks5Proxy: SOCKS proxy</description></item>
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
        /// <para>The request ID generated by Alibaba Cloud for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05F59944-2E24-595C-B21A-8C9955E60FAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
