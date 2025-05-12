// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCenterPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to grant the admin permissions to end users.</para>
        /// <remarks>
        /// <para> This parameter is in private preview and only available to specific users.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>allow: forcibly grants admin permissions.</description></item>
        /// <item><description>deny: forcibly rejects granting admin permissions.</description></item>
        /// <item><description>inherited: inherits the admin permissions from the user dimension.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("AdminAccess")]
        [Validation(Required=false)]
        public string AdminAccess { get; set; }

        /// <summary>
        /// <para>The anti-screenshot policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off (default): disables anti-screenshot.</description></item>
        /// <item><description>on: enables anti-screenshot.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AppContentProtection")]
        [Validation(Required=false)]
        public string AppContentProtection { get; set; }

        /// <summary>
        /// <para>The client IP address whitelists that you want to add. Once an IP address whitelist is configured, end users can only access cloud computers from the IP addresses listed in it.</para>
        /// </summary>
        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class CreateCenterPolicyRequestAuthorizeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>The client CIDR block from which end users can connect to cloud computers. Specify an IPv4 CIDR block.</para>
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
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The security group rule.</para>
        /// </summary>
        [NameInMap("AuthorizeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class CreateCenterPolicyRequestAuthorizeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <para>The object of the security group rule. Specify an IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX/8</para>
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
            /// <item><description>TCP: the Transmission Control Protocol (TCP) protocol.</description></item>
            /// <item><description>UDP: the User Datagram Protocol (UDP) protocol.</description></item>
            /// <item><description>ALL: any type of protocol.</description></item>
            /// <item><description>GRE: the Generic Routing Encapsulation (GRE) protocol.</description></item>
            /// <item><description>ICMP: the Internet Control Message Protocol (ICMP) for (IPv4).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The authorization policy of the security group rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>drop: denies all access requests. If no \&quot;\&quot;access denied\&quot;\&quot; messages are returned, the requests either timed out or failed.</description></item>
            /// <item><description>accept (default): accepts all requests.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The port range of the security group rule. The value range of this parameter varies based on the value of IpProtocol.</para>
            /// <list type="bullet">
            /// <item><description>If IpProtocol is set to TCP or UDP, the port range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>If IpProtocol is set to ICMP, set the value to -1/-1.</description></item>
            /// <item><description>If IpProtocol is set to GRE, set the value to -1/-1.</description></item>
            /// <item><description>If IpProtocol is set to ALL, set the value to -1/-1.</description></item>
            /// </list>
            /// <para>For more information about the common ports, see <a href="https://help.aliyun.com/document_detail/40724.html">Common ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of the security group rule. A smaller value specifies a higher priority.\
            /// Valid values: 1 to 60.\
            /// Default value: 1.</para>
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
            /// <item><description>outflow: outbound.</description></item>
            /// <item><description>inflow: inbound.</description></item>
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
        /// <para>The business type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: public cloud</description></item>
        /// <item><description>8: commercial edition.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public int? BusinessType { get; set; }

        /// <summary>
        /// <para>The on-premises camera redirection policy. This parameter only applies if DeviceRedirects does not include an on-premises camera redirection policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>deviceRedirect: enables device redirection.</description></item>
        /// <item><description>off: disables device redirection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// <para>The types of Alibaba Cloud Workspace clients that end users can use to connect to cloud computers.</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestClientType> ClientType { get; set; }
        public class CreateCenterPolicyRequestClientType : TeaModel {
            /// <summary>
            /// <para>The type of the Alibaba Cloud Workspace client that end users can use to connect to cloud computers.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>html5: the web client.</description></item>
            /// <item><description>android: the Android client.</description></item>
            /// <item><description>ios: the iOS client.</description></item>
            /// <item><description>windows: the Windows client.</description></item>
            /// <item><description>macos: the macOS client.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>Specifies whether end users can use the specified type of Alibaba Cloud Workspace client to connect to cloud computers.</para>
            /// <remarks>
            /// <para> If you don\&quot;t specify <c>ClientType</c>, any client can be used to connect to cloud computers.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off: End users cannot use the specified type of Alibaba Cloud Workspace client to connect to cloud computers.</description></item>
            /// <item><description>on: End users can use the specified type of Alibaba Cloud Workspace client to connect to cloud computers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The read/write permissions on the clipboard.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>read: specifies one-way transfer You can copy files only from on-premises devices to cloud computers.</description></item>
        /// <item><description>readwrite: specifies two-way transfer. You can copy files between on-premises devices and cloud computers.</description></item>
        /// <item><description>write: specifies one-way transfer. You can only copy files from cloud computers to on-premises devices.</description></item>
        /// <item><description>off (default): disables all transfers, both one-way and two-way. Files cannot be copied directly between on-premises devices and cloud computers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable color enhancement for design and 3D applications.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t enable color enhancement for design and 3D applications.</description></item>
        /// <item><description>on: enables color enhancement for design and 3D applications.</description></item>
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
        /// <para>The CPU processors.</para>
        /// </summary>
        [NameInMap("CpuProcessors")]
        [Validation(Required=false)]
        public List<string> CpuProcessors { get; set; }

        /// <summary>
        /// <para>The CPU spike protection policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: disables CPU spike protection.</description></item>
        /// <item><description>on: enables CPU spike protection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
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
        /// <para>60</para>
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
        /// <para>Specifies whether to display the peripheral connection prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DeviceConnectHint")]
        [Validation(Required=false)]
        public string DeviceConnectHint { get; set; }

        /// <summary>
        /// <para>The device redirection rules.</para>
        /// </summary>
        [NameInMap("DeviceRedirects")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestDeviceRedirects> DeviceRedirects { get; set; }
        public class CreateCenterPolicyRequestDeviceRedirects : TeaModel {
            /// <summary>
            /// <para>The peripheral type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>printer</description></item>
            /// <item><description>scanner</description></item>
            /// <item><description>serialport</description></item>
            /// <item><description>camera</description></item>
            /// <item><description>adb</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>camera</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The redirection type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>deviceRedirect: enables device redirection.</description></item>
            /// <item><description>usbRedirect: enables USB redirection.</description></item>
            /// <item><description>off: disables any type of redirection.</description></item>
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
        public List<CreateCenterPolicyRequestDeviceRules> DeviceRules { get; set; }
        public class CreateCenterPolicyRequestDeviceRules : TeaModel {
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
            /// <item><description>usbKey: UKeys.</description></item>
            /// <item><description>other: other peripheral devices.</description></item>
            /// <item><description>graphicsTablet: graphics tablets.</description></item>
            /// <item><description>cardReader: card readers.</description></item>
            /// <item><description>printer: printers.</description></item>
            /// <item><description>scanner: scanners.</description></item>
            /// <item><description>storage: storage devices.</description></item>
            /// <item><description>camera: cameras.</description></item>
            /// <item><description>networkInterfaceCard: NIC devices.</description></item>
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
            /// <item><description>deviceRedirect: device redirection.</description></item>
            /// <item><description>usbRedirect: USB redirection.</description></item>
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
        /// <para>Specifies whether to retain the session upon disconnection.</para>
        /// <remarks>
        /// <para> This parameter applies only to cloud application policies.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>customTime: retains the session for a specified time period.</description></item>
        /// <item><description>persistent: retains the session permanently.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customTime</para>
        /// </summary>
        [NameInMap("DisconnectKeepSession")]
        [Validation(Required=false)]
        public string DisconnectKeepSession { get; set; }

        /// <summary>
        /// <para>The retention period of the session after disconnection. Valid values: 30 to 7200. Unit: seconds.</para>
        /// <remarks>
        /// <para> This parameter applies only to cloud application policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("DisconnectKeepSessionTime")]
        [Validation(Required=false)]
        public int? DisconnectKeepSessionTime { get; set; }

        /// <summary>
        /// <para>The display mode.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>clientCustom: suitable for user-defined scenarios.</description></item>
        /// <item><description>adminOffice: suitable for daily office scenarios.</description></item>
        /// <item><description>adminDesign: suitable for design and 3D application scenarios.</description></item>
        /// <item><description>adminCustom: suitable for admin-customized scenarios.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clientCustom</para>
        /// </summary>
        [NameInMap("DisplayMode")]
        [Validation(Required=false)]
        public string DisplayMode { get; set; }

        /// <summary>
        /// <para>The domain resolution policies.</para>
        /// </summary>
        [NameInMap("DomainResolveRule")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestDomainResolveRule> DomainResolveRule { get; set; }
        public class CreateCenterPolicyRequestDomainResolveRule : TeaModel {
            /// <summary>
            /// <para>The policy description.</para>
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
            /// <para>Specifies whether to allow the domain resolution policy to take effect.</para>
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
        /// <para>Specifies whether to enforce the domain resolution policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: disables the domain resolution policy.</description></item>
        /// <item><description>on: enables the domain resolution policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DomainResolveRuleType")]
        [Validation(Required=false)]
        public string DomainResolveRuleType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enforce the peak bandwidth limit for sessions.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t enforce the peak bandwidth limit for sessions.</description></item>
        /// <item><description>on: enforces the peak bandwidth limit for sessions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EnableSessionRateLimiting")]
        [Validation(Required=false)]
        public string EnableSessionRateLimiting { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable end users to request administrator help.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: disables end users to request administrator help.</description></item>
        /// <item><description>on: enables end users to request administrator help.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EndUserApplyAdminCoordinate")]
        [Validation(Required=false)]
        public string EndUserApplyAdminCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow end users in the same office network to share cloud computers.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t allow end users in the same office network to share cloud computers.</description></item>
        /// <item><description>on: allows end users in the same office network to share cloud computers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EndUserGroupCoordinate")]
        [Validation(Required=false)]
        public string EndUserGroupCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable file transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("FileMigrate")]
        [Validation(Required=false)]
        public string FileMigrate { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable image quality control. This feature is highly recommended for professional design scenarios where computer performance and user experience are critical.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t enable image quality control.</description></item>
        /// <item><description>on: enables image quality control.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public string GpuAcceleration { get; set; }

        /// <summary>
        /// <para>The file transfer feature on the web client.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all: File upload and download are supported.</description></item>
        /// <item><description>download: Only file download is supported.</description></item>
        /// <item><description>upload: Only file upload is supported.</description></item>
        /// <item><description>off (default): File upload and download are not supported.</description></item>
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
        /// <item><description>tcp: TCP is used when UDP/AST is restricted.</description></item>
        /// <item><description>rtc: AST is used for high-frequency audio and video streaming.</description></item>
        /// <item><description>auto: UTO is used to enable automatic switch between AST and UDP modes based on desktop content.</description></item>
        /// <item><description>both: UDP is used for office and HD graphic design use.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>both</para>
        /// </summary>
        [NameInMap("InternetCommunicationProtocol")]
        [Validation(Required=false)]
        public string InternetCommunicationProtocol { get; set; }

        [NameInMap("InternetPrinter")]
        [Validation(Required=false)]
        public string InternetPrinter { get; set; }

        /// <summary>
        /// <para>The read/write permissions on the on-premises drive.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>read: read-only. Cloud computers support on-premises disk mapping, but only for reading (copying) files—not modifying them.</description></item>
        /// <item><description>readwrite: read and write. Cloud computers support on-premises disk mapping, allowing you to read (copy) and write (modify) on-premises files.</description></item>
        /// <item><description>off (default): none. Cloud computers don\&quot;t support on-premises disk mapping.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        /// <summary>
        /// <para>The maximum duration to retry reconnecting to cloud computers after an unexpected disconnection (non-human causes). Valid values: 30 to 7200. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MaxReconnectTime")]
        [Validation(Required=false)]
        public int? MaxReconnectTime { get; set; }

        /// <summary>
        /// <para>The memory underclocking duration per process. Valid values: 30 to 120. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemoryDownGradeDuration")]
        [Validation(Required=false)]
        public int? MemoryDownGradeDuration { get; set; }

        /// <summary>
        /// <para>The memory processors.</para>
        /// </summary>
        [NameInMap("MemoryProcessors")]
        [Validation(Required=false)]
        public List<string> MemoryProcessors { get; set; }

        /// <summary>
        /// <para>The memory spike protection policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: disables memory spike protection.</description></item>
        /// <item><description>on: enables memory spike protection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
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
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemorySampleDuration")]
        [Validation(Required=false)]
        public int? MemorySampleDuration { get; set; }

        /// <summary>
        /// <para>The memory usage per process. Valid values: 30 to 60. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemorySingleRateLimit")]
        [Validation(Required=false)]
        public int? MemorySingleRateLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the Restart button in the DesktopAssistant menu when end users connect to cloud computers from Android clients.</para>
        /// <remarks>
        /// <para> This feature applies to only mobile clients of version 7.4.0 or later.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t display the Restart button in the DesktopAssistant menu.</description></item>
        /// <item><description>on: displays the Restart button in the DesktopAssistant menu.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileRestart")]
        [Validation(Required=false)]
        public string MobileRestart { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the Stop button in the DesktopAssistant menu when end users connect to cloud computers from Android clients.</para>
        /// <remarks>
        /// <para> This feature applies to only mobile clients of version 7.4.0 or later.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t display the Stop button in the DesktopAssistant menu.</description></item>
        /// <item><description>on: displays the Stop button in the DesktopAssistant menu.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileShutdown")]
        [Validation(Required=false)]
        public string MobileShutdown { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPolicyGroupName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network redirection policy.</para>
        /// <remarks>
        /// <para> This parameter is in private preview and only available to specific users.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all: enables network redirection globally.</description></item>
        /// <item><description>off (default): disables network redirection.</description></item>
        /// <item><description>on: enables the whitelist mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("NetRedirect")]
        [Validation(Required=false)]
        public string NetRedirect { get; set; }

        /// <summary>
        /// <para>The network redirection policy.</para>
        /// <remarks>
        /// <para> This parameter is in private preview and only available to specific users.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("NetRedirectRule")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestNetRedirectRule> NetRedirectRule { get; set; }
        public class CreateCenterPolicyRequestNetRedirectRule : TeaModel {
            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.taobao.com</para>
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>prc: process.</description></item>
            /// <item><description>domain: domain name.</description></item>
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
        /// <para>Specifies whether to enforce a disconnection upon inactivity.</para>
        /// <remarks>
        /// <para> This parameter applies only to cloud application policies.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t enforce a disconnection upon inactivity.</description></item>
        /// <item><description>on: enforces a disconnection upon inactivity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("NoOperationDisconnect")]
        [Validation(Required=false)]
        public string NoOperationDisconnect { get; set; }

        /// <summary>
        /// <para>The duration of disconnection after inactivity. Valid values: 120 to 7200. Unit: seconds.</para>
        /// <remarks>
        /// <para> This parameter applies only to cloud application policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("NoOperationDisconnectTime")]
        [Validation(Required=false)]
        public int? NoOperationDisconnectTime { get; set; }

        /// <summary>
        /// <para>The printer redirection policy. This parameter only applies if DeviceRedirects does not include a printer redirection policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>deviceRedirect (default):enables device redirection.</description></item>
        /// <item><description>usbRedirect: enables USB redirection.</description></item>
        /// <item><description>off: disables any type of redirection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PrinterRedirect")]
        [Validation(Required=false)]
        public string PrinterRedirect { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable image quality enhancement for design and 3D applications.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t enable image quality enhancement for design and 3D applications.</description></item>
        /// <item><description>on: enables image quality enhancement for design and 3D applications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("QualityEnhancement")]
        [Validation(Required=false)]
        public string QualityEnhancement { get; set; }

        /// <summary>
        /// <para>The duration of screen recording after the specified event is detected. Unit: minutes. Valid values: 10 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordEventDuration")]
        [Validation(Required=false)]
        public int? RecordEventDuration { get; set; }

        /// <summary>
        /// <para>The absolute paths to screen recording files.</para>
        /// </summary>
        [NameInMap("RecordEventFilePaths")]
        [Validation(Required=false)]
        public List<string> RecordEventFilePaths { get; set; }

        /// <summary>
        /// <para>The absolute paths to screen recording registries.</para>
        /// </summary>
        [NameInMap("RecordEventRegisters")]
        [Validation(Required=false)]
        public List<string> RecordEventRegisters { get; set; }

        /// <summary>
        /// <para>The events that trigger screen recording.</para>
        /// </summary>
        [NameInMap("RecordEvents")]
        [Validation(Required=false)]
        public List<string> RecordEvents { get; set; }

        /// <summary>
        /// <para>The screen recording policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>period: Screen recording occurs at set intervals.</description></item>
        /// <item><description>session: Screen recording is limited to sessions only.</description></item>
        /// <item><description>off: Screen recording is disabled.</description></item>
        /// <item><description>alltime: Screen recording is always enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Recording")]
        [Validation(Required=false)]
        public string Recording { get; set; }

        /// <summary>
        /// <para>Specifies whether to record audio files generated on cloud computers.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t record audio files generated on cloud computers.</description></item>
        /// <item><description>on: records audio files generated on cloud computers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RecordingAudio")]
        [Validation(Required=false)]
        public string RecordingAudio { get; set; }

        /// <summary>
        /// <para>The frame rate of screen recording. Screen recordings are split based on the specified duration and uploaded to Object Storage Service (OSS) buckets. If a file reaches 300 MB, the system prioritizes rolling updates for that file. Valid values: 10 to 60</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordingDuration")]
        [Validation(Required=false)]
        public int? RecordingDuration { get; set; }

        /// <summary>
        /// <para>The screen recording\&quot;s end time in HH:MM:SS format. The value is meaningful only if <c>Recording</c> is set to <c>PERIOD</c>.</para>
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
        public int? RecordingExpires { get; set; }

        /// <summary>
        /// <para>The frame rate of screen recording. Unit: fps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecordingFps")]
        [Validation(Required=false)]
        public string RecordingFps { get; set; }

        /// <summary>
        /// <para>The screen recording\&quot;s start time in HH:MM:SS format. The value is meaningful only if <c>Recording</c> is set to <c>PERIOD</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00:00</para>
        /// </summary>
        [NameInMap("RecordingStartTime")]
        [Validation(Required=false)]
        public string RecordingStartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to notify end users when screen recording is enabled.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t notify end users when screen recording is enabled.</description></item>
        /// <item><description>on: notifies end users when screen recording is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("RecordingUserNotify")]
        [Validation(Required=false)]
        public string RecordingUserNotify { get; set; }

        /// <summary>
        /// <para>The notification sent to end users when screen recording is enabled.</para>
        /// </summary>
        [NameInMap("RecordingUserNotifyMessage")]
        [Validation(Required=false)]
        public string RecordingUserNotifyMessage { get; set; }

        /// <summary>
        /// <para>The region ID. Set the value to cn-shanghai.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The keyboard and mouse control permissions during remote assistance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optionalControl: By default, keyboard and mouse control is disabled during remote assistance. You can request permissions as needed.</description></item>
        /// <item><description>fullControl: Keyboard and mouse control is enabled during remote assistance.</description></item>
        /// <item><description>disableControl: Keyboard and mouse control is disabled during remote assistance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fullControl</para>
        /// </summary>
        [NameInMap("RemoteCoordinate")]
        [Validation(Required=false)]
        public string RemoteCoordinate { get; set; }

        /// <summary>
        /// <para>The computer reset setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ResetDesktop")]
        [Validation(Required=false)]
        public string ResetDesktop { get; set; }

        /// <summary>
        /// <para>The resolution height. Unit: pixel. Valid values for cloud applications: 500 to 50000. Valid values for cloud computers: 480 to 4096.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// <para>The resolution type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>adaptive: adaptive resolution.</description></item>
        /// <item><description>customer: fixed resolution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>adaptive</para>
        /// </summary>
        [NameInMap("ResolutionModel")]
        [Validation(Required=false)]
        public string ResolutionModel { get; set; }

        /// <summary>
        /// <para>The resolution width. Unit: pixel. Valid values for cloud applications: 500 to 50000. Valid values for cloud computers: 480 to 4096.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("ResolutionWidth")]
        [Validation(Required=false)]
        public int? ResolutionWidth { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>app: cloud applications.</description></item>
        /// <item><description>desktop: cloud computers.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SafeMenu")]
        [Validation(Required=false)]
        public string SafeMenu { get; set; }

        /// <summary>
        /// <para>The effective scope of the policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IP: The policy applies to specific IP addresses.</description></item>
        /// <item><description>GLOBAL: The policy applies globally.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The effective scopes. This parameter is required when <c>Scope</c> is set to <c>IP</c>. If <c>Scope</c> is set to <c>IP</c>, this parameter doesn\&quot;t take effect.</para>
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public List<string> ScopeValue { get; set; }

        /// <summary>
        /// <para>The bandwidth peak allowed for sessions. Unit: Kbit/s. Valid values: 2000 to 100000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("SessionMaxRateKbps")]
        [Validation(Required=false)]
        public int? SessionMaxRateKbps { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable smoothness enhancement for daily office use.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t enable smoothness enhancement for daily office use.</description></item>
        /// <item><description>on: enables smoothness enhancement for daily office use.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SmoothEnhancement")]
        [Validation(Required=false)]
        public string SmoothEnhancement { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the metric status entry in the DesktopAssistant menu.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t display the metric status entry in the DesktopAssistant menu.</description></item>
        /// <item><description>on: displays the metric status entry in the DesktopAssistant menu.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("StatusMonitor")]
        [Validation(Required=false)]
        public string StatusMonitor { get; set; }

        /// <summary>
        /// <para>The streaming mode.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>intelligent</description></item>
        /// <item><description>smooth</description></item>
        /// </list>
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
        /// <para>Specifies whether to display the application taskbar.</para>
        /// <remarks>
        /// <para> This parameter applies only to cloud application policies.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t display the application taskbar.</description></item>
        /// <item><description>on: displays the application taskbar.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Taskbar")]
        [Validation(Required=false)]
        public string Taskbar { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable USB redirection.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off (default): doesn\&quot;t enable USB redirection.</description></item>
        /// <item><description>on: enables USB redirection.</description></item>
        /// </list>
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
        public List<CreateCenterPolicyRequestUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
        public class CreateCenterPolicyRequestUsbSupplyRedirectRule : TeaModel {
            /// <summary>
            /// <para>The rule description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The product ID (PID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>08**</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow USB redirection.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: allows USB redirection.</description></item>
            /// <item><description>2: forbids USB redirection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsbRedirectType")]
            [Validation(Required=false)]
            public string UsbRedirectType { get; set; }

            /// <summary>
            /// <para>The type of the USB redirection rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: enables USB redirection based on products.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UsbRuleType")]
            [Validation(Required=false)]
            public string UsbRuleType { get; set; }

            /// <summary>
            /// <para>The vendor ID (VID). For more information, see <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB Vendor IDs (VIDs)</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04**</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// <para>The average bitrate for video encoding. Unit: Kbit/s. Valid values: 1000 to 50000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoEncAvgKbps")]
        [Validation(Required=false)]
        public int? VideoEncAvgKbps { get; set; }

        /// <summary>
        /// <para>The maximum QP for video files. Higher QP values result in lower video quality. Valid values: 0 to 51.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("VideoEncMaxQP")]
        [Validation(Required=false)]
        public int? VideoEncMaxQP { get; set; }

        /// <summary>
        /// <para>The minimum quantizer parameter (QP) for video files. A lower QP means better video quality. Valid values: 0 to 51.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("VideoEncMinQP")]
        [Validation(Required=false)]
        public int? VideoEncMinQP { get; set; }

        /// <summary>
        /// <para>The peak bitrate for video encoding. Unit: Kbit/s. Valid values: 1000 to 50000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoEncPeakKbps")]
        [Validation(Required=false)]
        public int? VideoEncPeakKbps { get; set; }

        /// <summary>
        /// <para>The video encoding policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>qualityFirst: prioritizes image quality.</description></item>
        /// <item><description>bandwidthFirst: prioritizes bandwidth.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>qualityFirst</para>
        /// </summary>
        [NameInMap("VideoEncPolicy")]
        [Validation(Required=false)]
        public string VideoEncPolicy { get; set; }

        /// <summary>
        /// <para>The multimedia redirection policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: disables multimedia redirection.</description></item>
        /// <item><description>on: enables multimedia redirection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("VideoRedirect")]
        [Validation(Required=false)]
        public string VideoRedirect { get; set; }

        /// <summary>
        /// <para>The image display quality.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>high: high-definition (HD).</description></item>
        /// <item><description>low: smoothness.</description></item>
        /// <item><description>lossless: no quality loss.</description></item>
        /// <item><description>medium (default): scenario-specific adaptation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("VisualQuality")]
        [Validation(Required=false)]
        public string VisualQuality { get; set; }

        /// <summary>
        /// <para>The watermark policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>blind: displays invisible watermarks.</description></item>
        /// <item><description>off (default): displays no watermark.</description></item>
        /// <item><description>on: displays visible watermarks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable anti-screen capture for invisible watermarks.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: disables anti-screen capture for invisible watermarks.</description></item>
        /// <item><description>on: enables anti-screen capture for invisible watermarks.</description></item>
        /// </list>
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
        /// <para>If you set <c>WatermarkType</c> to <c>custom</c>, you must also specify <c>WatermarkCustomText</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("WatermarkCustomText")]
        [Validation(Required=false)]
        public string WatermarkCustomText { get; set; }

        /// <summary>
        /// <para>The watermark rotation. Valid values: -10 to -30.</para>
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
        /// <para>The enhancement level for invisible watermarks.</para>
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
        /// <para>The number of watermark rows. Valid values: 3 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("WatermarkRowAmount")]
        [Validation(Required=false)]
        public int? WatermarkRowAmount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable security priority for invisible watermarks.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: disables security priority for invisible watermarks.</description></item>
        /// <item><description>on: enables security priority for invisible watermarks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("WatermarkSecurity")]
        [Validation(Required=false)]
        public string WatermarkSecurity { get; set; }

        /// <summary>
        /// <para>The watermark opacity. A higher value makes the watermark more opaque. Valid values: 10 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WatermarkTransparencyValue")]
        [Validation(Required=false)]
        public int? WatermarkTransparencyValue { get; set; }

        /// <summary>
        /// <para>The watermark type. You can specify up to three types. Separate multiple values with commas (,).</para>
        /// <remarks>
        /// <para> If you provide <c>custom</c> as the value for this parameter, you must configure <c>WatermarkCustomText</c> to specify custom text.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EndUserId: the username.</description></item>
        /// <item><description>Custom: the custom text.</description></item>
        /// <item><description>DesktopIp: the IP address of the cloud computer.</description></item>
        /// <item><description>ClientIp: the IP address of the client.</description></item>
        /// <item><description>HostName: the rightmost 15 digits of the cloud computer ID.</description></item>
        /// <item><description>ClientTime: the current time displayed on the cloud computer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EndUserId,HostName,ClientTime</para>
        /// </summary>
        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Cloud Computer Manager.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WuyingKeeper")]
        [Validation(Required=false)]
        public string WuyingKeeper { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the Xiaoying AI Assistant option in the DesktopAssistant menu when end users connect to cloud computers via desktop clients (Windows and macOS).</para>
        /// <remarks>
        /// <para> This feature applies to only desktop clients of version 7.7.0 or later.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: doesn\&quot;t display the Xiaoying AI Assistant option in the DesktopAssistant menu.</description></item>
        /// <item><description>on: displays the Xiaoying AI Assistant option in the DesktopAssistant menu.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("WyAssistant")]
        [Validation(Required=false)]
        public string WyAssistant { get; set; }

    }

}
