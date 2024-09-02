// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetScriptFileNamesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The files of the script.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetScriptFileNamesResponseBodyResult> Result { get; set; }
        public class GetScriptFileNamesResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the script file was created.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The name of the script file.
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The time when the script file was last modified.
            /// </summary>
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The path name of the script file.
            /// </summary>
            [NameInMap("pathName")]
            [Validation(Required=false)]
            public string PathName { get; set; }

        }

    }

}
