// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ToolInfo : TeaModel {
        [NameInMap("CAPConfig")]
        [Validation(Required=false)]
        public CAPConfig CAPConfig { get; set; }

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

        [NameInMap("schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("toolType")]
        [Validation(Required=false)]
        public string ToolType { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
