// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class CreateMemorySkillRequest : TeaModel {
        [NameInMap("agent_id")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("zip_base64")]
        [Validation(Required=false)]
        public string ZipBase64 { get; set; }

    }

}
