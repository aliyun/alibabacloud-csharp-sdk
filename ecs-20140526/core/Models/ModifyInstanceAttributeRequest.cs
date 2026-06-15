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
            /// <para>The number of CPU cores. This parameter is not customizable and uses a default value.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>For information about the default value, see <a href="https://help.aliyun.com/document_detail/145895.html">Custom CPU options</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            /// <summary>
            /// <para>The number of threads per core. The total number of vCPUs for an ECS instance is the value of <c>CpuOptions.Core</c> multiplied by the value of <c>CpuOptions.ThreadsPerCore</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>Setting <c>CpuOptions.ThreadsPerCore</c> to 1 disables hyper-threading.</para>
            /// </description></item>
            /// <item><description><para>Only some instance types support specifying the number of threads per core.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>For information about the valid values and default value, see <a href="https://help.aliyun.com/document_detail/145895.html">Custom CPU options</a>.</para>
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
            /// <item><description><para>ContinuousCoreToHTMapping: The hyper-threads of the same core are contiguous.</para>
            /// </description></item>
            /// <item><description><para>DiscreteCoreToHTMapping: The hyper-threads of the same core are discrete.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: None.</para>
            /// <para>Note the following when you use this parameter:</para>
            /// <list type="bullet">
            /// <item><description>The instance must be in the <c>Stopped</c> state.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported by only some instance families. See <a href="https://help.aliyun.com/document_detail/2636059.html">View and modify the CPU topology</a> for a list of supported families.</para>
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
            /// <para>This parameter is in invitation-only preview and is not publicly available.</para>
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
        /// <para>The performance mode of the burstable performance instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: standard mode.</para>
        /// </description></item>
        /// <item><description><para>Unlimited: unlimited mode.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about the performance modes of burstable performance instances, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable performance instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the instance. This setting prevents the instance from being released from the console or by calling the <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a> operation.</para>
        /// <remarks>
        /// <para>This feature applies only to pay-as-you-go instances and protects instances only from manual release operations. It does not affect system-initiated release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The instance description. The description must be 2 to 256 characters long and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testInstanceDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable jumbo frames. When jumbo frames are enabled, the MTU of the instance is 8500. When jumbo frames are disabled, the MTU of the instance is 1500. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <para>Note the following when you use this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>The instance must be in the <c>Running</c> or <c>Stopped</c> state.</para>
        /// </description></item>
        /// <item><description><para>The instance must be in a VPC.</para>
        /// </description></item>
        /// <item><description><para>Only some instance types support jumbo frames. For more information, see <a href="https://help.aliyun.com/document_detail/200512.html">ECS instance MTU</a>.</para>
        /// </description></item>
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
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is in invitation-only preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNetworkEncryption")]
        [Validation(Required=false)]
        public bool? EnableNetworkEncryption { get; set; }

        /// <summary>
        /// <para>The hostname of the operating system. Note the following when you use this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>The instance cannot be in the <c>Pending</c> or <c>Starting</c> state. Otherwise, the specified hostname and the <c>/etc/hosts</c> configuration may not take effect. You can call the <a href="https://help.aliyun.com/document_detail/25506.html">DescribeInstances</a> operation to query the current state of the instance.</para>
        /// </description></item>
        /// <item><description><para>The new hostname takes effect after you restart the instance from the ECS console (see <a href="https://help.aliyun.com/document_detail/25440.html">Restart an instance</a>) or by calling the <a href="https://help.aliyun.com/document_detail/25502.html">RebootInstance</a> operation. Restarting the instance from within its operating system does not apply the change.</para>
        /// </description></item>
        /// </list>
        /// <para>The hostname must meet the following requirements for different operating systems:</para>
        /// <list type="bullet">
        /// <item><description><para>For Windows Server instances: The hostname must be 2 to 15 characters long and contain letters, digits, and hyphens (-). It cannot start or end with a hyphen, contain consecutive hyphens, or consist of only digits.</para>
        /// </description></item>
        /// <item><description><para>For other types of instances (such as Linux): The hostname must be 2 to 64 characters long. You can use periods (.) to separate the hostname into segments. Each segment can contain letters, digits, and hyphens (-). The hostname cannot start or end with a period or hyphen, and cannot contain consecutive periods or hyphens.</para>
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
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 128 characters long. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testInstanceName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The number of queues for the primary network interface. Note the following when you use this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>The instance must be in the <c>Stopped</c> state.</para>
        /// </description></item>
        /// <item><description><para>The value cannot exceed the maximum number of queues that the instance type supports for a single network interface. The total number of queues across all network interfaces of the instance cannot exceed the total queue quota that the instance type supports. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the maximum number of queues per network interface and the total queue quota for an instance type.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to -1, the number of queues for the primary network interface is reset to the default value for the instance type. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the default number of queues for an elastic network interface of an instance type.</para>
        /// </description></item>
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
        /// <para>The password of the instance. The password must be 8 to 30 characters long and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The supported special characters are <b>()\~!@#$%^&amp;\*-_+=|{}[]:;\&quot;&lt;&gt;,.?/</b>. For a Windows instance, the password cannot start with a forward slash (/). Note the following when you use this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>The instance cannot be in the <c>Starting</c> state.</para>
        /// </description></item>
        /// <item><description><para>The new password takes effect after you restart the instance from the ECS console (see <a href="https://help.aliyun.com/document_detail/25440.html">Restart an instance</a>) or by calling the <a href="https://help.aliyun.com/document_detail/25502.html">RebootInstance</a> operation. Restarting the instance from within its operating system does not apply the change.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To prevent password exposure, send requests that include the <c>Password</c> parameter over HTTPS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456&amp;$</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The private DNS name settings for the instance.</para>
        /// <para>For more information about private DNS name resolution, see <a href="https://help.aliyun.com/document_detail/2844797.html">ECS private DNS resolution
        /// </a>.</para>
        /// </summary>
        [NameInMap("PrivateDnsNameOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestPrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
        public class ModifyInstanceAttributeRequestPrivateDnsNameOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable resolution of the instance ID-based domain name to an IPv6 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
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
            /// <para>Specifies whether to enable resolution of the instance ID-based domain name to an IPv4 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
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
            /// <para>Specifies whether to enable resolution of the IP address-based domain name to an IPv4 address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
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
            /// <para>Specifies whether to enable reverse DNS resolution of an IPv4 address to an IP address-based domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
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
            /// <item><description><para>Custom: a custom hostname.</para>
            /// </description></item>
            /// <item><description><para>IpBased: an IP address-based hostname.</para>
            /// </description></item>
            /// <item><description><para>InstanceIdBased: an instance ID-based hostname.</para>
            /// </description></item>
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
        /// <para>This parameter is in invitation-only preview and is not publicly available.</para>
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
        /// <para>This parameter is in invitation-only preview and is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RemoteConnectionOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestRemoteConnectionOptions RemoteConnectionOptions { get; set; }
        public class ModifyInstanceAttributeRequestRemoteConnectionOptions : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitation-only preview and is not publicly available.</para>
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
            /// <para>This parameter is in invitation-only preview and is not publicly available.</para>
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
        /// <para>The IDs of security groups to assign to the instance. Note the following when you use this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>The security group IDs in the array must be unique. The number of security groups that an instance can join is limited. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Limits</a>.</para>
        /// </description></item>
        /// <item><description><para>Specifying this parameter removes the instance from its current security groups. To retain existing security group associations, you must include their IDs in this array.</para>
        /// </description></item>
        /// <item><description><para>You can switch the security group type. However, the specified security groups cannot include both basic and enterprise security groups.</para>
        /// </description></item>
        /// <item><description><para>The security groups must belong to the same VPC as the instance.</para>
        /// </description></item>
        /// <item><description><para>This parameter is not supported for instances in the classic network.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The change takes effect on the instance after a short delay.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7o****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The user data of the instance. User data should be Base64-encoded before it is passed. Note the following when you use this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>The user data must comply with the limits described in <a href="https://help.aliyun.com/document_detail/49121.html">Generate user data</a>.</para>
        /// </description></item>
        /// <item><description><para>After you restart the instance, the new user data is available on the instance but is not executed.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The raw data cannot exceed 32 KB before being encoded. Do not pass confidential information, such as passwords and private keys, in plaintext. If you must pass confidential information, encrypt and then Base64-encode it. On the instance, decrypt the information by using the corresponding decryption method.</para>
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
