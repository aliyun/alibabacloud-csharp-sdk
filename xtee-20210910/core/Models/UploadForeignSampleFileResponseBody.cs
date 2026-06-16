// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class UploadForeignSampleFileResponseBody : TeaModel {
        /// <summary>
        /// <para>status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return Result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public UploadForeignSampleFileResponseBodyResultObject ResultObject { get; set; }
        public class UploadForeignSampleFileResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Number of jobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BeyondBacktrackingPeriodNum")]
            [Validation(Required=false)]
            public int? BeyondBacktrackingPeriodNum { get; set; }

            /// <summary>
            /// <para>Column.</para>
            /// </summary>
            [NameInMap("ColumnStats")]
            [Validation(Required=false)]
            public List<UploadForeignSampleFileResponseBodyResultObjectColumnStats> ColumnStats { get; set; }
            public class UploadForeignSampleFileResponseBodyResultObjectColumnStats : TeaModel {
                /// <summary>
                /// <para>De-duplication Count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("DistinctNumber")]
                [Validation(Required=false)]
                public int? DistinctNumber { get; set; }

                /// <summary>
                /// <para>De-duplication rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.87%</para>
                /// </summary>
                [NameInMap("DistinctRate")]
                [Validation(Required=false)]
                public string DistinctRate { get; set; }

                /// <summary>
                /// <para>Field Name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>repoName</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>Missing count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MissNumber")]
                [Validation(Required=false)]
                public int? MissNumber { get; set; }

                /// <summary>
                /// <para>Missing rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25.32%</para>
                /// </summary>
                [NameInMap("MissRate")]
                [Validation(Required=false)]
                public string MissRate { get; set; }

                /// <summary>
                /// <para>Row number of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RowNumber")]
                [Validation(Required=false)]
                public int? RowNumber { get; set; }

            }

            /// <summary>
            /// <para>Time type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yyyyMMdd</para>
            /// </summary>
            [NameInMap("DateType")]
            [Validation(Required=false)]
            public string DateType { get; set; }

            /// <summary>
            /// <para>File name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Acct71b_Sample140934_md5_batch20250916.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>File Size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>File URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>saf/cpoc/34cd7959590ef568086035b956210495/1760580976089_XN_test_1016_100000.csv</para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>Non-existent scenarios.</para>
            /// </summary>
            [NameInMap("NotExistScenes")]
            [Validation(Required=false)]
            public List<string> NotExistScenes { get; set; }

            /// <summary>
            /// <para>PhoneInvalidList.</para>
            /// </summary>
            [NameInMap("PhoneInvalidList")]
            [Validation(Required=false)]
            public List<string> PhoneInvalidList { get; set; }

            /// <summary>
            /// <para>Table data.</para>
            /// </summary>
            [NameInMap("PreviewData")]
            [Validation(Required=false)]
            public UploadForeignSampleFileResponseBodyResultObjectPreviewData PreviewData { get; set; }
            public class UploadForeignSampleFileResponseBodyResultObjectPreviewData : TeaModel {
                /// <summary>
                /// <para>Header information returned.</para>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public List<string> Headers { get; set; }

                /// <summary>
                /// <para>Row data.</para>
                /// </summary>
                [NameInMap("Rows")]
                [Validation(Required=false)]
                public List<List<string>> Rows { get; set; }

            }

            /// <summary>
            /// <para>Number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>284</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public int? RowCount { get; set; }

        }

    }

}
