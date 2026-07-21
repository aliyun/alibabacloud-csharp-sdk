// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CopyCdsFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution result. A value of <c>success</c> indicates success. Otherwise, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result of copying the file.</para>
        /// </summary>
        [NameInMap("CopyCdsFileModel")]
        [Validation(Required=false)]
        public CopyCdsFileResponseBodyCopyCdsFileModel CopyCdsFileModel { get; set; }
        public class CopyCdsFileResponseBodyCopyCdsFileModel : TeaModel {
            /// <summary>
            /// <para>The asynchronous task ID. This field is not returned when a file is copied. When a folder is copied, the copy operation is performed asynchronously in the background, so this field is returned. You can call <a href="https://help.aliyun.com/document_detail/2357404.html">GetAsyncTask</a> and pass in this asynchronous task ID to obtain the task details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4221bf6e6ab43a255edc4463bffa6f5f5d31****</para>
            /// </summary>
            [NameInMap("AsyncTaskId")]
            [Validation(Required=false)]
            public string AsyncTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the new file or folder after the copy operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6400727cb878821bcb414615a609b4072463****</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

        }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93AD30C1-16B8-5C54-AD23-A51FF53F****</para>
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
        public string Success { get; set; }

    }

}
