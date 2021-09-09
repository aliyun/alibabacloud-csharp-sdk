// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListPipelineIdsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPipelineIdsResponseBodyResult> Result { get; set; }
        public class ListPipelineIdsResponseBodyResult : TeaModel {
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
