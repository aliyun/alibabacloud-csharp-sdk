// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeDisksRequestFilter> Filter { get; set; }
        public class DescribeDisksRequestFilter : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        [NameInMap("Portable")]
        [Validation(Required=false)]
        public bool? Portable { get; set; }

        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        [NameInMap("DeleteAutoSnapshot")]
        [Validation(Required=false)]
        public bool? DeleteAutoSnapshot { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        [NameInMap("AutoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        [NameInMap("EnableAutoSnapshot")]
        [Validation(Required=false)]
        public bool? EnableAutoSnapshot { get; set; }

        [NameInMap("EnableAutomatedSnapshotPolicy")]
        [Validation(Required=false)]
        public bool? EnableAutomatedSnapshotPolicy { get; set; }

        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("EnableShared")]
        [Validation(Required=false)]
        public bool? EnableShared { get; set; }

        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        [NameInMap("MultiAttach")]
        [Validation(Required=false)]
        public string MultiAttach { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDisksRequestTag> Tag { get; set; }
        public class DescribeDisksRequestTag : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("AdditionalAttributes")]
        [Validation(Required=false)]
        public List<string> AdditionalAttributes { get; set; }

    }

}
