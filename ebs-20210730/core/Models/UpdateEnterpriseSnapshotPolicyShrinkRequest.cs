// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class UpdateEnterpriseSnapshotPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Snapshot replication destination information.
        /// </summary>
        [NameInMap("CrossRegionCopyInfo")]
        [Validation(Required=false)]
        public string CrossRegionCopyInfoShrink { get; set; }

        /// <summary>
        /// The description of the policy.
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// The name of the policy.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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

        /// <summary>
        /// Snapshot retention rule.
        /// </summary>
        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public string RetainRuleShrink { get; set; }

        /// <summary>
        /// The rule for scheduling.
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string ScheduleShrink { get; set; }

        /// <summary>
        /// The special snapshot retention rules.
        /// </summary>
        [NameInMap("SpecialRetainRules")]
        [Validation(Required=false)]
        public string SpecialRetainRulesShrink { get; set; }

        /// <summary>
        /// The status of the policy. Valid values:
        /// 
        /// *   **ENABLED**: Enable snapshot policy execution.
        /// *   **DISABLED**: Disable snapshot policy execution.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// Advanced snapshot features.
        /// </summary>
        [NameInMap("StorageRule")]
        [Validation(Required=false)]
        public string StorageRuleShrink { get; set; }

    }

}
