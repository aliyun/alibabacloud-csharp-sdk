// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class DeleteFolderResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>022F36C7-9FB4-5D67-BEBC-3D14B0984463</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response&lt;Map&lt;String, String&gt;&gt;</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DeleteFolderResponseBodyResult Result { get; set; }
        public class DeleteFolderResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>022F36C7-9FB4-5D67-BEBC-3D14B0984463</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The result</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public Dictionary<string, string> Result { get; set; }

        }

    }

}
