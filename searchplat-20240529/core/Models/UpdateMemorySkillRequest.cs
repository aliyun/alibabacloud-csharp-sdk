// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class UpdateMemorySkillRequest : TeaModel {
        [NameInMap("agent_id")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("files")]
        [Validation(Required=false)]
        public Dictionary<string, string> Files { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
