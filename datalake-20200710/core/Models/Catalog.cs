// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class Catalog : TeaModel {
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("CatalogType")]
        [Validation(Required=false)]
        public string CatalogType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("DefaultCatalog")]
        [Validation(Required=false)]
        public bool? DefaultCatalog { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("JdbcEnabled")]
        [Validation(Required=false)]
        public bool? JdbcEnabled { get; set; }

        [NameInMap("LocationUri")]
        [Validation(Required=false)]
        public string LocationUri { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StorageAccessConfig")]
        [Validation(Required=false)]
        public string StorageAccessConfig { get; set; }

        [NameInMap("ThriftEnabled")]
        [Validation(Required=false)]
        public bool? ThriftEnabled { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
