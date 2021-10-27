// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeCustomDataExportSrcDstTablesResponseBody : TeaModel {
        [NameInMap("DataExportSrcDstTables")]
        [Validation(Required=false)]
        public DescribeCustomDataExportSrcDstTablesResponseBodyDataExportSrcDstTables DataExportSrcDstTables { get; set; }
        public class DescribeCustomDataExportSrcDstTablesResponseBodyDataExportSrcDstTables : TeaModel {
            [NameInMap("DstTables")]
            [Validation(Required=false)]
            public DescribeCustomDataExportSrcDstTablesResponseBodyDataExportSrcDstTablesDstTables DstTables { get; set; }
            public class DescribeCustomDataExportSrcDstTablesResponseBodyDataExportSrcDstTablesDstTables : TeaModel {
                [NameInMap("DstTables")]
                [Validation(Required=false)]
                public List<string> DstTables { get; set; }

            }
            [NameInMap("SrcTables")]
            [Validation(Required=false)]
            public DescribeCustomDataExportSrcDstTablesResponseBodyDataExportSrcDstTablesSrcTables SrcTables { get; set; }
            public class DescribeCustomDataExportSrcDstTablesResponseBodyDataExportSrcDstTablesSrcTables : TeaModel {
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
