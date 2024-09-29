// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateSyntheticTaskRequest : TeaModel {
        /// <summary>
        /// <para>The common parameters.</para>
        /// </summary>
        [NameInMap("CommonParam")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestCommonParam CommonParam { get; set; }
        public class CreateSyntheticTaskRequestCommonParam : TeaModel {
            /// <summary>
            /// <para>Specifies whether to create an alert rule.</para>
            /// <list type="bullet">
            /// <item><description>1: creates an alert.</description></item>
            /// <item><description>0: does not create an alert.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlarmFlag")]
            [Validation(Required=false)]
            public string AlarmFlag { get; set; }

            /// <summary>
            /// <para>The alert parameters.</para>
            /// </summary>
            [NameInMap("AlertList")]
            [Validation(Required=false)]
            public List<CreateSyntheticTaskRequestCommonParamAlertList> AlertList { get; set; }
            public class CreateSyntheticTaskRequestCommonParamAlertList : TeaModel {
                /// <summary>
                /// <para>Specifies whether the condition must be met.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCritical")]
                [Validation(Required=false)]
                public long? IsCritical { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// <para>For network synthetic monitoring, use the following names:</para>
                /// <list type="bullet">
                /// <item><description>Latency: PING_SET</description></item>
                /// <item><description>Packet loss rate: PING_LOST_RATE</description></item>
                /// <item><description>Hijacking: HIJACKPER</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PING_SET</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies how the condition is evaluated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: greater than</description></item>
                /// <item><description>0: less than</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Symbols")]
                [Validation(Required=false)]
                public long? Symbols { get; set; }

            }

            /// <summary>
            /// <para>The ID of the alert recipient. Separate multiple recipients with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("AlertNotifierId")]
            [Validation(Required=false)]
            public string AlertNotifierId { get; set; }

            /// <summary>
            /// <para>The ID of the notification policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("AlertPolicyId")]
            [Validation(Required=false)]
            public string AlertPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to evenly distribute monitoring samples. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no</description></item>
            /// <item><description>1: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MonitorSamples")]
            [Validation(Required=false)]
            public long? MonitorSamples { get; set; }

            /// <summary>
            /// <para>The time when execution starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20 10</para>
            /// </summary>
            [NameInMap("StartExecutionTime")]
            [Validation(Required=false)]
            public long? StartExecutionTime { get; set; }

        }

        /// <summary>
        /// <para>The file download task.</para>
        /// </summary>
        [NameInMap("Download")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestDownload Download { get; set; }
        public class CreateSyntheticTaskRequestDownload : TeaModel {
            /// <summary>
            /// <para>The connection timeout period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ConnectionTimeout")]
            [Validation(Required=false)]
            public double? ConnectionTimeout { get; set; }

            /// <summary>
            /// <para>The items to be ignored in a certificate error. Pass the values of the check boxes that are separated with vertical bars (|).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Host:<a href="http://www.example.com%7CReferer:www.example.com">www.example.com|Referer:www.example.com</a></para>
            /// </summary>
            [NameInMap("DownloadCustomHeaderContent")]
            [Validation(Required=false)]
            public string DownloadCustomHeaderContent { get; set; }

            /// <summary>
            /// <para>The custom host mode.</para>
            /// <list type="bullet">
            /// <item><description>1: round robin</description></item>
            /// <item><description>0: random</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DownloadCustomHost")]
            [Validation(Required=false)]
            public long? DownloadCustomHost { get; set; }

            /// <summary>
            /// <para>The custom host IP address. You can enter multiple IP addresses. Separate the IP addresses with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4:192.168.2.1,192.168.2.5:img.a.com|192.168.2.1[8080]:img.a.com</para>
            /// </summary>
            [NameInMap("DownloadCustomHostIp")]
            [Validation(Required=false)]
            public string DownloadCustomHostIp { get; set; }

            /// <summary>
            /// <para>The items to be ignored in a certificate error. Pass the values of the check boxes that are separated with vertical bars (|).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1|2|4</para>
            /// </summary>
            [NameInMap("DownloadIgnoreCertificateError")]
            [Validation(Required=false)]
            public string DownloadIgnoreCertificateError { get; set; }

            /// <summary>
            /// <para>The kernel type.</para>
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
            /// <para>Specifies whether to support redirection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DownloadRedirection")]
            [Validation(Required=false)]
            public long? DownloadRedirection { get; set; }

            /// <summary>
            /// <para>The size of the download file. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("DownloadTransmissionSize")]
            [Validation(Required=false)]
            public long? DownloadTransmissionSize { get; set; }

            /// <summary>
            /// <para>The monitoring duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MonitorTimeout")]
            [Validation(Required=false)]
            public long? MonitorTimeout { get; set; }

            /// <summary>
            /// <para>The QUIC protocol type.</para>
            /// <list type="bullet">
            /// <item><description>1: http1</description></item>
            /// <item><description>2: http2</description></item>
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
            /// <para>keyword</para>
            /// </summary>
            [NameInMap("ValidateKeywords")]
            [Validation(Required=false)]
            public string ValidateKeywords { get; set; }

            /// <summary>
            /// <para>The verification method.</para>
            /// <list type="bullet">
            /// <item><description>0: no verification</description></item>
            /// <item><description>1: string verification</description></item>
            /// <item><description>2: MD5 verification</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("VerifyWay")]
            [Validation(Required=false)]
            public long? VerifyWay { get; set; }

            /// <summary>
            /// <para>The whitelist for DNS hijacking.</para>
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
        public CreateSyntheticTaskRequestExtendInterval ExtendInterval { get; set; }
        public class CreateSyntheticTaskRequestExtendInterval : TeaModel {
            /// <summary>
            /// <para>The day on which synthetic monitoring is performed.</para>
            /// </summary>
            [NameInMap("Days")]
            [Validation(Required=false)]
            public List<long?> Days { get; set; }

            /// <summary>
            /// <para>The hour at which synthetic monitoring ends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public long? EndHour { get; set; }

            /// <summary>
            /// <para>The minute at which synthetic monitoring ends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00</para>
            /// </summary>
            [NameInMap("EndMinute")]
            [Validation(Required=false)]
            public long? EndMinute { get; set; }

            /// <summary>
            /// <para>The time when synthetic monitoring ends. The format is <c>yyyy-MM-dd HH</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-20 10</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The hour at which synthetic monitoring starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00</para>
            /// </summary>
            [NameInMap("StartHour")]
            [Validation(Required=false)]
            public long? StartHour { get; set; }

            /// <summary>
            /// <para>The minute at which synthetic monitoring starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00</para>
            /// </summary>
            [NameInMap("StartMinute")]
            [Validation(Required=false)]
            public long? StartMinute { get; set; }

            /// <summary>
            /// <para>The time when synthetic monitoring starts. The format is <c>yyyy-MM-dd HH</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20 10</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("IntervalTime")]
        [Validation(Required=false)]
        public string IntervalTime { get; set; }

        /// <summary>
        /// <para>The interval type.</para>
        /// <list type="bullet">
        /// <item><description>0: daily</description></item>
        /// <item><description>1: custom frequency</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IntervalType")]
        [Validation(Required=false)]
        public string IntervalType { get; set; }

        /// <summary>
        /// <para>The IP address type:</para>
        /// <list type="bullet">
        /// <item><description>0: an automatic IP address</description></item>
        /// <item><description>1: IPv4</description></item>
        /// <item><description>2: IPv6</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public long? IpType { get; set; }

        /// <summary>
        /// <para>The list of monitoring points.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MonitorList")]
        [Validation(Required=false)]
        public List<CreateSyntheticTaskRequestMonitorList> MonitorList { get; set; }
        public class CreateSyntheticTaskRequestMonitorList : TeaModel {
            /// <summary>
            /// <para>The ID of the city to which the monitoring point belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1100101</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public long? CityCode { get; set; }

            /// <summary>
            /// <para>The carrier type:</para>
            /// <list type="bullet">
            /// <item><description>IDC</description></item>
            /// <item><description>LastMilie</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IDC</para>
            /// </summary>
            [NameInMap("MonitorType")]
            [Validation(Required=false)]
            public long? MonitorType { get; set; }

            /// <summary>
            /// <para>The ID of the carrier.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("NetServiceId")]
            [Validation(Required=false)]
            public long? NetServiceId { get; set; }

        }

        /// <summary>
        /// <para>The monitoring items that are associated with the browse tasks.</para>
        /// </summary>
        [NameInMap("Navigation")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestNavigation Navigation { get; set; }
        public class CreateSyntheticTaskRequestNavigation : TeaModel {
            /// <summary>
            /// <para>The whitelist for DNS hijacking.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com:202.0.3.55%7C203.3.44.67">www.aliyun.com:202.0.3.55|203.3.44.67</a></para>
            /// </summary>
            [NameInMap("DNSHijackWhiteList")]
            [Validation(Required=false)]
            public string DNSHijackWhiteList { get; set; }

            /// <summary>
            /// <para>The element blacklist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.a.com</para>
            /// </summary>
            [NameInMap("ElementBlacklist")]
            [Validation(Required=false)]
            public string ElementBlacklist { get; set; }

            /// <summary>
            /// <para>Specifies whether to execute ActiveX.</para>
            /// <list type="bullet">
            /// <item><description>3: yes</description></item>
            /// <item><description>0: no</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is supported only by IE Full Elements.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ExecuteActiveX")]
            [Validation(Required=false)]
            public long? ExecuteActiveX { get; set; }

            /// <summary>
            /// <para>Specifies whether to run applets.</para>
            /// <list type="bullet">
            /// <item><description>1: yes</description></item>
            /// <item><description>0: no</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is supported only by IE Full Elements.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecuteApplication")]
            [Validation(Required=false)]
            public long? ExecuteApplication { get; set; }

            /// <summary>
            /// <para>Specifies whether to execute scripts.</para>
            /// <list type="bullet">
            /// <item><description>1: yes</description></item>
            /// <item><description>0: no</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is supported only by IE Full Elements.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecuteScript")]
            [Validation(Required=false)]
            public long? ExecuteScript { get; set; }

            /// <summary>
            /// <para>Specifies whether to filter invalid IP addresses.</para>
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
            /// <para>50</para>
            /// </summary>
            [NameInMap("FlowHijackJumpTimes")]
            [Validation(Required=false)]
            public long? FlowHijackJumpTimes { get; set; }

            /// <summary>
            /// <para>The tag that is used in DNS hijacking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("FlowHijackLogo")]
            [Validation(Required=false)]
            public string FlowHijackLogo { get; set; }

            /// <summary>
            /// <para>The timeout period of monitoring. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MonitorTimeout")]
            [Validation(Required=false)]
            public string MonitorTimeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically scroll up and down the screen to load a page.</para>
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
            public string NavAutomaticScrolling { get; set; }

            /// <summary>
            /// <para>The method that is used to customize the header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: disables the customer header.</description></item>
            /// <item><description>1: modifies the first package.</description></item>
            /// <item><description>2: modifies all packages.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NavCustomHeader")]
            [Validation(Required=false)]
            public string NavCustomHeader { get; set; }

            /// <summary>
            /// <para>The format of the custom header. You can specify multiple fields. Separate the fields with vertical bars (|).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Host:<a href="http://www.example.com%7CReferer:www.example.com">www.example.com|Referer:www.example.com</a></para>
            /// </summary>
            [NameInMap("NavCustomHeaderContent")]
            [Validation(Required=false)]
            public string NavCustomHeaderContent { get; set; }

            /// <summary>
            /// <para>The custom host mode.</para>
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
            /// <para>The custom host IP address. You can enter multiple IP addresses. Separate the IP addresses with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4:192.168.2.1,192.168.2.5:img.a.com|192.168.2.1[8080]:img.a.com</para>
            /// </summary>
            [NameInMap("NavCustomHostIp")]
            [Validation(Required=false)]
            public string NavCustomHostIp { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable caching.</para>
            /// <list type="bullet">
            /// <item><description>1: disable</description></item>
            /// <item><description>0: enable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NavDisableCache")]
            [Validation(Required=false)]
            public long? NavDisableCache { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the feature of using the Accept-Encoding field to determine whether to accept compressed files.</para>
            /// <list type="bullet">
            /// <item><description>1: disable</description></item>
            /// <item><description>0: enable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NavDisableCompression")]
            [Validation(Required=false)]
            public string NavDisableCompression { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore certificate errors during certificate verification in the SSL handshake and continue browsing.</para>
            /// <list type="bullet">
            /// <item><description>1: ignore</description></item>
            /// <item><description>0: does not ignore</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NavIgnoreCertificateError")]
            [Validation(Required=false)]
            public long? NavIgnoreCertificateError { get; set; }

            /// <summary>
            /// <para>Specifies whether to continue browsing after a redirection occurs.</para>
            /// <list type="bullet">
            /// <item><description>1: yes</description></item>
            /// <item><description>0: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NavRedirection")]
            [Validation(Required=false)]
            public long? NavRedirection { get; set; }

            /// <summary>
            /// <para>Specifies whether to return the elements on the page.</para>
            /// <list type="bullet">
            /// <item><description>1: no. Returns the basic document data.</description></item>
            /// <item><description>2: yes. Returns all document data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NavReturnElement")]
            [Validation(Required=false)]
            public long? NavReturnElement { get; set; }

            /// <summary>
            /// <para>The web page defacement.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com:202.0.3.55%7C203.3.44.67">www.example.com:202.0.3.55|203.3.44.67</a></para>
            /// </summary>
            [NameInMap("PageTamper")]
            [Validation(Required=false)]
            public string PageTamper { get; set; }

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
            /// <remarks>
            /// <para> This parameter is supported by all elements of only Chrome</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("QUICDomain")]
            [Validation(Required=false)]
            public string QUICDomain { get; set; }

            /// <summary>
            /// <para>The Quick UDP Internet Connections (QUIC) protocol version. Default value: 0. Valid values:</para>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// <item><description>35</description></item>
            /// <item><description>39</description></item>
            /// <item><description>43</description></item>
            /// <item><description>44</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is supported by all elements of only Chrome</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("QUICVersion")]
            [Validation(Required=false)]
            public long? QUICVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to return the request header.</para>
            /// <list type="bullet">
            /// <item><description>0: does not return the response header.</description></item>
            /// <item><description>1: returns the basic document header.</description></item>
            /// <item><description>2: returns all headers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RequestHeader")]
            [Validation(Required=false)]
            public long? RequestHeader { get; set; }

            /// <summary>
            /// <para>The method that is used to return the response header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: does not return the response header.</description></item>
            /// <item><description>1: returns the basic document header.</description></item>
            /// <item><description>2: returns all headers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResponseHeader")]
            [Validation(Required=false)]
            public long? ResponseHeader { get; set; }

            /// <summary>
            /// <para>The time threshold that is used to define a slow element. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SlowElementThreshold")]
            [Validation(Required=false)]
            public double? SlowElementThreshold { get; set; }

            /// <summary>
            /// <para>The blacklist for string verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Regex:*.example|expalme|</para>
            /// </summary>
            [NameInMap("VerifyStringBlacklist")]
            [Validation(Required=false)]
            public string VerifyStringBlacklist { get; set; }

            /// <summary>
            /// <para>The whitelist for string verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Regex:*.example|expalme|</para>
            /// </summary>
            [NameInMap("VerifyStringWhiteList")]
            [Validation(Required=false)]
            public string VerifyStringWhiteList { get; set; }

            /// <summary>
            /// <para>The timeout period of waiting for the monitoring to complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("WaitCompletionTime")]
            [Validation(Required=false)]
            public double? WaitCompletionTime { get; set; }

        }

        /// <summary>
        /// <para>The network synthetic monitoring task.</para>
        /// </summary>
        [NameInMap("Net")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestNet Net { get; set; }
        public class CreateSyntheticTaskRequestNet : TeaModel {
            /// <summary>
            /// <para>The DNS server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114.114.XX.XX</para>
            /// </summary>
            [NameInMap("NetDNSNs")]
            [Validation(Required=false)]
            public string NetDNSNs { get; set; }

            /// <summary>
            /// <para>The DNS query method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: recursion</description></item>
            /// <item><description>2: iteration</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NetDNSQueryMethod")]
            [Validation(Required=false)]
            public long? NetDNSQueryMethod { get; set; }

            /// <summary>
            /// <para>The IP address type of the DNS server.</para>
            /// <list type="bullet">
            /// <item><description>0: IPv4</description></item>
            /// <item><description>1: IPv6</description></item>
            /// <item><description>2: an automatic IP address</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NetDNSServer")]
            [Validation(Required=false)]
            public long? NetDNSServer { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable domain name system (DNS) monitoring.</para>
            /// <list type="bullet">
            /// <item><description>0: Off.</description></item>
            /// <item><description>1: On. You must set DNS parameters if you want to enable DNS monitoring.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NetDNSSwitch")]
            [Validation(Required=false)]
            public long? NetDNSSwitch { get; set; }

            /// <summary>
            /// <para>The timeout period of DNS monitoring. Default value: 5 seconds. Valid values: 0 to 45 seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("NetDNSTimeout")]
            [Validation(Required=false)]
            public long? NetDNSTimeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to display the data in the DIG format. Valid values:</para>
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
            /// <para>The protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: ICMP</description></item>
            /// <item><description>1: TCP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NetICMPActive")]
            [Validation(Required=false)]
            public long? NetICMPActive { get; set; }

            /// <summary>
            /// <para>Specifies whether to split packages.</para>
            /// <list type="bullet">
            /// <item><description>0: no</description></item>
            /// <item><description>1: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NetICMPDataCut")]
            [Validation(Required=false)]
            public long? NetICMPDataCut { get; set; }

            /// <summary>
            /// <para>The interval at which the network synthetic monitoring task is executed. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NetICMPInterval")]
            [Validation(Required=false)]
            public long? NetICMPInterval { get; set; }

            /// <summary>
            /// <para>The number of packages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("NetICMPNum")]
            [Validation(Required=false)]
            public long? NetICMPNum { get; set; }

            /// <summary>
            /// <para>The package size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("NetICMPSize")]
            [Validation(Required=false)]
            public long? NetICMPSize { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable ping monitoring.</para>
            /// <list type="bullet">
            /// <item><description>0: Off.</description></item>
            /// <item><description>1: On. You must set Internet control message protocol (ICMP) parameters if you want to enable ping monitoring.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NetICMPSwitch")]
            [Validation(Required=false)]
            public long? NetICMPSwitch { get; set; }

            /// <summary>
            /// <para>The timeout period of Ping monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("NetICMPTimeout")]
            [Validation(Required=false)]
            public long? NetICMPTimeout { get; set; }

            /// <summary>
            /// <para>The maximum number of active monitoring points.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("NetTraceRouteNum")]
            [Validation(Required=false)]
            public long? NetTraceRouteNum { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable tracert monitoring.</para>
            /// <list type="bullet">
            /// <item><description>0: Off.</description></item>
            /// <item><description>1: On. You must set the tracert parameters if you want to enable tracert monitoring.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NetTraceRouteSwitch")]
            [Validation(Required=false)]
            public long? NetTraceRouteSwitch { get; set; }

            /// <summary>
            /// <para>The timeout period of tracert monitoring. Valid values: 0 to 300 seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("NetTraceRouteTimeout")]
            [Validation(Required=false)]
            public long? NetTraceRouteTimeout { get; set; }

            /// <summary>
            /// <para>The whitelist for DNS hijacking. The format is <c>Domain name: Matching rule</c>.</para>
            /// <remarks>
            /// <para> Wireless application protocol (WAP) networks do not support DNS hijacking.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com:202.0.3.55%7C203.3.44.67">www.aliyun.com:202.0.3.55|203.3.44.67</a></para>
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public string WhiteList { get; set; }

        }

        /// <summary>
        /// <para>The API performance synthetic monitoring task.</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestProtocol Protocol { get; set; }
        public class CreateSyntheticTaskRequestProtocol : TeaModel {
            /// <summary>
            /// <para>The encoding format.</para>
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
            /// <para>The custom host mode.</para>
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
            /// <para>The custom host IP address. You can enter multiple IP addresses. Separate the IP addresses with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4:192.168.2.1,192.168.2.5:img.a.com|192.168.2.1[8080]:img.a.com</para>
            /// </summary>
            [NameInMap("CustomHostIp")]
            [Validation(Required=false)]
            public string CustomHostIp { get; set; }

            /// <summary>
            /// <para>The connection timeout period of the protocol. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ProtocolConnectionTime")]
            [Validation(Required=false)]
            public long? ProtocolConnectionTime { get; set; }

            /// <summary>
            /// <para>The timeout period of API performance synthetic monitoring. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ProtocolMonitorTimeout")]
            [Validation(Required=false)]
            public string ProtocolMonitorTimeout { get; set; }

            /// <summary>
            /// <para>The size of the received data. This parameter is required when you set the value of the VerifyWay parameter to 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("ReceivedDataSize")]
            [Validation(Required=false)]
            public long? ReceivedDataSize { get; set; }

            /// <summary>
            /// <para>The request content, including the request header and request body.</para>
            /// </summary>
            [NameInMap("RequestContent")]
            [Validation(Required=false)]
            public CreateSyntheticTaskRequestProtocolRequestContent RequestContent { get; set; }
            public class CreateSyntheticTaskRequestProtocolRequestContent : TeaModel {
                /// <summary>
                /// <para>The custom body of a request to initiate an API performance synthetic monitoring task.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateSyntheticTaskRequestProtocolRequestContentBody Body { get; set; }
                public class CreateSyntheticTaskRequestProtocolRequestContentBody : TeaModel {
                    /// <summary>
                    /// <para>The data that is passed when the <b>Mode</b> parameter is set to <b>form-data</b>.</para>
                    /// </summary>
                    [NameInMap("FormData")]
                    [Validation(Required=false)]
                    public List<CreateSyntheticTaskRequestProtocolRequestContentBodyFormData> FormData { get; set; }
                    public class CreateSyntheticTaskRequestProtocolRequestContentBodyFormData : TeaModel {
                        /// <summary>
                        /// <para>The key of <b>form-data</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>appId</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of <b>form-data</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3425</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The language that is selected when the Mode parameter is set to raw.</para>
                    /// <list type="bullet">
                    /// <item><description>json</description></item>
                    /// <item><description>xml</description></item>
                    /// <item><description>javascript</description></item>
                    /// <item><description>html</description></item>
                    /// <item><description>text</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>json</para>
                    /// </summary>
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    /// <summary>
                    /// <para>The data type of the content.</para>
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
                    /// <para>The data that is passed when the <b>Mode</b> parameter is set to <b>raw</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>content</para>
                    /// </summary>
                    [NameInMap("Raw")]
                    [Validation(Required=false)]
                    public string Raw { get; set; }

                    /// <summary>
                    /// <para>The data that is passed when the <b>Mode</b> parameter is set to <b>x-www-form-urlencoded</b>.</para>
                    /// </summary>
                    [NameInMap("UrlEncoding")]
                    [Validation(Required=false)]
                    public List<CreateSyntheticTaskRequestProtocolRequestContentBodyUrlEncoding> UrlEncoding { get; set; }
                    public class CreateSyntheticTaskRequestProtocolRequestContentBodyUrlEncoding : TeaModel {
                        /// <summary>
                        /// <para>The key of <b>x-www-form-urlencoded</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>appId</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of <b>x-www-form-urlencoded</b>.</para>
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
                /// <para>The custom header of a request to initiate an API performance synthetic monitoring task.</para>
                /// </summary>
                [NameInMap("Header")]
                [Validation(Required=false)]
                public List<CreateSyntheticTaskRequestProtocolRequestContentHeader> Header { get; set; }
                public class CreateSyntheticTaskRequestProtocolRequestContentHeader : TeaModel {
                    /// <summary>
                    /// <para>The key of the request header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>regionId</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the request header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The request method.</para>
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
            /// <para>&quot;code&quot;:200</para>
            /// </summary>
            [NameInMap("VerifyContent")]
            [Validation(Required=false)]
            public string VerifyContent { get; set; }

            /// <summary>
            /// <para>The method that is used to verify the response content.</para>
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
        /// <para>The ID of the region in which the application is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the task. To update a synthetic monitoring task, enter the task name and set the <b>UpdateTask</b> parameter to <b>true</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Network synthetic monitoring task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the monitoring task. Valid values:</para>
        /// <ol>
        /// <item><description>3: web page performance - IE</description></item>
        /// <item><description>34: web Page Performance - Chrome</description></item>
        /// <item><description>0: network quality</description></item>
        /// <item><description>40: file download</description></item>
        /// <item><description>7:API performance</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public long? TaskType { get; set; }

        /// <summary>
        /// <para>Specifies whether to update existing synthetic monitoring tasks.</para>
        /// <list type="bullet">
        /// <item><description>true: updates existing synthetic monitoring tasks.</description></item>
        /// <item><description>false: creates new synthetic monitoring tasks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpdateTask")]
        [Validation(Required=false)]
        public bool? UpdateTask { get; set; }

        /// <summary>
        /// <para>The URL for synthetic monitoring.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com">https://www.example.com</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
