// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCommonSwitchConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCommonSwitchConfigResponseBodyData Data { get; set; }
        public class GetCommonSwitchConfigResponseBodyData : TeaModel {
            [NameInMap("TargetDefault")]
            [Validation(Required=false)]
            public string TargetDefault { get; set; }

            [NameInMap("TargetSyncStatus")]
            [Validation(Required=false)]
            public string TargetSyncStatus { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
