// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationHostsResponseBody : TeaModel {
        /// <summary>
        /// <para>The hosts returned.</para>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<ListOperationHostsResponseBodyHosts> Hosts { get; set; }
        public class ListOperationHostsResponseBodyHosts : TeaModel {
            /// <summary>
            /// <para>The address type of the host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Public</b></description></item>
            /// <item><description><b>Private</b></description></item>
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
            /// <para>comment</para>
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
            /// <para>The host name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host1</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The private IP address of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("HostPrivateAddress")]
            [Validation(Required=false)]
            public string HostPrivateAddress { get; set; }

            /// <summary>
            /// <para>The public IP address of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.158.XX.XX</para>
            /// </summary>
            [NameInMap("HostPublicAddress")]
            [Validation(Required=false)]
            public string HostPublicAddress { get; set; }

            /// <summary>
            /// <para>The host OS.</para>
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
            /// <para>The host type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Local</b>: on-premises host.</description></item>
            /// <item><description><b>Ecs</b>: Elastic Compute Service (ECS) instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Local</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The ECS instance ID.</para>
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
            /// <item><description><b>Normal</b></description></item>
            /// <item><description><b>Release</b></description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F6C075F-FC86-476E-943B-097BD4E12948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of hosts returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
