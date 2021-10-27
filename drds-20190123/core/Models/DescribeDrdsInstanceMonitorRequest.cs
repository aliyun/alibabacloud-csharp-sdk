// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceMonitorRequest : TeaModel {
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("PeriodMultiple")]
        [Validation(Required=false)]
        public int? PeriodMultiple { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
