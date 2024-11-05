// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the hosts returned.</para>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<ListHostsResponseBodyHosts> Hosts { get; set; }
        public class ListHostsResponseBodyHosts : TeaModel {
            /// <summary>
            /// <para>The address type of the host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Public</b>: a public address</description></item>
            /// <item><description><b>Private</b>: a private address</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("ActiveAddressType")]
            [Validation(Required=false)]
            public string ActiveAddressType { get; set; }

            /// <summary>
            /// <para>The description of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The number of host accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostAccountCount")]
            [Validation(Required=false)]
            public int? HostAccountCount { get; set; }

            /// <summary>
            /// <para>The ID of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The name of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The private address of the host. The value is a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("HostPrivateAddress")]
            [Validation(Required=false)]
            public string HostPrivateAddress { get; set; }

            /// <summary>
            /// <para>The public address of the host. The value is a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX</para>
            /// </summary>
            [NameInMap("HostPublicAddress")]
            [Validation(Required=false)]
            public string HostPublicAddress { get; set; }

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
            /// <para>The source of the host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Local</b>: a host in a data center</description></item>
            /// <item><description><b>Ecs</b>: an ECS instance</description></item>
            /// <item><description><b>Rds</b>: a host in an ApsaraDB MyBase dedicated cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Local</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance or the host in an ApsaraDB MyBase dedicated cluster.</para>
            /// <remarks>
            /// <para>No value is returned for this parameter if the <b>Source</b> parameter is set to <b>Local</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp19ienyt0yax748****</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// <para>The status of the host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: normal</description></item>
            /// <item><description><b>Release</b>: released</description></item>
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
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of hosts returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
