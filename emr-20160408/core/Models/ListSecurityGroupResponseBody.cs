// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListSecurityGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroupList")]
        [Validation(Required=false)]
        public ListSecurityGroupResponseBodySecurityGroupList SecurityGroupList { get; set; }
        public class ListSecurityGroupResponseBodySecurityGroupList : TeaModel {
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public List<ListSecurityGroupResponseBodySecurityGroupListSecurityGroup> SecurityGroup { get; set; }
            public class ListSecurityGroupResponseBodySecurityGroupListSecurityGroup : TeaModel {
                public int? AvailableInstanceAmount { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public int? EcsCount { get; set; }
                public string SecurityGroupId { get; set; }
                public string SecurityGroupName { get; set; }
                public string SecurityGroupType { get; set; }
                public string VpcId { get; set; }
            }
        };

    }

}
