// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateOpsItemRequest : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DedupString")]
        [Validation(Required=false)]
        public string DedupString { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public string Solutions { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
