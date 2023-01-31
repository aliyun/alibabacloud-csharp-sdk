// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcRouteEntrySummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteEntrySummarys")]
        [Validation(Required=false)]
        public List<GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarys> RouteEntrySummarys { get; set; }
        public class GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarys : TeaModel {
            [NameInMap("EntrySummarys")]
            [Validation(Required=false)]
            public List<GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarysEntrySummarys> EntrySummarys { get; set; }
            public class GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarysEntrySummarys : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("RouteEntryType")]
                [Validation(Required=false)]
                public string RouteEntryType { get; set; }

            }

            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
