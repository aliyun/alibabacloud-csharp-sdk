// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowNodeSqlResultResponseBody : TeaModel {
        [NameInMap("RowList")]
        [Validation(Required=false)]
        public ListFlowNodeSqlResultResponseBodyRowList RowList { get; set; }
        public class ListFlowNodeSqlResultResponseBodyRowList : TeaModel {
            [NameInMap("Row")]
            [Validation(Required=false)]
            public List<ListFlowNodeSqlResultResponseBodyRowListRow> Row { get; set; }
            public class ListFlowNodeSqlResultResponseBodyRowListRow : TeaModel {
                public int? RowIndex { get; set; }
                public ListFlowNodeSqlResultResponseBodyRowListRowRowItemList RowItemList { get; set; }
                public class ListFlowNodeSqlResultResponseBodyRowListRowRowItemList : TeaModel {
                    [NameInMap("rowItem")]
                    [Validation(Required=false)]
                    public List<string> RowItem { get; set; }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HeaderList")]
        [Validation(Required=false)]
        public ListFlowNodeSqlResultResponseBodyHeaderList HeaderList { get; set; }
        public class ListFlowNodeSqlResultResponseBodyHeaderList : TeaModel {
            [NameInMap("Header")]
            [Validation(Required=false)]
            public List<string> Header { get; set; }
        };

        [NameInMap("End")]
        [Validation(Required=false)]
        public bool? End { get; set; }

    }

}
