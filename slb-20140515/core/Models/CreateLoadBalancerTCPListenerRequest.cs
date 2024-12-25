// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateLoadBalancerTCPListenerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network ACL that is associated with the listener.</para>
        /// <remarks>
        /// <para> If <b>AclStatus</b> is set to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1323</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: yes</description></item>
        /// <item><description><b>off</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// <para>The type of the ACL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>white</b>: a whitelist. Only requests from the IP addresses or CIDR blocks in the network ACL are forwarded. Whitelists apply to scenarios where you want to allow only specific IP addresses to access an application.</para>
        /// <para>Your service may be adversely affected if the whitelist is not properly configured.</para>
        /// <para>If a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener. If a whitelist is configured but no IP address is added to the whitelist, the listener forwards all requests.</para>
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
        /// <para>black</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The backend port used by the CLB instance.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>If the <b>VServerGroupId</b> parameter is not set, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the listener. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: For a pay-by-data-transfer Internet-facing CLB instance, this value can be set to -1, which specifies unlimited bandwidth.</description></item>
        /// <item><description><b>1</b> to <b>5120</b>: For a pay-by-bandwidth Internet-facing CLB instance, you can specify the maximum bandwidth of each listener. The sum of the maximum bandwidth values that you set for all listeners cannot exceed the maximum bandwidth of the CLB instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
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
        /// <para>The timeout period of connection draining. Unit: seconds.</para>
        /// <para>Valid values: <b>10</b> to <b>900</b>.</para>
        /// <remarks>
        /// <para> This parameter is required if <b>ConnectionDrain</b> is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ConnectionDrainTimeout")]
        [Validation(Required=false)]
        public int? ConnectionDrainTimeout { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
        /// <para>The name must be 1 to 256 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp_80</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The timeout period of a connection. Unit: seconds.</para>
        /// <para>Valid values: <b>10</b> to <b>900</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// <para>The port that is used for health checks.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>If this parameter is not set, the backend port specified by <b>BackendServerPort</b> is used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The maximum timeout period of a health check response. Unit: seconds.</para>
        /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
        /// <para>Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// <para>The domain name that you want to use for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>$_ip</b>: the private IP address of a backend server. If you do not set the HealthCheckDomain parameter or set the parameter to $_ip, the CLB instance uses the private IP address of each backend server for health checks.</description></item>
        /// <item><description><b>domain</b>: The domain name must be 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.6</para>
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// <para>The HTTP status code for a successful health check. Separate multiple HTTP status codes with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>http_2xx</b>(default)</description></item>
        /// <item><description><b>http_3xx</b></description></item>
        /// <item><description><b>http_4xx</b></description></item>
        /// <item><description><b>http_5xx</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http_2xx,http_3xx</para>
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

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
        /// <para>The type of health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b> (default)</description></item>
        /// <item><description><b>http</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// <para>The URI that is used for health checks. The URI must be 1 to 80 characters in length, and can contain only digits, letters, hyphens (-), forward slashes (/), periods (.), percent signs (%), number signs (#), and ampersands (&amp;). The URI must start with a forward slash (/) but cannot be a single forward slash (/).</para>
        /// <para>You can set this parameter when the TCP listener requires HTTP health checks. If you do not set this parameter, TCP health checks are performed.</para>
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
        /// <para>lb-bp1b6c719dfa08ex****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The ID of the primary/secondary server group.</para>
        /// <remarks>
        /// <para> You cannot set both VServerGroupId and MasterSlaveServerGroupId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-0bfucw****</para>
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
        /// <para>The timeout period of session persistence. Unit: seconds.</para>
        /// <para>Valid values: <b>0 to 3600</b>.</para>
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
        /// <para>The ID of the region where the Classic Load Balancer (CLB) instance is deployed.</para>
        /// <para>You can query the region ID from the <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a> list or by calling the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation.</para>
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
        /// <para>The routing algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b> (default): Backend servers with higher weights receive more requests than backend servers with lower weights.</description></item>
        /// <item><description><b>rr</b>: Requests are distributed to backend servers in sequence.</description></item>
        /// <item><description><b>sch</b>: specifies consistent hashing that is based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.</description></item>
        /// <item><description><b>tch</b>: specifies consistent hashing that is based on four factors: source IP address, destination IP address, source port, and destination port. Requests that contain the same information based on the four factors are distributed to the same backend server.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Only high-performance CLB instances support the <b>sch</b> and <b>tch</b> consistent hashing algorithms.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerTCPListenerRequestTag> Tag { get; set; }
        public class CreateLoadBalancerTCPListenerRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key must be 1 to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be at most 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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
        /// <para>The ID of the vServer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6j****</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive health checks. Unit: seconds.</para>
        /// <para>Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("healthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

    }

}
