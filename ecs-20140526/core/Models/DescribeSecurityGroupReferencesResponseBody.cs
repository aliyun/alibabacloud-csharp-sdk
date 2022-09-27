// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupReferencesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroupReferences")]
        [Validation(Required=false)]
        public DescribeSecurityGroupReferencesResponseBodySecurityGroupReferences SecurityGroupReferences { get; set; }
        public class DescribeSecurityGroupReferencesResponseBodySecurityGroupReferences : TeaModel {
            [NameInMap("SecurityGroupReference")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReference> SecurityGroupReference { get; set; }
            public class DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReference : TeaModel {
                [NameInMap("ReferencingSecurityGroups")]
                [Validation(Required=false)]
                public DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReferenceReferencingSecurityGroups ReferencingSecurityGroups { get; set; }
                public class DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReferenceReferencingSecurityGroups : TeaModel {
                    [NameInMap("ReferencingSecurityGroup")]
                    [Validation(Required=false)]
                    public List<DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReferenceReferencingSecurityGroupsReferencingSecurityGroup> ReferencingSecurityGroup { get; set; }
                    public class DescribeSecurityGroupReferencesResponseBodySecurityGroupReferencesSecurityGroupReferenceReferencingSecurityGroupsReferencingSecurityGroup : TeaModel {
                        [NameInMap("AliUid")]
                        [Validation(Required=false)]
                        public string AliUid { get; set; }

                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                    }

                }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

        }

    }

}
