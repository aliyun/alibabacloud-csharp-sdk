// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCenterPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("AdminAccess")]
        [Validation(Required=false)]
        public string AdminAccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AppContentProtection")]
        [Validation(Required=false)]
        public string AppContentProtection { get; set; }

        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class CreateCenterPolicyRequestAuthorizeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        [NameInMap("AuthorizeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class CreateCenterPolicyRequestAuthorizeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10.0.XX.XX/8</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>inflow</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public int? BusinessType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestClientType> ClientType { get; set; }
        public class CreateCenterPolicyRequestClientType : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ColorEnhancement")]
        [Validation(Required=false)]
        public string ColorEnhancement { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CpuDownGradeDuration")]
        [Validation(Required=false)]
        public int? CpuDownGradeDuration { get; set; }

        [NameInMap("CpuProcessors")]
        [Validation(Required=false)]
        public List<string> CpuProcessors { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CpuProtectedMode")]
        [Validation(Required=false)]
        public string CpuProtectedMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("CpuRateLimit")]
        [Validation(Required=false)]
        public int? CpuRateLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("CpuSampleDuration")]
        [Validation(Required=false)]
        public int? CpuSampleDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("CpuSingleRateLimit")]
        [Validation(Required=false)]
        public int? CpuSingleRateLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DeviceConnectHint")]
        [Validation(Required=false)]
        public string DeviceConnectHint { get; set; }

        [NameInMap("DeviceRedirects")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestDeviceRedirects> DeviceRedirects { get; set; }
        public class CreateCenterPolicyRequestDeviceRedirects : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>camera</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>usbRedirect</para>
            /// </summary>
            [NameInMap("RedirectType")]
            [Validation(Required=false)]
            public string RedirectType { get; set; }

        }

        [NameInMap("DeviceRules")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestDeviceRules> DeviceRules { get; set; }
        public class CreateCenterPolicyRequestDeviceRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sandisk</para>
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0x55b1</para>
            /// </summary>
            [NameInMap("DevicePid")]
            [Validation(Required=false)]
            public string DevicePid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>storage</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0x0781</para>
            /// </summary>
            [NameInMap("DeviceVid")]
            [Validation(Required=false)]
            public string DeviceVid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2:0</para>
            /// </summary>
            [NameInMap("OptCommand")]
            [Validation(Required=false)]
            public string OptCommand { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>usbRedirect</para>
            /// </summary>
            [NameInMap("RedirectType")]
            [Validation(Required=false)]
            public string RedirectType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>customTime</para>
        /// </summary>
        [NameInMap("DisconnectKeepSession")]
        [Validation(Required=false)]
        public string DisconnectKeepSession { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("DisconnectKeepSessionTime")]
        [Validation(Required=false)]
        public int? DisconnectKeepSessionTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>clientCustom</para>
        /// </summary>
        [NameInMap("DisplayMode")]
        [Validation(Required=false)]
        public string DisplayMode { get; set; }

        [NameInMap("DomainResolveRule")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestDomainResolveRule> DomainResolveRule { get; set; }
        public class CreateCenterPolicyRequestDomainResolveRule : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>*.example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DomainResolveRuleType")]
        [Validation(Required=false)]
        public string DomainResolveRuleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EnableSessionRateLimiting")]
        [Validation(Required=false)]
        public string EnableSessionRateLimiting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EndUserApplyAdminCoordinate")]
        [Validation(Required=false)]
        public string EndUserApplyAdminCoordinate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EndUserGroupCoordinate")]
        [Validation(Required=false)]
        public string EndUserGroupCoordinate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("FileMigrate")]
        [Validation(Required=false)]
        public string FileMigrate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public string GpuAcceleration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Html5FileTransfer")]
        [Validation(Required=false)]
        public string Html5FileTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>both</para>
        /// </summary>
        [NameInMap("InternetCommunicationProtocol")]
        [Validation(Required=false)]
        public string InternetCommunicationProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MaxReconnectTime")]
        [Validation(Required=false)]
        public int? MaxReconnectTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemoryDownGradeDuration")]
        [Validation(Required=false)]
        public int? MemoryDownGradeDuration { get; set; }

        [NameInMap("MemoryProcessors")]
        [Validation(Required=false)]
        public List<string> MemoryProcessors { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MemoryProtectedMode")]
        [Validation(Required=false)]
        public string MemoryProtectedMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("MemoryRateLimit")]
        [Validation(Required=false)]
        public int? MemoryRateLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemorySampleDuration")]
        [Validation(Required=false)]
        public int? MemorySampleDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemorySingleRateLimit")]
        [Validation(Required=false)]
        public int? MemorySingleRateLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileRestart")]
        [Validation(Required=false)]
        public string MobileRestart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("MobileShutdown")]
        [Validation(Required=false)]
        public string MobileShutdown { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPolicyGroupName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("NetRedirect")]
        [Validation(Required=false)]
        public string NetRedirect { get; set; }

        [NameInMap("NetRedirectRule")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestNetRedirectRule> NetRedirectRule { get; set; }
        public class CreateCenterPolicyRequestNetRedirectRule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>*.taobao.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("NoOperationDisconnect")]
        [Validation(Required=false)]
        public string NoOperationDisconnect { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("NoOperationDisconnectTime")]
        [Validation(Required=false)]
        public int? NoOperationDisconnectTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PrinterRedirect")]
        [Validation(Required=false)]
        public string PrinterRedirect { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("QualityEnhancement")]
        [Validation(Required=false)]
        public string QualityEnhancement { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordEventDuration")]
        [Validation(Required=false)]
        public int? RecordEventDuration { get; set; }

        [NameInMap("RecordEventFilePaths")]
        [Validation(Required=false)]
        public List<string> RecordEventFilePaths { get; set; }

        [NameInMap("RecordEventRegisters")]
        [Validation(Required=false)]
        public List<string> RecordEventRegisters { get; set; }

        [NameInMap("RecordEvents")]
        [Validation(Required=false)]
        public List<string> RecordEvents { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Recording")]
        [Validation(Required=false)]
        public string Recording { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RecordingAudio")]
        [Validation(Required=false)]
        public string RecordingAudio { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordingDuration")]
        [Validation(Required=false)]
        public int? RecordingDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>08:59:00</para>
        /// </summary>
        [NameInMap("RecordingEndTime")]
        [Validation(Required=false)]
        public string RecordingEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("RecordingExpires")]
        [Validation(Required=false)]
        public int? RecordingExpires { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecordingFps")]
        [Validation(Required=false)]
        public string RecordingFps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>08:00:00</para>
        /// </summary>
        [NameInMap("RecordingStartTime")]
        [Validation(Required=false)]
        public string RecordingStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("RecordingUserNotify")]
        [Validation(Required=false)]
        public string RecordingUserNotify { get; set; }

        [NameInMap("RecordingUserNotifyMessage")]
        [Validation(Required=false)]
        public string RecordingUserNotifyMessage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fullControl</para>
        /// </summary>
        [NameInMap("RemoteCoordinate")]
        [Validation(Required=false)]
        public string RemoteCoordinate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ResetDesktop")]
        [Validation(Required=false)]
        public string ResetDesktop { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>adaptive</para>
        /// </summary>
        [NameInMap("ResolutionModel")]
        [Validation(Required=false)]
        public string ResolutionModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("ResolutionWidth")]
        [Validation(Required=false)]
        public int? ResolutionWidth { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GLOBAL</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public List<string> ScopeValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("SessionMaxRateKbps")]
        [Validation(Required=false)]
        public int? SessionMaxRateKbps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SmoothEnhancement")]
        [Validation(Required=false)]
        public string SmoothEnhancement { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("StatusMonitor")]
        [Validation(Required=false)]
        public string StatusMonitor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>smooth</para>
        /// </summary>
        [NameInMap("StreamingMode")]
        [Validation(Required=false)]
        public string StreamingMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TargetFps")]
        [Validation(Required=false)]
        public int? TargetFps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Taskbar")]
        [Validation(Required=false)]
        public string Taskbar { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("UsbRedirect")]
        [Validation(Required=false)]
        public string UsbRedirect { get; set; }

        [NameInMap("UsbSupplyRedirectRule")]
        [Validation(Required=false)]
        public List<CreateCenterPolicyRequestUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
        public class CreateCenterPolicyRequestUsbSupplyRedirectRule : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>08**</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsbRedirectType")]
            [Validation(Required=false)]
            public string UsbRedirectType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UsbRuleType")]
            [Validation(Required=false)]
            public string UsbRuleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>04**</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoEncAvgKbps")]
        [Validation(Required=false)]
        public int? VideoEncAvgKbps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("VideoEncMaxQP")]
        [Validation(Required=false)]
        public int? VideoEncMaxQP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("VideoEncMinQP")]
        [Validation(Required=false)]
        public int? VideoEncMinQP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("VideoEncPeakKbps")]
        [Validation(Required=false)]
        public int? VideoEncPeakKbps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qualityFirst</para>
        /// </summary>
        [NameInMap("VideoEncPolicy")]
        [Validation(Required=false)]
        public string VideoEncPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("VideoRedirect")]
        [Validation(Required=false)]
        public string VideoRedirect { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("VisualQuality")]
        [Validation(Required=false)]
        public string VisualQuality { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WatermarkAntiCam")]
        [Validation(Required=false)]
        public string WatermarkAntiCam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WatermarkColor")]
        [Validation(Required=false)]
        public int? WatermarkColor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("WatermarkColumnAmount")]
        [Validation(Required=false)]
        public int? WatermarkColumnAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("WatermarkCustomText")]
        [Validation(Required=false)]
        public string WatermarkCustomText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-10</para>
        /// </summary>
        [NameInMap("WatermarkDegree")]
        [Validation(Required=false)]
        public double? WatermarkDegree { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WatermarkFontSize")]
        [Validation(Required=false)]
        public int? WatermarkFontSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>plain</para>
        /// </summary>
        [NameInMap("WatermarkFontStyle")]
        [Validation(Required=false)]
        public string WatermarkFontStyle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("WatermarkPower")]
        [Validation(Required=false)]
        public string WatermarkPower { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("WatermarkRowAmount")]
        [Validation(Required=false)]
        public int? WatermarkRowAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("WatermarkSecurity")]
        [Validation(Required=false)]
        public string WatermarkSecurity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WatermarkTransparencyValue")]
        [Validation(Required=false)]
        public int? WatermarkTransparencyValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EndUserId,HostName,ClientTime</para>
        /// </summary>
        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WuyingKeeper")]
        [Validation(Required=false)]
        public string WuyingKeeper { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("WyAssistant")]
        [Validation(Required=false)]
        public string WyAssistant { get; set; }

    }

}
