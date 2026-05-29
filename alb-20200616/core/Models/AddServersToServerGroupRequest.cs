// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class AddServersToServerGroupRequest : TeaModel {
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
        /// <item><description><b>true</b>: prechecks the request, but does not add a backend server to a server group. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The server group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The backend servers. You can specify at most 200 servers in each call.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<AddServersToServerGroupRequestServers> Servers { get; set; }
        public class AddServersToServerGroupRequestServers : TeaModel {
            /// <summary>
            /// <para>The description of the backend server. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The port that is used by the backend server. Valid values: <b>1</b> to <b>65535</b>. You can specify at most 200 servers in each call.</para>
            /// <remarks>
            /// <para> This parameter is required if you set <b>ServerType</b> to <b>Ecs</b>, <b>Eni</b>, <b>Eci</b>, or <b>Ip</b>. You do not need to set this parameter if <b>ServerType</b> is set to <b>Fc</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the remote IP feature. You can specify at most 200 servers in each call. Default values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enables the feature.</description></item>
            /// <item><description><b>false</b>: disables the feature.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect only when <b>ServerType</b> is set to <b>Ip</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RemoteIpEnabled")]
            [Validation(Required=false)]
            public bool? RemoteIpEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the server group. You can specify at most 200 servers in each call.</para>
            /// <list type="bullet">
            /// <item><description>If the server group is of the <b>Instance</b> type, set ServerId to the ID of a resource of the <b>Ecs</b>, <b>Eni</b>, or <b>Eci</b> type.</description></item>
            /// <item><description>If the server group is of the <b>Ip</b> type, set this parameter to IP addresses.</description></item>
            /// <item><description>If the server group is of the <b>Fc</b> type, set ServerId to an Alibaba Cloud Resource Name (ARN).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The IP address of the backend server. You can specify at most 200 servers in each call.</para>
            /// <remarks>
            /// <para> You do not need to set this parameter if you set <b>ServerType</b> to <b>Fc</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The type of the backend server. You can specify at most 200 servers in each call. Default values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ecs</b>: Elastic Compute Service (ECS) instance</description></item>
            /// <item><description><b>Eni</b>: elastic network interface (ENI)</description></item>
            /// <item><description><b>Eci</b>: elastic container instance</description></item>
            /// <item><description><b>Ip</b>: IP address</description></item>
            /// <item><description><b>Fc</b>: Function Compute</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <para>The weight of the backend server. Valid values: <b>0</b> to <b>100</b>. Default value: <b>100</b>. If the value is set to <b>0</b>, no requests are forwarded to the server. You can specify at most 200 servers in each call.</para>
            /// <remarks>
            /// <para> You do not need to set this parameter if you set <b>ServerType</b> to <b>Fc</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

    }

}
