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
        /// <para>The cloud computer policies.</para>
        /// </summary>
        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=false)]
        public List<DescribePolicyGroupsResponseBodyDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribePolicyGroupsResponseBodyDescribePolicyGroups : TeaModel {
            /// <summary>
            /// <para>Indicates whether end users are granted the administrator permissions.</para>
            /// <remarks>
            /// <para> This parameter is in invitational preview for specific users and not available to the public.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("AdminAccess")]
            [Validation(Required=false)]
            public string AdminAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether the anti-screenshot feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off (default)</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AppContentProtection")]
            [Validation(Required=false)]
            public string AppContentProtection { get; set; }

            /// <summary>
            /// <para>The client IP address whitelist. End users can access cloud computers only from the IP addresses in the whitelist.</para>
            /// </summary>
            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules : TeaModel {
                /// <summary>
                /// <para>The CIDR block that is allowed to access the client. The value is an IPv4 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX/16</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>The remarks on the CIDR block that is allowed to access the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>The security group rules.</para>
            /// </summary>
            [NameInMap("AuthorizeSecurityPolicyRules")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules> AuthorizeSecurityPolicyRules { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules : TeaModel {
                /// <summary>
                /// <para>The object to which the security group rule applies. The value is an IPv4 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX/16</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>The description of the security group rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The protocol type of the security group rule.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>tcp: Transmission Control Protocol (TCP)</description></item>
                /// <item><description>udp: User Datagram Protocol (UDP)</description></item>
                /// <item><description>all: all protocols</description></item>
                /// <item><description>gre: Generic Routing Encapsulation (GRE)</description></item>
                /// <item><description>icmp: Internet Control Message Protocol (ICMP) for IPv4</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// <para>The authorization of the security group rule.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>drop: denies all access requests.</description></item>
                /// <item><description>accept: accepts all requests.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accept</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The port range of the security group rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22/22</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>The priority of the security group rule. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// <para>The direction of the security group rule.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>outflow: outbound</description></item>
                /// <item><description>inflow: inbound</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>inflow</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the webcam redirection feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CameraRedirect")]
            [Validation(Required=false)]
            public string CameraRedirect { get; set; }

            /// <summary>
            /// <para>The logon method control rules to limit the type of the Alibaba Cloud Workspace client used by end users to connect to cloud computers.</para>
            /// </summary>
            [NameInMap("ClientTypes")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsClientTypes> ClientTypes { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsClientTypes : TeaModel {
                /// <summary>
                /// <para>The client type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>html5: web client</description></item>
                /// <item><description>android: Android client</description></item>
                /// <item><description>windows: Windows client</description></item>
                /// <item><description>ios: iOS client</description></item>
                /// <item><description>macos: macOS client</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <para>Indicates whether end users are allowed to use a specific type of the client to connect to cloud computers.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OFF</description></item>
                /// <item><description>ON</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The permissions on the clipboard.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>read: specifies one-way transfer. You can copy files only from local devices to cloud computers.</description></item>
            /// <item><description>readwrite: specifies two-way transfer. You can copy files between local devices and cloud computers.</description></item>
            /// <item><description>write: specifies one-way transfer. You can only copy files from cloud computers to local devices.</description></item>
            /// <item><description>off: disables both one-way and two-way transfer. Files cannot be copied between local devices and cloud computers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            /// <summary>
            /// <para>Indicates whether the Color Enhancement switch is turned on in design and 3D scenarios.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ColorEnhancement")]
            [Validation(Required=false)]
            public string ColorEnhancement { get; set; }

            /// <summary>
            /// <para>The CPU underclocking duration. Valid values: 30 to 120. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CpuDownGradeDuration")]
            [Validation(Required=false)]
            public int? CpuDownGradeDuration { get; set; }

            /// <summary>
            /// <para>The process whitelist that is not restricted by the CPU usage limit.</para>
            /// </summary>
            [NameInMap("CpuProcessors")]
            [Validation(Required=false)]
            public List<string> CpuProcessors { get; set; }

            /// <summary>
            /// <para>Indicates whether the CPU spike protection switch is turned on.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CpuProtectedMode")]
            [Validation(Required=false)]
            public string CpuProtectedMode { get; set; }

            /// <summary>
            /// <para>The overall CPU usage. Valid values: 70 to 90. Unit: percentage (%).</para>
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
            /// <para>The single-CPU usage. Valid values: 70 to 100. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("CpuSingleRateLimit")]
            [Validation(Required=false)]
            public int? CpuSingleRateLimit { get; set; }

            /// <summary>
            /// <para>The number of cloud computers bound with this policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public int? DesktopCount { get; set; }

            /// <summary>
            /// <para>The number of shared cloud computers bound with this policy.</para>
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
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsDeviceRedirects> DeviceRedirects { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsDeviceRedirects : TeaModel {
                /// <summary>
                /// <para>The peripheral type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>printer</description></item>
                /// <item><description>scanner</description></item>
                /// <item><description>camera</description></item>
                /// <item><description>adb: the Android Debug Bridge (ADB) device.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>camera</para>
                /// </summary>
                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                /// <summary>
                /// <para>The redirection type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>usbRedirect</description></item>
                /// <item><description>deviceRedirect</description></item>
                /// <item><description>off: direction disabled.</description></item>
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
            /// <para>The custom peripheral rules.</para>
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
                /// <para>The product ID (PID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0x55b1</para>
                /// </summary>
                [NameInMap("DevicePid")]
                [Validation(Required=false)]
                public string DevicePid { get; set; }

                /// <summary>
                /// <para>The peripheral type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>usbKey</description></item>
                /// <item><description>other</description></item>
                /// <item><description>graphicsTablet</description></item>
                /// <item><description>printer</description></item>
                /// <item><description>cardReader</description></item>
                /// <item><description>scanner</description></item>
                /// <item><description>storage</description></item>
                /// <item><description>camera</description></item>
                /// <item><description>adb</description></item>
                /// <item><description>networkInterfaceCard: the NIC device.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>storage</para>
                /// </summary>
                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                /// <summary>
                /// <para>The vendor ID (VID). For more information, see <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB VIDs</a>.</para>
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
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>deviceRedirect</description></item>
                /// <item><description>usbRedirect</description></item>
                /// <item><description>off: redirection disabled.</description></item>
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
            /// <para>The display mode.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>clientCustom: suitable for user-defined scenarios.</description></item>
            /// <item><description>adminOffice: suitable for daily office scenarios.</description></item>
            /// <item><description>adminDesign: suitable for 3D application scenarios.</description></item>
            /// <item><description>adminCustom: administrator-customized scenarios</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>adminCustom</para>
            /// </summary>
            [NameInMap("DisplayMode")]
            [Validation(Required=false)]
            public string DisplayMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the access control for domain names. Domain names support wildcards (\*). Separate multiple domain names with commas (,).</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public string DomainList { get; set; }

            /// <summary>
            /// <para>The domain name resolution rules.</para>
            /// </summary>
            [NameInMap("DomainResolveRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsDomainResolveRule> DomainResolveRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsDomainResolveRule : TeaModel {
                /// <summary>
                /// <para>The rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The destination domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>Indicates whether the domain name resolution rule is allowed.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>allow</description></item>
                /// <item><description>block</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the switch for domain name resolution is turned on.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("DomainResolveRuleType")]
            [Validation(Required=false)]
            public string DomainResolveRuleType { get; set; }

            /// <summary>
            /// <para>The number of cloud computers that are associated with the policy. The number of cloud computers that are associated only with custom policies is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EdsCount")]
            [Validation(Required=false)]
            public int? EdsCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the Contact Administrator for Help switch is turned on.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("EndUserApplyAdminCoordinate")]
            [Validation(Required=false)]
            public string EndUserApplyAdminCoordinate { get; set; }

            /// <summary>
            /// <para>Indicates whether the User Stream Collaboration switch is turned on.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("EndUserGroupCoordinate")]
            [Validation(Required=false)]
            public string EndUserGroupCoordinate { get; set; }

            [NameInMap("FileMigrate")]
            [Validation(Required=false)]
            public string FileMigrate { get; set; }

            /// <summary>
            /// <para>Transfers files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("FileTransfer")]
            [Validation(Required=false)]
            public string FileTransfer { get; set; }

            /// <summary>
            /// <para>Indicates whether the Image Quality Control feature is enabled. If you have high requirements on the performance and user experience in scenarios such as professional design, we recommend that you enable this feature.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("GpuAcceleration")]
            [Validation(Required=false)]
            public string GpuAcceleration { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow web client access.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off (default)</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Html5Access")]
            [Validation(Required=false)]
            public string Html5Access { get; set; }

            /// <summary>
            /// <para>The file transfer feature on the web client.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>all: Files can be uploaded and downloaded between local computers and the web client.</description></item>
            /// <item><description>download: Files on the web client can be downloaded to local computers.</description></item>
            /// <item><description>upload: Files on local computers can be uploaded to the web client.</description></item>
            /// <item><description>off (default): Files cannot be transferred between the web client and local computers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            /// <summary>
            /// <para>The protocol for network communication.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP (default): TCP.</description></item>
            /// <item><description>BOTH: TCP and UDP.</description></item>
            /// </list>
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

            /// <summary>
            /// <para>The permissions on local disk mapping.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>read: read-only. Local disk mapping is available on cloud computers. However, you can only read (copy) local files but cannot modify the files.</description></item>
            /// <item><description>readwrite: read and write. Local disk mapping is available on cloud computers. You can read (copy) and write (modify) local files.</description></item>
            /// <item><description>off (default): none.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            /// <summary>
            /// <para>The maximum retry period for reconnecting to cloud computers when the cloud computers are disconnected due to none-human reasons. Valid values: 30 to 7200. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxReconnectTime")]
            [Validation(Required=false)]
            public int? MaxReconnectTime { get; set; }

            /// <summary>
            /// <para>The memory underclocking duration for a single process. Valid values: 30 to 120. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemoryDownGradeDuration")]
            [Validation(Required=false)]
            public int? MemoryDownGradeDuration { get; set; }

            /// <summary>
            /// <para>The whitelist of processes that are not restricted by the memory usage limit.</para>
            /// </summary>
            [NameInMap("MemoryProcessors")]
            [Validation(Required=false)]
            public List<string> MemoryProcessors { get; set; }

            /// <summary>
            /// <para>Indicates whether the memory spike protection switch is turned on.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("MemoryProtectedMode")]
            [Validation(Required=false)]
            public string MemoryProtectedMode { get; set; }

            /// <summary>
            /// <para>The overall memory usage. Valid values: 70 to 90. Unit: %.</para>
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
            /// <para>The memory usage of a single process. Valid values: 30 to 60. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemorySingleRateLimit")]
            [Validation(Required=false)]
            public int? MemorySingleRateLimit { get; set; }

            /// <summary>
            /// <para>Specifies whether to display the restart button in the DesktopAssistant when the cloud computer is accessed from the Alibaba Cloud Workspace mobile clients (including the Android client and the iOS client).</para>
            /// <remarks>
            /// <para>Mobile clients of V7.4 and higher versions required.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off: not provided.</description></item>
            /// <item><description>on: provided.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileRestart")]
            [Validation(Required=false)]
            public string MobileRestart { get; set; }

            /// <summary>
            /// <para>Specifies whether to display the shut down button in the DesktopAssistant when the cloud computer is accessed from the Alibaba Cloud Workspace mobile clients (including the Android client and the iOS client).</para>
            /// <remarks>
            /// <para>Mobile clients of V7.4 and higher versions required.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off: not provided.</description></item>
            /// <item><description>on: provided.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileShutdown")]
            [Validation(Required=false)]
            public string MobileShutdown { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testPolicyGroupName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the network redirection feature is enabled.</para>
            /// <remarks>
            /// <para> This parameter is in invitational preview for specific users and not available to the public.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off (default)</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("NetRedirect")]
            [Validation(Required=false)]
            public string NetRedirect { get; set; }

            /// <summary>
            /// <para>The network redirection rule.</para>
            /// <remarks>
            /// <para> This parameter is in invitational preview for specific users and not available to the public.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("NetRedirectRule")]
            [Validation(Required=false)]
            public List<DescribePolicyGroupsResponseBodyDescribePolicyGroupsNetRedirectRule> NetRedirectRule { get; set; }
            public class DescribePolicyGroupsResponseBodyDescribePolicyGroupsNetRedirectRule : TeaModel {
                /// <summary>
                /// <para>The rule content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is allowed.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>allow</description></item>
                /// <item><description>block</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The rule type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>prc: process</description></item>
                /// <item><description>domain: domain name</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>domain</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cloud computer policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-gx2x1dhsmthe9****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The type of the cloud computer policy.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM</description></item>
            /// <item><description>CUSTOM</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("PolicyGroupType")]
            [Validation(Required=false)]
            public string PolicyGroupType { get; set; }

            /// <summary>
            /// <para>The status of the cloud computer policy.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AVAILABLE</description></item>
            /// <item><description>CREATING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// <para>The cloud computer preemption feature.</para>
            /// <remarks>
            /// <para> To ensure user experience and data security, when a cloud computer is used by an end user, other end users cannot connect to the cloud computer. By default, this parameter is set to <c>off</c>, which cannot be modified.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off: Preemption is not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("PreemptLogin")]
            [Validation(Required=false)]
            public string PreemptLogin { get; set; }

            /// <summary>
            /// <para>The usernames that can preempt to connect to the cloud computer.</para>
            /// </summary>
            [NameInMap("PreemptLoginUsers")]
            [Validation(Required=false)]
            public List<string> PreemptLoginUsers { get; set; }

            /// <summary>
            /// <para>Indicates whether the printer redirection feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("PrinterRedirection")]
            [Validation(Required=false)]
            public string PrinterRedirection { get; set; }

            /// <summary>
            /// <para>Indicates whether the Image Quality Enhancement switch is turned on for design and 3D scenarios.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("QualityEnhancement")]
            [Validation(Required=false)]
            public string QualityEnhancement { get; set; }

            /// <summary>
            /// <para>Indicates whether the custom screen recording feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off (default)</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordContent")]
            [Validation(Required=false)]
            public string RecordContent { get; set; }

            /// <summary>
            /// <para>The period when the custom screen recording can be retained before expiration. Default value: 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RecordContentExpires")]
            [Validation(Required=false)]
            public long? RecordContentExpires { get; set; }

            /// <summary>
            /// <para>The recording duration since a target event is detected by the screen recording audit policy. Unit: Minute. Valid values: 10-60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordEventDuration")]
            [Validation(Required=false)]
            public int? RecordEventDuration { get; set; }

            /// <summary>
            /// <para>The array of absolute paths of the monitored files in the screen recording audit policy.</para>
            /// </summary>
            [NameInMap("RecordEventFilePaths")]
            [Validation(Required=false)]
            public List<string> RecordEventFilePaths { get; set; }

            /// <summary>
            /// <para>The array of absolute paths of the monitored registry entries in the screen recording audit policy.</para>
            /// </summary>
            [NameInMap("RecordEventRegisters")]
            [Validation(Required=false)]
            public List<string> RecordEventRegisters { get; set; }

            /// <summary>
            /// <para>Indicates whether the screen recording feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>byaction_cmd_ft: enables the operation-triggered screen recording upon command execution and file transfer.</description></item>
            /// <item><description>ALLTIME: enables the whole-process screen recording. That is, the recording starts when cloud computers are connected and ends when the cloud computers are disconnected.</description></item>
            /// <item><description>PERIOD: enables the interval-based screen recording. You must specify an interval between the start time and end time of this type of recording.</description></item>
            /// <item><description>byaction_commands: enables the operation-triggered screen recording upon command execution.</description></item>
            /// <item><description>OFF: disables the screen recording feature.</description></item>
            /// <item><description>byaction_file_transfer: enables the operation-triggered screen recording upon file transfer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OFF</para>
            /// </summary>
            [NameInMap("Recording")]
            [Validation(Required=false)]
            public string Recording { get; set; }

            /// <summary>
            /// <para>Indicates whether audio files generated from cloud computers are recorded.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off (default): records only video files.</description></item>
            /// <item><description>on: records video and audio files.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RecordingAudio")]
            [Validation(Required=false)]
            public string RecordingAudio { get; set; }

            /// <summary>
            /// <para>The file length of the screen recording. Unit: minutes. Screen recording files are split based on the specified file length and uploaded to Object Storage Service (OSS) buckets. When a screen recording file reaches 300 MB in size, the system preferentially performs rolling update for the file.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>10</description></item>
            /// <item><description>20</description></item>
            /// <item><description>30</description></item>
            /// <item><description>60</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// <para>The time when the screen recording ended. The value is in the HH:MM:SS format. The value takes effect only when Recording is set to PERIOD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:59:00</para>
            /// </summary>
            [NameInMap("RecordingEndTime")]
            [Validation(Required=false)]
            public string RecordingEndTime { get; set; }

            /// <summary>
            /// <para>The retention period of the screen recording file. Valid values: 1 to 180. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("RecordingExpires")]
            [Validation(Required=false)]
            public long? RecordingExpires { get; set; }

            /// <summary>
            /// <para>The frame rate of screen recording. Unit: fps.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2</description></item>
            /// <item><description>5</description></item>
            /// <item><description>10</description></item>
            /// <item><description>15</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecordingFps")]
            [Validation(Required=false)]
            public long? RecordingFps { get; set; }

            /// <summary>
            /// <para>The time when the screen recording was started. The value is in the HH:MM:SS format. The value takes effect only when Recording is set to PERIOD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00:00</para>
            /// </summary>
            [NameInMap("RecordingStartTime")]
            [Validation(Required=false)]
            public string RecordingStartTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the screen recording notification feature is enabled after end users log on to the Alibaba Cloud Workspace client.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordingUserNotify")]
            [Validation(Required=false)]
            public string RecordingUserNotify { get; set; }

            /// <summary>
            /// <para>The notification content of screen recording. By default, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Your desktop is being recorded</para>
            /// </summary>
            [NameInMap("RecordingUserNotifyMessage")]
            [Validation(Required=false)]
            public string RecordingUserNotifyMessage { get; set; }

            /// <summary>
            /// <para>The permissions on keyboard and mouse control during remote assistance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>optionalControl: By default, you are not granted the permissions. You can apply for the permissions.</description></item>
            /// <item><description>fullControl: You are granted the full permissions.</description></item>
            /// <item><description>disableControl: You are not granted the permissions.</description></item>
            /// </list>
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
            /// <para>The number of resource groups bound with this policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceGroupCount")]
            [Validation(Required=false)]
            public int? ResourceGroupCount { get; set; }

            /// <summary>
            /// <para>The region of the cloud computer policy.</para>
            /// <remarks>
            /// <para>The value of a region-less policy is <c>center</c>.</para>
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IP: The policy takes effect based on the IP address.</description></item>
            /// <item><description>GLOBAL: The policy takes effect globally.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GLOBAL</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>This parameter is required when the <c>Scope</c> parameter is set to <c>IP</c>.````</para>
            /// </summary>
            [NameInMap("ScopeValue")]
            [Validation(Required=false)]
            public List<string> ScopeValue { get; set; }

            /// <summary>
            /// <para>Indicates whether the Smooth Enhancement switch is turned on.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("SmoothEnhancement")]
            [Validation(Required=false)]
            public string SmoothEnhancement { get; set; }

            /// <summary>
            /// <para>Specifies whether to provide the Metrics function in the DesktopAssistant. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off: not provided.</description></item>
            /// <item><description>on: provided.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("StatusMonitor")]
            [Validation(Required=false)]
            public string StatusMonitor { get; set; }

            /// <summary>
            /// <para>The streaming mode.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>intelligent: suitable for daily office scenarios (Intelligent Mode).</description></item>
            /// <item><description>smooth: suitable for design and 3D application scenarios (Smooth Mode).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>smooth</para>
            /// </summary>
            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            /// <summary>
            /// <para>The destination frame rate. Valid values: 10 to 60. Unit: fps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TargetFps")]
            [Validation(Required=false)]
            public int? TargetFps { get; set; }

            /// <summary>
            /// <para>Indicates whether the USB redirection feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
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
                /// <para>Test</para>
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
                /// <para>The subclass of the device. This parameter is required when <c>usbRuleType</c> is set to 1. For more information, see <a href="https://www.usb.org/defined-class-codes">Defined Class Codes</a>.</para>
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
                /// <para>Indicates whether USB redirection is allowed.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: allowed</description></item>
                /// <item><description>2: not allowed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UsbRedirectType")]
                [Validation(Required=false)]
                public long? UsbRedirectType { get; set; }

                /// <summary>
                /// <para>The type of the USB redirection rule.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: by device class</description></item>
                /// <item><description>2: by device vendor</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UsbRuleType")]
                [Validation(Required=false)]
                public long? UsbRuleType { get; set; }

                /// <summary>
                /// <para>The vendor ID (VID). For more information, see <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB VIDs</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>04**</para>
                /// </summary>
                [NameInMap("VendorId")]
                [Validation(Required=false)]
                public string VendorId { get; set; }

            }

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
            /// <para>The maximum quantizer parameter (QP) of video files. A larger QP value indicates worse video quality. Valid values: 0 to 51.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("VideoEncMaxQP")]
            [Validation(Required=false)]
            public int? VideoEncMaxQP { get; set; }

            /// <summary>
            /// <para>The minimum quantizer parameter (QP) of video files. A smaller QP value indicates higher video quality. Valid values: 0 to 51.</para>
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
            /// <para>The video encoding feature.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>qualityFirst: The priority given to the image quality.</description></item>
            /// <item><description>bandwidthFirst: The priority given to the bitrate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>qualityFirst</para>
            /// </summary>
            [NameInMap("VideoEncPolicy")]
            [Validation(Required=false)]
            public string VideoEncPolicy { get; set; }

            /// <summary>
            /// <para>Indicates whether the multimedia redirection feature is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("VideoRedirect")]
            [Validation(Required=false)]
            public string VideoRedirect { get; set; }

            /// <summary>
            /// <para>The image display quality.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>high: high-definition (HD)</description></item>
            /// <item><description>low: fluent</description></item>
            /// <item><description>medium (default): adaptive</description></item>
            /// <item><description>lossless: no quality loss</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("VisualQuality")]
            [Validation(Required=false)]
            public string VisualQuality { get; set; }

            /// <summary>
            /// <para>The watermarking feature.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>blind: Invisible watermarks are applied.</description></item>
            /// <item><description>off: The watermarking feature is disabled.</description></item>
            /// <item><description>on: Visible watermarks are applied.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public string Watermark { get; set; }

            /// <summary>
            /// <para>Indicates whether the anti-screen photo feature is enabled for invisible watermarks.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("WatermarkAntiCam")]
            [Validation(Required=false)]
            public string WatermarkAntiCam { get; set; }

            /// <summary>
            /// <para>The font color in red, green, and blue (RGB) of the watermark. Valid values: 0 to 16777215.</para>
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
            /// <para>test</para>
            /// </summary>
            [NameInMap("WatermarkCustomText")]
            [Validation(Required=false)]
            public string WatermarkCustomText { get; set; }

            /// <summary>
            /// <para>The slope of the watermark. Valid values: -10 to -30.</para>
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
            /// <para>The watermark font style.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>plain</description></item>
            /// <item><description>bold</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>plain</para>
            /// </summary>
            [NameInMap("WatermarkFontStyle")]
            [Validation(Required=false)]
            public string WatermarkFontStyle { get; set; }

            /// <summary>
            /// <para>The watermark enhancement feature.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>high</description></item>
            /// <item><description>low</description></item>
            /// <item><description>medium</description></item>
            /// </list>
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
            /// <para> This parameter is not available for public use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("WatermarkRowAmount")]
            [Validation(Required=false)]
            public int? WatermarkRowAmount { get; set; }

            /// <summary>
            /// <para>Indicates whether the security priority feature is enabled for invisible watermarks.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("WatermarkSecurity")]
            [Validation(Required=false)]
            public string WatermarkSecurity { get; set; }

            /// <summary>
            /// <para>The watermark transparency.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LIGHT</description></item>
            /// <item><description>DARK</description></item>
            /// <item><description>MIDDLE</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LIGHT</para>
            /// </summary>
            [NameInMap("WatermarkTransparency")]
            [Validation(Required=false)]
            public string WatermarkTransparency { get; set; }

            /// <summary>
            /// <para>The watermark transparency. A greater value indicates that the watermark is less transparent. Valid values: 10 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WatermarkTransparencyValue")]
            [Validation(Required=false)]
            public int? WatermarkTransparencyValue { get; set; }

            /// <summary>
            /// <para>The watermark content.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EndUserId: the username.</description></item>
            /// <item><description>Custom</description></item>
            /// <item><description>DesktopIp: the IP address of the cloud computer.</description></item>
            /// <item><description>ClientIp: the IP address of the Alibaba Cloud Workspace client.</description></item>
            /// <item><description>HostName: the rightmost 15 digits of the cloud computer ID.</description></item>
            /// <item><description>ClientTime: the current time displayed on the cloud computer.</description></item>
            /// </list>
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
            /// <para>Specifies whether to provide the AI Assistant function in the DesktopAssistant when the cloud computer is accessed from the Alibaba Cloud Workspace desktop clients (including the Windows client and the macOS client).</para>
            /// <remarks>
            /// <para>Desktop clients of V7.7 and higher versions required.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off: the AI Aisstant function is not provided.</description></item>
            /// <item><description>on: the AI Aisstant function is provided.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("WyAssistant")]
            [Validation(Required=false)]
            public string WyAssistant { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
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
