// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetScriptFileNamesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetScriptFileNamesResponseBodyResult> Result { get; set; }
        public class GetScriptFileNamesResponseBodyResult : TeaModel {
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
