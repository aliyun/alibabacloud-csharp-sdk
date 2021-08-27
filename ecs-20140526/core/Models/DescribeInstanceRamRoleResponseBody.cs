// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceRamRoleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceRamRoleSets")]
        [Validation(Required=false)]
        public DescribeInstanceRamRoleResponseBodyInstanceRamRoleSets InstanceRamRoleSets { get; set; }
        public class DescribeInstanceRamRoleResponseBodyInstanceRamRoleSets : TeaModel {
            [NameInMap("InstanceRamRoleSet")]
            [Validation(Required=false)]
            public List<DescribeInstanceRamRoleResponseBodyInstanceRamRoleSetsInstanceRamRoleSet> InstanceRamRoleSet { get; set; }
            public class DescribeInstanceRamRoleResponseBodyInstanceRamRoleSetsInstanceRamRoleSet : TeaModel {
                public string RamRoleName { get; set; }
                public string InstanceId { get; set; }
            }
        };

    }

}
