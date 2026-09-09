// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumDailyBillsByItemRequest : TeaModel {
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("projectNames")]
        [Validation(Required=false)]
        public List<string> ProjectNames { get; set; }

        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        [NameInMap("statsType")]
        [Validation(Required=false)]
        public string StatsType { get; set; }

        [NameInMap("types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
