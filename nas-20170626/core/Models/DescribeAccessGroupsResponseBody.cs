// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessGroupsResponseBody : TeaModel {
        /// <summary>
        /// The queried permission groups.
        /// </summary>
        [NameInMap("AccessGroups")]
        [Validation(Required=false)]
        public DescribeAccessGroupsResponseBodyAccessGroups AccessGroups { get; set; }
        public class DescribeAccessGroupsResponseBodyAccessGroups : TeaModel {
            [NameInMap("AccessGroup")]
            [Validation(Required=false)]
            public List<DescribeAccessGroupsResponseBodyAccessGroupsAccessGroup> AccessGroup { get; set; }
            public class DescribeAccessGroupsResponseBodyAccessGroupsAccessGroup : TeaModel {
                /// <summary>
                /// The name of the permission group.
                /// </summary>
                [NameInMap("AccessGroupName")]
                [Validation(Required=false)]
                public string AccessGroupName { get; set; }

                /// <summary>
                /// The network type of the permission group. Valid value: **Vpc**.
                /// </summary>
                [NameInMap("AccessGroupType")]
                [Validation(Required=false)]
                public string AccessGroupType { get; set; }

                /// <summary>
                /// The time when the permission group was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The description of the permission group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The type of the file system.
                /// 
                /// Valid values:
                /// 
                /// *   standard: General-purpose Apsara File Storage NAS (NAS) file system
                /// *   extreme: Extreme NAS file system
                /// *   cpfs: Cloud Parallel File Storage (CPFS) file system
                /// 
                /// >  CPFS file systems are available only on the China site (aliyun.com).
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// The number of mount targets to which the permission group is attached.
                /// </summary>
                [NameInMap("MountTargetCount")]
                [Validation(Required=false)]
                public int? MountTargetCount { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The total number of rules in the permission group.
                /// </summary>
                [NameInMap("RuleCount")]
                [Validation(Required=false)]
                public int? RuleCount { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of permission groups returned per page.
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
        /// The total number of permission groups.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
