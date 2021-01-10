// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLDCCellResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Cells")]
        [Validation(Required=false)]
        public List<ListLDCCellResponseBodyCells> Cells { get; set; }
        public class ListLDCCellResponseBodyCells : TeaModel {
            [NameInMap("CellGroup")]
            [Validation(Required=false)]
            public string CellGroup { get; set; }

            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            [NameInMap("Color")]
            [Validation(Required=false)]
            public string Color { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Identity")]
            [Validation(Required=false)]
            public string Identity { get; set; }

            [NameInMap("IsGray")]
            [Validation(Required=false)]
            public bool? IsGray { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PressWeight")]
            [Validation(Required=false)]
            public long? PressWeight { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
