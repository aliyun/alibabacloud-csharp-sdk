// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGsResponseBody : TeaModel {
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
        public List<DescribeSDGsResponseBodySDGs> SDGs { get; set; }
        public class DescribeSDGsResponseBodySDGs : TeaModel {
            /// <summary>
            /// The IDs of available edge nodes.
            /// </summary>
            [NameInMap("AvaliableRegionIds")]
            [Validation(Required=false)]
            public List<DescribeSDGsResponseBodySDGsAvaliableRegionIds> AvaliableRegionIds { get; set; }
            public class DescribeSDGsResponseBodySDGsAvaliableRegionIds : TeaModel {
                /// <summary>
                /// The time when the SDG was created on the node.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the edge node.
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
            /// The time when the SDG was first created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The deployment information.
            /// </summary>
            [NameInMap("DeployedInstanceIds")]
            [Validation(Required=false)]
            public List<DescribeSDGsResponseBodySDGsDeployedInstanceIds> DeployedInstanceIds { get; set; }
            public class DescribeSDGsResponseBodySDGsDeployedInstanceIds : TeaModel {
                /// <summary>
                /// The time when the SDG was deployed on the instance.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The deployment type of the SDG. Valid values:
                /// 
                /// *   common: common deployment.
                /// *   overlay: read/write splitting deployment.
                /// </summary>
                [NameInMap("DeploymentType")]
                [Validation(Required=false)]
                public string DeploymentType { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The deployment status. Valid values:
                /// 
                /// *   **sdg_deploying**
                /// *   **failed**
                /// *   **success**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

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

    }

}
