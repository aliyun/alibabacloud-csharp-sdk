// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescibeImportsFromDatabaseResponseBody : TeaModel {
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescibeImportsFromDatabaseResponseBodyItems Items { get; set; }
        public class DescibeImportsFromDatabaseResponseBodyItems : TeaModel {
            [NameInMap("ImportResultFromDB")]
            [Validation(Required=false)]
            public List<DescibeImportsFromDatabaseResponseBodyItemsImportResultFromDB> ImportResultFromDB { get; set; }
            public class DescibeImportsFromDatabaseResponseBodyItemsImportResultFromDB : TeaModel {
                public string IncrementalImportingTime { get; set; }
                public int? ImportId { get; set; }
                public string ImportDataStatus { get; set; }
                public string ImportDataType { get; set; }
                public string ImportDataStatusDescription { get; set; }
            }
        };

    }

}
