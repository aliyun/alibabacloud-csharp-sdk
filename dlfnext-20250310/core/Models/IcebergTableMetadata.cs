// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class IcebergTableMetadata : TeaModel {
        [NameInMap("currentSnapshot")]
        [Validation(Required=false)]
        public IcebergSnapshot CurrentSnapshot { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<IcebergNestedField> Fields { get; set; }

        [NameInMap("identifierFieldIds")]
        [Validation(Required=false)]
        public List<int?> IdentifierFieldIds { get; set; }

        [NameInMap("partitionFields")]
        [Validation(Required=false)]
        public List<IcebergPartitionField> PartitionFields { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, string> Properties { get; set; }

    }

}
