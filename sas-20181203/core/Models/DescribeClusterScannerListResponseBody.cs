// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterScannerListResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of clusters that have the scanner installed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstalledCount")]
        [Validation(Required=false)]
        public int? InstalledCount { get; set; }

        /// <summary>
        /// <para>The list of clusters.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeClusterScannerListResponseBodyList> List { get; set; }
        public class DescribeClusterScannerListResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The most recent heartbeat time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1693446913000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>Indicates whether an upgrade is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedUpdate")]
            [Validation(Required=false)]
            public bool? NeedUpdate { get; set; }

            /// <summary>
            /// <para>The scanner status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: running</description></item>
            /// <item><description><b>offline</b>: offline</description></item>
            /// <item><description><b>not_installed</b>: not installed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>offline</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20241111</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>Indicates whether incremental scanning is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WebhookOpen")]
            [Validation(Required=false)]
            public int? WebhookOpen { get; set; }

            /// <summary>
            /// <para>The component status of incremental scanning. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>n</b>: not deployed</description></item>
            /// <item><description><b>y</b>: deployed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>n</para>
            /// </summary>
            [NameInMap("WebhookStatus")]
            [Validation(Required=false)]
            public string WebhookStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11C96623-E106-59C9-866D-A6C82911459F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
