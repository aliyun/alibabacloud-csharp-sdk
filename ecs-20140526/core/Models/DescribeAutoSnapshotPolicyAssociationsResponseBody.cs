// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoSnapshotPolicyAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The association of automatic snapshot policies.</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicyAssociations")]
        [Validation(Required=false)]
        public DescribeAutoSnapshotPolicyAssociationsResponseBodyAutoSnapshotPolicyAssociations AutoSnapshotPolicyAssociations { get; set; }
        public class DescribeAutoSnapshotPolicyAssociationsResponseBodyAutoSnapshotPolicyAssociations : TeaModel {
            [NameInMap("AutoSnapshotPolicyAssociation")]
            [Validation(Required=false)]
            public List<DescribeAutoSnapshotPolicyAssociationsResponseBodyAutoSnapshotPolicyAssociationsAutoSnapshotPolicyAssociation> AutoSnapshotPolicyAssociation { get; set; }
            public class DescribeAutoSnapshotPolicyAssociationsResponseBodyAutoSnapshotPolicyAssociationsAutoSnapshotPolicyAssociation : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-bp12quk7gqhhuu1f****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>The ID of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned pagination token which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
