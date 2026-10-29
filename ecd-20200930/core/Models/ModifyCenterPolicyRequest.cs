// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyCenterPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the academic proxy feature is enabled. Valid values:</para>
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
        /// <para>Specifies whether the user has administrator permissions after logging on to the cloud computer.</para>
        /// <remarks>
        /// <para>This feature is in targeted invitation-only preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("AdminAccess")]
        [Validation(Required=false)]
        public string AdminAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether administrator keyboard control in full-screen mode is enabled. Valid values:</para>
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
        /// <para>Specifies whether administrator keyboard control in Windows is enabled. Valid values:</para>
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
        /// <para>Specifies whether to enable the screen capture prevention feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AppContentProtection")]
        [Validation(Required=false)]
        public string AppContentProtection { get; set; }

        /// <summary>
        /// <para>The list of custom OSS buckets for mobile screenshots in the anti-screen capture feature.</para>
        /// </summary>
        [NameInMap("AppScreenshotBuckets")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestAppScreenshotBuckets> AppScreenshotBuckets { get; set; }
        public class ModifyCenterPolicyRequestAppScreenshotBuckets : TeaModel {
            /// <summary>
            /// <para>The name of the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc-bucket</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The region where the user\&quot;s OSS bucket is located. It must be the same as the actual region of the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("BucketRegionId")]
            [Validation(Required=false)]
            public string BucketRegionId { get; set; }

        }

        /// <summary>
        /// <para>The list of client IP address whitelists to add.</para>
        /// </summary>
        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestAuthorizeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR block for client access.</para>
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
            /// <para>Corporate office network segment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The list of new security group control rules.</para>
        /// </summary>
        [NameInMap("AuthorizeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestAuthorizeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <para>The target of the security group control rule, which is an IPv4 CIDR block.</para>
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
            /// <para>The port range of the security group control rule. The valid port range is determined by the IpProtocol parameter:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: Valid values are 1 to 65535. Separate the start port and the end port with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>ICMP: Set the value to -1/-1.</description></item>
            /// <item><description>GRE: Set the value to -1/-1.</description></item>
            /// <item><description>all: Set the value to -1/-1.</description></item>
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
        /// <para>The auto-reconnect after disconnection setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AutoReconnect")]
        [Validation(Required=false)]
        public string AutoReconnect { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically save mobile screenshots. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AutoSaveAppScreenshot")]
        [Validation(Required=false)]
        public string AutoSaveAppScreenshot { get; set; }

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
        /// <para>The local camera redirection settings. This parameter takes effect when no local camera redirection policy is specified in DeviceRedirects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// <para>The client control menu display switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("ClientControlMenu")]
        [Validation(Required=false)]
        public string ClientControlMenu { get; set; }

        /// <summary>
        /// <para>Specifies whether the feature for clients to create custom snapshots is enabled. Valid values:</para>
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
        /// <para>The list of logon method control rules. This parameter is used to control which clients can be used to access the cloud desktop.</para>
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
            /// <para>Specifies whether to allow a specific type of client to log on to the cloud desktop for logon method control.</para>
            /// <remarks>
            /// <para>If you do not configure the ClientType-related parameters, all types of clients are allowed to log on to the cloud desktop by default.</para>
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

        /// <summary>
        /// <para>The fine-grained clipboard control configuration.</para>
        /// </summary>
        [NameInMap("ClipboardGraineds")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestClipboardGraineds> ClipboardGraineds { get; set; }
        public class ModifyCenterPolicyRequestClipboardGraineds : TeaModel {
            /// <summary>
            /// <para>The maximum size of a single clipboard transfer. This parameter must be used together with the size unit parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ClipboardSize")]
            [Validation(Required=false)]
            public int? ClipboardSize { get; set; }

            /// <summary>
            /// <para>The unit of the maximum size for a single clipboard transfer.</para>
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
            /// <item><description>off: Disable the clipboard.</description></item>
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
            /// <para>The maximum size of a single clipboard transfer to the cloud desktop. This parameter must be used together with the inbound size unit parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InClipboardSize")]
            [Validation(Required=false)]
            public int? InClipboardSize { get; set; }

            /// <summary>
            /// <para>The unit of the maximum size for a single clipboard transfer to the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MB</para>
            /// </summary>
            [NameInMap("InClipboardSizeUnit")]
            [Validation(Required=false)]
            public string InClipboardSizeUnit { get; set; }

            /// <summary>
            /// <para>The maximum size of a single clipboard transfer from the cloud desktop. This parameter must be used together with the outbound size unit parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OutClipboardSize")]
            [Validation(Required=false)]
            public int? OutClipboardSize { get; set; }

            /// <summary>
            /// <para>The unit of the maximum size for a single clipboard transfer from the cloud desktop.</para>
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
        /// <para>Specifies whether color enhancement is enabled in common scenarios such as design and 3D applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ColorEnhancement")]
        [Validation(Required=false)]
        public string ColorEnhancement { get; set; }

        /// <summary>
        /// <para>The local drive clipboard feature switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CpdDriveClipboard")]
        [Validation(Required=false)]
        public string CpdDriveClipboard { get; set; }

        /// <summary>
        /// <para>The CPU frequency reduction duration. Valid values: 30 to 120. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("CpuDownGradeDuration")]
        [Validation(Required=false)]
        public int? CpuDownGradeDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether CPU overload protection is enabled. Valid values:</para>
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
        /// <para>The overall CPU utilization percentage. Valid values: 70 to 90.</para>
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
        /// <para>The single-core CPU utilization percentage. Valid values: 70 to 100.</para>
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
        /// <para>The peripheral connection prompt control.</para>
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
        /// <para>The session retention setting after disconnection.</para>
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
        /// <para>Specifies whether disk overload protection is enabled. Valid values:</para>
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
        /// <para>Specifies whether users can request administrator assistance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EndUserApplyAdminCoordinate")]
        [Validation(Required=false)]
        public string EndUserApplyAdminCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether users in the same office network can share cloud computers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EndUserGroupCoordinate")]
        [Validation(Required=false)]
        public string EndUserGroupCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether the use of external storage devices is enabled. Valid values:</para>
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
        /// <para>The file migration setting.</para>
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
        /// <para>The file size limit for a single transfer to the cloud desktop. This parameter must be used together with the transfer-in unit parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("FileTransferInSize")]
        [Validation(Required=false)]
        public string FileTransferInSize { get; set; }

        /// <summary>
        /// <para>The unit of the file size limit for a single transfer to the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MB</para>
        /// </summary>
        [NameInMap("FileTransferInUnit")]
        [Validation(Required=false)]
        public string FileTransferInUnit { get; set; }

        /// <summary>
        /// <para>The file size limit for a single transfer from the cloud desktop. This parameter must be used together with the transfer-out unit parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("FileTransferOutSize")]
        [Validation(Required=false)]
        public string FileTransferOutSize { get; set; }

        /// <summary>
        /// <para>The unit of the file size limit for a single transfer from the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MB</para>
        /// </summary>
        [NameInMap("FileTransferOutUnit")]
        [Validation(Required=false)]
        public string FileTransferOutUnit { get; set; }

        /// <summary>
        /// <para>Specifies whether the file transfer size limit is enabled. Valid values:</para>
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
        /// <para>The effective location of the file transfer speed configured on the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client</para>
        /// </summary>
        [NameInMap("FileTransferSpeedLocation")]
        [Validation(Required=false)]
        public string FileTransferSpeedLocation { get; set; }

        /// <summary>
        /// <para>Specifies whether file synchronization is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("FolderSync")]
        [Validation(Required=false)]
        public string FolderSync { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the image quality policy for cloud desktops with graphics-optimized specifications. Enable this policy when high performance and user experience are required, such as in professional design scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public string GpuAcceleration { get; set; }

        /// <summary>
        /// <para>Specifies whether the floating ball configuration message prompt is enabled. Valid values:</para>
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
        /// <para>The network printer feature switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
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
        /// <para>The maximum retry time for reconnecting to a cloud desktop after a disconnection caused by objective reasons. Valid values: 30 to 7200. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MaxReconnectTime")]
        [Validation(Required=false)]
        public int? MaxReconnectTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the MCP service is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("McpService")]
        [Validation(Required=false)]
        public string McpService { get; set; }

        /// <summary>
        /// <para>The memory downgrade duration for a single process. Valid values: 30 to 120. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemoryDownGradeDuration")]
        [Validation(Required=false)]
        public int? MemoryDownGradeDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether memory overload protection is enabled. Valid values:</para>
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
        /// <para>The overall memory utilization percentage. Valid values: 70 to 90.</para>
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
        /// <para>The memory utilization percentage of a single process. Valid values: 30 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemorySingleRateLimit")]
        [Validation(Required=false)]
        public int? MemorySingleRateLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide a restart button in the floating ball of the cloud desktop when you connect to the cloud desktop from a mobile client (Android client&lt;props=&quot;china&quot;&gt; and iOS client).</para>
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
        /// <para>The mobile Windows system security button switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileSafeMenu")]
        [Validation(Required=false)]
        public string MobileSafeMenu { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide a shutdown button in the floating ball of the cloud desktop when you connect to the cloud desktop from a mobile client (Android client&lt;props=&quot;china&quot;&gt; and iOS client).</para>
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
        /// <para>The mobile Wuying Keeper switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileWuyingKeeper")]
        [Validation(Required=false)]
        public string MobileWuyingKeeper { get; set; }

        /// <summary>
        /// <para>Specifies whether the mobile WUYING Assistant is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileWyAssistant")]
        [Validation(Required=false)]
        public string MobileWyAssistant { get; set; }

        /// <summary>
        /// <para>Specifies whether the model library feature is enabled. Valid values:</para>
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
        /// <para>Specifies whether the multi-screen display feature is enabled. Valid values:</para>
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
        /// <para>The details of the network redirection policy.</para>
        /// <remarks>
        /// <para>This feature is in invitation-only preview and is not publicly available.</para>
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
            /// <para>The redirection policy.</para>
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
        /// <para>The disconnect on inactivity setting.</para>
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
        /// <para>The inactivity timeout period before disconnection. Valid values: 120 to 7200. Unit: seconds.</para>
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
        /// <para>Specifies whether the port proxy feature is enabled. Valid values:</para>
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
        /// <para>The printer redirection policy. This parameter takes effect when no printer redirection policy is specified in DeviceRedirects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PrinterRedirect")]
        [Validation(Required=false)]
        public string PrinterRedirect { get; set; }

        /// <summary>
        /// <para>Specifies whether image quality enhancement is enabled in common scenarios such as design and 3D applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("QualityEnhancement")]
        [Validation(Required=false)]
        public string QualityEnhancement { get; set; }

        /// <summary>
        /// <para>The screen recording duration after an event is detected in the screen recording audit. Unit: minutes. Valid values: 10 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordEventDuration")]
        [Validation(Required=false)]
        public int? RecordEventDuration { get; set; }

        /// <summary>
        /// <para>The screen recording event file extensions.</para>
        /// </summary>
        [NameInMap("RecordEventFileExts")]
        [Validation(Required=false)]
        public List<string> RecordEventFileExts { get; set; }

        /// <summary>
        /// <para>The absolute paths for file monitoring in screen recording audit.</para>
        /// </summary>
        [NameInMap("RecordEventFilePaths")]
        [Validation(Required=false)]
        public List<string> RecordEventFilePaths { get; set; }

        /// <summary>
        /// <para>The screen recording event levels.</para>
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
        /// <para>The absolute paths for registry monitoring in screen recording audit.</para>
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
        /// <para>The audio recording option for the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RecordingAudio")]
        [Validation(Required=false)]
        public string RecordingAudio { get; set; }

        /// <summary>
        /// <para>The viewing duration of the screen recording file. Unit: minutes. The recording file is automatically split and uploaded to the storage space based on the specified duration. When the file size reaches 300 MB, it is preferentially updated in a rolling manner. Valid values: 10 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordingDuration")]
        [Validation(Required=false)]
        public int? RecordingDuration { get; set; }

        /// <summary>
        /// <para>The end time of screen recording. Format: HH:MM:SS. This parameter is valid only when Recording is set to PERIOD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:59:00</para>
        /// </summary>
        [NameInMap("RecordingEndTime")]
        [Validation(Required=false)]
        public string RecordingEndTime { get; set; }

        /// <summary>
        /// <para>The retention period of the screen recording file. Valid values: 1 to 180 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("RecordingExpires")]
        [Validation(Required=false)]
        public int? RecordingExpires { get; set; }

        /// <summary>
        /// <para>The frame rate of screen recording. Unit: FPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RecordingFps")]
        [Validation(Required=false)]
        public string RecordingFps { get; set; }

        /// <summary>
        /// <para>The start time of screen recording. Format: HH:MM:SS. This parameter is valid only when Recording is set to PERIOD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00:00</para>
        /// </summary>
        [NameInMap("RecordingStartTime")]
        [Validation(Required=false)]
        public string RecordingStartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to notify the end user that screen recording is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("RecordingUserNotify")]
        [Validation(Required=false)]
        public string RecordingUserNotify { get; set; }

        /// <summary>
        /// <para>The notification message sent to the end user when screen recording is enabled.</para>
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
        /// <para>The keyboard and mouse control permissions for remote assistance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fullControl</para>
        /// </summary>
        [NameInMap("RemoteCoordinate")]
        [Validation(Required=false)]
        public string RemoteCoordinate { get; set; }

        /// <summary>
        /// <para>The cloud desktop reset setting.</para>
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
        /// <para>The list of client IP address whitelists to delete.</para>
        /// </summary>
        [NameInMap("RevokeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestRevokeAccessPolicyRule> RevokeAccessPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestRevokeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR block of the client IP address whitelist to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>The description of the client IP address whitelist to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Corporate office network segment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The list of security group policy rules to delete.</para>
        /// </summary>
        [NameInMap("RevokeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyCenterPolicyRequestRevokeSecurityPolicyRule> RevokeSecurityPolicyRule { get; set; }
        public class ModifyCenterPolicyRequestRevokeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR block of the security group policy rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>The description of the security group policy rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow access to the internal R&amp;D environment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The protocol type of the security group policy rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The authorization policy of the security group policy rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The port range of the security group policy rule to delete. The valid port range depends on the value of IpProtocol:</para>
            /// <list type="bullet">
            /// <item><description>TCP or UDP: 1 to 65535. Separate the start port and the end port with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>ICMP: -1/-1.</description></item>
            /// <item><description>GRE: -1/-1.</description></item>
            /// <item><description>all: -1/-1.</description></item>
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
            /// <para>The priority of the security group policy rule to delete. A smaller value indicates a higher priority. Valid values: 1 to 60. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The direction of the security group policy rule to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>outflow</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The Security Center shortcut switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
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
        /// <para>The value specified when Scope is set to IP. This parameter takes effect only when Scope is set to IP.</para>
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
        /// <para>The maximum value for session bandwidth throttling. Unit: Kbps. Valid values: 2000 to 100000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("SessionMaxRateKbps")]
        [Validation(Required=false)]
        public int? SessionMaxRateKbps { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable smoothness enhancement in daily office scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SmoothEnhancement")]
        [Validation(Required=false)]
        public string SmoothEnhancement { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide an entry for the status monitoring feature in the floating ball of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("StatusMonitor")]
        [Validation(Required=false)]
        public string StatusMonitor { get; set; }

        /// <summary>
        /// <para>The applicable scenario for the streaming mode.</para>
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
        /// <para>Specifies whether the triple-screen feature is enabled. Valid values:</para>
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
        /// <para>The floating ball usage duration display switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
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
        /// <para>The maximum QP for video encoding, which indicates the lowest image quality. Valid values: 0 to 51.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("VideoEncMaxQP")]
        [Validation(Required=false)]
        public int? VideoEncMaxQP { get; set; }

        /// <summary>
        /// <para>The minimum quantization parameter (QP) for video encoding, which indicates the highest quality. Valid values: 0 to 51.</para>
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
        /// <para>The multimedia redirection settings.</para>
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
        /// <para>The watermark settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        /// <summary>
        /// <para>The blind watermark anti-photography feature.</para>
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
        /// <para>The number of watermark columns. Valid values: 3 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("WatermarkColumnAmount")]
        [Validation(Required=false)]
        public int? WatermarkColumnAmount { get; set; }

        /// <summary>
        /// <para>If you set the <c>WatermarkType</c> parameter to <c>custom</c>, you must also use the <c>WatermarkCustomText</c> parameter to specify the custom text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Confidential</para>
        /// </summary>
        [NameInMap("WatermarkCustomText")]
        [Validation(Required=false)]
        public string WatermarkCustomText { get; set; }

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
        /// <para>The blind watermark enhancement feature.</para>
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
        /// <para>The security priority rule for blind watermarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WatermarkSecurity")]
        [Validation(Required=false)]
        public string WatermarkSecurity { get; set; }

        /// <summary>
        /// <para>Specifies whether the watermark shadow effect is enabled. Valid values:</para>
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
        /// <para>The watermark type. You can select up to three types and separate them with commas.</para>
        /// <remarks>
        /// <para>If you set this parameter to <c>custom</c>, you must also use the <c>WatermarkCustomText</c> parameter to specify the custom text.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EndUserId</para>
        /// </summary>
        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

        /// <summary>
        /// <para>The Wuying Keeper switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WuyingKeeper")]
        [Validation(Required=false)]
        public string WuyingKeeper { get; set; }

        /// <summary>
        /// <para>Specifies whether to provide an entry for the WUYING AI Assistant in the floating widget of the cloud desktop when you connect to the cloud desktop by using a desktop client, including Windows and macOS clients.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to desktop clients of V7.7 or later.</para>
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
