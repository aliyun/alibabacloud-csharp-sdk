// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateLoadBalancerHTTPListenerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network access control list (ACL) that is associated with the listener.</para>
        /// <remarks>
        /// <para> If <b>AclStatus</b> is set to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
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
        /// <para>The type of access control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>white</b>: Only requests from IP addresses and CIDR blocks on the whitelist are forwarded by the listener. Your service may be adversely affected if the whitelist is not properly configured. If a whitelist is configured, the listener forwards only requests from IP addresses that are added to the whitelist.</para>
        /// <para>If you configure a whitelist but do not add an IP address to the whitelist, the listener forwards all requests.</para>
        /// </description></item>
        /// <item><description><para><b>black</b>: Requests from the IP addresses and CIDR blocks on the blacklist are blocked.</para>
        /// <para>If you configure a blacklist but do not add an IP address to the blacklist, the listener forwards all requests.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> When <b>AclStatus</b> is set to <b>on</b>, this parameter takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>white</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The backend port that is used by the CLB instance.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para> If the VServerGroupId parameter is not specified, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the listener. Unit: Mbit/s. Valid values:</para>
        /// <para><b>-1</b>: specifies that the bandwidth of the listener is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The cookie configured for the server.</para>
        /// <para>The cookie must be 1 to 200 characters in length, and can contain only ASCII letters and digits. It cannot contain commas (,), semicolons (;), space characters, or start with a dollar sign ($).</para>
        /// <remarks>
        /// <para> This parameter is required when the <b>StickySession</b> parameter is set to <b>on</b> and the <b>StickySessionType</b> parameter is set to <b>server</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>B490B5EBF6F3CD402E515D22BCDA1598</para>
        /// </summary>
        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// <para>The timeout period of a cookie. Unit: seconds.</para>
        /// <para>Valid values: <b>1</b> to <b>86400</b>.</para>
        /// <remarks>
        /// <para> If <b>StickySession</b> is set to <b>on</b> and <b>StickySessionType</b> is set to <b>insert</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
        /// <para>The name must be 1 to 256 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP_443</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The listening port that is used to redirect HTTP requests to HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("ForwardPort")]
        [Validation(Required=false)]
        public int? ForwardPort { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable <c>GZIP</c> compression to compress specific types of files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b> (default)</description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Gzip")]
        [Validation(Required=false)]
        public string Gzip { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the health check feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: yes</description></item>
        /// <item><description><b>off</b>: no</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// <para>The backend port that is used for health checks.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The domain name that is used for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>$_ip</b>: the private IP address of a backend server. If an IP address is specified, or this parameter is not specified, the CLB instance uses the private IP address of each backend server as the domain name for health checks.</description></item>
        /// <item><description><b>domain</b>: The domain name must be 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/12</para>
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// <para>The HTTP status code for a successful health check. Separate multiple HTTP status codes with commas (,).</para>
        /// <para>Valid values: <b>http_2xx</b> (default), <b>http_3xx</b>, <b>http_4xx</b>, and <b>http_5xx</b>.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
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
        /// <remarks>
        /// <para> This parameter takes effect only if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The health check method used in HTTP health checks. Valid values: <b>head</b> and <b>get</b>.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>get</para>
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check response. If a backend ECS instance does not respond within the specified timeout period, the ECS instance fails the health check. Unit: seconds</para>
        /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The URI that is used for health checks.</para>
        /// <para>The URI must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), and ampersands (&amp;). The URI must start with a forward slash (/) but cannot be a single forward slash (/).</para>
        /// <remarks>
        /// <para> This parameter takes effect only if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
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
        /// <remarks>
        /// <para> This parameter takes effect only if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The timeout period of an idle connection. Unit: seconds.</para>
        /// <para>Default value: <b>15</b>. Valid values: <b>1</b> to <b>60</b>.</para>
        /// <para>If no request is received within the specified timeout period, SLB closes the connection. When a request is received, SLB establishes a new connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable HTTP-to-HTTPS redirection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: yes</description></item>
        /// <item><description><b>off</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ListenerForward")]
        [Validation(Required=false)]
        public string ListenerForward { get; set; }

        /// <summary>
        /// <para>The frontend port that is used by the CLB instance.</para>
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
        /// <para>lb-bp1c9vixxjh92q83tw*****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the CLB instance is deployed.</para>
        /// <para>You can query the region ID from the <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a> list or by calling the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The timeout period of a request. Unit: seconds.</para>
        /// <para>Default value: <b>60</b>. Valid values: <b>1</b> to <b>180</b>.</para>
        /// <para>If no response is received from the backend server within the specified timeout period, CLB sends an <c>HTTP 504</c> error code to the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b> (default): Backend servers with higher weights receive more requests than backend servers with lower weights.</description></item>
        /// <item><description><b>rr</b>: Requests are distributed to backend servers in sequence.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable session persistence. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: yes</description></item>
        /// <item><description><b>off</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public string StickySession { get; set; }

        /// <summary>
        /// <para>The method that is used to handle cookies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>insert</b>: inserts a cookie.</para>
        /// <para>The first time a client accesses CLB, CLB inserts a cookie into the response packet. Subsequent requests from the client that carry the cookie are distributed to the same backend server as the first request.</para>
        /// </description></item>
        /// <item><description><para><b>server</b>: rewrites the original cookie.</para>
        /// <para>CLB rewrites the custom cookies in requests from a client. Subsequent requests from the client that carry the new cookie are forwarded to the same backend server as the first request.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if the <b>StickySession</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>insert</para>
        /// </summary>
        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerHTTPListenerRequestTag> Tag { get; set; }
        public class CreateLoadBalancerHTTPListenerRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the bastion host. Valid values of N: <b>1 to 20</b>. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be at most 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It must not start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: <b>1 to 20</b>. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <remarks>
        /// <para> This parameter takes effect only if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
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
        /// <para>rsp-cige6j*****</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the <c>X-Forwarded-For</c> header to retrieve client IP addresses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b> (default)</description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("XForwardedFor")]
        [Validation(Required=false)]
        public string XForwardedFor { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the <c>XForwardedFor_ClientSrcPort</c> header to retrieve the client port. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("XForwardedFor_ClientSrcPort")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientSrcPort { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>SLB-ID</c> header is used to retrieve the ID of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("XForwardedFor_SLBID")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBID { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>SLB-IP</c> header is used to retrieve the virtual IP address (VIP) requested by the client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("XForwardedFor_SLBIP")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBIP { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the <c>XForwardedFor_SLBPORT</c> header to retrieve the listener port of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("XForwardedFor_SLBPORT")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBPORT { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the <c>X-Forwarded-Proto</c> header to retrieve the listener protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("XForwardedFor_proto")]
        [Validation(Required=false)]
        public string XForwardedFor_proto { get; set; }

    }

}
