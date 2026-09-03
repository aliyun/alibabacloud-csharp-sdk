// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyCenterPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the academic proxy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AcademicProxy")]
        [Validation(Required=false)]
        public string AcademicProxy { get; set; }

        /// <summary>
        /// <para>Specifies whether the user has administrator permissions after logging on to the cloud desktop.</para>
        /// <remarks>
        /// <para>This feature is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("AdminAccess")]
        [Validation(Required=false)]
        public string AdminAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable administrator keyboard control in full-screen mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AdminKeyboardOnFullScreen")]
        [Validation(Required=false)]
        public string AdminKeyboardOnFullScreen { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable administrator keyboard control within the Windows system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AdminKeyboardOnWindows")]
        [Validation(Required=false)]
        public string AdminKeyboardOnWindows { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the screenshot prevention feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AppContentProtection")]
        [Validation(Required=false)]
        public string AppContentProtection { get; set; }

        /// <summary>
        /// <para>The list of client IP whitelist entries to add.</para>
        /// </summary>
        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestAuthorizeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>The client IP address range. The value is an IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>The description of the client IP whitelist entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Corporate office network segment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The list of security group control rules to add.</para>
        /// </summary>
        [NameInMap("AuthorizeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestAuthorizeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <para>The object of the security group control rule. An IPv4 CIDR block in CIDR notation.</para>
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
            /// <para>TCP</para>
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
            /// <para>The port range of the security group control rule. The port range is determined by the value of the protocol (IpProtocol):</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: Valid values: 1 to 65535. Separate the start port and end port with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>If IpProtocol is set to all: -1/-1.</description></item>
            /// </list>
            /// <para>For common ports of typical applications, see <a href="https://help.aliyun.com/document_detail/40724.html">Common ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of the security group control rule. A smaller value indicates a higher priority. Valid values: 1 to 60. Default value: 1.</para>
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
        /// <para>Specifies whether to automatically reconnect after disconnection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AutoReconnect")]
        [Validation(Required=false)]
        public string AutoReconnect { get; set; }

        /// <summary>
        /// <para>The business channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enterprise: Enterprise Edition.</description></item>
        /// <item><description>Business: Business Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise</para>
        /// </summary>
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
        /// <para>The local camera redirection policy. This parameter takes effect only when no local camera redirection policy is specified in DeviceRedirects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the client control menu. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("ClientControlMenu")]
        [Validation(Required=false)]
        public string ClientControlMenu { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the custom snapshot creation feature on the client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ClientCreateSnapshot")]
        [Validation(Required=false)]
        public string ClientCreateSnapshot { get; set; }

        /// <summary>
        /// <para>The list of logon method control rules. Specifies which client types can be used to access cloud computers.</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestClientType> ClientType { get; set; }
        public class ModifyCenterPolicyRequestClientType : TeaModel {
            /// <summary>
            /// <para>The client type for logon method control.</para>
            /// 
            /// <b>Example:</b>
            /// <para>android</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow a specific type of client to log on to cloud computers.</para>
            /// <remarks>
            /// <para>If you do not set the <c>ClientType</c> parameters, all client types are allowed to log on to cloud computers by default.</para>
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
        /// <para>The clipboard permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        /// <summary>
        /// <para>The fine-grained clipboard control configurations.</para>
        /// </summary>
        [NameInMap("ClipboardGraineds")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestClipboardGraineds> ClipboardGraineds { get; set; }
        public class ModifyCenterPolicyRequestClipboardGraineds : TeaModel {
            /// <summary>
            /// <para>The maximum size of a single clipboard transfer. Use this parameter together with the size unit parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ClipboardSize")]
            [Validation(Required=false)]
            public int? ClipboardSize { get; set; }

            /// <summary>
            /// <para>The unit of the maximum size of a single clipboard transfer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MB</para>
            /// </summary>
            [NameInMap("ClipboardSizeUnit")]
            [Validation(Required=false)]
            public string ClipboardSizeUnit { get; set; }

            /// <summary>
            /// <para>The fine-grained clipboard control type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off: Clipboard usage is disabled.</description></item>
            /// <item><description>read: Read-only.</description></item>
            /// <item><description>write: Write-only.</description></item>
            /// <item><description>readwrite: Read and write.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("ClipboardType")]
            [Validation(Required=false)]
            public string ClipboardType { get; set; }

            /// <summary>
            /// <para>The content type for fine-grained clipboard control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>text: Text.</description></item>
            /// <item><description>richtext: Rich text.</description></item>
            /// <item><description>file: File.</description></item>
            /// <item><description>picture: Image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("GrainedType")]
            [Validation(Required=false)]
            public string GrainedType { get; set; }

            /// <summary>
            /// <para>The maximum size of a single clipboard transfer to the cloud desktop. Use this parameter together with the inbound size unit parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InClipboardSize")]
            [Validation(Required=false)]
            public int? InClipboardSize { get; set; }

            /// <summary>
            /// <para>The unit of the maximum size of a single clipboard transfer to the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MB</para>
            /// </summary>
            [NameInMap("InClipboardSizeUnit")]
            [Validation(Required=false)]
            public string InClipboardSizeUnit { get; set; }

            /// <summary>
            /// <para>The maximum size of a single clipboard transfer from the cloud desktop. Use this parameter together with the outbound size unit parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OutClipboardSize")]
            [Validation(Required=false)]
            public int? OutClipboardSize { get; set; }

            /// <summary>
            /// <para>The unit of the maximum size of a single clipboard transfer from the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MB</para>
            /// </summary>
            [NameInMap("OutClipboardSizeUnit")]
            [Validation(Required=false)]
            public string OutClipboardSizeUnit { get; set; }

        }

        /// <summary>
        /// <para>The effective scope of the clipboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL</para>
        /// </summary>
        [NameInMap("ClipboardScope")]
        [Validation(Required=false)]
        public string ClipboardScope { get; set; }

        /// <summary>
        /// <para>Indicates whether color enhancement is enabled for the design and 3D application common scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ColorEnhancement")]
        [Validation(Required=false)]
        public string ColorEnhancement { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the local drive clipboard feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CpdDriveClipboard")]
        [Validation(Required=false)]
        public string CpdDriveClipboard { get; set; }

        /// <summary>
        /// <para>The CPU throttling duration. Valid values: 30 to 120. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("CpuDownGradeDuration")]
        [Validation(Required=false)]
        public int? CpuDownGradeDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable CPU overload protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CpuOverload")]
        [Validation(Required=false)]
        public string CpuOverload { get; set; }

        /// <summary>
        /// <para>The process name.</para>
        /// </summary>
        [NameInMap("CpuProcessors")]
        [Validation(Required=false)]
        public List<string> CpuProcessors { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable CPU protection mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CpuProtectedMode")]
        [Validation(Required=false)]
        public string CpuProtectedMode { get; set; }

        /// <summary>
        /// <para>The overall CPU usage percentage. Valid values: 70 to 90.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("CpuRateLimit")]
        [Validation(Required=false)]
        public int? CpuRateLimit { get; set; }

        /// <summary>
        /// <para>The overall CPU sampling duration. Valid values: 10 to 60. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CpuSampleDuration")]
        [Validation(Required=false)]
        public int? CpuSampleDuration { get; set; }

        /// <summary>
        /// <para>The single-core CPU usage percentage. Valid values: 70 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("CpuSingleRateLimit")]
        [Validation(Required=false)]
        public int? CpuSingleRateLimit { get; set; }

        /// <summary>
        /// <para>The description of the NAS file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The peripheral connection notification control.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DeviceConnectHint")]
        [Validation(Required=false)]
        public string DeviceConnectHint { get; set; }

        /// <summary>
        /// <para>The list of device redirection rules.</para>
        /// </summary>
        [NameInMap("DeviceRedirects")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestDeviceRedirects> DeviceRedirects { get; set; }
        public class ModifyCenterPolicyRequestDeviceRedirects : TeaModel {
            /// <summary>
            /// <para>The peripheral type.</para>
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
        public List<ModifyCenterPolicyRequestDeviceRules> DeviceRules { get; set; }
        public class ModifyCenterPolicyRequestDeviceRules : TeaModel {
            /// <summary>
            /// <para>The device name.</para>
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
            /// <para>The peripheral type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>storage</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The vendor ID. See <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB Vendor IDs (VIDs)</a>.</para>
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
        /// <para>The session retention policy after disconnection.</para>
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
        /// <para>The session retention period after disconnection. Valid values: 30 to 7200. Unit: seconds.</para>
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

        /// <summary>
        /// <para>Specifies whether to enable disk overload protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DiskOverload")]
        [Validation(Required=false)]
        public string DiskOverload { get; set; }

        /// <summary>
        /// <para>The display mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clientCustom</para>
        /// </summary>
        [NameInMap("DisplayMode")]
        [Validation(Required=false)]
        public string DisplayMode { get; set; }

        /// <summary>
        /// <para>The domain name resolution policy.</para>
        /// </summary>
        [NameInMap("DomainResolveRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestDomainResolveRule> DomainResolveRule { get; set; }
        public class ModifyCenterPolicyRequestDomainResolveRule : TeaModel {
            /// <summary>
            /// <para>The policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Policy description</para>
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
        /// <para>off</para>
        /// </summary>
        [NameInMap("DomainResolveRuleType")]
        [Validation(Required=false)]
        public string DomainResolveRuleType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable session bandwidth throttling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EnableSessionRateLimiting")]
        [Validation(Required=false)]
        public string EnableSessionRateLimiting { get; set; }

        /// <summary>
        /// <para>Specifies whether users can request assistance from administrators.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EndUserApplyAdminCoordinate")]
        [Validation(Required=false)]
        public string EndUserApplyAdminCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether users in the same office network can share cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EndUserGroupCoordinate")]
        [Validation(Required=false)]
        public string EndUserGroupCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable external storage devices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ExternalDrive")]
        [Validation(Required=false)]
        public string ExternalDrive { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable file migration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("FileMigrate")]
        [Validation(Required=false)]
        public string FileMigrate { get; set; }

        /// <summary>
        /// <para>The service address for the file transfer feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>filetransfer.example.com</para>
        /// </summary>
        [NameInMap("FileTransferAddress")]
        [Validation(Required=false)]
        public string FileTransferAddress { get; set; }

        /// <summary>
        /// <para>The maximum file size for a single transfer to the cloud desktop. This parameter must be used together with the transfer-in unit parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("FileTransferInSize")]
        [Validation(Required=false)]
        public string FileTransferInSize { get; set; }

        /// <summary>
        /// <para>The unit of the maximum file size for a single transfer to the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MB</para>
        /// </summary>
        [NameInMap("FileTransferInUnit")]
        [Validation(Required=false)]
        public string FileTransferInUnit { get; set; }

        /// <summary>
        /// <para>The maximum file size for a single transfer from the cloud desktop. This parameter must be used together with the transfer-out unit parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("FileTransferOutSize")]
        [Validation(Required=false)]
        public string FileTransferOutSize { get; set; }

        /// <summary>
        /// <para>The unit of the maximum file size for a single transfer from the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MB</para>
        /// </summary>
        [NameInMap("FileTransferOutUnit")]
        [Validation(Required=false)]
        public string FileTransferOutUnit { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the file transfer size limit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("FileTransferSizeLimit")]
        [Validation(Required=false)]
        public string FileTransferSizeLimit { get; set; }

        /// <summary>
        /// <para>The file transfer speed level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("FileTransferSpeed")]
        [Validation(Required=false)]
        public string FileTransferSpeed { get; set; }

        /// <summary>
        /// <para>The location where the file transfer speed configured on the client takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client</para>
        /// </summary>
        [NameInMap("FileTransferSpeedLocation")]
        [Validation(Required=false)]
        public string FileTransferSpeedLocation { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the image quality policy for GPU-accelerated cloud desktops. Enable this policy when high cloud desktop performance and user experience are required, such as in professional design scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public string GpuAcceleration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the floating ball configuration message prompt. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("HoverConfigMsg")]
        [Validation(Required=false)]
        public string HoverConfigMsg { get; set; }

        /// <summary>
        /// <para>The file transfer policy for the web client.</para>
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
        /// <para>Specifies whether to enable the network printer feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("InternetPrinter")]
        [Validation(Required=false)]
        public string InternetPrinter { get; set; }

        /// <summary>
        /// <para>The local disk mapping permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        /// <summary>
        /// <para>The maximum connection retry time when a cloud computer is disconnected due to objective reasons. Valid values: 30 to 7200. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MaxReconnectTime")]
        [Validation(Required=false)]
        public int? MaxReconnectTime { get; set; }

        /// <summary>
        /// <para>The memory throttling duration of a single process. Valid values: 30 to 120. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemoryDownGradeDuration")]
        [Validation(Required=false)]
        public int? MemoryDownGradeDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable memory overload protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MemoryOverload")]
        [Validation(Required=false)]
        public string MemoryOverload { get; set; }

        /// <summary>
        /// <para>The process name.</para>
        /// </summary>
        [NameInMap("MemoryProcessors")]
        [Validation(Required=false)]
        public List<string> MemoryProcessors { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable memory protection mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MemoryProtectedMode")]
        [Validation(Required=false)]
        public string MemoryProtectedMode { get; set; }

        /// <summary>
        /// <para>The overall memory usage percentage. Valid values: 70 to 90.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("MemoryRateLimit")]
        [Validation(Required=false)]
        public int? MemoryRateLimit { get; set; }

        /// <summary>
        /// <para>The overall memory sampling duration. Valid values: 30 to 60. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemorySampleDuration")]
        [Validation(Required=false)]
        public int? MemorySampleDuration { get; set; }

        /// <summary>
        /// <para>The memory usage percentage of a single process. Valid values: 30 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemorySingleRateLimit")]
        [Validation(Required=false)]
        public int? MemorySingleRateLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide the restart button in the cloud desktop floating ball when connecting to the cloud desktop from a mobile client (Android client&lt;props=&quot;china&quot;&gt; and iOS client).</para>
        /// <remarks>
        /// <para>This parameter applies only to mobile clients of V7.4 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileRestart")]
        [Validation(Required=false)]
        public string MobileRestart { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the security button for Windows on the mobile client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileSafeMenu")]
        [Validation(Required=false)]
        public string MobileSafeMenu { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide the shutdown button in the cloud desktop floating ball when connecting to the cloud desktop from a mobile client (Android client&lt;props=&quot;china&quot;&gt; and iOS client).</para>
        /// <remarks>
        /// <para>This parameter applies only to mobile clients of V7.4 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileShutdown")]
        [Validation(Required=false)]
        public string MobileShutdown { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable WUYING Keeper on the mobile client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileWuyingKeeper")]
        [Validation(Required=false)]
        public string MobileWuyingKeeper { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable WUYING Assistant on the mobile client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileWyAssistant")]
        [Validation(Required=false)]
        public string MobileWyAssistant { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the model library feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ModelLibrary")]
        [Validation(Required=false)]
        public string ModelLibrary { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the multi-screen display feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
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
        /// <para>This feature is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("NetRedirect")]
        [Validation(Required=false)]
        public string NetRedirect { get; set; }

        /// <summary>
        /// <para>The details of the network redirect policy.</para>
        /// <remarks>
        /// <para>This feature is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("NetRedirectRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestNetRedirectRule> NetRedirectRule { get; set; }
        public class ModifyCenterPolicyRequestNetRedirectRule : TeaModel {
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
            /// <para>The redirect policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to disconnect the session when no operation is performed.</para>
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
        /// <para>The idle disconnection period. Valid values: 120 to 7200. Unit: seconds.</para>
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
        /// <para>The ID of the cloud desktop policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-53iyi2aar0nd6****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the port proxy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PortProxy")]
        [Validation(Required=false)]
        public string PortProxy { get; set; }

        /// <summary>
        /// <para>The printer pop-up prompt. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: Default value.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// <item><description>custom: Custom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PrinterAlert")]
        [Validation(Required=false)]
        public string PrinterAlert { get; set; }

        /// <summary>
        /// <para>The content of the printer pop-up prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Print Content.</para>
        /// </summary>
        [NameInMap("PrinterAlertContent")]
        [Validation(Required=false)]
        public string PrinterAlertContent { get; set; }

        /// <summary>
        /// <para>The title of the printer pop-up prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Print Title</para>
        /// </summary>
        [NameInMap("PrinterAlertTitle")]
        [Validation(Required=false)]
        public string PrinterAlertTitle { get; set; }

        /// <summary>
        /// <para>The printer redirection policy. This parameter takes effect only when no printer redirection policy is specified in DeviceRedirects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PrinterRedirect")]
        [Validation(Required=false)]
        public string PrinterRedirect { get; set; }

        /// <summary>
        /// <para>Indicates whether image quality enhancement is enabled for the design and 3D application common scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("QualityEnhancement")]
        [Validation(Required=false)]
        public string QualityEnhancement { get; set; }

        /// <summary>
        /// <para>The duration of screen recording after an event is detected in screen recording audits. Unit: minutes. Valid values: 10 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordEventDuration")]
        [Validation(Required=false)]
        public int? RecordEventDuration { get; set; }

        /// <summary>
        /// <para>The file extensions of recording events.</para>
        /// </summary>
        [NameInMap("RecordEventFileExts")]
        [Validation(Required=false)]
        public List<string> RecordEventFileExts { get; set; }

        /// <summary>
        /// <para>The absolute paths for file monitoring in screen recording audits.</para>
        /// </summary>
        [NameInMap("RecordEventFilePaths")]
        [Validation(Required=false)]
        public List<string> RecordEventFilePaths { get; set; }

        /// <summary>
        /// <para>The levels of recording events.</para>
        /// </summary>
        [NameInMap("RecordEventLevels")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestRecordEventLevels> RecordEventLevels { get; set; }
        public class ModifyCenterPolicyRequestRecordEventLevels : TeaModel {
            /// <summary>
            /// <para>The event level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StartApplication</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

        }

        /// <summary>
        /// <para>The absolute paths for registry monitoring in screen recording audits.</para>
        /// </summary>
        [NameInMap("RecordEventRegisters")]
        [Validation(Required=false)]
        public List<string> RecordEventRegisters { get; set; }

        /// <summary>
        /// <para>The list of screen recording events.</para>
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
        /// <para>The audio recording option for cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RecordingAudio")]
        [Validation(Required=false)]
        public string RecordingAudio { get; set; }

        /// <summary>
        /// <para>The duration of each screen recording file, in minutes. Recording files are automatically split and uploaded to the storage space based on the specified duration. Files are rolled over when they reach 300 MB. Valid values: 10 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordingDuration")]
        [Validation(Required=false)]
        public int? RecordingDuration { get; set; }

        /// <summary>
        /// <para>The end time of screen recording. Format: HH:MM:SS. This response value is meaningful only when <c>Recording</c> is set to <c>PERIOD</c>.</para>
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
        public int? RecordingExpires { get; set; }

        /// <summary>
        /// <para>The screen recording frame rate. Unit: FPS (frames per second).</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RecordingFps")]
        [Validation(Required=false)]
        public string RecordingFps { get; set; }

        /// <summary>
        /// <para>The start time of screen recording. Format: HH:MM:SS. This response value is meaningful only when <c>Recording</c> is set to <c>PERIOD</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00:00</para>
        /// </summary>
        [NameInMap("RecordingStartTime")]
        [Validation(Required=false)]
        public string RecordingStartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to notify end users that screen recording is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("RecordingUserNotify")]
        [Validation(Required=false)]
        public string RecordingUserNotify { get; set; }

        /// <summary>
        /// <para>The notification message displayed to end users when screen recording is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Screen recording is enabled</para>
        /// </summary>
        [NameInMap("RecordingUserNotifyMessage")]
        [Validation(Required=false)]
        public string RecordingUserNotifyMessage { get; set; }

        /// <summary>
        /// <para>The region ID. This feature is region-independent. Set this parameter to <c>cn-shanghai</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The keyboard and mouse control permission for remote assistance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fullControl</para>
        /// </summary>
        [NameInMap("RemoteCoordinate")]
        [Validation(Required=false)]
        public string RemoteCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow resetting the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ResetDesktop")]
        [Validation(Required=false)]
        public string ResetDesktop { get; set; }

        /// <summary>
        /// <para>The DPI value of the screen resolution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("ResolutionDpi")]
        [Validation(Required=false)]
        public int? ResolutionDpi { get; set; }

        /// <summary>
        /// <para>The height of the resolution. Unit: pixels. Valid values for cloud applications: 500 to 50000. Valid values for cloud desktops: 480 to 4096.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// <para>The resolution type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adaptive</para>
        /// </summary>
        [NameInMap("ResolutionModel")]
        [Validation(Required=false)]
        public string ResolutionModel { get; set; }

        /// <summary>
        /// <para>The width of the resolution. Unit: pixels. Valid values for cloud applications: 500 to 50000. Valid values for cloud desktops: 480 to 4096.</para>
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
        /// <para>The list of client IP whitelist entries to delete.</para>
        /// </summary>
        [NameInMap("RevokeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestRevokeAccessPolicyRule> RevokeAccessPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestRevokeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>The client IP address range to delete. The value is an IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>The description of the client IP whitelist entry to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Corporate office network segment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The list of security group rules to delete.</para>
        /// </summary>
        [NameInMap("RevokeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestRevokeSecurityPolicyRule> RevokeSecurityPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestRevokeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <para>The target of the security group rule to delete. The value is an IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>The description of the security group rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow access to the internal R&amp;D environment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The protocol type of the security group rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The authorization policy of the security group rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The port range of the security group rule to delete. The port range is determined by the value of IpProtocol:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: The port range is 1 to 65535. Separate the start port and end port with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>If IpProtocol is set to all: -1/-1.</description></item>
            /// </list>
            /// <para>For more information about common ports of typical applications, see <a href="https://help.aliyun.com/document_detail/40724.html">Common ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of the security group rule to delete. A smaller value indicates a higher priority. Valid values: 1 to 60. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The direction of the security group rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>outflow</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the Security Center shortcut key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SafeMenu")]
        [Validation(Required=false)]
        public string SafeMenu { get; set; }

        /// <summary>
        /// <para>The scope in which the policy takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The value to specify when <c>Scope</c> is set to <c>IP</c>. This parameter takes effect only when <c>Scope</c> is set to <c>IP</c>.</para>
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public List<string> ScopeValue { get; set; }

        /// <summary>
        /// <para>The screen display mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("ScreenDisplayMode")]
        [Validation(Required=false)]
        public string ScreenDisplayMode { get; set; }

        /// <summary>
        /// <para>The maximum value of session bandwidth throttling. Unit: Kbps. Valid values: 2000 to 100000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("SessionMaxRateKbps")]
        [Validation(Required=false)]
        public int? SessionMaxRateKbps { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable smoothness enhancement for the daily office scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SmoothEnhancement")]
        [Validation(Required=false)]
        public string SmoothEnhancement { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide the status monitoring entry in the cloud desktop floating ball.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("StatusMonitor")]
        [Validation(Required=false)]
        public string StatusMonitor { get; set; }

        /// <summary>
        /// <para>The streaming mode adaptation scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>smooth</para>
        /// </summary>
        [NameInMap("StreamingMode")]
        [Validation(Required=false)]
        public string StreamingMode { get; set; }

        /// <summary>
        /// <para>The target frame rate. Valid values: 10 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TargetFps")]
        [Validation(Required=false)]
        public int? TargetFps { get; set; }

        /// <summary>
        /// <para>The application taskbar.</para>
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
        /// <para>Specifies whether to enable the three-screen feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ThreeScreen")]
        [Validation(Required=false)]
        public string ThreeScreen { get; set; }

        /// <summary>
        /// <para>The USB redirection policy.</para>
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
        public List<ModifyCenterPolicyRequestUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
        public class ModifyCenterPolicyRequestUsbSupplyRedirectRule : TeaModel {
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
            public string UsbRedirectType { get; set; }

            /// <summary>
            /// <para>The USB redirection rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsbRuleType")]
            [Validation(Required=false)]
            public string UsbRuleType { get; set; }

            /// <summary>
            /// <para>The vendor ID. See <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB Vendor IDs (VIDs)</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04**</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to display the usage duration in the floating ball. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("UseTime")]
        [Validation(Required=false)]
        public string UseTime { get; set; }

        /// <summary>
        /// <para>The average bitrate for video encoding. Unit: Kbps. Valid values: 1000 to 50000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoEncAvgKbps")]
        [Validation(Required=false)]
        public int? VideoEncAvgKbps { get; set; }

        /// <summary>
        /// <para>The maximum QP for video encoding, which represents the lowest quality. Valid values: 0 to 51.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("VideoEncMaxQP")]
        [Validation(Required=false)]
        public int? VideoEncMaxQP { get; set; }

        /// <summary>
        /// <para>The minimum QP for video encoding, which represents the highest quality. Valid values: 0 to 51.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("VideoEncMinQP")]
        [Validation(Required=false)]
        public int? VideoEncMinQP { get; set; }

        /// <summary>
        /// <para>The peak video encoding bitrate. Unit: Kbps. Valid values: 1000 to 50000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoEncPeakKbps")]
        [Validation(Required=false)]
        public int? VideoEncPeakKbps { get; set; }

        /// <summary>
        /// <para>The video encoding policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qualityFirst</para>
        /// </summary>
        [NameInMap("VideoEncPolicy")]
        [Validation(Required=false)]
        public string VideoEncPolicy { get; set; }

        /// <summary>
        /// <para>The multimedia redirection policy.</para>
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
        /// <para>The watermark policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        /// <summary>
        /// <para>The invisible watermark anti-photography feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WatermarkAntiCam")]
        [Validation(Required=false)]
        public string WatermarkAntiCam { get; set; }

        /// <summary>
        /// <para>The watermark font color. Valid values: 0 to 16777215.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WatermarkColor")]
        [Validation(Required=false)]
        public int? WatermarkColor { get; set; }

        /// <summary>
        /// <para>The number of watermark columns. Valid values: 3 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("WatermarkColumnAmount")]
        [Validation(Required=false)]
        public int? WatermarkColumnAmount { get; set; }

        /// <summary>
        /// <para>If the <c>WatermarkType</c> parameter is set to <c>custom</c>, you must also specify the custom text content by using the <c>WatermarkCustomText</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal Document</para>
        /// </summary>
        [NameInMap("WatermarkCustomText")]
        [Validation(Required=false)]
        public string WatermarkCustomText { get; set; }

        /// <summary>
        /// <para>The watermark tilt angle. Valid values: -10 to -30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-10</para>
        /// </summary>
        [NameInMap("WatermarkDegree")]
        [Validation(Required=false)]
        public double? WatermarkDegree { get; set; }

        /// <summary>
        /// <para>The watermark font size. Valid values: 10 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WatermarkFontSize")]
        [Validation(Required=false)]
        public int? WatermarkFontSize { get; set; }

        /// <summary>
        /// <para>The watermark font style.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plain</para>
        /// </summary>
        [NameInMap("WatermarkFontStyle")]
        [Validation(Required=false)]
        public string WatermarkFontStyle { get; set; }

        /// <summary>
        /// <para>The invisible watermark enhancement feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("WatermarkPower")]
        [Validation(Required=false)]
        public string WatermarkPower { get; set; }

        /// <summary>
        /// <para>The number of watermark rows. Valid values: 3 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("WatermarkRowAmount")]
        [Validation(Required=false)]
        public int? WatermarkRowAmount { get; set; }

        /// <summary>
        /// <para>The security priority rule for invisible watermarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WatermarkSecurity")]
        [Validation(Required=false)]
        public string WatermarkSecurity { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the watermark shadow effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WatermarkShadow")]
        [Validation(Required=false)]
        public string WatermarkShadow { get; set; }

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
        /// <para>The watermark type. You can select up to three types, separated by commas (,).</para>
        /// <remarks>
        /// <para>If you set this parameter to <c>custom</c>, you must also specify the custom text content by using the <c>WatermarkCustomText</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EndUserId</para>
        /// </summary>
        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable WUYING Keeper.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WuyingKeeper")]
        [Validation(Required=false)]
        public string WuyingKeeper { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide the WUYING AI Assistant entry in the floating ball when connecting to a cloud computer through a desktop client (including Windows client and macOS client).</para>
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
