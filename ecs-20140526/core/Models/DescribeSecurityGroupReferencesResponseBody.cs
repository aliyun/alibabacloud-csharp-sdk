// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupReferencesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about the references to the specified security groups.
        /// </summary>
        [NameInMap("SecurityGroupReferences")]
        [Validation(Required=false)]
        public DescribeSecurityGroupReferencesResponseBodySecurityGroupReferences SecurityGroupReferences { get; set; }
        public class DescribeSecurityGroupReferencesResponseBodySecurityGroupReferences : TeaModel {
            [NameInMap("SecurityGroupReference")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReference> SecurityGroupReference { get; set; }
            public class DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReference : TeaModel {
                /// <summary>
                /// Details about the security groups whose rules are referencing the specified security groups.
                /// </summary>
                [NameInMap("ReferencingSecurityGroups")]
                [Validation(Required=false)]
                public DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReferenceReferencingSecurityGroups ReferencingSecurityGroups { get; set; }
                public class DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReferenceReferencingSecurityGroups : TeaModel {
                    [NameInMap("ReferencingSecurityGroup")]
                    [Validation(Required=false)]
                    public List<DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReferenceReferencingSecurityGroupsReferencingSecurityGroup> ReferencingSecurityGroup { get; set; }
                    public class DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReferenceReferencingSecurityGroupsReferencingSecurityGroup : TeaModel {
                        /// <summary>
                        /// The ID of the Alibaba Cloud account to which the security group belongs.
                        /// </summary>
                        [NameInMap("AliUid")]
                        [Validation(Required=false)]
                        public string AliUid { get; set; }

                        /// <summary>
                        /// The ID of the security group.
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the specified security group.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

        }

    }

}
