// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetMemorySkillResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMemorySkillResponseBodyResult Result { get; set; }
        public class GetMemorySkillResponseBodyResult : TeaModel {
            [NameInMap("agent_id")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("files")]
            [Validation(Required=false)]
            public string Files { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("skill_id")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
