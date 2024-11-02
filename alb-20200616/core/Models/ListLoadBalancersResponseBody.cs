// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of ALB instances.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// <para>The configurations of access logs.</para>
            /// </summary>
            [NameInMap("AccessLogConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersAccessLogConfig AccessLogConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersAccessLogConfig : TeaModel {
                /// <summary>
                /// <para>The Simple Log Service project.</para>
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
            /// <para>The mode in which IP addresses are allocated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Fixed</b>: The ALB instance uses a static IP address.</description></item>
            /// <item><description><b>Dynamic</b>: dynamically allocates an IP address to each zone of the ALB instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Fixed</para>
            /// </summary>
            [NameInMap("AddressAllocatedMode")]
            [Validation(Required=false)]
            public string AddressAllocatedMode { get; set; }

            /// <summary>
            /// <para>The IP version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPv4</b></description></item>
            /// <item><description><b>DualStack</b></description></item>
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
            /// <item><description><b>Internet</b>: The ALB instance is assigned a public IP address. The domain name is resolved to the public IP address. The ALB instance is accessible over the Internet.</description></item>
            /// <item><description><b>Intranet</b>: The ALB instance is assigned only a private IP address. The domain name is resolved to the private IP address. The ALB instance is accessible only within the VPC of the ALB instance.</description></item>
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
            /// <para>The configuration of the deletion protection feature.</para>
            /// </summary>
            [NameInMap("DeletionProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig DeletionProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether deletion protection is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The time when deletion protection is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-02T02:49:05Z</para>
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

            }

            /// <summary>
            /// <para>The type of IPv6 address used by the ALB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Internet</b> The ALB instance is assigned a public IP address. The domain name is resolved to the public IP address. The ALB instance is accessible over the Internet.</description></item>
            /// <item><description><b>Intranet</b> The ALB instance is assigned only a private IP address. The domain name is resolved to the private IP address. The ALB instance is accessible only within the VPC of the ALB instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Intranet</para>
            /// </summary>
            [NameInMap("Ipv6AddressType")]
            [Validation(Required=false)]
            public string Ipv6AddressType { get; set; }

            /// <summary>
            /// <para>The billing information about the ALB instance.</para>
            /// </summary>
            [NameInMap("LoadBalancerBillingConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig : TeaModel {
                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <para>Only <b>PostPay</b> may be returned, which indicates the pay-as-you-go billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PostPay</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

            }

            /// <summary>
            /// <para>The status of the ALB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Abnormal</b></description></item>
            /// <item><description><b>Normal</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("LoadBalancerBussinessStatus")]
            [Validation(Required=false)]
            public string LoadBalancerBussinessStatus { get; set; }

            /// <summary>
            /// <para>The edition of the ALB instance. The features and billing rules vary based on the edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Basic</b></description></item>
            /// <item><description><b>Standard</b></description></item>
            /// <item><description><b>StandardWithWaf</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("LoadBalancerEdition")]
            [Validation(Required=false)]
            public string LoadBalancerEdition { get; set; }

            /// <summary>
            /// <para>The ID of the ALB instance.</para>
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
            /// <para>The configuration of the operation lock.</para>
            /// </summary>
            [NameInMap("LoadBalancerOperationLocks")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersLoadBalancerOperationLocks> LoadBalancerOperationLocks { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerOperationLocks : TeaModel {
                /// <summary>
                /// <para>The reason why the ALB instance is locked. This parameter is valid only if <b>LoadBalancerBussinessStatus</b> is set to <b>Abnormal</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test LockReason</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The lock type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SecurityLocked</b>: The ALB instance is locked due to security risks.</description></item>
                /// <item><description><b>RelatedResourceLocked</b>: The ALB instance is locked due to other resources associated with the ALB instance.</description></item>
                /// <item><description><b>FinancialLocked</b>: The ALB instance is locked due to overdue payments.</description></item>
                /// <item><description><b>ResidualLocked</b>: The ALB instance is locked because the associated resources have overdue payments and the resources are released.</description></item>
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
            /// <para>The status of the ALB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Inactive</b>: The ALB instance is disabled. ALB instances in the Inactive state do not forward traffic.</description></item>
            /// <item><description><b>Active</b>: The ALB instance is running.</description></item>
            /// <item><description><b>Provisioning</b>: The ALB instance is being created.</description></item>
            /// <item><description><b>Configuring</b>: The ALB instance is being modified.</description></item>
            /// <item><description><b>CreateFailed</b>: The system failed to create the ALB instance.</description></item>
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
                /// <para>The reason why the configuration read-only mode is enabled.</para>
                /// <para>The reason must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
                /// <para>This parameter is available only if the <b>ModificationProtectionStatus</b> parameter is set to <b>ConsoleProtection</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test Reason</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>Indicates whether the configuration read-only mode is enabled for the ALB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NonProtection</b>: Modification protection is disabled. In this case, you cannot set the ModificationProtectionReason parameter. If the ModificationProtectionReason parameter is specified, the value is cleared.</description></item>
                /// <item><description><b>ConsoleProtection</b>: Modification protection is enabled. In this case, you can set the ModificationProtectionReason parameter.</description></item>
                /// </list>
                /// <remarks>
                /// <para> If the value is <b>ConsoleProtection</b>, modification protection is enabled. You cannot modify the configurations of the ALB instance in the ALB console. However, you can call API operations to modify the configurations of the ALB instance.</para>
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
            /// <para>The information about the tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersTags> Tags { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the ALB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KeyTest</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the ALB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alueTest</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the VPC in which the ALB instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1b49rqrybk45nio****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is used to retrieve a new page of results.</description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
