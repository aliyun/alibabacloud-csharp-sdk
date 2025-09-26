// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateToolData : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

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

    }

}
