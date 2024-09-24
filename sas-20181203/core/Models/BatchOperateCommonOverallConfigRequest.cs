// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BatchOperateCommonOverallConfigRequest : TeaModel {
        /// <summary>
        /// <para>The status of the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled</description></item>
        /// <item><description><b>off</b>: disabled</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The type of the feature in proactive defense. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>kdump_switch</b>: Active defense experience optimization</description></item>
        /// <item><description><b>threat_detect</b>: Dynamic adaptive threat detection capability</description></item>
        /// <item><description><b>suspicious_aggregation</b>: Alert Association</description></item>
        /// <item><description><b>alidetect</b>: File Test</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_38857</b>: Entrance service execution high-risk operation (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50858</b>: Web service performs high-risk operations (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50859</b>: Entrance service execution suspicious operation (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50862</b>: Cloud Assistant Advanced Protection (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50867</b>: Create malicious files (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50868</b>: Create suspicious files (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_64025</b>: Ingress service execute command [enhanced mode] (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51229</b>: Browser service execution a high-risk operation (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51230</b>: Entrance service execution suspicious operation (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51232</b>: System processes execution high-risk operations (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51233</b>: Java service execution high-risk operations (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51234</b>: Office components execution high-risk operations (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51235</b>: Web service performs high-risk operations (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52820</b>: Create malicious files (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52826</b>: Entrance service execution high-risk operation (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_55251</b>: Database services execution high-risk operations (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_63725</b>: Ingress service implants suspicious script/binary file (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_3277</b>: Suspicious process startup (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50983</b>: obfuscated command (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51200</b>: Command line download and run malicious files (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_71131</b>: Ingress service executes sequence of suspicious behavior (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51225</b>: Powershell executes high-risk commands (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51226</b>: Powershell execute suspicious command (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52821</b>: Suspicious process startup (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57242</b>: Malicious command execution (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57340</b>: Command line download and run malicious files (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_39659</b>: Sensitive Registry Key Protection (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52816</b>: high-risk account manipulation behavior (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54365</b>: Create service autorun item (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54366</b>: Create high-risk autorun item (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54367</b>: Create scheduled task autorun item (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54368</b>: Create registry autorun item (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54369</b>: Create WMI autorun item (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50869</b>: Unauthorized execution of high-risk orders (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53272</b>: Exploiting Kernel Vulnerabilities to Elevate Privileges (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54395</b>: Unauthorized reading and writing of sensitive files (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57897</b>: suspected privilege escalation (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52825</b>: Unauthorized execution of high-risk orders (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_5507</b>: malicious drivers (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50876</b>: Against security software (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53168</b>: process debugging (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54699</b>: Hijack dynamic link library (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62981</b>: Bypassing security monitoring (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52815</b>: Load high-risk drivers (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52823</b>: Running high-risk ARK tools (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54373</b>: Against security software (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54374</b>: Intrusion trace cleanup (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54265</b>: Hijacking the PAM Module (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54953</b>: Hashdump Attack (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54383</b>: MimiKatz Credential Stealing (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54384</b>: Hashdump Attack (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50861</b>: Information detection (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52818</b>: Information detection (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54034</b>: Intranet scan (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51228</b>: High-risk lateral penetration tools (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50870</b>: Rebound Shell (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50873</b>: WebShell execute command</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51236</b>: Rebound Shell (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50877</b>: Malicious soft communication (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50884</b>: Suspicious worm script behavior (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50885</b>: malicious script behavior (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51201</b>: ransomware (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51202</b>: Suspected Extortion (Linux)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52827</b>: ransomware (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52828</b>: Suspected Extortion (Windows)</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52829</b>: delete system backup behavior (Windows)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public List<string> TypeList { get; set; }

    }

}
