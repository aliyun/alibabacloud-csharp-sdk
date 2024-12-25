// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetLoadBalancerTCPListenerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network access control list (ACL) that is associated with the listener.</para>
        /// <para>If <b>AclStatus</b> is set to <b>on</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12333</para>
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
        /// <item><description><para><b>white</b>: a whitelist. Only requests from the IP addresses or CIDR blocks in the network ACL are forwarded. Whitelists apply to scenarios where you want to allow only specific IP addresses to access an application. Your service may be adversely affected if the allowlist is not properly configured. After a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener.</para>
        /// <para>If you enable a whitelist but do not add an IP address to the ACL, the listener forwards all requests.</para>
        /// </description></item>
        /// <item><description><para><b>black</b>: a blacklist. All requests from the IP addresses or CIDR blocks in the ACL are rejected. Blacklists apply to scenarios where you want to block access from specified IP addresses to an application.</para>
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
        /// <para>The maximum bandwidth of the listener. Unit: Mbit/s. Valid values: <b>-1</b> and <b>1</b> to <b>5120</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: For a pay-by-data-transfer Internet-facing CLB instance, you can set this parameter to <b>-1</b>, which specifies unlimited bandwidth.</description></item>
        /// <item><description><b>1</b> to <b>5120</b>: For a pay-by-bandwidth Internet-facing CLB instance, you can specify the maximum bandwidth of each listener. The sum of the maximum bandwidth values of all listeners cannot exceed the maximum bandwidth of the CLB instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable connection draining. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: yes</description></item>
        /// <item><description><b>off</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ConnectionDrain")]
        [Validation(Required=false)]
        public string ConnectionDrain { get; set; }

        /// <summary>
        /// <para>The timeout period of connection draining. This parameter is required if <b>ConnectionDrain</b> is set to <b>on</b>. Unit: seconds.</para>
        /// <para>Valid values: <b>10</b> to <b>900</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ConnectionDrainTimeout")]
        [Validation(Required=false)]
        public int? ConnectionDrainTimeout { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
        /// <para>The name must be 1 to 256 characters in length and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp_80</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The timeout period of a connection. Unit: seconds. Valid values: <b>10</b> to <b>900</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// <para>The port that is used for health checks. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>If you do not set this parameter, the port specified by the <b>BackendServerPort</b> parameter is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check.</para>
        /// <para>If a backend ECS instance does not return a health check response within the specified timeout period, the server fails the health check.</para>
        /// <para>Valid values: <b>1</b> to <b>300</b>. Unit: seconds.</para>
        /// <remarks>
        /// <para> If the value of the <b>HealthCheckConnectTimeout</b> parameter is smaller than that of the <b>HealthCheckInterval</b> parameter, the timeout period specified by the <b>HCTimeout</b> parameter is ignored and the period of time specified by the <b>HealthCheckInterval</b> parameter is used as the timeout period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// <para>The domain name that is used for health checks. You can set this parameter when the TCP listener requires HTTP health checks. If you do not set this parameter, TCP health checks are performed.</para>
        /// <list type="bullet">
        /// <item><description><para><b>$_ip</b>: the private IP addresses of the backend servers.</para>
        /// <para>If you do not set the HealthCheckHost parameter or set the parameter to $SERVER_IP, the CLB instance uses the private IP addresses of backend servers for health checks.</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: The domain name is 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// <para>The HTTP status code for a successful health check. Separate multiple HTTP status codes with commas (,).</para>
        /// <para>Valid values: <b>http_2xx</b>, <b>http_3xx</b>, <b>http_4xx</b>, and <b>http_5xx</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_2xx</para>
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive health checks. Unit: seconds.</para>
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
        /// <item><description><b>on</b>: yes</description></item>
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
        /// <para>The type of the health check. Valid values: <b>tcp</b> and <b>http</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// <para>The URI that is used for health checks. The URI must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), and ampersands (&amp;). The URI must start with a forward slash (/) but cannot be a single forward slash (/).</para>
        /// <para>You can set this parameter when the TCP listener requires HTTP health checks.</para>
        /// <para>If you do not set this parameter, TCP health checks are performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/index.html</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from <b>fail</b> to <b>success</b>.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
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
        /// <para>lb-bp1ygod3yctvg1y****</para>
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
        /// <para>You cannot set both <b>VserverGroup</b> and <b>MasterSlaveServerGroup</b> to <b>on</b>.</para>
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
        /// <para> You can set only one of the VServerGroupId and MasterSlaveServerGroupId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige****</para>
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
        /// <para>The timeout period of session persistence. Valid values: <b>0</b> to <b>3600</b>. Unit: seconds.</para>
        /// <para>Default value: <b>0</b>. If the default value is used, the system disables session persistence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PersistenceTimeout")]
        [Validation(Required=false)]
        public int? PersistenceTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Proxy protocol to pass client IP addresses to backend servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
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
        /// <para>You can query the region ID from the <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a> list or by calling the <a href="~~DescribeRegions~~">DescribeRegions</a> operation.</para>
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
        /// <item><description><b>wrr</b>: Backend servers that have higher weights receive more requests than backend servers that have lower weights.</description></item>
        /// <item><description><b>rr</b>: Requests are distributed to backend servers in sequence.</description></item>
        /// <item><description><b>sch</b>: specifies consistent hashing that is based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.</description></item>
        /// <item><description><b>tch</b>: specifies consistent hashing that is based on four factors: source IP address, destination IP address, source port, and destination port. Requests that contain the same information based on the four factors are distributed to the same backend server.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Only high-performance CLB instances support the <b>sch</b> and <b>tch</b> algorithms.</description></item>
        /// <item><description>CLB does not support converting the <b>wrr</b> and <b>rr</b> algorithms to sch or tch. You cannot switch the hash algorithm from one to another.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the SynProxy feature of CLB for protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enable</b>: yes</description></item>
        /// <item><description><b>disable</b>: no</description></item>
        /// </list>
        /// <para>We recommend that you use the default value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("SynProxy")]
        [Validation(Required=false)]
        public string SynProxy { get; set; }

        /// <summary>
        /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from <b>success</b> to <b>fail</b>.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
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
        /// <para>rsp-cige6j5****</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
