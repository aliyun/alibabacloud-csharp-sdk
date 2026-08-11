// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateNetworkDomainRequest : TeaModel {
        /// <summary>
        /// <para>The description of the network domain. The description can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The instance ID of the Bastionhost instance for which you want to create a network domain.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-lbj3bw4ma02</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the network domain to create. The name can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSH Proxy</para>
        /// </summary>
        [NameInMap("NetworkDomainName")]
        [Validation(Required=false)]
        public string NetworkDomainName { get; set; }

        /// <summary>
        /// <para>The type of the network domain to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Direct: direct connection. Bastionhost is directly connected to the asset network without an intermediate proxy server.</description></item>
        /// <item><description>Proxy: proxy connection. If the network where the assets reside is not connected to the Bastionhost network, you can use a proxy server to forward network requests and manage assets in different network environments.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Proxy</para>
        /// </summary>
        [NameInMap("NetworkDomainType")]
        [Validation(Required=false)]
        public string NetworkDomainType { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The proxy server information.</para>
        /// </summary>
        [NameInMap("Proxies")]
        [Validation(Required=false)]
        public List<CreateNetworkDomainRequestProxies> Proxies { get; set; }
        public class CreateNetworkDomainRequestProxies : TeaModel {
            /// <summary>
            /// <para>The address of the proxy server.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>47.104.**.**</c></para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The node type of the proxy server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Master: primary proxy server.</description></item>
            /// <item><description>Slave: secondary proxy server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Master</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The Base64-encoded password of the proxy server account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UWdi******Ng==</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The Server Port of the proxy server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The proxy type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SSHProxy: SSH proxy.</description></item>
            /// <item><description>HTTPProxy: HTTP proxy.</description></item>
            /// <item><description>Socks5Proxy: SOCKS proxy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SSHProxy</para>
            /// </summary>
            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

            /// <summary>
            /// <para>The account of the proxy server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance for which you want to create a network domain.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
