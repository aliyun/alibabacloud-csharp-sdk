// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeMasterSlaveServerGroupAttributeResponseBody : TeaModel {
        /// <summary>
        /// The time when the CLB instance was created. The time follows the `YYYY-MM-DDThh:mm:ssZ` format.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The ID of the associated CLB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The list of backend servers in the primary/secondary server group.
        /// </summary>
        [NameInMap("MasterSlaveBackendServers")]
        [Validation(Required=false)]
        public DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServers MasterSlaveBackendServers { get; set; }
        public class DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServers : TeaModel {
            [NameInMap("MasterSlaveBackendServer")]
            [Validation(Required=false)]
            public List<DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServersMasterSlaveBackendServer> MasterSlaveBackendServer { get; set; }
            public class DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServersMasterSlaveBackendServer : TeaModel {
                /// <summary>
                /// The description of the primary/secondary server group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The port used by the backend server.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The ID of the ECS instance or ENI.
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// The type of backend server. Valid values: **Master and Slave. Default value: Master.
                /// </summary>
                [NameInMap("ServerType")]
                [Validation(Required=false)]
                public string ServerType { get; set; }

                /// <summary>
                /// The type of the backend server. Valid values:
                /// 
                /// *   **ecs** (default): an Elastic Compute Service (ECS) instance
                /// *   **eni**: an elastic network interface (ENI)
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The weight of the backend server.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// The ID of the primary/secondary server group.
        /// </summary>
        [NameInMap("MasterSlaveServerGroupId")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupId { get; set; }

        /// <summary>
        /// The name of the primary/secondary server group.
        /// </summary>
        [NameInMap("MasterSlaveServerGroupName")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tag list.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeMasterSlaveServerGroupAttributeResponseBodyTags Tags { get; set; }
        public class DescribeMasterSlaveServerGroupAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeMasterSlaveServerGroupAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeMasterSlaveServerGroupAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
