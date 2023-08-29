// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class SingleIndicatorDTO : TeaModel {
        [NameInMap("DayIncrement")]
        [Validation(Required=false)]
        public long? DayIncrement { get; set; }

        [NameInMap("DayOnDay")]
        [Validation(Required=false)]
        public double? DayOnDay { get; set; }

        [NameInMap("MonthIncrement")]
        [Validation(Required=false)]
        public long? MonthIncrement { get; set; }

        [NameInMap("MonthOnMonth")]
        [Validation(Required=false)]
        public double? MonthOnMonth { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
