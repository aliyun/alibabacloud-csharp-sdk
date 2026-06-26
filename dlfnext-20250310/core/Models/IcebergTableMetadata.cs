// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class IcebergTableMetadata : TeaModel {
        /// <summary>
        /// <para>The latest snapshot of the Iceberg table.</para>
        /// </summary>
        [NameInMap("currentSnapshot")]
        [Validation(Required=false)]
        public IcebergSnapshot CurrentSnapshot { get; set; }

        /// <summary>
        /// <para>The fields.</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<IcebergNestedField> Fields { get; set; }

        [NameInMap("identifierFieldIds")]
        [Validation(Required=false)]
        public List<int?> IdentifierFieldIds { get; set; }

        /// <summary>
        /// <para>The partition fields.</para>
        /// </summary>
        [NameInMap("partitionFields")]
        [Validation(Required=false)]
        public List<IcebergPartitionField> PartitionFields { get; set; }

        /// <summary>
        /// <para>The properties.</para>
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, string> Properties { get; set; }

    }

}
