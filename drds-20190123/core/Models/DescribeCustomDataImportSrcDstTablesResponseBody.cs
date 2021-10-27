// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeCustomDataImportSrcDstTablesResponseBody : TeaModel {
        [NameInMap("DataImportSrcDstTables")]
        [Validation(Required=false)]
        public DescribeCustomDataImportSrcDstTablesResponseBodyDataImportSrcDstTables DataImportSrcDstTables { get; set; }
        public class DescribeCustomDataImportSrcDstTablesResponseBodyDataImportSrcDstTables : TeaModel {
            [NameInMap("DstTables")]
            [Validation(Required=false)]
            public DescribeCustomDataImportSrcDstTablesResponseBodyDataImportSrcDstTablesDstTables DstTables { get; set; }
            public class DescribeCustomDataImportSrcDstTablesResponseBodyDataImportSrcDstTablesDstTables : TeaModel {
                [NameInMap("DstTables")]
                [Validation(Required=false)]
                public List<string> DstTables { get; set; }

            }
            [NameInMap("SrcTables")]
            [Validation(Required=false)]
            public DescribeCustomDataImportSrcDstTablesResponseBodyDataImportSrcDstTablesSrcTables SrcTables { get; set; }
            public class DescribeCustomDataImportSrcDstTablesResponseBodyDataImportSrcDstTablesSrcTables : TeaModel {
                [NameInMap("SrcTables")]
                [Validation(Required=false)]
                public List<string> SrcTables { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
