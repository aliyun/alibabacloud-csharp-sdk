// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetRuleRequest : TeaModel {
        /// <summary>
        /// <para>The cookie that is configured on the server.</para>
        /// <para>The cookie must be 1 to 200 characters in length and can contain only ASCII characters and digits. It cannot contain commas (,), semicolons (;), or space characters. It cannot start with a dollar sign ($).</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect if <b>StickySession</b> is set to <b>on</b> and <b>StickySessionType</b> is set to <b>server</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23ffsa</para>
        /// </summary>
        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// <para>The timeout period of a cookie. Unit: seconds. Valid values: <b>1</b> to <b>86400</b>.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect if <b>StickySession</b> is set to <b>on</b> and <b>StickySessionType</b> is set to <b>insert</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the health check feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: yes</description></item>
        /// <item><description><b>off</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required and takes effect if the <b>ListenerSync</b> parameter is set to <b>off</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// <para>The port that is used for health checks. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para> This parameter takes effect when the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
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
        /// <item><description><b>$_ip</b>: the private IP address of a backend server. If you do not set this parameter or set the parameter to $_ip, the SLB instance uses the private IP address of each backend server for health checks.</description></item>
        /// <item><description><b>domain</b>: The domain name must be 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>$_ip</para>
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// <para>The HTTP status code for a successful health check. Multiple HTTP status codes are separated by commas (,).</para>
        /// <para>Valid values: <b>http_2xx</b>, <b>http_3xx</b>, <b>http_4xx</b>, and <b>http_5xx</b>.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>http_2xx</para>
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive health checks. Unit: seconds. Valid values: <b>1</b> to <b>50</b>.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check response. If a backend server, such as an Elastic Compute Service (ECS) instance, does not return a health check response within the specified timeout period, the server fails the health check. Unit: seconds. Valid values: <b>1</b> to <b>300</b>.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The URI that is used for health checks.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/example</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from <b>fail</b> to <b>success</b>.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the scheduling algorithm, session persistence, and health check configurations of the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: uses the configurations of the listener.</description></item>
        /// <item><description><b>off</b>: does not use the configurations of the listener. You can customize the health check and session persistence configurations for the forwarding rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ListenerSync")]
        [Validation(Required=false)]
        public string ListenerSync { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Classic Load Balancer (CLB) instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The ID of the forwarding rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-3ejhkt****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the forwarding rule. The name must be 1 to 40 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// <remarks>
        /// <para>On the same listener, the forwarding rule names must be unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b>: Backend servers with higher weights receive more requests than those with lower weights.</description></item>
        /// <item><description><b>rr</b>: Requests are distributed to backend servers in sequence.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required and takes effect if the <b>ListenerSync</b> parameter is set to <b>off</b>.</para>
        /// </remarks>
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
        /// <item><description><b>off</b>: no</description></item>
        /// </list>
        /// <para>This parameter is required and takes effect if the <b>ListenerSync</b> parameter is set to <b>off</b>.</para>
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
        /// <item><description><para><b>insert</b>: inserts a cookie.</para>
        /// <para>CLB inserts the backend server ID as a cookie into the first HTTP or HTTPS response that is sent to a client. The next request from the client will contain this cookie, and the listener will distribute this request to the recorded backend server.</para>
        /// </description></item>
        /// <item><description><para><b>server</b>: rewrites a cookie.</para>
        /// <para>When CLB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. The next request from the client will contain the user-defined cookie, and the listener will distribute this request to the recorded backend server.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required and takes effect if the <b>StickySession</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>insert</para>
        /// </summary>
        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        /// <summary>
        /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from <b>success</b> to <b>fail</b>.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect if the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the vServer group that is associated with the forwarding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6****</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
