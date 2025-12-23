// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetScriptFileNamesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCDEFGH</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The files of the script.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetScriptFileNamesResponseBodyResult> Result { get; set; }
        public class GetScriptFileNamesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the script file was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-02 20:21:14</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the script file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_cava_script.cava</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The time when the script file was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-02 21:21:14</para>
            /// </summary>
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The path name of the script file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>src</para>
            /// </summary>
            [NameInMap("pathName")]
            [Validation(Required=false)]
            public string PathName { get; set; }

        }

    }

}
