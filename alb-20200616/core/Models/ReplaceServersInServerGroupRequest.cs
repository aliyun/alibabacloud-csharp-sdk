// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ReplaceServersInServerGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AddedServers")]
        [Validation(Required=false)]
        public List<ReplaceServersInServerGroupRequestAddedServers> AddedServers { get; set; }
        public class ReplaceServersInServerGroupRequestAddedServers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs-123</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>593B0448-D13E-4C56-AC0D-FDF0FDE0E9A3</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a <c>2xx</c> HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The backend servers that you want to remove.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RemovedServers")]
        [Validation(Required=false)]
        public List<ReplaceServersInServerGroupRequestRemovedServers> RemovedServers { get; set; }
        public class ReplaceServersInServerGroupRequestRemovedServers : TeaModel {
            /// <summary>
            /// <para>The port that is used by the backend server. Valid values: <b>1</b> to <b>65535</b>. You can specify at most 200 servers in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The ID of the backend server. You can specify at most 200 servers in each call.</para>
            /// <list type="bullet">
            /// <item><description>If the server group is of the <b>Instance</b> type, set ServerId to the ID of a resource of the <b>Ecs</b>, <b>Eni</b>, or <b>Eci</b> type.</description></item>
            /// <item><description>If the server group is of the <b>Ip</b> type, set ServerId to IP addresses.</description></item>
            /// </list>
            /// <remarks>
            /// <para> You cannot perform this operation on a server group of the Function Compute type. You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the type of server groups.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-bp1ac9uozods2uc****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The IP address of the ENI in exclusive mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.12</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The type of backend server. You can specify at most 200 servers in each call. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ecs</b>: ECS instance</description></item>
            /// <item><description><b>Eni</b>: ENI</description></item>
            /// <item><description><b>Eci</b>: elastic container instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the server group.</para>
        /// <remarks>
        /// <para>You cannot perform this operation on a server group of the Function type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-5114d593o96qxy****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

    }

}
