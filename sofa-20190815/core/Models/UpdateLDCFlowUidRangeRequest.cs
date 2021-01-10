// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLDCFlowUidRangeRequest : TeaModel {
        [NameInMap("CellGroup")]
        [Validation(Required=false)]
        public string CellGroup { get; set; }

        [NameInMap("Gray")]
        [Validation(Required=false)]
        public bool? Gray { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("Press")]
        [Validation(Required=false)]
        public bool? Press { get; set; }

        [NameInMap("UidRangesJsonStr")]
        [Validation(Required=false)]
        public string UidRangesJsonStr { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
