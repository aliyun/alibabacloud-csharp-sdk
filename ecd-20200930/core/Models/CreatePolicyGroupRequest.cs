// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreatePolicyGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether users have the administrator permissions after they connect to cloud desktops.</para>
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
        /// <para>Specifies whether to enable the anti-screenshot feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>off: Anti-screenshot is disabled. This value is the default value.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>on: Anti-screenshot is enabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AppContentProtection")]
        [Validation(Required=false)]
        public string AppContentProtection { get; set; }

        /// <summary>
        /// <para>The client IP address whitelists. Only the client IP addresses in whitelists can access the cloud desktop.</para>
        /// </summary>
        [NameInMap("AuthorizeAccessPolicyRule")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestAuthorizeAccessPolicyRule> AuthorizeAccessPolicyRule { get; set; }
        public class CreatePolicyGroupRequestAuthorizeAccessPolicyRule : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR block that you want to access from the client. The value is an IPv4 CIDR block.</para>
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
            /// <para>North China Branch</para>
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
        public List<CreatePolicyGroupRequestAuthorizeSecurityPolicyRule> AuthorizeSecurityPolicyRule { get; set; }
        public class CreatePolicyGroupRequestAuthorizeSecurityPolicyRule : TeaModel {
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
            /// <para>The protocol type of the security group rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>TCP</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>UDP</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>ALL: all protocols</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>GRE</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>ICMP: ICMP (IPv4)</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The authorization policy of the security group rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>drop: denies all access requests</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <para>If no denied messages are returned, the requests timed out or failed.</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>accept: accepts all access requests</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <para>This value is the default value.</para>
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The port range of the security group rule. The value range of this parameter varies based on the value of the IpProtocol parameter.</para>
            /// <list type="bullet">
            /// <item><description>If you set the IpProtocol parameter to TCP or UDP, the value range is 1 to 65535. Separate the start port number and the end port number with a forward slash (/). Example: 1/200.</description></item>
            /// <item><description>If you set the IpProtocol parameter to ICMP, the start port number and the end port number are -1/-1.</description></item>
            /// <item><description>If you set the IpProtocol parameter to GRE, the start port number and the end port number are -1/-1.</description></item>
            /// <item><description>If you set the IpProtocol parameter to ALL, the start port number and the end port number are -1/-1.</description></item>
            /// </list>
            /// <para>For more information about the common ports of applications, see <a href="https://help.aliyun.com/document_detail/40724.html">Common ports</a>.</para>
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
            /// <item><description><para>outflow: outbound</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>inflow: inbound</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
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
        /// <para>Specifies whether to enable the webcam redirection feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>off: Webcam redirection is disabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>on: Webcam redirection is enabled. This value is the default value.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// <para>The logon methods. You can use this parameter to determine which clients can be used to connect to the cloud desktop.</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestClientType> ClientType { get; set; }
        public class CreatePolicyGroupRequestClientType : TeaModel {
            /// <summary>
            /// <para>The type of the client.</para>
            /// <remarks>
            /// <para>By default, if you do not specify the ClientType parameter, all types of clients can be used to connect to cloud desktops.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>html5: web clients</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>android: Android clients</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>linux: Alibaba Cloud Workspace clients</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>ios: iOS clients</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>windows: Windows clients</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>macos: macOS clients</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>Specifies whether a specific client type can be used to connect to the cloud desktop.</para>
            /// <remarks>
            /// <para>By default, if you do not specify the ClientType parameter, all types of clients can be used to connect to cloud desktops.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>OFF: Clients of the specified type cannot be used to connect to cloud desktops.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>ON: Clients of the specified type can be used to connect to cloud desktops.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
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
        /// <item><description><para>read: specifies one-way transfer</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>You can copy data from your local computer to the cloud desktop, but cannot copy data from the cloud desktop to your local computer.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>readwrite: specifies two-way transfer</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>You can copy data between your local computer and the cloud desktop.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>off: disables both one-way and two-way transfer</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>You cannot copy data between your local computer and the cloud desktop. This value is the default value.</para>
        /// <!-- --></description></item>
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
        public List<CreatePolicyGroupRequestDeviceRedirects> DeviceRedirects { get; set; }
        public class CreatePolicyGroupRequestDeviceRedirects : TeaModel {
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("RedirectType")]
            [Validation(Required=false)]
            public string RedirectType { get; set; }

        }

        [NameInMap("DeviceRules")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestDeviceRules> DeviceRules { get; set; }
        public class CreatePolicyGroupRequestDeviceRules : TeaModel {
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
        /// <para>Access control for domain names. The wildcard character (\*) is supported for domain names. Separate multiple domain names with commas (,). Valid values:</para>
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
        /// <para>The details of the domain name resolution policy.</para>
        /// </summary>
        [NameInMap("DomainResolveRule")]
        [Validation(Required=false)]
        public List<CreatePolicyGroupRequestDomainResolveRule> DomainResolveRule { get; set; }
        public class CreatePolicyGroupRequestDomainResolveRule : TeaModel {
            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system policy</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.baidu.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow the policy.</para>
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
            /// <para>allow</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

        }

        /// <summary>
        /// <para>The type of the domain name resolution policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OFF</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>ON</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("DomainResolveRuleType")]
        [Validation(Required=false)]
        public string DomainResolveRuleType { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow end users to seek assistance from the administrator. Valid values: ON OFF</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("EndUserApplyAdminCoordinate")]
        [Validation(Required=false)]
        public string EndUserApplyAdminCoordinate { get; set; }

        /// <summary>
        /// <para>The switch for collaboration between end users. Valid values: ON OFF</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("EndUserGroupCoordinate")]
        [Validation(Required=false)]
        public string EndUserGroupCoordinate { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the image display quality feature for the Graphics cloud desktop. If you have high requirements for desktop performance and user experience, we recommend that you enable this feature. For example, you can enable this feature in professional design scenarios.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>off</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>on</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("GpuAcceleration")]
        [Validation(Required=false)]
        public string GpuAcceleration { get; set; }

        /// <summary>
        /// <para>The policy for HTML5 client access.</para>
        /// <remarks>
        /// <para>We recommend that you use the ClientType parameter to manage the type of Alibaba Cloud Workspace clients for desktop connection.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>off: HTML5 client access is disabled. This value is the default value.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>on: HTML5 client access is enabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Html5Access")]
        [Validation(Required=false)]
        public string Html5Access { get; set; }

        /// <summary>
        /// <para>The file transfer policy for HTML5 clients.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>all: Files can be uploaded and downloaded between your computer and HTML5 clients.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>download: Files on HTML5 clients can be downloaded to your computer.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>upload: Files on your computer can be uploaded to HTML5 clients.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>off: File transfer between HTML5 clients and your computer is disabled. This value is the default value.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Html5FileTransfer")]
        [Validation(Required=false)]
        public string Html5FileTransfer { get; set; }

        /// <summary>
        /// <para>The protocol that you want to use for network communication. Valid values: -TCP: Only TCP is allowed. -BOTH: Automatic switch between TCP and UDP is allowed. Default value: TCP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>both</para>
        /// </summary>
        [NameInMap("InternetCommunicationProtocol")]
        [Validation(Required=false)]
        public string InternetCommunicationProtocol { get; set; }

        /// <summary>
        /// <para>The permissions on local disk mapping.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>read: read-only</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>The disks on your local computer are mapped to the cloud desktop. You can only read (copy) files on the local computer.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>readwrite: read and write</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>The disks on your local computer are mapped to the cloud desktop. You can read (copy) and modify files on your local computer.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>off:</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>The disks on your local computer are not mapped to the cloud desktop. This value is the default value.</para>
        /// <!-- --></description></item>
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
        /// <para>Specifies whether to enable the network redirection feature.</para>
        /// <remarks>
        /// <para>This feature is in invitational preview and is not available to the public.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>off (default): The network redirection feature is disabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>on: The network redirection feature is enabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("NetRedirect")]
        [Validation(Required=false)]
        public string NetRedirect { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow user preemption.</para>
        /// <remarks>
        /// <para>To improve user experience and ensure data security, multiple end users cannot connect to the same cloud desktop at the same time. The default value of this parameter is <c>off</c>, and the value cannot be changed.</para>
        /// </remarks>
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
        /// <para>To improve user experience and ensure data security, we recommend that you disable the user preemption feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("PreemptLoginUser")]
        [Validation(Required=false)]
        public List<string> PreemptLoginUser { get; set; }

        /// <summary>
        /// <para>The policy for printer redirection.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>off: Printer redirection is disabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>on: Printer redirection is enabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PrinterRedirection")]
        [Validation(Required=false)]
        public string PrinterRedirection { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the custom screen recording feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>off: Custom screen recording is disabled. This value is the default value.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>on: Custom screen recording is enabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
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
        /// <para>Specifies whether to enable screen recording.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ALLTIME: All operations that are performed by end users on cloud desktops are recorded. The recording starts immediately when end users connect to cloud desktops and ends when the end users disconnect from the cloud desktops.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>PERIOD: The operations that are performed by end users on cloud desktops during a specified period of time are recorded. You must set the start time and end time for the recording period.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>OFF: Screen recording is disabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("Recording")]
        [Validation(Required=false)]
        public string Recording { get; set; }

        /// <summary>
        /// <para>Specifies whether to record audio data during the screen recording. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: records audio and video data</description></item>
        /// <item><description>off: records only video data</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RecordingAudio")]
        [Validation(Required=false)]
        public string RecordingAudio { get; set; }

        /// <summary>
        /// <para>The duration from the time when the screen recording starts to the time when the screen recording stops. If you specify the Recording parameter, you must also specify the RecordingDuration parameter. When the specified duration ends, a recording file is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("RecordingDuration")]
        [Validation(Required=false)]
        public int? RecordingDuration { get; set; }

        /// <summary>
        /// <para>The time when the screen recording stops. Specify the value in the HH:MM:SS format. The value of this parameter is valid only if you set the Recording parameter to PERIOD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:59:00</para>
        /// </summary>
        [NameInMap("RecordingEndTime")]
        [Validation(Required=false)]
        public string RecordingEndTime { get; set; }

        /// <summary>
        /// <para>The duration in which the screen recording is valid. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("RecordingExpires")]
        [Validation(Required=false)]
        public long? RecordingExpires { get; set; }

        /// <summary>
        /// <para>The frame rate of screen recording.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>2</para>
        /// </description></item>
        /// <item><description><para>5</para>
        /// </description></item>
        /// <item><description><para>10</para>
        /// </description></item>
        /// <item><description><para>15</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecordingFps")]
        [Validation(Required=false)]
        public long? RecordingFps { get; set; }

        /// <summary>
        /// <para>The time when screen recording starts. Specify the value in the HH:MM:SS format. The value of this parameter is valid only if you set the Recording parameter to PERIOD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00:00</para>
        /// </summary>
        [NameInMap("RecordingStartTime")]
        [Validation(Required=false)]
        public string RecordingStartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the feature to send screen recording notifications to clients is enabled. Valid values: on and off.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("RecordingUserNotify")]
        [Validation(Required=false)]
        public string RecordingUserNotify { get; set; }

        /// <summary>
        /// <para>The notification content sent to clients when screen recording is enabled. By default, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Your desktop is being recorded.</para>
        /// </summary>
        [NameInMap("RecordingUserNotifyMessage")]
        [Validation(Required=false)]
        public string RecordingUserNotifyMessage { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The permission to control the keyboard and the mouse during remote assistance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>optionalControl: By default, this feature is disabled. You can enable it by applying permissions.</para>
        /// </description></item>
        /// <item><description><para>fullControl: The permission is granted.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>disableControl: The permission is revoked.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fullControl</para>
        /// </summary>
        [NameInMap("RemoteCoordinate")]
        [Validation(Required=false)]
        public string RemoteCoordinate { get; set; }

        /// <summary>
        /// <para>The effective scope of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GLOBAL: The policy takes effect globally.</description></item>
        /// <item><description>IP: The policy takes effect for specified IP addresses.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The effective CIDR block ranges. If you set the Scope parameter to IP, you must specify this parameter.</para>
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public List<string> ScopeValue { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable USB redirection.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>off: USB redirection is disabled. This value is the default value.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>on: USB redirection is enabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
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
        public List<CreatePolicyGroupRequestUsbSupplyRedirectRule> UsbSupplyRedirectRule { get; set; }
        public class CreatePolicyGroupRequestUsbSupplyRedirectRule : TeaModel {
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
            /// <para>The class of the device. If you set the <c>usbRuleType</c> parameter to 1, you must specify this parameter. For more information, see <a href="https://www.usb.org/defined-class-codes">Defined Class Codes</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0Eh</para>
            /// </summary>
            [NameInMap("DeviceClass")]
            [Validation(Required=false)]
            public string DeviceClass { get; set; }

            /// <summary>
            /// <para>The subclass of the device. If you set the <c>usbRuleType</c> parameter to 1, you must specify this parameter. For more information, see <a href="https://www.usb.org/defined-class-codes">Defined Class Codes</a>.</para>
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
            /// <para>The type of USB redirection.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: allows USB redirection</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>2: forbids USB redirection</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
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
            /// <item><description><para>1: by device class</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>2: by device vendor</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsbRuleType")]
            [Validation(Required=false)]
            public long? UsbRuleType { get; set; }

            /// <summary>
            /// <para>The ID of the vendor. For more information, see <a href="https://www.usb.org/sites/default/files/vendor_ids032322.pdf_1.pdf">Valid USB Vendor IDs (VIDs)</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04**</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the multimedia redirection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Multimedia redirection is enabled.</description></item>
        /// <item><description>off: Multimedia redirection is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("VideoRedirect")]
        [Validation(Required=false)]
        public string VideoRedirect { get; set; }

        /// <summary>
        /// <para>The policy for image display quality.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>high</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>low</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>lossless</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>medium: adaptive. This value is the default value.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("VisualQuality")]
        [Validation(Required=false)]
        public string VisualQuality { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable watermarking.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>off: Watermarking is disabled. This value is the default value.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>on: Watermarking is enabled.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        /// <summary>
        /// <para>The anti-screen photo feature. Valid values: on and off.</para>
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
        /// <para>The inclination angle of the watermark. Valid values: -10 to -30.</para>
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
        /// <para>The invisible watermark enhancement feature. Valid values: low, medium, and high.</para>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("WatermarkPower")]
        [Validation(Required=false)]
        public string WatermarkPower { get; set; }

        /// <summary>
        /// <para>The number of watermark rows. This parameter is now invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("WatermarkRowAmount")]
        [Validation(Required=false)]
        public int? WatermarkRowAmount { get; set; }

        /// <summary>
        /// <para>The security priority for invisible watermarks. Valid values: on and off.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("WatermarkSecurity")]
        [Validation(Required=false)]
        public string WatermarkSecurity { get; set; }

        /// <summary>
        /// <para>The transparency of the watermark.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>LIGHT</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DARK</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>MIDDLE</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LIGHT</para>
        /// </summary>
        [NameInMap("WatermarkTransparency")]
        [Validation(Required=false)]
        public string WatermarkTransparency { get; set; }

        /// <summary>
        /// <para>The transparency of the watermark. A larger value specifies that the watermark is less transparent. Valid values: 10 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WatermarkTransparencyValue")]
        [Validation(Required=false)]
        public int? WatermarkTransparencyValue { get; set; }

        /// <summary>
        /// <para>The type of the watermark. You can specify multiple types of watermarks at the same time. Separate multiple watermark types with commas (,).</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>EndUserId: The ID of the end user is displayed.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>HostName: The rightmost 15 characters of the cloud desktop ID are displayed.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
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
