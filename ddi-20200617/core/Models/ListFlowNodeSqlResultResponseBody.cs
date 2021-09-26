// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowNodeSqlResultResponseBody : TeaModel {
        [NameInMap("End")]
        [Validation(Required=false)]
        public bool? End { get; set; }

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
                    [NameInMap("RowItem")]
                    [Validation(Required=false)]
                    public List<string> RowItem { get; set; }

                }
            }
        };

    }

}
