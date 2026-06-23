// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationHostsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of the hosts.</para>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<ListOperationHostsResponseBodyHosts> Hosts { get; set; }
        public class ListOperationHostsResponseBodyHosts : TeaModel {
            /// <summary>
            /// <para>The address type of the host.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Public</b>: The public endpoint is used.</para>
            /// </description></item>
            /// <item><description><para><b>Private</b>: The private endpoint is used.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("ActiveAddressType")]
            [Validation(Required=false)]
            public string ActiveAddressType { get; set; }

            /// <summary>
            /// <para>The comments on the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

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
            /// <para>host1</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The private address of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("HostPrivateAddress")]
            [Validation(Required=false)]
            public string HostPrivateAddress { get; set; }

            /// <summary>
            /// <para>The public address of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.158.XX.XX</para>
            /// </summary>
            [NameInMap("HostPublicAddress")]
            [Validation(Required=false)]
            public string HostPublicAddress { get; set; }

            /// <summary>
            /// <para>The operating system of the host.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Linux</b></para>
            /// </description></item>
            /// <item><description><para><b>Windows</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            /// <summary>
            /// <para>The source of the host.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Local</b>: a local host</para>
            /// </description></item>
            /// <item><description><para><b>Ecs</b>: an ECS instance</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Local</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp19ienyt0yax748****</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// <para>The state of the host.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: The host is running.</para>
            /// </description></item>
            /// <item><description><para><b>Release</b>: The host is released.</para>
            /// </description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F6C075F-FC86-476E-943B-097BD4E12948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of hosts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
