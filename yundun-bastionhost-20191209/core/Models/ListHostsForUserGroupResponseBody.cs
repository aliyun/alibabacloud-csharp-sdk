// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsForUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The hosts returned.</para>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<ListHostsForUserGroupResponseBodyHosts> Hosts { get; set; }
        public class ListHostsForUserGroupResponseBodyHosts : TeaModel {
            /// <summary>
            /// <para>The address type of the host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Public</b>: public endpoint</description></item>
            /// <item><description><b>Private</b>: internal endpoint</description></item>
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
            /// <para>The internal endpoint of the host. The value is a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("HostPrivateAddress")]
            [Validation(Required=false)]
            public string HostPrivateAddress { get; set; }

            /// <summary>
            /// <para>The public endpoint of the host. The value is a domain name or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.158.XX.XX</para>
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
        /// <para>The total number of hosts returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
