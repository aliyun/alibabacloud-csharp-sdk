// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
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
        /// The information about the SDGs.
        /// </summary>
        [NameInMap("SDGs")]
        [Validation(Required=false)]
        public List<DescribeSDGResponseBodySDGs> SDGs { get; set; }
        public class DescribeSDGResponseBodySDGs : TeaModel {
            /// <summary>
            /// SDGs that have snapshots.
            /// </summary>
            [NameInMap("AvaliableRegionIds")]
            [Validation(Required=false)]
            public List<DescribeSDGResponseBodySDGsAvaliableRegionIds> AvaliableRegionIds { get; set; }
            public class DescribeSDGResponseBodySDGsAvaliableRegionIds : TeaModel {
                /// <summary>
                /// The time when the SDG was created on the node.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the snapshot.
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                /// <summary>
                /// The status of the SDG on the node. Valid values:
                /// 
                /// *   **sdg_making**
                /// *   **sdg_saving**
                /// *   **sdg_copying**
                /// *   **failed**
                /// *   **success**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The ID of the instance on which the SDG is created.
            /// </summary>
            [NameInMap("CreationInstanceId")]
            [Validation(Required=false)]
            public string CreationInstanceId { get; set; }

            /// <summary>
            /// The ID of the node on which the SDG is created.
            /// </summary>
            [NameInMap("CreationRegionId")]
            [Validation(Required=false)]
            public string CreationRegionId { get; set; }

            /// <summary>
            /// The time when the first SDG in the node was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the SDG.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the source SDG from which you want to create an SDG. The value of this parameter is the value of the **FromSDGId** parameter that you need to specify when you call the [CreateSDG](https://help.aliyun.com/document_detail/608128.html) operation.
            /// </summary>
            [NameInMap("ParentSDGId")]
            [Validation(Required=false)]
            public string ParentSDGId { get; set; }

            /// <summary>
            /// The preload information.
            /// </summary>
            [NameInMap("PreloadInfos")]
            [Validation(Required=false)]
            public List<DescribeSDGResponseBodySDGsPreloadInfos> PreloadInfos { get; set; }
            public class DescribeSDGResponseBodySDGsPreloadInfos : TeaModel {
                /// <summary>
                /// The time when the SDG was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The namespace.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The number of redundant replicas to quickly respond to shared mounts.
                /// </summary>
                [NameInMap("RedundantNum")]
                [Validation(Required=false)]
                public int? RedundantNum { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The time when the status was last updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// The ID of the SDG.
            /// </summary>
            [NameInMap("SDGId")]
            [Validation(Required=false)]
            public string SDGId { get; set; }

            /// <summary>
            /// The size of the SDG. Unit: GB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The status of the SDG creation. Valid values:
            /// 
            /// *   **sdg_making**
            /// *   **sdg_saving**
            /// *   **failed**
            /// *   **success**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the SDG was last updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
