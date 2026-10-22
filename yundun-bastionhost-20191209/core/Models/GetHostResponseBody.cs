// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the queried host.</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public GetHostResponseBodyHost Host { get; set; }
        public class GetHostResponseBodyHost : TeaModel {
            /// <summary>
            /// <para>The host address type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Public</b>: public address.</description></item>
            /// <item><description><b>Private</b>: private network address.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("ActiveAddressType")]
            [Validation(Required=false)]
            public string ActiveAddressType { get; set; }

            /// <summary>
            /// <para>The remarks of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The host ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The private network address of the host, which can be a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("HostPrivateAddress")]
            [Validation(Required=false)]
            public string HostPrivateAddress { get; set; }

            /// <summary>
            /// <para>The public address of the host, which can be a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX</para>
            /// </summary>
            [NameInMap("HostPublicAddress")]
            [Validation(Required=false)]
            public string HostPublicAddress { get; set; }

            /// <summary>
            /// <para>The ID of the network domain to which the host belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NetworkDomainId")]
            [Validation(Required=false)]
            public string NetworkDomainId { get; set; }

            /// <summary>
            /// <para>The operating system of the host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Linux</b></description></item>
            /// <item><description><b>Windows</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            /// <summary>
            /// <para>The preferred key exchange algorithm configuration of the host. This parameter is returned only when OSType is Linux.</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: default mode.</description></item>
            /// <item><description><b>diffie-hellman-group1-sha1</b>: diffie-hellman-group1-sha1 algorithm compatibility mode.</description></item>
            /// <item><description><b>diffie-hellman-group14-sha1</b>: diffie-hellman-group14-sha1 algorithm compatibility mode.</description></item>
            /// <item><description><b>diffie-hellman-group-exchange-sha1</b>: diffie-hellman-group-exchange-sha1 algorithm compatibility mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("PrefKex")]
            [Validation(Required=false)]
            public string PrefKex { get; set; }

            /// <summary>
            /// <para>The protocol information of the host.</para>
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<GetHostResponseBodyHostProtocols> Protocols { get; set; }
            public class GetHostResponseBodyHostProtocols : TeaModel {
                /// <summary>
                /// <para>The host fingerprint information, which uniquely identifies a host. The bastion host records the host fingerprint only when you use the bastion host to perform O&amp;M on the target host. Otherwise, this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ssh-ed25519|3e:46:5a:e1:1f:0d:39:7e:61:35:d5:fa:7b:2b:<b>:</b></para>
                /// </summary>
                [NameInMap("HostFingerPrint")]
                [Validation(Required=false)]
                public string HostFingerPrint { get; set; }

                /// <summary>
                /// <para>The service port of the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol name used by the host. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SSH</b></description></item>
                /// <item><description><b>RDP</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SSH</para>
                /// </summary>
                [NameInMap("ProtocolName")]
                [Validation(Required=false)]
                public string ProtocolName { get; set; }

            }

            /// <summary>
            /// <para>The source of the host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Local</b>: local host.</description></item>
            /// <item><description><b>Ecs</b>: ECS instance.</description></item>
            /// <item><description><b>Rds</b>: ApsaraDB RDS dedicated cluster host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Local</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The ECS instance ID or dedicated cluster host ID that corresponds to the host.</para>
            /// <remarks>
            /// <para>If <b>Source</b> is set to <b>Local</b>, this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp19ienyt0yax748****</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// <para>The host status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: Normal.</description></item>
            /// <item><description><b>Release</b>: Released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("SourceInstanceState")]
            [Validation(Required=false)]
            public string SourceInstanceState { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID generated by Alibaba Cloud for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
