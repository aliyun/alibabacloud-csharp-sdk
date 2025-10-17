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

        /// <summary>
        /// <para>The information about the snapshot chains.</para>
        /// </summary>
        [NameInMap("SnapshotLinks")]
        [Validation(Required=false)]
        public DescribeSnapshotLinksResponseBodySnapshotLinks SnapshotLinks { get; set; }
        public class DescribeSnapshotLinksResponseBodySnapshotLinks : TeaModel {
            [NameInMap("SnapshotLink")]
            [Validation(Required=false)]
            public List<DescribeSnapshotLinksResponseBodySnapshotLinksSnapshotLink> SnapshotLink { get; set; }
            public class DescribeSnapshotLinksResponseBodySnapshotLinksSnapshotLink : TeaModel {
                /// <summary>
                /// <para>The type of the snapshot chain. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard: standard snapshot chain.</description></item>
                /// <item><description>archive: archive snapshot chain.</description></item>
                /// <item><description>flash: instant access snapshot chain.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1h6jmbefj2cyqs****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testInstanceName</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Indicates whether the instant access feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The instant access feature is enabled. The feature can be enabled only for Enterprise SSDs (ESSDs).</description></item>
                /// <item><description>false: The instant access feature is disabled. The snapshot is a standard snapshot for which the instant access feature is disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is no longer used. By default, standard snapshots of ESSDs are upgraded to instant access snapshots free of charge without the need for additional configurations. For more information, see <a href="https://help.aliyun.com/document_detail/193667.html">Use the instant access feature</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InstantAccess")]
                [Validation(Required=false)]
                public bool? InstantAccess { get; set; }

                /// <summary>
                /// <para>The region ID of the source disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot chain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sl-2ze0y1jwzpb1geqx****</para>
                /// </summary>
                [NameInMap("SnapshotLinkId")]
                [Validation(Required=false)]
                public string SnapshotLinkId { get; set; }

                /// <summary>
                /// <para>The ID of the source disk. This parameter is retained even if the source disk is deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp1d6tsvznfghy7y****</para>
                /// </summary>
                [NameInMap("SourceDiskId")]
                [Validation(Required=false)]
                public string SourceDiskId { get; set; }

                /// <summary>
                /// <para>The name of the source disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testSourceDiskName</para>
                /// </summary>
                [NameInMap("SourceDiskName")]
                [Validation(Required=false)]
                public string SourceDiskName { get; set; }

                /// <summary>
                /// <para>The capacity of the source disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("SourceDiskSize")]
                [Validation(Required=false)]
                public int? SourceDiskSize { get; set; }

                /// <summary>
                /// <para>The type of the source disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: system disk</description></item>
                /// <item><description>data: data disk</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>data</para>
                /// </summary>
                [NameInMap("SourceDiskType")]
                [Validation(Required=false)]
                public string SourceDiskType { get; set; }

                /// <summary>
                /// <para>The total number of snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// <para>The total size of all snapshots in the snapshot chain. Unit: byte.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2097152</para>
                /// </summary>
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
