// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosEventListResponseBody : TeaModel {
        [NameInMap("DdosEventList")]
        [Validation(Required=false)]
        public List<DescribeDdosEventListResponseBodyDdosEventList> DdosEventList { get; set; }
        public class DescribeDdosEventListResponseBodyDdosEventList : TeaModel {
            [NameInMap("DdosType")]
            [Validation(Required=false)]
            public string DdosType { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public long? DelayTime { get; set; }

            [NameInMap("DdosStatus")]
            [Validation(Required=false)]
            public string DdosStatus { get; set; }

            [NameInMap("UnBlackholeTime")]
            [Validation(Required=false)]
            public long? UnBlackholeTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
