// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateCommonOverallConfigRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Different requests must use different tokens. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The switch status. Valid values:</para>
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
        /// <para>Specifies whether to only precheck the request. Valid values: true: Prechecks the request without performing the actual operation. false: Performs the actual operation.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether assets need to be configured. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: required</description></item>
        /// <item><description><b>false</b>: not required<remarks>
        /// <para>This value is valid only when <b>Config</b> is set to <b>on</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NoTargetAsOn")]
        [Validation(Required=false)]
        public bool? NoTargetAsOn { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.79.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The configuration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>kdump_switch</b>: proactive defense optimization experience</description></item>
        /// <item><description><b>threat_detect</b>: adaptive threat detection capability</description></item>
        /// <item><description><b>suspicious_aggregation</b>: alerting associate</description></item>
        /// <item><description><b>alidetect</b>: file detection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_38857</b>: high-risk operations executed by Linux entry services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50858</b>: high-risk operations executed by Linux web services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50859</b>: suspicious operations executed by Linux entry services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50862</b>: advanced protection for Linux Cloud Assistant</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50867</b>: malicious file implantation in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50868</b>: suspicious file implantation in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_64025</b>: command execution by Linux entry services [enhanced pattern]</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51229</b>: high-risk operations executed by Windows browser services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51230</b>: suspicious operations executed by Windows entry services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51232</b>: high-risk operations executed by Windows system processes</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51233</b>: high-risk operations executed by Windows Java services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51234</b>: high-risk operations executed by Windows Office components</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51235</b>: high-risk operations executed by Windows web services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52820</b>: malicious file implantation in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52826</b>: high-risk operations executed by Windows entry services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_55251</b>: high-risk operations executed by Windows database services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_63725</b>: suspicious script or binary file implantation by Windows entry services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_3277</b>: suspicious process startup in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50983</b>: command obfuscation in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51200</b>: downloading and running malicious files via Linux command line</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_71131</b>: suspicious behavior sequences executed by Linux entry services</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51225</b>: high-risk commands executed by Windows PowerShell</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51226</b>: suspicious commands executed by Windows PowerShell</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52821</b>: suspicious process startup in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57242</b>: malicious command execution in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57340</b>: downloading and running malicious files via Windows command line</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_39659</b>: sensitive registry key protection in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52816</b>: high-risk account manipulation in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54365</b>: creation of service auto-start items in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54366</b>: creation of high-risk auto-start items in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54367</b>: creation of scheduled node auto-start items in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54368</b>: creation of registry auto-start items in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54369</b>: creation of WMI auto-start items in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50869</b>: unauthorized execution of high-risk commands in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53272</b>: privilege escalation by exploiting kernel vulnerabilities in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54395</b>: unauthorized reading and writing of sensitive files in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57897</b>: suspected privilege escalation in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52825</b>: unauthorized execution of high-risk commands in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_5507</b>: malicious drivers in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50876</b>: evasion of security software in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53168</b>: process debugging in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54699</b>: dynamic-link library hijacking in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62981</b>: bypassing security monitoring in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52815</b>: loading of high-risk drivers in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52823</b>: running high-risk ARK tools in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54373</b>: evasion of security software in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54374</b>: clearing intrusion traces in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54265</b>: PAM module hijacking in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54953</b>: HashDump attacks in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54383</b>: credential theft by Mimikatz in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54384</b>: HashDump attacks in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50861</b>: information probing in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52818</b>: information probing in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54034</b>: internal network scanning in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51228</b>: high-risk lateral movement tools in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50870</b>: reverse shells in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50873</b>: command execution by web shells</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51236</b>: reverse shells in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50877</b>: malicious program communication in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50884</b>: suspicious worm script behavior in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50885</b>: malicious script behavior in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51201</b>: ransomware virus in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51202</b>: suspicious ransomware behavior in Linux</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52827</b>: ransomware virus in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52828</b>: suspicious ransomware behavior in Windows</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52829</b>: delete system backups behavior in Windows</description></item>
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
