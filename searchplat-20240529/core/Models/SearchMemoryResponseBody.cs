// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class SearchMemoryResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public SearchMemoryResponseBodyResult Result { get; set; }
        public class SearchMemoryResponseBodyResult : TeaModel {
            [NameInMap("memory")]
            [Validation(Required=false)]
            public SearchMemoryResponseBodyResultMemory Memory { get; set; }
            public class SearchMemoryResponseBodyResultMemory : TeaModel {
                [NameInMap("results")]
                [Validation(Required=false)]
                public List<SearchMemoryResponseBodyResultMemoryResults> Results { get; set; }
                public class SearchMemoryResponseBodyResultMemoryResults : TeaModel {
                    [NameInMap("agent_id")]
                    [Validation(Required=false)]
                    public string AgentId { get; set; }

                    [NameInMap("memory")]
                    [Validation(Required=false)]
                    public string Memory { get; set; }

                    [NameInMap("memory_id")]
                    [Validation(Required=false)]
                    public string MemoryId { get; set; }

                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            [NameInMap("skill")]
            [Validation(Required=false)]
            public SearchMemoryResponseBodyResultSkill Skill { get; set; }
            public class SearchMemoryResponseBodyResultSkill : TeaModel {
                [NameInMap("results")]
                [Validation(Required=false)]
                public List<SearchMemoryResponseBodyResultSkillResults> Results { get; set; }
                public class SearchMemoryResponseBodyResultSkillResults : TeaModel {
                    [NameInMap("agent_id")]
                    [Validation(Required=false)]
                    public string AgentId { get; set; }

                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("skill_id")]
                    [Validation(Required=false)]
                    public string SkillId { get; set; }

                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
