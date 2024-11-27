// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DLTable : TeaModel {
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public long? CreatorId { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("LastAccessTime")]
        [Validation(Required=false)]
        public int? LastAccessTime { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("ModifierId")]
        [Validation(Required=false)]
        public long? ModifierId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("PartitionKeys")]
        [Validation(Required=false)]
        public List<DLColumn> PartitionKeys { get; set; }

        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        [NameInMap("StorageDescriptor")]
        [Validation(Required=false)]
        public DLStorageDescriptor StorageDescriptor { get; set; }

        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        [NameInMap("ViewExpandedText")]
        [Validation(Required=false)]
        public string ViewExpandedText { get; set; }

        [NameInMap("ViewOriginalText")]
        [Validation(Required=false)]
        public string ViewOriginalText { get; set; }

    }

}
