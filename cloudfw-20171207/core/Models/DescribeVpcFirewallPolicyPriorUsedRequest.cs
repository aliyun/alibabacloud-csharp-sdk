// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallPolicyPriorUsedRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response.
        /// 
        /// Valid values:
        /// 
        /// *   **zh** (default)
        /// *   **en**
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the access control policy group. You can call the [DescribeVpcFirewallAclGroupList](https://help.aliyun.com/document_detail/159760.html) operation to query the ID.
        /// 
        /// *   If the VPC firewall is used to protect a Cloud Enterprise Network (CEN) instance, the value of this parameter is the ID of the CEN instance.
        /// 
        ///     Example: cen-ervw0g12b5jbw\\*\\*\\*\\*.
        /// 
        /// *   If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter is the ID of the VPC firewall.
        /// 
        ///     Example: vfw-a42bbb7b887148c9\\*\\*\\*\\*.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
