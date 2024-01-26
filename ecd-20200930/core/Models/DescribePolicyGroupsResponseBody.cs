// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePolicyGroupsResponseBody : TeaModel {
        /// <summary>
        /// Details of the policies.
        /// </summary>
        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=false)]
        public List<DescribePolicyGroupsResponseBodyDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribePolicyGroupsResponseBodyDescribePolicyGroups : TeaModel {
            [NameInMap("AdminAccess")]
            [Validation(Required=false)]
            public string AdminAccess { get; set; }

            /// <summary>
            /// Indicates whether the anti-screenshot feature is enabled. Valid values:
            /// 
            /// *   on: This feature is enabled.
            /// *   off: This feature is disabled.
            /// 
            /// Default value: off.
            /// </summary>
            [NameInMap("AppContentProtection")]
            [Validation(Required=false)]
            public string AppContentProtection { get; set; }

            /// <summary>
            /// The client CIDR blocks in the whitelist.
            /// </summary>
            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules : TeaModel {
                /// <summary>
                /// The CIDR block that you access from the client. The value is an IPv4 CIDR block.
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// The description of the IPv4 CIDR block.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// The security group rules.
            /// </summary>
            [NameInMap("AuthorizeSecurityPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules> AuthorizeSecurityPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules : TeaModel {
                /// <summary>
                /// The IPv4 CIDR block of the security group rule.
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// The description of the security group rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The protocol type of the security group rule.
                /// 
                /// Valid values:
                /// 
                /// *   tcp: Transmission Control Protocol (TCP)
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   udp: User Datagram Protocol (UDP)
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   all: all protocols
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   gre: Generic Routing Encapsulation (GRE)
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   icmp: ICMP (IPv4)
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// The authorization policy of the security group rule.
                /// 
                /// Valid values:
                /// 
                /// *   drop: denies all access requests.
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   accept: accepts all access requests.
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// The port range of the security group rule.
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// The priority of the security group rule. A smaller value indicates a higher priority.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// The direction of the security group rule.
                /// 
                /// Valid values:
                /// 
                /// *   outflow: outbound
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   inflow: inbound
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// Indicates whether the webcam redirection feature is enabled.
            /// 
            /// Valid values:
            /// 
            /// *   off: The feature is disabled.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   on (default): The feature is enabled.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("CameraRedirect")]
            [Validation(Required=false)]
            public string CameraRedirect { get; set; }

            /// <summary>
            /// The logon methods.
            /// </summary>
            [NameInMap("ClientTypes")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsClientTypes> ClientTypes { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsClientTypes : TeaModel {
                /// <summary>
                /// The client type.
                /// 
                /// Valid values:
                /// 
                /// *   html5: web client
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   linux
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     WUYING hardware client
                /// 
                ///     <!-- -->
                /// 
                /// *   android
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     Android client
                /// 
                ///     <!-- -->
                /// 
                /// *   windows
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     Windows client
                /// 
                ///     <!-- -->
                /// 
                /// *   ios
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     iOS client
                /// 
                ///     <!-- -->
                /// 
                /// *   macos
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     macOS client
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// Indicates whether a specific type of client is allowed to connect to the cloud desktop.
                /// 
                /// Valid values:
                /// 
                /// *   OFF
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     not allowed
                /// 
                ///     <!-- -->
                /// 
                /// *   ON
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     allowed
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The permissions on the clipboard.
            /// 
            /// Valid values:
            /// 
            /// *   read: One-way transfer is allowed.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   readwrite: Two-way transfer is allowed.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   off: Two-way transfer is not allowed.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            [NameInMap("CpuDownGradeDuration")]
            [Validation(Required=false)]
            public int? CpuDownGradeDuration { get; set; }

            [NameInMap("CpuProcessors")]
            [Validation(Required=false)]
            public List<string> CpuProcessors { get; set; }

            [NameInMap("CpuProtectedMode")]
            [Validation(Required=false)]
            public string CpuProtectedMode { get; set; }

            [NameInMap("CpuRateLimit")]
            [Validation(Required=false)]
            public int? CpuRateLimit { get; set; }

            [NameInMap("CpuSampleDuration")]
            [Validation(Required=false)]
            public int? CpuSampleDuration { get; set; }

            [NameInMap("CpuSingleRateLimit")]
            [Validation(Required=false)]
            public int? CpuSingleRateLimit { get; set; }

            /// <summary>
            /// The access control for domain names. The domain names can contain the wildcard character (\*). Multiple domain names are separated by commas (,). Valid values:
            /// 
            /// *   off: This feature is disabled.
            /// *   on: This feature is enabled.
            /// </summary>
            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public string DomainList { get; set; }

            /// <summary>
            /// The resolution of domain names.
            /// </summary>
            [NameInMap("DomainResolveRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsDomainResolveRule> DomainResolveRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsDomainResolveRule : TeaModel {
                /// <summary>
                /// The policy description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// Indicates whether the resolution feature is allowed.
                /// 
                /// *   allow: The feature is allowed.
                /// *   block: The feature is not allowed.
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

            /// <summary>
            /// Indicates whether the switch for domain name resolution is turned on.
            /// 
            /// Valid values:
            /// 
            /// *   off
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   on
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("DomainResolveRuleType")]
            [Validation(Required=false)]
            public string DomainResolveRuleType { get; set; }

            /// <summary>
            /// The number of cloud desktops that are associated with the policy.\
            /// This parameter is returned only if PolicyGroupType is set to CUSTOM.
            /// </summary>
            [NameInMap("EdsCount")]
            [Validation(Required=false)]
            public int? EdsCount { get; set; }

            /// <summary>
            /// Indicates whether the switch for end users to ask for assistance from the administrator is turned on. Valid values: on off
            /// </summary>
            [NameInMap("EndUserApplyAdminCoordinate")]
            [Validation(Required=false)]
            public string EndUserApplyAdminCoordinate { get; set; }

            /// <summary>
            /// The switch for stream collaboration between end users. Valid values: on off
            /// </summary>
            [NameInMap("EndUserGroupCoordinate")]
            [Validation(Required=false)]
            public string EndUserGroupCoordinate { get; set; }

            /// <summary>
            /// Indicates whether the image quality policy is enabled for Graphics cloud desktops. If you have high requirements for desktop performance and user experience, we recommend that you enable this feature. For example, you can enable this feature in professional design scenarios.
            /// 
            /// Valid values:
            /// 
            /// *   off: The feature is disabled.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   on: This feature is enabled.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("GpuAcceleration")]
            [Validation(Required=false)]
            public string GpuAcceleration { get; set; }

            /// <summary>
            /// The HTML5 client access feature.
            /// 
            /// Valid values:
            /// 
            /// *   off (default)
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     disabled
            /// 
            ///     <!-- -->
            /// 
            /// *   on
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     enabled
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Html5Access")]
            [Validation(Required=false)]
            public string Html5Access { get; set; }

            /// <summary>
            /// The file transfer feature for the HTML5 client.
            /// 
            /// Valid values:
            /// 
            /// *   all: Files can be uploaded and downloaded between your computer and HTML5 clients.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   download: Files on HTML5 clients can be downloaded to your computer.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   upload: Files on your computer can be uploaded to HTML5 clients.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   off (default): File transfer between HTML5 clients and your computer is disabled.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            /// <summary>
            /// The protocol that is used for network communication. Valid values:
            /// 
            /// *   TCP: Only the TCP protocol is used.
            /// *   BOTH: The automatic switchover between the TCP protocol and the UDP protocol is supported.
            /// 
            /// Default value: TCP.
            /// </summary>
            [NameInMap("InternetCommunicationProtocol")]
            [Validation(Required=false)]
            public string InternetCommunicationProtocol { get; set; }

            /// <summary>
            /// The permissions on local disk mapping.
            /// 
            /// Valid values:
            /// 
            /// *   read: read-only
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   readwrite: read and write
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   off: no permissions
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            [NameInMap("MemoryDownGradeDuration")]
            [Validation(Required=false)]
            public int? MemoryDownGradeDuration { get; set; }

            [NameInMap("MemoryProcessors")]
            [Validation(Required=false)]
            public List<string> MemoryProcessors { get; set; }

            [NameInMap("MemoryProtectedMode")]
            [Validation(Required=false)]
            public string MemoryProtectedMode { get; set; }

            [NameInMap("MemoryRateLimit")]
            [Validation(Required=false)]
            public int? MemoryRateLimit { get; set; }

            [NameInMap("MemorySampleDuration")]
            [Validation(Required=false)]
            public int? MemorySampleDuration { get; set; }

            [NameInMap("MemorySingleRateLimit")]
            [Validation(Required=false)]
            public int? MemorySingleRateLimit { get; set; }

            /// <summary>
            /// The policy name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether the network redirection feature is enabled. Valid values:
            /// 
            /// *   on: This feature is enabled.
            /// *   off: The feature is disabled.
            /// 
            /// Default value: off.
            /// </summary>
            [NameInMap("NetRedirect")]
            [Validation(Required=false)]
            public string NetRedirect { get; set; }

            /// <summary>
            /// The network redirection rules.
            /// </summary>
            [NameInMap("NetRedirectRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsNetRedirectRule> NetRedirectRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsNetRedirectRule : TeaModel {
                /// <summary>
                /// The content of the rule.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// The rule type.
                /// 
                /// Valid values:
                /// 
                /// *   prc
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     process
                /// 
                ///     <!-- -->
                /// 
                /// *   domain
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     domain name
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

            }

            /// <summary>
            /// The policy ID.
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// The rule type.
            /// 
            /// Valid values:
            /// 
            /// *   SYSTEM
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   CUSTOM
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("PolicyGroupType")]
            [Validation(Required=false)]
            public string PolicyGroupType { get; set; }

            /// <summary>
            /// The state of the policy.
            /// 
            /// Valid values:
            /// 
            /// *   AVAILABLE
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   CREATING
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// Indicates whether user preemption is allowed. The value is fixed to `off`, which indicates that user preemption is not allowed.
            /// </summary>
            [NameInMap("PreemptLogin")]
            [Validation(Required=false)]
            public string PreemptLogin { get; set; }

            /// <summary>
            /// The names of the users that are allowed to connect to the cloud desktop to which another user is logged on.
            /// </summary>
            [NameInMap("PreemptLoginUsers")]
            [Validation(Required=false)]
            public List<string> PreemptLoginUsers { get; set; }

            /// <summary>
            /// The printer redirection feature.
            /// 
            /// Valid values:
            /// 
            /// *   off
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The feature is disabled
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   on
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The feature is enabled
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("PrinterRedirection")]
            [Validation(Required=false)]
            public string PrinterRedirection { get; set; }

            /// <summary>
            /// Indicates whether the custom screen recording feature is enabled. Valid values:
            /// 
            /// *   on: This feature is enabled.
            /// *   off: This feature is disabled.
            /// 
            /// Default value: off.
            /// </summary>
            [NameInMap("RecordContent")]
            [Validation(Required=false)]
            public string RecordContent { get; set; }

            /// <summary>
            /// The duration in which the custom screen recording is valid. Default value: 30. Unit: days.
            /// </summary>
            [NameInMap("RecordContentExpires")]
            [Validation(Required=false)]
            public long? RecordContentExpires { get; set; }

            /// <summary>
            /// Indicates whether screen recording is enabled.
            /// 
            /// Valid values:
            /// 
            /// *   ALLTIME: All operations that are performed by end users on cloud desktops are recorded. The recording starts immediately when end users connect to cloud desktops and ends after the end users disconnect from the cloud desktops.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   PERIOD: The operations that are performed by end users on cloud desktops during a specified period of time are recorded. You must specify the start time and the end time of the recording.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   OFF: Screen recording is disabled.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Recording")]
            [Validation(Required=false)]
            public string Recording { get; set; }

            /// <summary>
            /// Indicates whether the sound that is generated on the cloud desktop is recorded during screen recording. Valid values:
            /// 
            /// *   on: records audio and video data.
            /// *   off: records only video data.
            /// </summary>
            [NameInMap("RecordingAudio")]
            [Validation(Required=false)]
            public string RecordingAudio { get; set; }

            /// <summary>
            /// This parameter is used together with Recording. After the specified period of the recording reaches, a screen recording file is generated.
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// The time when the screen recording ended. The value is in the HH:MM:SS format. The value of this parameter is valid only if Recording is set to PERIOD.
            /// </summary>
            [NameInMap("RecordingEndTime")]
            [Validation(Required=false)]
            public string RecordingEndTime { get; set; }

            /// <summary>
            /// The period in which the screen recording audit is valid. Valid values: 15 to 180. Unit: days.
            /// </summary>
            [NameInMap("RecordingExpires")]
            [Validation(Required=false)]
            public long? RecordingExpires { get; set; }

            /// <summary>
            /// The frame rate of screen recording. Unit: fps. Valid values:
            /// 
            /// *   2
            /// *   5
            /// *   10
            /// *   15
            /// </summary>
            [NameInMap("RecordingFps")]
            [Validation(Required=false)]
            public long? RecordingFps { get; set; }

            /// <summary>
            /// The time when the screen recording was started. The value is in the HH:MM:SS format. The value of this parameter is valid only if Recording is set to PERIOD.
            /// </summary>
            [NameInMap("RecordingStartTime")]
            [Validation(Required=false)]
            public string RecordingStartTime { get; set; }

            [NameInMap("RecordingUserNotify")]
            [Validation(Required=false)]
            public string RecordingUserNotify { get; set; }

            [NameInMap("RecordingUserNotifyMessage")]
            [Validation(Required=false)]
            public string RecordingUserNotifyMessage { get; set; }

            /// <summary>
            /// The permissions on the keyboard and mouse to control the cloud desktop during remote assistance. Valid values:
            /// 
            /// *   fullControl: The keyboard and mouse are fully controlled.
            /// *   optionalControl: By default, you do not have the permissions on the keyboard or mouse to control the cloud desktop during remote assistance. You can apply for the permissions.
            /// *   disableControl: The keyboard and mouse are not controlled.
            /// </summary>
            [NameInMap("RemoteCoordinate")]
            [Validation(Required=false)]
            public string RemoteCoordinate { get; set; }

            /// <summary>
            /// The effective scope of the policy. Valid values:
            /// 
            /// *   GLOBAL: The policy takes effect globally.
            /// *   IP: The policy takes effect based on the IP address.
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// This parameter is specified if Scope is set to IP.
            /// </summary>
            [NameInMap("ScopeValue")]
            [Validation(Required=false)]
            public List<string> ScopeValue { get; set; }

            /// <summary>
            /// Indicates whether the USB redirection feature is enabled.
            /// 
            /// Valid values:
            /// 
            /// *   off: The feature is disabled.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   on: This feature is enabled.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("UsbRedirect")]
            [Validation(Required=false)]
            public string UsbRedirect { get; set; }

            /// <summary>
            /// The USB redirection rules.
            /// </summary>
            [NameInMap("UsbSupplyRedirectRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsUsbSupplyRedirectRule : TeaModel {
                /// <summary>
                /// The rule description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The device class. If you set `UsbRuleType` to 1, you must specify this parameter. For more information, see [Defined Class Codes](https://www.usb.org/defined-class-codes).
                /// </summary>
                [NameInMap("DeviceClass")]
                [Validation(Required=false)]
                public string DeviceClass { get; set; }

                /// <summary>
                /// The device subclass. This parameter is required if `UsbRuleType` is set to 1. For more information, see [Defined Class Codes](https://www.usb.org/defined-class-codes).
                /// </summary>
                [NameInMap("DeviceSubclass")]
                [Validation(Required=false)]
                public string DeviceSubclass { get; set; }

                /// <summary>
                /// The product ID.
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// The USB redirection type.
                /// 
                /// Valid values:
                /// 
                /// *   1: allows USB redirection.
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   2: forbids USB redirection.
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("UsbRedirectType")]
                [Validation(Required=false)]
                public long? UsbRedirectType { get; set; }

                /// <summary>
                /// The type of the USB redirection rule.
                /// 
                /// Valid values:
                /// 
                /// *   1: by device class
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   2: by device vendor
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("UsbRuleType")]
                [Validation(Required=false)]
                public long? UsbRuleType { get; set; }

                /// <summary>
                /// The vendor ID. For more information, see [Valid USB Vendor IDs (VIDs)](https://www.usb.org/sites/default/files/vendor_ids032322.pdf\_1.pdf).
                /// </summary>
                [NameInMap("VendorId")]
                [Validation(Required=false)]
                public string VendorId { get; set; }

            }

            /// <summary>
            /// Indicates whether the multimedia redirection feature is enabled. Valid values: on: The feature is enabled. off: The feature is disabled.
            /// </summary>
            [NameInMap("VideoRedirect")]
            [Validation(Required=false)]
            public string VideoRedirect { get; set; }

            /// <summary>
            /// The image display quality feature.
            /// 
            /// Valid values:
            /// 
            /// *   high
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     high-definition (HD)
            /// 
            ///     <!-- -->
            /// 
            /// *   low
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     fluent
            /// 
            ///     <!-- -->
            /// 
            /// *   medium (default)
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     adaptive
            /// 
            ///     <!-- -->
            /// 
            /// *   lossless
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     no quality loss
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("VisualQuality")]
            [Validation(Required=false)]
            public string VisualQuality { get; set; }

            /// <summary>
            /// Indicates whether the watermark feature is enabled.
            /// 
            /// Valid values:
            /// 
            /// *   off: The feature is disabled.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   on: This feature is enabled.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public string Watermark { get; set; }

            [NameInMap("WatermarkAntiCam")]
            [Validation(Required=false)]
            public string WatermarkAntiCam { get; set; }

            /// <summary>
            /// The font color of the watermark. Valid values: 0 to 16777215.
            /// </summary>
            [NameInMap("WatermarkColor")]
            [Validation(Required=false)]
            public int? WatermarkColor { get; set; }

            /// <summary>
            /// This parameter is unavailable for public use.
            /// </summary>
            [NameInMap("WatermarkCustomText")]
            [Validation(Required=false)]
            public string WatermarkCustomText { get; set; }

            /// <summary>
            /// The inclination angle of the watermark. Valid values: -10 to -30.
            /// </summary>
            [NameInMap("WatermarkDegree")]
            [Validation(Required=false)]
            public double? WatermarkDegree { get; set; }

            /// <summary>
            /// The font size of the watermark. Valid values: 10 to 20.
            /// </summary>
            [NameInMap("WatermarkFontSize")]
            [Validation(Required=false)]
            public int? WatermarkFontSize { get; set; }

            /// <summary>
            /// The font style of the watermark. Valid values:
            /// 
            /// *   plain
            /// *   bold
            /// </summary>
            [NameInMap("WatermarkFontStyle")]
            [Validation(Required=false)]
            public string WatermarkFontStyle { get; set; }

            [NameInMap("WatermarkPower")]
            [Validation(Required=false)]
            public string WatermarkPower { get; set; }

            /// <summary>
            /// The number of watermark rows. This parameter is now invalid.
            /// </summary>
            [NameInMap("WatermarkRowAmount")]
            [Validation(Required=false)]
            public int? WatermarkRowAmount { get; set; }

            [NameInMap("WatermarkSecurity")]
            [Validation(Required=false)]
            public string WatermarkSecurity { get; set; }

            /// <summary>
            /// The watermark transparency.
            /// 
            /// Valid values:
            /// 
            /// *   LIGHT
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   DARK
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   MIDDLE
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("WatermarkTransparency")]
            [Validation(Required=false)]
            public string WatermarkTransparency { get; set; }

            /// <summary>
            /// The watermark transparency. A larger value indicates that the watermark is less transparent. Valid values: 10 to 100.
            /// </summary>
            [NameInMap("WatermarkTransparencyValue")]
            [Validation(Required=false)]
            public int? WatermarkTransparencyValue { get; set; }

            /// <summary>
            /// The watermark type.
            /// 
            /// Valid values:
            /// 
            /// *   HostName,EndUserId: The watermark is displayed in the following format: Rightmost 15 characters of the cloud desktop ID,Username.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   EndUserId: The username is displayed.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   EndUserId,HostName: The watermark is displayed in the following format: Username,Rightmost 15 characters of the cloud desktop ID.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   HostName: The rightmost 15 characters of the cloud desktop ID are displayed.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("WatermarkType")]
            [Validation(Required=false)]
            public string WatermarkType { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
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

    }

}
