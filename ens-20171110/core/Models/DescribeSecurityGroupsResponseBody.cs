// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecurityGroupsResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about security groups.
        /// </summary>
        [NameInMap("SecurityGroups")]
        [Validation(Required=false)]
        public DescribeSecurityGroupsResponseBodySecurityGroups SecurityGroups { get; set; }
        public class DescribeSecurityGroupsResponseBodySecurityGroups : TeaModel {
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroup> SecurityGroup { get; set; }
            public class DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroup : TeaModel {
                /// <summary>
                /// The time when the security group was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC. The format is yyyy-MM-ddThh:mmZ.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the security group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The number of associated instances.
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                /// <summary>
                /// The ID of the security group.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The name of the security group.
                /// </summary>
                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

            }

        }

        /// <summary>
        /// The total number of returned pages.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
