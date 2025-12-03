// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetLoadBalancerUDPListenerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network access control list (ACL) that is associated with the listener.</para>
        /// <remarks>
        /// <para> If <b>AclStatus</b> is set to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: yes</description></item>
        /// <item><description><b>off</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// <para>The type of the network ACL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>white</b>: a whitelist. Only requests from the IP addresses or CIDR blocks in the network ACL are forwarded. Whitelists apply to scenarios where you want to allow only specific IP addresses to access an application. Your service may be adversely affected if the whitelist is not properly configured. After a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener.</para>
        /// <para>If you enable a whitelist but do not add an IP address to the ACL, the listener forwards all requests.</para>
        /// </description></item>
        /// <item><description><para><b>black</b>: a blacklist. All requests from the IP addresses or CIDR blocks in the network ACL are denied. Blacklists apply to scenarios where you want to block access from specified IP addresses to an application.</para>
        /// <para>If a blacklist is configured for a listener but no IP address is added to the blacklist, the listener forwards all requests.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If <b>AclStatus</b> is set to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>white</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the listener. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: For a pay-by-data-transfer Internet-facing CLB instance, you can set this parameter to <b>-1</b>. This way, the bandwidth of the listener is unlimited.</description></item>
        /// <item><description><b>1</b> to <b>5120</b>: For a pay-by-bandwidth Internet-facing CLB instance, you can specify the maximum bandwidth of each listener. The sum of bandwidth limits that you set for all listeners cannot exceed the maximum bandwidth of the CLB instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
        /// <para>The name must be 1 to 256 characters in length and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>udp_80</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The port that is used for health checks.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check. If a backend server, such as an Elastic Compute Service (ECS) instance, does not return a health check response within the specified timeout period, the server fails the health check. Unit: seconds.</para>
        /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
        /// <remarks>
        /// <para> If the value of the <b>HealthCheckConnectTimeout</b> parameter is smaller than that of the <b>HealthCheckInterval</b> parameter, the timeout period specified by the <b>HealthCheckConnectTimeout</b> parameter is ignored and the period of time specified by the <b>HealthCheckInterval</b> parameter is used as the timeout period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// <para>The interval at which health checks are performed. Unit: seconds.</para>
        /// <para>Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the health check feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b> (default): yes</description></item>
        /// <item><description><b>off</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HealthCheckSwitch")]
        [Validation(Required=false)]
        public string HealthCheckSwitch { get; set; }

        /// <summary>
        /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it can be declared healthy (from <b>fail</b> to <b>success</b>).</para>
        /// <para>Valid values: <b>1</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The frontend port used by the CLB instance.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1rtfnodmywb43ecu4sf-c****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a primary/secondary server group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: yes</description></item>
        /// <item><description><b>off</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para> You cannot set <b>VserverGroup</b> and <b>MasterSlaveServerGroup</b> both to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("MasterSlaveServerGroup")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroup { get; set; }

        /// <summary>
        /// <para>The ID of the primary/secondary server group.</para>
        /// <remarks>
        /// <para> You cannot specify both VServerGroupId and MasterSlaveServerGroupId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-0bfuc****</para>
        /// </summary>
        [NameInMap("MasterSlaveServerGroupId")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Proxy protocol to pass client IP addresses to backend servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProxyProtocolV2Enabled")]
        [Validation(Required=false)]
        public bool? ProxyProtocolV2Enabled { get; set; }

        /// <summary>
        /// <para>The region ID of the CLB instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>wrr</b>: Backend servers with higher weights receive more requests than those with lower weights.</para>
        /// <para>If two backend servers have the same weight, the backend server that has fewer connections is expected to receive more requests.</para>
        /// </description></item>
        /// <item><description><para><b>rr</b>: Requests are distributed to backend servers in sequence.</para>
        /// </description></item>
        /// <item><description><para><b>sch</b>: specifies consistent hashing that is based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>tch</b>: specifies consistent hashing that is based on the following parameters: source IP address, destination IP address, source port, and destination port. Requests that contain the same preceding information are distributed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>qch</b>: specifies consistent hashing that is based on QUIC connection IDs. Requests that contain the same QUIC connection ID are distributed to the same backend server.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only high-performance CLB instances support <b>sch</b>, <b>tch</b>, and <b>qch</b>.</description></item>
        /// <item><description>You cannot switch the algorithm used by a CLB instance from <b>wrr</b> or <b>rr</b> to consistent hashing or from consistent hashing to weighted round robin or round robin.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from <b>success</b> to <b>fail</b>.</para>
        /// <para>Valid values: <b>1</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a vServer group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: yes</description></item>
        /// <item><description><b>off</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para> You cannot set both <b>VserverGroup</b> and <b>MasterSlaveServerGroup</b> to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("VServerGroup")]
        [Validation(Required=false)]
        public string VServerGroup { get; set; }

        /// <summary>
        /// <para>The ID of the vServer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6****</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// <para>The response string for UDP listener health checks. The string must be 1 to 64 characters in length and can contain only letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("healthCheckExp")]
        [Validation(Required=false)]
        public string HealthCheckExp { get; set; }

        /// <summary>
        /// <para>The request string for UDP listener health checks. The string must be 1 to 64 characters in length and can contain only letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("healthCheckReq")]
        [Validation(Required=false)]
        public string HealthCheckReq { get; set; }

    }

}
