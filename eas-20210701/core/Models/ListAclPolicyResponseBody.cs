// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListAclPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The private gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-1uhcqmsc7x22******</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The access control policies of the private gateway over the Internet.</para>
        /// </summary>
        [NameInMap("InternetAclPolicyList")]
        [Validation(Required=false)]
        public List<ListAclPolicyResponseBodyInternetAclPolicyList> InternetAclPolicyList { get; set; }
        public class ListAclPolicyResponseBodyInternetAclPolicyList : TeaModel {
            /// <summary>
            /// <para>The whitelisted IP CIDR blocks in the VPC that can access the private gateway over the Internet.</para>
            /// </summary>
            [NameInMap("AclPolicyList")]
            [Validation(Required=false)]
            public List<ListAclPolicyResponseBodyInternetAclPolicyListAclPolicyList> AclPolicyList { get; set; }
            public class ListAclPolicyResponseBodyInternetAclPolicyListAclPolicyList : TeaModel {
                /// <summary>
                /// <para>The comment on the IP CIDR block in the VPC that can access the private gateway over the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The IP CIDR block in the VPC that can access the private gateway over the Internet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.23.XX.XX/32</para>
                /// </summary>
                [NameInMap("Entry")]
                [Validation(Required=false)]
                public string Entry { get; set; }

            }

        }

        /// <summary>
        /// <para>The access control policies of the private gateway over the internal network.</para>
        /// </summary>
        [NameInMap("IntranetVpcAclPolicyList")]
        [Validation(Required=false)]
        public List<ListAclPolicyResponseBodyIntranetVpcAclPolicyList> IntranetVpcAclPolicyList { get; set; }
        public class ListAclPolicyResponseBodyIntranetVpcAclPolicyList : TeaModel {
            /// <summary>
            /// <para>The whitelisted IP CIDR blocks in the VPC that can access the private gateway over the internal network.</para>
            /// </summary>
            [NameInMap("AclPolicyList")]
            [Validation(Required=false)]
            public List<ListAclPolicyResponseBodyIntranetVpcAclPolicyListAclPolicyList> AclPolicyList { get; set; }
            public class ListAclPolicyResponseBodyIntranetVpcAclPolicyListAclPolicyList : TeaModel {
                /// <summary>
                /// <para>The comment on the IP CIDR block in the VPC that can access the private gateway over the internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test Entry</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The IP CIDR block in the VPC that can access the private gateway over the internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX/24</para>
                /// </summary>
                [NameInMap("Entry")]
                [Validation(Required=false)]
                public string Entry { get; set; }

            }

            /// <summary>
            /// <para>The VPC ID. For more information about how to obtain the VPC ID, see DescribeVpcs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf66uio7md****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
