// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ReplaceServersInServerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The list of backend servers to add. You can specify up to 200 servers in a single request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AddedServers")]
        [Validation(Required=false)]
        public List<ReplaceServersInServerGroupRequestAddedServers> AddedServers { get; set; }
        public class ReplaceServersInServerGroupRequestAddedServers : TeaModel {
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
            /// <para>The port used by the backend server group. Valid values: <b>1</b> to <b>65535</b>. You can specify up to 200 servers in a single request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The backend server ID. You can specify up to 200 servers in a single request.</para>
            /// <list type="bullet">
            /// <item><description><para>If the server group type is <b>Instance</b>, set this parameter to the ID of an <b>Ecs</b>, <b>Eni</b>, or <b>Eci</b> resource.</para>
            /// </description></item>
            /// <item><description><para>If the server group type is <b>Ip</b>, set this parameter to an IP address.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Server groups of the Function Compute type do not support replacing backend servers. You can call <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> to query the server group type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1f9kdprbgy9uiu****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// <para>If <b>ServerType</b> is set to <b>Eni</b>, you can specify the primary private IP address or a secondary private IP address of the ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The backend server type. You can specify up to 200 servers in a single call. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ecs</b>: ECS instance.</description></item>
            /// <item><description><b>Eni</b>: ENI network interface controller (NIC) instance.</description></item>
            /// <item><description><b>Eci</b>: ECI elastic container.</description></item>
            /// <item><description><b>Ip</b>: IP address.</description></item>
            /// <item><description><b>Fc</b>: Function Compute.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <para>The weight of the backend server. You can specify up to 200 servers in a single request.</para>
            /// <para>Valid values: <b>0</b> to <b>100</b>. Default value: <b>100</b>. If the weight is set to <b>0</b>, no requests are forwarded to the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>593B0448-D13E-4C56-AC0D-FDF0FDE0E9A3</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without replacing backend servers in the server group. The system checks the required parameters, request syntax, and business limitations. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check succeeds, an <c>HTTP 2xx</c> status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The backend servers to remove.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RemovedServers")]
        [Validation(Required=false)]
        public List<ReplaceServersInServerGroupRequestRemovedServers> RemovedServers { get; set; }
        public class ReplaceServersInServerGroupRequestRemovedServers : TeaModel {
            /// <summary>
            /// <para>The port used by the backend server. Valid values: <b>1</b> to <b>65535</b>. You can specify up to 200 servers in a single request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The backend server ID. You can specify up to 200 servers in a single request.</para>
            /// <list type="bullet">
            /// <item><description><para>If the server group type is <b>Instance</b>, set this parameter to the ID of an <b>Ecs</b>, <b>Eni</b>, or <b>Eci</b> resource.</para>
            /// </description></item>
            /// <item><description><para>If the server group type is <b>Ip</b>, set this parameter to an IP address.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Server groups of the Function Compute type do not support replacing backend servers. You can call <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> to query the server group type.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1f9kdprbgy9uiu****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// <para>If <b>ServerType</b> is set to <b>Eni</b>, you can specify the primary private IP address or a secondary private IP address of the ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.12</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The backend server type. You can specify up to 200 servers in a single call. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ecs</b>: ECS instance.</description></item>
            /// <item><description><b>Eni</b>: ENI network interface controller (NIC) instance.</description></item>
            /// <item><description><b>Eci</b>: ECI elastic container.</description></item>
            /// <item><description><b>Ip</b>: IP address.</description></item>
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
        /// <para>The server group ID.</para>
        /// <remarks>
        /// <para>Server groups of the Function Compute type do not support replacing backend servers.</para>
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
