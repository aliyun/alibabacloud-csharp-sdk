// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of file detection results.</para>
        /// </summary>
        [NameInMap("ResultList")]
        [Validation(Required=false)]
        public List<GetFileDetectResultResponseBodyResultList> ResultList { get; set; }
        public class GetFileDetectResultResponseBodyResultList : TeaModel {
            /// <summary>
            /// <para>The status code returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Whether to identify as a compressed package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Compress")]
            [Validation(Required=false)]
            public bool? Compress { get; set; }

            /// <summary>
            /// <para>The extended information about the file detection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;HighLight&quot;:[[23245,23212]]}</para>
            /// </summary>
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            /// <summary>
            /// <para>The identifier of the file. Only MD5 hash values are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0a212417e65c26ff133cfff28f6c****</para>
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The file detection result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The file is normal.</description></item>
            /// <item><description><b>1</b>: The file is suspicious.</description></item>
            /// <item><description><b>3</b>: The detection is in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

            /// <summary>
            /// <para>The score of file detection result.</para>
            /// <remarks>
            /// <para>A higher score indicates a more suspicious file.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The type of the virus. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Trojan</b>: trojan horse</description></item>
            /// <item><description><b>WebShell</b>: webshell</description></item>
            /// <item><description><b>Backdoor</b>: backdoor program</description></item>
            /// <item><description><b>RansomWare</b>: ransomware</description></item>
            /// <item><description><b>Scanner</b>: scanner</description></item>
            /// <item><description><b>Stealer</b>: tool that is used to steal information</description></item>
            /// <item><description><b>Malbaseware</b>: tainted basic software</description></item>
            /// <item><description><b>Hacktool</b>: attacker tool</description></item>
            /// <item><description><b>Engtest</b>: engine test program</description></item>
            /// <item><description><b>Downloader</b>: trojan downloader</description></item>
            /// <item><description><b>Virus</b>: infectious virus</description></item>
            /// <item><description><b>Miner</b>: mining program</description></item>
            /// <item><description><b>Worm</b>: worm</description></item>
            /// <item><description><b>DDoS</b>: DDoS trojan</description></item>
            /// <item><description><b>Malware</b>: malicious program</description></item>
            /// <item><description><b>RiskWare</b>: software that has risks</description></item>
            /// <item><description><b>Proxytool</b>: proxy</description></item>
            /// <item><description><b>Suspicious</b>: suspicious program</description></item>
            /// <item><description><b>MalScript</b>: malicious script</description></item>
            /// <item><description><b>Rootkit</b>: rootkit</description></item>
            /// <item><description><b>Exploit</b>: exploit</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WEBSHELL</para>
            /// </summary>
            [NameInMap("VirusType")]
            [Validation(Required=false)]
            public string VirusType { get; set; }

        }

    }

}
