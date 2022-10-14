// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeTableResponseBody : TeaModel {
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
                [NameInMap("Head")]
                [Validation(Required=false)]
                public List<string> Head { get; set; }

                [NameInMap("TableRows")]
                [Validation(Required=false)]
                public List<RecognizeTableResponseBodyDataTablesTableRows> TableRows { get; set; }
                public class RecognizeTableResponseBodyDataTablesTableRows : TeaModel {
                    [NameInMap("TableColumns")]
                    [Validation(Required=false)]
                    public List<RecognizeTableResponseBodyDataTablesTableRowsTableColumns> TableColumns { get; set; }
                    public class RecognizeTableResponseBodyDataTablesTableRowsTableColumns : TeaModel {
                        [NameInMap("EndColumn")]
                        [Validation(Required=false)]
                        public int? EndColumn { get; set; }

                        [NameInMap("EndRow")]
                        [Validation(Required=false)]
                        public int? EndRow { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        [NameInMap("StartColumn")]
                        [Validation(Required=false)]
                        public int? StartColumn { get; set; }

                        [NameInMap("StartRow")]
                        [Validation(Required=false)]
                        public int? StartRow { get; set; }

                        [NameInMap("Texts")]
                        [Validation(Required=false)]
                        public List<string> Texts { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                    }

                }

                [NameInMap("Tail")]
                [Validation(Required=false)]
                public List<string> Tail { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
