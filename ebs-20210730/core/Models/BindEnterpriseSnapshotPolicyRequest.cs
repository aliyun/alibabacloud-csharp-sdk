// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class BindEnterpriseSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The list of disks.
        /// </summary>
        [NameInMap("DiskTargets")]
        [Validation(Required=false)]
        public List<string> DiskTargets { get; set; }

        /// <summary>
        /// The id of the policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The region ID . You can call the [DescribeRegions](https://help.aliyun.com/document_detail/354276.html) operation to query the most recent list of regions in which snapshot policy is supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
