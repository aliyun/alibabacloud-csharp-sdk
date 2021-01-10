// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMsDrmDataCellsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("DrmDataCellInfo")]
        [Validation(Required=false)]
        public ListMsDrmDataCellsResponseBodyDrmDataCellInfo DrmDataCellInfo { get; set; }
        public class ListMsDrmDataCellsResponseBodyDrmDataCellInfo : TeaModel {
            [NameInMap("HasSpecialCell")]
            [Validation(Required=false)]
            public bool? HasSpecialCell { get; set; }
            [NameInMap("CellInfos")]
            [Validation(Required=false)]
            public List<ListMsDrmDataCellsResponseBodyDrmDataCellInfoCellInfos> CellInfos { get; set; }
            public class ListMsDrmDataCellsResponseBodyDrmDataCellInfoCellInfos : TeaModel {
                public string Cell { get; set; }
                public bool? SpecialPush { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
