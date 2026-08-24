// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusFileStatusesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of virus files.</para>
        /// </summary>
        [NameInMap("FileStatuses")]
        [Validation(Required=false)]
        public List<ListVirusFileStatusesResponseBodyFileStatuses> FileStatuses { get; set; }
        public class ListVirusFileStatusesResponseBodyFileStatuses : TeaModel {
            /// <summary>
            /// <para>The time when the administrator initiated the disposition, in the format yyyy-MM-dd HH:mm:ss (UTC+8). An empty string is returned when the disposition was not initiated by an administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-21 09:30:12</para>
            /// </summary>
            [NameInMap("ConsoleOperationTime")]
            [Validation(Required=false)]
            public string ConsoleOperationTime { get; set; }

            /// <summary>
            /// <para>The name of the department to which the user belongs. Multiple departments are separated by commas (,). The nearest department name in the organizational structure is returned, not the full path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D Department,Security Team</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>The unique identifier of the user\&quot;s endpoint device that detected this virus file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            /// <summary>
            /// <para>The operating system type of the user terminal device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b>: Windows.</description></item>
            /// <item><description><b>macOS</b>: macOS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("DevType")]
            [Validation(Required=false)]
            public string DevType { get; set; }

            /// <summary>
            /// <para>The time when the virus file was discovered, in the format yyyy-MM-dd HH:mm:ss (UTC+8). A hyphen (-) is returned when no record exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-21 03:12:07</para>
            /// </summary>
            [NameInMap("DiscoveryTime")]
            [Validation(Required=false)]
            public string DiscoveryTime { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the virus file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d41d8cd98f00b204e9800998ecf8427e</para>
            /// </summary>
            [NameInMap("FileMd5")]
            [Validation(Required=false)]
            public string FileMd5 { get; set; }

            /// <summary>
            /// <para>The absolute path of the virus file on the user\&quot;s endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Users\Public\Downloads\setup.exe</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The disposition status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: Pending disposition.</description></item>
            /// <item><description><b>Processed</b>: Disposed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("FileProcessStatus")]
            [Validation(Required=false)]
            public string FileProcessStatus { get; set; }

            /// <summary>
            /// <para>The size of the virus file, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20480</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>The hostname of the user\&quot;s endpoint device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DESKTOP-8A3F</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The disposition action that has been performed. An empty string is returned when no disposition has been performed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AdminQuarantine</b>: Quarantined by administrator.</description></item>
            /// <item><description><b>AdminTrust</b>: Trusted by administrator.</description></item>
            /// <item><description><b>UserQuarantine</b>: Quarantined by endpoint user.</description></item>
            /// <item><description><b>UserTrust</b>: Trusted by endpoint user.</description></item>
            /// <item><description><b>AutoQuarantine</b>: Automatically quarantined based on policy.</description></item>
            /// <item><description><b>Fail</b>: Disposition failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AdminQuarantine</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The effective period of the disposition, in the format yyyy-MM-dd HH:mm:ss (UTC+8). The later of the actual disposition time on the user\&quot;s endpoint device and the time when the administrator initiated the disposition is used. A hyphen (-) is returned when no disposition has been performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-21 09:31:45</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>High</b>: High risk.</description></item>
            /// <item><description><b>Mid</b>: Medium risk.</description></item>
            /// <item><description><b>Low</b>: Low risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>High</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("SaseUserId")]
            [Validation(Required=false)]
            public string SaseUserId { get; set; }

            /// <summary>
            /// <para>The ID of the virus scan task that detected this virus file. An empty string is returned when the file is detected by real-time protection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1:1024772</para>
            /// </summary>
            [NameInMap("ScanTaskId")]
            [Validation(Required=false)]
            public string ScanTaskId { get; set; }

            /// <summary>
            /// <para>The execution result description of the disposition or scan, reported by the user\&quot;s endpoint device. If a disposition record exists, the execution result of the disposition task is returned. Otherwise, the execution result of the scan task is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quarantine success</para>
            /// </summary>
            [NameInMap("TaskExecutionInfo")]
            [Validation(Required=false)]
            public string TaskExecutionInfo { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John Smith</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <para>The detection source of the virus file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Task</b>: Detected by a virus scan task.</description></item>
            /// <item><description><b>Download</b>: Detected by real-time protection during file download.</description></item>
            /// <item><description><b>Process</b>: Detected by real-time protection during process execution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Task</para>
            /// </summary>
            [NameInMap("VirusFileSource")]
            [Validation(Required=false)]
            public string VirusFileSource { get; set; }

            /// <summary>
            /// <para>The virus type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Backdoor</b>: Backdoor program.</description></item>
            /// <item><description><b>DDoS</b>: DDoS Trojan.</description></item>
            /// <item><description><b>Downloader</b>: Downloader Trojan.</description></item>
            /// <item><description><b>Engtest</b>: DPI engine test program.</description></item>
            /// <item><description><b>Hacktool</b>: Hacking tool.</description></item>
            /// <item><description><b>Trojan</b>: Self-mutating Trojan.</description></item>
            /// <item><description><b>Malbaseware</b>: Contaminated base software.</description></item>
            /// <item><description><b>MalScript</b>: Malicious script.</description></item>
            /// <item><description><b>Malware</b>: Malicious program.</description></item>
            /// <item><description><b>Miner</b>: Mining programs.</description></item>
            /// <item><description><b>Proxytool</b>: Proxy tool.</description></item>
            /// <item><description><b>RansomWare</b>: Ransomware.</description></item>
            /// <item><description><b>RiskWare</b>: Risky software.</description></item>
            /// <item><description><b>Rootkit</b>: Kernel-hidden program.</description></item>
            /// <item><description><b>Stealer</b>: Credential-stealing tool.</description></item>
            /// <item><description><b>Scanner</b>: Scanner.</description></item>
            /// <item><description><b>Suspicious</b>: Suspicious program.</description></item>
            /// <item><description><b>Virus</b>: File-infecting virus.</description></item>
            /// <item><description><b>WebShell</b>: Web shell.</description></item>
            /// <item><description><b>Worm</b>: Worms.</description></item>
            /// <item><description><b>BlackList</b>: File that hit the blacklist.</description></item>
            /// <item><description><b>Exp</b>: Vulnerability exploits program.</description></item>
            /// <item><description><b>Patcher</b>: Cracking program.</description></item>
            /// <item><description><b>Gametool</b>: Private server tool.</description></item>
            /// <item><description><b>AdWare</b>: Adware.</description></item>
            /// <item><description><b>Maldoc</b>: Malicious document.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Virus</para>
            /// </summary>
            [NameInMap("VirusType")]
            [Validation(Required=false)]
            public string VirusType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of virus files that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

    }

}
