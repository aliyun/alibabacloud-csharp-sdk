// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteAclPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The whitelist of IP address ranges that are allowed to access the VPC. This parameter is required. If this parameter is not specified, an InvalidParameter error is returned, indicating that AclPolicyList must be set.</para>
        /// </summary>
        [NameInMap("AclPolicyList")]
        [Validation(Required=false)]
        public List<DeleteAclPolicyRequestAclPolicyList> AclPolicyList { get; set; }
        public class DeleteAclPolicyRequestAclPolicyList : TeaModel {
            /// <summary>
            /// <para>The comment for the IP address range that is allowed to access the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The IP address range that is allowed to access the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.23.XX.XX/32</para>
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC. For information about how to obtain the VPC ID, see DescribeVpcs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf66uio7md****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
