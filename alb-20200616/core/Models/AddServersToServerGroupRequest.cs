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
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
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
        /// <item><description><b>true</b>: performs a dry run without adding backend servers to the server group. The system checks the required parameters, request format, and service limits. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check succeeds, an HTTP 2xx status code is returned and the operation is performed.</description></item>
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
        /// <para>The list of backend servers. You can add up to 200 servers in a single call.</para>
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
            /// <para>The port used by the backend server. Valid values: <b>1</b> to <b>65535</b>. You can add up to 200 servers in a single call.</para>
            /// <remarks>
            /// <para>This parameter is required when <b>ServerType</b> is set to <b>Ecs</b>, <b>Eni</b>, <b>Eci</b>, or <b>Ip</b>. This parameter is not required when <b>ServerType</b> is set to <b>Fc</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the remote IP feature. You can add up to 200 servers in a single call. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>ServerType</b> is set to <b>Ip</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RemoteIpEnabled")]
            [Validation(Required=false)]
            public bool? RemoteIpEnabled { get; set; }

            /// <summary>
            /// <para>The backend server ID. You can add up to 200 servers in a single call.</para>
            /// <list type="bullet">
            /// <item><description><para>If the server group is of the <b>Instance</b> type, this parameter specifies the resource ID of an <b>Ecs</b>, <b>Eni</b>, or <b>Eci</b> instance.</para>
            /// </description></item>
            /// <item><description><para>If the server group is of the <b>Ip</b> type, this parameter specifies an IP address.</para>
            /// </description></item>
            /// <item><description><para>If the server group is of the <b>Fc</b> type, this parameter specifies the Alibaba Cloud Resource Name (ARN) of a Function Compute function.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>i-uf616vu8me******</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The IP address. You can add up to 200 servers in a single call.</para>
            /// <para>When <b>ServerType</b> is set to <b>Eni</b>, you can specify the primary private IP address or a secondary private IP address of the ENI.</para>
            /// <remarks>
            /// <para>This parameter is not required when <b>ServerType</b> is set to <b>Fc</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The server type of the backend server. You can add up to 200 servers in a single invoke. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ecs</b>: ECS instance.</description></item>
            /// <item><description><b>Eni</b>: ENI network interface controller (NIC) instance.</description></item>
            /// <item><description><b>Eci</b>: ECI elastic container instance.</description></item>
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
            /// <para>The weight of the backend server. Valid values: <b>0</b> to <b>100</b>. Default value: <b>100</b>. If the weight is set to <b>0</b>, no requests are forwarded to the backend server. You can add up to 200 servers in a single call.</para>
            /// <remarks>
            /// <para>This parameter is not required when <b>ServerType</b> is set to <b>Fc</b>.</para>
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
