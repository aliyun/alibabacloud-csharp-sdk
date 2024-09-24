// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspiciousOverallConfigRequest : TeaModel {
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39.161.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto_breaking</b>: Anti-Virus</description></item>
        /// <item><description><b>ransomware_breaking</b>: Anti-ransomware (Bait Capture)</description></item>
        /// <item><description><b>webshell_cloud_breaking</b>: Webshell Protection</description></item>
        /// <item><description><b>alinet</b>: Behavior prevention</description></item>
        /// <item><description><b>k8s_log_analysis</b>: K8s Threat Detection</description></item>
        /// <item><description><b>alisecguard</b>: Defense mode for Client Protection</description></item>
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
