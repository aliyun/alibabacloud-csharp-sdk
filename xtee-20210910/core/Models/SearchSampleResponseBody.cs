// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class SearchSampleResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        public List<SearchSampleResponseBodyResultObject> ResultObject { get; set; }
        public class SearchSampleResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>File Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>icekredit_model_A_2025c_1755826424_870000.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>File Size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>572</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>Remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ios_velo</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Number of Records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>325</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public int? RowCount { get; set; }

            /// <summary>
            /// <para>Sample ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9b020e69bbae49d88c07a377c3ab7a71</para>
            /// </summary>
            [NameInMap("SampleId")]
            [Validation(Required=false)]
            public int? SampleId { get; set; }

            /// <summary>
            /// <para>Sample Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
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
            /// <para>2023-12-01 12:23:34</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

            /// <summary>
            /// <para>Uploader.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds</para>
            /// </summary>
            [NameInMap("UploadUserName")]
            [Validation(Required=false)]
            public string UploadUserName { get; set; }

        }

    }

}
