// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MoveCdsFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution result. The value <c>success</c> indicates that the operation is successful. Otherwise, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is not returned if Code is <c>success</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The result of the move file operation.</para>
        /// </summary>
        [NameInMap("MoveCdsFileModel")]
        [Validation(Required=false)]
        public MoveCdsFileResponseBodyMoveCdsFileModel MoveCdsFileModel { get; set; }
        public class MoveCdsFileResponseBodyMoveCdsFileModel : TeaModel {
            /// <summary>
            /// <para>The asynchronous task ID. This field is not returned when a file is copied. When a folder is copied, the copy operation is performed asynchronously in the background, so this field is returned. You can call <a href="https://help.aliyun.com/document_detail/2357404.html">GetAsyncTask</a> and pass in this asynchronous task ID to obtain the task details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe307518-825a-4c8b-a69c-958f0e8a****</para>
            /// </summary>
            [NameInMap("AsyncTaskId")]
            [Validation(Required=false)]
            public string AsyncTaskId { get; set; }

            /// <summary>
            /// <para>Indicates whether the file already exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Exist")]
            [Validation(Required=false)]
            public bool? Exist { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63636837e47e5a24a8a940218bef395c210e****</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
