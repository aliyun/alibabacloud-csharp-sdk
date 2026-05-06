// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class GetSampleDetailResponseBody : TeaModel {
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
        public GetSampleDetailResponseBodyResultObject ResultObject { get; set; }
        public class GetSampleDetailResponseBodyResultObject : TeaModel {
            [NameInMap("ColumnStats")]
            [Validation(Required=false)]
            public List<GetSampleDetailResponseBodyResultObjectColumnStats> ColumnStats { get; set; }
            public class GetSampleDetailResponseBodyResultObjectColumnStats : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>23</para>
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
            /// <para>month</para>
            /// </summary>
            [NameInMap("DateType")]
            [Validation(Required=false)]
            public string DateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://cas-documents-service.oss-cn-shanghai.aliyuncs.com/Batch_Upload_Monitor_Domain.xlsx?Expires=1753755419&OSSAccessKeyId=****&Signature=">https://cas-documents-service.oss-cn-shanghai.aliyuncs.com/Batch_Upload_Monitor_Domain.xlsx?Expires=1753755419&amp;OSSAccessKeyId=****&amp;Signature=</a>****</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>199</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            [NameInMap("PreviewData")]
            [Validation(Required=false)]
            public GetSampleDetailResponseBodyResultObjectPreviewData PreviewData { get; set; }
            public class GetSampleDetailResponseBodyResultObjectPreviewData : TeaModel {
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public List<string> Headers { get; set; }

                [NameInMap("Rows")]
                [Validation(Required=false)]
                public List<List<string>> Rows { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ios_fb</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>325</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public int? RowCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SampleId")]
            [Validation(Required=false)]
            public int? SampleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SampleTest</para>
            /// </summary>
            [NameInMap("SampleName")]
            [Validation(Required=false)]
            public string SampleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINANCE</para>
            /// </summary>
            [NameInMap("Tab")]
            [Validation(Required=false)]
            public string Tab { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-27 10:23:40</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

            [NameInMap("UploadUserName")]
            [Validation(Required=false)]
            public string UploadUserName { get; set; }

        }

    }

}
