// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetSwitchInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetSwitchInfoResponseBodyResult Result { get; set; }
        public class QueryDatasetSwitchInfoResponseBodyResult : TeaModel {
            [NameInMap("CubeId")]
            [Validation(Required=false)]
            public string CubeId { get; set; }
            [NameInMap("IsOpenColumnLevelPermission")]
            [Validation(Required=false)]
            public int? IsOpenColumnLevelPermission { get; set; }
            [NameInMap("IsOpenRowLevelPermission")]
            [Validation(Required=false)]
            public int? IsOpenRowLevelPermission { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
