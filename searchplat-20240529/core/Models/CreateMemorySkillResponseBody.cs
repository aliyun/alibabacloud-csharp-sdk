// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class CreateMemorySkillResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateMemorySkillResponseBodyResult Result { get; set; }
        public class CreateMemorySkillResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<CreateMemorySkillResponseBodyResultData> Data { get; set; }
            public class CreateMemorySkillResponseBodyResultData : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("resource_paths")]
                [Validation(Required=false)]
                public List<string> ResourcePaths { get; set; }

                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                [NameInMap("triggers")]
                [Validation(Required=false)]
                public List<string> Triggers { get; set; }

                [NameInMap("updated_at")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("imported_count")]
            [Validation(Required=false)]
            public int? ImportedCount { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
