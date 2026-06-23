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
            /// <para>The comment for the network domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Specifies whether the network domain is built-in. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            /// <summary>
            /// <para>The ID of the network domain.</para>
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
            /// <para>The type of the network domain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Direct: direct connection</para>
            /// </description></item>
            /// <item><description><para>Proxy: proxy</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Proxy</para>
            /// </summary>
            [NameInMap("NetworkDomainType")]
            [Validation(Required=false)]
            public string NetworkDomainType { get; set; }

            /// <summary>
            /// <para>A list of proxy servers.</para>
            /// </summary>
            [NameInMap("Proxies")]
            [Validation(Required=false)]
            public List<GetNetworkDomainResponseBodyNetworkDomainProxies> Proxies { get; set; }
            public class GetNetworkDomainResponseBodyNetworkDomainProxies : TeaModel {
                /// <summary>
                /// <para>The address of the proxy server.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>47.102.**.**</c></para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>Specifies whether a password is set for the proxy server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: A password is set.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: No password is set.</para>
                /// </description></item>
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
                /// <item><description><para>Master: primary proxy server</para>
                /// </description></item>
                /// <item><description><para>Slave: secondary proxy server</para>
                /// </description></item>
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
                /// <para>The status of the proxy server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Available</b>: available</para>
                /// </description></item>
                /// <item><description><para><b>Unavailable</b>: unavailable</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unavailable</para>
                /// </summary>
                [NameInMap("ProxyState")]
                [Validation(Required=false)]
                public string ProxyState { get; set; }

                /// <summary>
                /// <para>The error code that is returned if the proxy server is unavailable. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>CHECK_PWD_FAILED</b>: Incorrect password.</para>
                /// </description></item>
                /// <item><description><para><b>CHECK_PWD_TIMEOUT</b>: Password verification timeout.</para>
                /// </description></item>
                /// <item><description><para><b>CHECK_PWD_NETWORK_ERR</b>: Network error.</para>
                /// </description></item>
                /// <item><description><para><b>UNEXPECTED</b>: Unknown error.</para>
                /// </description></item>
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
                /// <item><description><para>SSHProxy: SSH proxy</para>
                /// </description></item>
                /// <item><description><para>HTTPProxy: HTTP proxy</para>
                /// </description></item>
                /// <item><description><para>Socks5Proxy: SOCKS5 proxy</para>
                /// </description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05F59944-2E24-595C-B21A-8C9955E60FAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
