// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerUDPListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the network ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123943****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The ID of the access control list (ACL).</para>
        /// </summary>
        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public DescribeLoadBalancerUDPListenerAttributeResponseBodyAclIds AclIds { get; set; }
        public class DescribeLoadBalancerUDPListenerAttributeResponseBodyAclIds : TeaModel {
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public List<string> AclId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether access control is enabled. Valid values: <b>on</b> and <b>off</b>. Default value: off.</para>
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
        /// <item><description><para><b>white</b>: a whitelist. Only requests from the IP addresses or CIDR blocks in the network ACL are forwarded. Whitelists apply to scenarios in which you want to allow only specified IP addresses to access an application.</para>
        /// <para>Your service may be adversely affected if the whitelist is not properly configured. After a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener. If you enable a whitelist but do not add an IP address to the ACL, the listener forwards all requests.</para>
        /// </description></item>
        /// <item><description><para><b>black</b>: a blacklist. All requests from the IP addresses or CIDR blocks in the network ACL are blocked. Blacklists apply to scenarios in which you want to deny access from specific IP addresses or CIDR blocks to an application.</para>
        /// <para>If a blacklist is configured for a listener but no IP address is added to the blacklist, the listener forwards all requests.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>white</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The backend port used by the CLB instance.</para>
        /// <remarks>
        /// <para> If the listener is associated with a vServer group, this parameter is not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the listener. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: For a pay-by-data-transfer Internet-facing CLB instance, this parameter is set to -1. This indicates that the bandwidth of the listener is unlimited.</description></item>
        /// <item><description><b>1</b> to <b>5120</b>: For a pay-by-bandwidth Internet-facing CLB instance, you can specify the maximum bandwidth of each listener. The sum of maximum bandwidth of all listeners cannot exceed the maximum bandwidth of the CLB instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The description of the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the health check feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: yes</description></item>
        /// <item><description><b>off</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// <para>The port that is used for health checks. Valid values: <b>1</b> to <b>65535</b>. If this parameter is not set, the port specified by BackendServerPort is used for health checks.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when the <b>HealthCheck</b> parameter is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check. If a backend Elastic Compute Service (ECS) instance does not return a health check response within the specified timeout period, the server fails the health check. Valid values: <b>1</b> to <b>300</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// <para>The response string for UDP listener health checks. The string is up to 64 characters in length, and can contain letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("HealthCheckExp")]
        [Validation(Required=false)]
        public string HealthCheckExp { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive health checks. Valid values: <b>1</b> to <b>50</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The request string for UDP listener health checks. The string is up to 64 characters in length, and can contain letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("HealthCheckReq")]
        [Validation(Required=false)]
        public string HealthCheckReq { get; set; }

        /// <summary>
        /// <para>The healthy threshold. The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from <b>fail</b> to <b>success</b>. Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The frontend port used by the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1rtfnodmywb43e*****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The ID of the primary/secondary server group that is associated with the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-0bfucw****</para>
        /// </summary>
        [NameInMap("MasterSlaveServerGroupId")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the Proxy protocol is used to pass client IP addresses to backend servers. Valid values:</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The status of the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>running</b></description></item>
        /// <item><description><b>stopped</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>stopped</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeLoadBalancerUDPListenerAttributeResponseBodyTags Tags { get; set; }
        public class DescribeLoadBalancerUDPListenerAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerUDPListenerAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeLoadBalancerUDPListenerAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// <para>The key of tag N. Valid values of N: <b>1</b> to <b>20</b>. The tag value cannot be an empty string. The tag key can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of tag N. Valid values of N: <b>1</b> to <b>20</b>. The tag value can be an empty string. The tag value can be up to 128 characters in length, and cannot start with <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The unhealthy threshold. The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from <b>success</b> to <b>fail</b>. Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the vServer group that is associated with the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6j****</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
