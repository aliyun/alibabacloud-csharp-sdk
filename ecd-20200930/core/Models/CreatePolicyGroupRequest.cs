// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreatePolicyGroupRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the anti-screenshot feature.
        /// 
        /// Valid values:
        /// 
        /// *   off: Anti-screenshot is disabled. This value is the default value.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   on: Anti-screenshot is enabled.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("AppContentProtection")]
        [Validation(Required=false)]
        public string AppContentProtection { get; set; }

        /// <summary>
        /// The client IP address whitelists. Only the client IP addresses in whitelists can access the cloud desktop.
        /// </summary>
        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class CreatePolicyGroupRequestAuthorizeAccessPolicyRule : TeaModel {
            /// <summary>
            /// The IPv4 CIDR block that you want to access from the client. The value is an IPv4 CIDR block.
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
        public List<CreatePolicyGroupRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class CreatePolicyGroupRequestAuthorizeSecurityPolicyRule : TeaModel {
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
            /// *   TCP
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   UDP
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   ALL: all protocols
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   GRE
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   ICMP: ICMP (IPv4)
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
            /// *   drop: denies all access requests
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     If no denied messages are returned, the requests timed out or failed.
            /// 
            ///     <!-- -->
            /// 
            /// *   accept: accepts all access requests
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     This value is the default value.
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The port range of the security group rule. The value range of this parameter varies based on the value of the IpProtocol parameter.
            /// 
            /// *   If you set the IpProtocol parameter to TCP or UDP, the value range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.
            /// *   If you set the IpProtocol parameter to ICMP, the start port number and the end port number are -1/-1.
            /// *   If you set the IpProtocol parameter to GRE, the start port number and the end port number are -1/-1.
            /// *   If you set the IpProtocol parameter to ALL, the start port number and the end port number are -1/-1.
            /// 
            /// For more information about the common ports of applications, see [Common ports](~~40724~~).
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// The priority of the security group rule. A smaller value specifies a higher priority.\
            /// Valid values: 1 to 60.\
            /// Default value: 1.
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
        /// Specifies whether to enable the webcam redirection feature.
        /// 
        /// Valid values:
        /// 
        /// *   off: Webcam redirection is disabled.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   on: Webcam redirection is enabled. This value is the default value.
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
        /// The logon methods. You can use this parameter to determine which clients can be used to connect to the cloud desktop.
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestClientType> ClientType { get; set; }
        public class CreatePolicyGroupRequestClientType : TeaModel {
            /// <summary>
            /// The type of the client.
            /// 
            /// > By default, if you do not specify the ClientType parameter, all types of clients can be used to connect to cloud desktops.
            /// 
            /// Valid values:
            /// 
            /// *   html5: web clients
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   android: Android clients
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   linux: Alibaba Cloud Workspace clients
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   ios: iOS clients
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   windows: Windows clients
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   macos: macOS clients
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// Specifies whether a specific client type can be used to connect to the cloud desktop.
            /// 
            /// > By default, if you do not specify the ClientType parameter, all types of clients can be used to connect to cloud desktops.
            /// 
            /// Valid values:
            /// 
            /// *   OFF: Clients of the specified type cannot be used to connect to cloud desktops.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   ON: Clients of the specified type can be used to connect to cloud desktops.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
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
        /// *   read: specifies one-way transfer
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     You can copy data from your local computer to the cloud desktop, but cannot copy data from the cloud desktop to your local computer.
        /// 
        ///     <!-- -->
        /// 
        /// *   readwrite: specifies two-way transfer
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     You can copy data between your local computer and the cloud desktop.
        /// 
        ///     <!-- -->
        /// 
        /// *   off: disables both one-way and two-way transfer
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     You cannot copy data between your local computer and the cloud desktop. This value is the default value.
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        /// <summary>
        /// Access control for domain names. The wildcard character (\*) is supported for domain names. Separate multiple domain names with commas (,). Valid values:
        /// 
        /// *   off
        /// *   on
        /// </summary>
        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public string DomainList { get; set; }

        /// <summary>
        /// Specifies whether to allow end users to seek assistance from the administrator. Valid values: ON OFF
        /// </summary>
        [NameInMap("EndUserApplyAdminCoordinate")]
        [Validation(Required=false)]
        public string EndUserApplyAdminCoordinate { get; set; }

        /// <summary>
        /// The switch for collaboration between end users. Valid values: ON OFF
        /// </summary>
        [NameInMap("EndUserGroupCoordinate")]
        [Validation(Required=false)]
        public string EndUserGroupCoordinate { get; set; }

        /// <summary>
        /// Specifies whether to enable the image display quality feature for the Graphics cloud desktop. If you have high requirements for desktop performance and user experience, we recommend that you enable this feature. For example, you can enable this feature in professional design scenarios.
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
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public string GpuAcceleration { get; set; }

        /// <summary>
        /// The policy for HTML5 client access.
        /// 
        /// > We recommend that you use the ClientType parameter to manage the type of Alibaba Cloud Workspace clients for desktop connection.
        /// 
        /// Valid values:
        /// 
        /// *   off: HTML5 client access is disabled. This value is the default value.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   on: HTML5 client access is enabled.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Html5Access")]
        [Validation(Required=false)]
        public string Html5Access { get; set; }

        /// <summary>
        /// The file transfer policy for HTML5 clients.
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
        /// *   off: File transfer between HTML5 clients and your computer is disabled. This value is the default value.
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
        /// The protocol that you want to use for network communication. Valid values: -TCP: Only TCP is allowed. -BOTH: Automatic switch between TCP and UDP is allowed. Default value: TCP.
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
        ///     The disks on your local computer are mapped to the cloud desktop. You can only read (copy) files on the local computer.
        /// 
        ///     <!-- -->
        /// 
        /// *   readwrite: read and write
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     The disks on your local computer are mapped to the cloud desktop. You can read (copy) and modify files on your local computer.
        /// 
        ///     <!-- -->
        /// 
        /// *   off:
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     The disks on your local computer are not mapped to the cloud desktop. This value is the default value.
        /// 
        ///     <!-- -->
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
        /// Specifies whether to enable the network redirection feature.
        /// 
        /// Valid values:
        /// 
        /// *   off: Network redirection is disabled. This value is the default value.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   on: Network redirection is enabled.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("NetRedirect")]
        [Validation(Required=false)]
        public string NetRedirect { get; set; }

        /// <summary>
        /// Specifies whether to allow user preemption.
        /// 
        /// > To improve user experience and ensure data security, multiple end users cannot connect to the same cloud desktop at the same time. The default value of this parameter is `off`, and the value cannot be changed.
        /// </summary>
        [NameInMap("PreemptLogin")]
        [Validation(Required=false)]
        public string PreemptLogin { get; set; }

        /// <summary>
        /// The names of the users that are allowed to connect to the same cloud desktop at the same time. You can specify up to five usernames.
        /// 
        /// > To improve user experience and ensure data security, we recommend that you disable the user preemption feature.
        /// </summary>
        [NameInMap("PreemptLoginUser")]
        [Validation(Required=false)]
        public List<string> PreemptLoginUser { get; set; }

        /// <summary>
        /// The policy for printer redirection.
        /// 
        /// Valid values:
        /// 
        /// *   off: Printer redirection is disabled.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   on: Printer redirection is enabled.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("PrinterRedirection")]
        [Validation(Required=false)]
        public string PrinterRedirection { get; set; }

        /// <summary>
        /// Specifies whether to enable the custom screen recording feature.
        /// 
        /// Valid values:
        /// 
        /// *   off: Custom screen recording is disabled. This value is the default value.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   on: Custom screen recording is enabled.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
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
        /// Specifies whether to enable screen recording.
        /// 
        /// Valid values:
        /// 
        /// *   ALLTIME: All operations that are performed by end users on cloud desktops are recorded. The recording starts immediately when end users connect to cloud desktops and ends when the end users disconnect from the cloud desktops.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   PERIOD: The operations that are performed by end users on cloud desktops during a specified period of time are recorded. You must set the start time and end time for the recording period.
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
        /// Specifies whether to record audio data during the screen recording. Valid values:
        /// 
        /// *   on: records audio and video data
        /// *   off: records only video data
        /// </summary>
        [NameInMap("RecordingAudio")]
        [Validation(Required=false)]
        public string RecordingAudio { get; set; }

        /// <summary>
        /// The duration from the time when the screen recording starts to the time when the screen recording stops. If you specify the Recording parameter, you must also specify the RecordingDuration parameter. When the specified duration ends, a recording file is generated.
        /// </summary>
        [NameInMap("RecordingDuration")]
        [Validation(Required=false)]
        public int? RecordingDuration { get; set; }

        /// <summary>
        /// The time when the screen recording stops. Specify the value in the HH:MM:SS format. The value of this parameter is valid only if you set the Recording parameter to PERIOD.
        /// </summary>
        [NameInMap("RecordingEndTime")]
        [Validation(Required=false)]
        public string RecordingEndTime { get; set; }

        /// <summary>
        /// The duration in which the screen recording is valid. Unit: days.
        /// </summary>
        [NameInMap("RecordingExpires")]
        [Validation(Required=false)]
        public long? RecordingExpires { get; set; }

        /// <summary>
        /// The frame rate of screen recording.
        /// 
        /// Valid values:
        /// 
        /// *   2
        /// 
        /// *   5
        /// 
        /// *  10
        /// 
        /// *   15
        /// </summary>
        [NameInMap("RecordingFps")]
        [Validation(Required=false)]
        public long? RecordingFps { get; set; }

        /// <summary>
        /// The time when screen recording starts. Specify the value in the HH:MM:SS format. The value of this parameter is valid only if you set the Recording parameter to PERIOD.
        /// </summary>
        [NameInMap("RecordingStartTime")]
        [Validation(Required=false)]
        public string RecordingStartTime { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The permission to control the keyboard and the mouse during remote assistance.
        /// 
        /// Valid values:
        /// 
        /// *   \-
        /// 
        ///     <!-- -->
        /// 
        ///     optionalControl
        /// 
        ///     <!-- -->
        /// 
        ///     : By default, this feature is disabled. You can enable it by applying permissions.
        /// 
        ///     <!-- -->
        /// 
        /// *   fullControl: The permission is granted.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   disableControl: The permission is revoked.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("RemoteCoordinate")]
        [Validation(Required=false)]
        public string RemoteCoordinate { get; set; }

        /// <summary>
        /// The effective scope of the policy. Valid values:
        /// 
        /// *   GLOBAL: The policy takes effect globally.
        /// *   IP: The policy takes effect for specified IP addresses.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The effective CIDR block ranges. If you set the Scope parameter to IP, you must specify this parameter.
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public List<string> ScopeValue { get; set; }

        /// <summary>
        /// Specifies whether to enable USB redirection.
        /// 
        /// Valid values:
        /// 
        /// *   off: USB redirection is disabled. This value is the default value.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   on: USB redirection is enabled.
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
        public List<CreatePolicyGroupRequestUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
        public class CreatePolicyGroupRequestUsbSupplyRedirectRule : TeaModel {
            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The class of the device. If you set the `usbRuleType` parameter to 1, you must specify this parameter. For more information, see [Defined Class Codes](https://www.usb.org/defined-class-codes).
            /// </summary>
            [NameInMap("DeviceClass")]
            [Validation(Required=false)]
            public string DeviceClass { get; set; }

            /// <summary>
            /// The subclass of the device. If you set the `usbRuleType` parameter to 1, you must specify this parameter. For more information, see [Defined Class Codes](https://www.usb.org/defined-class-codes).
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
            /// The type of USB redirection.
            /// 
            /// Valid values:
            /// 
            /// *   1: allows USB redirection
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   2: forbids USB redirection
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
            /// The ID of the vendor. For more information, see [Valid USB Vendor IDs (VIDs)](https://www.usb.org/sites/default/files/vendor_ids032322.pdf\_1.pdf).
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable the multimedia redirection feature. Valid values:
        /// 
        /// *   on: Multimedia redirection is enabled.
        /// *   off: Multimedia redirection is disabled.
        /// </summary>
        [NameInMap("VideoRedirect")]
        [Validation(Required=false)]
        public string VideoRedirect { get; set; }

        /// <summary>
        /// The policy for image display quality.
        /// 
        /// Valid values:
        /// 
        /// *   high
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   low
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   lossless
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   medium: adaptive. This value is the default value.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("VisualQuality")]
        [Validation(Required=false)]
        public string VisualQuality { get; set; }

        /// <summary>
        /// Specifies whether to enable watermarking.
        /// 
        /// Valid values:
        /// 
        /// *   off: Watermarking is disabled. This value is the default value.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   on: Watermarking is enabled.
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

        /// <summary>
        /// The font color of the watermark. Valid values: 0 to 16777215.
        /// </summary>
        [NameInMap("WatermarkColor")]
        [Validation(Required=false)]
        public int? WatermarkColor { get; set; }

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

        /// <summary>
        /// The number of watermark rows. This parameter is now invalid.
        /// </summary>
        [NameInMap("WatermarkRowAmount")]
        [Validation(Required=false)]
        public int? WatermarkRowAmount { get; set; }

        /// <summary>
        /// The transparency of the watermark.
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
        /// The transparency of the watermark. A larger value specifies that the watermark is less transparent. Valid values: 10 to 100.
        /// </summary>
        [NameInMap("WatermarkTransparencyValue")]
        [Validation(Required=false)]
        public int? WatermarkTransparencyValue { get; set; }

        /// <summary>
        /// The type of the watermark. You can specify multiple types of watermarks at the same time. Separate multiple watermark types with commas (,).
        /// 
        /// Valid values:
        /// 
        /// *   EndUserId: The ID of the end user is displayed.
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

}
