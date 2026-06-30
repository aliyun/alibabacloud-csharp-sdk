// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetMiningTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code. <b>200</b> indicates success. Any other value indicates failure. Use this field to determine the cause of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Quality inspection task ID.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMiningTaskResultResponseBodyData Data { get; set; }
        public class GetMiningTaskResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>File path</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.22.com/manager/static/login-back.jpg</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>List of returned file paths</para>
            /// </summary>
            [NameInMap("FilePathList")]
            [Validation(Required=false)]
            public List<GetMiningTaskResultResponseBodyDataFilePathList> FilePathList { get; set; }
            public class GetMiningTaskResultResponseBodyDataFilePathList : TeaModel {
                /// <summary>
                /// <para>Generated file type</para>
                /// 
                /// <b>Example:</b>
                /// <para>CSV</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>Generated file URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://vxxxcustomer-pop.oss-cn-shanghai.aliyuncs.com/100.csv">http://vxxxcustomer-pop.oss-cn-shanghai.aliyuncs.com/100.csv</a></para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

            }

            /// <summary>
            /// <para>Markdown file path</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.22.com/manager/static/login-back.md</para>
            /// </summary>
            [NameInMap("FilePathMd")]
            [Validation(Required=false)]
            public string FilePathMd { get; set; }

            /// <summary>
            /// <para>Task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>20201231de3d34ec-40fa-4a55-8d27-76ea*****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Task status</para>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>Details of the error if an error occurs. Otherwise, <b>successful</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. true means success. false or null means failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
