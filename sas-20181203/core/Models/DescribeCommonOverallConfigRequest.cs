// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonOverallConfigRequest : TeaModel {
        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59.61.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The configuration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>kdump_switch</b>: proactive defense optimization</description></item>
        /// <item><description><b>threat_detect</b>: adaptive threat detection</description></item>
        /// <item><description><b>suspicious_aggregation</b>: alert association</description></item>
        /// <item><description><b>alidetect</b>: file detection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_3277</b>: suspicious process startup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_5507</b>: malicious driver</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_38857</b>: entry service performing high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50858</b>: web service performing high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50859</b>: entry service performing suspicious operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50861</b>: information probing</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50862</b>: Cloud Assistant advanced protection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50867</b>: malicious file implantation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50868</b>: suspicious file implantation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50869</b>: unauthorized execution of high-risk commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50870</b>: reverse shell</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50873</b>: WebShell command execution</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50876</b>: anti-security software</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50877</b>: malicious program communication</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50884</b>: suspicious worm script behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50885</b>: malicious script behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50983</b>: obfuscated commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51200</b>: downloading and running malicious files from the command line</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51201</b>: ransomware</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51202</b>: suspicious ransomware behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53168</b>: process debugging</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53272</b>: privilege escalation by exploiting kernel vulnerabilities</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54034</b>: internal network scanning</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54265</b>: PAM module hijacking</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54395</b>: unauthorized read/write of sensitive files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54699</b>: dynamic-link library hijacking</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54953</b>: HashDump attack</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57897</b>: suspected privilege escalation behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62981</b>: bypassing security monitoring</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_64025</b>: entry service command execution [enhanced mode]</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_39659</b>: sensitive registry key protection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51225</b>: Powershell executing high-risk commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51226</b>: Powershell executing suspicious commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51228</b>: high-risk lateral movement tools</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51229</b>: browser service performing high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51230</b>: entry service performing suspicious operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51232</b>: system process performing high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51233</b>: Java service performing high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51234</b>: Office component performing high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51235</b>: web service performing high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51236</b>: reverse shell</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52815</b>: loading high-risk drivers</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52816</b>: high-risk account manipulation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52818</b>: information probing</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52820</b>: malicious file implantation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52821</b>: suspicious process startup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52823</b>: running high-risk ARK tools</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52825</b>: unauthorized execution of high-risk commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52826</b>: entry service performing high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52827</b>: ransomware</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52828</b>: suspicious ransomware behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52829</b>: system backup deletion behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54168</b>: LSA security authority service protection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54365</b>: creating service auto-start items</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54366</b>: creating high-risk auto-start items</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54367</b>: creating scheduled task auto-start items</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54368</b>: creating registry auto-start items</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54369</b>: creating WMI auto-start items</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54373</b>: anti-security software</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54374</b>: intrusion trace cleanup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54384</b>: HashDump attack</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_55251</b>: database service performing high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57242</b>: malicious command execution</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57340</b>: downloading and running malicious files from the command line</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62357</b>: Cloud Assistant service information probing</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_63725</b>: entry service implanting suspicious scripts or binary files.</description></item>
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
