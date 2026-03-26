// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotLinksResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotLinks")]
        [Validation(Required=false)]
        public DescribeSnapshotLinksResponseBodySnapshotLinks SnapshotLinks { get; set; }
        public class DescribeSnapshotLinksResponseBodySnapshotLinks : TeaModel {
            [NameInMap("SnapshotLink")]
            [Validation(Required=false)]
            public List<DescribeSnapshotLinksResponseBodySnapshotLinksSnapshotLink> SnapshotLink { get; set; }
            public class DescribeSnapshotLinksResponseBodySnapshotLinksSnapshotLink : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstantAccess")]
                [Validation(Required=false)]
                public bool? InstantAccess { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SnapshotLinkId")]
                [Validation(Required=false)]
                public string SnapshotLinkId { get; set; }

                [NameInMap("SourceDiskId")]
                [Validation(Required=false)]
                public string SourceDiskId { get; set; }

                [NameInMap("SourceDiskName")]
                [Validation(Required=false)]
                public string SourceDiskName { get; set; }

                [NameInMap("SourceDiskSize")]
                [Validation(Required=false)]
                public int? SourceDiskSize { get; set; }

                [NameInMap("SourceDiskType")]
                [Validation(Required=false)]
                public string SourceDiskType { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of snapshot chains.</para>
        /// <remarks>
        /// <para>When using the <c>MaxResults</c> and <c>NextToken</c> parameters for a paginated query, the returned <c>TotalCount</c> parameter value is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
