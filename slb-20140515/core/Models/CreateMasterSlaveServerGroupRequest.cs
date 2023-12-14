// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateMasterSlaveServerGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The backend servers in the primary/secondary server group.
        /// 
        /// The value of this parameter must be a STRING list in the JSON format. You can specify up to 20 elements in each request.
        /// 
        /// *   **ServerId**: Required. Specify the ID of the backend server. The value must be of the STRING type.
        /// 
        /// *   **Port**: Required. Specify the port that is used by the backend server. The value must be of the INTEGER type. Valid values: **1** to **65535**.
        /// 
        /// *   **Weight**: Required. Specify the weight of the backend server. The value must be of the INTEGER type. Valid values: **0** to **100**.
        /// 
        /// *   \*\*Description \*\*: Optional. The description of the backend server. The value must be of the STRING type. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (\_).
        /// 
        /// *   **ServerType**: the type of the backend server. The value must be of the STRING type. Valid values:
        /// 
        ///     *   **Master**
        /// 
        /// *   **Slave**
        /// 
        /// *   **Type**: the service type of backend server. The value must be of the STRING type. Valid values:
        /// 
        ///     *   **ecs**
        ///     *   **eni**
        /// 
        /// *   **ServerIp**
        /// 
        /// A primary/secondary server group can contain up to two backend servers.
        /// 
        /// If you do not specify this parameter, an empty primary/secondary server group is created.
        /// 
        /// Examples:
        /// 
        /// *   ECS instances:
        /// 
        /// `[{ "ServerId": "i-xxxxxxxxx", "Weight": "100", "Type": "ecs", "Port":"82","ServerType":"Master","Description":"test-112" }, { "ServerId": "i-xxxxxxxxx", "Weight": "100", "Type": "ecs", "Port":"84","ServerType":"Slave","Description":"test-112" }]`
        /// 
        /// *   ENIs:
        /// 
        ///     `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "Port":"80","ServerType":"Master","Description":"test-112" }, { "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.**.**", "Port":"80","ServerType":"Slave","Description":"test-112" }]`
        /// 
        /// *   IP addresses of ENIs:
        /// 
        ///     `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni","ServerIp": "192.168.**.**", "Port":"80","ServerType":"Master","Description":"test-112" }, { "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni","ServerIp": "192.168.**.**", "Port":"80","ServerType":"Slave","Description":"test-112" }]`
        /// </summary>
        [NameInMap("MasterSlaveBackendServers")]
        [Validation(Required=false)]
        public string MasterSlaveBackendServers { get; set; }

        /// <summary>
        /// The name of the primary/secondary server group.
        /// </summary>
        [NameInMap("MasterSlaveServerGroupName")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the Server Load Balancer (SLB) instance is deployed.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateMasterSlaveServerGroupRequestTag> Tag { get; set; }
        public class CreateMasterSlaveServerGroupRequestTag : TeaModel {
            /// <summary>
            /// 资源标签键。N的取值范围：**1**~**20**。一旦输入该值，则不允许为空字符串。
            /// 
            /// 最多支持64个字符，不能以`aliyun`和`acs:`开头，不能包含`http://`或者`https://`。
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 资源的标签值。N的取值范围：**1~20**。一旦输入该值，可以为空字符串。
            /// 最多支持128个字符，不能以`aliyun`和`acs:`开头，不能包含`http://`或者`https://`。
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
