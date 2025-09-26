// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateToolData : TeaModel {
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
