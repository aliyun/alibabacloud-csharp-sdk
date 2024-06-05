// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DeleteAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the automatic snapshot policy.
        /// 
        /// You can call the [DescribeAutoSnapshotPolicies](https://help.aliyun.com/document_detail/126583.html) operation to view available automatic snapshot policies.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AutoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

    }

}
