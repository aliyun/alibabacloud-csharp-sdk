// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D6C358A-A58B-4F4B-94CE-F5AAF023****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the task.</para>
        /// </summary>
        [NameInMap("TaskDetail")]
        [Validation(Required=false)]
        public GetSyntheticTaskDetailResponseBodyTaskDetail TaskDetail { get; set; }
        public class GetSyntheticTaskDetailResponseBodyTaskDetail : TeaModel {
            /// <summary>
            /// <para>The list of common parameters.</para>
            /// </summary>
            [NameInMap("CommonParam")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailCommonParam CommonParam { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailCommonParam : TeaModel {
                /// <summary>
                /// <para>The identifier of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlarmFlag")]
                [Validation(Required=false)]
                public long? AlarmFlag { get; set; }

                /// <summary>
                /// <para>The list of alerts.</para>
                /// </summary>
                [NameInMap("AlertList")]
                [Validation(Required=false)]
                public List<GetSyntheticTaskDetailResponseBodyTaskDetailCommonParamAlertList> AlertList { get; set; }
                public class GetSyntheticTaskDetailResponseBodyTaskDetailCommonParamAlertList : TeaModel {
                    /// <summary>
                    /// <para>The low-risk alert.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("GeneralAlert")]
                    [Validation(Required=false)]
                    public string GeneralAlert { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the condition is essential.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IsCritical")]
                    [Validation(Required=false)]
                    public string IsCritical { get; set; }

                    /// <summary>
                    /// <para>The alert name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alert-test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The Critical-level alert.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SeriousAlert")]
                    [Validation(Required=false)]
                    public string SeriousAlert { get; set; }

                    /// <summary>
                    /// <para>Greater than or less than.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Symbols")]
                    [Validation(Required=false)]
                    public string Symbols { get; set; }

                }

                /// <summary>
                /// <para>The ID of the alert identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlertNotifierId")]
                [Validation(Required=false)]
                public string AlertNotifierId { get; set; }

                /// <summary>
                /// <para>The ID of the alert policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlertPolicyId")]
                [Validation(Required=false)]
                public string AlertPolicyId { get; set; }

                /// <summary>
                /// <para>The monitoring samples.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MonitorSamples")]
                [Validation(Required=false)]
                public string MonitorSamples { get; set; }

                /// <summary>
                /// <para>The start time of the execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1664427128</para>
                /// </summary>
                [NameInMap("StartExecutionTime")]
                [Validation(Required=false)]
                public string StartExecutionTime { get; set; }

            }

            /// <summary>
            /// <para>The file download task.</para>
            /// </summary>
            [NameInMap("Download")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailDownload Download { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailDownload : TeaModel {
                /// <summary>
                /// <para>The timeout period of the file download task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ConnectionTimeout")]
                [Validation(Required=false)]
                public long? ConnectionTimeout { get; set; }

                /// <summary>
                /// <para>The items to be ignored in a certificate error. Multiple values are concatenated with vertical bars (|).</para>
                /// 
                /// <b>Example:</b>
                /// <para>char</para>
                /// </summary>
                [NameInMap("DownloadCustomHeaderContent")]
                [Validation(Required=false)]
                public string DownloadCustomHeaderContent { get; set; }

                /// <summary>
                /// <para>The custom host. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: round robin</description></item>
                /// <item><description>0: random</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DownloadCustomHost")]
                [Validation(Required=false)]
                public long? DownloadCustomHost { get; set; }

                /// <summary>
                /// <para>The custom IP address of the host. Multiple IP addresses are separated with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>168.23.45.1</para>
                /// </summary>
                [NameInMap("DownloadCustomHostIp")]
                [Validation(Required=false)]
                public string DownloadCustomHostIp { get; set; }

                /// <summary>
                /// <para>The kernel type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: curl</description></item>
                /// <item><description>0: WinInet</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DownloadKernel")]
                [Validation(Required=false)]
                public long? DownloadKernel { get; set; }

                /// <summary>
                /// <para>Indicates whether redirection is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DownloadRedirect")]
                [Validation(Required=false)]
                public long? DownloadRedirect { get; set; }

                /// <summary>
                /// <para>The file size. Unit: KB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DownloadTransmissionSize")]
                [Validation(Required=false)]
                public long? DownloadTransmissionSize { get; set; }

                /// <summary>
                /// <para>The monitoring duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MonitorTimeout")]
                [Validation(Required=false)]
                public long? MonitorTimeout { get; set; }

                /// <summary>
                /// <para>The QUIC protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: HTTP/1</description></item>
                /// <item><description>2: HTTP/2</description></item>
                /// <item><description>3: http3</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("QuickProtocol")]
                [Validation(Required=false)]
                public string QuickProtocol { get; set; }

                /// <summary>
                /// <para>The keyword that is used in verification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ValidateKeywords")]
                [Validation(Required=false)]
                public string ValidateKeywords { get; set; }

                /// <summary>
                /// <para>The method that is used to verify the response content. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no verification.</description></item>
                /// <item><description>1: exact match with the verification string.</description></item>
                /// <item><description>2: partial match with the verification string.</description></item>
                /// <item><description>3: MD5 verification.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("VerifyWay")]
                [Validation(Required=false)]
                public long? VerifyWay { get; set; }

                /// <summary>
                /// <para>The whitelisted objects that are used to avoid DNS hijacking. Format: <c>&lt;domain name&gt;:&lt;objects&gt;</c>.</para>
                /// <remarks>
                /// <para> WAP networks do not support hijacking.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;src\&quot;:\&quot;211.154.166.174\&quot;}]</para>
                /// </summary>
                [NameInMap("WhiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }

            }

            /// <summary>
            /// <para>The frequency.</para>
            /// </summary>
            [NameInMap("ExtendInterval")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailExtendInterval ExtendInterval { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailExtendInterval : TeaModel {
                /// <summary>
                /// <para>The day on which synthetic monitoring is performed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>\-1: every day</description></item>
                /// <item><description>0: Sunday</description></item>
                /// <item><description>1: Monday</description></item>
                /// <item><description>2: Tuesday</description></item>
                /// <item><description>3: Wednesday</description></item>
                /// <item><description>4: Thursday</description></item>
                /// <item><description>5: Friday</description></item>
                /// <item><description>6: Saturday</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<long?> Days { get; set; }

                /// <summary>
                /// <para>The minute at which synthetic monitoring ends.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("EndMinute")]
                [Validation(Required=false)]
                public long? EndMinute { get; set; }

                /// <summary>
                /// <para>The time when synthetic monitoring ends. Format: <c>yyyy-MM-dd HH</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-03 11:40</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The hour at which synthetic monitoring ends.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Endhour")]
                [Validation(Required=false)]
                public long? Endhour { get; set; }

                /// <summary>
                /// <para>The hour at which synthetic monitoring starts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("StartHour")]
                [Validation(Required=false)]
                public long? StartHour { get; set; }

                /// <summary>
                /// <para>The minute at which synthetic monitoring starts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("StartMinute")]
                [Validation(Required=false)]
                public long? StartMinute { get; set; }

                /// <summary>
                /// <para>The time when synthetic monitoring starts. Format: yyyy-MM-dd HH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-02-26 11:40</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The interval at which synthetic monitoring is performed. Unit: minutes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1</description></item>
            /// <item><description>5</description></item>
            /// <item><description>10</description></item>
            /// <item><description>15</description></item>
            /// <item><description>20</description></item>
            /// <item><description>30</description></item>
            /// <item><description>60</description></item>
            /// <item><description>120</description></item>
            /// <item><description>180</description></item>
            /// <item><description>240</description></item>
            /// <item><description>360</description></item>
            /// <item><description>480</description></item>
            /// <item><description>720</description></item>
            /// <item><description>1440</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("IntervalTime")]
            [Validation(Required=false)]
            public long? IntervalTime { get; set; }

            /// <summary>
            /// <para>The interval type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: daily</description></item>
            /// <item><description>1: custom frequency</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IntervalType")]
            [Validation(Required=false)]
            public long? IntervalType { get; set; }

            /// <summary>
            /// <para>The IP version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: A version is automatically selected.</description></item>
            /// <item><description>1: IPv4.</description></item>
            /// <item><description>2: IPv6.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public long? IpType { get; set; }

            /// <summary>
            /// <para>The detection points.</para>
            /// </summary>
            [NameInMap("MonitorList")]
            [Validation(Required=false)]
            public List<GetSyntheticTaskDetailResponseBodyTaskDetailMonitorList> MonitorList { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailMonitorList : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public long? CityCode { get; set; }

                /// <summary>
                /// <para>The type of the detection point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IDC</para>
                /// </summary>
                [NameInMap("MonitorType")]
                [Validation(Required=false)]
                public long? MonitorType { get; set; }

                /// <summary>
                /// <para>The ID of the network service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12001</para>
                /// </summary>
                [NameInMap("NetServiceId")]
                [Validation(Required=false)]
                public long? NetServiceId { get; set; }

                /// <summary>
                /// <para>The number of times that the system sends detection requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("SendCount")]
                [Validation(Required=false)]
                public long? SendCount { get; set; }

            }

            /// <summary>
            /// <para>The detection points.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("MonitorListString")]
            [Validation(Required=false)]
            public string MonitorListString { get; set; }

            /// <summary>
            /// <para>The browser test task.</para>
            /// </summary>
            [NameInMap("Nav")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailNav Nav { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailNav : TeaModel {
                /// <summary>
                /// <para>The DNS whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>119.119.53.156</para>
                /// </summary>
                [NameInMap("DnsHijackWhitelist")]
                [Validation(Required=false)]
                public string DnsHijackWhitelist { get; set; }

                /// <summary>
                /// <para>The element blacklist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ElementBlacklist")]
                [Validation(Required=false)]
                public string ElementBlacklist { get; set; }

                /// <summary>
                /// <para>Indicates whether ActiveX is executed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>3: yes</description></item>
                /// <item><description>0: no</description></item>
                /// </list>
                /// <remarks>
                /// <para> Only IE elements support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ExecuteActiveX")]
                [Validation(Required=false)]
                public long? ExecuteActiveX { get; set; }

                /// <summary>
                /// <para>Indicates whether the applet is executed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no</description></item>
                /// <item><description>1: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecuteApplet")]
                [Validation(Required=false)]
                public long? ExecuteApplet { get; set; }

                /// <summary>
                /// <para>Indicates whether scripts are executed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: yes</description></item>
                /// <item><description>0: no</description></item>
                /// </list>
                /// <remarks>
                /// <para> Only IE elements support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecuteScript")]
                [Validation(Required=false)]
                public long? ExecuteScript { get; set; }

                /// <summary>
                /// <para>Indicates whether invalid IP addresses are excluded. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: no</description></item>
                /// <item><description>0: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FilterInvalidIP")]
                [Validation(Required=false)]
                public long? FilterInvalidIP { get; set; }

                /// <summary>
                /// <para>The element that is used in DNS hijacking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("FlowHijackJumpTimes")]
                [Validation(Required=false)]
                public long? FlowHijackJumpTimes { get; set; }

                /// <summary>
                /// <para>The tag that is used in DNS hijacking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>target</para>
                /// </summary>
                [NameInMap("FlowHijackLogo")]
                [Validation(Required=false)]
                public string FlowHijackLogo { get; set; }

                /// <summary>
                /// <para>The monitoring timeout period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("MonitorTimeout")]
                [Validation(Required=false)]
                public long? MonitorTimeout { get; set; }

                /// <summary>
                /// <para>Indicates whether the screen is automatically scrolled up and down to load a page. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: yes</description></item>
                /// <item><description>0: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NavAutomaticScrolling")]
                [Validation(Required=false)]
                public long? NavAutomaticScrolling { get; set; }

                /// <summary>
                /// <para>Indicates whether a custom header is created. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no</description></item>
                /// <item><description>1: A custom header is created for the first packet.</description></item>
                /// <item><description>2: A custom header is created for all packets.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NavCustomHeader")]
                [Validation(Required=false)]
                public string NavCustomHeader { get; set; }

                /// <summary>
                /// <para>The format of the custom header. Multiple fields are separated with vertical bars (|).</para>
                /// 
                /// <b>Example:</b>
                /// <para>content</para>
                /// </summary>
                [NameInMap("NavCustomHeaderContent")]
                [Validation(Required=false)]
                public string NavCustomHeaderContent { get; set; }

                /// <summary>
                /// <para>The custom host mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: round robin</description></item>
                /// <item><description>0: random</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NavCustomHost")]
                [Validation(Required=false)]
                public long? NavCustomHost { get; set; }

                /// <summary>
                /// <para>The custom IP address of the host. Multiple IP addresses are separated with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>119.119.53.156/32</para>
                /// </summary>
                [NameInMap("NavCustomHostIp")]
                [Validation(Required=false)]
                public string NavCustomHostIp { get; set; }

                /// <summary>
                /// <para>Indicates whether caching is disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Caching is disabled.</description></item>
                /// <item><description>0: Caching is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NavDisableCache")]
                [Validation(Required=false)]
                public long? NavDisableCache { get; set; }

                /// <summary>
                /// <para>Indicates whether compression is disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Compression is enabled.</description></item>
                /// <item><description>1: Compression is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NavDisableCompression")]
                [Validation(Required=false)]
                public long? NavDisableCompression { get; set; }

                /// <summary>
                /// <para>Indicates whether certificate errors are ignored during certificate verification in the SSL handshake. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: yes</description></item>
                /// <item><description>0: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NavIgnoreCertificateError")]
                [Validation(Required=false)]
                public long? NavIgnoreCertificateError { get; set; }

                /// <summary>
                /// <para>Indicates whether redirection is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no</description></item>
                /// <item><description>1: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NavRedirect")]
                [Validation(Required=false)]
                public long? NavRedirect { get; set; }

                /// <summary>
                /// <para>Indicates whether the elements on the page are returned.</para>
                /// <list type="bullet">
                /// <item><description>1: no. The basic document data is returned.</description></item>
                /// <item><description>2: yes. All document data is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NavReturnElement")]
                [Validation(Required=false)]
                public long? NavReturnElement { get; set; }

                /// <summary>
                /// <para>The page tampering.</para>
                /// 
                /// <b>Example:</b>
                /// <para>content</para>
                /// </summary>
                [NameInMap("PageTampering")]
                [Validation(Required=false)]
                public string PageTampering { get; set; }

                /// <summary>
                /// <para>The process ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ssh</para>
                /// </summary>
                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

                /// <summary>
                /// <para>The domain name of the QUIC request element.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("QuicDomain")]
                [Validation(Required=false)]
                public string QuicDomain { get; set; }

                /// <summary>
                /// <para>The QUIC version. Default value: 0. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>35</description></item>
                /// <item><description>39</description></item>
                /// <item><description>43</description></item>
                /// <item><description>44</description></item>
                /// </list>
                /// <remarks>
                /// <para> Only Chrome elements support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QuicVersion")]
                [Validation(Required=false)]
                public long? QuicVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether request headers are returned. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no</description></item>
                /// <item><description>1: The headers of base documents are returned.</description></item>
                /// <item><description>2: All headers are returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RequestHeader")]
                [Validation(Required=false)]
                public long? RequestHeader { get; set; }

                /// <summary>
                /// <para>The time threshold that is used to define a slow element. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("SlowElementThreshold")]
                [Validation(Required=false)]
                public long? SlowElementThreshold { get; set; }

                /// <summary>
                /// <para>The blacklist for string verification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("VerifyStringBlacklist")]
                [Validation(Required=false)]
                public string VerifyStringBlacklist { get; set; }

                /// <summary>
                /// <para>The whitelist for string verification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("VerifyStringWhitelist")]
                [Validation(Required=false)]
                public string VerifyStringWhitelist { get; set; }

                /// <summary>
                /// <para>The timeout period of waiting for the monitoring to complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("WaitCompletionTime")]
                [Validation(Required=false)]
                public long? WaitCompletionTime { get; set; }

            }

            /// <summary>
            /// <para>The network synthetic monitoring task.</para>
            /// </summary>
            [NameInMap("Net")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailNet Net { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailNet : TeaModel {
                /// <summary>
                /// <para>Indicates whether the data is displayed in the DIG format. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no</description></item>
                /// <item><description>1: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NetDigSwitch")]
                [Validation(Required=false)]
                public long? NetDigSwitch { get; set; }

                /// <summary>
                /// <para>The NS server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>189.12.32.124</para>
                /// </summary>
                [NameInMap("NetDnsNs")]
                [Validation(Required=false)]
                public string NetDnsNs { get; set; }

                /// <summary>
                /// <para>The DNS query method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: recursive</description></item>
                /// <item><description>2: iterative</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NetDnsQueryMethod")]
                [Validation(Required=false)]
                public string NetDnsQueryMethod { get; set; }

                /// <summary>
                /// <para>The type of the DNS server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: ipv4</description></item>
                /// <item><description>1: ipv6</description></item>
                /// <item><description>2: A version is automatically selected.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NetDnsServer")]
                [Validation(Required=false)]
                public long? NetDnsServer { get; set; }

                /// <summary>
                /// <para>Indicates whether DNS test is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no</description></item>
                /// <item><description>1: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NetDnsSwitch")]
                [Validation(Required=false)]
                public long? NetDnsSwitch { get; set; }

                /// <summary>
                /// <para>The timeout period of DNS requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("NetDnsTimeout")]
                [Validation(Required=false)]
                public string NetDnsTimeout { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0 : ICMP</description></item>
                /// <item><description>1 : TCP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NetIcmpActive")]
                [Validation(Required=false)]
                public long? NetIcmpActive { get; set; }

                /// <summary>
                /// <para>Indicates whether packets are split. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no</description></item>
                /// <item><description>1: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NetIcmpDataCut")]
                [Validation(Required=false)]
                public long? NetIcmpDataCut { get; set; }

                /// <summary>
                /// <para>The interval at which the synthetic monitoring task is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("NetIcmpInterval")]
                [Validation(Required=false)]
                public long? NetIcmpInterval { get; set; }

                /// <summary>
                /// <para>The number of packets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("NetIcmpNum")]
                [Validation(Required=false)]
                public long? NetIcmpNum { get; set; }

                /// <summary>
                /// <para>The packet size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("NetIcmpSize")]
                [Validation(Required=false)]
                public long? NetIcmpSize { get; set; }

                /// <summary>
                /// <para>Indicates whether ICMP test is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no.</description></item>
                /// <item><description>1: yes. If you set this parameter to 1, you must also set the Icmp parameter.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NetIcmpSwitch")]
                [Validation(Required=false)]
                public long? NetIcmpSwitch { get; set; }

                /// <summary>
                /// <para>The monitoring timeout period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("NetIcmpTimeout")]
                [Validation(Required=false)]
                public long? NetIcmpTimeout { get; set; }

                /// <summary>
                /// <para>The maximum number of active detection points.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("NetTraceRouteNum")]
                [Validation(Required=false)]
                public long? NetTraceRouteNum { get; set; }

                /// <summary>
                /// <para>Indicates whether Tracert test is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no</description></item>
                /// <item><description>1: yes. If you set this parameter to 1, you must also set the Tracert parameter.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NetTraceRouteSwitch")]
                [Validation(Required=false)]
                public long? NetTraceRouteSwitch { get; set; }

                /// <summary>
                /// <para>The monitoring timeout period. Valid values: 0 to 300. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("NetTraceRouteTimeout")]
                [Validation(Required=false)]
                public long? NetTraceRouteTimeout { get; set; }

                /// <summary>
                /// <para>The whitelisted objects that are used to avoid DNS hijacking. Format: <c>&lt;domain name&gt;:&lt;objects&gt;</c>.</para>
                /// <remarks>
                /// <para> WAP networks do not support hijacking.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>119.119.53.156/32</para>
                /// </summary>
                [NameInMap("WhiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }

            }

            /// <summary>
            /// <para>The synthetic monitoring task of the API performance type.</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailProtocol Protocol { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocol : TeaModel {
                /// <summary>
                /// <para>The encoding format. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: UTF-8</description></item>
                /// <item><description>1: GBK</description></item>
                /// <item><description>2: GB2312</description></item>
                /// <item><description>3: Unicode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CharacterEncoding")]
                [Validation(Required=false)]
                public long? CharacterEncoding { get; set; }

                /// <summary>
                /// <para>The custom host. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: round robin</description></item>
                /// <item><description>0: random</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CustomHost")]
                [Validation(Required=false)]
                public long? CustomHost { get; set; }

                /// <summary>
                /// <para>The custom IP address of the host. Multiple IP addresses are separated with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>119.119.53.156</para>
                /// </summary>
                [NameInMap("CustomHostIp")]
                [Validation(Required=false)]
                public string CustomHostIp { get; set; }

                /// <summary>
                /// <para>The timeout period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ProtocolConnectionTimeout")]
                [Validation(Required=false)]
                public long? ProtocolConnectionTimeout { get; set; }

                /// <summary>
                /// <para>The timeout period of API performance monitoring. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("ProtocolMonitorTimeout")]
                [Validation(Required=false)]
                public long? ProtocolMonitorTimeout { get; set; }

                /// <summary>
                /// <para>The size of the received data. This parameter is returned when <b>VerifyWay</b> is set to 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("ReceivedDataSize")]
                [Validation(Required=false)]
                public long? ReceivedDataSize { get; set; }

                /// <summary>
                /// <para>The request content, including the header and body.</para>
                /// </summary>
                [NameInMap("RequestContent")]
                [Validation(Required=false)]
                public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContent RequestContent { get; set; }
                public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContent : TeaModel {
                    /// <summary>
                    /// <para>The content of the request body.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBody Body { get; set; }
                    public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBody : TeaModel {
                        /// <summary>
                        /// <para>The data content. This parameter is returned when Mode is set to form-data.</para>
                        /// </summary>
                        [NameInMap("Formdata")]
                        [Validation(Required=false)]
                        public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyFormdata Formdata { get; set; }
                        public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyFormdata : TeaModel {
                            /// <summary>
                            /// <para>The key of the <b>form-data</b>.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>appId</para>
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// <para>The value of the form-data.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3425</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The language used when Mode is set to raw. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>json</description></item>
                        /// <item><description>xml</description></item>
                        /// <item><description>javascript</description></item>
                        /// <item><description>html</description></item>
                        /// <item><description>text</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xml</para>
                        /// </summary>
                        [NameInMap("Language")]
                        [Validation(Required=false)]
                        public string Language { get; set; }

                        /// <summary>
                        /// <para>The type of the content. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>form-data</description></item>
                        /// <item><description>x-www-form-urlencoded</description></item>
                        /// <item><description>raw</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>form-data</para>
                        /// </summary>
                        [NameInMap("Mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// <para>The data content. This parameter is returned when <b>Mode</b> is set to <b>raw</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>content</para>
                        /// </summary>
                        [NameInMap("Raw")]
                        [Validation(Required=false)]
                        public string Raw { get; set; }

                        /// <summary>
                        /// <para>The URL of the body content.</para>
                        /// </summary>
                        [NameInMap("Urlencoded")]
                        [Validation(Required=false)]
                        public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyUrlencoded Urlencoded { get; set; }
                        public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyUrlencoded : TeaModel {
                            /// <summary>
                            /// <para>The tag key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>appId</para>
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// <para>The tag value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11080</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The request header.</para>
                    /// </summary>
                    [NameInMap("Header")]
                    [Validation(Required=false)]
                    public List<GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentHeader> Header { get; set; }
                    public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentHeader : TeaModel {
                        /// <summary>
                        /// <para>The key of the header in the request parameters.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>regionId</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the header in the request parameters.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The request method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>POST</description></item>
                    /// <item><description>GET</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>POST</para>
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                }

                /// <summary>
                /// <para>The verification string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>list</para>
                /// </summary>
                [NameInMap("VerifyContent")]
                [Validation(Required=false)]
                public string VerifyContent { get; set; }

                /// <summary>
                /// <para>The method that is used to verify the response content. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no verification.</description></item>
                /// <item><description>1: exact match with the verification string.</description></item>
                /// <item><description>2: partial match with the verification string.</description></item>
                /// <item><description>3: MD5 verification.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("VerifyWay")]
                [Validation(Required=false)]
                public long? VerifyWay { get; set; }

            }

            /// <summary>
            /// <para>The ID of the synthetic monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19584</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>net-test</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid values:</para>
            /// <ol>
            /// <item><description>3: web page performance - IE</description></item>
            /// <item><description>34: web page performance - Chrome</description></item>
            /// <item><description>0: network quality</description></item>
            /// <item><description>40: file download</description></item>
            /// <item><description>7: API performance</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public long? TaskType { get; set; }

            /// <summary>
            /// <para>The URL for synthetic monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
