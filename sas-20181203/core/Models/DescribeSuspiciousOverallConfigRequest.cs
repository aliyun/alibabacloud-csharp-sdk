// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspiciousOverallConfigRequest : TeaModel {
        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39.161.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The switch type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto_breaking</b>: anti-virus</description></item>
        /// <item><description><b>ransomware_breaking</b>: anti-ransomware (decoy capture)</description></item>
        /// <item><description><b>webshell_cloud_breaking</b>: web shell connection defense</description></item>
        /// <item><description><b>alinet</b>: malicious network behavior defense</description></item>
        /// <item><description><b>k8s_log_analysis</b>: container Kubernetes threat detection</description></item>
        /// <item><description><b>alisecguard</b>: client self-protection mode</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto_breaking</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
