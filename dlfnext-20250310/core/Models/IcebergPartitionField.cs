// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class IcebergPartitionField : TeaModel {
        [NameInMap("fieldId")]
        [Validation(Required=false)]
        public long? FieldId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public long? SourceId { get; set; }

        [NameInMap("transform")]
        [Validation(Required=false)]
        public string Transform { get; set; }

    }

}
