// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonOverallConfigRequest : TeaModel {
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59.61.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>kdump_switch</b>: Active defense experience optimization</description></item>
        /// <item><description><b>threat_detect</b>: Dynamic adaptive threat detection capability</description></item>
        /// <item><description><b>suspicious_aggregation</b>: Alert Association</description></item>
        /// <item><description><b>alidetect</b>: File Test</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_3277</b>: Suspicious process startup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_5507</b>: malicious drivers</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_38857</b>: Entrance service execution high-risk operation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50858</b>: Web service performs high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50859</b>: Entrance service execution suspicious operation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50861</b>: Information detection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50862</b>: Cloud Assistant Advanced Protection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50867</b>: Create malicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50868</b>: Create suspicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50869</b>: Unauthorized execution of high-risk orders</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50870</b>: Rebound Shell</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50873</b>: WebShell execute command</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50876</b>: Against security software</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50877</b>: Malicious soft communication</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50884</b>: Suspicious worm script behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50885</b>: malicious script behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50983</b>: obfuscated command</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51200</b>: Command line download and run malicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51201</b>: ransomware</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51202</b>: Suspected Extortion</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53168</b>: process debugging</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53272</b>: Exploiting Kernel Vulnerabilities to Elevate Privileges</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54034</b>: Intranet scan</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54265</b>: Hijacking the PAM Module</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54395</b>: Unauthorized reading and writing of sensitive files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54699</b>: Hijack dynamic link library</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54953</b>: Hashdump Attack</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57897</b>: suspected privilege escalation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62981</b>: Bypassing security monitoring</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_64025</b>: Ingress service execute command [enhanced mode]</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_39659</b>: Sensitive Registry Key Protection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51225</b>: Powershell executes high-risk commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51226</b>: Powershell execute suspicious command</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51228</b>: High-risk lateral penetration tools</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51229</b>: Browser service execution a high-risk operation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51230</b>: Entrance service execution suspicious operation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51232</b>: System processes execution high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51233</b>: Java service execution high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51234</b>: Office components execution high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51235</b>: Web service performs high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51236</b>: Rebound shells</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52815</b>: Load high-risk drivers</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52816</b>: high-risk account manipulation behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52818</b>: Information detection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52820</b>: Create malicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52821</b>: Suspicious process startup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52823</b>: Running high-risk ARK tools</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52825</b>: Unauthorized execution of high-risk orders</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52826</b>: Entrance service execution high-risk operation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52827</b>: Ransomware</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52828</b>: Suspected Extortion</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52829</b>: delete system backup behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54168</b>: LSA security permission service protection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54365</b>: Create service autorun item</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54366</b>: Create high-risk autorun item</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54367</b>: Create scheduled task autorun item</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54368</b>: Create registry autorun item</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54369</b>: Create WMI autorun item</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54373</b>: Against security software</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54374</b>: Intrusion trace cleanup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54384</b>: Hashdump Attack</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_55251</b>: Database services execution high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57242</b>: Malicious command execution</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57340</b>: Command line download and run malicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62357</b>: Cloud Assistant service information detection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_63725</b>: Ingress service implants suspicious script/binary file</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kdump_switch</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
