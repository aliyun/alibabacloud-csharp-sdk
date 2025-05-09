// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class AddServersToServerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token. Ensure that the token is unique among different requests. Only ASCII characters are allowed.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the value of <b>RequestId</b> is used.**** The value of <b>RequestId</b> is different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: validates the request without performing the operation. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the validation, the corresponding error message is returned. If the request passes the validation, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): validates the request and performs the operation. If the request passes the validation, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the region where the NLB instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The server group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-atstuj3rtoptyui****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The backend servers that you want to add.</para>
        /// <remarks>
        /// <para> You can add up to 200 backend servers in each call.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<AddServersToServerGroupRequestServers> Servers { get; set; }
        public class AddServersToServerGroupRequestServers : TeaModel {
            /// <summary>
            /// <para>The description of the backend server.</para>
            /// <para>The description must be 2 to 256 characters in length, and can contain letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at sings (@), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The port that is used by the backend server to provide services. Valid values: <b>0 to 65535</b>. If you do not set this parameter, the default value <b>0</b> is used.</para>
            /// <para>If multi-port forwarding is enabled, you do not need to set this parameter. The default value 0 is used. NLB forwards requests to the requested ports. To determine whether multi-port forwarding is enabled, call the <a href="https://help.aliyun.com/document_detail/445895.html">ListServerGroups</a> operation and check the value of the <b>AnyPortEnabled</b> parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The backend server ID.</para>
            /// <list type="bullet">
            /// <item><description>If the server group is of the <b>Instance</b> type, set this parameter to the IDs of <b>Elastic Compute Service (ECS) instances</b>, <b>elastic network interfaces (ENIs)</b>, or <b>elastic container instances</b>.</description></item>
            /// <item><description>If the server group is of the <b>Ip</b> type, set ServerId to IP addresses.</description></item>
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
            /// <para>The IP address of the backend server. If the server group type is <b>Ip</b>, set the ServerId parameter to IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.6.6</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The type of the backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ecs</b>: the ECS instance</description></item>
            /// <item><description><b>Eni</b>: the ENI</description></item>
            /// <item><description><b>Eci</b>: the elastic container instance</description></item>
            /// <item><description><b>Ip</b>: the IP address</description></item>
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
            /// <para>The weight of the backend server. Valid values: <b>0</b> to <b>100</b>. Default value: <b>100</b>. If this parameter is set to <b>0</b>, no requests are forwarded to the server.</para>
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
