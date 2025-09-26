// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class GetCredentialOutput : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, string> Config { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
