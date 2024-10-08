// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateAclPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The whitelisted IP CIDR blocks in the VPC that can access the private gateway.</para>
        /// </summary>
        [NameInMap("AclPolicyList")]
        [Validation(Required=false)]
        public List<CreateAclPolicyRequestAclPolicyList> AclPolicyList { get; set; }
        public class CreateAclPolicyRequestAclPolicyList : TeaModel {
            /// <summary>
            /// <para>The comment on the IP CIDR block in the VPC that can access the private gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The IP CIDR block in the VPC that can access the private gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.23.XX.XX/32</para>
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). For more information about how to obtain the VPC ID, see DescribeVpcs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf66uio7md****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
