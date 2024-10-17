// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried permission groups.</para>
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
                /// <para>The name of the permission group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT_VPC_GROUP_NAME</para>
                /// </summary>
                [NameInMap("AccessGroupName")]
                [Validation(Required=false)]
                public string AccessGroupName { get; set; }

                /// <summary>
                /// <para>The network type of the permission group. Valid value: <b>Vpc</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Vpc</para>
                /// </summary>
                [NameInMap("AccessGroupType")]
                [Validation(Required=false)]
                public string AccessGroupType { get; set; }

                /// <summary>
                /// <para>The time when the permission group was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-05T16:00:00Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the permission group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a test access group.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The type of the file system.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard: General-purpose Apsara File Storage NAS (NAS) file system</description></item>
                /// <item><description>extreme: Extreme NAS file system</description></item>
                /// <item><description>cpfs: Cloud Parallel File Storage (CPFS) file system</description></item>
                /// </list>
                /// <remarks>
                /// <para> CPFS file systems are available only on the China site (aliyun.com).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// <para>The number of mount targets to which the permission group is attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MountTargetCount")]
                [Validation(Required=false)]
                public int? MountTargetCount { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The total number of rules in the permission group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
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
