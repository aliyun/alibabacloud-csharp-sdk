// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCenterPolicyListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the cloud computer policy.</para>
        /// </summary>
        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=false)]
        public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribeCenterPolicyListResponseBodyDescribePolicyGroups : TeaModel {
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
            /// <para>Specifies whether the user has administrator permissions after connecting to the cloud computer.</para>
            /// <remarks>
            /// <para>This feature is in limited preview and is not publicly available.</para>
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
            /// <para>Specifies whether to enable administrator keyboard control in Windows. Valid values:</para>
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
            /// <para>Specifies whether to enable administrator monitoring. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Enabled.</description></item>
            /// <item><description>0: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AdminMonitor")]
            [Validation(Required=false)]
            public int? AdminMonitor { get; set; }

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
            /// <para>The list of custom OSS buckets for mobile screenshots in screen capture prevention.</para>
            /// </summary>
            [NameInMap("AppScreenshotBuckets")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAppScreenshotBuckets> AppScreenshotBuckets { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAppScreenshotBuckets : TeaModel {
                /// <summary>
                /// <para>The name of the bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-bucket-01</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The region where the user\&quot;s OSS bucket is located. It must be the same as the actual region of the bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("BucketRegionId")]
                [Validation(Required=false)]
                public string BucketRegionId { get; set; }

            }

            /// <summary>
            /// <para>The IP address whitelist for client access.</para>
            /// </summary>
            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules : TeaModel {
                /// <summary>
                /// <para>The CIDR block for client access. The value must be an IPv4 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX/16</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>The description of the CIDR block for client access.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Corporate office CIDR block</para>
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
                /// <para>The target of the security group control rule. The value must be an IPv4 CIDR block.</para>
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

            /// <summary>
            /// <para>Specifies whether to enable automatic reconnection for the client.</para>
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
            /// <para>off</para>
            /// </summary>
            [NameInMap("AutoSaveAppScreenshot")]
            [Validation(Required=false)]
            public string AutoSaveAppScreenshot { get; set; }

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
            /// <para>Specifies whether to enable the feature that allows the client to create custom snapshots. Valid values:</para>
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
            /// <para>Specifies whether to enable the hibernate option in the client menu. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ClientHibernate")]
            [Validation(Required=false)]
            public string ClientHibernate { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the restart option in the client menu. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ClientRestart")]
            [Validation(Required=false)]
            public string ClientRestart { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the shutdown option in the client menu. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
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
                /// <para>Specifies whether to allow a specific type of client to log on to the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
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
            /// <para>Specifies whether color enhancement is enabled for design and 3D Common scenarios.</para>
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
            /// <para>The CPU downclocking duration. Valid values: 30 to 120. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CpuDownGradeDuration")]
            [Validation(Required=false)]
            public int? CpuDownGradeDuration { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable CPU load protection. Valid values:</para>
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
            /// <para>on</para>
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("CpuSampleDuration")]
            [Validation(Required=false)]
            public int? CpuSampleDuration { get; set; }

            /// <summary>
            /// <para>The single-core CPU utilization percentage. Valid values: 70 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("CpuSingleRateLimit")]
            [Validation(Required=false)]
            public int? CpuSingleRateLimit { get; set; }

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
            /// <para>The device redirection rules.</para>
            /// </summary>
            [NameInMap("DeviceRedirects")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDeviceRedirects> DeviceRedirects { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDeviceRedirects : TeaModel {
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
                /// <para>The platform types to which the device rules apply.</para>
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
            /// <para>Specifies whether to retain the session after disconnection.</para>
            /// <remarks>
            /// <para>This applies only to cloud application policies.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>persistent</para>
            /// </summary>
            [NameInMap("DisconnectKeepSession")]
            [Validation(Required=false)]
            public string DisconnectKeepSession { get; set; }

            /// <summary>
            /// <para>The session retention duration after disconnection. Unit: seconds.</para>
            /// <remarks>
            /// <para>This applies only to cloud application policies.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("DisconnectKeepSessionTime")]
            [Validation(Required=false)]
            public int? DisconnectKeepSessionTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable disk load protection. Valid values:</para>
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
            /// <para>adminCustom</para>
            /// </summary>
            [NameInMap("DisplayMode")]
            [Validation(Required=false)]
            public string DisplayMode { get; set; }

            /// <summary>
            /// <para>The effective field for domain name resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainRegisterValue")]
            [Validation(Required=false)]
            public string DomainRegisterValue { get; set; }

            /// <summary>
            /// <para>The details of the domain name resolution policy.</para>
            /// </summary>
            [NameInMap("DomainResolveRule")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDomainResolveRule> DomainResolveRule { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDomainResolveRule : TeaModel {
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
            /// <para>Specifies whether to enable the domain name resolution policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("DomainResolveRuleType")]
            [Validation(Required=false)]
            public string DomainResolveRuleType { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow users to request administrator assistance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("EndUserApplyAdminCoordinate")]
            [Validation(Required=false)]
            public string EndUserApplyAdminCoordinate { get; set; }

            /// <summary>
            /// <para>The number of associated end users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("EndUserCount")]
            [Validation(Required=false)]
            public string EndUserCount { get; set; }

            /// <summary>
            /// <para>Specifies whether users in the same office network share cloud desktops.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("EndUserGroupCoordinate")]
            [Validation(Required=false)]
            public string EndUserGroupCoordinate { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow the use of external storage devices. Valid values:</para>
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
            /// <para>The maximum size of a file that can be transferred to the cloud desktop in a single operation. This parameter must be used together with the transfer-in unit parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FileTransferInSize")]
            [Validation(Required=false)]
            public string FileTransferInSize { get; set; }

            /// <summary>
            /// <para>The unit for the maximum size of a file that can be transferred to the cloud desktop in a single operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MB</para>
            /// </summary>
            [NameInMap("FileTransferInUnit")]
            [Validation(Required=false)]
            public string FileTransferInUnit { get; set; }

            /// <summary>
            /// <para>The maximum size of a file that can be transferred from the cloud desktop in a single operation. This parameter must be used together with the transfer-out unit parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FileTransferOutSize")]
            [Validation(Required=false)]
            public string FileTransferOutSize { get; set; }

            /// <summary>
            /// <para>The unit for the maximum size of a file that can be transferred from the cloud desktop in a single operation.</para>
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
            /// <para>Specifies whether to enable file synchronization. Valid values:</para>
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
            /// <para>Specifies whether to enable message prompts for the floating ball configuration. Valid values:</para>
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
            /// <para>Specifies whether to enable the hibernate button on the floating ball. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("HoverHibernate")]
            [Validation(Required=false)]
            public string HoverHibernate { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the restart button on the floating ball. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("HoverRestart")]
            [Validation(Required=false)]
            public string HoverRestart { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the shutdown button on the floating ball. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("HoverShutdown")]
            [Validation(Required=false)]
            public string HoverShutdown { get; set; }

            /// <summary>
            /// <para>The access policy for the web client.</para>
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
            /// <para>tcp</para>
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
            /// <para>Specifies whether to enable keyboard control on the floating ball. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("KeyboardControl")]
            [Validation(Required=false)]
            public string KeyboardControl { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the KMS server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("KmsServer")]
            [Validation(Required=false)]
            public string KmsServer { get; set; }

            /// <summary>
            /// <para>The KMS server configuration in the address:port format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kms.example.com:1688</para>
            /// </summary>
            [NameInMap("KmsServerConfig")]
            [Validation(Required=false)]
            public string KmsServerConfig { get; set; }

            /// <summary>
            /// <para>The mapping permissions for local disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            /// <summary>
            /// <para>The maximum connection retry time for a cloud desktop that is disconnected due to objective reasons. Valid values: 30 to 7200. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxReconnectTime")]
            [Validation(Required=false)]
            public int? MaxReconnectTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the MCP service. Valid values:</para>
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
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemoryDownGradeDuration")]
            [Validation(Required=false)]
            public int? MemoryDownGradeDuration { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable memory load protection. Valid values:</para>
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
            /// <para>Specifies whether to enable the memory protection mode.</para>
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
            /// <para>The memory usage percentage for a single process. Valid values: 30 to 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemorySingleRateLimit")]
            [Validation(Required=false)]
            public int? MemorySingleRateLimit { get; set; }

            /// <summary>
            /// <para>Specifies whether to provide a restart button on the floating ball when you connect to a cloud desktop from a mobile client (Android client&lt;props=&quot;china&quot;&gt; and iOS client).</para>
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
            /// <para>Specifies whether to enable the Windows security control on the mobile client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileSafeMenu")]
            [Validation(Required=false)]
            public string MobileSafeMenu { get; set; }

            /// <summary>
            /// <para>Specifies whether to provide a shutdown button on the floating ball when you connect to a cloud desktop from a mobile client (Android client&lt;props=&quot;china&quot;&gt; and iOS client).</para>
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
            /// <para>Specifies whether to enable the Wuying Assistant on the mobile client.</para>
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
            /// <para>The network redirection setting.</para>
            /// <remarks>
            /// <para>This feature is in closed beta and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("NetRedirect")]
            [Validation(Required=false)]
            public string NetRedirect { get; set; }

            /// <summary>
            /// <para>The details of the network redirection policy.</para>
            /// <remarks>
            /// <para>This feature is in closed beta and is not publicly available.</para>
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
            [NameInMap("NetworkPrinter")]
            [Validation(Required=false)]
            public string NetworkPrinter { get; set; }

            /// <summary>
            /// <para>Specifies whether to disconnect the session when no operations are performed.</para>
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
            /// <para>The idle timeout period before disconnection. Unit: seconds.</para>
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
            /// <para>The number of associated organizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
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
            /// <para>The status of the cloud desktop policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

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
            /// <para>The printer pop-up prompt setting. Valid values:</para>
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
            /// <para>The printer redirection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("PrinterRedirection")]
            [Validation(Required=false)]
            public string PrinterRedirection { get; set; }

            /// <summary>
            /// <para>Specifies whether image quality enhancement is enabled for Common scenarios such as design and 3D.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("QualityEnhancement")]
            [Validation(Required=false)]
            public string QualityEnhancement { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable custom screen recording.</para>
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
            /// <para>The absolute paths for file monitoring in screen recording audit.</para>
            /// </summary>
            [NameInMap("RecordEventFilePaths")]
            [Validation(Required=false)]
            public List<string> RecordEventFilePaths { get; set; }

            /// <summary>
            /// <para>The absolute paths for registry monitoring in screen recording audit.</para>
            /// </summary>
            [NameInMap("RecordEventRegisters")]
            [Validation(Required=false)]
            public List<string> RecordEventRegisters { get; set; }

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
            /// <para>The option for recording the audio of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RecordingAudio")]
            [Validation(Required=false)]
            public string RecordingAudio { get; set; }

            /// <summary>
            /// <para>The duration of each screen recording file, in minutes. Recorded files are automatically split and uploaded to the storage space based on the specified duration. If a file reaches 300 MB, it is overwritten on a rolling basis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// <para>The end time of screen recording. Format: HH:MM:SS. This parameter is valid only when the Recording parameter is set to period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:59:00</para>
            /// </summary>
            [NameInMap("RecordingEndTime")]
            [Validation(Required=false)]
            public string RecordingEndTime { get; set; }

            /// <summary>
            /// <para>The retention period of screen recording files. Valid values: 1 to 180 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("RecordingExpires")]
            [Validation(Required=false)]
            public long? RecordingExpires { get; set; }

            /// <summary>
            /// <para>The frame rate of screen recording. Unit: FPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecordingFps")]
            [Validation(Required=false)]
            public long? RecordingFps { get; set; }

            /// <summary>
            /// <para>The start time of screen recording. Format: HH:MM:SS. This parameter is valid only when the Recording parameter is set to period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00:00</para>
            /// </summary>
            [NameInMap("RecordingStartTime")]
            [Validation(Required=false)]
            public string RecordingStartTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to notify the terminal user that screen recording is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordingUserNotify")]
            [Validation(Required=false)]
            public string RecordingUserNotify { get; set; }

            /// <summary>
            /// <para>The notification message sent to the terminal user when screen recording is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Screen recording is enabled</para>
            /// </summary>
            [NameInMap("RecordingUserNotifyMessage")]
            [Validation(Required=false)]
            public string RecordingUserNotifyMessage { get; set; }

            /// <summary>
            /// <para>The permissions for keyboard and mouse control during remote assistance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fullControl</para>
            /// </summary>
            [NameInMap("RemoteCoordinate")]
            [Validation(Required=false)]
            public string RemoteCoordinate { get; set; }

            /// <summary>
            /// <para>The permission to reset the cloud desktop.</para>
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
            /// <para>The height of the resolution. Unit: pixels.</para>
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
            /// <para>The width of the resolution. Unit: pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

            /// <summary>
            /// <para>The number of resource groups associated with the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceGroupCount")]
            [Validation(Required=false)]
            public int? ResourceGroupCount { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the shortcut key for the security center. Valid values:</para>
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
            /// <para>Specifies whether to enable smoothness enhancement for daily office scenarios.</para>
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
            /// <para>on</para>
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
            /// <para>Specifies whether to enable the triple-screen feature. Valid values:</para>
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
                /// <para>The description of the rule.</para>
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
                /// <para>The type of the USB redirection rule.</para>
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
            /// <para>The average video encoding bitrate. Unit: Kbps. Valid values: 1000 to 50000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("VideoEncAvgKbps")]
            [Validation(Required=false)]
            public int? VideoEncAvgKbps { get; set; }

            /// <summary>
            /// <para>The maximum quantization parameter (QP) for video encoding, which indicates the lowest video quality. Valid values: 0 to 51.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("VideoEncMaxQP")]
            [Validation(Required=false)]
            public int? VideoEncMaxQP { get; set; }

            /// <summary>
            /// <para>The minimum quantization parameter (QP) for video encoding, which indicates the highest video quality. Valid values: 0 to 51.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
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
            /// <para>The blind watermark anti-camera capture feature.</para>
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
            /// <para>If the WatermarkType parameter is set to custom, you must specify the custom text by using the WatermarkCustomText parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom-watermark</para>
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
            /// <para>The number of watermark rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
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
            /// <para>Specifies whether to enable the shadow effect for the watermark. Valid values:</para>
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
            /// <para>The transparency of the watermark. A larger value indicates lower transparency. Valid values: 10 to 100.</para>
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
            /// <para>Specifies whether to provide an entry for the WUYING AI Assistant feature in the floating ball of the cloud desktop.</para>
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
