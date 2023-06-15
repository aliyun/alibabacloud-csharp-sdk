// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeGadInstancesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details about the global active database clusters that are returned.
        /// </summary>
        [NameInMap("GadInstances")]
        [Validation(Required=false)]
        public List<DescribeGadInstancesResponseBodyGadInstances> GadInstances { get; set; }
        public class DescribeGadInstancesResponseBodyGadInstances : TeaModel {
            /// <summary>
            /// The time when the global active database cluster was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The name of the global active database cluster.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// An array that consists of the details about the nodes in the global active database cluster.
            /// </summary>
            [NameInMap("GadInstanceMembers")]
            [Validation(Required=false)]
            public List<DescribeGadInstancesResponseBodyGadInstancesGadInstanceMembers> GadInstanceMembers { get; set; }
            public class DescribeGadInstancesResponseBodyGadInstancesGadInstanceMembers : TeaModel {
                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("DBInstanceID")]
                [Validation(Required=false)]
                public string DBInstanceID { get; set; }

                /// <summary>
                /// A JSON array that consists of the details about the Data Transmission Service (DTS) synchronization task.
                /// 
                /// >  Each unit node uses DTS to synchronize data with the central node. This parameter contains the ID of the DTS synchronization link and the ID of the DTS synchronization request.
                /// </summary>
                [NameInMap("DtsInstance")]
                [Validation(Required=false)]
                public string DtsInstance { get; set; }

                /// <summary>
                /// The database engine that is run by the node.
                /// 
                /// >  The value of this parameter is fixed as **mysql**.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The database engine version that is run by the node.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The ID of the region where the node resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The type of the node. Valid values:
                /// 
                /// *   **CENTRAL**: The node is the central node. Each global active database cluster has only one central node. All unit nodes synchronize data from the central node.
                /// *   **UNIT**: The node is a unit node. Each global active database cluster can have up to 10 unit nodes. All unit nodes synchronize data from the central node.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The status of the node. Valid values:
                /// 
                /// *   **activation**: The node is running.
                /// *   **creating**: The node is being created.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The ID of the global active database cluster.
            /// </summary>
            [NameInMap("GadInstanceName")]
            [Validation(Required=false)]
            public string GadInstanceName { get; set; }

            /// <summary>
            /// The time when the most recent modification was made to the global active database cluster. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// The database engine that is run by the global active database cluster.
            /// 
            /// >  The value of this parameter is fixed as **mysql**.
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// The status of the global active database cluster. Valid values:
            /// 
            /// *   **activation**: The global active database cluster is running.
            /// *   **creating**: The global active database cluster is being created.
            /// *   **replica_adding**: Nodes are being added to the global active database cluster.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
