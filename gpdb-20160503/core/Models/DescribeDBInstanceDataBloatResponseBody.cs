// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDataBloatResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceDataBloatResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceDataBloatResponseBodyItems : TeaModel {
            [NameInMap("BloatCeoff")]
            [Validation(Required=false)]
            public string BloatCeoff { get; set; }

            [NameInMap("BloatSize")]
            [Validation(Required=false)]
            public string BloatSize { get; set; }

            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            [NameInMap("ExpectTableSize")]
            [Validation(Required=false)]
            public string ExpectTableSize { get; set; }

            [NameInMap("RealTableSize")]
            [Validation(Required=false)]
            public string RealTableSize { get; set; }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("SuggestedAction")]
            [Validation(Required=false)]
            public string SuggestedAction { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("TimeLastUpdated")]
            [Validation(Required=false)]
            public string TimeLastUpdated { get; set; }

            [NameInMap("TimeLastVacuumed")]
            [Validation(Required=false)]
            public string TimeLastVacuumed { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
