// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class UploadForeignSampleFileResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public UploadForeignSampleFileResponseBodyResultObject ResultObject { get; set; }
        public class UploadForeignSampleFileResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BeyondBacktrackingPeriodNum")]
            [Validation(Required=false)]
            public int? BeyondBacktrackingPeriodNum { get; set; }

            [NameInMap("ColumnStats")]
            [Validation(Required=false)]
            public List<UploadForeignSampleFileResponseBodyResultObjectColumnStats> ColumnStats { get; set; }
            public class UploadForeignSampleFileResponseBodyResultObjectColumnStats : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("DistinctNumber")]
                [Validation(Required=false)]
                public int? DistinctNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23.87%</para>
                /// </summary>
                [NameInMap("DistinctRate")]
                [Validation(Required=false)]
                public string DistinctRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>repoName</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MissNumber")]
                [Validation(Required=false)]
                public int? MissNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>25.32%</para>
                /// </summary>
                [NameInMap("MissRate")]
                [Validation(Required=false)]
                public string MissRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RowNumber")]
                [Validation(Required=false)]
                public int? RowNumber { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyyMMdd</para>
            /// </summary>
            [NameInMap("DateType")]
            [Validation(Required=false)]
            public string DateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Acct71b_Sample140934_md5_batch20250916.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>78</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>saf/cpoc/34cd7959590ef568086035b956210495/1760580976089_XN_test_1016_100000.csv</para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            [NameInMap("NotExistScenes")]
            [Validation(Required=false)]
            public List<string> NotExistScenes { get; set; }

            /// <summary>
            /// <para>PhoneInvalidList。</para>
            /// </summary>
            [NameInMap("PhoneInvalidList")]
            [Validation(Required=false)]
            public List<string> PhoneInvalidList { get; set; }

            [NameInMap("PreviewData")]
            [Validation(Required=false)]
            public UploadForeignSampleFileResponseBodyResultObjectPreviewData PreviewData { get; set; }
            public class UploadForeignSampleFileResponseBodyResultObjectPreviewData : TeaModel {
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public List<string> Headers { get; set; }

                [NameInMap("Rows")]
                [Validation(Required=false)]
                public List<List<string>> Rows { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>284</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public int? RowCount { get; set; }

        }

    }

}
