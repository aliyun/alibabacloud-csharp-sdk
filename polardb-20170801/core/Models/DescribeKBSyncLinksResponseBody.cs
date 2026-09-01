// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKBSyncLinksResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeKBSyncLinksResponseBodyItems> Items { get; set; }
        public class DescribeKBSyncLinksResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cli_xxxxxxbe8</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-08-11T09:55:19Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testDesc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FEISHU</para>
            /// </summary>
            [NameInMap("ImPlatform")]
            [Validation(Required=false)]
            public string ImPlatform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pkbl-xxxxx</para>
            /// </summary>
            [NameInMap("LinkId")]
            [Validation(Required=false)]
            public string LinkId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("LinkName")]
            [Validation(Required=false)]
            public string LinkName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.feishu.cn/wiki/space/xxxxxx">https://example.feishu.cn/wiki/space/xxxxxx</a></para>
            /// </summary>
            [NameInMap("SourceDir")]
            [Validation(Required=false)]
            public string SourceDir { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SyncIntervalMinutes")]
            [Validation(Required=false)]
            public int? SyncIntervalMinutes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("SyncStatus")]
            [Validation(Required=false)]
            public string SyncStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EB07CFF0-D8A4-5C76-AED7-D00E26FC2***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
