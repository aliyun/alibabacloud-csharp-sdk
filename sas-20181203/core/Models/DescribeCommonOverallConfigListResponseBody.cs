// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonOverallConfigListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the configuration items.</para>
        /// </summary>
        [NameInMap("OverallList")]
        [Validation(Required=false)]
        public List<DescribeCommonOverallConfigListResponseBodyOverallList> OverallList { get; set; }
        public class DescribeCommonOverallConfigListResponseBodyOverallList : TeaModel {
            /// <summary>
            /// <para>The editions of Security Center.</para>
            /// </summary>
            [NameInMap("AuthVersionList")]
            [Validation(Required=false)]
            public List<string> AuthVersionList { get; set; }

            /// <summary>
            /// <para>Indicates the status of the switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>off</b></description></item>
            /// <item><description><b>on</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The total number of entries that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>184</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The type of the configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>kdump_switch</b>: Active defense experience optimization.</description></item>
            /// <item><description><b>threat_detect</b>: Adaptive threat detection.</description></item>
            /// <item><description><b>suspicious_aggregation</b>: Alert association.</description></item>
            /// <item><description><b>alidetect</b>: File detection.</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_38857</b>: Entrance service performs high-risk operations (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50858</b>: Web service performs high-risk operations (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50859</b>: Entrance service performs suspicious operations (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50862</b>: Cloud Assistant advanced protection (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50867</b>: Injects malicious files (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50868</b>: Injects suspicious files (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_64025</b>: Entrance service executes commands in an enhanced mode (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51229</b>: Browser service performs high-risk operations (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51230</b>: Entrance service performs suspicious operations (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51232</b>: System processes perform high-risk operations (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51233</b>: Java service performs high-risk operations (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51234</b>: Office components perform high-risk operations (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51235</b>: Web service performs high-risk operations (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52820</b>: Injects malicious files (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52826</b>: Entrance service performs high-risk operations (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_55251</b>: Database services perform high-risk operations (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_63725</b>: Entrance service injects suspicious scripts or binary files (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_3277</b>: Suspicious process startup (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50983</b>: Obfuscated commands (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51200</b>: Uses command line to download and run malicious files (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_71131</b>: Entrance service executes sequence of suspicious behavior (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51225</b>: Powershell executes high-risk commands (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51226</b>: Powershell executes suspicious commands (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52821</b>: Suspicious process startup (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57242</b>: Malicious command execution (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57340</b>: Uses command line to download and run malicious files (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_39659</b>: Sensitive registry key protection (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52816</b>: High-risk account manipulation behavior (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54365</b>: Creates service auto-startup items (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54366</b>: Creates high-risk auto-startup items (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54367</b>: Creates scheduled task auto-startup items (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54368</b>: Creates registry auto-startup items (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54369</b>: Creates WMI auto-startup items (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50869</b>: Unauthorized execution of high-risk commands (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53272</b>: Exploits kernel vulnerabilities to elevate privileges (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54395</b>: Unauthorized reading and writing of sensitive files (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57897</b>: Suspected privilege escalation (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52825</b>: Unauthorized execution of high-risk commands (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_5507</b>: Malicious drivers (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50876</b>: Uninstalls security software (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53168</b>: Process debugging (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54699</b>: Hijacks dynamic link library (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62981</b>: Bypasses security monitoring (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52815</b>: Loads high-risk drivers (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52823</b>: Runs high-risk anti-rootkit (ARK) tools (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54373</b>: Uninstalls security software (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54374</b>: Intrusion trace cleanup (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54265</b>: Hijacks the pluggable authentication module (PAM) (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54953</b>: Hashdump attack (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54383</b>: MimiKatz credential stealing (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54384</b>: Hashdump attack (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50861</b>: Information detection (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52818</b>: Information detection (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54034</b>: Intranet scan (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51228</b>: High-risk lateral penetration tools (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50870</b>: Rebound shell (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50873</b>: WebShell executes commands.</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51236</b>: Rebound shell (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50877</b>: Malicious program communication (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50884</b>: Suspicious worm script behavior (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50885</b>: Malicious script behavior (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51201</b>: Ransomware (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51202</b>: Suspected extortion (Linux).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52827</b>: Ransomware (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52828</b>: Suspected extortion (Windows).</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52829</b>: Deletes system backup behavior (Windows).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>kdump_switch</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F3B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
