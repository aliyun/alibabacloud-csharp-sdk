// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class ListDictsResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDictsResponseBodyResult> Result { get; set; }
        public class ListDictsResponseBodyResult : TeaModel {
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
