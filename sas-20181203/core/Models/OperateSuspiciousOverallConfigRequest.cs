// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateSuspiciousOverallConfigRequest : TeaModel {
        /// <summary>
        /// <para>The switch status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled</description></item>
        /// <item><description><b>off</b>: Disabled</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Specifies the language type for requests and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to configure assets. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes</description></item>
        /// <item><description><b>false</b>: No<remarks>
        /// <para>This value is valid only when <b>config</b> is set to <b>on</b>.</para>
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
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>222.178.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The switch type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto_breaking</b>: Anti-virus</description></item>
        /// <item><description><b>ransomware_breaking</b>: Anti-ransomware (bait capture)</description></item>
        /// <item><description><b>webshell_cloud_breaking</b>: Web shell connection defense</description></item>
        /// <item><description><b>alinet</b>: Malicious network behavior defense</description></item>
        /// <item><description><b>k8s_log_analysis</b>: Container Kubernetes threat detection</description></item>
        /// <item><description><b>alisecguard</b>: Client self-protection defense mode</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s_log_analysis</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
