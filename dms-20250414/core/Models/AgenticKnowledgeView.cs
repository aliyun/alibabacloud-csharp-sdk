// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticKnowledgeView : TeaModel {
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        [NameInMap("KnowledgeUuid")]
        [Validation(Required=false)]
        public string KnowledgeUuid { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("Locked")]
        [Validation(Required=false)]
        public bool? Locked { get; set; }

        [NameInMap("LockedBy")]
        [Validation(Required=false)]
        public string LockedBy { get; set; }

        [NameInMap("LockedTime")]
        [Validation(Required=false)]
        public long? LockedTime { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UnitCatalogUuid")]
        [Validation(Required=false)]
        public string UnitCatalogUuid { get; set; }

        [NameInMap("UnitDatabaseUuid")]
        [Validation(Required=false)]
        public string UnitDatabaseUuid { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
