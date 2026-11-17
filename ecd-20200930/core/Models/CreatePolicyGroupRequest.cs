// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreatePolicyGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the user has administrator permissions after logging on to the cloud computer.</para>
        /// <remarks>
        /// <para>This feature is in targeted invitation-only testing and is not yet publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("AdminAccess")]
        [Validation(Required=false)]
        public string AdminAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the screen capture prevention feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AppContentProtection")]
        [Validation(Required=false)]
        public string AppContentProtection { get; set; }

        /// <summary>
        /// <para>The client IP address whitelist. After you configure this parameter, only IP addresses in the whitelisted CIDR blocks can access the cloud desktop.</para>
        /// </summary>
        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class CreatePolicyGroupRequestAuthorizeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>The client access CIDR block. The value must be an IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>The description of the client IP address whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>North China branch</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The security group control rules.</para>
        /// </summary>
        [NameInMap("AuthorizeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class CreatePolicyGroupRequestAuthorizeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <para>The destination of the security group control rule, which is an IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>The description of the security group control rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow access to the internal R&amp;D environment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The protocol type of the security group control rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The authorization policy of the security group control rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The port range of the security group control rule. The valid port range depends on the value of the IpProtocol parameter:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: The port range is 1 to 65535. Use a forward slash (/) to separate the start port and the end port. Example: 1/200.</description></item>
            /// <item><description>ICMP: Set the value to -1/-1.</description></item>
            /// <item><description>GRE: Set the value to -1/-1.</description></item>
            /// <item><description>If IpProtocol is set to all: Set the value to -1/-1.</description></item>
            /// </list>
            /// <para>For more information about common ports used by typical applications, see <a href="https://help.aliyun.com/document_detail/40724.html">Common ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of the security group control rule. A smaller value indicates a higher priority.<br>Valid values: 1 to 60.<br>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The direction of the security group control rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inflow</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable local camera redirection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// <para>The list of logon method control rules. Specifies which clients can access the cloud computer.</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestClientType> ClientType { get; set; }
        public class CreatePolicyGroupRequestClientType : TeaModel {
            /// <summary>
            /// <para>The client type for logon method control.</para>
            /// <remarks>
            /// <para>If you do not specify the ClientType parameters, all types of clients are allowed to log on to the cloud computer by default.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow a specific type of client to log on to the cloud computer.</para>
            /// <remarks>
            /// <para>If you do not specify the ClientType parameters, all types of clients are allowed to log on to the cloud computer by default.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The clipboard permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        /// <summary>
        /// <para>The list of device redirection rules.</para>
        /// </summary>
        [NameInMap("DeviceRedirects")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestDeviceRedirects> DeviceRedirects { get; set; }
        public class CreatePolicyGroupRequestDeviceRedirects : TeaModel {
            /// <summary>
            /// <para>The type of the peripheral.</para>
            /// 
            /// <b>Example:</b>
            /// <para>camera</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The redirection type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deviceRedirect</para>
            /// </summary>
            [NameInMap("RedirectType")]
            [Validation(Required=false)]
            public string RedirectType { get; set; }

        }

        /// <summary>
        /// <para>The list of custom peripheral rules.</para>
        /// </summary>
        [NameInMap("DeviceRules")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestDeviceRules> DeviceRules { get; set; }
        public class CreatePolicyGroupRequestDeviceRules : TeaModel {
            /// <summary>
            /// <para>The name of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sandisk</para>
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0x55b1</para>
            /// </summary>
            [NameInMap("DevicePid")]
            [Validation(Required=false)]
            public string DevicePid { get; set; }

            /// <summary>
            /// <para>The type of the peripheral.</para>
            /// 
            /// <b>Example:</b>
            /// <para>storage</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The vendor ID. For more information, see <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB Vendor IDs (VIDs)</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0x0781</para>
            /// </summary>
            [NameInMap("DeviceVid")]
            [Validation(Required=false)]
            public string DeviceVid { get; set; }

            /// <summary>
            /// <para>The link optimization command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2:0</para>
            /// </summary>
            [NameInMap("OptCommand")]
            [Validation(Required=false)]
            public string OptCommand { get; set; }

            /// <summary>
            /// <para>The platform types to which the device rule applies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("Platforms")]
            [Validation(Required=false)]
            public string Platforms { get; set; }

            /// <summary>
            /// <para>The redirection type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usbRedirect</para>
            /// </summary>
            [NameInMap("RedirectType")]
            [Validation(Required=false)]
            public string RedirectType { get; set; }

        }

        /// <summary>
        /// <para>The domain name access control settings. Domain names support wildcards (*). Separate multiple domain names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public string DomainList { get; set; }

        /// <summary>
        /// <para>The domain name resolution policy details.</para>
        /// </summary>
        [NameInMap("DomainResolveRule")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestDomainResolveRule> DomainResolveRule { get; set; }
        public class CreatePolicyGroupRequestDomainResolveRule : TeaModel {
            /// <summary>
            /// <para>The policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test rule</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The resolution policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

        }

        /// <summary>
        /// <para>The domain name resolution policy type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("DomainResolveRuleType")]
        [Validation(Required=false)]
        public string DomainResolveRuleType { get; set; }

        /// <summary>
        /// <para>Specifies whether regular users can request administrator assistance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("EndUserApplyAdminCoordinate")]
        [Validation(Required=false)]
        public string EndUserApplyAdminCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether stream collaboration between users is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("EndUserGroupCoordinate")]
        [Validation(Required=false)]
        public string EndUserGroupCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the image quality policy for cloud computers with graphics-optimized specifications. Enable this policy when high performance and user experience are required, such as in professional design scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public string GpuAcceleration { get; set; }

        /// <summary>
        /// <para>The web client access policy.</para>
        /// <remarks>
        /// <para>Use the <c>ClientType</c> parameter to manage logon methods in a unified manner.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Html5Access")]
        [Validation(Required=false)]
        public string Html5Access { get; set; }

        /// <summary>
        /// <para>The web client file transfer policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Html5FileTransfer")]
        [Validation(Required=false)]
        public string Html5FileTransfer { get; set; }

        /// <summary>
        /// <para>The network communication protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>both</para>
        /// </summary>
        [NameInMap("InternetCommunicationProtocol")]
        [Validation(Required=false)]
        public string InternetCommunicationProtocol { get; set; }

        /// <summary>
        /// <para>The local disk mapping permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        /// <summary>
        /// <para>The maximum retry time for reconnecting to a cloud computer after it is disconnected due to objective reasons. Valid values: 30 to 7200. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MaxReconnectTime")]
        [Validation(Required=false)]
        public int? MaxReconnectTime { get; set; }

        /// <summary>
        /// <para>The Policy Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPolicyGroupName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable network redirection.</para>
        /// <remarks>
        /// <para>This feature is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("NetRedirect")]
        [Validation(Required=false)]
        public string NetRedirect { get; set; }

        /// <summary>
        /// <para>The cloud desktop preemption policy.</para>
        /// <remarks>
        /// <para>To ensure the user experience and data security of the end user who is using the cloud desktop, preemption among multiple users is not allowed. This configuration defaults to <c>off</c> and cannot be modified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PreemptLogin")]
        [Validation(Required=false)]
        public string PreemptLogin { get; set; }

        /// <summary>
        /// <para>The usernames of the users who are allowed to preempt the cloud desktop. You can specify up to five usernames.</para>
        /// <remarks>
        /// <para>To ensure the user experience and data security of the end user who is using the cloud desktop, preemption among multiple users is not allowed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("PreemptLoginUser")]
        [Validation(Required=false)]
        public List<string> PreemptLoginUser { get; set; }

        /// <summary>
        /// <para>The printer redirection policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PrinterRedirection")]
        [Validation(Required=false)]
        public string PrinterRedirection { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable custom screen recording.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("RecordContent")]
        [Validation(Required=false)]
        public string RecordContent { get; set; }

        /// <summary>
        /// <para>The expiration time of custom screen recording files. Default value: 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RecordContentExpires")]
        [Validation(Required=false)]
        public long? RecordContentExpires { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable screen recording.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("Recording")]
        [Validation(Required=false)]
        public string Recording { get; set; }

        /// <summary>
        /// <para>The option for recording the audio of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RecordingAudio")]
        [Validation(Required=false)]
        public string RecordingAudio { get; set; }

        /// <summary>
        /// <para>The viewing duration of screen recording files. Unit: minutes. Recorded files are automatically split and uploaded to the storage space based on the specified duration. When a file reaches 300 MB, it is rotated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordingDuration")]
        [Validation(Required=false)]
        public int? RecordingDuration { get; set; }

        /// <summary>
        /// <para>The end time for screen recording. Format: HH:MM:SS. This parameter takes effect only when Recording is set to PERIOD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:59:00</para>
        /// </summary>
        [NameInMap("RecordingEndTime")]
        [Validation(Required=false)]
        public string RecordingEndTime { get; set; }

        /// <summary>
        /// <para>The retention period of screen recording files. Valid values: 1 to 180. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("RecordingExpires")]
        [Validation(Required=false)]
        public long? RecordingExpires { get; set; }

        /// <summary>
        /// <para>The frame rate for screen recording. Unit: FPS (frames per second).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecordingFps")]
        [Validation(Required=false)]
        public long? RecordingFps { get; set; }

        /// <summary>
        /// <para>The start time for screen recording. Format: HH:MM:SS. This parameter takes effect only when Recording is set to PERIOD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00:00</para>
        /// </summary>
        [NameInMap("RecordingStartTime")]
        [Validation(Required=false)]
        public string RecordingStartTime { get; set; }

        /// <summary>
        /// <para>The screen recording notification feature for the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("RecordingUserNotify")]
        [Validation(Required=false)]
        public string RecordingUserNotify { get; set; }

        /// <summary>
        /// <para>The content of the screen recording notification displayed on the client. You do not need to specify this parameter by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Your cloud computer is being recorded</para>
        /// </summary>
        [NameInMap("RecordingUserNotifyMessage")]
        [Validation(Required=false)]
        public string RecordingUserNotifyMessage { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions supported by WUYING Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The keyboard and mouse control permissions during remote assistance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fullControl</para>
        /// </summary>
        [NameInMap("RemoteCoordinate")]
        [Validation(Required=false)]
        public string RemoteCoordinate { get; set; }

        /// <summary>
        /// <para>The effective scope of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>This parameter is required when Scope is set to IP. This parameter takes effect only when Scope is set to IP.</para>
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public List<string> ScopeValue { get; set; }

        /// <summary>
        /// <para>The USB redirection settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("UsbRedirect")]
        [Validation(Required=false)]
        public string UsbRedirect { get; set; }

        /// <summary>
        /// <para>The USB redirection rule.</para>
        /// </summary>
        [NameInMap("UsbSupplyRedirectRule")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
        public class CreatePolicyGroupRequestUsbSupplyRedirectRule : TeaModel {
            /// <summary>
            /// <para>The rule description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test rule</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The device class. This parameter is required when usbRuleType is set to 1. For more information, see <a href="https://www.usb.org/defined-class-codes">Defined Class Codes</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0Eh</para>
            /// </summary>
            [NameInMap("DeviceClass")]
            [Validation(Required=false)]
            public string DeviceClass { get; set; }

            /// <summary>
            /// <para>The device subclass. This parameter is required when usbRuleType is set to 1. For more information, see <a href="https://www.usb.org/defined-class-codes">Defined Class Codes</a>.</para>
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
            /// <para>The USB redirection type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsbRedirectType")]
            [Validation(Required=false)]
            public long? UsbRedirectType { get; set; }

            /// <summary>
            /// <para>The USB redirection rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsbRuleType")]
            [Validation(Required=false)]
            public long? UsbRuleType { get; set; }

            /// <summary>
            /// <para>The vendor ID. For more information, see <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB Vendor IDs (VIDs)</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04**</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// <para>The multimedia redirection setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("VideoRedirect")]
        [Validation(Required=false)]
        public string VideoRedirect { get; set; }

        /// <summary>
        /// <para>The image display quality policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("VisualQuality")]
        [Validation(Required=false)]
        public string VisualQuality { get; set; }

        /// <summary>
        /// <para>The watermark settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        /// <summary>
        /// <para>The anti-camera capture feature for blind watermarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WatermarkAntiCam")]
        [Validation(Required=false)]
        public string WatermarkAntiCam { get; set; }

        /// <summary>
        /// <para>The font color of the watermark. Valid values: 0 to 16777215.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WatermarkColor")]
        [Validation(Required=false)]
        public int? WatermarkColor { get; set; }

        /// <summary>
        /// <para>The tilt angle of the watermark. Valid values: -10 to -30.</para>
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
        /// <para>The font style of the watermark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plain</para>
        /// </summary>
        [NameInMap("WatermarkFontStyle")]
        [Validation(Required=false)]
        public string WatermarkFontStyle { get; set; }

        /// <summary>
        /// <para>The enhancement feature for blind watermarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("WatermarkPower")]
        [Validation(Required=false)]
        public string WatermarkPower { get; set; }

        /// <summary>
        /// <para>The number of watermark rows.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("WatermarkRowAmount")]
        [Validation(Required=false)]
        public int? WatermarkRowAmount { get; set; }

        /// <summary>
        /// <para>The security priority rule for blind watermarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("WatermarkSecurity")]
        [Validation(Required=false)]
        public string WatermarkSecurity { get; set; }

        /// <summary>
        /// <para>The transparency of the watermark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIGHT</para>
        /// </summary>
        [NameInMap("WatermarkTransparency")]
        [Validation(Required=false)]
        public string WatermarkTransparency { get; set; }

        /// <summary>
        /// <para>The watermark opacity. A larger value indicates lower transparency. Valid values: 10 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WatermarkTransparencyValue")]
        [Validation(Required=false)]
        public int? WatermarkTransparencyValue { get; set; }

        /// <summary>
        /// <para>The watermark types. You can select up to three types and separate them with commas (,).</para>
        /// <remarks>
        /// <para>If you specify <c>custom</c>, you must also use the <c>WatermarkCustomText</c> parameter to specify the custom text.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EndUserId</para>
        /// </summary>
        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide the entry point for the WUYING AI Assistant in the floating ball when connecting to the cloud computer through a desktop client, including Windows and macOS clients.</para>
        /// <remarks>
        /// <para>This feature applies only to desktop clients of V7.7 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("WyAssistant")]
        [Validation(Required=false)]
        public string WyAssistant { get; set; }

    }

}
