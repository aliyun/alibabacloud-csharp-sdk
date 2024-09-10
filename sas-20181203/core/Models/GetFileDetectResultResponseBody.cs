// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectResultResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of file detection results.
        /// </summary>
        [NameInMap("ResultList")]
        [Validation(Required=false)]
        public List<GetFileDetectResultResponseBodyResultList> ResultList { get; set; }
        public class GetFileDetectResultResponseBodyResultList : TeaModel {
            /// <summary>
            /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// Whether to identify as a compressed package. Valid values:
            /// - **true**: Yes.
            /// - **false**: No.
            /// </summary>
            [NameInMap("Compress")]
            [Validation(Required=false)]
            public bool? Compress { get; set; }

            /// <summary>
            /// The extended information about the file detection result.
            /// </summary>
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            /// <summary>
            /// The identifier of the file. Only MD5 hash values are supported.
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            /// <summary>
            /// The error message returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The file detection result. Valid values:
            /// 
            /// *   **0**: The file is normal.
            /// *   **1**: The file is suspicious.
            /// *   **3**: The detection is in progress.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

            /// <summary>
            /// The score of file detection result.
            /// 
            /// > A higher score indicates a more suspicious file.
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// The type of the virus. Valid values:
            /// 
            /// *   **Trojan**: trojan horse
            /// *   **WebShell**: webshell
            /// *   **Backdoor**: backdoor program
            /// *   **RansomWare**: ransomware
            /// *   **Scanner**: scanner
            /// *   **Stealer**: tool that is used to steal information
            /// *   **Malbaseware**: tainted basic software
            /// *   **Hacktool**: attacker tool
            /// *   **Engtest**: engine test program
            /// *   **Downloader**: trojan downloader
            /// *   **Virus**: infectious virus
            /// *   **Miner**: mining program
            /// *   **Worm**: worm
            /// *   **DDoS**: DDoS trojan
            /// *   **Malware**: malicious program
            /// *   **RiskWare**: software that has risks
            /// *   **Proxytool**: proxy
            /// *   **Suspicious**: suspicious program
            /// *   **MalScript**: malicious script
            /// *   **Rootkit**: rootkit
            /// *   **Exploit**: exploit
            /// </summary>
            [NameInMap("VirusType")]
            [Validation(Required=false)]
            public string VirusType { get; set; }

        }

    }

}
