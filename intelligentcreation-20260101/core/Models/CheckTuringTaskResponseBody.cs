// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20260101.Models
{
    public class CheckTuringTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>404</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E8B1746-AE35-5C4B-A3A8-345B274AE32C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CheckTuringTaskResponseBodyResult Result { get; set; }
        public class CheckTuringTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("failCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            [NameInMap("failMsg")]
            [Validation(Required=false)]
            public string FailMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>871509423398305792</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://order-45-1318180738.cos.ap-beijing.myqcloud.com/2025/06/09/1a4837f81c594e7790073f22a43439bf.mp4">http://order-45-1318180738.cos.ap-beijing.myqcloud.com/2025/06/09/1a4837f81c594e7790073f22a43439bf.mp4</a></para>
            /// </summary>
            [NameInMap("videoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
