// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeSecurityGroupAttributeResponseBody : TeaModel {
        [NameInMap("AvailableGroupList")]
        [Validation(Required=false)]
        public DescribeSecurityGroupAttributeResponseBodyAvailableGroupList AvailableGroupList { get; set; }
        public class DescribeSecurityGroupAttributeResponseBodyAvailableGroupList : TeaModel {
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupAttributeResponseBodyAvailableGroupListSecurityGroup> SecurityGroup { get; set; }
            public class DescribeSecurityGroupAttributeResponseBodyAvailableGroupListSecurityGroup : TeaModel {
                public int? AvailableInstanceAmount { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public int? EcsCount { get; set; }
                public string SecurityGroupId { get; set; }
                public string SecurityGroupName { get; set; }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroupAttributeList")]
        [Validation(Required=false)]
        public DescribeSecurityGroupAttributeResponseBodySecurityGroupAttributeList SecurityGroupAttributeList { get; set; }
        public class DescribeSecurityGroupAttributeResponseBodySecurityGroupAttributeList : TeaModel {
            [NameInMap("SecurityGroupAttribute")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupAttributeResponseBodySecurityGroupAttributeListSecurityGroupAttribute> SecurityGroupAttribute { get; set; }
            public class DescribeSecurityGroupAttributeResponseBodySecurityGroupAttributeListSecurityGroupAttribute : TeaModel {
                public string BizContent { get; set; }
                public string BizType { get; set; }
            }
        };

    }

}
