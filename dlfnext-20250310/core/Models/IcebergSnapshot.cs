// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class IcebergSnapshot : TeaModel {
        [NameInMap("addedRows")]
        [Validation(Required=false)]
        public long? AddedRows { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("idString")]
        [Validation(Required=false)]
        public string IdString { get; set; }

        [NameInMap("operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        [NameInMap("parentIdString")]
        [Validation(Required=false)]
        public string ParentIdString { get; set; }

        [NameInMap("schemaId")]
        [Validation(Required=false)]
        public long? SchemaId { get; set; }

        [NameInMap("sequenceNumber")]
        [Validation(Required=false)]
        public long? SequenceNumber { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public Dictionary<string, string> Summary { get; set; }

        [NameInMap("timestampMillis")]
        [Validation(Required=false)]
        public long? TimestampMillis { get; set; }

    }

}
