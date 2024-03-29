// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class ListOrderConsumeStatisticRecordsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListOrderConsumeStatisticRecordsResponseBodyItems> Items { get; set; }
        public class ListOrderConsumeStatisticRecordsResponseBodyItems : TeaModel {
            [NameInMap("AliOrderCode")]
            [Validation(Required=false)]
            public string AliOrderCode { get; set; }

            [NameInMap("ApplicationExternalId")]
            [Validation(Required=false)]
            public string ApplicationExternalId { get; set; }

            [NameInMap("ChargedCount")]
            [Validation(Required=false)]
            public long? ChargedCount { get; set; }

            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            [NameInMap("StatisticTime")]
            [Validation(Required=false)]
            public long? StatisticTime { get; set; }

            [NameInMap("TotalPrice")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

            [NameInMap("UnitPrice")]
            [Validation(Required=false)]
            public long? UnitPrice { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public long? TotalElements { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public long? TotalPages { get; set; }

    }

}
