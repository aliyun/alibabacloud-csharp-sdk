// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetMiningTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMiningTaskResultResponseBodyData Data { get; set; }
        public class GetMiningTaskResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123.22.com/manger/static/login-back.jpg</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("FilePathList")]
            [Validation(Required=false)]
            public List<GetMiningTaskResultResponseBodyDataFilePathList> FilePathList { get; set; }
            public class GetMiningTaskResultResponseBodyDataFilePathList : TeaModel {
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123.22.com/manger/static/login-back.md</para>
            /// </summary>
            [NameInMap("FilePathMd")]
            [Validation(Required=false)]
            public string FilePathMd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20201231de3d34ec-40fa-4a55-8d27-76ea*****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24***</para>
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
        public string Success { get; set; }

    }

}
