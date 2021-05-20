// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableRequest : TeaModel {
        [NameInMap("IsView")]
        [Validation(Required=false)]
        public int? IsView { get; set; }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public int? Visibility { get; set; }

        [NameInMap("LifeCycle")]
        [Validation(Required=false)]
        public int? LifeCycle { get; set; }

        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("LogicalLevelId")]
        [Validation(Required=false)]
        public long? LogicalLevelId { get; set; }

        [NameInMap("PhysicsLevelId")]
        [Validation(Required=false)]
        public long? PhysicsLevelId { get; set; }

        [NameInMap("ExternalTableType")]
        [Validation(Required=false)]
        public string ExternalTableType { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        [NameInMap("AppGuid")]
        [Validation(Required=false)]
        public string AppGuid { get; set; }

        [NameInMap("CreateIfNotExists")]
        [Validation(Required=false)]
        public bool? CreateIfNotExists { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("HasPart")]
        [Validation(Required=false)]
        public int? HasPart { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<UpdateTableRequestColumns> Columns { get; set; }
        public class UpdateTableRequestColumns : TeaModel {
            [NameInMap("ColumnNameCn")]
            [Validation(Required=false)]
            public string ColumnNameCn { get; set; }

            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("ColumnType")]
            [Validation(Required=false)]
            public string ColumnType { get; set; }

            [NameInMap("SeqNumber")]
            [Validation(Required=false)]
            public int? SeqNumber { get; set; }

            [NameInMap("Length")]
            [Validation(Required=false)]
            public int? Length { get; set; }

            [NameInMap("IsPartitionCol")]
            [Validation(Required=false)]
            public bool? IsPartitionCol { get; set; }

        }

        [NameInMap("Themes")]
        [Validation(Required=false)]
        public List<UpdateTableRequestThemes> Themes { get; set; }
        public class UpdateTableRequestThemes : TeaModel {
            [NameInMap("ThemeId")]
            [Validation(Required=false)]
            public long? ThemeId { get; set; }

            [NameInMap("ThemeLevel")]
            [Validation(Required=false)]
            public int? ThemeLevel { get; set; }

        }

    }

}
