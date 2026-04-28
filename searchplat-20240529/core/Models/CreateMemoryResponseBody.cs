// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class CreateMemoryResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateMemoryResponseBodyResult Result { get; set; }
        public class CreateMemoryResponseBodyResult : TeaModel {
            [NameInMap("memory")]
            [Validation(Required=false)]
            public CreateMemoryResponseBodyResultMemory Memory { get; set; }
            public class CreateMemoryResponseBodyResultMemory : TeaModel {
                [NameInMap("task_id")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            [NameInMap("skill")]
            [Validation(Required=false)]
            public CreateMemoryResponseBodyResultSkill Skill { get; set; }
            public class CreateMemoryResponseBodyResultSkill : TeaModel {
                [NameInMap("task_id")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
