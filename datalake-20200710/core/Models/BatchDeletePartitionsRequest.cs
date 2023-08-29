// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class BatchDeletePartitionsRequest : TeaModel {
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("IfExists")]
        [Validation(Required=false)]
        public bool? IfExists { get; set; }

        [NameInMap("PartitionValueList")]
        [Validation(Required=false)]
        public List<BatchDeletePartitionsRequestPartitionValueList> PartitionValueList { get; set; }
        public class BatchDeletePartitionsRequestPartitionValueList : TeaModel {
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
