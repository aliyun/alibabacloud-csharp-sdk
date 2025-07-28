// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoSnapshotPolicyAssociationsResponseBody : TeaModel {
        [NameInMap("AutoSnapshotPolicyAssociations")]
        [Validation(Required=false)]
        public DescribeAutoSnapshotPolicyAssociationsResponseBodyAutoSnapshotPolicyAssociations AutoSnapshotPolicyAssociations { get; set; }
        public class DescribeAutoSnapshotPolicyAssociationsResponseBodyAutoSnapshotPolicyAssociations : TeaModel {
            [NameInMap("AutoSnapshotPolicyAssociation")]
            [Validation(Required=false)]
            public List<DescribeAutoSnapshotPolicyAssociationsResponseBodyAutoSnapshotPolicyAssociationsAutoSnapshotPolicyAssociation> AutoSnapshotPolicyAssociation { get; set; }
            public class DescribeAutoSnapshotPolicyAssociationsResponseBodyAutoSnapshotPolicyAssociationsAutoSnapshotPolicyAssociation : TeaModel {
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
