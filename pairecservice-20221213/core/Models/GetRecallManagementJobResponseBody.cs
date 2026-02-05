// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetRecallManagementJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;success&quot;</para>
        /// </summary>
        [NameInMap("Log")]
        [Validation(Required=false)]
        public string Log { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecallManagementJobId")]
        [Validation(Required=false)]
        public string RecallManagementJobId { get; set; }

        [NameInMap("RecallManagementTableInfo")]
        [Validation(Required=false)]
        public GetRecallManagementJobResponseBodyRecallManagementTableInfo RecallManagementTableInfo { get; set; }
        public class GetRecallManagementJobResponseBodyRecallManagementTableInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ds=20250701</para>
            /// </summary>
            [NameInMap("DataVersion")]
            [Validation(Required=false)]
            public string DataVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20250101000</para>
            /// </summary>
            [NameInMap("RecallManagementTableVersionId")]
            [Validation(Required=false)]
            public string RecallManagementTableVersionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("SourceTableDataSize")]
            [Validation(Required=false)]
            public string SourceTableDataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SourceTableRowCount")]
            [Validation(Required=false)]
            public string SourceTableRowCount { get; set; }

        }

        [NameInMap("RecallManagerTableInfo")]
        [Validation(Required=false)]
        public GetRecallManagementJobResponseBodyRecallManagerTableInfo RecallManagerTableInfo { get; set; }
        public class GetRecallManagementJobResponseBodyRecallManagerTableInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ds=20250701</para>
            /// </summary>
            [NameInMap("DataVersion")]
            [Validation(Required=false)]
            public string DataVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20250101000</para>
            /// </summary>
            [NameInMap("RecallManagerTableVersionId")]
            [Validation(Required=false)]
            public string RecallManagerTableVersionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("SourceTableDataSize")]
            [Validation(Required=false)]
            public string SourceTableDataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SourceTableRowCount")]
            [Validation(Required=false)]
            public string SourceTableRowCount { get; set; }

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
        /// <para>2021-12-15T22:24:33.132</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
