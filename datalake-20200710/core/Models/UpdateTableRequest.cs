// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class UpdateTableRequest : TeaModel {
        [NameInMap("AllowPartitionKeyChange")]
        [Validation(Required=false)]
        public bool? AllowPartitionKeyChange { get; set; }

        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("IsAsync")]
        [Validation(Required=false)]
        public bool? IsAsync { get; set; }

        [NameInMap("SkipArchive")]
        [Validation(Required=false)]
        public bool? SkipArchive { get; set; }

        [NameInMap("TableInput")]
        [Validation(Required=false)]
        public TableInput TableInput { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
