// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListSortScriptsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListSortScriptsResponseBodyResult> Result { get; set; }
        public class ListSortScriptsResponseBodyResult : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("scriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
