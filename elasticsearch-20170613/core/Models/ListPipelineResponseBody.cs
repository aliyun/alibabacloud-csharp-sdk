// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListPipelineResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListPipelineResponseBodyHeaders Headers { get; set; }
        public class ListPipelineResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPipelineResponseBodyResult> Result { get; set; }
        public class ListPipelineResponseBodyResult : TeaModel {
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            [NameInMap("pipelineStatus")]
            [Validation(Required=false)]
            public string PipelineStatus { get; set; }

        }

    }

}
