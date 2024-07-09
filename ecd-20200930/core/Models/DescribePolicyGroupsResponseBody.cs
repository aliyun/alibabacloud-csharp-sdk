// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePolicyGroupsResponseBody : TeaModel {
        /// <summary>
        /// The details of the policies.
        /// </summary>
        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=false)]
        public List<DescribePolicyGroupsResponseBodyDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribePolicyGroupsResponseBodyDescribePolicyGroups : TeaModel {
            /// <summary>
            /// Indicates whether users have the administrator permissions after they connect to cloud desktops.
            /// 
            /// >  This parameter is in invitational preview and not available to the public.
            /// </summary>
            [NameInMap("AdminAccess")]
            [Validation(Required=false)]
            public string AdminAccess { get; set; }

            /// <summary>
            /// Indicates whether the anti-screenshot feature is enabled. Valid values:
            /// 
            /// *   on
            /// *   off
            /// 
            /// Default value: off.
            /// </summary>
            [NameInMap("AppContentProtection")]
            [Validation(Required=false)]
            public string AppContentProtection { get; set; }

            /// <summary>
            /// The client CIDR blocks in a whitelist.
            /// </summary>
            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules : TeaModel {
                /// <summary>
                /// The CIDR block that is allowed to access the client. The value is an IPv4 CIDR block.
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// The remarks on the CIDR block that is allowed to access the client.
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
                /// The object to which the security group rule applies. The value is an IPv4 CIDR block.
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
                /// *   udp: User Datagram Protocol (UDP)
                /// *   all: all protocols
                /// *   gre: Generic Routing Encapsulation (GRE)
                /// *   icmp: Internet Control Message Protocol (ICMP) for IPv4
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// The authorization of the security group rule.
                /// 
                /// Valid values:
                /// 
                /// *   drop: denies all access requests.
                /// *   accept: accepts all access requests.
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
                /// *   inflow: inbound
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
            /// *   off
            /// *   on (default)
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
                /// *   linux: Alibaba Cloud Workspace hardware terminal
                /// *   android: Android client
                /// *   windows: Windows client
                /// *   ios: iOS client
                /// *   macos: macOS client
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
                /// *   ON
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
            /// *   readwrite: Two-way transfer is allowed.
            /// *   off: Two-way transfer is not allowed.
            /// </summary>
            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            [NameInMap("ColorEnhancement")]
            [Validation(Required=false)]
            public string ColorEnhancement { get; set; }

            /// <summary>
            /// The CPU underclocking duration. Valid values: 30 to 120.
            /// </summary>
            [NameInMap("CpuDownGradeDuration")]
            [Validation(Required=false)]
            public int? CpuDownGradeDuration { get; set; }

            /// <summary>
            /// The process whitelist that is not restricted by the CPU usage limit.
            /// </summary>
            [NameInMap("CpuProcessors")]
            [Validation(Required=false)]
            public List<string> CpuProcessors { get; set; }

            /// <summary>
            /// Indicates whether the switch for CPU protection mode is turned on. Valid values: on and off.
            /// </summary>
            [NameInMap("CpuProtectedMode")]
            [Validation(Required=false)]
            public string CpuProtectedMode { get; set; }

            /// <summary>
            /// The overall CPU utilization. Valid values: 70 to 90.
            /// </summary>
            [NameInMap("CpuRateLimit")]
            [Validation(Required=false)]
            public int? CpuRateLimit { get; set; }

            /// <summary>
            /// The overall CPU sampling duration. Valid values: 10 to 60.
            /// </summary>
            [NameInMap("CpuSampleDuration")]
            [Validation(Required=false)]
            public int? CpuSampleDuration { get; set; }

            /// <summary>
            /// The usage of a single CPU. Valid values: 70 to 100.
            /// </summary>
            [NameInMap("CpuSingleRateLimit")]
            [Validation(Required=false)]
            public int? CpuSingleRateLimit { get; set; }

            [NameInMap("DisplayMode")]
            [Validation(Required=false)]
            public string DisplayMode { get; set; }

            /// <summary>
            /// Indicates whether the access control for domain names is enabled. The domain names can contain wildcard characters (\\*). Multiple domain names are separated by commas (,). Valid values:
            /// 
            /// *   off
            /// *   on
            /// </summary>
            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public string DomainList { get; set; }

            /// <summary>
            /// The rule of domain name resolution.
            /// </summary>
            [NameInMap("DomainResolveRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsDomainResolveRule> DomainResolveRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsDomainResolveRule : TeaModel {
                /// <summary>
                /// The rule description.
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
                /// Indicates whether the domain name resolution is allowed. Valid values:
                /// 
                /// *   allow
                /// *   block
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
            /// *   on
            /// </summary>
            [NameInMap("DomainResolveRuleType")]
            [Validation(Required=false)]
            public string DomainResolveRuleType { get; set; }

            /// <summary>
            /// The number of cloud desktops that are associated with the policy.\\
            /// This parameter is returned only for custom policies.
            /// </summary>
            [NameInMap("EdsCount")]
            [Validation(Required=false)]
            public int? EdsCount { get; set; }

            /// <summary>
            /// Indicates whether the switch for end users to ask for assistance from the administrator is turned on. Valid values: on and off.
            /// </summary>
            [NameInMap("EndUserApplyAdminCoordinate")]
            [Validation(Required=false)]
            public string EndUserApplyAdminCoordinate { get; set; }

            /// <summary>
            /// Indicates whether the switch for stream collaboration between end users is turned on. Valid values: on and off.
            /// </summary>
            [NameInMap("EndUserGroupCoordinate")]
            [Validation(Required=false)]
            public string EndUserGroupCoordinate { get; set; }

            /// <summary>
            /// Indicates whether the image quality feature is enabled for Graphics cloud desktops. If you have high requirements for desktop performance and user experience, we recommend that you enable this feature. For example, you can enable this feature in professional graphic design scenarios.
            /// 
            /// Valid values:
            /// 
            /// *   off
            /// *   on
            /// </summary>
            [NameInMap("GpuAcceleration")]
            [Validation(Required=false)]
            public string GpuAcceleration { get; set; }

            /// <summary>
            /// Indicates whether the access policy on HTML5 clients is allowed.
            /// 
            /// Valid values:
            /// 
            /// *   off (default)
            /// *   on
            /// </summary>
            [NameInMap("Html5Access")]
            [Validation(Required=false)]
            public string Html5Access { get; set; }

            /// <summary>
            /// The file transfer policy for HTML5 clients.
            /// 
            /// Valid values:
            /// 
            /// *   all: Files can be uploaded and downloaded between your local computer and HTML5 clients.
            /// *   download: Files on HTML5 clients can be downloaded to your local computer.
            /// *   upload: Files on your local computer can be uploaded to HTML5 clients.
            /// *   off (default): File transfer between HTML5 clients and your computer is disabled.
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            /// <summary>
            /// The protocol that is used for network communication. Valid values:
            /// 
            /// *   TCP: Only TCP can be used.
            /// *   BOTH: TCP or UDP can be used. The system switches between TCP and UDP based on the actual network condition.
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
            /// *   readwrite: read and write
            /// *   off: no permissions
            /// </summary>
            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            [NameInMap("MaxReconnectTime")]
            [Validation(Required=false)]
            public int? MaxReconnectTime { get; set; }

            /// <summary>
            /// The duration required for underclocking memory by a single process. Valid values: 30 to 120.
            /// </summary>
            [NameInMap("MemoryDownGradeDuration")]
            [Validation(Required=false)]
            public int? MemoryDownGradeDuration { get; set; }

            /// <summary>
            /// The whitelist of processes that are not restricted by the memory usage limit.
            /// </summary>
            [NameInMap("MemoryProcessors")]
            [Validation(Required=false)]
            public List<string> MemoryProcessors { get; set; }

            /// <summary>
            /// Indicates whether the switch for memory protection mode is turned on. Valid values: on and off.
            /// </summary>
            [NameInMap("MemoryProtectedMode")]
            [Validation(Required=false)]
            public string MemoryProtectedMode { get; set; }

            /// <summary>
            /// The overall memory usage. Valid values: 70 to 90.
            /// </summary>
            [NameInMap("MemoryRateLimit")]
            [Validation(Required=false)]
            public int? MemoryRateLimit { get; set; }

            /// <summary>
            /// The overall sampling duration of memory statistics. Valid values: 30 to 60.
            /// </summary>
            [NameInMap("MemorySampleDuration")]
            [Validation(Required=false)]
            public int? MemorySampleDuration { get; set; }

            /// <summary>
            /// The memory usage of a single process. Valid values: 30 to 60.
            /// </summary>
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
            /// *   on
            /// *   off
            /// 
            /// Default value: off.
            /// 
            /// >  This parameter is in invitational preview and not available to the public.
            /// </summary>
            [NameInMap("NetRedirect")]
            [Validation(Required=false)]
            public string NetRedirect { get; set; }

            /// <summary>
            /// The network redirection rule.
            /// 
            /// >  This parameter is in invitational preview and not available to the public.
            /// </summary>
            [NameInMap("NetRedirectRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsNetRedirectRule> NetRedirectRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsNetRedirectRule : TeaModel {
                /// <summary>
                /// The rule content.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// Indicates whether the rule is allowed.
                /// 
                /// Valid values:
                /// 
                /// *   allow
                /// *   block
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// The rule type.
                /// 
                /// Valid values:
                /// 
                /// *   prc: process
                /// *   domain: domain name
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
            /// The policy type.
            /// 
            /// Valid values:
            /// 
            /// *   SYSTEM
            /// *   CUSTOM
            /// </summary>
            [NameInMap("PolicyGroupType")]
            [Validation(Required=false)]
            public string PolicyGroupType { get; set; }

            /// <summary>
            /// The policy status.
            /// 
            /// Valid values:
            /// 
            /// *   AVAILABLE
            /// *   CREATING
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
            /// Indicates whether the printer redirection feature is enabled.
            /// 
            /// Valid values:
            /// 
            /// *   off
            /// *   on
            /// </summary>
            [NameInMap("PrinterRedirection")]
            [Validation(Required=false)]
            public string PrinterRedirection { get; set; }

            [NameInMap("QualityEnhancement")]
            [Validation(Required=false)]
            public string QualityEnhancement { get; set; }

            /// <summary>
            /// Indicates whether the custom screen recording feature is enabled. Valid values:
            /// 
            /// *   on
            /// *   off
            /// 
            /// Default value: off.
            /// </summary>
            [NameInMap("RecordContent")]
            [Validation(Required=false)]
            public string RecordContent { get; set; }

            /// <summary>
            /// The period when the custom screen recording can be retained before expiration. Default value: 30 days.
            /// </summary>
            [NameInMap("RecordContentExpires")]
            [Validation(Required=false)]
            public long? RecordContentExpires { get; set; }

            /// <summary>
            /// Indicates whether the screen recording feature is enabled.
            /// 
            /// Valid values:
            /// 
            /// *   ALLTIME: All operations that are performed by end users on cloud desktops are recorded. The recording starts immediately when end users connect to cloud desktops and ends after the end users disconnect from the cloud desktops.
            /// *   PERIOD: The operations that are performed by end users on cloud desktops during a specified period of time are recorded. You must specify the start time and the end time of the recording.
            /// *   OFF: The screen recording feature is disabled.
            /// </summary>
            [NameInMap("Recording")]
            [Validation(Required=false)]
            public string Recording { get; set; }

            /// <summary>
            /// Indicates whether to record audio or video data that is generated on the cloud desktop during screen recording. Valid values:
            /// 
            /// *   on: records audio and video data.
            /// *   off: records only video data.
            /// </summary>
            [NameInMap("RecordingAudio")]
            [Validation(Required=false)]
            public string RecordingAudio { get; set; }

            /// <summary>
            /// This parameter is used with the Recording parameter to generate a screen recording file after you specify the duration of screen recording.
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// The time when the screen recording ended. The value is in the HH:MM:SS format. The value takes effect only when Recording is set to PERIOD.
            /// </summary>
            [NameInMap("RecordingEndTime")]
            [Validation(Required=false)]
            public string RecordingEndTime { get; set; }

            /// <summary>
            /// The period in which the screen recording audit is valid. Valid values: 15 to 180. Unit: day.
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
            /// The time when the screen recording was started. The value is in the HH:MM:SS format. The value takes effect only when Recording is set to PERIOD.
            /// </summary>
            [NameInMap("RecordingStartTime")]
            [Validation(Required=false)]
            public string RecordingStartTime { get; set; }

            /// <summary>
            /// Indicates whether the client notification of screen recording is enabled. Valid values: on and off.
            /// </summary>
            [NameInMap("RecordingUserNotify")]
            [Validation(Required=false)]
            public string RecordingUserNotify { get; set; }

            /// <summary>
            /// The notification content of screen recording. By default, this parameter is left empty.
            /// </summary>
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
            /// *   IP: The policy takes effect based on IP addresses.
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// This parameter is required when Scope is set to IP. This parameter takes effect when Scope is set to IP.
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
            /// Indicates whether the USB redirection feature is enabled.
            /// 
            /// Valid values:
            /// 
            /// *   off
            /// *   on
            /// </summary>
            [NameInMap("UsbRedirect")]
            [Validation(Required=false)]
            public string UsbRedirect { get; set; }

            /// <summary>
            /// The USB redirection rule.
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
                /// The device class. This parameter is required when `usbRuleType` is set to 1. For more information, see [Defined Class Codes](https://www.usb.org/defined-class-codes).
                /// </summary>
                [NameInMap("DeviceClass")]
                [Validation(Required=false)]
                public string DeviceClass { get; set; }

                /// <summary>
                /// The subclass of the device. This parameter is required when `usbRuleType` is set to 1. For more information, see [Defined Class Codes](https://www.usb.org/defined-class-codes).
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
                /// Indicates whether USB redirection is allowed.
                /// 
                /// Valid values:
                /// 
                /// *   1: allowed
                /// *   2: not allowed
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
                /// *   2: by device vendor
                /// </summary>
                [NameInMap("UsbRuleType")]
                [Validation(Required=false)]
                public long? UsbRuleType { get; set; }

                /// <summary>
                /// The vendor ID (VID). For more information, see [Valid USB VIDs](https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf).
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
            /// Indicates whether the multimedia redirection feature is enabled. Valid values: on and off.
            /// </summary>
            [NameInMap("VideoRedirect")]
            [Validation(Required=false)]
            public string VideoRedirect { get; set; }

            /// <summary>
            /// The image display quality.
            /// 
            /// Valid values:
            /// 
            /// *   high: high-definition (HD)
            /// *   low: fluent
            /// *   medium (default): adaptive
            /// *   lossless: no quality loss
            /// </summary>
            [NameInMap("VisualQuality")]
            [Validation(Required=false)]
            public string VisualQuality { get; set; }

            /// <summary>
            /// Indicates whether the watermarking feature is enabled.
            /// 
            /// Valid values:
            /// 
            /// *   off
            /// *   on
            /// </summary>
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public string Watermark { get; set; }

            /// <summary>
            /// Indicates whether the anti-screen photo feature is enabled for invisible watermarks. Valid values: on and off.
            /// </summary>
            [NameInMap("WatermarkAntiCam")]
            [Validation(Required=false)]
            public string WatermarkAntiCam { get; set; }

            /// <summary>
            /// The font color in red, green, and blue (RGB) of the watermark. Valid values: 0 to 16777215.
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
            /// The slope of the watermark. Valid values: -10 to -30.
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

            /// <summary>
            /// The invisible watermark enhancement feature. Valid values: low, medium, and high.
            /// </summary>
            [NameInMap("WatermarkPower")]
            [Validation(Required=false)]
            public string WatermarkPower { get; set; }

            /// <summary>
            /// The number of watermark rows. This parameter is now invalid.
            /// </summary>
            [NameInMap("WatermarkRowAmount")]
            [Validation(Required=false)]
            public int? WatermarkRowAmount { get; set; }

            /// <summary>
            /// Indicates whether the security priority for invisible watermarks is enabled. Valid values: on and off.
            /// </summary>
            [NameInMap("WatermarkSecurity")]
            [Validation(Required=false)]
            public string WatermarkSecurity { get; set; }

            /// <summary>
            /// The watermark transparency.
            /// 
            /// Valid values:
            /// 
            /// *   LIGHT
            /// *   DARK
            /// *   MIDDLE
            /// </summary>
            [NameInMap("WatermarkTransparency")]
            [Validation(Required=false)]
            public string WatermarkTransparency { get; set; }

            /// <summary>
            /// The watermark transparency. A greater value indicates that the watermark is less transparent. Valid values: 10 to 100.
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
            /// *   EndUserId: The username is displayed.
            /// *   EndUserId,HostName: The watermark is displayed in the following format: Username,Rightmost 15 characters of the cloud desktop ID.
            /// *   HostName: The rightmost 15 characters of the cloud desktop ID are displayed.
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
