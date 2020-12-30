// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetCallMeasureSummaryReportRequest : TeaModel {
        [NameInMap("IntervalType")]
        [Validation(Required=false)]
        public string IntervalType { get; set; }

        [NameInMap("Year")]
        [Validation(Required=false)]
        public int? Year { get; set; }

        [NameInMap("Month")]
        [Validation(Required=false)]
        public int? Month { get; set; }

        [NameInMap("Day")]
        [Validation(Required=false)]
        public int? Day { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
