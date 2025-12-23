// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetSortScriptFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCDEFGH</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The content of the sort script.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSortScriptFileResponseBodyResult Result { get; set; }
        public class GetSortScriptFileResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The script content that is encoded in the Base64 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YWJjZGVmZw==</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The time when the script was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-02 20:21:14</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the script was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-02 21:21:14</para>
            /// </summary>
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The version of the script content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
