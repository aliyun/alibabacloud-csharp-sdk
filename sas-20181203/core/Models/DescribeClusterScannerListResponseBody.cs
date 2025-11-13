// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterScannerListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstalledCount")]
        [Validation(Required=false)]
        public int? InstalledCount { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeClusterScannerListResponseBodyList> List { get; set; }
        public class DescribeClusterScannerListResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1693446913000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedUpdate")]
            [Validation(Required=false)]
            public bool? NeedUpdate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>offline</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20241111</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WebhookOpen")]
            [Validation(Required=false)]
            public int? WebhookOpen { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n</para>
            /// </summary>
            [NameInMap("WebhookStatus")]
            [Validation(Required=false)]
            public string WebhookStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11C96623-E106-59C9-866D-A6C82911459F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
