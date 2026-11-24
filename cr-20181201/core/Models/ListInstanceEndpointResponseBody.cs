// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListInstanceEndpointResponseBody : TeaModel {
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
        /// <para>The endpoints of the instance.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListInstanceEndpointResponseBodyEndpoints> Endpoints { get; set; }
        public class ListInstanceEndpointResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>Indicates whether the endpoint is added to an access control list (ACL).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AclEnable")]
            [Validation(Required=false)]
            public bool? AclEnable { get; set; }

            /// <summary>
            /// <para>The ACLs that are configured for the instance.</para>
            /// </summary>
            [NameInMap("AclEntries")]
            [Validation(Required=false)]
            public List<ListInstanceEndpointResponseBodyEndpointsAclEntries> AclEntries { get; set; }
            public class ListInstanceEndpointResponseBodyEndpointsAclEntries : TeaModel {
                /// <summary>
                /// <para>The information about the ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Entry")]
                [Validation(Required=false)]
                public string Entry { get; set; }

            }

            /// <summary>
            /// <para>The list of domain names of the Container Registry instance.</para>
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<ListInstanceEndpointResponseBodyEndpointsDomains> Domains { get; set; }
            public class ListInstanceEndpointResponseBodyEndpointsDomains : TeaModel {
                /// <summary>
                /// <para>The domain name of the Container Registry instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t****-registry.cn-shanghai.cr.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The type of the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SYSTEM: system domain name.</description></item>
                /// <item><description>USER: user domain name.</description></item>
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
            /// <para>Indicates whether the endpoint is added to an ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The type of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>internet</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The VPCs associated with the instance.</para>
            /// </summary>
            [NameInMap("LinkedVpcs")]
            [Validation(Required=false)]
            public List<ListInstanceEndpointResponseBodyEndpointsLinkedVpcs> LinkedVpcs { get; set; }
            public class ListInstanceEndpointResponseBodyEndpointsLinkedVpcs : TeaModel {
                /// <summary>
                /// <para>VPC ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The status of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

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
        /// <para>1B21A877-66A2-4095-90EB-20A7781A4A67</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
