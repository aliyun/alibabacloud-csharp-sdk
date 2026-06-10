// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePolicyGroupsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The detailed information about the cloud computer policies.</para>
        /// </summary>
        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=false)]
        public List<DescribePolicyGroupsResponseBodyDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribePolicyGroupsResponseBodyDescribePolicyGroups : TeaModel {
            [NameInMap("AcademicProxy")]
            [Validation(Required=false)]
            public string AcademicProxy { get; set; }

            /// <summary>
            /// <para>Whether end users have administrative permission after connecting to the cloud computer.</para>
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

            [NameInMap("AdminKeyboardOnFullScreen")]
            [Validation(Required=false)]
            public string AdminKeyboardOnFullScreen { get; set; }

            [NameInMap("AdminKeyboardOnWindows")]
            [Validation(Required=false)]
            public string AdminKeyboardOnWindows { get; set; }

            /// <summary>
            /// <para>Whether to enable the anti-screenshot feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AppContentProtection")]
            [Validation(Required=false)]
            public string AppContentProtection { get; set; }

            /// <summary>
            /// <para>The client IP address whitelist. Only IP addresses within the whitelisted CIDR blocks can access the cloud computer.</para>
            /// </summary>
            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules : TeaModel {
                /// <summary>
                /// <para>The client-accessible IP address segment. The value is an IPv4 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX/16</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>The remarks for the client-accessible CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>The security group control rules.</para>
            /// </summary>
            [NameInMap("AuthorizeSecurityPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules> AuthorizeSecurityPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules : TeaModel {
                /// <summary>
                /// <para>The target of the security group control rule. The value is an IPv4 CIDR block.</para>
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
                /// <para>test</para>
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
                /// <para>The port range of the security group control rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22/22</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>The priority of the security group control rule. A smaller number indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// <para>The rule direction of the security group control rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>inflow</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The automatic client reconnection configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AutoReconnect")]
            [Validation(Required=false)]
            public string AutoReconnect { get; set; }

            /// <summary>
            /// <para>Whether to enable local camera redirection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CameraRedirect")]
            [Validation(Required=false)]
            public string CameraRedirect { get; set; }

            [NameInMap("ClientControlMenu")]
            [Validation(Required=false)]
            public string ClientControlMenu { get; set; }

            [NameInMap("ClientCreateSnapshot")]
            [Validation(Required=false)]
            public string ClientCreateSnapshot { get; set; }

            [NameInMap("ClientHibernate")]
            [Validation(Required=false)]
            public string ClientHibernate { get; set; }

            [NameInMap("ClientRestart")]
            [Validation(Required=false)]
            public string ClientRestart { get; set; }

            [NameInMap("ClientShutdown")]
            [Validation(Required=false)]
            public string ClientShutdown { get; set; }

            /// <summary>
            /// <para>The logon method control list. Controls which clients can access the cloud computer.</para>
            /// </summary>
            [NameInMap("ClientTypes")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsClientTypes> ClientTypes { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsClientTypes : TeaModel {
                /// <summary>
                /// <para>The client type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <para>Whether a specific client type is allowed to connect to the cloud computer.</para>
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
            /// <para>Whether to enable color enhancement for design and 3D application scenarios.</para>
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
            /// <para>The CPU downclocking duration in seconds. Valid values: 30 to 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CpuDownGradeDuration")]
            [Validation(Required=false)]
            public int? CpuDownGradeDuration { get; set; }

            [NameInMap("CpuOverload")]
            [Validation(Required=false)]
            public string CpuOverload { get; set; }

            /// <summary>
            /// <para>The process whitelist exempt from CPU usage limits.</para>
            /// </summary>
            [NameInMap("CpuProcessors")]
            [Validation(Required=false)]
            public List<string> CpuProcessors { get; set; }

            /// <summary>
            /// <para>The CPU protection mode switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
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
            /// <para>The overall CPU sampling duration in seconds. Valid values: 10 to 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CpuSampleDuration")]
            [Validation(Required=false)]
            public int? CpuSampleDuration { get; set; }

            /// <summary>
            /// <para>The single-core CPU usage percentage. Valid values: 70 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("CpuSingleRateLimit")]
            [Validation(Required=false)]
            public int? CpuSingleRateLimit { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The number of cloud computers associated with this policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public int? DesktopCount { get; set; }

            /// <summary>
            /// <para>The number of cloud computer pools associated with this policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public int? DesktopGroupCount { get; set; }

            [NameInMap("DeviceConnectHint")]
            [Validation(Required=false)]
            public string DeviceConnectHint { get; set; }

            /// <summary>
            /// <para>The device redirection rule list.</para>
            /// </summary>
            [NameInMap("DeviceRedirects")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsDeviceRedirects> DeviceRedirects { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsDeviceRedirects : TeaModel {
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
                /// <list type="bullet">
                /// <item><description><para>usbRedirect: USB redirection.</para>
                /// </description></item>
                /// <item><description><para>deviceRedirect: Device redirection.</para>
                /// </description></item>
                /// <item><description><para>off: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>usbRedirect</para>
                /// </summary>
                [NameInMap("RedirectType")]
                [Validation(Required=false)]
                public string RedirectType { get; set; }

            }

            /// <summary>
            /// <para>The custom peripheral rule list.</para>
            /// </summary>
            [NameInMap("DeviceRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsDeviceRules> DeviceRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsDeviceRules : TeaModel {
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

            [NameInMap("DiskOverload")]
            [Validation(Required=false)]
            public string DiskOverload { get; set; }

            /// <summary>
            /// <para>The display mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adminCustom</para>
            /// </summary>
            [NameInMap("DisplayMode")]
            [Validation(Required=false)]
            public string DisplayMode { get; set; }

            /// <summary>
            /// <para>The access control for domain names. Wildcards (\*) are supported. Separate multiple domain names with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public string DomainList { get; set; }

            /// <summary>
            /// <para>The domain name resolution policy list.</para>
            /// </summary>
            [NameInMap("DomainResolveRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsDomainResolveRule> DomainResolveRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsDomainResolveRule : TeaModel {
                /// <summary>
                /// <para>The policy description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试规则</para>
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
            /// <para>The domain name resolution policy switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("DomainResolveRuleType")]
            [Validation(Required=false)]
            public string DomainResolveRuleType { get; set; }

            /// <summary>
            /// <para>The total number of cloud computers and cloud computer pools associated with this policy. This value is returned only for custom policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EdsCount")]
            [Validation(Required=false)]
            public int? EdsCount { get; set; }

            /// <summary>
            /// <para>The switch for users to request administrator assistance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("EndUserApplyAdminCoordinate")]
            [Validation(Required=false)]
            public string EndUserApplyAdminCoordinate { get; set; }

            [NameInMap("EndUserCount")]
            [Validation(Required=false)]
            public string EndUserCount { get; set; }

            /// <summary>
            /// <para>The switch for stream collaboration between users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("EndUserGroupCoordinate")]
            [Validation(Required=false)]
            public string EndUserGroupCoordinate { get; set; }

            [NameInMap("ExternalDrive")]
            [Validation(Required=false)]
            public string ExternalDrive { get; set; }

            [NameInMap("FileMigrate")]
            [Validation(Required=false)]
            public string FileMigrate { get; set; }

            /// <summary>
            /// <para>File transfer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("FileTransfer")]
            [Validation(Required=false)]
            public string FileTransfer { get; set; }

            [NameInMap("FileTransferAddress")]
            [Validation(Required=false)]
            public string FileTransferAddress { get; set; }

            [NameInMap("FileTransferSpeed")]
            [Validation(Required=false)]
            public string FileTransferSpeed { get; set; }

            [NameInMap("FileTransferSpeedLocation")]
            [Validation(Required=false)]
            public string FileTransferSpeedLocation { get; set; }

            /// <summary>
            /// <para>Whether to enable the image quality policy for graphics-specification cloud computers. Enable this policy if you have high requirements for cloud computer performance and user experience, such as in professional design scenarios.</para>
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

            [NameInMap("HoverHibernate")]
            [Validation(Required=false)]
            public string HoverHibernate { get; set; }

            [NameInMap("HoverRestart")]
            [Validation(Required=false)]
            public string HoverRestart { get; set; }

            [NameInMap("HoverShutdown")]
            [Validation(Required=false)]
            public string HoverShutdown { get; set; }

            /// <summary>
            /// <para>The web client access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Html5Access")]
            [Validation(Required=false)]
            public string Html5Access { get; set; }

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
            /// <para>BOTH</para>
            /// </summary>
            [NameInMap("InternetCommunicationProtocol")]
            [Validation(Required=false)]
            public string InternetCommunicationProtocol { get; set; }

            [NameInMap("InternetPrinter")]
            [Validation(Required=false)]
            public string InternetPrinter { get; set; }

            [NameInMap("KeyboardControl")]
            [Validation(Required=false)]
            public string KeyboardControl { get; set; }

            /// <summary>
            /// <para>The local disk mapping permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            /// <summary>
            /// <para>The maximum retry time for reconnecting to the cloud computer after a disconnection caused by objective reasons. Valid values: 30 to 7200 seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxReconnectTime")]
            [Validation(Required=false)]
            public int? MaxReconnectTime { get; set; }

            /// <summary>
            /// <para>The memory downclocking duration per process in seconds. Valid values: 30 to 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemoryDownGradeDuration")]
            [Validation(Required=false)]
            public int? MemoryDownGradeDuration { get; set; }

            [NameInMap("MemoryOverload")]
            [Validation(Required=false)]
            public string MemoryOverload { get; set; }

            /// <summary>
            /// <para>The process whitelist exempt from memory usage limits.</para>
            /// </summary>
            [NameInMap("MemoryProcessors")]
            [Validation(Required=false)]
            public List<string> MemoryProcessors { get; set; }

            /// <summary>
            /// <para>The memory protection mode switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
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
            /// <para>The overall memory sampling duration in seconds. Valid values: 30 to 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemorySampleDuration")]
            [Validation(Required=false)]
            public int? MemorySampleDuration { get; set; }

            /// <summary>
            /// <para>The memory usage percentage per worker. Valid values: 30 to 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemorySingleRateLimit")]
            [Validation(Required=false)]
            public int? MemorySingleRateLimit { get; set; }

            /// <summary>
            /// <para>Whether to display the restart button in the floating ball when accessing the cloud computer from mobile clients (including Android and iOS clients).</para>
            /// <remarks>
            /// <para>Applies only to mobile clients of V7.4 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileRestart")]
            [Validation(Required=false)]
            public string MobileRestart { get; set; }

            /// <summary>
            /// <para>The Windows security control switch for mobile clients.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileSafeMenu")]
            [Validation(Required=false)]
            public string MobileSafeMenu { get; set; }

            /// <summary>
            /// <para>Whether to display the shutdown button in the floating ball when accessing the cloud computer from mobile clients (including Android and iOS clients).</para>
            /// <remarks>
            /// <para>Applies only to mobile clients of V7.4 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileShutdown")]
            [Validation(Required=false)]
            public string MobileShutdown { get; set; }

            /// <summary>
            /// <para>The WUYING Keeper switch for mobile clients.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileWuyingKeeper")]
            [Validation(Required=false)]
            public string MobileWuyingKeeper { get; set; }

            /// <summary>
            /// <para>The Xiaoying AI Assistant switch for mobile clients.</para>
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
            /// <para>The cloud computer policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testPolicyGroupName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Network redirection.</para>
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
            /// <para>The network redirection policy list.</para>
            /// <remarks>
            /// <para>This feature is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("NetRedirectRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsNetRedirectRule> NetRedirectRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsNetRedirectRule : TeaModel {
                /// <summary>
                /// <para>The policy content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>domain</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

            }

            [NameInMap("NetworkPrinter")]
            [Validation(Required=false)]
            public string NetworkPrinter { get; set; }

            [NameInMap("OrganizationCount")]
            [Validation(Required=false)]
            public string OrganizationCount { get; set; }

            /// <summary>
            /// <para>The cloud computer policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-gx2x1dhsmthe9****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The cloud computer policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("PolicyGroupType")]
            [Validation(Required=false)]
            public string PolicyGroupType { get; set; }

            /// <summary>
            /// <para>The status of the cloud computer policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            [NameInMap("PortProxy")]
            [Validation(Required=false)]
            public string PortProxy { get; set; }

            /// <summary>
            /// <para>The cloud computer preemption policy.</para>
            /// <remarks>
            /// <para>To ensure user experience and data security for end users currently using a cloud computer, mutual preemption between multiple users is not allowed. This parameter defaults to <c>off</c> and cannot be modified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("PreemptLogin")]
            [Validation(Required=false)]
            public string PreemptLogin { get; set; }

            /// <summary>
            /// <para>The usernames of users who can preempt the cloud computer.</para>
            /// </summary>
            [NameInMap("PreemptLoginUsers")]
            [Validation(Required=false)]
            public List<string> PreemptLoginUsers { get; set; }

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
            /// <para>Whether to enable image quality enhancement for design and 3D application scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("QualityEnhancement")]
            [Validation(Required=false)]
            public string QualityEnhancement { get; set; }

            /// <summary>
            /// <para>Whether to enable custom screen recording.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordContent")]
            [Validation(Required=false)]
            public string RecordContent { get; set; }

            /// <summary>
            /// <para>The expiration time for custom screen recording files. Default value: 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RecordContentExpires")]
            [Validation(Required=false)]
            public long? RecordContentExpires { get; set; }

            /// <summary>
            /// <para>The screen recording duration after an event is detected in screen recording audit. Unit: minutes. Valid values: 10 to 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordEventDuration")]
            [Validation(Required=false)]
            public int? RecordEventDuration { get; set; }

            /// <summary>
            /// <para>The screen recording event suffix.</para>
            /// </summary>
            [NameInMap("RecordEventFileExts")]
            [Validation(Required=false)]
            public List<string> RecordEventFileExts { get; set; }

            /// <summary>
            /// <para>The list of absolute paths for file monitoring in screen recording audit.</para>
            /// </summary>
            [NameInMap("RecordEventFilePaths")]
            [Validation(Required=false)]
            public List<string> RecordEventFilePaths { get; set; }

            /// <summary>
            /// <para>The screen recording event severity switch.</para>
            /// </summary>
            [NameInMap("RecordEventLevels")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsRecordEventLevels> RecordEventLevels { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsRecordEventLevels : TeaModel {
                /// <summary>
                /// <para>The event severity.</para>
                /// </summary>
                [NameInMap("EventLevel")]
                [Validation(Required=false)]
                public string EventLevel { get; set; }

                /// <summary>
                /// <para>The event type.</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

            }

            /// <summary>
            /// <para>The list of absolute paths for registry monitoring in screen recording audit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Computer\HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR</para>
            /// </summary>
            [NameInMap("RecordEventRegisters")]
            [Validation(Required=false)]
            public List<string> RecordEventRegisters { get; set; }

            /// <summary>
            /// <para>Whether to enable screen recording.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFF</para>
            /// </summary>
            [NameInMap("Recording")]
            [Validation(Required=false)]
            public string Recording { get; set; }

            /// <summary>
            /// <para>The option to record audio from the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RecordingAudio")]
            [Validation(Required=false)]
            public string RecordingAudio { get; set; }

            /// <summary>
            /// <para>The screen recording file viewing duration in minutes. Recording files are automatically split based on this duration and uploaded to the bucket. When a file reaches 300 MB, it is preferentially rolled over.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// <para>The screen recording end time in HH:MM:SS format. This parameter takes effect only when Recording is set to PERIOD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:59:00</para>
            /// </summary>
            [NameInMap("RecordingEndTime")]
            [Validation(Required=false)]
            public string RecordingEndTime { get; set; }

            /// <summary>
            /// <para>The retention period for screen recording files. Valid values: 1 to 180 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("RecordingExpires")]
            [Validation(Required=false)]
            public long? RecordingExpires { get; set; }

            /// <summary>
            /// <para>The screen recording frame rate. Unit: FPS (frames per second).</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecordingFps")]
            [Validation(Required=false)]
            public long? RecordingFps { get; set; }

            /// <summary>
            /// <para>The screen recording start time in HH:MM:SS format. This parameter takes effect only when Recording is set to PERIOD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00:00</para>
            /// </summary>
            [NameInMap("RecordingStartTime")]
            [Validation(Required=false)]
            public string RecordingStartTime { get; set; }

            /// <summary>
            /// <para>The screen recording client notification feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordingUserNotify")]
            [Validation(Required=false)]
            public string RecordingUserNotify { get; set; }

            /// <summary>
            /// <para>The screen recording client notification message. Leave empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Your cloud desktop is being recorded.</para>
            /// </summary>
            [NameInMap("RecordingUserNotifyMessage")]
            [Validation(Required=false)]
            public string RecordingUserNotifyMessage { get; set; }

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
            /// <para>Resets the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ResetDesktop")]
            [Validation(Required=false)]
            public string ResetDesktop { get; set; }

            [NameInMap("ResolutionDpi")]
            [Validation(Required=false)]
            public int? ResolutionDpi { get; set; }

            [NameInMap("ResolutionHeight")]
            [Validation(Required=false)]
            public int? ResolutionHeight { get; set; }

            [NameInMap("ResolutionModel")]
            [Validation(Required=false)]
            public string ResolutionModel { get; set; }

            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

            /// <summary>
            /// <para>The number of resource groups associated with this policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceGroupCount")]
            [Validation(Required=false)]
            public int? ResourceGroupCount { get; set; }

            /// <summary>
            /// <para>The region to which the cloud computer policy belongs.</para>
            /// <remarks>
            /// <para>For region-less policies, this value is <c>center</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>center</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

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
            /// <para>Specify this parameter when <c>Scope</c> is set to <c>IP</c>. This parameter takes effect only when <c>Scope</c> is set to <c>IP</c>.</para>
            /// </summary>
            [NameInMap("ScopeValue")]
            [Validation(Required=false)]
            public List<string> ScopeValue { get; set; }

            [NameInMap("ScreenDisplayMode")]
            [Validation(Required=false)]
            public string ScreenDisplayMode { get; set; }

            /// <summary>
            /// <para>Whether to enable smoothness enhancement for daily office scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("SmoothEnhancement")]
            [Validation(Required=false)]
            public string SmoothEnhancement { get; set; }

            /// <summary>
            /// <para>Whether to provide the status monitoring feature in the floating ball when accessing the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
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
            /// <para>USB redirection.</para>
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
                /// <para>Test rule</para>
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
                /// <para>The device subclass. This parameter is required when <c>usbRuleType</c> is set to 1. For more information, see <a href="https://www.usb.org/defined-class-codes">Defined Class Codes</a>.</para>
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

            [NameInMap("UseTime")]
            [Validation(Required=false)]
            public string UseTime { get; set; }

            /// <summary>
            /// <para>The average bitrate for video encoding. Valid values: 1000 to 50000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("VideoEncAvgKbps")]
            [Validation(Required=false)]
            public int? VideoEncAvgKbps { get; set; }

            /// <summary>
            /// <para>The maximum quantization parameter (QP) for video encoding, representing the lowest quality. Valid values: 0 to 51.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("VideoEncMaxQP")]
            [Validation(Required=false)]
            public int? VideoEncMaxQP { get; set; }

            /// <summary>
            /// <para>The minimum quantization parameter (QP) for video encoding, representing the highest quality. Valid values: 0 to 51.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("VideoEncMinQP")]
            [Validation(Required=false)]
            public int? VideoEncMinQP { get; set; }

            /// <summary>
            /// <para>The peak bitrate for video encoding. Valid values: 1000 to 50000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
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
            /// <para>Multimedia redirection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
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
            /// <para>Watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public string Watermark { get; set; }

            /// <summary>
            /// <para>The blind watermark anti-photo feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("WatermarkAntiCam")]
            [Validation(Required=false)]
            public string WatermarkAntiCam { get; set; }

            /// <summary>
            /// <para>The watermark font color in RGB format. Valid values: 0 to 16777215.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WatermarkColor")]
            [Validation(Required=false)]
            public int? WatermarkColor { get; set; }

            /// <summary>
            /// <para>If you set <c>WatermarkType</c> to <c>custom</c>, you must also specify <c>WatermarkCustomText</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom-watermark</para>
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
            /// <para>The blind watermark enhancement feature.</para>
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
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("WatermarkRowAmount")]
            [Validation(Required=false)]
            public int? WatermarkRowAmount { get; set; }

            /// <summary>
            /// <para>The blind watermark security priority rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("WatermarkSecurity")]
            [Validation(Required=false)]
            public string WatermarkSecurity { get; set; }

            [NameInMap("WatermarkShadow")]
            [Validation(Required=false)]
            public string WatermarkShadow { get; set; }

            /// <summary>
            /// <para>The watermark transparency level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LIGHT</para>
            /// </summary>
            [NameInMap("WatermarkTransparency")]
            [Validation(Required=false)]
            public string WatermarkTransparency { get; set; }

            /// <summary>
            /// <para>The watermark transparency. A higher value means lower transparency. Valid values: 10 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WatermarkTransparencyValue")]
            [Validation(Required=false)]
            public int? WatermarkTransparencyValue { get; set; }

            /// <summary>
            /// <para>The watermark type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EndUserId</para>
            /// </summary>
            [NameInMap("WatermarkType")]
            [Validation(Required=false)]
            public string WatermarkType { get; set; }

            [NameInMap("WuyingKeeper")]
            [Validation(Required=false)]
            public string WuyingKeeper { get; set; }

            /// <summary>
            /// <para>Whether to provide the WUYING AI Assistant feature in the floating ball when accessing the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("WyAssistant")]
            [Validation(Required=false)]
            public string WyAssistant { get; set; }

        }

        /// <summary>
        /// <para>The pagination token for the next query. If NextToken is empty, no further pages exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
