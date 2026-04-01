// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessGroupsResponseBody : TeaModel {
        [NameInMap("AccessGroups")]
        [Validation(Required=false)]
        public DescribeAccessGroupsResponseBodyAccessGroups AccessGroups { get; set; }
        public class DescribeAccessGroupsResponseBodyAccessGroups : TeaModel {
            [NameInMap("AccessGroup")]
            [Validation(Required=false)]
            public List<DescribeAccessGroupsResponseBodyAccessGroupsAccessGroup> AccessGroup { get; set; }
            public class DescribeAccessGroupsResponseBodyAccessGroupsAccessGroup : TeaModel {
                [NameInMap("AccessGroupName")]
                [Validation(Required=false)]
                public string AccessGroupName { get; set; }

                [NameInMap("AccessGroupType")]
                [Validation(Required=false)]
                public string AccessGroupType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                [NameInMap("MountTargetCount")]
                [Validation(Required=false)]
                public int? MountTargetCount { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RuleCount")]
                [Validation(Required=false)]
                public int? RuleCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of permission groups returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2514F97E-FFF0-4A1F-BF04-729CEAC6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of permission groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
