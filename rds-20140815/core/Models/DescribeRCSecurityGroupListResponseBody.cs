// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCSecurityGroupListResponseBody : TeaModel {
        [NameInMap("RCSecurityGroups")]
        [Validation(Required=false)]
        public List<DescribeRCSecurityGroupListResponseBodyRCSecurityGroups> RCSecurityGroups { get; set; }
        public class DescribeRCSecurityGroupListResponseBodyRCSecurityGroups : TeaModel {
            [NameInMap("AvailableInstanceAmount")]
            [Validation(Required=false)]
            public int? AvailableInstanceAmount { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("SecurityGroupType")]
            [Validation(Required=false)]
            public string SecurityGroupType { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
