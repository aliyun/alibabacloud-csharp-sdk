// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspiciousOverallConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration.</para>
        /// </summary>
        [NameInMap("OverallConfig")]
        [Validation(Required=false)]
        public DescribeSuspiciousOverallConfigResponseBodyOverallConfig OverallConfig { get; set; }
        public class DescribeSuspiciousOverallConfigResponseBodyOverallConfig : TeaModel {
            /// <summary>
            /// <para>The status of the feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>off</b>: disabled</description></item>
            /// <item><description><b>on</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>auto_breaking</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6673D49C-A9AB-40DD-B4A2-B92306701AE7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
