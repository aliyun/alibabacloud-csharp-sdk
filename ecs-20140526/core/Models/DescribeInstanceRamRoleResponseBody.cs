// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceRamRoleResponseBody : TeaModel {
        /// <summary>
        /// Details about the instance RAM roles.
        /// </summary>
        [NameInMap("InstanceRamRoleSets")]
        [Validation(Required=false)]
        public DescribeInstanceRamRoleResponseBodyInstanceRamRoleSets InstanceRamRoleSets { get; set; }
        public class DescribeInstanceRamRoleResponseBodyInstanceRamRoleSets : TeaModel {
            [NameInMap("InstanceRamRoleSet")]
            [Validation(Required=false)]
            public List<DescribeInstanceRamRoleResponseBodyInstanceRamRoleSetsInstanceRamRoleSet> InstanceRamRoleSet { get; set; }
            public class DescribeInstanceRamRoleResponseBodyInstanceRamRoleSetsInstanceRamRoleSet : TeaModel {
                /// <summary>
                /// The ID of the instance
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the instance RAM role.
                /// </summary>
                [NameInMap("RamRoleName")]
                [Validation(Required=false)]
                public string RamRoleName { get; set; }

            }

        }

        /// <summary>
        /// The region ID of the instance RAM role.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of instance RAM roles returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
