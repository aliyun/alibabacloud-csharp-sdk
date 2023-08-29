// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class MetaResource : TeaModel {
        [NameInMap("CatalogResource")]
        [Validation(Required=false)]
        public CatalogResource CatalogResource { get; set; }

        [NameInMap("ColumnResource")]
        [Validation(Required=false)]
        public ColumnResource ColumnResource { get; set; }

        [NameInMap("DatabaseResource")]
        [Validation(Required=false)]
        public DatabaseResource DatabaseResource { get; set; }

        [NameInMap("FunctionResource")]
        [Validation(Required=false)]
        public FunctionResource FunctionResource { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("TableResource")]
        [Validation(Required=false)]
        public TableResource TableResource { get; set; }

    }

}
