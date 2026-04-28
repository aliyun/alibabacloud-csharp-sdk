// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetMemoryTaskResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMemoryTaskResponseBodyResult Result { get; set; }
        public class GetMemoryTaskResponseBodyResult : TeaModel {
            [NameInMap("error_message")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("memory_ids")]
            [Validation(Required=false)]
            public List<string> MemoryIds { get; set; }

            [NameInMap("skill_ids")]
            [Validation(Required=false)]
            public List<string> SkillIds { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
