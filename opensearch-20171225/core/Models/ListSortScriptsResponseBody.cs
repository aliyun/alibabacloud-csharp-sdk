// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListSortScriptsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The scripts.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListSortScriptsResponseBodyResult> Result { get; set; }
        public class ListSortScriptsResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the script was created.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the script was last modified.
            /// </summary>
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The sort phase to which the script applies.
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// The name of the script.
            /// </summary>
            [NameInMap("scriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// The status of the script. Valid values:
            /// 
            /// *   configurable: The script is created, but no script files are uploaded.
            /// *   not compiled: The script is not compiled.
            /// *   compile failed: The compilation of the script failed.
            /// *   compile successful: The script is compiled.
            /// *   released: The script is published.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the script.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
