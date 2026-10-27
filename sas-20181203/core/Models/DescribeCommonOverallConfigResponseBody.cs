// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonOverallConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration information.</para>
        /// </summary>
        [NameInMap("OverallConfig")]
        [Validation(Required=false)]
        public DescribeCommonOverallConfigResponseBodyOverallConfig OverallConfig { get; set; }
        public class DescribeCommonOverallConfigResponseBodyOverallConfig : TeaModel {
            /// <summary>
            /// <para>The switch status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled</description></item>
            /// <item><description><b>off</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>kdump_switch</b>: proactive defense optimization</description></item>
            /// <item><description><b>threat_detect</b>: adaptive threat detection</description></item>
            /// <item><description><b>suspicious_aggregation</b>: associate alerting</description></item>
            /// <item><description><b>alidetect</b>: file detection</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_3277</b>: suspicious process startup</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_5507</b>: malicious driver</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_38857</b>: high-risk operations executed by entry services</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50858</b>: high-risk operations executed by web services</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50859</b>: suspicious operations executed by entry services</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50861</b>: information probing</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50862</b>: Cloud Assistant advanced protection</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50867</b>: malicious file implantation</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50868</b>: suspicious file implantation</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50869</b>: unauthorized execution of high-risk commands</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50870</b>: reverse shell</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50873</b>: webshell command execution</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50876</b>: security software evasion</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50877</b>: malicious program communication</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50884</b>: suspicious worm script behavior</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50885</b>: malicious script behavior</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_50983</b>: obfuscation commands</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51200</b>: downloading and running malicious files via command line</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51201</b>: ransomware virus</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51202</b>: suspicious ransomware behavior</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53168</b>: process debugging</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_53272</b>: privilege escalation by exploiting kernel vulnerabilities</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54034</b>: internal network scanning</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54265</b>: PAM module hijacking</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54395</b>: unauthorized reading and writing of sensitive files</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54699</b>: dynamic-link library hijacking</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54953</b>: HashDump attack</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57897</b>: suspected privilege escalation</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62981</b>: bypassing security monitoring</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_64025</b>: command execution by entry services [Enhanced pattern]</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_39659</b>: sensitive registry key protection</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51225</b>: high-risk command execution by PowerShell</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51226</b>: suspicious command execution by PowerShell</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51228</b>: high-risk lateral movement tools</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51229</b>: high-risk operations executed by browser services</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51230</b>: suspicious operations executed by entry services</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51232</b>: high-risk operations executed by system processes</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51233</b>: high-risk operations executed by Java services</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51234</b>: high-risk operations executed by Office components</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51235</b>: high-risk operations executed by web services</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_51236</b>: reverse shell</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52815</b>: loading high-risk drivers</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52816</b>: high-risk account manipulation</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52818</b>: information probing</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52820</b>: malicious file implantation</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52821</b>: suspicious process startup</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52823</b>: running high-risk ARK tools</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52825</b>: unauthorized execution of high-risk commands</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52826</b>: high-risk operations executed by entry services</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52827</b>: ransomware virus</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52828</b>: suspicious ransomware behavior</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_52829</b>: delete system backup behavior</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54168</b>: LSA security authority service protection</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54365</b>: creating service auto-start items</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54366</b>: creating high-risk auto-start items</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54367</b>: creating scheduled node auto-start items</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54368</b>: creating registry auto-start items</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54369</b>: creating WMI auto-start items</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54373</b>: security software evasion</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54374</b>: intrusion trace cleanup</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_54384</b>: HashDump attack</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_55251</b>: high-risk operations executed by database services</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57242</b>: malicious command execution</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_57340</b>: downloading and running malicious files via command line</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_62357</b>: Cloud Assistant service information probing</description></item>
            /// <item><description><b>USER-ENABLE-SWITCH-TYPE_63725</b>: implantation of suspicious scripts or binary files by entry services</description></item>
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
        /// <para>The ID of the request. This is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D9CDB47-6191-4415-BE63-7E8B12CD4FBE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
