// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AddStoryFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The objects that were added.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<AddStoryFilesResponseBodyFiles> Files { get; set; }
        public class AddStoryFilesResponseBodyFiles : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceNotFound</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified resource %s is not found.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The URI of the object.</para>
            /// <para>The OSS URI follows the <c>oss://{bucketname}/{objectname}</c> format, where <c>bucketname</c> is the name of the bucket in the same region as the current project and <c>objectname</c> is the path of the object with the extension included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E93D6C9-5AC0-49F9-914D-E02678D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
