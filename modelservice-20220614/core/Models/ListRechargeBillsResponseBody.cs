// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelService20220614.Models
{
    public class ListRechargeBillsResponseBody : TeaModel {
        [NameInMap("InstanseInfos")]
        [Validation(Required=false)]
        public List<ListRechargeBillsResponseBodyInstanseInfos> InstanseInfos { get; set; }
        public class ListRechargeBillsResponseBodyInstanseInfos : TeaModel {
            [NameInMap("CurrTimes")]
            [Validation(Required=false)]
            public int? CurrTimes { get; set; }

            [NameInMap("GmtEndTime")]
            [Validation(Required=false)]
            public string GmtEndTime { get; set; }

            [NameInMap("InitTimes")]
            [Validation(Required=false)]
            public int? InitTimes { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResidueAmount")]
        [Validation(Required=false)]
        public int? ResidueAmount { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
