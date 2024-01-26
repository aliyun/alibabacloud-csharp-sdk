// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyPolicyGroupRequest : TeaModel {
        [NameInMap("AdminAccess")]
        [Validation(Required=false)]
        public string AdminAccess { get; set; }

        /// <summary>
        /// Specifies whether to enable the anti-screenshot feature. Valid values:
        /// 
        /// * on
        /// * off
        /// 
        /// Default value: off.
        /// </summary>
        [NameInMap("AppContentProtection")]
        [Validation(Required=false)]
        public string AppContentProtection { get; set; }

        /// <summary>
        /// The client CIDR blocks in the whitelist.
        /// </summary>
        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestAuthorizeAccessPolicyRule : TeaModel {
            /// <summary>
            /// The CIDR block that the client can access.
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// The description of the client IP address whitelist.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// The security group rules.
        /// </summary>
        [NameInMap("AuthorizeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestAuthorizeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// The object to which the security group rule applies. The value is an IPv4 CIDR block.
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// The description of security group rule N.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The protocol type of security group rule N. Valid values:
            /// 
            /// *   tcp: TCP
            /// *   udp: UDP
            /// *   icmp: ICMP (IPv4)
            /// *   gre: GRE
            /// *   all: all protocols
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// The authorization policy of security group rule N. Valid values:
            /// 
            /// *   accept: specifies the Allow policy that allows all access requests.
            /// *   drop: specifies the Deny policy that denies all access requests. If no messages of access denied are returned, the requests time out or failed.
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The port range of security group rule N. The value of the port range is determined by the protocol type specified by the AuthorizeSecurityPolicyRule.N.IpProtocol parameter.
            /// 
            /// *   When the AuthorizeSecurityPolicyRule.N.IpProtocol parameter is set to tcp or udp, the port range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.
            /// *   When AuthorizeSecurityPolicyRule.N.IpProtocol is set to icmp, set the value to -1/-1.
            /// *   When AuthorizeSecurityPolicyRule.N.IpProtocol is set to gre, set the value to -1/-1.
            /// *   When AuthorizeSecurityPolicyRule.N.IpProtocol is set to all, set the value to -1/-1.
            /// 
            /// For more information about the common ports of typical applications, see [Common ports](~~40724~~).
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// The priority of security group rule N. A smaller value indicates a higher priority.
            /// 
            /// Valid values: 1 to 60.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// The direction of security group rule N. Valid values:
            /// 
            /// *   inflow: inbound
            /// *   outflow: outbound
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable the webcam redirection feature. Valid values:
        /// 
        /// * on
        /// * off
        /// 
        /// Default value: on.
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// The logon methods.
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestClientType> ClientType { get; set; }
        public class ModifyPolicyGroupRequestClientType : TeaModel {
            /// <summary>
            /// The type of client that you want to use to connect to the cloud desktop. Valid values:
            /// 
            /// * windows: the Windows client
            /// * linux: C-Key Series Cloud Computer TC and A Series Cloud Computer TC
            /// * macos: the macOS client
            /// * ios: the iOS client
            /// * android: the Android client
            /// * html5: the web client
            /// 
            /// > By default, if you do not configure the ClientType-related parameters, all types of clients are allowed to connect to the cloud desktop.
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// The logon method. This parameter specifies whether a specific type of the client is allowed to connect to the cloud desktop. Valid values:
            /// 
            /// * on: allowed.
            /// * off: disallowed.
            /// 
            /// > By default, if you do not configure the ClientType-related parameters, all types of clients are allowed to log on to cloud desktops.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The permissions on clipboards. Valid values:
        /// 
        /// *   read: specifies one-way transfer. You can copy data from your computer to cloud desktops, but cannot copy data from cloud desktops to your computer.
        /// *   readwrite: specifies two-way transfer. You can copy data between your computer and cloud desktops.
        /// *   off: specifies that the two-way transfer is disabled. You cannot copy data between your computer and cloud desktops.
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        /// <summary>
        /// The domain blacklist or whitelist. Wildcard domains are supported. Separate domain names with commas (,). Valid values:
        /// 
        /// *   \[black:],example1.com,example2.com: the domain name blacklist.
        /// *   \[white:],example1.com,example2.com: the domain name whitelist.
        /// </summary>
        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public string DomainList { get; set; }

        /// <summary>
        /// The details of the DNS rule.
        /// </summary>
        [NameInMap("DomainResolveRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestDomainResolveRule> DomainResolveRule { get; set; }
        public class ModifyPolicyGroupRequestDomainResolveRule : TeaModel {
            /// <summary>
            /// The description of the DNS rule.
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
            /// Specifies whether to allow the DNS rule.
            /// 
            /// Valid values:
            /// 
            /// *   allow
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   block
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

        }

        /// <summary>
        /// The DNS rule type.
        /// </summary>
        [NameInMap("DomainResolveRuleType")]
        [Validation(Required=false)]
        public string DomainResolveRuleType { get; set; }

        /// <summary>
        /// The user applies for the administrator assistance switch. Value range: 
        /// * on 
        /// * off
        /// </summary>
        [NameInMap("EndUserApplyAdminCoordinate")]
        [Validation(Required=false)]
        public string EndUserApplyAdminCoordinate { get; set; }

        /// <summary>
        /// The flow collaboration switch between users. Value range: 
        /// * on 
        /// * off
        /// </summary>
        [NameInMap("EndUserGroupCoordinate")]
        [Validation(Required=false)]
        public string EndUserGroupCoordinate { get; set; }

        /// <summary>
        /// Specifies whether to enable the image display quality feature for the Graphics cloud desktop. If your business requires high desktop performance and optimal user experience, we recommend that you enable this feature. For example, you can enable this policy in professional design scenarios. Valid values:
        /// 
        /// * on
        /// * off
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public string GpuAcceleration { get; set; }

        /// <summary>
        /// Specifies whether to allow the access from HTM5 clients to a cloud desktop. Valid values:
        /// 
        /// *   on: allows the access.
        /// *   off: denies the access.
        /// 
        /// Default value: off.
        /// 
        /// >  We recommend that you use the ClientType-related parameters to control the EDS client type for cloud desktop logon.
        /// </summary>
        [NameInMap("Html5Access")]
        [Validation(Required=false)]
        public string Html5Access { get; set; }

        /// <summary>
        /// The file transfer policy for HTML5 clients. Valid values:
        /// 
        /// *   off: Files cannot be uploaded from or downloaded to HTML5 clients.
        /// *   upload: Files can be uploaded from HTML5 clients.
        /// *   download: Files can be downloaded to HTML5 clients.
        /// *   all: Files can be uploaded from and downloaded to HTML5 clients.
        /// 
        /// Default value: off.
        /// </summary>
        [NameInMap("Html5FileTransfer")]
        [Validation(Required=false)]
        public string Html5FileTransfer { get; set; }

        /// <summary>
        /// The protocol that you want to use for network communication. Valid values:
        /// 
        /// * TCP: Only the TCP protocol is used.
        /// * BOTH: allows automatic switchover between the TCP protocol and the UDP protocol.
        /// 
        /// Default value: TCP.
        /// </summary>
        [NameInMap("InternetCommunicationProtocol")]
        [Validation(Required=false)]
        public string InternetCommunicationProtocol { get; set; }

        /// <summary>
        /// The permissions on local disk mapping. Valid values:
        /// 
        /// *   read: read-only permissions. Local disks are mapped to cloud desktops. You can only read (copy) local files but cannot modify them.
        /// *   readwrite: read and write permissions. Local disks are mapped to cloud desktops. You can read (copy) and modify local files.
        /// *   off: no permissions. Local disks are not mapped to cloud desktops.
        /// </summary>
        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        /// <summary>
        /// The name of the policy.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The network redirection feature. Valid values:
        /// 
        /// * on
        /// * off
        /// 
        /// Default value: off.
        /// </summary>
        [NameInMap("NetRedirect")]
        [Validation(Required=false)]
        public string NetRedirect { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// Specifies whether to allow user preemption. Default value: off. You cannot change the value.
        /// </summary>
        [NameInMap("PreemptLogin")]
        [Validation(Required=false)]
        public string PreemptLogin { get; set; }

        /// <summary>
        /// The names of the users that are allowed to connect to the same cloud desktop at the same time. You can specify up to five usernames.
        /// 
        /// > To improve user experience and ensure data security, multiple end users cannot connect to the same cloud desktop at the same time.
        /// </summary>
        [NameInMap("PreemptLoginUser")]
        [Validation(Required=false)]
        public List<string> PreemptLoginUser { get; set; }

        /// <summary>
        /// Specifies whether to enable printer redirection. Valid values:
        /// 
        /// *   off: disables printer redirection.
        /// *   on: enables printer redirection.
        /// </summary>
        [NameInMap("PrinterRedirection")]
        [Validation(Required=false)]
        public string PrinterRedirection { get; set; }

        /// <summary>
        /// Specifies whether to enable the custom screen recording feature. Valid values:
        /// 
        /// * on
        /// * off
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
        /// Specifies whether to enable screen recording. Valid values:
        /// 
        /// * OFF: disabled.
        /// * ALLTIME: All operations that are performed by an end user on the cloud desktop are recorded. The recording immediately starts when the end user connects to the cloud desktop and ends after the end user disconnects from the cloud desktop.
        /// * PERIOD: The operations that are performed by an end user on the cloud desktop during a specific period of time are recorded. You must specify the start time and the end time of the recording.
        /// </summary>
        [NameInMap("Recording")]
        [Validation(Required=false)]
        public string Recording { get; set; }

        /// <summary>
        /// Specifies whether to record the sound that is generated on the cloud desktop during screen recording. Valid values:
        /// 
        /// * on
        /// * off
        /// </summary>
        [NameInMap("RecordingAudio")]
        [Validation(Required=false)]
        public string RecordingAudio { get; set; }

        /// <summary>
        /// This parameter takes effect based on the Recording-related parameters. You can specify a time range for screen recording, and recording files are generated after the specified end time is reached.
        /// </summary>
        [NameInMap("RecordingDuration")]
        [Validation(Required=false)]
        public int? RecordingDuration { get; set; }

        /// <summary>
        /// The time when the screen recording ends. Specify the value in the HH:MM:SS format. The value is valid only when you set the Recording parameter to PERIOD.
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
        /// * 2
        /// * 5
        /// * 10
        /// * 15
        /// </summary>
        [NameInMap("RecordingFps")]
        [Validation(Required=false)]
        public long? RecordingFps { get; set; }

        /// <summary>
        /// The time when the screen recording starts. Specify the value in the HH:MM:SS format. The value is valid only when you set the Recording parameter to PERIOD.
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
        /// The ID of the region where the cloud desktop resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The permissions on the keyboard and mouse to control the cloud desktop during remote assistance. Valid values:
        /// 
        /// * fullControl: The keyboard and mouse can be fully controlled.
        /// * optionalControl: By default, this feature is disabled. You can apply for permissions to enable the feature.
        /// * disableControl: The keyboard and mouse cannot be controlled.
        /// </summary>
        [NameInMap("RemoteCoordinate")]
        [Validation(Required=false)]
        public string RemoteCoordinate { get; set; }

        /// <summary>
        /// The security group rules that you want to delete.
        /// </summary>
        [NameInMap("RevokeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestRevokeAccessPolicyRule> RevokeAccessPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestRevokeAccessPolicyRule : TeaModel {
            /// <summary>
            /// The IPv4 CIDR block that can be accessed from the client.
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// The description of the client IP address whitelist that you want to delete.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// The security group rules that you want to delete.
        /// </summary>
        [NameInMap("RevokeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestRevokeSecurityPolicyRule> RevokeSecurityPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestRevokeSecurityPolicyRule : TeaModel {
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
            /// The protocol type of the security group rule. Valid values:
            /// 
            /// * TCP
            /// * UDP
            /// * ICMP: ICMP (IPv4)
            /// * GRE
            /// * ALL
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// The authorization policy of the security group rule that you want to delete. Valid values:
            /// 
            /// * accept: allows all access requests.
            /// * drop: disallows all access requests. If no denied messages are returned, the requests timed out or failed.
            /// 
            /// Default value: accept.
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The port range of the security group rule that you want to delete. The value of the port range is determined by the protocol type specified by the IpProtocol parameter.
            /// 
            /// * If the IpProtocol parameter is set to TCP or UDP, the port range is 1 to 65535. The start port number and the end port number are separated by a forward slash (/). Example: 1/200.
            /// * If the IpProtocol parameter is set to ICMP, the port range is -1/-1.
            /// * If the IpProtocol parameter is set to GRE, the port range is -1/-1.
            /// * If the IpProtocol parameter is set to ALL, the port range is -1/-1.
            /// 
            /// For more information about the common ports of typical applications, see [Common ports](https://www.alibabacloud.com/help/en/ecs/user-guide/common-ports?spm=a2c63.p38356.0.0.56b87f2c2SJTAw).
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// The priority of the security group rule. A smaller value indicates a higher priority.
            /// 
            /// Valid values: 1 to 60.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// The direction of the security group rule that you want to delete. Valid values:
            /// 
            /// * inflow: inbound
            /// * outflow: outbound
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The effective scope of the policy. Valid values:
        /// 
        /// * GLOBAL: takes effect globally.
        /// * IP: takes effect based on the IP address.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// This parameter is required when the Scope parameter is set to IP.
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public List<string> ScopeValue { get; set; }

        /// <summary>
        /// Specifies whether to enable USB redirection. Valid values:
        /// 
        /// *   on: enables USB redirection.
        /// *   off: disables USB redirection.
        /// </summary>
        [NameInMap("UsbRedirect")]
        [Validation(Required=false)]
        public string UsbRedirect { get; set; }

        /// <summary>
        /// The USB redirection rules.
        /// </summary>
        [NameInMap("UsbSupplyRedirectRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
        public class ModifyPolicyGroupRequestUsbSupplyRedirectRule : TeaModel {
            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The class of the device. This parameter is required when you set the usbRuleType parameter to 1. For more information, see [Defined Class Codes](https://www.usb.org/defined-class-codes?spm=a2c63.p38356.0.0.56b84b03GUn4kJ).
            /// </summary>
            [NameInMap("DeviceClass")]
            [Validation(Required=false)]
            public string DeviceClass { get; set; }

            /// <summary>
            /// The subclass of the device. This parameter is required when you set the usbRuleType parameter to 1. For more information, see [Defined Class Codes](https://www.usb.org/defined-class-codes?spm=a2c63.p38356.0.0.56b84b03GUn4kJ).
            /// </summary>
            [NameInMap("DeviceSubclass")]
            [Validation(Required=false)]
            public string DeviceSubclass { get; set; }

            /// <summary>
            /// The ID of the service.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// Specifies whether to allow USB redirection. Valid values:
            /// 
            /// * 1: allowed.
            /// * 2: disallowed.
            /// </summary>
            [NameInMap("UsbRedirectType")]
            [Validation(Required=false)]
            public long? UsbRedirectType { get; set; }

            /// <summary>
            /// The type of the USB redirection rule. Valid values:
            /// 
            /// * 1: device class.
            /// * 2: device vendor.
            /// </summary>
            [NameInMap("UsbRuleType")]
            [Validation(Required=false)]
            public long? UsbRuleType { get; set; }

            /// <summary>
            /// The ID of the vendor. For more information, see[ Valid USB Vendor IDs (VIDs)](https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf?spm=a2c63.p38356.0.0.56b84b03GUn4kJ&file=vendor_ids032322.pdf_1.pdf).
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// The multimedia redirection feature.
        /// </summary>
        [NameInMap("VideoRedirect")]
        [Validation(Required=false)]
        public string VideoRedirect { get; set; }

        /// <summary>
        /// Specify whether to enable the policy of image display quality. Valid values:
        /// 
        /// *   on: enables the policy of image display quality.
        /// *   off: disables the policy of image display quality.
        /// 
        /// Default value: off.
        /// </summary>
        [NameInMap("VisualQuality")]
        [Validation(Required=false)]
        public string VisualQuality { get; set; }

        /// <summary>
        /// Specifies whether to enable watermarking. Valid values:
        /// 
        /// *   on: enables watermarking.
        /// *   off: disables watermarking.
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
        /// The inclination angle of the watermark. Value values: -10 to -30.
        /// </summary>
        [NameInMap("WatermarkDegree")]
        [Validation(Required=false)]
        public double? WatermarkDegree { get; set; }

        /// <summary>
        /// The font size of the watermark. Valid values: 10 to 50
        /// </summary>
        [NameInMap("WatermarkFontSize")]
        [Validation(Required=false)]
        public int? WatermarkFontSize { get; set; }

        /// <summary>
        /// The font style of the watermark. Valid values:
        /// 
        /// * plain
        /// * bold
        /// </summary>
        [NameInMap("WatermarkFontStyle")]
        [Validation(Required=false)]
        public string WatermarkFontStyle { get; set; }

        [NameInMap("WatermarkPower")]
        [Validation(Required=false)]
        public string WatermarkPower { get; set; }

        /// <summary>
        /// The number of watermark rows. This parameter is not in use.
        /// </summary>
        [NameInMap("WatermarkRowAmount")]
        [Validation(Required=false)]
        public int? WatermarkRowAmount { get; set; }

        /// <summary>
        /// The security priority rule for invisible watermarks. Valid values: on and off.
        /// </summary>
        [NameInMap("WatermarkSecurity")]
        [Validation(Required=false)]
        public string WatermarkSecurity { get; set; }

        /// <summary>
        /// The transparency of the watermark. The valid values include:
        /// 
        /// *   LIGHT
        /// *   MIDDLE
        /// *   DARK
        /// </summary>
        [NameInMap("WatermarkTransparency")]
        [Validation(Required=false)]
        public string WatermarkTransparency { get; set; }

        /// <summary>
        /// The transparency of the watermark. A larger value indicates a less transparent watermark. Valid values: 10 to 100.
        /// </summary>
        [NameInMap("WatermarkTransparencyValue")]
        [Validation(Required=false)]
        public int? WatermarkTransparencyValue { get; set; }

        /// <summary>
        /// The type of the watermark. You can specify multiple watermark types at a time. Separate watermark types with commas (,). Valid values:
        /// 
        /// *   EndUserId: the username
        /// *   HostName: the last 15 characters of the cloud desktop ID
        /// </summary>
        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

    }

}
