// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetInstanceEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the access control list (ACL) is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AclEnable")]
        [Validation(Required=false)]
        public bool? AclEnable { get; set; }

        /// <summary>
        /// <para>The list of ACL entries.</para>
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<GetInstanceEndpointResponseBodyAclEntries> AclEntries { get; set; }
        public class GetInstanceEndpointResponseBodyAclEntries : TeaModel {
            /// <summary>
            /// <para>The comment for adding an Internet whitelist entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The CIDR block added to the Internet whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.0/24</para>
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

        }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of domain names.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<GetInstanceEndpointResponseBodyDomains> Domains { get; set; }
        public class GetInstanceEndpointResponseBodyDomains : TeaModel {
            /// <summary>
            /// <para>The domain name used to access the Enterprise instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shanghai-instance1-registry.cn-shanghai.cr.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The domain name type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>SYSTEM</c>: system domain name</para>
            /// </description></item>
            /// <item><description><para><c>USER</c>: user domain name</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the access endpoint is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F3D5EC5-39D1-4C53-A198-48C54C658FA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The running status. Valid values:</para>
        /// <para><c>CREATING</c>: Creating.</para>
        /// <para><c>RUNNING</c>: Running.</para>
        /// <para><c>DELETING</c>: Deleting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
