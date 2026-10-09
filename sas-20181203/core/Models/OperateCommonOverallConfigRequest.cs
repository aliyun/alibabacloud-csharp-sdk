// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateCommonOverallConfigRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure request idempotence. Use a different token for each request. Only ASCII characters are supported. The token can be up to 64 characters in length.</para>
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
        /// <para>Specifies whether to perform only a dry run for this request. Valid values: true: performs only a dry run without executing the actual operation. false: sends the request normally. Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether asset configuration is required. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: required</description></item>
        /// <item><description><b>false</b>: not required<remarks>
        /// <para>This value takes effect only when <b>config</b> is set to <b>on</b>.</para>
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
        /// <item><description><b>suspicious_aggregation</b>: alert correlation</description></item>
        /// <item><description><b>alidetect</b>: file detection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_38857</b>: Linux entry service executes high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50858</b>: Linux web service executes high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50859</b>: Linux entry service executes suspicious operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50862</b>: Linux Cloud Assistant advanced protection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50867</b>: Linux implants malicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50868</b>: Linux implants suspicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_64025</b>: Linux entry service executes commands [enhanced mode]</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51229</b>: Windows browser service executes high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51230</b>: Windows entry service executes suspicious operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51232</b>: Windows system process executes high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51233</b>: Windows Java service executes high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51234</b>: Windows Office component executes high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51235</b>: Windows web service executes high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52820</b>: Windows implants malicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52826</b>: Windows entry service executes high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_55251</b>: Windows database service executes high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_63725</b>: Windows entry service implants suspicious scripts or binary files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_3277</b>: Linux suspicious process startup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50983</b>: Linux obfuscation commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51200</b>: Linux command line downloads and runs malicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_71131</b>: Linux entry service executes suspicious behavior sequences</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51225</b>: Windows PowerShell executes high-risk commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51226</b>: Windows PowerShell executes suspicious commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52821</b>: Windows suspicious process startup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57242</b>: Windows malicious command execution</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57340</b>: Windows command line downloads and runs malicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_39659</b>: Windows sensitive registry key protection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52816</b>: Windows high-risk account manipulation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54365</b>: Windows creates service auto-start entry</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54366</b>: Windows creates high-risk auto-start entry</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54367</b>: Windows creates scheduled task auto-start entry</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54368</b>: Windows creates registry auto-start entry</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54369</b>: Windows creates WMI auto-start entry</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50869</b>: Linux unauthorized execution of high-risk commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53272</b>: Linux privilege escalation via kernel vulnerability</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54395</b>: Linux unauthorized read/write of sensitive files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57897</b>: Linux suspected privilege escalation behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52825</b>: Windows unauthorized execution of high-risk commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_5507</b>: Linux malicious driver</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50876</b>: Linux counters security software</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53168</b>: Linux process debugging</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54699</b>: Linux hijacks dynamic-link library</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62981</b>: Linux bypasses security monitoring</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52815</b>: Windows loads high-risk driver</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52823</b>: Windows runs high-risk ARK tool</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54373</b>: Windows counters security software</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54374</b>: Windows clears intrusion traces</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54265</b>: Linux hijacks PAM module</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54953</b>: Linux HashDump attack</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54383</b>: Windows MimiKatz credential theft</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54384</b>: Windows HashDump attack</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50861</b>: Linux information detection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52818</b>: Windows information detection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54034</b>: Linux internal network scan</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51228</b>: Windows high-risk lateral movement tool</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50870</b>: Linux reverse shell</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50873</b>: WebShell command execution</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51236</b>: Windows reverse shell</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50877</b>: Linux malicious program communication</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50884</b>: Linux suspicious worm script behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50885</b>: Linux malicious script behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51201</b>: Linux ransomware</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51202</b>: Linux suspected ransomware behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52827</b>: Windows ransomware</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52828</b>: Windows suspected ransomware behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52829</b>: Windows deletes system backup</description></item>
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
