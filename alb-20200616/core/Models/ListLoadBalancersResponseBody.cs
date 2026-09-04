// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Application Load Balancer instances.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// <para>The configuration of the access log.</para>
            /// </summary>
            [NameInMap("AccessLogConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersAccessLogConfig AccessLogConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersAccessLogConfig : TeaModel {
                /// <summary>
                /// <para>The Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls-setter</para>
                /// </summary>
                [NameInMap("LogProject")]
                [Validation(Required=false)]
                public string LogProject { get; set; }

                /// <summary>
                /// <para>The Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public string LogStore { get; set; }

            }

            /// <summary>
            /// <para>The mode of the IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Fixed</b>: The ALB instance uses a static IP address.</para>
            /// </description></item>
            /// <item><description><para><b>Dynamic</b>: A dynamic IP address is allocated to the ALB instance in each zone.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Fixed</para>
            /// </summary>
            [NameInMap("AddressAllocatedMode")]
            [Validation(Required=false)]
            public string AddressAllocatedMode { get; set; }

            /// <summary>
            /// <para>The protocol version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>IPv4</b>: IPv4</para>
            /// </description></item>
            /// <item><description><para><b>DualStack</b>: dual-stack</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DualStack</para>
            /// </summary>
            [NameInMap("AddressIpVersion")]
            [Validation(Required=false)]
            public string AddressIpVersion { get; set; }

            /// <summary>
            /// <para>The type of IP address that the ALB instance uses to provide services. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Internet</b>: The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.</para>
            /// </description></item>
            /// <item><description><para><b>Intranet</b>: The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. Therefore, the ALB instance can be accessed in the VPC where the ALB instance is deployed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Intranet</para>
            /// </summary>
            [NameInMap("AddressType")]
            [Validation(Required=false)]
            public string AddressType { get; set; }

            /// <summary>
            /// <para>The ID of the Internet Shared Bandwidth instance that is associated with the Internet-facing ALB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-bp1vevu8h3ieh****</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The time when the resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-02T02:49:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-95qnr2itwu9orb****.cn-hangzhou.alb.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DNSName")]
            [Validation(Required=false)]
            public string DNSName { get; set; }

            /// <summary>
            /// <para>The deletion protection configuration.</para>
            /// </summary>
            [NameInMap("DeletionProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig DeletionProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether deletion protection is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The time when deletion protection was enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-02T02:49:05Z</para>
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

            }

            /// <summary>
            /// <para>The type of the IPv6 address that the Application Load Balancer instance uses to provide services. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Internet</b>: The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.</para>
            /// </description></item>
            /// <item><description><para><b>Intranet</b>: The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. Therefore, the ALB instance can be accessed in the VPC where the ALB instance is deployed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Intranet</para>
            /// </summary>
            [NameInMap("Ipv6AddressType")]
            [Validation(Required=false)]
            public string Ipv6AddressType { get; set; }

            /// <summary>
            /// <para>The billing configuration of the ALB instance.</para>
            /// </summary>
            [NameInMap("LoadBalancerBillingConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig : TeaModel {
                /// <summary>
                /// <para>The billing method. Valid value:</para>
                /// <para><b>PostPay</b>: pay-as-you-go.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PostPay</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

            }

            /// <summary>
            /// <para>The service status of the ALB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Abnormal</b>: The instance is not working as expected.</para>
            /// </description></item>
            /// <item><description><para><b>Normal</b>: The instance is working as expected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("LoadBalancerBussinessStatus")]
            [Validation(Required=false)]
            public string LoadBalancerBussinessStatus { get; set; }

            /// <summary>
            /// <para>The edition of the ALB instance. Different editions have different limits and billing methods. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Basic</b>: Basic Edition.</para>
            /// </description></item>
            /// <item><description><para><b>Standard</b>: Standard Edition.</para>
            /// </description></item>
            /// <item><description><para><b>StandardWithWaf</b>: WAF-enabled Edition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("LoadBalancerEdition")]
            [Validation(Required=false)]
            public string LoadBalancerEdition { get; set; }

            /// <summary>
            /// <para>The ID of the Application Load Balancer instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-o9ulmq5hgn68jk****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The name of the ALB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-instance-test</para>
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            /// <summary>
            /// <para>The configuration of the configuration lock.</para>
            /// </summary>
            [NameInMap("LoadBalancerOperationLocks")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersLoadBalancerOperationLocks> LoadBalancerOperationLocks { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerOperationLocks : TeaModel {
                /// <summary>
                /// <para>The reason for the lock. This parameter is valid only if <b>LoadBalancerBussinessStatus</b> is set to <b>Abnormal</b>.</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The type of the lock. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>SecurityLocked</b>: The instance is locked for security reasons.</para>
                /// </description></item>
                /// <item><description><para><b>RelatedResourceLocked</b>: The instance is locked due to a correlated resource.</para>
                /// </description></item>
                /// <item><description><para><b>FinancialLocked</b>: The instance is locked due to overdue payments.</para>
                /// </description></item>
                /// <item><description><para><b>ResidualLocked</b>: The instance is locked because it is faulty.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FinancialLocked</para>
                /// </summary>
                [NameInMap("LockType")]
                [Validation(Required=false)]
                public string LockType { get; set; }

            }

            /// <summary>
            /// <para>The state of the Application Load Balancer instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Inactive</b>: The instance is disabled. Listeners of the instance do not forward traffic.</para>
            /// </description></item>
            /// <item><description><para><b>Active</b>: The instance is running.</para>
            /// </description></item>
            /// <item><description><para><b>Provisioning</b>: The instance is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: The instance is being configured.</para>
            /// </description></item>
            /// <item><description><para><b>CreateFailed</b>: The instance failed to be created.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LoadBalancerStatus")]
            [Validation(Required=false)]
            public string LoadBalancerStatus { get; set; }

            /// <summary>
            /// <para>The configuration of modification protection.</para>
            /// </summary>
            [NameInMap("ModificationProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig ModificationProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig : TeaModel {
                /// <summary>
                /// <para>The reason for enabling modification protection.</para>
                /// <para>The reason must be 2 to 128 characters in length, start with a letter or a Chinese character, and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
                /// <para>This parameter is returned only if <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Managed Instance</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The status of modification protection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>NonProtection</b>: Modification protection is disabled. If you specify a value for <b>Reason</b>, the value is cleared.</para>
                /// </description></item>
                /// <item><description><para><b>ConsoleProtection</b>: Modification protection is enabled. If you specify a value for <b>Reason</b>, the value takes effect.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>If you set the value to <b>ConsoleProtection</b>, you cannot modify the instance configuration in the Application Load Balancer console. However, you can call API operations to modify the instance configuration.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ConsoleProtection</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-atstuj3rtop****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The security groups to which the Application Load Balancer instance is added.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersTags> Tags { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KeyTest</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alueTest</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the VPC to which the Application Load Balancer instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1b49rqryhk45nio****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, it indicates that no next query is to be sent.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
