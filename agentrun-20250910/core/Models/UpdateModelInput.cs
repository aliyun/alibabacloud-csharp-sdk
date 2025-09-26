// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateModelInput : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("models")]
        [Validation(Required=false)]
        public List<string> Models { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
