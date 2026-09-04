// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateServerGroupServersAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>593B0448-D13E-4C56-AC0D-FDF0******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request format, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a Normal request, passes the dry run, and returns an HTTP 2xx status code. The operation to update the weight and description of the backend server in the server group is directly performed.</description></item>
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
        /// <para>The backend server group list. You can specify up to 40 servers in a single invoke.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<UpdateServerGroupServersAttributeRequestServers> Servers { get; set; }
        public class UpdateServerGroupServersAttributeRequestServers : TeaModel {
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
            /// <para>The port used by the backend server. Valid values: <b>1</b> to <b>65535</b>.</para>
            /// <remarks>
            /// <para>This parameter does not take effect when <b>ServerType</b> is set to <b>Fc</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The backend server ID.</para>
            /// <list type="bullet">
            /// <item><description>If <b>ServerType</b> is set to <b>Ecs</b>, <b>Eni</b>, or <b>Eci</b>, this parameter specifies the resource ID of the ECS instance, ENI, or ECI.</description></item>
            /// <item><description>If <b>ServerType</b> is set to <b>Ip</b>, this parameter specifies the IP address.</description></item>
            /// <item><description>If <b>ServerType</b> is set to <b>Fc</b>, this parameter specifies the ARN of the function.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1f9kdprbgy9uiu****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The server type of the backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ecs</b>: ECS instance.</description></item>
            /// <item><description><b>Eni</b>: network interface controller (NIC).</description></item>
            /// <item><description><b>Eci</b>: elastic container instance.</description></item>
            /// <item><description><b>Ip</b>: IP address.</description></item>
            /// <item><description><b>Fc</b>: Function Compute.</description></item>
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
            /// <para>The weight of the backend server. Valid values: <b>0</b> to <b>100</b>. Default value: <b>100</b>. If the weight is set to <b>0</b>, no requests are forwarded to the backend server. You can specify up to 40 servers in a single request.</para>
            /// <remarks>
            /// <para>This parameter does not take effect when <b>ServerType</b> is set to <b>Fc</b>.</para>
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
