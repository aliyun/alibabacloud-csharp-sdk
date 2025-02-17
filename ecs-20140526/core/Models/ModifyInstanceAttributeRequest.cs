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
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            [NameInMap("ThreadsPerCore")]
            [Validation(Required=false)]
            public int? ThreadsPerCore { get; set; }

            /// <summary>
            /// <para>The CPU topology type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ContinuousCoreToHTMapping: The Hyper-Threading (HT) technology allows continuous threads to run on the same core in the CPU topology of the instance.</description></item>
            /// <item><description>DiscreteCoreToHTMapping: The HT technology allows discrete threads to run on the same core.</description></item>
            /// </list>
            /// <para>This parameter is left empty by default.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The instance must be in the Stopped (<c>Stopped</c>) state.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is supported only for specific instance families. For information about the supported instance families, see <a href="https://help.aliyun.com/document_detail/2636059.html">View and modify CPU topologies</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>DiscreteCoreToHTMapping</para>
            /// </summary>
            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

        }

        /// <summary>
        /// <para>The performance mode of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard</description></item>
        /// <item><description>Unlimited</description></item>
        /// </list>
        /// <para>For more information about the performance modes of burstable instances, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The release protection attribute of the instance. This parameter specifies whether you can use the ECS console or call the <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a> operation to release the instance.</para>
        /// <remarks>
        /// <para> This parameter is applicable only to pay-as-you-go instances. The release protection attribute can protect instances against manual releases, but not against automatic releases.</para>
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
        /// <para>Specifies whether to enable the Jumbo Frames feature for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The Jumbo Frame feature is enabled for the instance.</description></item>
        /// <item><description>false: The Jumbo Frame feature is disabled for the instance.</description></item>
        /// </list>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instance must be in the Running (<c>Running</c>) or Stopped (<c>Stopped</c>) state.</description></item>
        /// <item><description>The instance must reside in a VPC.</description></item>
        /// <item><description>After the Jumbo Frames feature is enabled, the MTU value of the instance is set to 8500. After the Jumbo Frames feature is disabled, the MTU value of the instance is set to 1500. You can enable the Jumbo Frames feature only for specific instance types. For more information, see <a href="https://help.aliyun.com/document_detail/200512.html">Jumbo Frames</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableJumboFrame")]
        [Validation(Required=false)]
        public bool? EnableJumboFrame { get; set; }

        /// <summary>
        /// <para>The hostname of the instance. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instance cannot be in the Creating (<c>Pending</c>) or Starting (<c>Starting</c>) state. Otherwise, the new hostname and the configurations in the <c>/etc/hosts</c> file may not take effect. You can call the <a href="https://help.aliyun.com/document_detail/25506.html">DescribeInstances</a> operation to query the status of the instance.</description></item>
        /// <item><description>The parameter takes effect after the instance is restarted. You can restart an instance in the ECS console. For more information, see <a href="https://help.aliyun.com/document_detail/25440.html">Restart an instance</a>. You can also call the <a href="https://help.aliyun.com/document_detail/25502.html">RebootInstance</a> operation to restart the instance. The parameter cannot take effect if you restart an instance within the operating system.</description></item>
        /// </list>
        /// <para>The following limits apply to the hostnames of instances that run different operating systems:</para>
        /// <list type="bullet">
        /// <item><description>For Windows Server, the hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). The hostname cannot start or end with a hyphen (-), contain consecutive hyphens (-), or contain only digits.</description></item>
        /// <item><description>For other operating systems such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate a hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-). The hostname cannot contain consecutive periods (.) or hyphens (-). The hostname cannot start or end with a period (.) or a hyphen (-).</description></item>
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
        /// <para>The name of the instance. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testInstanceName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The number of queues supported by the primary elastic network interface (ENI) of the instance. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instance must be in the Stopped (<c>Stopped</c>) state.</description></item>
        /// <item><description>The number of queues supported by an ENI cannot exceed the maximum number of queues that the instance type allows for each ENI. The total number of queues on all ENIs on the instance cannot exceed the queue quota that the instance type supports. To query the maximum number of queues that an instance type allows for each ENI and the queue quota for the instance type, call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation.</description></item>
        /// <item><description>If you set this parameter to -1, the value is reset to the default value for the instance type. To query the default number of queues of an ENI of each instance type, call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation.</description></item>
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
        /// <para>The password of the instance. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include <em><em>( ) \` ~ ! @ # $ % ^ &amp; \</em> - _ + = | { } [ ] : ; \&quot; &lt; &gt; , . ? /</em>* The password of a Windows instance cannot start with a forward slash (/). Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instance cannot be in the Starting (<c>Starting</c>) state.</description></item>
        /// <item><description>The parameter takes effect after the instance is restarted. You can restart an instance in the ECS console. For more information, see <a href="https://help.aliyun.com/document_detail/25440.html">Restart an instance</a>. You can also call the <a href="https://help.aliyun.com/document_detail/25502.html">RebootInstance</a> operation to restart the instance. The parameter cannot take effect if you restart an instance within the operating system.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For security reasons, we recommend that you use HTTPS to send requests if <c>Password</c> is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The private domain name options of the ECS instance.</para>
        /// <para>For information about private domain name resolution, see <a href="https://help.aliyun.com/document_detail/2844797.html">ECS private DNS resolution</a>.</para>
        /// </summary>
        [NameInMap("PrivateDnsNameOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestPrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
        public class ModifyInstanceAttributeRequestPrivateDnsNameOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether DNS Resolution from the Instance ID-based Hostname to the Instance Primary Private IPv6 Address (AAAA Record) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <para>Specifies whether DNS Resolution from the Instance ID-based Hostname to the Instance Primary Private IPv4 Address (A Record) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <para>Specifies whether DNS Resolution from the IP Address-based Hostname to the Instance Primary Private IPv4 Address (A Record) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <para>Specifies whether Reverse DNS Resolution from the Instance Primary Private IPv4 Address to the IP Address-based Hostname (PTR Record) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <para>The type of the hostname. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Custom: custom hostname.</description></item>
            /// <item><description>IpBased: IP address-based hostname.</description></item>
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
        /// <para> This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("Recyclable")]
        [Validation(Required=false)]
        public bool? Recyclable { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RemoteConnectionOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestRemoteConnectionOptions RemoteConnectionOptions { get; set; }
        public class ModifyInstanceAttributeRequestRemoteConnectionOptions : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
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
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
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
        /// <para>The IDs of the new security groups to which to assign the instance. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The security group IDs in the array cannot be duplicate. The length of the array is related to the quota of security groups to which the instance can be assigned. For more information, see the <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a> section in the &quot;Limits and quotas&quot; topic.</description></item>
        /// <item><description>The instance is moved from the current security groups to the replacement security groups. If you want the instance to remain in the current security groups, add the IDs of the current security groups to the array.</description></item>
        /// <item><description>You can move the instance to security groups of a different type. However, the array cannot contain the IDs of both basic and advanced security groups.</description></item>
        /// <item><description>The security groups and the instance must belong to the same VPC.</description></item>
        /// <item><description>Security groups of instances in the classic network cannot be changed.</description></item>
        /// </list>
        /// <remarks>
        /// <para> New security groups become valid for the instance after a short delay.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7o****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The user data of the instance. We recommend that you encode the data in Base64. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instance must meet the limits for user data. For more information, see <a href="https://help.aliyun.com/document_detail/49121.html">Initialize an instance by using instance user data</a>.</description></item>
        /// <item><description>After you restart the instance, the new user data is displayed but not run as scripts.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The maximum size of the raw data before encoding is 32 KB. We recommend that you do not pass in confidential information such as passwords and private keys in plaintext. If you must pass in confidential information, we recommend that you encrypt and Base64-encode the information before you pass it in. Then, you can decode and decrypt the information in the same way within the instance.</para>
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
