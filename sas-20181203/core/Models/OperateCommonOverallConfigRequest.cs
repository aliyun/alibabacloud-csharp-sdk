// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateCommonOverallConfigRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Different requests must use different tokens. The token supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The switch status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
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
        /// <para>Specifies whether asset configuration is required. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Required.</description></item>
        /// <item><description><b>false</b>: Not required.<remarks>
        /// <para>This parameter takes effect only when <b>config</b> is set to <b>on</b>.</para>
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
        /// <item><description><b>kdump_switch</b>: proactive defense optimization</description></item>
        /// <item><description><b>threat_detect</b>: adaptive threat detection capability</description></item>
        /// <item><description><b>suspicious_aggregation</b>: alert associate</description></item>
        /// <item><description><b>alidetect</b>: file detection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_38857</b>: Linux entry service execute high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50858</b>: Linux web service execute high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50859</b>: Linux entry service execute suspicious operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50862</b>: Linux Cloud Assistant advanced protection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50867</b>: Linux malicious file implantation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50868</b>: Linux suspicious file implantation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_64025</b>: Linux entry service execute commands [enhanced mode]</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51229</b>: Windows browser service execute high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51230</b>: Windows entry service execute suspicious operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51232</b>: Windows system process execute high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51233</b>: Windows Java service execute high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51234</b>: Windows Office component execute high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51235</b>: Windows web service execute high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52820</b>: Windows malicious file implantation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52826</b>: Windows entry service execute high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_55251</b>: Windows database service execute high-risk operations</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_63725</b>: Windows entry service implanting suspicious scripts/binary files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_3277</b>: Linux suspicious process startup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50983</b>: Linux obfuscation commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51200</b>: Linux command line downloading and running malicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_71131</b>: Linux entry service execute suspicious behavior sequence</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51225</b>: Windows PowerShell execute high-risk commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51226</b>: Windows PowerShell execute suspicious commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52821</b>: Windows suspicious process startup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57242</b>: Windows malicious command execution</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57340</b>: Windows command line downloading and running malicious files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_39659</b>: Windows sensitive registry key protection</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52816</b>: Windows high-risk account manipulation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54365</b>: Windows creating service auto-start items</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54366</b>: Windows creating high-risk auto-start items</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54367</b>: Windows creating scheduled task auto-start items</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54368</b>: Windows creating registry auto-start items</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54369</b>: Windows creating WMI auto-start items</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50869</b>: Linux privilege escalation execute high-risk commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53272</b>: Linux kernel vulnerability privilege escalation</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54395</b>: Linux privilege escalation reading/writing sensitive files</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57897</b>: Linux suspected privilege escalation behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52825</b>: Windows privilege escalation execute high-risk commands</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_5507</b>: Linux malicious driver</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50876</b>: Linux anti-security software</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53168</b>: Linux process debugging</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54699</b>: Linux dynamic-link library hijacking</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62981</b>: Linux bypassing security monitoring</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52815</b>: Windows loading high-risk drivers</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52823</b>: Windows running high-risk ARK tools</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54373</b>: Windows anti-security software</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54374</b>: Windows intrusion trace cleanup</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54265</b>: Linux PAM module hijacking</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54953</b>: Linux HashDump attack</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54383</b>: Windows MimiKatz credential theft</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54384</b>: Windows HashDump attack</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50861</b>: Linux information reconnaissance</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52818</b>: Windows information reconnaissance</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54034</b>: Linux internal network scanning</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51228</b>: Windows high-risk lateral movement tools</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50870</b>: Linux reverse shell</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50873</b>: WebShell command execution</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51236</b>: Windows reverse shell</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50877</b>: Linux malicious program communication</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50884</b>: Linux suspicious worm script behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50885</b>: Linux malicious script behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51201</b>: Linux ransomware virus</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51202</b>: Linux suspicious ransomware behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52827</b>: Windows ransomware virus</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52828</b>: Windows suspicious ransomware behavior</description></item>
        /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52829</b>: Windows delete system backup behavior</description></item>
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
