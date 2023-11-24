// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateSortScriptResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateSortScriptResponseBodyResult Result { get; set; }
        public class CreateSortScriptResponseBodyResult : TeaModel {
            /// <summary>
            /// 脚本的作用范围
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// 脚本名称
            /// </summary>
            [NameInMap("scriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// 脚本的类型
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
