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
        public DescribeDdosEventListResponseBodyDdosEventList DdosEventList { get; set; }
        public class DescribeDdosEventListResponseBodyDdosEventList : TeaModel {
            [NameInMap("DdosEvent")]
            [Validation(Required=false)]
            public List<DescribeDdosEventListResponseBodyDdosEventListDdosEvent> DdosEvent { get; set; }
            public class DescribeDdosEventListResponseBodyDdosEventListDdosEvent : TeaModel {
                public string DdosStatus { get; set; }
                public string DdosType { get; set; }
                public long? DelayTime { get; set; }
                public long? EndTime { get; set; }
                public long? StartTime { get; set; }
                public long? UnBlackholeTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
