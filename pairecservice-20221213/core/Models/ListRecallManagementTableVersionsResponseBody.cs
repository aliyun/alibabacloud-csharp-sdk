// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListRecallManagementTableVersionsResponseBody : TeaModel {
        [NameInMap("RecallManagementTableVersions")]
        [Validation(Required=false)]
        public List<ListRecallManagementTableVersionsResponseBodyRecallManagementTableVersions> RecallManagementTableVersions { get; set; }
        public class ListRecallManagementTableVersionsResponseBodyRecallManagementTableVersions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ds=20250701</para>
            /// </summary>
            [NameInMap("DataVersion")]
            [Validation(Required=false)]
            public string DataVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132</para>
            /// </summary>
            [NameInMap("PublishEndTime")]
            [Validation(Required=false)]
            public string PublishEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T22:24:33.132</para>
            /// </summary>
            [NameInMap("PublishStartTime")]
            [Validation(Required=false)]
            public string PublishStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>202507010000</para>
            /// </summary>
            [NameInMap("RecallManagementTableVersionId")]
            [Validation(Required=false)]
            public string RecallManagementTableVersionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("SourceTableDataSize")]
            [Validation(Required=false)]
            public long? SourceTableDataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SourceTableRowCount")]
            [Validation(Required=false)]
            public long? SourceTableRowCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
