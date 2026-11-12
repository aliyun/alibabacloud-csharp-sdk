// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteAclPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The whitelist of IP address ranges that are allowed to access the VPC. This parameter is required. If this parameter is not specified, an InvalidParameter error is returned, indicating that AclPolicyList must be set.</para>
        /// </summary>
        [NameInMap("AclPolicyList")]
        [Validation(Required=false)]
        public string AclPolicyListShrink { get; set; }

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
