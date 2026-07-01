// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceAttributeRequest : TeaModel {
        [NameInMap("CpuOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestCpuOptions CpuOptions { get; set; }
        public class ModifyInstanceAttributeRequestCpuOptions : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores. This parameter does not support custom values and can only use the default value.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;Default value: see <a href="https://help.aliyun.com/document_detail/145895.html">Customize CPU options</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            /// <summary>
            /// <para>The number of threads per CPU core. The number of vCPUs of the ECS instance = CpuOptions.Core value × CpuOptions.ThreadsPerCore value.</para>
            /// <list type="bullet">
            /// <item><description><para>CpuOptions.ThreadsPerCore=1 indicates that hyper-threading is disabled.</para>
            /// </description></item>
            /// <item><description><para>Only some instance types support custom thread counts.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;Valid values and default value: see <a href="https://help.aliyun.com/document_detail/145895.html">Customize CPU options</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ThreadsPerCore")]
            [Validation(Required=false)]
            public int? ThreadsPerCore { get; set; }

            /// <summary>
            /// <para>The CPU topology type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ContinuousCoreToHTMapping: the hyper-threads of the same core in the CPU topology are continuous.</description></item>
            /// <item><description>DiscreteCoreToHTMapping: the hyper-threads of the same core are discrete.</description></item>
            /// </list>
            /// <para>Default value: none.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The instance must be in the Stopped state.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only some instance families support this parameter. For information about the supported instance families, see <a href="https://help.aliyun.com/document_detail/2636059.html">View and modify the CPU topology structure</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>DiscreteCoreToHTMapping</para>
            /// </summary>
            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("NestedVirtualization")]
            [Validation(Required=false)]
            public string NestedVirtualization { get; set; }

        }

        /// <summary>
        /// <para>The running mode of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard mode.</description></item>
        /// <item><description>Unlimited: unlimited mode.</description></item>
        /// </list>
        /// <para>For more information about the running modes of burstable instances, see <a href="https://help.aliyun.com/document_detail/59977.html">What are burstable instances?</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The release protection attribute of the instance. Specifies whether the instance can be released from the console or by calling <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a>.</para>
        /// <remarks>
        /// <para>This attribute applies only to pay-as-you-go instances and only prevents manual release operations. It does not apply to system-initiated release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The description of the instance. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testInstanceDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Jumbo Frame feature for the instance MTU. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the feature.</description></item>
        /// <item><description>false: does not enable the feature.</description></item>
        /// </list>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instance must be in the Running or Stopped state.</description></item>
        /// <item><description>The instance must be a VPC-connected instance.</description></item>
        /// <item><description>After the Jumbo Frame feature is enabled, the MTU value of the instance changes to 8500. After the feature is disabled, the MTU value reverts to 1500.
        /// Only some instance types support the Jumbo Frame feature. For more information, see <a href="https://help.aliyun.com/document_detail/200512.html">ECS instance MTU</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableJumboFrame")]
        [Validation(Required=false)]
        public bool? EnableJumboFrame { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable VPC network traffic encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the encryption.</description></item>
        /// <item><description>false: disables the encryption.<remarks>
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNetworkEncryption")]
        [Validation(Required=false)]
        public bool? EnableNetworkEncryption { get; set; }

        /// <summary>
        /// <para>The hostname of the operating system. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>The instance cannot be in the Pending or Starting state. Otherwise, the hostname and <c>/etc/hosts</c> configuration may not take effect. You can call <a href="https://help.aliyun.com/document_detail/25506.html">DescribeInstances</a> to query the current status of the instance.</para>
        /// </description></item>
        /// <item><description><para>The new hostname takes effect after you restart the instance. You can restart the instance in the ECS console (for more information, see <a href="https://help.aliyun.com/document_detail/25440.html">Restart an instance</a>) or by calling <a href="https://help.aliyun.com/document_detail/25502.html">RebootInstance</a>. Restarting the instance from within the operating system does not take effect.</para>
        /// </description></item>
        /// </list>
        /// <para>The hostname has the following limits for different operating systems:</para>
        /// <list type="bullet">
        /// <item><description><para>Windows Server: The hostname must be 2 to 15 characters in length and can contain uppercase letters, lowercase letters, digits, and hyphens (-). It cannot start or end with a hyphen (-), cannot contain consecutive hyphens (-), and cannot contain only digits.</para>
        /// </description></item>
        /// <item><description><para>Other instances (such as Linux): The hostname must be 2 to 64 characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain uppercase letters, lowercase letters, digits, and hyphens (-), but cannot contain consecutive periods (.) or hyphens (-). The hostname cannot start or end with a period (.) or hyphen (-).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testHostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must be 2 to 128 characters in length. It must start with an uppercase letter, lowercase letter, or Chinese character and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testInstanceName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The number of queues for the primary network interface controller (NIC). Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instance must be in the Stopped state.</description></item>
        /// <item><description>The value cannot exceed the maximum number of queues per NIC allowed by the instance type. The total number of queues for all NICs on the instance cannot exceed the total queue quota allowed by the instance type. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the maximum number of queues per NIC and the total queue quota for an instance type.</description></item>
        /// <item><description>If you set this parameter to -1, the number of queues for the primary NIC is reset to the default value for the instance type. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the default number of Elastic Network Interface (ENI) queues for an instance type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("NetworkInterfaceQueueNumber")]
        [Validation(Required=false)]
        public int? NetworkInterfaceQueueNumber { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the instance. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported: <b>()`~!@#$%^&amp;*-_+=|{}[]:;\&quot;&lt;&gt;,.?/</b>
        /// . For Windows instances, the password cannot start with a forward slash (/). Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instance cannot be in the Starting state.</description></item>
        /// <item><description>The new password takes effect after you restart the instance. You can restart the instance in the ECS console (for more information, see <a href="https://help.aliyun.com/document_detail/25440.html">Restart an instance</a>) or by calling <a href="https://help.aliyun.com/document_detail/25502.html">RebootInstance</a>. Restarting the instance from within the operating system does not take effect.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify the Password parameter, use HTTPS to send the request to avoid password leaks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456&amp;$</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The private domain name configuration of the instance.</para>
        /// <para>For more information about private private domain resolution, see <a href="https://help.aliyun.com/document_detail/2844797.html">ECS private private domain resolution</a>.</para>
        /// </summary>
        [NameInMap("PrivateDnsNameOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestPrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
        public class ModifyInstanceAttributeRequestPrivateDnsNameOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable DNS resolution from the instance ID-based domain name to the IPv6 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the resolution.</description></item>
            /// <item><description>false: disables the resolution.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableInstanceIdDnsAAAARecord")]
            [Validation(Required=false)]
            public bool? EnableInstanceIdDnsAAAARecord { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable DNS resolution from the instance ID-based domain name to the IPv4 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the resolution.</description></item>
            /// <item><description>false: disables the resolution.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableInstanceIdDnsARecord")]
            [Validation(Required=false)]
            public bool? EnableInstanceIdDnsARecord { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable DNS resolution from the IP-based domain name to the IPv4 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the resolution.</description></item>
            /// <item><description>false: disables the resolution.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableIpDnsARecord")]
            [Validation(Required=false)]
            public bool? EnableIpDnsARecord { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable reverse DNS resolution from the IPv4 address to the IP-based domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the resolution.</description></item>
            /// <item><description>false: disables the resolution.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableIpDnsPtrRecord")]
            [Validation(Required=false)]
            public bool? EnableIpDnsPtrRecord { get; set; }

            /// <summary>
            /// <para>The hostname type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Custom: custom.</description></item>
            /// <item><description>IpBased: IP-based hostname.</description></item>
            /// <item><description>InstanceIdBased: instance ID-based hostname.</description></item>
            /// </list>
            /// <para>Default value: Custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("HostnameType")]
            [Validation(Required=false)]
            public string HostnameType { get; set; }

        }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Recyclable")]
        [Validation(Required=false)]
        public bool? Recyclable { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RemoteConnectionOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestRemoteConnectionOptions RemoteConnectionOptions { get; set; }
        public class ModifyInstanceAttributeRequestRemoteConnectionOptions : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hide</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hide</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups to which the instance is reassigned. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Security group IDs in the array cannot be duplicated. The maximum length of the array depends on the maximum number of security groups to which the instance can belong. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Limits</a>.</description></item>
        /// <item><description>The instance leaves its current security groups. To retain the current security groups, add their IDs to the array.</description></item>
        /// <item><description>You can switch between security group types, but the list cannot contain both basic security groups and advanced security groups at the same time.</description></item>
        /// <item><description>The security groups must belong to the same VPC as the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Changes to security groups take effect on the instance shortly after the modification, but a slight delay may occur.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7o****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The instance user data. We recommend that you Base64-encode the data before you pass it in. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instance must meet the usage limits for instance user data. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Create instance user data</a>.</description></item>
        /// <item><description>After you restart the instance, the new user data is displayed on the instance but is not run.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Before Base64 encoding, the raw data cannot exceed 32 KB. Do not pass in sensitive information such as passwords and private keys in plaintext. If you must pass in sensitive information, encrypt the information, Base64-encode it, and then decrypt it in the same way within the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
