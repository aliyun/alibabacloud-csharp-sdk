// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeTableResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeTableResponseBodyData Data { get; set; }
        public class RecognizeTableResponseBodyData : TeaModel {
            [NameInMap("FileContent")]
            [Validation(Required=false)]
            public string FileContent { get; set; }
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<RecognizeTableResponseBodyDataTables> Tables { get; set; }
            public class RecognizeTableResponseBodyDataTables : TeaModel {
                public List<string> Head { get; set; }
                public List<string> Tail { get; set; }
                public List<RecognizeTableResponseBodyDataTablesTableRows> TableRows { get; set; }
                public class RecognizeTableResponseBodyDataTablesTableRows : TeaModel {
                    public List<RecognizeTableResponseBodyDataTablesTableRowsTableColumns> TableColumns { get; set; }
                    public class RecognizeTableResponseBodyDataTablesTableRowsTableColumns : TeaModel {
                        public int? EndRow { get; set; }
                        public int? EndColumn { get; set; }
                        public int? Width { get; set; }
                        public int? Height { get; set; }
                        public List<string> Texts { get; set; }
                        public int? StartRow { get; set; }
                        public int? StartColumn { get; set; }
                    }
                }
            }
        };

    }

}
