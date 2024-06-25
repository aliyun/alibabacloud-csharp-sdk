// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class RemoveServersFromServerGroupRequest : TeaModel {
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
        /// Specifies whether to perform a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The region ID of the NLB instance.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/443657.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The server group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// The backend servers that you want to add to the server group. You can specify up to 40 servers in each call.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<RemoveServersFromServerGroupRequestServers> Servers { get; set; }
        public class RemoveServersFromServerGroupRequestServers : TeaModel {
            /// <summary>
            /// The port that is used by the backend server. Valid values: **1** to **65535**.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The backend server ID.
            /// 
            /// *   If the server group type is **Instance**, set this parameter to the ID of an Elastic Compute Service (ECS) instance, an elastic network interface (ENI), or an elastic container instance. The backend servers are specified by **Ecs**, **Eni**, or **Eci**.
            /// *   If the server group type is **Ip**, set this parameter to an IP address.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// The IP address of the backend server. If the server group type is **Ip**, you must specify an IP address.
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// The type of the backend server. Valid values:
            /// 
            /// *   **Ecs**: ECS instance
            /// *   **Eni**: ENI
            /// *   **Eci**: elastic container instance
            /// *   **Ip**: IP address
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

        }

    }

}
