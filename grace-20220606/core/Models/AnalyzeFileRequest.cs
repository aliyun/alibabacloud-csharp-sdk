// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Grace20220606.Models
{
    public class AnalyzeFileRequest : TeaModel {
        [NameInMap("keepUnreachableObjects")]
        [Validation(Required=false)]
        public bool? KeepUnreachableObjects { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
