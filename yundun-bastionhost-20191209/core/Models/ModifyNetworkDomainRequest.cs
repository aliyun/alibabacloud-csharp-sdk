// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyNetworkDomainRequest : TeaModel {
        /// <summary>
        /// <para>The new remarks of the network domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host to which the network domain to modify belongs.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-x0r3hyr3f09</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the network domain to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NetworkDomainId")]
        [Validation(Required=false)]
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// <para>The new name of the network domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NetworkDomainName")]
        [Validation(Required=false)]
        public string NetworkDomainName { get; set; }

        /// <summary>
        /// <para>The new connection mode of the network domain. Valid values:</para>
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

        /// <summary>
        /// <para>The information about the proxy servers in the network domain.</para>
        /// </summary>
        [NameInMap("Proxies")]
        [Validation(Required=false)]
        public List<ModifyNetworkDomainRequestProxies> Proxies { get; set; }
        public class ModifyNetworkDomainRequestProxies : TeaModel {
            /// <summary>
            /// <para>The new IP address of the proxy server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114.21**.**</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The node type of the proxy server to modify. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Master</b>: primary proxy server.</description></item>
            /// <item><description><b>Slave</b>: secondary proxy server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Slave</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The new password of the proxy server account.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The new port of the proxy server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The new proxy mode. Valid values:</para>
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
            /// <para>The new username of the proxy server account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the bastion host to which the network domain to modify belongs.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
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
