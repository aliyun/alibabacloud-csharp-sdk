// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CapacityPlanResponseBody : TeaModel {
        /// <summary>
        /// The response of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The extension configuration information.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CapacityPlanResponseBodyResult Result { get; set; }
        public class CapacityPlanResponseBodyResult : TeaModel {
            /// <summary>
            /// The type of the configuration. Set the value to sharedDisk.
            /// 
            /// >  The extendConfigs attribute that may occur when the planned instance type is enhanced (advanced).
            /// </summary>
            [NameInMap("ExtendConfigs")]
            [Validation(Required=false)]
            public List<CapacityPlanResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class CapacityPlanResponseBodyResultExtendConfigs : TeaModel {
                /// <summary>
                /// The size of the disk. Unit: GiB.
                /// </summary>
                [NameInMap("ConfigType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                /// <summary>
                /// The type of the disk. Valid value: CPFS_PREMIUM.
                /// 
                /// >  The extendConfigs attribute that may occur when the planned instance type is enhanced (advanced).
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public long? Disk { get; set; }

                /// <summary>
                /// The version type. Valid values:
                /// 
                /// *   advanced: enhanced edition
                /// *   x-pack: Commercial Edition
                /// *   community: community version
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            /// <summary>
            /// The node information.
            /// </summary>
            [NameInMap("InstanceCategory")]
            [Validation(Required=false)]
            public string InstanceCategory { get; set; }

            /// <summary>
            /// The number of cores.
            /// </summary>
            [NameInMap("NodeConfigurations")]
            [Validation(Required=false)]
            public List<CapacityPlanResponseBodyResultNodeConfigurations> NodeConfigurations { get; set; }
            public class CapacityPlanResponseBodyResultNodeConfigurations : TeaModel {
                /// <summary>
                /// The number of CPUs of the cloud desktop.
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// The size of the disk. Unit: GiB.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public long? Cpu { get; set; }

                /// <summary>
                /// The type of the hard disk. Valid values:
                /// 
                /// *   cloud_essd: enhanced SSD (ESSD)
                /// *   cloud_ssd: standard SSD
                /// *   cloud_efficiency: ultra disk
                /// *   local_ssd: local SSD
                /// *   local_efficiency: local ultra disk
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public long? Disk { get; set; }

                /// <summary>
                /// The memory size of the current node role.
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The type of the node. Supported types are as follows:
                /// 
                /// *   WORKER: data node
                /// *   WORKER_WARM: cold data node
                /// *   MASTER: dedicated master node
                /// *   KIBANA: Kibana node
                /// *   COORDINATING: client node
                /// *   ELASTIC_WORKER: elastic node
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public long? Memory { get; set; }

                /// <summary>
                /// The result calculated based on the capacity planning. No default value is available. The values are as follows:
                /// 
                /// *   true: indicates that the number of data nodes calculated by capacity planning exceeds the threshold of 50.
                /// *   false: The number of data nodes calculated by capacity planning is less than 50.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

            [NameInMap("OversizedCluster")]
            [Validation(Required=false)]
            public bool? OversizedCluster { get; set; }

        }

    }

}
