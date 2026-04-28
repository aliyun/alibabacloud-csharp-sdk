// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class UpdateMemorySkillResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateMemorySkillResponseBodyResult Result { get; set; }
        public class UpdateMemorySkillResponseBodyResult : TeaModel {
            [NameInMap("files")]
            [Validation(Required=false)]
            public Dictionary<string, string> Files { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
