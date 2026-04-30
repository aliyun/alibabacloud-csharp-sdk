// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class TableKnowledgeVO : TeaModel {
        [NameInMap("AssetCreatedGmt")]
        [Validation(Required=false)]
        public string AssetCreatedGmt { get; set; }

        [NameInMap("AssetDescription")]
        [Validation(Required=false)]
        public string AssetDescription { get; set; }

        [NameInMap("AssetModifiedGmt")]
        [Validation(Required=false)]
        public string AssetModifiedGmt { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        [NameInMap("HotLevel")]
        [Validation(Required=false)]
        public int? HotLevel { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public int? InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        [NameInMap("LevelType")]
        [Validation(Required=false)]
        public string LevelType { get; set; }

        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        [NameInMap("NumRows")]
        [Validation(Required=false)]
        public long? NumRows { get; set; }

        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("TableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
