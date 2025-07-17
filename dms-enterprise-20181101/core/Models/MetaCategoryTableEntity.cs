// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class MetaCategoryTableEntity : TeaModel {
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("DatabaseSearchName")]
        [Validation(Required=false)]
        public string DatabaseSearchName { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public int? InstanceId { get; set; }

        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TableSchemaName")]
        [Validation(Required=false)]
        public string TableSchemaName { get; set; }

    }

}
