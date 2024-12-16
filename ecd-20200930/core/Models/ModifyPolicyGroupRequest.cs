// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyPolicyGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the end user has administrator permissions after the end user connects to the cloud desktop.</para>
        /// <remarks>
        /// <para> This parameter is in invitational preview and not available to the public.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("AdminAccess")]
        [Validation(Required=false)]
        public string AdminAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the anti-screenshot feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// <para>Default value: off.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AppContentProtection")]
        [Validation(Required=false)]
        public string AppContentProtection { get; set; }

        /// <summary>
        /// <para>The client CIDR blocks in the whitelist.</para>
        /// </summary>
        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestAuthorizeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>The CIDR block that the client can access.</para>
            /// <para>This parameter is required.</para>
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
        /// <para>The security group rules.</para>
        /// </summary>
        [NameInMap("AuthorizeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestAuthorizeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <para>The object to which the security group rule applies. The value is an IPv4 CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX/8</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>The description of security group rule N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The protocol type of security group rule N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>tcp: TCP</description></item>
            /// <item><description>udp: UDP</description></item>
            /// <item><description>icmp: ICMP (IPv4)</description></item>
            /// <item><description>gre: GRE</description></item>
            /// <item><description>all: all protocols</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The authorization policy of security group rule N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>accept: specifies the Allow policy that allows all access requests.</description></item>
            /// <item><description>drop: specifies the Deny policy that denies all access requests. If no messages of access denied are returned, the requests time out or failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The port range of security group rule N. The value of the port range is determined by the protocol type specified by the AuthorizeSecurityPolicyRule.N.IpProtocol parameter.</para>
            /// <list type="bullet">
            /// <item><description>When the AuthorizeSecurityPolicyRule.N.IpProtocol parameter is set to tcp or udp, the port range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>When AuthorizeSecurityPolicyRule.N.IpProtocol is set to icmp, set the value to -1/-1.</description></item>
            /// <item><description>When AuthorizeSecurityPolicyRule.N.IpProtocol is set to gre, set the value to -1/-1.</description></item>
            /// <item><description>When AuthorizeSecurityPolicyRule.N.IpProtocol is set to all, set the value to -1/-1.</description></item>
            /// </list>
            /// <para>For more information about the common ports of typical applications, see <a href="https://help.aliyun.com/document_detail/40724.html">Common ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of security group rule N. A smaller value indicates a higher priority.</para>
            /// <para>Valid values: 1 to 60.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The direction of security group rule N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>inflow: inbound</description></item>
            /// <item><description>outflow: outbound</description></item>
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
        /// <para>Specifies whether to enable the webcam redirection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// <para>Default value: on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// <para>The logon methods.</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestClientType> ClientType { get; set; }
        public class ModifyPolicyGroupRequestClientType : TeaModel {
            /// <summary>
            /// <para>The type of client that you want to use to connect to the cloud desktop. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows: the Windows client</description></item>
            /// <item><description>linux: C-Key Series Cloud Computer TC and A Series Cloud Computer TC</description></item>
            /// <item><description>macos: the macOS client</description></item>
            /// <item><description>ios: the iOS client</description></item>
            /// <item><description>android: the Android client</description></item>
            /// <item><description>html5: the web client</description></item>
            /// </list>
            /// <remarks>
            /// <para>By default, if you do not configure the ClientType-related parameters, all types of clients are allowed to connect to the cloud desktop.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>The logon method. This parameter specifies whether a specific type of the client is allowed to connect to the cloud desktop. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: allowed.</description></item>
            /// <item><description>off: disallowed.</description></item>
            /// </list>
            /// <remarks>
            /// <para>By default, if you do not configure the ClientType-related parameters, all types of clients are allowed to log on to cloud desktops.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The permissions on clipboards. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>read: specifies one-way transfer. You can copy data from your computer to cloud desktops, but cannot copy data from cloud desktops to your computer.</description></item>
        /// <item><description>readwrite: specifies two-way transfer. You can copy data between your computer and cloud desktops.</description></item>
        /// <item><description>off: specifies that the two-way transfer is disabled. You cannot copy data between your computer and cloud desktops.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        [NameInMap("DeviceRedirects")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestDeviceRedirects> DeviceRedirects { get; set; }
        public class ModifyPolicyGroupRequestDeviceRedirects : TeaModel {
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("RedirectType")]
            [Validation(Required=false)]
            public string RedirectType { get; set; }

        }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("DeviceRules")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestDeviceRules> DeviceRules { get; set; }
        public class ModifyPolicyGroupRequestDeviceRules : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("DevicePid")]
            [Validation(Required=false)]
            public string DevicePid { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("DeviceVid")]
            [Validation(Required=false)]
            public string DeviceVid { get; set; }

            [NameInMap("OptCommand")]
            [Validation(Required=false)]
            public string OptCommand { get; set; }

            [NameInMap("RedirectType")]
            [Validation(Required=false)]
            public string RedirectType { get; set; }

        }

        /// <summary>
        /// <para>The domain blacklist or whitelist. Wildcard domains are supported. Separate domain names with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>[black:],example1.com,example2.com: the domain name blacklist.</description></item>
        /// <item><description>[white:],example1.com,example2.com: the domain name whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[black:],example1.com,example2.com</para>
        /// </summary>
        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public string DomainList { get; set; }

        /// <summary>
        /// <para>The details of the DNS rule.</para>
        /// </summary>
        [NameInMap("DomainResolveRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestDomainResolveRule> DomainResolveRule { get; set; }
        public class ModifyPolicyGroupRequestDomainResolveRule : TeaModel {
            /// <summary>
            /// <para>The description of the DNS rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description policy</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.igetget.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow the DNS rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>allow</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>block</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

        }

        /// <summary>
        /// <para>The DNS rule type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("DomainResolveRuleType")]
        [Validation(Required=false)]
        public string DomainResolveRuleType { get; set; }

        /// <summary>
        /// <para>The user applies for the administrator assistance switch. Value range: </para>
        /// <list type="bullet">
        /// <item><description>on </description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("EndUserApplyAdminCoordinate")]
        [Validation(Required=false)]
        public string EndUserApplyAdminCoordinate { get; set; }

        /// <summary>
        /// <para>The flow collaboration switch between users. Value range: </para>
        /// <list type="bullet">
        /// <item><description>on </description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("EndUserGroupCoordinate")]
        [Validation(Required=false)]
        public string EndUserGroupCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the image display quality feature for the Graphics cloud desktop. If your business requires high desktop performance and optimal user experience, we recommend that you enable this feature. For example, you can enable this policy in professional design scenarios. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public string GpuAcceleration { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the access from HTM5 clients to a cloud desktop. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: allows the access.</description></item>
        /// <item><description>off: denies the access.</description></item>
        /// </list>
        /// <para>Default value: off.</para>
        /// <remarks>
        /// <para> We recommend that you use the ClientType-related parameters to control the EDS client type for cloud desktop logon.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Html5Access")]
        [Validation(Required=false)]
        public string Html5Access { get; set; }

        /// <summary>
        /// <para>The file transfer policy for HTML5 clients. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: Files cannot be uploaded from or downloaded to HTML5 clients.</description></item>
        /// <item><description>upload: Files can be uploaded from HTML5 clients.</description></item>
        /// <item><description>download: Files can be downloaded to HTML5 clients.</description></item>
        /// <item><description>all: Files can be uploaded from and downloaded to HTML5 clients.</description></item>
        /// </list>
        /// <para>Default value: off.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Html5FileTransfer")]
        [Validation(Required=false)]
        public string Html5FileTransfer { get; set; }

        /// <summary>
        /// <para>The protocol that you want to use for network communication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TCP: Only the TCP protocol is used.</description></item>
        /// <item><description>BOTH: allows automatic switchover between the TCP protocol and the UDP protocol.</description></item>
        /// </list>
        /// <para>Default value: TCP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BOTH</para>
        /// </summary>
        [NameInMap("InternetCommunicationProtocol")]
        [Validation(Required=false)]
        public string InternetCommunicationProtocol { get; set; }

        /// <summary>
        /// <para>The permissions on local disk mapping. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>read: read-only permissions. Local disks are mapped to cloud desktops. You can only read (copy) local files but cannot modify them.</description></item>
        /// <item><description>readwrite: read and write permissions. Local disks are mapped to cloud desktops. You can read (copy) and modify local files.</description></item>
        /// <item><description>off: no permissions. Local disks are not mapped to cloud desktops.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        [NameInMap("MaxReconnectTime")]
        [Validation(Required=false)]
        public int? MaxReconnectTime { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPolicyGroupName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network redirection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// <para>Default value: off.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("NetRedirect")]
        [Validation(Required=false)]
        public string NetRedirect { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-gx2x1dhsmthe9****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow user preemption. Default value: off. You cannot change the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PreemptLogin")]
        [Validation(Required=false)]
        public string PreemptLogin { get; set; }

        /// <summary>
        /// <para>The names of the users that are allowed to connect to the same cloud desktop at the same time. You can specify up to five usernames.</para>
        /// <remarks>
        /// <para>To improve user experience and ensure data security, multiple end users cannot connect to the same cloud desktop at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("PreemptLoginUser")]
        [Validation(Required=false)]
        public List<string> PreemptLoginUser { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable printer redirection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off: disables printer redirection.</description></item>
        /// <item><description>on: enables printer redirection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("PrinterRedirection")]
        [Validation(Required=false)]
        public string PrinterRedirection { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the custom screen recording feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// <para>Default value: off.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("RecordContent")]
        [Validation(Required=false)]
        public string RecordContent { get; set; }

        /// <summary>
        /// <para>The duration in which the custom screen recording is valid. Default value: 30. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RecordContentExpires")]
        [Validation(Required=false)]
        public long? RecordContentExpires { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable screen recording. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OFF: disabled.</description></item>
        /// <item><description>ALLTIME: All operations that are performed by an end user on the cloud desktop are recorded. The recording immediately starts when the end user connects to the cloud desktop and ends after the end user disconnects from the cloud desktop.</description></item>
        /// <item><description>PERIOD: The operations that are performed by an end user on the cloud desktop during a specific period of time are recorded. You must specify the start time and the end time of the recording.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("Recording")]
        [Validation(Required=false)]
        public string Recording { get; set; }

        /// <summary>
        /// <para>Specifies whether to record the sound that is generated on the cloud desktop during screen recording. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RecordingAudio")]
        [Validation(Required=false)]
        public string RecordingAudio { get; set; }

        /// <summary>
        /// <para>This parameter takes effect based on the Recording-related parameters. You can specify a time range for screen recording, and recording files are generated after the specified end time is reached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("RecordingDuration")]
        [Validation(Required=false)]
        public int? RecordingDuration { get; set; }

        /// <summary>
        /// <para>The time when the screen recording ends. Specify the value in the HH:MM:SS format. The value is valid only when you set the Recording parameter to PERIOD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:59:00</para>
        /// </summary>
        [NameInMap("RecordingEndTime")]
        [Validation(Required=false)]
        public string RecordingEndTime { get; set; }

        /// <summary>
        /// <para>The period in which the screen recording audit is valid. Valid values: 15 to 180. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RecordingExpires")]
        [Validation(Required=false)]
        public long? RecordingExpires { get; set; }

        /// <summary>
        /// <para>The frame rate of screen recording. Unit: fps. Valid values:</para>
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
        /// <para>The time when the screen recording starts. Specify the value in the HH:MM:SS format. The value is valid only when you set the Recording parameter to PERIOD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00:00</para>
        /// </summary>
        [NameInMap("RecordingStartTime")]
        [Validation(Required=false)]
        public string RecordingStartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the screen recording notification feature. Valid values: on and off. on and off (default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("RecordingUserNotify")]
        [Validation(Required=false)]
        public string RecordingUserNotify { get; set; }

        /// <summary>
        /// <para>The content of the screen recording notification sent to the client. By default, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Your desktop is being recorded.</para>
        /// </summary>
        [NameInMap("RecordingUserNotifyMessage")]
        [Validation(Required=false)]
        public string RecordingUserNotifyMessage { get; set; }

        /// <summary>
        /// <para>The ID of the region where the cloud desktop resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The permissions on the keyboard and mouse to control the cloud desktop during remote assistance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>fullControl: The keyboard and mouse can be fully controlled.</description></item>
        /// <item><description>optionalControl: By default, this feature is disabled. You can apply for permissions to enable the feature.</description></item>
        /// <item><description>disableControl: The keyboard and mouse cannot be controlled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fullControl</para>
        /// </summary>
        [NameInMap("RemoteCoordinate")]
        [Validation(Required=false)]
        public string RemoteCoordinate { get; set; }

        /// <summary>
        /// <para>The security group rules that you want to delete.</para>
        /// </summary>
        [NameInMap("RevokeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestRevokeAccessPolicyRule> RevokeAccessPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestRevokeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR block that can be accessed from the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

            /// <summary>
            /// <para>The description of the client IP address whitelist that you want to delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The security group rules that you want to delete.</para>
        /// </summary>
        [NameInMap("RevokeSecurityPolicyRule")]
        [Validation(Required=false)]
        public List<ModifyPolicyGroupRequestRevokeSecurityPolicyRule> RevokeSecurityPolicyRule { get; set; }
        public class ModifyPolicyGroupRequestRevokeSecurityPolicyRule : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR block of the security group rule.</para>
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
            /// <para>The protocol type of the security group rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP</description></item>
            /// <item><description>UDP</description></item>
            /// <item><description>ICMP: ICMP (IPv4)</description></item>
            /// <item><description>GRE</description></item>
            /// <item><description>ALL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The authorization policy of the security group rule that you want to delete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>accept: allows all access requests.</description></item>
            /// <item><description>drop: disallows all access requests. If no denied messages are returned, the requests timed out or failed.</description></item>
            /// </list>
            /// <para>Default value: accept.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The port range of the security group rule that you want to delete. The value of the port range is determined by the protocol type specified by the IpProtocol parameter.</para>
            /// <list type="bullet">
            /// <item><description>If the IpProtocol parameter is set to TCP or UDP, the port range is 1 to 65535. The start port number and the end port number are separated by a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>If the IpProtocol parameter is set to ICMP, the port range is -1/-1.</description></item>
            /// <item><description>If the IpProtocol parameter is set to GRE, the port range is -1/-1.</description></item>
            /// <item><description>If the IpProtocol parameter is set to ALL, the port range is -1/-1.</description></item>
            /// </list>
            /// <para>For more information about the common ports of typical applications, see <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/common-ports?spm=a2c63.p38356.0.0.56b87f2c2SJTAw">Common ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The priority of the security group rule. A smaller value indicates a higher priority.</para>
            /// <para>Valid values: 1 to 60.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The direction of the security group rule that you want to delete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>inflow: inbound</description></item>
            /// <item><description>outflow: outbound</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>outflow</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The effective scope of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GLOBAL: takes effect globally.</description></item>
        /// <item><description>IP: takes effect based on the IP address.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>This parameter is required when the Scope parameter is set to IP.</para>
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public List<string> ScopeValue { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable USB redirection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enables USB redirection.</description></item>
        /// <item><description>off: disables USB redirection.</description></item>
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
        public List<ModifyPolicyGroupRequestUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
        public class ModifyPolicyGroupRequestUsbSupplyRedirectRule : TeaModel {
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
            /// <para>The class of the device. This parameter is required when you set the usbRuleType parameter to 1. For more information, see <a href="https://www.usb.org/defined-class-codes?spm=a2c63.p38356.0.0.56b84b03GUn4kJ">Defined Class Codes</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0Eh</para>
            /// </summary>
            [NameInMap("DeviceClass")]
            [Validation(Required=false)]
            public string DeviceClass { get; set; }

            /// <summary>
            /// <para>The subclass of the device. This parameter is required when you set the usbRuleType parameter to 1. For more information, see <a href="https://www.usb.org/defined-class-codes?spm=a2c63.p38356.0.0.56b84b03GUn4kJ">Defined Class Codes</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxh</para>
            /// </summary>
            [NameInMap("DeviceSubclass")]
            [Validation(Required=false)]
            public string DeviceSubclass { get; set; }

            /// <summary>
            /// <para>The ID of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08**</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow USB redirection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: allowed.</description></item>
            /// <item><description>2: disallowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsbRedirectType")]
            [Validation(Required=false)]
            public long? UsbRedirectType { get; set; }

            /// <summary>
            /// <para>The type of the USB redirection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: device class.</description></item>
            /// <item><description>2: device vendor.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsbRuleType")]
            [Validation(Required=false)]
            public long? UsbRuleType { get; set; }

            /// <summary>
            /// <para>The ID of the vendor. For more information, see<a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf?spm=a2c63.p38356.0.0.56b84b03GUn4kJ&file=vendor_ids032322.pdf_1.pdf"> Valid USB Vendor IDs (VIDs)</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04**</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// <para>The multimedia redirection feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("VideoRedirect")]
        [Validation(Required=false)]
        public string VideoRedirect { get; set; }

        /// <summary>
        /// <para>Specify whether to enable the policy of image display quality. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enables the policy of image display quality.</description></item>
        /// <item><description>off: disables the policy of image display quality.</description></item>
        /// </list>
        /// <para>Default value: off.</para>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("VisualQuality")]
        [Validation(Required=false)]
        public string VisualQuality { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable watermarking. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enables watermarking.</description></item>
        /// <item><description>off: disables watermarking.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the anti-screen photo feature for invisible watermarks. on and off (default).</para>
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
        /// <para>The inclination angle of the watermark. Value values: -10 to -30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-10</para>
        /// </summary>
        [NameInMap("WatermarkDegree")]
        [Validation(Required=false)]
        public double? WatermarkDegree { get; set; }

        /// <summary>
        /// <para>The font size of the watermark. Valid values: 10 to 50</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WatermarkFontSize")]
        [Validation(Required=false)]
        public int? WatermarkFontSize { get; set; }

        /// <summary>
        /// <para>The font style of the watermark. Valid values:</para>
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
        /// <para>The watermark enhancement feature. Valid values: low, medium, and high.</para>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("WatermarkPower")]
        [Validation(Required=false)]
        public string WatermarkPower { get; set; }

        /// <summary>
        /// <para>The number of watermark rows. This parameter is not in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("WatermarkRowAmount")]
        [Validation(Required=false)]
        public int? WatermarkRowAmount { get; set; }

        /// <summary>
        /// <para>The security priority rule for invisible watermarks. Valid values: on and off.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("WatermarkSecurity")]
        [Validation(Required=false)]
        public string WatermarkSecurity { get; set; }

        /// <summary>
        /// <para>The transparency of the watermark. The valid values include:</para>
        /// <list type="bullet">
        /// <item><description>LIGHT</description></item>
        /// <item><description>MIDDLE</description></item>
        /// <item><description>DARK</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LIGHT</para>
        /// </summary>
        [NameInMap("WatermarkTransparency")]
        [Validation(Required=false)]
        public string WatermarkTransparency { get; set; }

        /// <summary>
        /// <para>The transparency of the watermark. A larger value indicates a less transparent watermark. Valid values: 10 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WatermarkTransparencyValue")]
        [Validation(Required=false)]
        public int? WatermarkTransparencyValue { get; set; }

        /// <summary>
        /// <para>The type of the watermark. You can specify multiple watermark types at a time. Separate watermark types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EndUserId: the username</description></item>
        /// <item><description>HostName: the last 15 characters of the cloud desktop ID</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EndUserId</para>
        /// </summary>
        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

        [NameInMap("WyAssistant")]
        [Validation(Required=false)]
        public string WyAssistant { get; set; }

    }

}
