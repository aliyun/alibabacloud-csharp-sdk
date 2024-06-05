// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class AddServersToServerGroupRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: prechecks the request, but does not add a backend server to a server group. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The server group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// The backend servers that you want to add to the server group. You can specify up to 40 backend servers in each call.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<AddServersToServerGroupRequestServers> Servers { get; set; }
        public class AddServersToServerGroupRequestServers : TeaModel {
            /// <summary>
            /// The description of the backend server. The description must be 2 to 256 characters in length and can contain letters, digits, periods (.), underscores (_), hyphens (-), commas (,), semicolons (;), forward slashes (/), and at signs (@). You can specify up to 40 servers in each call.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The port used by the backend server. Valid values: **1** to **65535**. You can specify up to 40 server IDs in each call.
            /// 
            /// > This parameter is required if the **ServerType** parameter is set to **Ecs**, **Eni**, **Eci**, or **Ip**. You do not need to set this parameter if **ServerType** is set to **Fc**.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// Specifies whether to enable the remote IP address feature. You can specify up to 40 server IDs in each call. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// Regions that support the remote IP address feature: China (Hangzhou), China (Shenzhen), China (Qingdao), China (Beijing), China (Zhangjiakou), China (Ulanqab), China (Shanghai), China (Chengdu), China (Guangzhou), China (Hong Kong), US (Virginia), Japan (Tokyo), UK (London), US (Silicon Valley), Germany (Frankfurt), Indonesia (Jakarta), Singapore, Malaysia (Kuala Lumpur), Australia (Sydney), and India (Mumbai).
            /// 
            /// > If **ServerType** is set to **Ip**, this parameter is available.
            /// </summary>
            [NameInMap("RemoteIpEnabled")]
            [Validation(Required=false)]
            public bool? RemoteIpEnabled { get; set; }

            /// <summary>
            /// The backend server ID. You can specify up to 40 server IDs in each call.
            /// 
            /// *   If ServerType is set to **Instance**, set the ServerId parameter to the ID of an Elastic Compute Service (ECS) instance, an elastic network interface (ENI), or an elastic container instance. These backend servers are specified by **Ecs**, **Eni**, or **Eci**.
            /// *   If ServerType is set to **Ip**, set the ServerId parameter to an IP address specified in the server group.
            /// *   If the backend server group is of the **Fc** type, set this parameter to the Alibaba Cloud Resource Name (ARN) of a function.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// The IP address in inclusive ENI mode. You can specify up to 40 server IDs in each call.
            /// 
            /// > You do not need to set this parameter if **ServerType** is set to **Fc**.
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// The type of the backend server that you want to add to the server group. You can specify up to 40 server IDs in each call. Valid values:
            /// 
            /// *   **Ecs**
            /// *   **Eni**
            /// *   **Eci**
            /// *   **Ip**
            /// *   **fc**
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// The weight of the backend server. Valid values: **0** to **100**. Default value: **100**. If the weight of a backend server is set to **0**, no requests are forwarded to the backend server. You can specify up to 40 server IDs in each call.
            /// 
            /// > You do not need to set this parameter if **ServerType** is set to **Fc**.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

    }

}
