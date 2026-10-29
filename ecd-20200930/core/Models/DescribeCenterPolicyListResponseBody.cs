// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCenterPolicyListResponseBody : TeaModel {
        /// <summary>
        /// <para>雲端電腦原則的詳細資訊。</para>
        /// </summary>
        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=false)]
        public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribeCenterPolicyListResponseBodyDescribePolicyGroups : TeaModel {
            /// <summary>
            /// <para>學術代理功能開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AcademicProxy")]
            [Validation(Required=false)]
            public string AcademicProxy { get; set; }

            /// <summary>
            /// <para>使用者連線雲端電腦後是否具有管理員權限。</para>
            /// <remarks>
            /// <para>該功能處於定向邀測中，暫不對外開放。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("AdminAccess")]
            [Validation(Required=false)]
            public string AdminAccess { get; set; }

            /// <summary>
            /// <para>全螢幕模式下管理員鍵盤控制開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AdminKeyboardOnFullScreen")]
            [Validation(Required=false)]
            public string AdminKeyboardOnFullScreen { get; set; }

            /// <summary>
            /// <para>Windows 系統內管理員鍵盤控制開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AdminKeyboardOnWindows")]
            [Validation(Required=false)]
            public string AdminKeyboardOnWindows { get; set; }

            /// <summary>
            /// <para>管理員監控開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>1：開啟。</description></item>
            /// <item><description>0：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AdminMonitor")]
            [Validation(Required=false)]
            public int? AdminMonitor { get; set; }

            /// <summary>
            /// <para>是否開啟防截圖功能。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AppContentProtection")]
            [Validation(Required=false)]
            public string AppContentProtection { get; set; }

            /// <summary>
            /// <para>防截圖行動裝置截圖自訂 OSS Bucket 清單。</para>
            /// </summary>
            [NameInMap("AppScreenshotBuckets")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAppScreenshotBuckets> AppScreenshotBuckets { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAppScreenshotBuckets : TeaModel {
                /// <summary>
                /// <para>Bucket 名稱。</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-bucket-01</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>使用者 OSS Bucket 所在地域，必須與 Bucket 的實際地域一致。</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("BucketRegionId")]
                [Validation(Required=false)]
                public string BucketRegionId { get; set; }

            }

            /// <summary>
            /// <para>用戶端存取 IP 白名單。</para>
            /// </summary>
            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAuthorizeAccessPolicyRules : TeaModel {
                /// <summary>
                /// <para>用戶端存取 IP 位址區段。格式為 CIDR 格式的 IPv4 位址區段。</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX/16</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>用戶端存取 IP 位址區段備註資訊。</para>
                /// 
                /// <b>Example:</b>
                /// <para>公司辦公網段</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>安全性群組管控規則清單。</para>
            /// </summary>
            [NameInMap("AuthorizeSecurityPolicyRules")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules> AuthorizeSecurityPolicyRules { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsAuthorizeSecurityPolicyRules : TeaModel {
                /// <summary>
                /// <para>安全性群組管控規則的對象，CIDR 格式的 IPv4 位址區段。</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX/16</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>安全性群組管控規則的描述資訊。</para>
                /// 
                /// <b>Example:</b>
                /// <para>允許存取內網研發環境</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>安全性群組管控規則的通訊協定類型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// <para>安全性群組管控規則的授權原則。</para>
                /// 
                /// <b>Example:</b>
                /// <para>accept</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>安全性群組管控規則的連接埠範圍。</para>
                /// 
                /// <b>Example:</b>
                /// <para>22/22</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>安全性群組管控規則的優先順序，數字越小，代表優先順序越高。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// <para>安全性群組管控規則的規則方向。</para>
                /// 
                /// <b>Example:</b>
                /// <para>inflow</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>用戶端自動重新連線開關。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AutoReconnect")]
            [Validation(Required=false)]
            public string AutoReconnect { get; set; }

            /// <summary>
            /// <para>自動儲存行動裝置截圖。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("AutoSaveAppScreenshot")]
            [Validation(Required=false)]
            public string AutoSaveAppScreenshot { get; set; }

            /// <summary>
            /// <para>是否開啟本機攝影機重新導向。</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CameraRedirect")]
            [Validation(Required=false)]
            public string CameraRedirect { get; set; }

            /// <summary>
            /// <para>用戶端控制選單顯示開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("ClientControlMenu")]
            [Validation(Required=false)]
            public string ClientControlMenu { get; set; }

            /// <summary>
            /// <para>用戶端建立自訂快照功能開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ClientCreateSnapshot")]
            [Validation(Required=false)]
            public string ClientCreateSnapshot { get; set; }

            /// <summary>
            /// <para>用戶端休眠選單開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ClientHibernate")]
            [Validation(Required=false)]
            public string ClientHibernate { get; set; }

            /// <summary>
            /// <para>用戶端重新啟動選單開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ClientRestart")]
            [Validation(Required=false)]
            public string ClientRestart { get; set; }

            /// <summary>
            /// <para>用戶端關機選單開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ClientShutdown")]
            [Validation(Required=false)]
            public string ClientShutdown { get; set; }

            /// <summary>
            /// <para>登入方式管控規則。</para>
            /// </summary>
            [NameInMap("ClientTypes")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsClientTypes> ClientTypes { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsClientTypes : TeaModel {
                /// <summary>
                /// <para>用戶端類型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <para>是否允許某一類型的用戶端登入雲端桌面。</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>剪貼簿權限。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            /// <summary>
            /// <para>設計及 3D 應用場景選擇是否開啟色彩增強。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ColorEnhancement")]
            [Validation(Required=false)]
            public string ColorEnhancement { get; set; }

            /// <summary>
            /// <para>本機驅動程式剪貼簿功能開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("CpdDriveClipboard")]
            [Validation(Required=false)]
            public string CpdDriveClipboard { get; set; }

            /// <summary>
            /// <para>CPU 降頻時長，取值範圍： 30\~120。單位：秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CpuDownGradeDuration")]
            [Validation(Required=false)]
            public int? CpuDownGradeDuration { get; set; }

            /// <summary>
            /// <para>CPU 負載保護開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("CpuOverload")]
            [Validation(Required=false)]
            public string CpuOverload { get; set; }

            /// <summary>
            /// <para>處理程序名稱。</para>
            /// </summary>
            [NameInMap("CpuProcessors")]
            [Validation(Required=false)]
            public List<string> CpuProcessors { get; set; }

            /// <summary>
            /// <para>CPU 保護模式開關。</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CpuProtectedMode")]
            [Validation(Required=false)]
            public string CpuProtectedMode { get; set; }

            /// <summary>
            /// <para>CPU 整體使用率百分比，取值範圍： 70\~90。</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("CpuRateLimit")]
            [Validation(Required=false)]
            public int? CpuRateLimit { get; set; }

            /// <summary>
            /// <para>CPU 整體取樣時長，取值範圍： 10\~60。單位：秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CpuSampleDuration")]
            [Validation(Required=false)]
            public int? CpuSampleDuration { get; set; }

            /// <summary>
            /// <para>CPU 單核心使用率百分比，取值範圍： 70\~100。</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("CpuSingleRateLimit")]
            [Validation(Required=false)]
            public int? CpuSingleRateLimit { get; set; }

            /// <summary>
            /// <para>已關聯該原則的雲端電腦數量。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public int? DesktopCount { get; set; }

            /// <summary>
            /// <para>已關聯該原則的雲端電腦集區數量。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public int? DesktopGroupCount { get; set; }

            /// <summary>
            /// <para>周邊裝置連線提示控制。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("DeviceConnectHint")]
            [Validation(Required=false)]
            public string DeviceConnectHint { get; set; }

            /// <summary>
            /// <para>裝置重新導向規則。</para>
            /// </summary>
            [NameInMap("DeviceRedirects")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDeviceRedirects> DeviceRedirects { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDeviceRedirects : TeaModel {
                /// <summary>
                /// <para>周邊裝置類型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>camera</para>
                /// </summary>
                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                /// <summary>
                /// <para>重新導向類型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>usbRedirect</para>
                /// </summary>
                [NameInMap("RedirectType")]
                [Validation(Required=false)]
                public string RedirectType { get; set; }

            }

            /// <summary>
            /// <para>自訂周邊裝置規則。</para>
            /// </summary>
            [NameInMap("DeviceRules")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDeviceRules> DeviceRules { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDeviceRules : TeaModel {
                /// <summary>
                /// <para>裝置名稱。</para>
                /// 
                /// <b>Example:</b>
                /// <para>sandisk</para>
                /// </summary>
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// <para>產品 ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0x55b1</para>
                /// </summary>
                [NameInMap("DevicePid")]
                [Validation(Required=false)]
                public string DevicePid { get; set; }

                /// <summary>
                /// <para>周邊裝置類型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>storage</para>
                /// </summary>
                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                /// <summary>
                /// <para>生產廠商 ID。參見 <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB Vendor IDs (VIDs)</a>。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0x0781</para>
                /// </summary>
                [NameInMap("DeviceVid")]
                [Validation(Required=false)]
                public string DeviceVid { get; set; }

                /// <summary>
                /// <para>連結最佳化指令。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2:0</para>
                /// </summary>
                [NameInMap("OptCommand")]
                [Validation(Required=false)]
                public string OptCommand { get; set; }

                /// <summary>
                /// <para>裝置規則適用的平台類型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>Windows</para>
                /// </summary>
                [NameInMap("Platforms")]
                [Validation(Required=false)]
                public string Platforms { get; set; }

                /// <summary>
                /// <para>重新導向類型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>usbRedirect</para>
                /// </summary>
                [NameInMap("RedirectType")]
                [Validation(Required=false)]
                public string RedirectType { get; set; }

            }

            /// <summary>
            /// <para>工作階段斷線保留。</para>
            /// <remarks>
            /// <para>僅適用於雲端應用程式原則。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>persistent</para>
            /// </summary>
            [NameInMap("DisconnectKeepSession")]
            [Validation(Required=false)]
            public string DisconnectKeepSession { get; set; }

            /// <summary>
            /// <para>工作階段斷線保留時長。單位：秒。</para>
            /// <remarks>
            /// <para>僅適用於雲端應用程式原則。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("DisconnectKeepSessionTime")]
            [Validation(Required=false)]
            public int? DisconnectKeepSessionTime { get; set; }

            /// <summary>
            /// <para>磁碟負載保護開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("DiskOverload")]
            [Validation(Required=false)]
            public string DiskOverload { get; set; }

            /// <summary>
            /// <para>顯示模式。</para>
            /// 
            /// <b>Example:</b>
            /// <para>adminCustom</para>
            /// </summary>
            [NameInMap("DisplayMode")]
            [Validation(Required=false)]
            public string DisplayMode { get; set; }

            /// <summary>
            /// <para>網域解析生效欄位。</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainRegisterValue")]
            [Validation(Required=false)]
            public string DomainRegisterValue { get; set; }

            /// <summary>
            /// <para>網域解析原則詳情。</para>
            /// </summary>
            [NameInMap("DomainResolveRule")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDomainResolveRule> DomainResolveRule { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsDomainResolveRule : TeaModel {
                /// <summary>
                /// <para>原則描述。</para>
                /// 
                /// <b>Example:</b>
                /// <para>測試規則</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>網域。</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>解析原則。</para>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

            /// <summary>
            /// <para>網域解析原則開關。</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("DomainResolveRuleType")]
            [Validation(Required=false)]
            public string DomainResolveRuleType { get; set; }

            /// <summary>
            /// <para>使用者請求管理員協助。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("EndUserApplyAdminCoordinate")]
            [Validation(Required=false)]
            public string EndUserApplyAdminCoordinate { get; set; }

            /// <summary>
            /// <para>關聯的終端使用者數量。</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("EndUserCount")]
            [Validation(Required=false)]
            public string EndUserCount { get; set; }

            /// <summary>
            /// <para>同一個辦公網路下使用者共享雲端電腦。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("EndUserGroupCoordinate")]
            [Validation(Required=false)]
            public string EndUserGroupCoordinate { get; set; }

            /// <summary>
            /// <para>外接儲存裝置使用開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ExternalDrive")]
            [Validation(Required=false)]
            public string ExternalDrive { get; set; }

            /// <summary>
            /// <para>檔案遷移。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("FileMigrate")]
            [Validation(Required=false)]
            public string FileMigrate { get; set; }

            /// <summary>
            /// <para>檔案傳輸功能的服務位址。</para>
            /// 
            /// <b>Example:</b>
            /// <para>filetransfer.example.com</para>
            /// </summary>
            [NameInMap("FileTransferAddress")]
            [Validation(Required=false)]
            public string FileTransferAddress { get; set; }

            /// <summary>
            /// <para>單次傳入雲端電腦的檔案大小限制，需與傳入單位參數配合使用。</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FileTransferInSize")]
            [Validation(Required=false)]
            public string FileTransferInSize { get; set; }

            /// <summary>
            /// <para>單次傳入雲端電腦的檔案大小限制單位。</para>
            /// 
            /// <b>Example:</b>
            /// <para>MB</para>
            /// </summary>
            [NameInMap("FileTransferInUnit")]
            [Validation(Required=false)]
            public string FileTransferInUnit { get; set; }

            /// <summary>
            /// <para>單次從雲端電腦傳出的檔案大小限制，需與傳出單位參數配合使用。</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FileTransferOutSize")]
            [Validation(Required=false)]
            public string FileTransferOutSize { get; set; }

            /// <summary>
            /// <para>單次從雲端電腦傳出的檔案大小限制單位。</para>
            /// 
            /// <b>Example:</b>
            /// <para>MB</para>
            /// </summary>
            [NameInMap("FileTransferOutUnit")]
            [Validation(Required=false)]
            public string FileTransferOutUnit { get; set; }

            /// <summary>
            /// <para>檔案傳輸大小限制開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("FileTransferSizeLimit")]
            [Validation(Required=false)]
            public string FileTransferSizeLimit { get; set; }

            /// <summary>
            /// <para>檔案傳輸速度檔位。</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("FileTransferSpeed")]
            [Validation(Required=false)]
            public string FileTransferSpeed { get; set; }

            /// <summary>
            /// <para>用戶端設定的檔案傳輸速度生效位置。</para>
            /// 
            /// <b>Example:</b>
            /// <para>client</para>
            /// </summary>
            [NameInMap("FileTransferSpeedLocation")]
            [Validation(Required=false)]
            public string FileTransferSpeedLocation { get; set; }

            /// <summary>
            /// <para>檔案同步開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("FolderSync")]
            [Validation(Required=false)]
            public string FolderSync { get; set; }

            /// <summary>
            /// <para>是否為圖形型規格雲端電腦開啟畫質策略。對雲端電腦效能和使用體驗要求較高時，例如專業設計場景下，建議開啟該策略。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("GpuAcceleration")]
            [Validation(Required=false)]
            public string GpuAcceleration { get; set; }

            /// <summary>
            /// <para>懸浮球設定訊息提示開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("HoverConfigMsg")]
            [Validation(Required=false)]
            public string HoverConfigMsg { get; set; }

            /// <summary>
            /// <para>懸浮球休眠按鈕開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("HoverHibernate")]
            [Validation(Required=false)]
            public string HoverHibernate { get; set; }

            /// <summary>
            /// <para>懸浮球重新啟動按鈕開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("HoverRestart")]
            [Validation(Required=false)]
            public string HoverRestart { get; set; }

            /// <summary>
            /// <para>懸浮球關機按鈕開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("HoverShutdown")]
            [Validation(Required=false)]
            public string HoverShutdown { get; set; }

            /// <summary>
            /// <para>Web用戶端存取策略。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Html5Access")]
            [Validation(Required=false)]
            public string Html5Access { get; set; }

            /// <summary>
            /// <para>Web用戶端檔案傳輸策略。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            /// <summary>
            /// <para>網路通訊協定。</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("InternetCommunicationProtocol")]
            [Validation(Required=false)]
            public string InternetCommunicationProtocol { get; set; }

            /// <summary>
            /// <para>網路印表機功能開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("InternetPrinter")]
            [Validation(Required=false)]
            public string InternetPrinter { get; set; }

            /// <summary>
            /// <para>懸浮球鍵盤控制開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("KeyboardControl")]
            [Validation(Required=false)]
            public string KeyboardControl { get; set; }

            /// <summary>
            /// <para>KMS 伺服器開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("KmsServer")]
            [Validation(Required=false)]
            public string KmsServer { get; set; }

            /// <summary>
            /// <para>KMS 伺服器設定，格式為位址:連接埠。</para>
            /// 
            /// <b>Example:</b>
            /// <para>kms.example.com:1688</para>
            /// </summary>
            [NameInMap("KmsServerConfig")]
            [Validation(Required=false)]
            public string KmsServerConfig { get; set; }

            /// <summary>
            /// <para>本機磁碟映射權限。</para>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            /// <summary>
            /// <para>雲端電腦由於客觀原因造成中斷連線的最大連線重試時間。取值範圍：30\~7200，單位：秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxReconnectTime")]
            [Validation(Required=false)]
            public int? MaxReconnectTime { get; set; }

            /// <summary>
            /// <para>開啟 MCP 服務。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("McpService")]
            [Validation(Required=false)]
            public string McpService { get; set; }

            /// <summary>
            /// <para>單個處理程序記憶體降頻時長，取值範圍： 30\~120。單位：秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemoryDownGradeDuration")]
            [Validation(Required=false)]
            public int? MemoryDownGradeDuration { get; set; }

            /// <summary>
            /// <para>記憶體負載保護開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MemoryOverload")]
            [Validation(Required=false)]
            public string MemoryOverload { get; set; }

            /// <summary>
            /// <para>處理程序名稱。</para>
            /// </summary>
            [NameInMap("MemoryProcessors")]
            [Validation(Required=false)]
            public List<string> MemoryProcessors { get; set; }

            /// <summary>
            /// <para>記憶體保護模式開關。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MemoryProtectedMode")]
            [Validation(Required=false)]
            public string MemoryProtectedMode { get; set; }

            /// <summary>
            /// <para>記憶體整體使用率百分比，取值範圍： 70\~90。</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("MemoryRateLimit")]
            [Validation(Required=false)]
            public int? MemoryRateLimit { get; set; }

            /// <summary>
            /// <para>記憶體整體取樣時長，取值範圍： 30\~60。單位：秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemorySampleDuration")]
            [Validation(Required=false)]
            public int? MemorySampleDuration { get; set; }

            /// <summary>
            /// <para>單個處理程序記憶體使用率百分比，取值範圍： 30\~60。</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MemorySingleRateLimit")]
            [Validation(Required=false)]
            public int? MemorySingleRateLimit { get; set; }

            /// <summary>
            /// <para>透過行動端（Android用戶端&lt;props=&quot;china&quot;&gt;和iOS用戶端）連線雲端電腦時，是否在雲端電腦懸浮球內提供重新啟動按鈕。</para>
            /// <remarks>
            /// <para>僅適用於V7.4或更高版本的行動端。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileRestart")]
            [Validation(Required=false)]
            public string MobileRestart { get; set; }

            /// <summary>
            /// <para>行動端Windows 安全性控制開關。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileSafeMenu")]
            [Validation(Required=false)]
            public string MobileSafeMenu { get; set; }

            /// <summary>
            /// <para>透過行動端（Android用戶端&lt;props=&quot;china&quot;&gt;和iOS用戶端）連線雲端電腦時，是否在雲端電腦懸浮球內提供關機按鈕。</para>
            /// <remarks>
            /// <para>僅適用於V7.4或更高版本的行動端。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileShutdown")]
            [Validation(Required=false)]
            public string MobileShutdown { get; set; }

            /// <summary>
            /// <para>行動端無影管家開關。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileWuyingKeeper")]
            [Validation(Required=false)]
            public string MobileWuyingKeeper { get; set; }

            /// <summary>
            /// <para>行動端小穎的開關。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MobileWyAssistant")]
            [Validation(Required=false)]
            public string MobileWyAssistant { get; set; }

            /// <summary>
            /// <para>模型庫功能開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ModelLibrary")]
            [Validation(Required=false)]
            public string ModelLibrary { get; set; }

            /// <summary>
            /// <para>多螢幕顯示功能開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MultiScreen")]
            [Validation(Required=false)]
            public string MultiScreen { get; set; }

            /// <summary>
            /// <para>策略名稱。</para>
            /// 
            /// <b>Example:</b>
            /// <para>testPolicyGroupName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>網路重新導向。</para>
            /// <remarks>
            /// <para>該功能處於定向邀測中，暫不對外開放。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("NetRedirect")]
            [Validation(Required=false)]
            public string NetRedirect { get; set; }

            /// <summary>
            /// <para>網路重新導向策略詳細資訊。</para>
            /// <remarks>
            /// <para>該功能處於定向邀測中，暫不對外開放。</para>
            /// </remarks>
            /// </summary>
            [NameInMap("NetRedirectRule")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsNetRedirectRule> NetRedirectRule { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsNetRedirectRule : TeaModel {
                /// <summary>
                /// <para>網域。</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>重新導向策略。</para>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>規則類型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>domain</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

            }

            /// <summary>
            /// <para>網路印表機功能開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("NetworkPrinter")]
            [Validation(Required=false)]
            public string NetworkPrinter { get; set; }

            /// <summary>
            /// <para>無操作中斷連線。</para>
            /// <remarks>
            /// <para>僅適用於雲端應用策略。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("NoOperationDisconnect")]
            [Validation(Required=false)]
            public string NoOperationDisconnect { get; set; }

            /// <summary>
            /// <para>無操作中斷連線時長。單位：秒。</para>
            /// <remarks>
            /// <para>僅適用於雲端應用策略。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("NoOperationDisconnectTime")]
            [Validation(Required=false)]
            public int? NoOperationDisconnectTime { get; set; }

            /// <summary>
            /// <para>關聯的組織數量。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OrganizationCount")]
            [Validation(Required=false)]
            public string OrganizationCount { get; set; }

            /// <summary>
            /// <para>策略ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-gx2x1dhsmthe9****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>策略類型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("PolicyGroupType")]
            [Validation(Required=false)]
            public string PolicyGroupType { get; set; }

            /// <summary>
            /// <para>雲端電腦策略狀態。</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// <para>連接埠代理功能開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("PortProxy")]
            [Validation(Required=false)]
            public string PortProxy { get; set; }

            /// <summary>
            /// <para>印表機彈出視窗提示。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>default：預設值。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// <item><description>custom：自訂。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("PrinterAlert")]
            [Validation(Required=false)]
            public string PrinterAlert { get; set; }

            /// <summary>
            /// <para>印表機彈出視窗提示內容。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Print Content.</para>
            /// </summary>
            [NameInMap("PrinterAlertContent")]
            [Validation(Required=false)]
            public string PrinterAlertContent { get; set; }

            /// <summary>
            /// <para>印表機彈出視窗提示標題。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Print Title</para>
            /// </summary>
            [NameInMap("PrinterAlertTitle")]
            [Validation(Required=false)]
            public string PrinterAlertTitle { get; set; }

            /// <summary>
            /// <para>印表機重新導向策略。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("PrinterRedirection")]
            [Validation(Required=false)]
            public string PrinterRedirection { get; set; }

            /// <summary>
            /// <para>設計及3D應用場景選擇是否開啟畫質增強。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("QualityEnhancement")]
            [Validation(Required=false)]
            public string QualityEnhancement { get; set; }

            /// <summary>
            /// <para>是否開啟自訂螢幕錄影。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordContent")]
            [Validation(Required=false)]
            public string RecordContent { get; set; }

            /// <summary>
            /// <para>自訂螢幕錄影的檔案過期時間，預設30天。</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RecordContentExpires")]
            [Validation(Required=false)]
            public long? RecordContentExpires { get; set; }

            /// <summary>
            /// <para>螢幕錄影稽核中偵測到事件發生後螢幕錄影的時長。單位：分鐘。取值範圍：10\~60。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordEventDuration")]
            [Validation(Required=false)]
            public int? RecordEventDuration { get; set; }

            /// <summary>
            /// <para>螢幕錄影稽核中的檔案監控絕對路徑。</para>
            /// </summary>
            [NameInMap("RecordEventFilePaths")]
            [Validation(Required=false)]
            public List<string> RecordEventFilePaths { get; set; }

            /// <summary>
            /// <para>螢幕錄影稽核中的登錄檔監控絕對路徑。</para>
            /// </summary>
            [NameInMap("RecordEventRegisters")]
            [Validation(Required=false)]
            public List<string> RecordEventRegisters { get; set; }

            /// <summary>
            /// <para>是否開啟螢幕錄影。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Recording")]
            [Validation(Required=false)]
            public string Recording { get; set; }

            /// <summary>
            /// <para>錄製雲端電腦聲音選項。</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RecordingAudio")]
            [Validation(Required=false)]
            public string RecordingAudio { get; set; }

            /// <summary>
            /// <para>螢幕錄影檔案閱覽時長，單位為分鐘。錄製檔案會根據您設定的時長自動分割並上傳至儲存空間，檔案達到300MB時優先滾動更新。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// <para>螢幕錄影結束時間，取值：HH:MM:SS。只有Recording取值是period時，該傳回值有實際意義。</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:59:00</para>
            /// </summary>
            [NameInMap("RecordingEndTime")]
            [Validation(Required=false)]
            public string RecordingEndTime { get; set; }

            /// <summary>
            /// <para>螢幕錄影檔案的保留時間。取值範圍為1\~180天。</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("RecordingExpires")]
            [Validation(Required=false)]
            public long? RecordingExpires { get; set; }

            /// <summary>
            /// <para>螢幕錄影幀率。單位：FPS（幀/秒）。</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecordingFps")]
            [Validation(Required=false)]
            public long? RecordingFps { get; set; }

            /// <summary>
            /// <para>螢幕錄影開始時間，取值：HH:MM:SS。只有Recording取值是period時，該傳回值有實際意義。</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00:00</para>
            /// </summary>
            [NameInMap("RecordingStartTime")]
            [Validation(Required=false)]
            public string RecordingStartTime { get; set; }

            /// <summary>
            /// <para>提示終端客戶已開啟螢幕錄影。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RecordingUserNotify")]
            [Validation(Required=false)]
            public string RecordingUserNotify { get; set; }

            /// <summary>
            /// <para>提示終端客戶開啟螢幕錄影的資訊。</para>
            /// 
            /// <b>Example:</b>
            /// <para>螢幕錄影已開啟</para>
            /// </summary>
            [NameInMap("RecordingUserNotifyMessage")]
            [Validation(Required=false)]
            public string RecordingUserNotifyMessage { get; set; }

            /// <summary>
            /// <para>遠端協助鍵盤與滑鼠控制權限。</para>
            /// 
            /// <b>Example:</b>
            /// <para>fullControl</para>
            /// </summary>
            [NameInMap("RemoteCoordinate")]
            [Validation(Required=false)]
            public string RemoteCoordinate { get; set; }

            /// <summary>
            /// <para>重置雲端電腦。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ResetDesktop")]
            [Validation(Required=false)]
            public string ResetDesktop { get; set; }

            /// <summary>
            /// <para>螢幕解析度的 DPI 值。</para>
            /// 
            /// <b>Example:</b>
            /// <para>96</para>
            /// </summary>
            [NameInMap("ResolutionDpi")]
            [Validation(Required=false)]
            public int? ResolutionDpi { get; set; }

            /// <summary>
            /// <para>解析度的高度。單位：畫素。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("ResolutionHeight")]
            [Validation(Required=false)]
            public int? ResolutionHeight { get; set; }

            /// <summary>
            /// <para>解析度類型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>adaptive</para>
            /// </summary>
            [NameInMap("ResolutionModel")]
            [Validation(Required=false)]
            public string ResolutionModel { get; set; }

            /// <summary>
            /// <para>解析度的寬度。單位：畫素。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

            /// <summary>
            /// <para>已關聯該策略的資源群組數量。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceGroupCount")]
            [Validation(Required=false)]
            public int? ResourceGroupCount { get; set; }

            /// <summary>
            /// <para>安全中心快速鍵開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("SafeMenu")]
            [Validation(Required=false)]
            public string SafeMenu { get; set; }

            /// <summary>
            /// <para>策略的生效範圍。</para>
            /// 
            /// <b>Example:</b>
            /// <para>GLOBAL</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>生效的 CIDR Block。</para>
            /// </summary>
            [NameInMap("ScopeValue")]
            [Validation(Required=false)]
            public List<string> ScopeValue { get; set; }

            /// <summary>
            /// <para>螢幕顯示模式。</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("ScreenDisplayMode")]
            [Validation(Required=false)]
            public string ScreenDisplayMode { get; set; }

            /// <summary>
            /// <para>日常辦公場景選擇，是否開啟平滑度增強。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("SmoothEnhancement")]
            [Validation(Required=false)]
            public string SmoothEnhancement { get; set; }

            /// <summary>
            /// <para>是否在雲端電腦懸浮球內提供狀態監控功能入口。</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("StatusMonitor")]
            [Validation(Required=false)]
            public string StatusMonitor { get; set; }

            /// <summary>
            /// <para>串流模式適配場景。</para>
            /// 
            /// <b>Example:</b>
            /// <para>smooth</para>
            /// </summary>
            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            /// <summary>
            /// <para>目標幀率，取值範圍：10\~60。</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TargetFps")]
            [Validation(Required=false)]
            public int? TargetFps { get; set; }

            /// <summary>
            /// <para>應用程式工作列。</para>
            /// <remarks>
            /// <para>僅適用於雲端應用程式策略。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Taskbar")]
            [Validation(Required=false)]
            public string Taskbar { get; set; }

            /// <summary>
            /// <para>三螢幕開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ThreeScreen")]
            [Validation(Required=false)]
            public string ThreeScreen { get; set; }

            /// <summary>
            /// <para>USB 重新導向。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("UsbRedirect")]
            [Validation(Required=false)]
            public string UsbRedirect { get; set; }

            /// <summary>
            /// <para>USB 重新導向規則。</para>
            /// </summary>
            [NameInMap("UsbSupplyRedirectRule")]
            [Validation(Required=false)]
            public List<DescribeCenterPolicyListResponseBodyDescribePolicyGroupsUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
            public class DescribeCenterPolicyListResponseBodyDescribePolicyGroupsUsbSupplyRedirectRule : TeaModel {
                /// <summary>
                /// <para>規則描述。</para>
                /// 
                /// <b>Example:</b>
                /// <para>測試規則</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>產品 ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>08**</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <para>USB 重新導向類型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UsbRedirectType")]
                [Validation(Required=false)]
                public long? UsbRedirectType { get; set; }

                /// <summary>
                /// <para>USB 重新導向規則類型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UsbRuleType")]
                [Validation(Required=false)]
                public long? UsbRuleType { get; set; }

                /// <summary>
                /// <para>生產廠商 ID。參見 <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB Vendor IDs (VIDs)</a>。</para>
                /// 
                /// <b>Example:</b>
                /// <para>04**</para>
                /// </summary>
                [NameInMap("VendorId")]
                [Validation(Required=false)]
                public string VendorId { get; set; }

            }

            /// <summary>
            /// <para>懸浮球使用時長顯示開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("UseTime")]
            [Validation(Required=false)]
            public string UseTime { get; set; }

            /// <summary>
            /// <para>影片編碼平均位元率。單位：Kbps。取值範圍：1000\~50000。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("VideoEncAvgKbps")]
            [Validation(Required=false)]
            public int? VideoEncAvgKbps { get; set; }

            /// <summary>
            /// <para>影片編碼最大 QP，畫面最低品質，取值範圍：0\~51。</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("VideoEncMaxQP")]
            [Validation(Required=false)]
            public int? VideoEncMaxQP { get; set; }

            /// <summary>
            /// <para>影片編碼最小 QP，最高品質。取值範圍：0\~51。</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("VideoEncMinQP")]
            [Validation(Required=false)]
            public int? VideoEncMinQP { get; set; }

            /// <summary>
            /// <para>影片編碼峰值位元率。單位：Kbps。取值範圍：1000~50000。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("VideoEncPeakKbps")]
            [Validation(Required=false)]
            public int? VideoEncPeakKbps { get; set; }

            /// <summary>
            /// <para>影片編碼策略。</para>
            /// 
            /// <b>Example:</b>
            /// <para>qualityFirst</para>
            /// </summary>
            [NameInMap("VideoEncPolicy")]
            [Validation(Required=false)]
            public string VideoEncPolicy { get; set; }

            /// <summary>
            /// <para>多媒體重新導向。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("VideoRedirect")]
            [Validation(Required=false)]
            public string VideoRedirect { get; set; }

            /// <summary>
            /// <para>影像顯示品質策略。</para>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("VisualQuality")]
            [Validation(Required=false)]
            public string VisualQuality { get; set; }

            /// <summary>
            /// <para>浮水印。</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public string Watermark { get; set; }

            /// <summary>
            /// <para>隱藏式浮水印防拍照功能。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("WatermarkAntiCam")]
            [Validation(Required=false)]
            public string WatermarkAntiCam { get; set; }

            /// <summary>
            /// <para>浮水印字型顏色。取值範圍：0\~16777215。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WatermarkColor")]
            [Validation(Required=false)]
            public int? WatermarkColor { get; set; }

            /// <summary>
            /// <para>若參數 <c>WatermarkType</c> 傳入 <c>custom</c>，則必須同時透過參數 <c>WatermarkCustomText</c> 傳入自訂文字的內容。</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom-watermark</para>
            /// </summary>
            [NameInMap("WatermarkCustomText")]
            [Validation(Required=false)]
            public string WatermarkCustomText { get; set; }

            /// <summary>
            /// <para>浮水印傾斜度。取值範圍：-10\~-30。</para>
            /// 
            /// <b>Example:</b>
            /// <para>-10</para>
            /// </summary>
            [NameInMap("WatermarkDegree")]
            [Validation(Required=false)]
            public double? WatermarkDegree { get; set; }

            /// <summary>
            /// <para>浮水印字型大小。取值範圍：10\~20。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WatermarkFontSize")]
            [Validation(Required=false)]
            public int? WatermarkFontSize { get; set; }

            /// <summary>
            /// <para>浮水印字型樣式。</para>
            /// 
            /// <b>Example:</b>
            /// <para>plain</para>
            /// </summary>
            [NameInMap("WatermarkFontStyle")]
            [Validation(Required=false)]
            public string WatermarkFontStyle { get; set; }

            /// <summary>
            /// <para>隱藏式浮水印增強功能。</para>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("WatermarkPower")]
            [Validation(Required=false)]
            public string WatermarkPower { get; set; }

            /// <summary>
            /// <para>浮水印行數。</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("WatermarkRowAmount")]
            [Validation(Required=false)]
            public int? WatermarkRowAmount { get; set; }

            /// <summary>
            /// <para>隱藏式浮水印安全優先規則。</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("WatermarkSecurity")]
            [Validation(Required=false)]
            public string WatermarkSecurity { get; set; }

            /// <summary>
            /// <para>浮水印陰影效果開關。取值範圍：</para>
            /// <list type="bullet">
            /// <item><description>on：開啟。</description></item>
            /// <item><description>off：關閉。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("WatermarkShadow")]
            [Validation(Required=false)]
            public string WatermarkShadow { get; set; }

            /// <summary>
            /// <para>浮水印透明度，值越大，透明度越小。取值範圍：10\~100。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WatermarkTransparencyValue")]
            [Validation(Required=false)]
            public int? WatermarkTransparencyValue { get; set; }

            /// <summary>
            /// <para>浮水印類型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>EndUserId</para>
            /// </summary>
            [NameInMap("WatermarkType")]
            [Validation(Required=false)]
            public string WatermarkType { get; set; }

            /// <summary>
            /// <para>無影管家開關。</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("WuyingKeeper")]
            [Validation(Required=false)]
            public string WuyingKeeper { get; set; }

            /// <summary>
            /// <para>是否在雲端電腦懸浮球內提供無影 AI 助手功能入口。</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("WyAssistant")]
            [Validation(Required=false)]
            public string WyAssistant { get; set; }

        }

        /// <summary>
        /// <para>請求 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>查詢結果總數。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
