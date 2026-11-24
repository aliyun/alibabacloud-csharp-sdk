// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateVirusFileStatusRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the user terminal device where the virus file is located. The value can be up to 64 characters in length. You can obtain the value from the following source:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusFileStatuses~~">ListVirusFileStatuses</a>: Queries the statuses of virus files in batches.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
        /// </summary>
        [NameInMap("DevTag")]
        [Validation(Required=false)]
        public string DevTag { get; set; }

        /// <summary>
        /// <para>The MD5 hash value of the virus file. The value must be a 32-character hexadecimal string. You can obtain the value from the following source:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusFileStatuses~~">ListVirusFileStatuses</a>: Queries the statuses of virus files in batches.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d41d8cd98f00b204e9800998ecf8427e</para>
        /// </summary>
        [NameInMap("FileMd5")]
        [Validation(Required=false)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// <para>The absolute path of the virus file on the user terminal device. You can obtain the value from the following source:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusFileStatuses~~">ListVirusFileStatuses</a>: Queries the statuses of virus files in batches.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C:\Users\Public\Downloads\setup.exe</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The processing action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AdminQuarantine</b>: Quarantines the virus file. The server creates a processing task and returns a TaskId. The user terminal device pulls and executes the quarantine task.</description></item>
        /// <item><description><b>AdminTrust</b>: Marks the virus file as trusted. This action only updates the processing status and does not create a processing task. An empty string is returned for TaskId.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AdminQuarantine</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The virus type. This parameter is used for synchronization to update the virus type of the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Backdoor</b>: Backdoor program.</description></item>
        /// <item><description><b>DDoS</b>: DDoS trojan.</description></item>
        /// <item><description><b>Downloader</b>: Downloader trojan.</description></item>
        /// <item><description><b>Engtest</b>: DPI engine test program.</description></item>
        /// <item><description><b>Hacktool</b>: Hacker tool.</description></item>
        /// <item><description><b>Trojan</b>: Self-mutating trojan.</description></item>
        /// <item><description><b>Malbaseware</b>: Contaminated basic software.</description></item>
        /// <item><description><b>MalScript</b>: Malicious script.</description></item>
        /// <item><description><b>Malware</b>: Malicious program.</description></item>
        /// <item><description><b>Miner</b>: Mining programs.</description></item>
        /// <item><description><b>Proxytool</b>: Proxy tool.</description></item>
        /// <item><description><b>RansomWare</b>: Ransomware.</description></item>
        /// <item><description><b>RiskWare</b>: Riskware.</description></item>
        /// <item><description><b>Rootkit</b>: Kernel hiding program.</description></item>
        /// <item><description><b>Stealer</b>: Stealer tool.</description></item>
        /// <item><description><b>Scanner</b>: Scanner.</description></item>
        /// <item><description><b>Suspicious</b>: Suspicious program.</description></item>
        /// <item><description><b>Virus</b>: Infectious virus.</description></item>
        /// <item><description><b>WebShell</b>: Web shell.</description></item>
        /// <item><description><b>Worm</b>: Worms.</description></item>
        /// <item><description><b>BlackList</b>: Files that hit the blacklist.</description></item>
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

}
