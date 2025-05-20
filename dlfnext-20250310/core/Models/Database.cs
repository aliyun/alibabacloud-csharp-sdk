// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Database : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

    }

}
