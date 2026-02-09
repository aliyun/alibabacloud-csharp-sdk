// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetSmartClipTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSmartClipTaskResponseBodyData Data { get; set; }
        public class GetSmartClipTaskResponseBodyData : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubJobs")]
            [Validation(Required=false)]
            public List<GetSmartClipTaskResponseBodyDataSubJobs> SubJobs { get; set; }
            public class GetSmartClipTaskResponseBodyDataSubJobs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>x\&quot;x\&quot;x\&quot;x</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("FileAttr")]
                [Validation(Required=false)]
                public GetSmartClipTaskResponseBodyDataSubJobsFileAttr FileAttr { get; set; }
                public class GetSmartClipTaskResponseBodyDataSubJobsFileAttr : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public double? Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>290804</para>
                    /// </summary>
                    [NameInMap("FileLength")]
                    [Validation(Required=false)]
                    public string FileLength { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-12-12.mp4</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1080</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/tmp.mp4">http://www.example.com/tmp.mp4</a></para>
                    /// </summary>
                    [NameInMap("TmpUrl")]
                    [Validation(Required=false)]
                    public string TmpUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1920</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://default/bucket-name/path-xxx/xxx-1.mp4</para>
                /// </summary>
                [NameInMap("FileKey")]
                [Validation(Required=false)]
                public string FileKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("SubJobId")]
                [Validation(Required=false)]
                public string SubJobId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
