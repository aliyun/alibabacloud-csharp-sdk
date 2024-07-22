// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// A list of ALB instances.
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// The configurations of access logs.
            /// </summary>
            [NameInMap("AccessLogConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersAccessLogConfig AccessLogConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersAccessLogConfig : TeaModel {
                /// <summary>
                /// The Simple Log Service project.
                /// </summary>
                [NameInMap("LogProject")]
                [Validation(Required=false)]
                public string LogProject { get; set; }

                /// <summary>
                /// The Logstore.
                /// </summary>
                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public string LogStore { get; set; }

            }

            /// <summary>
            /// The mode in which IP addresses are allocated. Valid values:
            /// 
            /// *   **Fixed**: The ALB instance uses a static IP address.
            /// *   **Dynamic**: dynamically allocates an IP address to each zone of the ALB instance.
            /// </summary>
            [NameInMap("AddressAllocatedMode")]
            [Validation(Required=false)]
            public string AddressAllocatedMode { get; set; }

            /// <summary>
            /// The IP version. Valid values:
            /// 
            /// *   **IPv4**
            /// *   **DualStack**
            /// </summary>
            [NameInMap("AddressIpVersion")]
            [Validation(Required=false)]
            public string AddressIpVersion { get; set; }

            /// <summary>
            /// The type of IP address that the ALB instance uses to provide services. Valid values:
            /// 
            /// *   **Internet**: The ALB instance is assigned a public IP address. The domain name is resolved to the public IP address. The ALB instance is accessible over the Internet.
            /// *   **Intranet**: The ALB instance is assigned only a private IP address. The domain name is resolved to the private IP address. The ALB instance is accessible only within the VPC of the ALB instance.
            /// </summary>
            [NameInMap("AddressType")]
            [Validation(Required=false)]
            public string AddressType { get; set; }

            /// <summary>
            /// The ID of the Internet Shared Bandwidth instance that is associated with the Internet-facing ALB instance.
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// The time when the resource was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("DNSName")]
            [Validation(Required=false)]
            public string DNSName { get; set; }

            /// <summary>
            /// The configuration of the deletion protection feature.
            /// </summary>
            [NameInMap("DeletionProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig DeletionProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig : TeaModel {
                /// <summary>
                /// Indicates whether deletion protection is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// The time when deletion protection is enabled.
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

            }

            /// <summary>
            /// The type of IPv6 address used by the ALB instance. Valid values:
            /// 
            /// *   **Internet** The ALB instance is assigned a public IP address. The domain name is resolved to the public IP address. The ALB instance is accessible over the Internet.
            /// *   **Intranet** The ALB instance is assigned only a private IP address. The domain name is resolved to the private IP address. The ALB instance is accessible only within the VPC of the ALB instance.
            /// </summary>
            [NameInMap("Ipv6AddressType")]
            [Validation(Required=false)]
            public string Ipv6AddressType { get; set; }

            /// <summary>
            /// The billing information about the ALB instance.
            /// </summary>
            [NameInMap("LoadBalancerBillingConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig : TeaModel {
                /// <summary>
                /// The billing method. Valid values:
                /// 
                /// Only **PostPay** may be returned, which indicates the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

            }

            /// <summary>
            /// The status of the ALB instance. Valid values:
            /// 
            /// *   **Abnormal**
            /// *   **Normal**
            /// </summary>
            [NameInMap("LoadBalancerBussinessStatus")]
            [Validation(Required=false)]
            public string LoadBalancerBussinessStatus { get; set; }

            /// <summary>
            /// The edition of the ALB instance. The features and billing rules vary based on the edition. Valid values:
            /// 
            /// *   **Basic**
            /// *   **Standard**
            /// *   **StandardWithWaf**
            /// </summary>
            [NameInMap("LoadBalancerEdition")]
            [Validation(Required=false)]
            public string LoadBalancerEdition { get; set; }

            /// <summary>
            /// The ID of the ALB instance.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The name of the ALB instance.
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            /// <summary>
            /// The configuration of the operation lock.
            /// </summary>
            [NameInMap("LoadBalancerOperationLocks")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersLoadBalancerOperationLocks> LoadBalancerOperationLocks { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerOperationLocks : TeaModel {
                /// <summary>
                /// The reason why the ALB instance is locked. This parameter is valid only if **LoadBalancerBussinessStatus** is set to **Abnormal**.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The lock type. Valid values:
                /// 
                /// *   **SecurityLocked**: The ALB instance is locked due to security risks.
                /// *   **RelatedResourceLocked**: The ALB instance is locked due to other resources associated with the ALB instance.
                /// *   **FinancialLocked**: The ALB instance is locked due to overdue payments.
                /// *   **ResidualLocked**: The ALB instance is locked because the associated resources have overdue payments and the resources are released.
                /// </summary>
                [NameInMap("LockType")]
                [Validation(Required=false)]
                public string LockType { get; set; }

            }

            /// <summary>
            /// The status of the ALB instance. Valid values:
            /// 
            /// *   **Inactive**: The ALB instance is disabled. ALB instances in the Inactive state do not forward traffic.
            /// *   **Active**: The ALB instance is running.
            /// *   **Provisioning**: The ALB instance is being created.
            /// *   **Configuring**: The ALB instance is being modified.
            /// *   **CreateFailed**: The system failed to create the ALB instance.
            /// </summary>
            [NameInMap("LoadBalancerStatus")]
            [Validation(Required=false)]
            public string LoadBalancerStatus { get; set; }

            /// <summary>
            /// The configuration of modification protection.
            /// </summary>
            [NameInMap("ModificationProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig ModificationProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig : TeaModel {
                /// <summary>
                /// The reason why the configuration read-only mode is enabled.
                /// 
                /// The reason must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).
                /// 
                /// This parameter is available only if the **ModificationProtectionStatus** parameter is set to **ConsoleProtection**.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// Indicates whether the configuration read-only mode is enabled for the ALB instance. Valid values:
                /// 
                /// *   **NonProtection**: Modification protection is disabled. In this case, you cannot set the ModificationProtectionReason parameter. If the ModificationProtectionReason parameter is specified, the value is cleared.
                /// *   **ConsoleProtection**: Modification protection is enabled. In this case, you can set the ModificationProtectionReason parameter.
                /// 
                /// >  If the value is **ConsoleProtection**, modification protection is enabled. You cannot modify the configurations of the ALB instance in the ALB console. However, you can call API operations to modify the configurations of the ALB instance.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The information about the tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersTags> Tags { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersTags : TeaModel {
                /// <summary>
                /// The tag key of the ALB instance.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the ALB instance.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the VPC in which the ALB instance is deployed.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is used to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
