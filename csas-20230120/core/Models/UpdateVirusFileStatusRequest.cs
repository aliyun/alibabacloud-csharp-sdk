// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateVirusFileStatusRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the user terminal device where the virus file is located. The value can be up to 64 characters in length. You can obtain the value from the following operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusFileStatuses~~">ListVirusFileStatuses</a>: lists virus file statuses.</description></item>
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
        /// <para>The MD5 value of the virus file. The value must be a 32-character hexadecimal string. You can obtain the value from the following operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusFileStatuses~~">ListVirusFileStatuses</a>: lists virus file statuses.</description></item>
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
        /// <para>The absolute path of the virus file on the user terminal device. You can obtain the value from the following operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusFileStatuses~~">ListVirusFileStatuses</a>: lists virus file statuses.</description></item>
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
        /// <para>The disposal action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AdminQuarantine</b>: quarantines the virus file. The server creates a disposal task and returns a TaskId. The user terminal device pulls and executes the quarantine.</description></item>
        /// <item><description><b>AdminTrust</b>: trusts the virus file. Only the disposal status is updated. No disposal task is created, and TaskId returns an empty string.</description></item>
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
        /// <item><description><b>Backdoor</b>: backdoor program.</description></item>
        /// <item><description><b>DDoS</b>: DDoS Trojan.</description></item>
        /// <item><description><b>Downloader</b>: downloader Trojan.</description></item>
        /// <item><description><b>Engtest</b>: DPI engine test program.</description></item>
        /// <item><description><b>Hacktool</b>: hacker tool.</description></item>
        /// <item><description><b>Trojan</b>: self-mutating Trojan.</description></item>
        /// <item><description><b>Malbaseware</b>: contaminated base software.</description></item>
        /// <item><description><b>MalScript</b>: malicious script.</description></item>
        /// <item><description><b>Malware</b>: malicious program.</description></item>
        /// <item><description><b>Miner</b>: mining programs.</description></item>
        /// <item><description><b>Proxytool</b>: proxy tool.</description></item>
        /// <item><description><b>RansomWare</b>: ransomware.</description></item>
        /// <item><description><b>RiskWare</b>: riskware.</description></item>
        /// <item><description><b>Rootkit</b>: kernel-hidden program.</description></item>
        /// <item><description><b>Stealer</b>: credential stealer.</description></item>
        /// <item><description><b>Scanner</b>: scanner.</description></item>
        /// <item><description><b>Suspicious</b>: suspicious program.</description></item>
        /// <item><description><b>Virus</b>: file-infecting virus.</description></item>
        /// <item><description><b>WebShell</b>: webshell.</description></item>
        /// <item><description><b>Worm</b>: worms.</description></item>
        /// <item><description><b>BlackList</b>: file that hit a blacklist entry.</description></item>
        /// <item><description><b>Exp</b>: vulnerability exploits program.</description></item>
        /// <item><description><b>Patcher</b>: cracking program.</description></item>
        /// <item><description><b>Gametool</b>: private server tool.</description></item>
        /// <item><description><b>AdWare</b>: adware.</description></item>
        /// <item><description><b>Maldoc</b>: malicious document.</description></item>
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
