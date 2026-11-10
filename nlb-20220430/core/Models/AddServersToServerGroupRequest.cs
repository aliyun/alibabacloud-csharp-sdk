// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class AddServersToServerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without adding the servers. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the precheck, an error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Network Load Balancer (NLB) instance is deployed. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the server group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-atstuj3rtoptyui****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The list of backend servers.</para>
        /// <remarks>
        /// <para>You can specify up to 200 servers in a single call.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<AddServersToServerGroupRequestServers> Servers { get; set; }
        public class AddServersToServerGroupRequestServers : TeaModel {
            /// <summary>
            /// <para>The description of the server.</para>
            /// <para>The description must be 2 to 256 characters in length, and can contain letters, digits, Chinese characters, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The port used by the backend server. Valid values: <b>0</b> to <b>65535</b>. If you do not specify this parameter, the default value <b>0</b> is used.</para>
            /// <para>If the all-port forwarding feature is enabled for the server group, you do not need to specify a port when you add a backend server. In this case, the default value 0 is used, and NLB forwards traffic to the backend server based on the frontend request port. You can check whether the all-port forwarding feature is enabled by querying the <b>AnyPortEnabled</b> field returned by the <a href="https://help.aliyun.com/document_detail/445895.html">ListServerGroups</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The ID of the backend server.</para>
            /// <list type="bullet">
            /// <item><description><para>If the server group is of the <b>Instance</b> type, this parameter specifies the resource ID of an <b>Ecs</b>, <b>Eni</b>, or <b>Eci</b> resource.</para>
            /// </description></item>
            /// <item><description><para>If the server group is of the <b>Ip</b> type, this parameter specifies an IP address.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The IP address of the server. This parameter is required when the server group is of the <b>Ip</b> type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.6.6</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The backend server type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ecs</b>: an ECS instance.</description></item>
            /// <item><description><b>Eni</b>: an elastic network interface (ENI).</description></item>
            /// <item><description><b>Eci</b>: an Elastic Container Instance (ECI).</description></item>
            /// <item><description><b>Ip</b>: an IP address.</description></item>
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
            /// <para>The weight of the backend server. Valid values: <b>0</b> to <b>100</b>. Default value: <b>100</b>. If the weight is set to <b>0</b>, no requests are forwarded to the backend server.</para>
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
