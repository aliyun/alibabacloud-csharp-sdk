// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryAllMsDrmLdcCellsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("IsLdc")]
        [Validation(Required=false)]
        public bool? IsLdc { get; set; }

        [NameInMap("OldCells")]
        [Validation(Required=false)]
        public List<string> OldCells { get; set; }

        [NameInMap("NewCells")]
        [Validation(Required=false)]
        public List<QueryAllMsDrmLdcCellsResponseBodyNewCells> NewCells { get; set; }
        public class QueryAllMsDrmLdcCellsResponseBodyNewCells : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
