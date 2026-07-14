// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCenterPolicyListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the cloud desktop policies.</para>
        /// </summary>
        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=false)]
        public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribeCenterPolicyListResponseBodyDescribePolicyGroups : TeaModel {
            [NameInMap("AcademicProxy")]
            [Validation(Required=false)]
            public string AcademicProxy { get; set; }

            /// <summary>
            /// <para>Indicates whether the user has administrator permissions after connecting to the cloud desktop.</para>
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

            [NameInMap("AdminMonitor")]
            [Validation(Required=false)]
            public int? AdminMonitor { get; set; }

            /// <summary>
            /// <para>Indicates whether the screenshot prevention feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AppContentProtection")]
            [Validation(Required=false)]
            public string AppContentProtection { get; set; }

            /// <summary>
            /// <para>The client access IP whitelist.</para>
            /// </summary>
            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules : TeaModel {
                /// <summary>
                /// <para>The client access IP CIDR block, in IPv4 CIDR notation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX/16</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>The description of the client access IP CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>The list of security group control rules.</para>
            /// </summary>
            [NameInMap("AuthorizeSecurityPolicyRules")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules> AuthorizeSecurityPolicyRules { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules : TeaModel {
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
                /// <para>The priority of the security group control rule. A smaller value indicates a higher priority.</para>
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

            [NameInMap("AutoReconnect")]
            [Validation(Required=false)]
            public string AutoReconnect { get; set; }

            /// <summary>
            /// <para>Indicates whether local camera redirection is enabled.</para>
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
            /// <para>The logon method control rules.</para>
            /// </summary>
            [NameInMap("ClientTypes")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsClientTypes> ClientTypes { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsClientTypes : TeaModel {
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
                /// <para>Indicates whether a specific type of client is allowed to log on to the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
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
            /// <para>Indicates whether color enhancement is enabled. Common scenarios: design and 3D applications.</para>
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
            /// <para>The CPU throttling duration. Valid values: 30 to 120. Unit: seconds.</para>
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
            /// <para>The process name.</para>
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
            /// <para>The overall CPU sampling duration. Valid values: 10 to 60. Unit: seconds.</para>
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

            /// <summary>
            /// <para>The number of cloud desktops associated with this policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public int? DesktopCount { get; set; }

            /// <summary>
            /// <para>The number of cloud desktop pools associated with this policy.</para>
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
            /// <para>The device redirection rules.</para>
            /// </summary>
            [NameInMap("DeviceRedirects")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDeviceRedirects> DeviceRedirects { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDeviceRedirects : TeaModel {
                /// <summary>
                /// <para>The peripheral device type.</para>
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
                /// <para>usbRedirect</para>
                /// </summary>
                [NameInMap("RedirectType")]
                [Validation(Required=false)]
                public string RedirectType { get; set; }

            }

            /// <summary>
            /// <para>The custom peripheral device rules.</para>
            /// </summary>
            [NameInMap("DeviceRules")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDeviceRules> DeviceRules { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDeviceRules : TeaModel {
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
                /// <para>The peripheral device type.</para>
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
                /// <para>The link optimization instruction.</para>
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

            /// <summary>
            /// <para>The session retention on disconnect setting.</para>
            /// <remarks>
            /// <para>Applicable only to cloud application policies.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>persistent</para>
            /// </summary>
            [NameInMap("DisconnectKeepSession")]
            [Validation(Required=false)]
            public string DisconnectKeepSession { get; set; }

            /// <summary>
            /// <para>The session retention duration on disconnect. Unit: seconds.</para>
            /// <remarks>
            /// <para>Applicable only to cloud application policies.</para>
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
            /// <para>The display mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adminCustom</para>
            /// </summary>
            [NameInMap("DisplayMode")]
            [Validation(Required=false)]
            public string DisplayMode { get; set; }

            /// <summary>
            /// <para>The effective field for domain name resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("DomainRegisterValue")]
            [Validation(Required=false)]
            public string DomainRegisterValue { get; set; }

            /// <summary>
            /// <para>The domain name resolution policy details.</para>
            /// </summary>
            [NameInMap("DomainResolveRule")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDomainResolveRule> DomainResolveRule { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDomainResolveRule : TeaModel {
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
            /// <para>Indicates whether users can request administrator assistance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("EndUserApplyAdminCoordinate")]
            [Validation(Required=false)]
            public string EndUserApplyAdminCoordinate { get; set; }

            [NameInMap("EndUserCount")]
            [Validation(Required=false)]
            public string EndUserCount { get; set; }

            /// <summary>
            /// <para>Indicates whether users within the same office network can share cloud desktops.</para>
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

            [NameInMap("FileMigrate")]
            [Validation(Required=false)]
            public string FileMigrate { get; set; }

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
            /// <para>Indicates whether the image quality policy is enabled for GPU-accelerated cloud desktops. Enable this policy when high performance and user experience are required, such as in professional design scenarios.</para>
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
            /// <para>tcp</para>
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

            [NameInMap("KmsServer")]
            [Validation(Required=false)]
            public string KmsServer { get; set; }

            [NameInMap("KmsServerConfig")]
            [Validation(Required=false)]
            public string KmsServerConfig { get; set; }

            /// <summary>
            /// <para>The local drive mapping permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            /// <summary>
            /// <para>The maximum reconnection retry time when the cloud desktop is disconnected due to external reasons. Valid values: 30 to 7200. Unit: seconds.</para>
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
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemoryDownGradeDuration")]
            [Validation(Required=false)]
            public int? MemoryDownGradeDuration { get; set; }

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
            /// <para>The memory protection mode switch.</para>
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
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemorySampleDuration")]
            [Validation(Required=false)]
            public int? MemorySampleDuration { get; set; }

            /// <summary>
            /// <para>The memory usage percentage of a single process. Valid values: 30 to 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemorySingleRateLimit")]
            [Validation(Required=false)]
            public int? MemorySingleRateLimit { get; set; }

            /// <summary>
            /// <para>Indicates whether the restart button is provided in the cloud desktop floating ball when connecting through a mobile client (Android client&lt;props=&quot;china&quot;&gt; and iOS client).</para>
            /// <remarks>
            /// <para>Applicable only to mobile clients V7.4 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileRestart")]
            [Validation(Required=false)]
            public string MobileRestart { get; set; }

            [NameInMap("MobileSafeMenu")]
            [Validation(Required=false)]
            public string MobileSafeMenu { get; set; }

            /// <summary>
            /// <para>Indicates whether the shutdown button is provided in the cloud desktop floating ball when connecting through a mobile client (Android client&lt;props=&quot;china&quot;&gt; and iOS client).</para>
            /// <remarks>
            /// <para>Applicable only to mobile clients V7.4 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileShutdown")]
            [Validation(Required=false)]
            public string MobileShutdown { get; set; }

            [NameInMap("MobileWuyingKeeper")]
            [Validation(Required=false)]
            public string MobileWuyingKeeper { get; set; }

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
            /// <para>The network redirection setting.</para>
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
            /// <para>The network redirection policy details.</para>
            /// <remarks>
            /// <para>This feature is in invitational preview and is not publicly available.
            /// .</para>
            /// </remarks>
            /// </summary>
            [NameInMap("NetRedirectRule")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsNetRedirectRule> NetRedirectRule { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsNetRedirectRule : TeaModel {
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
                /// <para>allow</para>
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

            [NameInMap("NetworkPrinter")]
            [Validation(Required=false)]
            public string NetworkPrinter { get; set; }

            /// <summary>
            /// <para>The no-operation disconnect setting.</para>
            /// <remarks>
            /// <para>Applicable only to cloud application policies.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("NoOperationDisconnect")]
            [Validation(Required=false)]
            public string NoOperationDisconnect { get; set; }

            /// <summary>
            /// <para>The no-operation disconnect duration. Unit: seconds.</para>
            /// <remarks>
            /// <para>Applicable only to cloud application policies.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("NoOperationDisconnectTime")]
            [Validation(Required=false)]
            public int? NoOperationDisconnectTime { get; set; }

            [NameInMap("OrganizationCount")]
            [Validation(Required=false)]
            public string OrganizationCount { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("PolicyGroupType")]
            [Validation(Required=false)]
            public string PolicyGroupType { get; set; }

            /// <summary>
            /// <para>The cloud desktop policy status.</para>
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
            /// <para>The printer redirection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("PrinterRedirection")]
            [Validation(Required=false)]
            public string PrinterRedirection { get; set; }

            /// <summary>
            /// <para>Indicates whether image quality enhancement is enabled. Common scenarios: design and 3D applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("QualityEnhancement")]
            [Validation(Required=false)]
            public string QualityEnhancement { get; set; }

            /// <summary>
            /// <para>Indicates whether custom screen recording is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordContent")]
            [Validation(Required=false)]
            public string RecordContent { get; set; }

            /// <summary>
            /// <para>The expiration period of custom screen recording files. Default value: 30. Unit: days.</para>
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
            /// <para>The absolute paths for file monitoring in screen recording audit.</para>
            /// </summary>
            [NameInMap("RecordEventFilePaths")]
            [Validation(Required=false)]
            public List<string> RecordEventFilePaths { get; set; }

            /// <summary>
            /// <para>The absolute paths for registry monitoring in screen recording audit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Computer\HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR</para>
            /// </summary>
            [NameInMap("RecordEventRegisters")]
            [Validation(Required=false)]
            public List<string> RecordEventRegisters { get; set; }

            /// <summary>
            /// <para>Indicates whether screen recording is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Recording")]
            [Validation(Required=false)]
            public string Recording { get; set; }

            /// <summary>
            /// <para>The option for recording cloud desktop audio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RecordingAudio")]
            [Validation(Required=false)]
            public string RecordingAudio { get; set; }

            /// <summary>
            /// <para>The duration of each screen recording file. Unit: minutes. Recording files are automatically split and uploaded to the storage space based on the specified duration. Files are rolled over when they reach 300 MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// <para>The screen recording end time, in the format of HH:MM:SS. This value is meaningful only when Recording is set to period.</para>
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
            /// <para>The screen recording frame rate. Unit: FPS (frames per second).</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecordingFps")]
            [Validation(Required=false)]
            public long? RecordingFps { get; set; }

            /// <summary>
            /// <para>The screen recording start time, in the format of HH:MM:SS. This value is meaningful only when Recording is set to period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00:00</para>
            /// </summary>
            [NameInMap("RecordingStartTime")]
            [Validation(Required=false)]
            public string RecordingStartTime { get; set; }

            /// <summary>
            /// <para>Indicates whether end users are notified that screen recording is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordingUserNotify")]
            [Validation(Required=false)]
            public string RecordingUserNotify { get; set; }

            /// <summary>
            /// <para>The notification message displayed to end users about screen recording.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Screen recording is enabled.</para>
            /// </summary>
            [NameInMap("RecordingUserNotifyMessage")]
            [Validation(Required=false)]
            public string RecordingUserNotifyMessage { get; set; }

            /// <summary>
            /// <para>The keyboard and mouse control permission for remote assistance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fullControl</para>
            /// </summary>
            [NameInMap("RemoteCoordinate")]
            [Validation(Required=false)]
            public string RemoteCoordinate { get; set; }

            [NameInMap("ResetDesktop")]
            [Validation(Required=false)]
            public string ResetDesktop { get; set; }

            [NameInMap("ResolutionDpi")]
            [Validation(Required=false)]
            public int? ResolutionDpi { get; set; }

            /// <summary>
            /// <para>The resolution height. Unit: pixels.</para>
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
            /// <para>The resolution width. Unit: pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
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
            /// <para>The effective CIDR block.</para>
            /// </summary>
            [NameInMap("ScopeValue")]
            [Validation(Required=false)]
            public List<string> ScopeValue { get; set; }

            [NameInMap("ScreenDisplayMode")]
            [Validation(Required=false)]
            public string ScreenDisplayMode { get; set; }

            /// <summary>
            /// <para>Indicates whether smoothness enhancement is enabled for daily office scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("SmoothEnhancement")]
            [Validation(Required=false)]
            public string SmoothEnhancement { get; set; }

            /// <summary>
            /// <para>Indicates whether the status monitoring entry is provided in the cloud desktop floating ball.</para>
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
            /// <para>The application taskbar.</para>
            /// <remarks>
            /// <para>Applicable only to cloud application policies.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Taskbar")]
            [Validation(Required=false)]
            public string Taskbar { get; set; }

            /// <summary>
            /// <para>The USB redirection setting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("UsbRedirect")]
            [Validation(Required=false)]
            public string UsbRedirect { get; set; }

            /// <summary>
            /// <para>The USB redirection rules.</para>
            /// </summary>
            [NameInMap("UsbSupplyRedirectRule")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsUsbSupplyRedirectRule : TeaModel {
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
            /// <para>The average bitrate for video encoding. Unit: Kbps. Valid values: 1000 to 50000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("VideoEncAvgKbps")]
            [Validation(Required=false)]
            public int? VideoEncAvgKbps { get; set; }

            /// <summary>
            /// <para>The maximum QP for video encoding, which represents the lowest image quality. Valid values: 0 to 51.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("VideoEncMaxQP")]
            [Validation(Required=false)]
            public int? VideoEncMaxQP { get; set; }

            /// <summary>
            /// <para>The minimum QP for video encoding, which represents the highest quality. Valid values: 0 to 51.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("VideoEncMinQP")]
            [Validation(Required=false)]
            public int? VideoEncMinQP { get; set; }

            /// <summary>
            /// <para>The peak bitrate for video encoding. Unit: Kbps. Valid values: 1000 to 50000.</para>
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
            /// <para>The multimedia redirection setting.</para>
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
            /// <para>The watermark setting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
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
            /// <para>If the <c>WatermarkType</c> parameter is set to <c>custom</c>, you must also specify the custom text content by using the <c>WatermarkCustomText</c> parameter.</para>
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
            /// <para>The invisible watermark enhancement feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("WatermarkPower")]
            [Validation(Required=false)]
            public string WatermarkPower { get; set; }

            /// <summary>
            /// <para>The number of watermark rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("WatermarkRowAmount")]
            [Validation(Required=false)]
            public int? WatermarkRowAmount { get; set; }

            /// <summary>
            /// <para>The invisible watermark security priority rule.</para>
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
            /// <para>The watermark transparency. A larger value indicates lower transparency. Valid values: 10 to 100.</para>
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
            /// <para>Indicates whether the WUYING AI Assistant entry is provided in the cloud desktop floating ball.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("WyAssistant")]
            [Validation(Required=false)]
            public string WyAssistant { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
