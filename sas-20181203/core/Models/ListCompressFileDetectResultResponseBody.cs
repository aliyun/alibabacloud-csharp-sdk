// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCompressFileDetectResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCompressFileDetectResultResponseBodyPageInfo PageInfo { get; set; }
        public class ListCompressFileDetectResultResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E10BAF1C-A6C5-51E2-866C-76D5922E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detection results of files.</para>
        /// </summary>
        [NameInMap("ResultList")]
        [Validation(Required=false)]
        public List<ListCompressFileDetectResultResponseBodyResultList> ResultList { get; set; }
        public class ListCompressFileDetectResultResponseBodyResultList : TeaModel {
            /// <summary>
            /// <para>The extended information about the file detection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;HighLight&quot;:
            ///     [
            ///         [
            ///             23245,
            ///             23212
            ///         ]
            ///     ],
            ///     &quot;FileLabel&quot;:
            ///     [
            ///         &quot;PE32&quot;,
            ///         &quot;Zip&quot;,
            ///         &quot;SFX&quot;,
            ///         &quot;encrypted&quot;
            ///     ]
            /// }</para>
            /// </summary>
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            /// <summary>
            /// <para>The identifier of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0a212417e65c26ff133cfff28f6c****</para>
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            /// <summary>
            /// <para>The path to the file within the package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/1.zip/test****</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

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
            /// <para>The score of the file detection result. The following list describes mappings between the score ranges and risk levels:</para>
            /// <list type="bullet">
            /// <item><description>0 to 60: normal</description></item>
            /// <item><description>61 to 70: risky</description></item>
            /// <item><description>71 to 80: suspicious</description></item>
            /// <item><description>81 to 100: malicious</description></item>
            /// </list>
            /// <remarks>
            /// <para> A higher score indicates a more suspicious file.</para>
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
            /// <item><description><b>Trojan</b>: self-mutating trojan</description></item>
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
            /// <item><description><b>Backdoor</b>: reverse shell</description></item>
            /// <item><description><b>RiskWare</b>: software that has risks</description></item>
            /// <item><description><b>Proxytool</b>: proxy</description></item>
            /// <item><description><b>Suspicious</b>: suspicious program</description></item>
            /// <item><description><b>MalScript</b>: malicious script</description></item>
            /// <item><description><b>Rootkit</b>: rootkit</description></item>
            /// <item><description><b>Exploit</b>: exploit</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WebShell</para>
            /// </summary>
            [NameInMap("VirusType")]
            [Validation(Required=false)]
            public string VirusType { get; set; }

        }

    }

}
