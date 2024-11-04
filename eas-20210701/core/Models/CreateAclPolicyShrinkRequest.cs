// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateAclPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The whitelisted IP CIDR blocks in the VPC that can access the private gateway.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AclPolicyList")]
        [Validation(Required=false)]
        public string AclPolicyListShrink { get; set; }

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
