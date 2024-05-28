// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerHTTPListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the network ACL that is associated with a listener.
        /// 
        /// > This parameter is returned when **AclStatus** is set to **on**.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public DescribeLoadBalancerHTTPListenerAttributeResponseBodyAclIds AclIds { get; set; }
        public class DescribeLoadBalancerHTTPListenerAttributeResponseBodyAclIds : TeaModel {
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public List<string> AclId { get; set; }

        }

        /// <summary>
        /// Indicates whether access control is enabled. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// The type of the ACL. Valid values:
        /// 
        /// *   **white**: a whitelist. Only requests from the IP addresses or CIDR blocks in the ACL are forwarded. Whitelists apply to scenarios where you want to allow only specific IP addresses to access an application. Your service may be adversely affected if the whitelist is not properly configured. If a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener.
        /// 
        /// If you enable a whitelist but do not add an IP address to the ACL, the listener forwards all requests.
        /// 
        /// *   **black**: a blacklist. All requests from the IP addresses or CIDR blocks in the network ACL are rejected. Blacklists apply to scenarios where you want to block access from specified IP addresses to an application.
        /// 
        /// If a blacklist is configured for a listener but no IP address is added to the blacklist, the listener forwards all requests.
        /// 
        /// > This parameter is required when **AclStatus** is set to **on**.
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// The backend port that is used by the CLB instance.
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// The maximum bandwidth of the listener. Unit: Mbit/s.
        /// 
        /// *   **-1**: If -1 is returned, it indicates that the bandwidth of the listener is unlimited.
        /// *   **1 to 5120**: If a value from 1 to 5120 is returned, the value indicates the maximum bandwidth of the listener. The sum of the maximum bandwidth of all listeners added to a CLB instance does not exceed the maximum bandwidth of the CLB instance.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The cookie that is configured on the server.
        /// </summary>
        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// The timeout period of a cookie. Unit: seconds.
        /// </summary>
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        /// <summary>
        /// The name of the listener.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The listener port that is used to redirect HTTP requests to HTTPS.
        /// 
        /// >  If the **ListenerForward** parameter is set to **off**, this parameter is not displayed.
        /// </summary>
        [NameInMap("ForwardPort")]
        [Validation(Required=false)]
        public int? ForwardPort { get; set; }

        /// <summary>
        /// Indicates whether `Gzip` compression is enabled to compress specific types of files. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("Gzip")]
        [Validation(Required=false)]
        public string Gzip { get; set; }

        /// <summary>
        /// Indicates whether the health check feature is enabled. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// The port that is used for health checks.
        /// 
        /// > This parameter takes effect only when **HealthCheck** is set to **on**.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The domain name that you want to use for health checks.
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// The HTTP status code for a successful health check.
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// The interval at which health checks are performed. Unit: seconds.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// The health check method used by HTTP listeners. Valid values: **head** and **get**.
        /// 
        /// > This parameter is returned when **HealthCheck** is set to **on**.
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// The timeout period of each health check. Unit: seconds.
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// The URL path that is used for health checks.
        /// 
        /// The URI must be 1 to 80 characters in length, and can contain only digits, letters, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), and ampersands (&). The URI must start with a forward slash (/) but cannot be a single forward slash (/).
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// The healthy threshold.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// The timeout period of an idle connection. Unit: seconds.
        /// 
        /// Default value: **15**. Valid values: **1 to 60**.
        /// 
        /// If no request is received within the specified timeout period, CLB closes the connection. When a request is received, CLB establishes a new connection.
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// Indicates whether HTTP-to-HTTPS redirection is enabled. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("ListenerForward")]
        [Validation(Required=false)]
        public string ListenerForward { get; set; }

        /// <summary>
        /// The frontend port that is used by the CLB instance.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The CLB instance ID.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The timeout period of a request. Unit: seconds.
        /// 
        /// Default value: **60**. Valid values: **1 to 180**.
        /// 
        /// If no response is received from a backend server within the specified timeout period, CLB returns the HTTP 504 status code to the client.
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// The list of forwarding rules.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribeLoadBalancerHTTPListenerAttributeResponseBodyRules Rules { get; set; }
        public class DescribeLoadBalancerHTTPListenerAttributeResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerHTTPListenerAttributeResponseBodyRulesRule> Rule { get; set; }
            public class DescribeLoadBalancerHTTPListenerAttributeResponseBodyRulesRule : TeaModel {
                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The ID of the forwarding rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The name of the forwarding rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The request URL.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// The ID of the server group specified in the forwarding rule.
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// The routing algorithm. Valid values:
        /// 
        /// *   **wrr**: Backend servers that have higher weights receive more requests than backend servers that have lower weights.
        /// *   \\*\\* rr\\*\\*: Requests are sequentially distributed to backend servers.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// Indicates whether the listener is in the Secure state. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("SecurityStatus")]
        [Validation(Required=false)]
        public string SecurityStatus { get; set; }

        /// <summary>
        /// The status of the listener. Valid values:
        /// 
        /// *   **running**
        /// *   **stopped**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether session persistence is enabled. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public string StickySession { get; set; }

        /// <summary>
        /// The method that is used to handle a cookie.
        /// 
        /// Valid values: **insert** and **server**.
        /// 
        /// *   **insert**: inserts a cookie.
        /// 
        ///     CLB inserts a session cookie (SERVERID) into the first HTTP or HTTPS response that is sent to a client. Subsequent requests to CLB carry this cookie, and CLB determines the destination servers of the requests based on the cookies.
        /// 
        /// *   **server**: rewrites a cookie.
        /// 
        ///     When CLB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. The next request from the client carries the user-defined cookie, and the listener forwards this request to the recorded backend server.
        /// 
        /// > This parameter is required when **StickySession** is set to **on**.
        /// </summary>
        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeLoadBalancerHTTPListenerAttributeResponseBodyTags Tags { get; set; }
        public class DescribeLoadBalancerHTTPListenerAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerHTTPListenerAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeLoadBalancerHTTPListenerAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The key of tag N. Valid values of N: **1** to **20**. The tag key cannot be an empty string. The tag key can be up to 64 characters in length. The key cannot start with `acs:` or `aliyun` or contain `http://` or `https://`.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of tag N. Valid values of N: **1** to **20**. The tag value can be an empty string. The tag value must be 0 to 128 characters in length, and cannot start with `acs:`. It cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The unhealthy threshold.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// The ID of the associated server group.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// Indicates whether the `X-Forwarded-For` header is used to preserve the real IP address of the client. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor")]
        [Validation(Required=false)]
        public string XForwardedFor { get; set; }

        /// <summary>
        /// Indicates whether the `XForwardedFor_ClientSrcPort` header is used to retrieve the client port. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_ClientSrcPort")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientSrcPort { get; set; }

        /// <summary>
        /// Indicates whether the `SLB-ID` header is used to retrieve the ID of the CLB instance. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_SLBID")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBID { get; set; }

        /// <summary>
        /// Indicates whether the `SLB-IP` header is used to retrieve the virtual IP address requested by the client. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_SLBIP")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBIP { get; set; }

        /// <summary>
        /// Indicates whether the `XForwardedFor_SLBPORT` header is used to retrieve the listener port of the CLB instance. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_SLBPORT")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBPORT { get; set; }

        /// <summary>
        /// Indicates whether the `X-Forwarded-Proto` header is used to retrieve the listener protocol. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_proto")]
        [Validation(Required=false)]
        public string XForwardedFor_proto { get; set; }

    }

}
