// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ListSampleResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
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
        public List<ListSampleResponseBodyResultObject> ResultObject { get; set; }
        public class ListSampleResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>File Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202604016426_2_MOB_10W.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>File Size. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>Remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-gw8hs2m7qiiy4onxnjf7x</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Table Row Count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>284</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public int? RowCount { get; set; }

            /// <summary>
            /// <para>Sample ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("SampleId")]
            [Validation(Required=false)]
            public int? SampleId { get; set; }

            /// <summary>
            /// <para>Sample Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEst</para>
            /// </summary>
            [NameInMap("SampleName")]
            [Validation(Required=false)]
            public string SampleName { get; set; }

            /// <summary>
            /// <para>Scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINANCE</para>
            /// </summary>
            [NameInMap("Tab")]
            [Validation(Required=false)]
            public string Tab { get; set; }

            /// <summary>
            /// <para>File Upload Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-09 12:45:23</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

            /// <summary>
            /// <para>Uploader.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mest</para>
            /// </summary>
            [NameInMap("UploadUserName")]
            [Validation(Required=false)]
            public string UploadUserName { get; set; }

        }

        /// <summary>
        /// <para>Total Number of Returned Items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
