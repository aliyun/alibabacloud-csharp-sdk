// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePolicyGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the policies.</para>
        /// </summary>
        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=false)]
        public List<DescribePolicyGroupsResponseBodyDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribePolicyGroupsResponseBodyDescribePolicyGroups : TeaModel {
            /// <summary>
            /// <para>Indicates whether users have the administrator permissions after they connect to cloud desktops.</para>
            /// <remarks>
            /// <para> This parameter is in invitational preview and not available to the public.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("AdminAccess")]
            [Validation(Required=false)]
            public string AdminAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether the anti-screenshot feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// <para>Default value: off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AppContentProtection")]
            [Validation(Required=false)]
            public string AppContentProtection { get; set; }

            /// <summary>
            /// <para>The client CIDR blocks in a whitelist.</para>
            /// </summary>
            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules : TeaModel {
                /// <summary>
                /// <para>The CIDR block that is allowed to access the client. The value is an IPv4 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX/16</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>The remarks on the CIDR block that is allowed to access the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>The security group rules.</para>
            /// </summary>
            [NameInMap("AuthorizeSecurityPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules> AuthorizeSecurityPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules : TeaModel {
                /// <summary>
                /// <para>The object to which the security group rule applies. The value is an IPv4 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX/16</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>The description of the security group rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The protocol type of the security group rule.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>tcp: Transmission Control Protocol (TCP)</description></item>
                /// <item><description>udp: User Datagram Protocol (UDP)</description></item>
                /// <item><description>all: all protocols</description></item>
                /// <item><description>gre: Generic Routing Encapsulation (GRE)</description></item>
                /// <item><description>icmp: Internet Control Message Protocol (ICMP) for IPv4</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// <para>The authorization of the security group rule.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>drop: denies all access requests.</description></item>
                /// <item><description>accept: accepts all access requests.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accept</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The port range of the security group rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22/22</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>The priority of the security group rule. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// <para>The direction of the security group rule.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>outflow: outbound</description></item>
                /// <item><description>inflow: inbound</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>inflow</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the webcam redirection feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CameraRedirect")]
            [Validation(Required=false)]
            public string CameraRedirect { get; set; }

            /// <summary>
            /// <para>The logon methods.</para>
            /// </summary>
            [NameInMap("ClientTypes")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsClientTypes> ClientTypes { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsClientTypes : TeaModel {
                /// <summary>
                /// <para>The client type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>html5: web client</description></item>
                /// <item><description>linux: Alibaba Cloud Workspace hardware terminal</description></item>
                /// <item><description>android: Android client</description></item>
                /// <item><description>windows: Windows client</description></item>
                /// <item><description>ios: iOS client</description></item>
                /// <item><description>macos: macOS client</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <para>Indicates whether a specific type of client is allowed to connect to the cloud desktop.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OFF</description></item>
                /// <item><description>ON</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The permissions on the clipboard.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>read: One-way transfer is allowed.</description></item>
            /// <item><description>readwrite: Two-way transfer is allowed.</description></item>
            /// <item><description>off: Two-way transfer is not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            [NameInMap("ColorEnhancement")]
            [Validation(Required=false)]
            public string ColorEnhancement { get; set; }

            /// <summary>
            /// <para>The CPU underclocking duration. Valid values: 30 to 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CpuDownGradeDuration")]
            [Validation(Required=false)]
            public int? CpuDownGradeDuration { get; set; }

            /// <summary>
            /// <para>The process whitelist that is not restricted by the CPU usage limit.</para>
            /// </summary>
            [NameInMap("CpuProcessors")]
            [Validation(Required=false)]
            public List<string> CpuProcessors { get; set; }

            /// <summary>
            /// <para>Indicates whether the switch for CPU protection mode is turned on. Valid values: on and off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CpuProtectedMode")]
            [Validation(Required=false)]
            public string CpuProtectedMode { get; set; }

            /// <summary>
            /// <para>The overall CPU utilization. Valid values: 70 to 90.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("CpuRateLimit")]
            [Validation(Required=false)]
            public int? CpuRateLimit { get; set; }

            /// <summary>
            /// <para>The overall CPU sampling duration. Valid values: 10 to 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CpuSampleDuration")]
            [Validation(Required=false)]
            public int? CpuSampleDuration { get; set; }

            /// <summary>
            /// <para>The usage of a single CPU. Valid values: 70 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("CpuSingleRateLimit")]
            [Validation(Required=false)]
            public int? CpuSingleRateLimit { get; set; }

            [NameInMap("DeviceRedirects")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsDeviceRedirects> DeviceRedirects { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsDeviceRedirects : TeaModel {
                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                [NameInMap("RedirectType")]
                [Validation(Required=false)]
                public string RedirectType { get; set; }

            }

            [NameInMap("DeviceRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsDeviceRules> DeviceRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsDeviceRules : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("DevicePid")]
                [Validation(Required=false)]
                public string DevicePid { get; set; }

                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                [NameInMap("DeviceVid")]
                [Validation(Required=false)]
                public string DeviceVid { get; set; }

                [NameInMap("OptCommand")]
                [Validation(Required=false)]
                public string OptCommand { get; set; }

                [NameInMap("RedirectType")]
                [Validation(Required=false)]
                public string RedirectType { get; set; }

            }

            [NameInMap("DisplayMode")]
            [Validation(Required=false)]
            public string DisplayMode { get; set; }

            /// <summary>
            /// <para>Indicates whether the access control for domain names is enabled. The domain names can contain wildcard characters (\*). Multiple domain names are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public string DomainList { get; set; }

            /// <summary>
            /// <para>The rule of domain name resolution.</para>
            /// </summary>
            [NameInMap("DomainResolveRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsDomainResolveRule> DomainResolveRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsDomainResolveRule : TeaModel {
                /// <summary>
                /// <para>The rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>Indicates whether the domain name resolution is allowed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>allow</description></item>
                /// <item><description>block</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the switch for domain name resolution is turned on.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("DomainResolveRuleType")]
            [Validation(Required=false)]
            public string DomainResolveRuleType { get; set; }

            /// <summary>
            /// <para>The number of cloud desktops that are associated with the policy.\
            /// This parameter is returned only for custom policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EdsCount")]
            [Validation(Required=false)]
            public int? EdsCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the switch for end users to ask for assistance from the administrator is turned on. Valid values: on and off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("EndUserApplyAdminCoordinate")]
            [Validation(Required=false)]
            public string EndUserApplyAdminCoordinate { get; set; }

            /// <summary>
            /// <para>Indicates whether the switch for stream collaboration between end users is turned on. Valid values: on and off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("EndUserGroupCoordinate")]
            [Validation(Required=false)]
            public string EndUserGroupCoordinate { get; set; }

            /// <summary>
            /// <para>Indicates whether the image quality feature is enabled for Graphics cloud desktops. If you have high requirements for desktop performance and user experience, we recommend that you enable this feature. For example, you can enable this feature in professional graphic design scenarios.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("GpuAcceleration")]
            [Validation(Required=false)]
            public string GpuAcceleration { get; set; }

            /// <summary>
            /// <para>Indicates whether the access policy on HTML5 clients is allowed.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off (default)</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Html5Access")]
            [Validation(Required=false)]
            public string Html5Access { get; set; }

            /// <summary>
            /// <para>The file transfer policy for HTML5 clients.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>all: Files can be uploaded and downloaded between your local computer and HTML5 clients.</description></item>
            /// <item><description>download: Files on HTML5 clients can be downloaded to your local computer.</description></item>
            /// <item><description>upload: Files on your local computer can be uploaded to HTML5 clients.</description></item>
            /// <item><description>off (default): File transfer between HTML5 clients and your computer is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            /// <summary>
            /// <para>The protocol that is used for network communication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP: Only TCP can be used.</description></item>
            /// <item><description>BOTH: TCP or UDP can be used. The system switches between TCP and UDP based on the actual network condition.</description></item>
            /// </list>
            /// <para>Default value: TCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BOTH</para>
            /// </summary>
            [NameInMap("InternetCommunicationProtocol")]
            [Validation(Required=false)]
            public string InternetCommunicationProtocol { get; set; }

            /// <summary>
            /// <para>The permissions on local disk mapping.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>read: read-only</description></item>
            /// <item><description>readwrite: read and write</description></item>
            /// <item><description>off: no permissions</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            [NameInMap("MaxReconnectTime")]
            [Validation(Required=false)]
            public int? MaxReconnectTime { get; set; }

            /// <summary>
            /// <para>The duration required for underclocking memory by a single process. Valid values: 30 to 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemoryDownGradeDuration")]
            [Validation(Required=false)]
            public int? MemoryDownGradeDuration { get; set; }

            /// <summary>
            /// <para>The whitelist of processes that are not restricted by the memory usage limit.</para>
            /// </summary>
            [NameInMap("MemoryProcessors")]
            [Validation(Required=false)]
            public List<string> MemoryProcessors { get; set; }

            /// <summary>
            /// <para>Indicates whether the switch for memory protection mode is turned on. Valid values: on and off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("MemoryProtectedMode")]
            [Validation(Required=false)]
            public string MemoryProtectedMode { get; set; }

            /// <summary>
            /// <para>The overall memory usage. Valid values: 70 to 90.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("MemoryRateLimit")]
            [Validation(Required=false)]
            public int? MemoryRateLimit { get; set; }

            /// <summary>
            /// <para>The overall sampling duration of memory statistics. Valid values: 30 to 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemorySampleDuration")]
            [Validation(Required=false)]
            public int? MemorySampleDuration { get; set; }

            /// <summary>
            /// <para>The memory usage of a single process. Valid values: 30 to 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemorySingleRateLimit")]
            [Validation(Required=false)]
            public int? MemorySingleRateLimit { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testPolicyGroupName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the network redirection feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// <para>Default value: off.</para>
            /// <remarks>
            /// <para> This parameter is in invitational preview and not available to the public.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("NetRedirect")]
            [Validation(Required=false)]
            public string NetRedirect { get; set; }

            /// <summary>
            /// <para>The network redirection rule.</para>
            /// <remarks>
            /// <para> This parameter is in invitational preview and not available to the public.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("NetRedirectRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsNetRedirectRule> NetRedirectRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsNetRedirectRule : TeaModel {
                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is allowed.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>allow</description></item>
                /// <item><description>block</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The rule type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>prc: process</description></item>
                /// <item><description>domain: domain name</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>domain</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

            }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-gx2x1dhsmthe9****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM</description></item>
            /// <item><description>CUSTOM</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("PolicyGroupType")]
            [Validation(Required=false)]
            public string PolicyGroupType { get; set; }

            /// <summary>
            /// <para>The policy status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AVAILABLE</description></item>
            /// <item><description>CREATING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether user preemption is allowed. The value is fixed to <c>off</c>, which indicates that user preemption is not allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("PreemptLogin")]
            [Validation(Required=false)]
            public string PreemptLogin { get; set; }

            /// <summary>
            /// <para>The names of the users that are allowed to connect to the cloud desktop to which another user is logged on.</para>
            /// </summary>
            [NameInMap("PreemptLoginUsers")]
            [Validation(Required=false)]
            public List<string> PreemptLoginUsers { get; set; }

            /// <summary>
            /// <para>Indicates whether the printer redirection feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("PrinterRedirection")]
            [Validation(Required=false)]
            public string PrinterRedirection { get; set; }

            [NameInMap("QualityEnhancement")]
            [Validation(Required=false)]
            public string QualityEnhancement { get; set; }

            /// <summary>
            /// <para>Indicates whether the custom screen recording feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// <para>Default value: off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordContent")]
            [Validation(Required=false)]
            public string RecordContent { get; set; }

            /// <summary>
            /// <para>The period when the custom screen recording can be retained before expiration. Default value: 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RecordContentExpires")]
            [Validation(Required=false)]
            public long? RecordContentExpires { get; set; }

            /// <summary>
            /// <para>Indicates whether the screen recording feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALLTIME: All operations that are performed by end users on cloud desktops are recorded. The recording starts immediately when end users connect to cloud desktops and ends after the end users disconnect from the cloud desktops.</description></item>
            /// <item><description>PERIOD: The operations that are performed by end users on cloud desktops during a specified period of time are recorded. You must specify the start time and the end time of the recording.</description></item>
            /// <item><description>OFF: The screen recording feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OFF</para>
            /// </summary>
            [NameInMap("Recording")]
            [Validation(Required=false)]
            public string Recording { get; set; }

            /// <summary>
            /// <para>Indicates whether to record audio or video data that is generated on the cloud desktop during screen recording. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: records audio and video data.</description></item>
            /// <item><description>off: records only video data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RecordingAudio")]
            [Validation(Required=false)]
            public string RecordingAudio { get; set; }

            /// <summary>
            /// <para>This parameter is used with the Recording parameter to generate a screen recording file after you specify the duration of screen recording.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// <para>The time when the screen recording ended. The value is in the HH:MM:SS format. The value takes effect only when Recording is set to PERIOD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:59:00</para>
            /// </summary>
            [NameInMap("RecordingEndTime")]
            [Validation(Required=false)]
            public string RecordingEndTime { get; set; }

            /// <summary>
            /// <para>The period in which the screen recording audit is valid. Valid values: 15 to 180. Unit: day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("RecordingExpires")]
            [Validation(Required=false)]
            public long? RecordingExpires { get; set; }

            /// <summary>
            /// <para>The frame rate of screen recording. Unit: fps. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2</description></item>
            /// <item><description>5</description></item>
            /// <item><description>10</description></item>
            /// <item><description>15</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecordingFps")]
            [Validation(Required=false)]
            public long? RecordingFps { get; set; }

            /// <summary>
            /// <para>The time when the screen recording was started. The value is in the HH:MM:SS format. The value takes effect only when Recording is set to PERIOD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00:00</para>
            /// </summary>
            [NameInMap("RecordingStartTime")]
            [Validation(Required=false)]
            public string RecordingStartTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the client notification of screen recording is enabled. Valid values: on and off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordingUserNotify")]
            [Validation(Required=false)]
            public string RecordingUserNotify { get; set; }

            /// <summary>
            /// <para>The notification content of screen recording. By default, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Your desktop is being recorded</para>
            /// </summary>
            [NameInMap("RecordingUserNotifyMessage")]
            [Validation(Required=false)]
            public string RecordingUserNotifyMessage { get; set; }

            /// <summary>
            /// <para>The permissions on the keyboard and mouse to control the cloud desktop during remote assistance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>fullControl: The keyboard and mouse are fully controlled.</description></item>
            /// <item><description>optionalControl: By default, you do not have the permissions on the keyboard or mouse to control the cloud desktop during remote assistance. You can apply for the permissions.</description></item>
            /// <item><description>disableControl: The keyboard and mouse are not controlled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fullControl</para>
            /// </summary>
            [NameInMap("RemoteCoordinate")]
            [Validation(Required=false)]
            public string RemoteCoordinate { get; set; }

            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <para>The effective scope of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GLOBAL: The policy takes effect globally.</description></item>
            /// <item><description>IP: The policy takes effect based on IP addresses.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GLOBAL</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>This parameter is required when Scope is set to IP. This parameter takes effect when Scope is set to IP.</para>
            /// </summary>
            [NameInMap("ScopeValue")]
            [Validation(Required=false)]
            public List<string> ScopeValue { get; set; }

            [NameInMap("SmoothEnhancement")]
            [Validation(Required=false)]
            public string SmoothEnhancement { get; set; }

            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            [NameInMap("TargetFps")]
            [Validation(Required=false)]
            public int? TargetFps { get; set; }

            /// <summary>
            /// <para>Indicates whether the USB redirection feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("UsbRedirect")]
            [Validation(Required=false)]
            public string UsbRedirect { get; set; }

            /// <summary>
            /// <para>The USB redirection rule.</para>
            /// </summary>
            [NameInMap("UsbSupplyRedirectRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsUsbSupplyRedirectRule : TeaModel {
                /// <summary>
                /// <para>The rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The device class. This parameter is required when <c>usbRuleType</c> is set to 1. For more information, see <a href="https://www.usb.org/defined-class-codes">Defined Class Codes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0Eh</para>
                /// </summary>
                [NameInMap("DeviceClass")]
                [Validation(Required=false)]
                public string DeviceClass { get; set; }

                /// <summary>
                /// <para>The subclass of the device. This parameter is required when <c>usbRuleType</c> is set to 1. For more information, see <a href="https://www.usb.org/defined-class-codes">Defined Class Codes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxh</para>
                /// </summary>
                [NameInMap("DeviceSubclass")]
                [Validation(Required=false)]
                public string DeviceSubclass { get; set; }

                /// <summary>
                /// <para>The product ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>08**</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <para>Indicates whether USB redirection is allowed.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: allowed</description></item>
                /// <item><description>2: not allowed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UsbRedirectType")]
                [Validation(Required=false)]
                public long? UsbRedirectType { get; set; }

                /// <summary>
                /// <para>The type of the USB redirection rule.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: by device class</description></item>
                /// <item><description>2: by device vendor</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UsbRuleType")]
                [Validation(Required=false)]
                public long? UsbRuleType { get; set; }

                /// <summary>
                /// <para>The vendor ID (VID). For more information, see <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB VIDs</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>04**</para>
                /// </summary>
                [NameInMap("VendorId")]
                [Validation(Required=false)]
                public string VendorId { get; set; }

            }

            [NameInMap("VideoEncAvgKbps")]
            [Validation(Required=false)]
            public int? VideoEncAvgKbps { get; set; }

            [NameInMap("VideoEncMaxQP")]
            [Validation(Required=false)]
            public int? VideoEncMaxQP { get; set; }

            [NameInMap("VideoEncMinQP")]
            [Validation(Required=false)]
            public int? VideoEncMinQP { get; set; }

            [NameInMap("VideoEncPeakKbps")]
            [Validation(Required=false)]
            public int? VideoEncPeakKbps { get; set; }

            [NameInMap("VideoEncPolicy")]
            [Validation(Required=false)]
            public string VideoEncPolicy { get; set; }

            /// <summary>
            /// <para>Indicates whether the multimedia redirection feature is enabled. Valid values: on and off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("VideoRedirect")]
            [Validation(Required=false)]
            public string VideoRedirect { get; set; }

            /// <summary>
            /// <para>The image display quality.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>high: high-definition (HD)</description></item>
            /// <item><description>low: fluent</description></item>
            /// <item><description>medium (default): adaptive</description></item>
            /// <item><description>lossless: no quality loss</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("VisualQuality")]
            [Validation(Required=false)]
            public string VisualQuality { get; set; }

            /// <summary>
            /// <para>Indicates whether the watermarking feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public string Watermark { get; set; }

            /// <summary>
            /// <para>Indicates whether the anti-screen photo feature is enabled for invisible watermarks. Valid values: on and off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("WatermarkAntiCam")]
            [Validation(Required=false)]
            public string WatermarkAntiCam { get; set; }

            /// <summary>
            /// <para>The font color in red, green, and blue (RGB) of the watermark. Valid values: 0 to 16777215.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WatermarkColor")]
            [Validation(Required=false)]
            public int? WatermarkColor { get; set; }

            /// <summary>
            /// <para>This parameter is unavailable for public use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WatermarkCustomText")]
            [Validation(Required=false)]
            public string WatermarkCustomText { get; set; }

            /// <summary>
            /// <para>The slope of the watermark. Valid values: -10 to -30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-10</para>
            /// </summary>
            [NameInMap("WatermarkDegree")]
            [Validation(Required=false)]
            public double? WatermarkDegree { get; set; }

            /// <summary>
            /// <para>The font size of the watermark. Valid values: 10 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WatermarkFontSize")]
            [Validation(Required=false)]
            public int? WatermarkFontSize { get; set; }

            /// <summary>
            /// <para>The font style of the watermark. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>plain</description></item>
            /// <item><description>bold</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>plain</para>
            /// </summary>
            [NameInMap("WatermarkFontStyle")]
            [Validation(Required=false)]
            public string WatermarkFontStyle { get; set; }

            /// <summary>
            /// <para>The invisible watermark enhancement feature. Valid values: low, medium, and high.</para>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("WatermarkPower")]
            [Validation(Required=false)]
            public string WatermarkPower { get; set; }

            /// <summary>
            /// <para>The number of watermark rows. This parameter is now invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("WatermarkRowAmount")]
            [Validation(Required=false)]
            public int? WatermarkRowAmount { get; set; }

            /// <summary>
            /// <para>Indicates whether the security priority for invisible watermarks is enabled. Valid values: on and off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("WatermarkSecurity")]
            [Validation(Required=false)]
            public string WatermarkSecurity { get; set; }

            /// <summary>
            /// <para>The watermark transparency.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LIGHT</description></item>
            /// <item><description>DARK</description></item>
            /// <item><description>MIDDLE</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LIGHT</para>
            /// </summary>
            [NameInMap("WatermarkTransparency")]
            [Validation(Required=false)]
            public string WatermarkTransparency { get; set; }

            /// <summary>
            /// <para>The watermark transparency. A greater value indicates that the watermark is less transparent. Valid values: 10 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WatermarkTransparencyValue")]
            [Validation(Required=false)]
            public int? WatermarkTransparencyValue { get; set; }

            /// <summary>
            /// <para>The watermark type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HostName,EndUserId: The watermark is displayed in the following format: Rightmost 15 characters of the cloud desktop ID,Username.</description></item>
            /// <item><description>EndUserId: The username is displayed.</description></item>
            /// <item><description>EndUserId,HostName: The watermark is displayed in the following format: Username,Rightmost 15 characters of the cloud desktop ID.</description></item>
            /// <item><description>HostName: The rightmost 15 characters of the cloud desktop ID are displayed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EndUserId</para>
            /// </summary>
            [NameInMap("WatermarkType")]
            [Validation(Required=false)]
            public string WatermarkType { get; set; }

            [NameInMap("WyAssistant")]
            [Validation(Required=false)]
            public string WyAssistant { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
