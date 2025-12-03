// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeRuleAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The cookie to be configured on the backend server.</para>
        /// <para>The cookie must be 1 to 200 characters in length and can contain ASCII letters and digits. It cannot contain commas (,), semicolons (;), or whitespace characters. It cannot start with a dollar sign ($).</para>
        /// <para>If you set the <b>StickySession</b> parameter to <b>on</b> and the <b>StickySessionType</b> parameter to <b>server</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wwe</para>
        /// </summary>
        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// <para>The timeout period of a cookie.</para>
        /// <para>Valid values: <b>1 to 86400</b>. Unit: seconds.</para>
        /// <remarks>
        /// <para> If you set the <b>StickySession</b> parameter to <b>on</b> and the <b>StickySessionType</b> parameter to <b>insert</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        /// <summary>
        /// <para>The domain name that is configured in the forwarding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable health checks.</para>
        /// <para>Valid values: <b>on</b> and <b>off</b>.</para>
        /// <remarks>
        /// <para> If you set the <b>ListenerSync</b> parameter to <b>off</b>, this parameter is required. If you set the parameter to <b>on</b>, the configuration of the listener is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// <para>The backend port that is used for health checks.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para> If you set the <b>HealthCheck</b> parameter to <b>on</b>, this parameter is required. If this parameter is empty but <b>HealthCheck</b> is set to <b>on</b>, the listener port is used for health checks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The domain name that is used for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>$_ip</b>: The private IP address of the backend server. If the $_ip parameter is set or the HealthCheckDomain parameter is not set, SLB uses the private IP addresses of backend servers as the domain names for health checks.</description></item>
        /// <item><description><b>domain</b>: The domain name must be 1 to 80 characters in length. It can contain only letters, digits, periods (.),and hyphens (-).</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the <b>HealthCheck</b> parameter to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// <para>The HTTP status code that indicates a successful health check. Separate multiple HTTP status codes with commas (,). Default value: <b>http_2xx</b>.</para>
        /// <para>Valid values: <b>http_2xx</b>, <b>http_3xx</b>, <b>http_4xx</b>, and <b>http_5xx</b>.</para>
        /// <remarks>
        /// <para> If you set the <b>HealthCheck</b> parameter to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>http_3xx</para>
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// <para>The time interval between two consecutive health checks.</para>
        /// <para>Valid values: <b>1</b> to <b>50</b>. Unit: seconds.</para>
        /// <remarks>
        /// <para> If you set the <b>HealthCheck</b> parameter to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>34</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check response. If a backend ECS instance does not respond within the specified timeout period, the ECS instance fails the health check.</para>
        /// <para>Valid values: <b>1</b> to <b>300</b>. Unit: seconds.</para>
        /// <remarks>
        /// <para> If you set the <b>HealthCheck</b> parameter to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>34</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The URI that is used for health checks.</para>
        /// <remarks>
        /// <para> If you set the <b>HealthCheck</b> parameter to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/rest</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks that must occur before an unhealthy backend server is declared healthy. In this case, the health check state is changed from <b>fail</b> to <b>success</b>.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para> If you set the <b>HealthCheck</b> parameter to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The listener port that is used by the SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public string ListenerPort { get; set; }

        /// <summary>
        /// <para>Indicates whether the forwarding rule uses the scheduling algorithm, session persistence, and health check configurations of the listener.</para>
        /// <para>Valid values: <b>on</b> and <b>off</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>off</b>: does not use the configurations of the listener. You can customize health check and session persistence configurations for the forwarding rule.</description></item>
        /// <item><description><b>on</b>: uses the configurations of the listener.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ListenerSync")]
        [Validation(Required=false)]
        public string ListenerSync { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1ca0zt07t934wxe****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DEC9C28-AB05-4DDF-9A78-6B08EC9CE18C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the forwarding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-hfgnd*****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the forwarding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rule1</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b> (default): Backend servers that have higher weights receive more requests than backend servers that have lower weights.</description></item>
        /// <item><description><b>rr</b>: Requests are distributed to backend servers in sequence.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the <b>ListenerSync</b> parameter to <b>off</b>, this parameter is required. If you set the parameter to <b>on</b>, the configuration of the listener is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>Indicates whether session persistence is enabled.</para>
        /// <para>Valid values: <b>on</b> and <b>off</b>.</para>
        /// <remarks>
        /// <para> If you set the <b>ListenerSync</b> parameter to <b>off</b>, this parameter is required. If you set the parameter to <b>on</b>, the configuration of the listener is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public string StickySession { get; set; }

        /// <summary>
        /// <para>The method that is used to handle a cookie. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>insert</b>: inserts a cookie into the response. SLB inserts a cookie (SERVERID) into the first HTTP or HTTPS response packet that is sent to a client. The next request from the client will contain this cookie, and the listener will distribute this request to the recorded backend server.</description></item>
        /// <item><description><b>server</b>: rewrites a cookie. When SLB detects a user-defined cookie, SLB overwrites the original cookie with the user-defined cookie. The next request from the client contains the user-defined cookie, and the listener distributes the request to the recorded backend server.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the <b>StickySession</b> parameter to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>insert</para>
        /// </summary>
        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        /// <summary>
        /// <para>The number of consecutive failed health checks that must occur before a healthy backend server is declared unhealthy. In this case, the health check state is changed from <b>success</b> to <b>fail</b>.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para> If you set the <b>HealthCheck</b> parameter to <b>on</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// <para>The URL that is configured in the forwarding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/cache</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>The ID of the vServer group that is associated with the forwarding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6j****</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
