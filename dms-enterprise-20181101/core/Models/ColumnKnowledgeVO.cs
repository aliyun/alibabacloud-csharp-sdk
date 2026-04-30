// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ColumnKnowledgeVO : TeaModel {
        [NameInMap("AssetDescription")]
        [Validation(Required=false)]
        public string AssetDescription { get; set; }

        [NameInMap("AssetModifiedGmt")]
        [Validation(Required=false)]
        public string AssetModifiedGmt { get; set; }

        [NameInMap("AutoIncrement")]
        [Validation(Required=false)]
        public bool? AutoIncrement { get; set; }

        [NameInMap("ColumnId")]
        [Validation(Required=false)]
        public long? ColumnId { get; set; }

        [NameInMap("ColumnKeyType")]
        [Validation(Required=false)]
        public string ColumnKeyType { get; set; }

        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        [NameInMap("ColumnType")]
        [Validation(Required=false)]
        public string ColumnType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("HotLevel")]
        [Validation(Required=false)]
        public int? HotLevel { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        [NameInMap("LevelType")]
        [Validation(Required=false)]
        public string LevelType { get; set; }

        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

        [NameInMap("Plain")]
        [Validation(Required=false)]
        public bool? Plain { get; set; }

        [NameInMap("Position")]
        [Validation(Required=false)]
        public int? Position { get; set; }

        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public string SecurityLevel { get; set; }

        [NameInMap("TableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UserSensitivityLevel")]
        [Validation(Required=false)]
        public string UserSensitivityLevel { get; set; }

    }

}
