// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateVServerGroupRequest : TeaModel {
        /// <summary>
        /// The list of backend servers to be added.
        /// 
        /// The value of this parameter must be a STRING list in the JSON format. You can specify up to 20 elements in each request.
        /// 
        /// *   **ServerId**: Required. Specify the ID of an Elastic Compute Service (ECS) instance or an Elastic Network Interface (ENI). This parameter must be of the STRING type.
        /// 
        /// *   **Port**: Required. Specify the port that is used by the backend server. This parameter must be of the INTEGER type. Valid values: **1** to **65535**.
        /// 
        /// *   **Weight**: Required. Specify the weight of the backend server. This parameter must be of the INTEGER type. Valid values: **0** to **100**.
        /// 
        /// *   **Description**: Optional. Specify the description of the backend server. This parameter must be of the STRING type. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.),and underscores (\_).
        /// 
        /// *   **Type**: Specify the type of the backend server. This parameter must be of the STRING type. Valid values:
        /// 
        ///     *   **ecs**: an ECS instance. This is the default value.
        ///     *   **eni**: an ENI.
        /// 
        /// *   **ServerIp**: The IP address of the ECS instance or ENI.
        /// 
        /// Examples:
        /// 
        /// *   ECS instance:`  [{ "ServerId": "i-xxxxxxxxx", "Weight": "100", "Type": "ecs", "Port": "80", "Description": "test-112" }]. `
        /// *   ENI:`  [{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.**.**", "Port":"80","Description":"test-112" }] `
        /// *   ENI with multiple IP addresses:`  [{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.**.**", "Port":"80","Description":"test-112" },{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "172.166.**.**", "Port":"80","Description":"test-113" }] `
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServers { get; set; }

        /// <summary>
        /// The ID of the Server Load Balancer (SLB) instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the SLB instance is deployed.
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
        public List<CreateVServerGroupRequestTag> Tag { get; set; }
        public class CreateVServerGroupRequestTag : TeaModel {
            /// <summary>
            /// 资源的标签键。N的取值范围：**1~20**。一旦输入该值，则不允许为空字符串。
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

        /// <summary>
        /// The name of the vServer group.
        /// 
        /// The name must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.),and underscores (\_).
        /// </summary>
        [NameInMap("VServerGroupName")]
        [Validation(Required=false)]
        public string VServerGroupName { get; set; }

    }

}
