// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyCenterPolicyRequest : TeaModel {
        [NameInMap("AcademicProxy")]
        [Validation(Required=false)]
        public string AcademicProxy { get; set; }

        /// <summary>
        /// <para>Specifies whether users have administrator permissions after logging on to cloud computers.</para>
        /// <remarks>
        /// <para>This feature is in invitational preview and not available to the public.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("AdminAccess")]
        [Validation(Required=false)]
        public string AdminAccess { get; set; }

        [NameInMap("AdminKeyboardOnFullScreen")]
        [Validation(Required=false)]
        public string AdminKeyboardOnFullScreen { get; set; }

        [NameInMap("AdminKeyboardOnWindows")]
        [Validation(Required=false)]
        public string AdminKeyboardOnWindows { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable anti-screenshot protection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AppContentProtection")]
        [Validation(Required=false)]
        public string AppContentProtection { get; set; }

        /// <summary>
        /// <para>List of new client IP address whitelists.</para>
        /// </summary>
        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestAuthorizeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>Client access IP address range. Specify an IPv4 CIDr block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>Description of the client IP address whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>List of new security group control rules.</para>
        /// </summary>
        [NameInMap("AuthorizeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestAuthorizeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <para>Target of the security group control rule. Specify an IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>Description of the security group control rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Protocol type for the security group control rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>Authorization policy for the security group control rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>Port range for the security group control rule. The port range depends on the protocol (IpProtocol):</para>
            /// <list type="bullet">
            /// <item><description><para>For TCP or UDP protocols: Port range is 1 to 65535. Separate the start and end ports with a forward slash (/). Example: 1/200.</para>
            /// </description></item>
            /// <item><description><para>For ICMP protocol: Set to -1/-1.</para>
            /// </description></item>
            /// <item><description><para>For GRE protocol: Set to -1/-1.</para>
            /// </description></item>
            /// <item><description><para>When IpProtocol is set to all: Set to -1/-1.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information about common ports for typical applications, see <a href="https://help.aliyun.com/document_detail/40724.html">Common ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>Priority of the security group control rule. A smaller number indicates a higher priority. Valid values: 1 to 60. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>Rule direction for the security group control rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inflow</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Automatically reconnect after disconnection</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AutoReconnect")]
        [Validation(Required=false)]
        public string AutoReconnect { get; set; }

        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The business type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public int? BusinessType { get; set; }

        /// <summary>
        /// <para>Local camera redirection. This parameter takes effect only if DeviceRedirects does not include a local camera redirection policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// <para>Event level for screen recording</para>
        /// </summary>
        [NameInMap("ClientControlMenu")]
        [Validation(Required=false)]
        public string ClientControlMenu { get; set; }

        [NameInMap("ClientCreateSnapshot")]
        [Validation(Required=false)]
        public string ClientCreateSnapshot { get; set; }

        /// <summary>
        /// <para>List of client login control rules. Controls which clients can access cloud computers.</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestClientType> ClientType { get; set; }
        public class ModifyCenterPolicyRequestClientType : TeaModel {
            /// <summary>
            /// <para>Client login control. Specifies the client type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>android</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>Client login control. Specifies whether to allow using a specific client type to log on to cloud computers.</para>
            /// <remarks>
            /// <para>If you don\&quot;t configure <c>ClientType</c> parameters, all client types are allowed by default.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
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

        [NameInMap("ClipboardGraineds")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestClipboardGraineds> ClipboardGraineds { get; set; }
        public class ModifyCenterPolicyRequestClipboardGraineds : TeaModel {
            [NameInMap("ClipboardSize")]
            [Validation(Required=false)]
            public int? ClipboardSize { get; set; }

            [NameInMap("ClipboardSizeUnit")]
            [Validation(Required=false)]
            public string ClipboardSizeUnit { get; set; }

            [NameInMap("ClipboardType")]
            [Validation(Required=false)]
            public string ClipboardType { get; set; }

            [NameInMap("GrainedType")]
            [Validation(Required=false)]
            public string GrainedType { get; set; }

            [NameInMap("InClipboardSize")]
            [Validation(Required=false)]
            public int? InClipboardSize { get; set; }

            [NameInMap("InClipboardSizeUnit")]
            [Validation(Required=false)]
            public string InClipboardSizeUnit { get; set; }

            [NameInMap("OutClipboardSize")]
            [Validation(Required=false)]
            public int? OutClipboardSize { get; set; }

            [NameInMap("OutClipboardSizeUnit")]
            [Validation(Required=false)]
            public string OutClipboardSizeUnit { get; set; }

        }

        [NameInMap("ClipboardScope")]
        [Validation(Required=false)]
        public string ClipboardScope { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable color enhancement for design and 3D applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ColorEnhancement")]
        [Validation(Required=false)]
        public string ColorEnhancement { get; set; }

        [NameInMap("CpdDriveClipboard")]
        [Validation(Required=false)]
        public string CpdDriveClipboard { get; set; }

        /// <summary>
        /// <para>CPU downclocking duration. Valid values: 30 to 120. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("CpuDownGradeDuration")]
        [Validation(Required=false)]
        public int? CpuDownGradeDuration { get; set; }

        [NameInMap("CpuOverload")]
        [Validation(Required=false)]
        public string CpuOverload { get; set; }

        /// <summary>
        /// <para>The name of the process.</para>
        /// </summary>
        [NameInMap("CpuProcessors")]
        [Validation(Required=false)]
        public List<string> CpuProcessors { get; set; }

        /// <summary>
        /// <para>CPU protection mode switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CpuProtectedMode")]
        [Validation(Required=false)]
        public string CpuProtectedMode { get; set; }

        /// <summary>
        /// <para>Overall CPU usage percentage. Valid values: 70 to 90.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("CpuRateLimit")]
        [Validation(Required=false)]
        public int? CpuRateLimit { get; set; }

        /// <summary>
        /// <para>Overall CPU sampling duration. Valid values: 10 to 60. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CpuSampleDuration")]
        [Validation(Required=false)]
        public int? CpuSampleDuration { get; set; }

        /// <summary>
        /// <para>Single-core CPU usage percentage. Valid values: 70 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("CpuSingleRateLimit")]
        [Validation(Required=false)]
        public int? CpuSingleRateLimit { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Peripheral connection prompt control.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DeviceConnectHint")]
        [Validation(Required=false)]
        public string DeviceConnectHint { get; set; }

        /// <summary>
        /// <para>Device redirection rules.</para>
        /// </summary>
        [NameInMap("DeviceRedirects")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestDeviceRedirects> DeviceRedirects { get; set; }
        public class ModifyCenterPolicyRequestDeviceRedirects : TeaModel {
            /// <summary>
            /// <para>Peripheral type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>camera</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>Redirection type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deviceRedirect</para>
            /// </summary>
            [NameInMap("RedirectType")]
            [Validation(Required=false)]
            public string RedirectType { get; set; }

        }

        /// <summary>
        /// <para>Custom peripheral rules.</para>
        /// </summary>
        [NameInMap("DeviceRules")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestDeviceRules> DeviceRules { get; set; }
        public class ModifyCenterPolicyRequestDeviceRules : TeaModel {
            /// <summary>
            /// <para>Device name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sandisk</para>
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <para>Product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0x55b1</para>
            /// </summary>
            [NameInMap("DevicePid")]
            [Validation(Required=false)]
            public string DevicePid { get; set; }

            /// <summary>
            /// <para>Peripheral type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>storage</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>Vendor ID. For more information, see <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB Vendor IDs (VIDs)</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0x0781</para>
            /// </summary>
            [NameInMap("DeviceVid")]
            [Validation(Required=false)]
            public string DeviceVid { get; set; }

            /// <summary>
            /// <para>Link optimization command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2:0</para>
            /// </summary>
            [NameInMap("OptCommand")]
            [Validation(Required=false)]
            public string OptCommand { get; set; }

            [NameInMap("Platforms")]
            [Validation(Required=false)]
            public string Platforms { get; set; }

            /// <summary>
            /// <para>Redirection type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usbRedirect</para>
            /// </summary>
            [NameInMap("RedirectType")]
            [Validation(Required=false)]
            public string RedirectType { get; set; }

        }

        /// <summary>
        /// <para>Session retention after disconnection.</para>
        /// <remarks>
        /// <para>This parameter applies only to cloud application policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>customTime</para>
        /// </summary>
        [NameInMap("DisconnectKeepSession")]
        [Validation(Required=false)]
        public string DisconnectKeepSession { get; set; }

        /// <summary>
        /// <para>Session retention duration after disconnection. Valid values: 30 to 7200. Unit: seconds.</para>
        /// <remarks>
        /// <para>This parameter applies only to cloud application policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("DisconnectKeepSessionTime")]
        [Validation(Required=false)]
        public int? DisconnectKeepSessionTime { get; set; }

        [NameInMap("DiskOverload")]
        [Validation(Required=false)]
        public string DiskOverload { get; set; }

        /// <summary>
        /// <para>Display mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clientCustom</para>
        /// </summary>
        [NameInMap("DisplayMode")]
        [Validation(Required=false)]
        public string DisplayMode { get; set; }

        /// <summary>
        /// <para>Domain name resolution policies.</para>
        /// </summary>
        [NameInMap("DomainResolveRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestDomainResolveRule> DomainResolveRule { get; set; }
        public class ModifyCenterPolicyRequestDomainResolveRule : TeaModel {
            /// <summary>
            /// <para>Policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Policy description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Resolution policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

        }

        /// <summary>
        /// <para>Domain name resolution policy type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DomainResolveRuleType")]
        [Validation(Required=false)]
        public string DomainResolveRuleType { get; set; }

        /// <summary>
        /// <para>Session bandwidth throttling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EnableSessionRateLimiting")]
        [Validation(Required=false)]
        public string EnableSessionRateLimiting { get; set; }

        /// <summary>
        /// <para>User requests administrator assistance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EndUserApplyAdminCoordinate")]
        [Validation(Required=false)]
        public string EndUserApplyAdminCoordinate { get; set; }

        /// <summary>
        /// <para>Users on the same office network share cloud computers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EndUserGroupCoordinate")]
        [Validation(Required=false)]
        public string EndUserGroupCoordinate { get; set; }

        [NameInMap("ExternalDrive")]
        [Validation(Required=false)]
        public string ExternalDrive { get; set; }

        /// <summary>
        /// <para>File migration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("FileMigrate")]
        [Validation(Required=false)]
        public string FileMigrate { get; set; }

        [NameInMap("FileTransferAddress")]
        [Validation(Required=false)]
        public string FileTransferAddress { get; set; }

        [NameInMap("FileTransferSpeed")]
        [Validation(Required=false)]
        public string FileTransferSpeed { get; set; }

        /// <summary>
        /// <para>Screen recording event suffix</para>
        /// </summary>
        [NameInMap("FileTransferSpeedLocation")]
        [Validation(Required=false)]
        public string FileTransferSpeedLocation { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the image quality policy for graphics-intensive cloud computers. Enable this policy for scenarios such as professional design where high performance and user experience are required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public string GpuAcceleration { get; set; }

        [NameInMap("HoverConfigMsg")]
        [Validation(Required=false)]
        public string HoverConfigMsg { get; set; }

        /// <summary>
        /// <para>The file transfer policy for web clients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Html5FileTransfer")]
        [Validation(Required=false)]
        public string Html5FileTransfer { get; set; }

        /// <summary>
        /// <para>Network communication protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>both</para>
        /// </summary>
        [NameInMap("InternetCommunicationProtocol")]
        [Validation(Required=false)]
        public string InternetCommunicationProtocol { get; set; }

        /// <summary>
        /// <para>Wuying Keeper toggle for mobile devices</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("InternetPrinter")]
        [Validation(Required=false)]
        public string InternetPrinter { get; set; }

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
        /// <para>Maximum reconnection retry time after an unexpected disconnection. Valid values: 30 to 7200. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MaxReconnectTime")]
        [Validation(Required=false)]
        public int? MaxReconnectTime { get; set; }

        /// <summary>
        /// <para>Memory downclocking duration per process. Valid values: 30 to 120. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemoryDownGradeDuration")]
        [Validation(Required=false)]
        public int? MemoryDownGradeDuration { get; set; }

        [NameInMap("MemoryOverload")]
        [Validation(Required=false)]
        public string MemoryOverload { get; set; }

        /// <summary>
        /// <para>The name of the process.</para>
        /// </summary>
        [NameInMap("MemoryProcessors")]
        [Validation(Required=false)]
        public List<string> MemoryProcessors { get; set; }

        /// <summary>
        /// <para>Memory protection mode switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MemoryProtectedMode")]
        [Validation(Required=false)]
        public string MemoryProtectedMode { get; set; }

        /// <summary>
        /// <para>Overall memory usage percentage. Valid values: 70 to 90.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("MemoryRateLimit")]
        [Validation(Required=false)]
        public int? MemoryRateLimit { get; set; }

        /// <summary>
        /// <para>Overall memory sampling duration. Valid values: 30 to 60. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemorySampleDuration")]
        [Validation(Required=false)]
        public int? MemorySampleDuration { get; set; }

        /// <summary>
        /// <para>Memory usage per process percentage. Valid values: 30 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemorySingleRateLimit")]
        [Validation(Required=false)]
        public int? MemorySingleRateLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide the Restart button in the cloud computer floating ball when connecting via mobile clients (Android and iOS clients).</para>
        /// <remarks>
        /// <para>This feature applies only to mobile clients of version 7.4 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileRestart")]
        [Validation(Required=false)]
        public string MobileRestart { get; set; }

        /// <summary>
        /// <para>The security button toggle for Windows systems on mobile devices</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileSafeMenu")]
        [Validation(Required=false)]
        public string MobileSafeMenu { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide the Shutdown button in the cloud computer floating ball when connecting via mobile clients (Android and iOS clients).</para>
        /// <remarks>
        /// <para>This feature applies only to mobile clients of version 7.4 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileShutdown")]
        [Validation(Required=false)]
        public string MobileShutdown { get; set; }

        /// <summary>
        /// <para>Wuying Keeper toggle for mobile devices</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileWuyingKeeper")]
        [Validation(Required=false)]
        public string MobileWuyingKeeper { get; set; }

        /// <summary>
        /// <para>Mobile Wy Assistant Toggle</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileWyAssistant")]
        [Validation(Required=false)]
        public string MobileWyAssistant { get; set; }

        [NameInMap("ModelLibrary")]
        [Validation(Required=false)]
        public string ModelLibrary { get; set; }

        [NameInMap("MultiScreen")]
        [Validation(Required=false)]
        public string MultiScreen { get; set; }

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
        /// <para>Specifies whether to enable network redirection.</para>
        /// <remarks>
        /// <para>This feature is in invitational preview and not available to the public.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("NetRedirect")]
        [Validation(Required=false)]
        public string NetRedirect { get; set; }

        /// <summary>
        /// <para>Network redirection policy details.</para>
        /// <remarks>
        /// <para>This feature is in invitational preview and not available to the public.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("NetRedirectRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestNetRedirectRule> NetRedirectRule { get; set; }
        public class ModifyCenterPolicyRequestNetRedirectRule : TeaModel {
            /// <summary>
            /// <para>Domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Redirection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>Rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

        /// <summary>
        /// <para>Disconnect on inactivity.</para>
        /// <remarks>
        /// <para>This parameter applies only to cloud application policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("NoOperationDisconnect")]
        [Validation(Required=false)]
        public string NoOperationDisconnect { get; set; }

        /// <summary>
        /// <para>Inactivity disconnect duration. Valid values: 120 to 7200. Unit: seconds.</para>
        /// <remarks>
        /// <para>This parameter applies only to cloud application policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("NoOperationDisconnectTime")]
        [Validation(Required=false)]
        public int? NoOperationDisconnectTime { get; set; }

        /// <summary>
        /// <para>The cloud computer policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-53iyi2aar0nd6****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("PortProxy")]
        [Validation(Required=false)]
        public string PortProxy { get; set; }

        /// <summary>
        /// <para>The printer redirection policy. This parameter takes effect only if DeviceRedirects does not include a printer redirection policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PrinterRedirect")]
        [Validation(Required=false)]
        public string PrinterRedirect { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable image quality enhancement for design and 3D applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("QualityEnhancement")]
        [Validation(Required=false)]
        public string QualityEnhancement { get; set; }

        /// <summary>
        /// <para>Screen recording duration after an event is detected in audit. Unit: minutes. Valid values: 10 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordEventDuration")]
        [Validation(Required=false)]
        public int? RecordEventDuration { get; set; }

        /// <summary>
        /// <para>File extensions for screen recording events</para>
        /// </summary>
        [NameInMap("RecordEventFileExts")]
        [Validation(Required=false)]
        public List<string> RecordEventFileExts { get; set; }

        /// <summary>
        /// <para>Absolute paths for file monitoring in screen recording audit.</para>
        /// </summary>
        [NameInMap("RecordEventFilePaths")]
        [Validation(Required=false)]
        public List<string> RecordEventFilePaths { get; set; }

        /// <summary>
        /// <para>Levels of screen recording events</para>
        /// </summary>
        [NameInMap("RecordEventLevels")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestRecordEventLevels> RecordEventLevels { get; set; }
        public class ModifyCenterPolicyRequestRecordEventLevels : TeaModel {
            /// <summary>
            /// <para>Event level</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <para>Event type</para>
            /// 
            /// <b>Example:</b>
            /// <para>StartApplication</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

        }

        /// <summary>
        /// <para>Absolute paths for registry monitoring in screen recording audit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Computer\HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR</para>
        /// </summary>
        [NameInMap("RecordEventRegisters")]
        [Validation(Required=false)]
        public List<string> RecordEventRegisters { get; set; }

        /// <summary>
        /// <para>List of screen recording events.</para>
        /// </summary>
        [NameInMap("RecordEvents")]
        [Validation(Required=false)]
        public List<string> RecordEvents { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable screen recording.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Recording")]
        [Validation(Required=false)]
        public string Recording { get; set; }

        /// <summary>
        /// <para>Cloud computer audio recording option.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RecordingAudio")]
        [Validation(Required=false)]
        public string RecordingAudio { get; set; }

        /// <summary>
        /// <para>Screen recording file viewing duration in minutes. Recording files are automatically split based on the specified duration and uploaded to the storage bucket. When a file reaches 300 MB, it is prioritized for rolling updates. Valid values: 10 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordingDuration")]
        [Validation(Required=false)]
        public int? RecordingDuration { get; set; }

        /// <summary>
        /// <para>Screen recording end time in HH:MM:SS format. This parameter is meaningful only when <c>Recording</c> is set to <c>PERIOD</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:59:00</para>
        /// </summary>
        [NameInMap("RecordingEndTime")]
        [Validation(Required=false)]
        public string RecordingEndTime { get; set; }

        /// <summary>
        /// <para>Retention period of screen recording files. Valid values: 1 to 180 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("RecordingExpires")]
        [Validation(Required=false)]
        public int? RecordingExpires { get; set; }

        /// <summary>
        /// <para>Screen recording frame rate. Unit: FPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RecordingFps")]
        [Validation(Required=false)]
        public string RecordingFps { get; set; }

        /// <summary>
        /// <para>Screen recording start time in HH:MM:SS format. This parameter is meaningful only when <c>Recording</c> is set to <c>PERIOD</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00:00</para>
        /// </summary>
        [NameInMap("RecordingStartTime")]
        [Validation(Required=false)]
        public string RecordingStartTime { get; set; }

        /// <summary>
        /// <para>Notify end users when screen recording is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("RecordingUserNotify")]
        [Validation(Required=false)]
        public string RecordingUserNotify { get; set; }

        /// <summary>
        /// <para>Message to notify end users when screen recording is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Screen recording is enabled.</para>
        /// </summary>
        [NameInMap("RecordingUserNotifyMessage")]
        [Validation(Required=false)]
        public string RecordingUserNotifyMessage { get; set; }

        /// <summary>
        /// <para>The region ID. Set the value to <c>cn-shanghai</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Keyboard and mouse control permissions for remote assistance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fullControl</para>
        /// </summary>
        [NameInMap("RemoteCoordinate")]
        [Validation(Required=false)]
        public string RemoteCoordinate { get; set; }

        /// <summary>
        /// <para>Reset cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ResetDesktop")]
        [Validation(Required=false)]
        public string ResetDesktop { get; set; }

        [NameInMap("ResolutionDpi")]
        [Validation(Required=false)]
        public int? ResolutionDpi { get; set; }

        /// <summary>
        /// <para>Resolution height. Unit: pixels. Valid values for cloud applications: 500 to 50000. Valid values for cloud computers: 480 to 4096.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// <para>Resolution type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adaptive</para>
        /// </summary>
        [NameInMap("ResolutionModel")]
        [Validation(Required=false)]
        public string ResolutionModel { get; set; }

        /// <summary>
        /// <para>Resolution width. Unit: pixels. Valid values for cloud applications: 500 to 50000. Valid values for cloud computers: 480 to 4096.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("ResolutionWidth")]
        [Validation(Required=false)]
        public int? ResolutionWidth { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of client IP address whitelists to delete.</para>
        /// </summary>
        [NameInMap("RevokeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestRevokeAccessPolicyRule> RevokeAccessPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestRevokeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>Client access IP address range to delete. Specify an IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>Description of the client IP address whitelist to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>List of security group control rules to delete.</para>
        /// </summary>
        [NameInMap("RevokeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestRevokeSecurityPolicyRule> RevokeSecurityPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestRevokeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <para>Target of the security group control rule to delete. Specify an IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>Description of the security group control rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Protocol type for the security group control rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>Authorization policy for the security group control rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>Port range for the security group control rule to delete. The port range depends on the protocol (IpProtocol):</para>
            /// <list type="bullet">
            /// <item><description><para>For TCP or UDP protocols: Port range is 1 to 65535. Separate the start and end ports with a forward slash (/). Example: 1/200.</para>
            /// </description></item>
            /// <item><description><para>For ICMP protocol: Set to -1/-1.</para>
            /// </description></item>
            /// <item><description><para>For GRE protocol: Set to -1/-1.</para>
            /// </description></item>
            /// <item><description><para>When IpProtocol is set to all: Set to -1/-1.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information about common ports for typical applications, see <a href="https://help.aliyun.com/document_detail/40724.html">Common ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>Priority of the security group control rule to delete. A smaller number indicates a higher priority. Valid values: 1 to 60. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>Rule direction for the security group control rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>outflow</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Security button toggle for Windows systems on mobile devices</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SafeMenu")]
        [Validation(Required=false)]
        public string SafeMenu { get; set; }

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
        /// <para>Specify when <c>Scope</c> is set to <c>IP</c>. Takes effect only when <c>Scope</c> is <c>IP</c>.</para>
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public List<string> ScopeValue { get; set; }

        /// <summary>
        /// <para>Xiao Ying toggle for mobile devices</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ScreenDisplayMode")]
        [Validation(Required=false)]
        public string ScreenDisplayMode { get; set; }

        /// <summary>
        /// <para>Maximum session bandwidth throttling value. Unit: Kbps. Valid values: 2000 to 100000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("SessionMaxRateKbps")]
        [Validation(Required=false)]
        public int? SessionMaxRateKbps { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable smoothness enhancement for daily office scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SmoothEnhancement")]
        [Validation(Required=false)]
        public string SmoothEnhancement { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide the status monitoring entry in the cloud computer floating ball.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("StatusMonitor")]
        [Validation(Required=false)]
        public string StatusMonitor { get; set; }

        /// <summary>
        /// <para>Streaming mode adaptation scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>smooth</para>
        /// </summary>
        [NameInMap("StreamingMode")]
        [Validation(Required=false)]
        public string StreamingMode { get; set; }

        /// <summary>
        /// <para>Target frame rate. Valid values: 10 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TargetFps")]
        [Validation(Required=false)]
        public int? TargetFps { get; set; }

        /// <summary>
        /// <para>Application taskbar.</para>
        /// <remarks>
        /// <para>This parameter applies only to cloud application policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Taskbar")]
        [Validation(Required=false)]
        public string Taskbar { get; set; }

        /// <summary>
        /// <para>USB redirection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("UsbRedirect")]
        [Validation(Required=false)]
        public string UsbRedirect { get; set; }

        /// <summary>
        /// <para>USB redirection rules.</para>
        /// </summary>
        [NameInMap("UsbSupplyRedirectRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
        public class ModifyCenterPolicyRequestUsbSupplyRedirectRule : TeaModel {
            /// <summary>
            /// <para>Rule description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test rule</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08**</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>USB redirection type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsbRedirectType")]
            [Validation(Required=false)]
            public string UsbRedirectType { get; set; }

            /// <summary>
            /// <para>USB redirection rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsbRuleType")]
            [Validation(Required=false)]
            public string UsbRuleType { get; set; }

            /// <summary>
            /// <para>Vendor ID. For more information, see <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB Vendor IDs (VIDs)</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04**</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        [NameInMap("UseTime")]
        [Validation(Required=false)]
        public string UseTime { get; set; }

        /// <summary>
        /// <para>Average bitrate for video encoding. Unit: Kbps. Valid values: 1000 to 50000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoEncAvgKbps")]
        [Validation(Required=false)]
        public int? VideoEncAvgKbps { get; set; }

        /// <summary>
        /// <para>Maximum QP for video encoding, representing lowest quality. Valid values: 0 to 51.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("VideoEncMaxQP")]
        [Validation(Required=false)]
        public int? VideoEncMaxQP { get; set; }

        /// <summary>
        /// <para>Minimum QP for video encoding, representing highest quality. Valid values: 0 to 51.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("VideoEncMinQP")]
        [Validation(Required=false)]
        public int? VideoEncMinQP { get; set; }

        /// <summary>
        /// <para>Peak bitrate for video encoding. Unit: Kbps. Valid values: 1000 to 50000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoEncPeakKbps")]
        [Validation(Required=false)]
        public int? VideoEncPeakKbps { get; set; }

        /// <summary>
        /// <para>Video encoding policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qualityFirst</para>
        /// </summary>
        [NameInMap("VideoEncPolicy")]
        [Validation(Required=false)]
        public string VideoEncPolicy { get; set; }

        /// <summary>
        /// <para>Multimedia redirection.</para>
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
        /// <para>low</para>
        /// </summary>
        [NameInMap("VisualQuality")]
        [Validation(Required=false)]
        public string VisualQuality { get; set; }

        /// <summary>
        /// <para>Watermark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        /// <summary>
        /// <para>Blind watermark anti-photo feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WatermarkAntiCam")]
        [Validation(Required=false)]
        public string WatermarkAntiCam { get; set; }

        /// <summary>
        /// <para>Watermark font color. Valid values: 0 to 16777215.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WatermarkColor")]
        [Validation(Required=false)]
        public int? WatermarkColor { get; set; }

        /// <summary>
        /// <para>Number of watermark columns. Valid values: 3 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("WatermarkColumnAmount")]
        [Validation(Required=false)]
        public int? WatermarkColumnAmount { get; set; }

        /// <summary>
        /// <para>If you set <c>WatermarkType</c> to <c>custom</c>, you must also specify custom text using the <c>WatermarkCustomText</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("WatermarkCustomText")]
        [Validation(Required=false)]
        public string WatermarkCustomText { get; set; }

        /// <summary>
        /// <para>Watermark tilt angle. Valid values: -10 to -30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-10</para>
        /// </summary>
        [NameInMap("WatermarkDegree")]
        [Validation(Required=false)]
        public double? WatermarkDegree { get; set; }

        /// <summary>
        /// <para>Watermark font size. Valid values: 10 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WatermarkFontSize")]
        [Validation(Required=false)]
        public int? WatermarkFontSize { get; set; }

        /// <summary>
        /// <para>Watermark font style.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plain</para>
        /// </summary>
        [NameInMap("WatermarkFontStyle")]
        [Validation(Required=false)]
        public string WatermarkFontStyle { get; set; }

        /// <summary>
        /// <para>Blind watermark enhancement feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("WatermarkPower")]
        [Validation(Required=false)]
        public string WatermarkPower { get; set; }

        /// <summary>
        /// <para>Number of watermark rows. Valid values: 3 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("WatermarkRowAmount")]
        [Validation(Required=false)]
        public int? WatermarkRowAmount { get; set; }

        /// <summary>
        /// <para>Blind watermark security priority rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WatermarkSecurity")]
        [Validation(Required=false)]
        public string WatermarkSecurity { get; set; }

        [NameInMap("WatermarkShadow")]
        [Validation(Required=false)]
        public string WatermarkShadow { get; set; }

        /// <summary>
        /// <para>Watermark opacity. A higher value means lower transparency. Valid values: 10 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WatermarkTransparencyValue")]
        [Validation(Required=false)]
        public int? WatermarkTransparencyValue { get; set; }

        /// <summary>
        /// <para>The watermark type. You can select up to three types, separated by commas.</para>
        /// <remarks>
        /// <para>If you set this parameter to <c>custom</c>, you must also specify custom text using the <c>WatermarkCustomText</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EndUserId</para>
        /// </summary>
        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

        /// <summary>
        /// <para>Wuying Keeper switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WuyingKeeper")]
        [Validation(Required=false)]
        public string WuyingKeeper { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide the Wuying AI Assistant entry in the cloud computer floating ball when connecting via desktop clients (including Windows and macOS clients).</para>
        /// <remarks>
        /// <para>This feature applies only to desktop clients of version 7.7 or later.</para>
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
